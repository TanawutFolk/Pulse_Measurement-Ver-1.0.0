Imports System.ComponentModel
Imports System.Threading

Public Class frmLDTempWait
    ' ใช้ BackgroundWorker เพื่อไม่ให้หน้าจอค้าง
    Private WithEvents bgworkerTempCtrl As New BackgroundWorker
    Dim timercount As Integer
    Dim CtrlTemp As Boolean = False

    ' กำหนดค่าความแม่นยำ (Tolerance) ตรงนี้
    Const TempTolerance As Double = 0.1 ' +/- 0.1 องศา

    ' --- ตอนโหลดหน้าจอ ---
    Private Sub frmLDTempWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Visible = True

            ' โชว์ค่า Setpoint ที่ตั้งมาจากหน้า Production
            txtTcset.Text = dblTcSet.ToString("0.00")
            txtTldset.Text = dblTsSet.ToString("0.00")

            ' สถานะเริ่มต้น = แดง (Not Ready)
            pnTcstatus.BackColor = Color.DarkRed
            lblTcStatus.Text = "Tc not Ready"
            pnTldstatus.BackColor = Color.DarkRed
            lblTldStatus.Text = "Ts not Ready"

            ' ตั้งเวลา Timeout 300 วินาที (5 นาที)
            timercount = 300
            tmrCountdown.Interval = 1000
            tmrCountdown.Enabled = True
            tmrCountdown.Start()

            ' ตั้งค่า BackgroundWorker
            bgworkerTempCtrl.WorkerReportsProgress = True
            bgworkerTempCtrl.WorkerSupportsCancellation = True
            bgworkerTempCtrl.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show("Error Load: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    ' --- ปุ่ม Cancel ---
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CtrlTemp = False
        bgworkerTempCtrl.CancelAsync()
        Me.Close()
    End Sub

    ' --- ส่วนทำงานเบื้องหลัง (วนลูปเช็คอุณหภูมิ) ---
    Private Sub bgworkerTempCtrl_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworkerTempCtrl.DoWork
        Dim TcSteady As Boolean = False
        Dim TsSteady As Boolean = False

        Try
            Do
                If bgworkerTempCtrl.CancellationPending Then Exit Do

                ' 1. อ่านค่าอุณหภูมิจากเครื่องมือ (ผ่านตัวแปร Global)
                ' ถ้าอ่านไม่ได้ ให้ข้ามไปก่อน (ไม่ Error)
                clsTc_ILX.ReadGPIB(0, "TEC:T?", dblTc_act)
                clsTs_ILX.ReadGPIB(0, "TEC:T?", dblTs_act)

                ' 2. ตรวจสอบความนิ่ง (เทียบค่าจริง กับ ค่าที่ตั้งไว้)
                TcSteady = (Math.Abs(dblTc_act - dblTcSet) <= TempTolerance)
                TsSteady = (Math.Abs(dblTs_act - dblTsSet) <= TempTolerance)

                ' 3. ส่งผลลัพธ์ไปแสดงหน้าจอ (ReportProgress)
                ' ส่งสถานะ (True/False)
                Dim statusTag As String = ""
                If TcSteady Then statusTag &= "Tc_True," Else statusTag &= "Tc_False,"
                If TsSteady Then statusTag &= "Ts_True," Else statusTag &= "Ts_False,"

                ' ส่งค่าอุณหภูมิปัจจุบัน
                statusTag &= dblTc_act.ToString() & "," & dblTs_act.ToString()

                bgworkerTempCtrl.ReportProgress(1, statusTag)

                ' 4. ถ้าทั้งสองตัวนิ่งแล้ว -> จบการทำงาน (Success)
                If TcSteady And TsSteady Then
                    CtrlTemp = True
                    Thread.Sleep(500) ' รอให้ชัวร์อีกนิด
                    Exit Do
                End If

                Thread.Sleep(500) ' หน่วงเวลา 0.5 วินาที
            Loop
        Catch ex As Exception
            CtrlTemp = False
        End Try
    End Sub

    ' --- อัพเดทหน้าจอ (ทำงานเมื่อ Background ส่งค่ามา) ---
    Private Sub bgworkerTempCtrl_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgworkerTempCtrl.ProgressChanged
        Try
            Dim parts() As String = e.UserState.ToString().Split(","c)
            ' parts(0) = Tc Status
            ' parts(1) = Ts Status
            ' parts(2) = Tc Value
            ' parts(3) = Ts Value

            ' อัพเดทสีสถานะ Tc
            If parts(0) = "Tc_True" Then
                pnTcstatus.BackColor = Color.GreenYellow
                lblTcStatus.Text = "Tc Ready"
            Else
                pnTcstatus.BackColor = Color.DarkRed
                lblTcStatus.Text = "Tc not Ready"
            End If

            ' อัพเดทสีสถานะ Ts
            If parts(1) = "Ts_True" Then
                pnTldstatus.BackColor = Color.GreenYellow
                lblTldStatus.Text = "Ts Ready"
            Else
                pnTldstatus.BackColor = Color.DarkRed
                lblTldStatus.Text = "Ts not Ready"
            End If

            ' อัพเดทตัวเลข
            If parts.Length >= 4 Then
                lblTcactual.Text = Double.Parse(parts(2)).ToString("0.00")
                lblTldactual.Text = Double.Parse(parts(3)).ToString("0.00")
            End If

        Catch ex As Exception
            ' กัน Error เล็กน้อย
        End Try
    End Sub

    ' --- ฟังก์ชันเรียกใช้งาน (Main Entry Point) ---
    Friend Function gfuncTempCtrl() As Boolean
        CtrlTemp = False ' Reset ค่าก่อนเริ่ม
        Me.ShowDialog() ' เปิดหน้าจอค้างไว้

        tmrCountdown.Stop()
        Return CtrlTemp ' คืนค่า True ถ้าอุณหภูมินิ่ง, False ถ้ากด Cancel/Timeout
    End Function

    ' --- เมื่อจบการทำงาน ---
    Private Sub bgworkerTempCtrl_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerTempCtrl.RunWorkerCompleted
        Me.Close()
    End Sub

    ' --- นับถอยหลัง Timeout ---
    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        lbltmr.Text = timercount.ToString()
        If timercount <= 0 Then
            bgworkerTempCtrl.CancelAsync()
            tmrCountdown.Stop()
            MessageBox.Show("Timeout! Temperature is not stable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            timercount -= 1
        End If
    End Sub
End Class

'Imports System.ComponentModel

'Public Class frmLDTempWait
'    Dim dblTempLimit As Double
'    Dim dblGain As Double
'    Dim dblITElim As Double
'    Dim timercount As Integer
'    Dim CtrlTemp As Boolean
'    Private workers As New List(Of BackgroundWorker)

'    Private Sub frmLDTempWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        On Error GoTo ErrRoutine

'        Me.Visible = True

'        txtTcset.Text = dblTcSet
'        txtTldset.Text = dblTsSet

'        pnTcstatus.BackColor = Color.DarkRed
'        lblTcStatus.Text = "Tc not Ready"
'        pnTldstatus.BackColor = Color.DarkRed
'        lblTldStatus.Text = "Ts not Ready"

'        tmrCountdown.Enabled = True
'        tmrCountdown.Interval = 1000
'        timercount = gfuncReadIniFile("TEC Parameter", "TempCTRLTime", iniPrefs)

'Success:
'        tmrCountdown.Start()
'        bgworkerTempCtrl.RunWorkerAsync()
'ErrRoutine:

'    End Sub

'    Private Sub bttCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        CtrlTemp = False
'        bgworkerTempCtrl.CancelAsync()
'        Me.Close()
'    End Sub

'    Private Sub bgworkerTempCtrl_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerTempCtrl.DoWork

'        Dim sw As New System.Diagnostics.Stopwatch()
'        Dim sw2 As New System.Diagnostics.Stopwatch()

'        Dim TimeOutS1 As Integer
'        Dim TimeOutS2 As Integer
'        Dim TcTolerance As Double
'        Dim TsTolerance As Double
'        Dim Tcoffset As Double

'        TimeOutS1 = gfuncReadIniFile("TEC Parameter", "TcTimeOut", iniPrefs)
'        TimeOutS2 = gfuncReadIniFile("TEC Parameter", "TsTimeOut", iniPrefs)
'        TcTolerance = gfuncReadIniFile("TEC Parameter", "TcToler", iniPrefs)
'        TsTolerance = gfuncReadIniFile("TEC Parameter", "TsToler", iniPrefs)
'        Tcoffset = gfuncReadIniFile("TEC Parameter", "Tcoffset", iniPrefs)

'        Dim strTimeOut1 As String = ""
'        Dim intTimeOut1 = TimeOutS1 * 1000
'        Dim strTimeOut2 As String = ""
'        Dim intTimeOut2 = TimeOutS2 * 1000

'        Dim TcSteady As Boolean = False
'        Dim TsSteady As Boolean = False

'        CtrlTemp = False

'        Try
'            sw.Start()
'            sw2.Start()
'            Do
'                'Check temp steady
'                If clsTc_ILX.ReadGPIB(0, "TEC:T?", dblTc_act) = False Then Throw New Exception("")
'                TcSteady = clsTc_ILX.LDTEC_SteadyCheck(dblTcSet, TcTolerance, Tcoffset)
'                If TcSteady = False Then
'                    If sw.ElapsedMilliseconds > intTimeOut1 = True Then 'Timeout?
'                        Throw New Exception("Tc time out!")
'                    Else
'                        bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Tc_False"))
'                    End If
'                Else
'                    TcSteady = True
'                    bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Tc_True"))
'                End If

'                If clsTs_ILX.ReadGPIB(0, "TEC:T?", dblTs_act) = False Then Throw New Exception("")
'                TsSteady = clsTs_ILX.LDTEC_SteadyCheck(dblTsSet, TsTolerance, 0)
'                If TsSteady = False Then
'                    If sw.ElapsedMilliseconds > intTimeOut2 = True Then 'Timeout?
'                        Throw New Exception("Tld time out!")
'                    Else
'                        bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Ts_False"))
'                    End If
'                Else
'                    bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Ts_True"))
'                End If

'                bgworkerTempCtrl.ReportProgress(0, (1 & "," & dblTc_act & "," & dblTs_act))

'                If TcSteady = True And TsSteady = True Then
'                    CtrlTemp = True
'                    Exit Do
'                End If

'            Loop
'        Catch ex As System.Exception
'            bgworkerTempCtrl.CancelAsync()
'            Call gSysLog.LogOut("bgworkerTempCtrl_DoWork," & ex.Message)
'        Finally

'        End Try

'    End Sub

'    Private Sub bgworkerTempCtrl_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerTempCtrl.ProgressChanged
'        Dim state As Object
'        state = e.UserState

'        If state <> "" Then
'            Dim splitstate As String() = state.Split(",")
'            If CType(splitstate(0), Integer) = 1 Then
'                lblTcactual.Text = (CType(splitstate(1), Double)).ToString
'                lblTldactual.Text = (CType(splitstate(2), Double)).ToString
'            ElseIf CType(splitstate(0), Integer) = 0 Then
'                If (CType(splitstate(1), String)).ToString = "Tc_True" Then
'                    pnTcstatus.BackColor = Color.GreenYellow
'                    lblTcStatus.Text = "Tc Ready"
'                ElseIf (CType(splitstate(1), String)).ToString = "Ts_True" Then
'                    pnTldstatus.BackColor = Color.GreenYellow
'                    lblTldStatus.Text = "Ts Ready"
'                ElseIf (CType(splitstate(1), String)).ToString = "Tc_False" Then
'                    pnTcstatus.BackColor = Color.DarkRed
'                    lblTcStatus.Text = "Tc not Ready"
'                ElseIf (CType(splitstate(1), String)).ToString = "Ts_False" Then
'                    pnTldstatus.BackColor = Color.DarkRed
'                    lblTldStatus.Text = "Ts not Ready"
'                End If
'            Else
'                MsgBox("Cannot get temperature data", MsgBoxStyle.Information)
'            End If
'        End If

'    End Sub

'    Friend Function gfuncTempCtrl() As Boolean
'        gfuncTempCtrl = True

'        Try

'            Me.ShowDialog()
'            tmrCountdown.Stop()

'            If CtrlTemp = False Then Throw New Exception("Cancel")

'            Threading.Thread.Sleep(500)

'        Catch ex As System.Exception
'            gfuncTempCtrl = False
'            MsgBox("gfuncTempCtrl," & ex.Message)
'        Finally
'        End Try

'    End Function

'    Private Sub bgworkerTempCtrl_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerTempCtrl.RunWorkerCompleted
'        'CtrlTemp = False
'        Me.Close()
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
'        On Error GoTo Erroutine
'        lbltmr.Text = timercount.ToString()
'        If timercount = 0 Then
'            bgworkerTempCtrl.CancelAsync()
'            MessageBox.Show("Time out!!", "Time Countdown", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Else
'            timercount -= 1
'            GoTo Success
'        End If

'Erroutine:
'        Me.Close()
'Success:

'    End Sub
'End Class