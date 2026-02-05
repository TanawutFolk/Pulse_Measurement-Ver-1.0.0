Imports System.ComponentModel

Public Class frmLDTempWait
    Dim dblTempLimit As Double
    Dim dblGain As Double
    Dim dblITElim As Double
    Dim timercount As Integer
    Dim CtrlTemp As Boolean
    Private workers As New List(Of BackgroundWorker)

    Private Sub frmLDTempWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error GoTo ErrRoutine

        Me.Visible = True

        txtTcset.Text = dblTcSet
        txtTldset.Text = dblTsSet

        pnTcstatus.BackColor = Color.DarkRed
        lblTcStatus.Text = "Tc not Ready"
        pnTldstatus.BackColor = Color.DarkRed
        lblTldStatus.Text = "Ts not Ready"

        tmrCountdown.Enabled = True
        tmrCountdown.Interval = 1000
        timercount = gfuncReadIniFile("TEC Parameter", "TempCTRLTime", iniPrefs)

Success:
        tmrCountdown.Start()
        bgworkerTempCtrl.RunWorkerAsync()
ErrRoutine:

    End Sub

    Private Sub bttCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CtrlTemp = False
        bgworkerTempCtrl.CancelAsync()
        Me.Close()
    End Sub

    Private Sub bgworkerTempCtrl_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgworkerTempCtrl.DoWork

        Dim sw As New System.Diagnostics.Stopwatch()
        Dim sw2 As New System.Diagnostics.Stopwatch()

        Dim TimeOutS1 As Integer
        Dim TimeOutS2 As Integer
        Dim TcTolerance As Double
        Dim TsTolerance As Double
        Dim Tcoffset As Double

        TimeOutS1 = gfuncReadIniFile("TEC Parameter", "TcTimeOut", iniPrefs)
        TimeOutS2 = gfuncReadIniFile("TEC Parameter", "TsTimeOut", iniPrefs)
        TcTolerance = gfuncReadIniFile("TEC Parameter", "TcToler", iniPrefs)
        TsTolerance = gfuncReadIniFile("TEC Parameter", "TsToler", iniPrefs)
        Tcoffset = gfuncReadIniFile("TEC Parameter", "Tcoffset", iniPrefs)

        Dim strTimeOut1 As String = ""
        Dim intTimeOut1 = TimeOutS1 * 1000
        Dim strTimeOut2 As String = ""
        Dim intTimeOut2 = TimeOutS2 * 1000

        Dim TcSteady As Boolean = False
        Dim TsSteady As Boolean = False

        CtrlTemp = False

        Try
            sw.Start()
            sw2.Start()
            Do
                'Check temp steady
                If clsTc_ILX.ReadGPIB(0, "TEC:T?", dblTc_act) = False Then Throw New Exception("")
                TcSteady = clsTc_ILX.LDTEC_SteadyCheck(dblTcSet, TcTolerance, Tcoffset)
                If TcSteady = False Then
                    If sw.ElapsedMilliseconds > intTimeOut1 = True Then 'Timeout?
                        Throw New Exception("Tc time out!")
                    Else
                        bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Tc_False"))
                    End If
                Else
                    TcSteady = True
                    bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Tc_True"))
                End If

                If clsTs_ILX.ReadGPIB(0, "TEC:T?", dblTs_act) = False Then Throw New Exception("")
                TsSteady = clsTs_ILX.LDTEC_SteadyCheck(dblTsSet, TsTolerance, 0)
                If TsSteady = False Then
                    If sw.ElapsedMilliseconds > intTimeOut2 = True Then 'Timeout?
                        Throw New Exception("Tld time out!")
                    Else
                        bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Ts_False"))
                    End If
                Else
                    bgworkerTempCtrl.ReportProgress(0, (0 & "," & "Ts_True"))
                End If

                bgworkerTempCtrl.ReportProgress(0, (1 & "," & dblTc_act & "," & dblTs_act))

                If TcSteady = True And TsSteady = True Then
                    CtrlTemp = True
                    Exit Do
                End If

            Loop
        Catch ex As System.Exception
            bgworkerTempCtrl.CancelAsync()
            Call gSysLog.LogOut("bgworkerTempCtrl_DoWork," & ex.Message)
        Finally

        End Try

    End Sub

    Private Sub bgworkerTempCtrl_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworkerTempCtrl.ProgressChanged
        Dim state As Object
        state = e.UserState

        If state <> "" Then
            Dim splitstate As String() = state.Split(",")
            If CType(splitstate(0), Integer) = 1 Then
                lblTcactual.Text = (CType(splitstate(1), Double)).ToString
                lblTldactual.Text = (CType(splitstate(2), Double)).ToString
            ElseIf CType(splitstate(0), Integer) = 0 Then
                If (CType(splitstate(1), String)).ToString = "Tc_True" Then
                    pnTcstatus.BackColor = Color.GreenYellow
                    lblTcStatus.Text = "Tc Ready"
                ElseIf (CType(splitstate(1), String)).ToString = "Ts_True" Then
                    pnTldstatus.BackColor = Color.GreenYellow
                    lblTldStatus.Text = "Ts Ready"
                ElseIf (CType(splitstate(1), String)).ToString = "Tc_False" Then
                    pnTcstatus.BackColor = Color.DarkRed
                    lblTcStatus.Text = "Tc not Ready"
                ElseIf (CType(splitstate(1), String)).ToString = "Ts_False" Then
                    pnTldstatus.BackColor = Color.DarkRed
                    lblTldStatus.Text = "Ts not Ready"
                End If
            Else
                MsgBox("Cannot get temperature data", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Friend Function gfuncTempCtrl() As Boolean
        gfuncTempCtrl = True

        Try

            Me.ShowDialog()
            tmrCountdown.Stop()

            If CtrlTemp = False Then Throw New Exception("Cancel")

            Threading.Thread.Sleep(500)

        Catch ex As System.Exception
            gfuncTempCtrl = False
            MsgBox("gfuncTempCtrl," & ex.Message)
        Finally
        End Try

    End Function

    Private Sub bgworkerTempCtrl_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworkerTempCtrl.RunWorkerCompleted
        'CtrlTemp = False
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        On Error GoTo Erroutine
        lbltmr.Text = timercount.ToString()
        If timercount = 0 Then
            bgworkerTempCtrl.CancelAsync()
            MessageBox.Show("Time out!!", "Time Countdown", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            timercount -= 1
            GoTo Success
        End If

Erroutine:
        Me.Close()
Success:

    End Sub
End Class