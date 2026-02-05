Imports System.IO
Imports Newtonsoft.Json

Public Class frmPreferance

    '-------------------------------- btnCancle (ปิดหน้าจอ) --------------------------------
    Private Sub CloseAll_Click(sender As Object, e As EventArgs) Handles _
        btnCancle.Click,
        btnCanclepowermea.Click,
        btnCanclevarious.Click,
        btnCanclercable.Click,
        btnCancletec.Click,
        btnCancleccs.Click,
        btnCancleGeneralSet.Click,
        btnCancleOscilloscope.Click

        Me.Close()
    End Sub

    '-------------------------------- btnSave --------------------------------
    Private Sub SaveAll_Click(sender As Object, e As EventArgs) Handles _
            btnSaveGPIBaddress.Click,
            btnSavepowermea.Click,
            btnSavevarious.Click,
            btnSaveRcable.Click,
            btnSaveTEC.Click,
            btnSaveCCS_HPP.Click,
            btnSaveGeneralSet.Click,
            btnSaveOscilloScope.Click
        SaveAllData()
    End Sub

    '-------------------------------- btnSelectParameterFolder --------------------------------
    Private Sub btnSelectparasFolder_Click(sender As Object, e As EventArgs) Handles btnSelectparasFolder.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Parameters (Select a Parameter Folder)"

        If txtParamsFolder.Text <> "" Then dlg.SelectedPath = txtParamsFolder.Text

        If dlg.ShowDialog() = DialogResult.OK Then
            txtParamsFolder.Text = dlg.SelectedPath
        End If
    End Sub

    '-------------------------------- btnSelectDataFolder --------------------------------
    Private Sub btnSelectdataFolder_Click(sender As Object, e As EventArgs) Handles btnSelectdataFolder.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Data (Select a Data Folder)"

        If txtDataFolder.Text <> "" Then dlg.SelectedPath = txtDataFolder.Text

        If dlg.ShowDialog() = DialogResult.OK Then
            txtDataFolder.Text = dlg.SelectedPath
        End If
    End Sub

    '-------------------------------- SaveAllData Function (หัวใจหลัก) --------------------------------
    Private Sub SaveAllData()
        Try
            If GlobalVariables.CurrentProduct = "" Then
                MessageBox.Show("กรุณาเลือกรุ่นสินค้า Product ที่หน้าเมนูหลักก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim data As New PreferanceParameter()

            ' --- Tab 1: GPIB ---
            data.GPIB_address.LDT_5910C_TempControlLD = txtAddress1.Text
            data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz = txtAddress2.Text
            data.GPIB_address.SANTEC_OVA_100_OpticAttenua = txtAddress3.Text
            data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch = txtAddress4.Text
            'data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope = txtDSO_X_4154GOsciloscope.Text
            data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase = txtAddress5.Text
            data.GPIB_address.OFS_1000_TempControlBase = txtAddress6.Text
            data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter = txtAddress7.Text

            ' --- Tab 2: Power Measurement ---
            data.Power_Measurement.LaserStar_comport = CDbl(txtLasercomport.Text)
            data.Power_Measurement.Delaytime = CDbl(txtDelaytime.Text)
            data.Power_Measurement.Average = CDbl(txtAverage.Text)

            ' --- Tab 3: Various Folder ---
            data.VariousKinds_Folders.ParamsFolder = txtParamsFolder.Text
            data.VariousKinds_Folders.DataFolder = txtDataFolder.Text

            ' --- Tab 4: R cable ---
            data.Rcable.Rprobe = CDbl(txtRprobe.Text)
            data.Rcable.Rtec = CDbl(txtRtec.Text)

            ' --- Tab 5: TEC Condition ---
            ' Zone 1
            data.TEC_Condition.Case_Waitmultiply = CDbl(txtCase_WaitFactor.Text)
            data.TEC_Condition.Case_WaitPlus = CDbl(txtCase_WaitBase.Text)
            data.TEC_Condition.Case_Error = CDbl(txtCase_Error.Text)
            ' Zone 2
            data.TEC_Condition.LD_Waitmultiply = CDbl(txtLD_WaitFactor.Text)
            data.TEC_Condition.LD_WaitPlus = CDbl(txtLD_WaitBase.Text)
            data.TEC_Condition.LD_Error = CDbl(txtLD_Error.Text)
            ' Zone 3
            data.TEC_Condition.Det_WaitFactor = CDbl(txtDet_WaitFactor.Text)
            data.TEC_Condition.Det_WaitBase = CDbl(txtDet_WaitBase.Text)
            data.TEC_Condition.Det_Error = CDbl(txtDet_Error.Text)
            data.TEC_Condition.Det_SetTemp = CDbl(txtDet_SetTemp.Text)
            ' Timeout
            data.TEC_Condition.Timeout = CDbl(txtTecTimeout.Text)

            ' Gain (Radio Button)
            If rbGain1.Checked Then data.TEC_Condition.GainValue = 1
            If rbGain3.Checked Then data.TEC_Condition.GainValue = 3
            If rbGain10.Checked Then data.TEC_Condition.GainValue = 10
            If rbGain30.Checked Then data.TEC_Condition.GainValue = 30
            If rbGain100.Checked Then data.TEC_Condition.GainValue = 100
            If rbGain300.Checked Then data.TEC_Condition.GainValue = 300

            ' --- Tab 6: CCS HPP ---
            data.CCS_HPP.MaxAvgCurrent = CDbl(txtMaxAvgCurrent.Text)
            data.CCS_HPP.MaximumCWCurrent = CDbl(txtMaximumCWCurrent.Text)
            data.CCS_HPP.MaxpeakCurrent = CDbl(txtMaxpeakCurrent.Text)
            data.CCS_HPP.Lasermode = cboLasermode.Text
            data.CCS_HPP.duration = cboduration.Text
            data.CCS_HPP.BFMgain = CDbl(txtBFMgain.Text)
            data.CCS_HPP.BFMconvers = CDbl(txtBFMconvers.Text)
            data.CCS_HPP.Comport = txtComport.Text
            data.CCS_HPP.Baudrate = CDbl(txtBaudrate.Text)

            data.Oscilloscope_Setting.Comport = txtComportOCS.Text
            If txtBaudrateOCS.Text.Trim() <> "" AndAlso IsNumeric(txtBaudrateOCS.Text) Then
                data.Oscilloscope_Setting.Baudrate = CDbl(txtBaudrateOCS.Text)
            Else
                data.Oscilloscope_Setting.Baudrate = 9600
            End If

            ' --- Tab 8: General Set ---
            data.General_Setting.DelayTimeOffset = CDbl(txtDelaygeneral.Text)


            ' JSON SAVE
            Dim fileName As String = "Pulse_" & GlobalVariables.CurrentProduct & ".json"

            ' Find Path Folder PRF (From GlobalVariables)
            Dim fullPath As String = Path.Combine(GlobalVariables.GetPRFPath(), fileName)

            ' แปลงเป็น JSON และบันทึกไฟล์
            Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(fullPath, json)

            ' Debug
            Dim debugMsg As String = ""
            debugMsg &= "บันทึกการตั้งค่า (Preference) สำเร็จ!" & vbCrLf & vbCrLf
            'debugMsg &= "รุ่น: " & GlobalVariables.CurrentProduct & vbCrLf
            'debugMsg &= "ชื่อไฟล์: " & fileName & vbCrLf & vbCrLf
            'debugMsg &= "Path เต็ม:" & vbCrLf & fullPath & vbCrLf & vbCrLf
            'debugMsg &= "โฟลเดอร์ PRF:" & vbCrLf & GlobalVariables.GetPRFPath()

            MessageBox.Show(debugMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            Dim msg As String = ""
            msg &= "Error Occurred! / เกิดข้อผิดพลาด!" & vbCrLf
            msg &= "---------------------------------" & vbCrLf
            msg &= "1. Please fill in all numeric fields." & vbCrLf
            msg &= "   (กรุณากรอกตัวเลขให้ครบทุกช่อง ห้ามเว้นว่าง)" & vbCrLf & vbCrLf
            msg &= "2. Do not enter text in numeric fields." & vbCrLf
            msg &= "   (ช่องที่เป็นตัวเลข ห้ามใส่ตัวหนังสือ)" & vbCrLf & vbCrLf
            msg &= "Error Details: " & ex.Message

            MessageBox.Show(msg, "Error / แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-------------------------------- LoadData Function  --------------------------------
    Private Sub LoadData()

        'if ""
        If GlobalVariables.CurrentProduct = "" Then Return

        ' Create file name
        Dim fileName As String = "Pulse_" & GlobalVariables.CurrentProduct & ".json"
        Dim fullPath As String = Path.Combine(GlobalVariables.GetPRFPath(), fileName)

        Dim data As PreferanceParameter

        ' เช็คว่ามีไฟล์นี้จริงไหม
        If File.Exists(fullPath) Then
            Try
                ' 1. อ่านไฟล์
                Dim json As String = File.ReadAllText(fullPath)

                ' 2. แปลงจากข้อความ JSON กลับเป็น Class
                data = JsonConvert.DeserializeObject(Of PreferanceParameter)(json)

            Catch ex As Exception
                MessageBox.Show("โหลดข้อมูลไม่สำเร็จ: " & ex.Message)
                ' ถ้าโหลดไม่สำเร็จ ให้สร้างค่าเริ่มต้นใหม่
                data = New PreferanceParameter()
            End Try
        Else
            ' ถ้ายังไม่มีไฟล์ ให้สร้างค่าเริ่มต้น
            data = New PreferanceParameter()
        End If

        ' 3. เอาค่าใส่ TextBox ทีละช่อง

        ' --- Tab 1: GPIB ---
        txtAddress1.Text = data.GPIB_address.LDT_5910C_TempControlLD
        txtAddress2.Text = data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz
        txtAddress3.Text = data.GPIB_address.SANTEC_OVA_100_OpticAttenua
        txtAddress4.Text = data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch
        'txtDSO_X_4154GOsciloscope.Text = data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope
        txtAddress5.Text = data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase
        txtAddress6.Text = data.GPIB_address.OFS_1000_TempControlBase
        txtAddress7.Text = data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter

        ' --- Tab 2: Power ---
        txtLasercomport.Text = data.Power_Measurement.LaserStar_comport.ToString()
        txtDelaytime.Text = data.Power_Measurement.Delaytime.ToString()
        txtAverage.Text = data.Power_Measurement.Average.ToString()

        ' --- Tab 3: Folders ---
        txtParamsFolder.Text = data.VariousKinds_Folders.ParamsFolder
        txtDataFolder.Text = data.VariousKinds_Folders.DataFolder

        ' --- Tab 4: Cable ---
        txtRprobe.Text = data.Rcable.Rprobe.ToString()
        txtRtec.Text = data.Rcable.Rtec.ToString()

        ' --- Tab 5: TEC ---
        txtCase_WaitFactor.Text = data.TEC_Condition.Case_Waitmultiply.ToString()
        txtCase_WaitBase.Text = data.TEC_Condition.Case_WaitPlus.ToString()
        txtCase_Error.Text = data.TEC_Condition.Case_Error.ToString()

        txtLD_WaitFactor.Text = data.TEC_Condition.LD_Waitmultiply.ToString()
        txtLD_WaitBase.Text = data.TEC_Condition.LD_WaitPlus.ToString()
        txtLD_Error.Text = data.TEC_Condition.LD_Error.ToString()

        txtDet_WaitFactor.Text = data.TEC_Condition.Det_WaitFactor.ToString()
        txtDet_WaitBase.Text = data.TEC_Condition.Det_WaitBase.ToString()
        txtDet_Error.Text = data.TEC_Condition.Det_Error.ToString()
        txtDet_SetTemp.Text = data.TEC_Condition.Det_SetTemp.ToString()

        txtTecTimeout.Text = data.TEC_Condition.Timeout.ToString()

        ' Radio Button (Gain)
        Select Case data.TEC_Condition.GainValue
            Case 1 : rbGain1.Checked = True
            Case 3 : rbGain3.Checked = True
            Case 10 : rbGain10.Checked = True
            Case 30 : rbGain30.Checked = True
            Case 100 : rbGain100.Checked = True
            Case 300 : rbGain300.Checked = True
            Case Else : rbGain1.Checked = True ' ค่าเริ่มต้น
        End Select

        ' --- Tab 6: CCS ---
        txtMaxAvgCurrent.Text = data.CCS_HPP.MaxAvgCurrent.ToString()
        txtMaximumCWCurrent.Text = data.CCS_HPP.MaximumCWCurrent.ToString()
        txtMaxpeakCurrent.Text = data.CCS_HPP.MaxpeakCurrent.ToString()
        cboLasermode.Text = data.CCS_HPP.Lasermode
        cboduration.Text = data.CCS_HPP.duration
        txtBFMgain.Text = data.CCS_HPP.BFMgain.ToString()
        txtBFMconvers.Text = data.CCS_HPP.BFMconvers.ToString()
        txtComport.Text = data.CCS_HPP.Comport
        txtBaudrate.Text = data.CCS_HPP.Baudrate.ToString()

        ' --- Tab 7: General ---
        txtDelaygeneral.Text = data.General_Setting.DelayTimeOffset.ToString()

        ' --- Tab 8: Oscilloscope ---
        txtComportOCS.Text = data.Oscilloscope_Setting.Comport
        txtBaudrateOCS.Text = data.Oscilloscope_Setting.Baudrate.ToString()
    End Sub

    Private Sub frmPreferance_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' ตั้งค่า Dropdown เริ่มต้น
        cboLasermode.Items.Clear()
        cboLasermode.Items.Add("ACC")
        cboLasermode.Items.Add("APC")

        cboduration.Items.Clear()
        cboduration.Items.Add("int")
        cboduration.Items.Add("int")


        LoadData()
    End Sub

    '----------- Connect All Devices -----------------
    'Public Sub ConnectDevices()

    '    Dim gpibBoxes As TextBox() = {txtAddress1, txtAddress2, txtAddress3, txtAddress4, txtAddress5, txtAddress6, txtAddress7}

    '    Try
    '        ' GPIB -----
    '        For i As Integer = 0 To gpibBoxes.Length - 1
    '            Dim addr As String = gpibBoxes(i).Text.Trim()

    '            If Not String.IsNullOrEmpty(addr) Then
    '                Try
    '                    'Connection String
    '                    Dim connStr As String = "GPIB0::" & addr & "::INSTR"
    '                    Dim instr As MessageBasedSession = rm.Open(connStr)
    '                    instr.TimeoutMilliseconds = 5000 ' ตั้งเวลา TimeOut

    '                    'Mapping
    '                    Select Case i
    '                        Case 0 : instrument1 = instr ' LDT-5910C
    '                        Case 1 : instrument2 = instr ' YOKOGAWA OSA
    '                        Case 2 : instrument3 = instr ' SANTEC
    '                        Case 3 : instrument4 = instr ' AQ2211
    '                        Case 4 : instrument5 = instr ' FUKKO
    '                        Case 5 : instrument6 = instr ' OFS
    '                        Case 6 : instrument7 = instr ' KEYSIGHT 34416A
    '                    End Select

    '                Catch ex As Exception
    '                    MessageBox.Show($"GPIB Address {addr} Error: " & ex.Message)
    '                End Try
    '            End If
    '        Next

    '        'USB CCS-HPP
    '        Try
    '            ' ดึงค่าจากช่อง Comport (สมมติว่าชื่อ txtComportCCS) 
    '            ' ค่าในช่องคือ "Comport3" เราต้องตัดคำว่า "Comport" ออกให้เหลือเลข "3"
    '            Dim portName As String = txtComport.Text ' ได้ค่า "Comport3"
    '            Dim portNum As String = portName.Replace("Comport", "").Trim() ' เหลือ "3"

    '            ' สร้าง Address แบบ Serial (ASRL)
    '            Dim ccsAddress As String = "ASRL" & portNum & "::INSTR" ' ผลลัพธ์: ASRL3::INSTR

    '            usbIntrument1 = rm.Open(ccsAddress)
    '            usbIntrument1.TimeoutMilliseconds = 5000
    '            ' บางครั้ง Serial ต้องเปิด Termination Character (เช็คคู่มือ CCS อีกทีครับ)
    '            ' usbIntrument1.TerminationCharacterEnabled = True 

    '        Catch ex As Exception
    '            MessageBox.Show("CCS-HPP (USB/Serial) Connect Error: " & ex.Message)
    '        End Try

    '        ' ==================================================
    '        ' PART 3: เชื่อมต่อ USB ตัวที่ 2 (Oscilloscope) -> แบบ USB แท้
    '        ' ==================================================
    '        Try
    '            ' Oscilloscope ส่วนใหญ่ Address จะยาวมากและไม่ค่อยเปลี่ยน
    '            ' แนะนำให้ Hardcode ค่าที่ได้จาก NI MAX ใส่ลงไปเลยครับ
    '            Dim scopeAddress As String = "USB0::0x0957::0x1796::MY5000000::0::INSTR" ' <--- แก้ตรงนี้ให้ตรงกับใน NI MAX

    '            usbIntrument2 = rm.Open(scopeAddress)
    '            usbIntrument2.TimeoutMilliseconds = 5000

    '            ' สั่ง Reset Scope สักทีเพื่อความชัวร์ (ถ้าต้องการ)
    '            ' usbIntrument2.RawIO.Write("*RST")

    '        Catch ex As Exception
    '            MessageBox.Show("Oscilloscope (USB) Connect Error: " & ex.Message)
    '        End Try

    '        MessageBox.Show("การเชื่อมต่อเสร็จสมบูรณ์!")

    '    Catch ex As Exception
    '        MessageBox.Show("System Critical Error: " & ex.Message)
    '    End Try

    '    'Dim gpibBoxes As TextBox() = {txtAddress1, txtAddress2, txtAddress3, txtAddress4, txtAddress5, txtAddress6}
    '    'Dim instruments As New List(Of ImessageBasedSession)

    '    'Try
    '    '    'GPIB
    '    '    For i As Integer = 0 To gpibBoxes.Length - 1
    '    '        Dim addr As String = gpibBoxes(i).Text
    '    '        If Not String.IsNullOrEmpty(addr) Then
    '    '            Try
    '    '                Dim instr = CType(rm.open("GPIB0::" & addr & "::INSTR"), IMessageBasedSession)
    '    '                instr.TimeOutMilliseconds = 5000

    '    '                ' *IDN = Identification
    '    '                instr.RawIO.Write("*IDN?")
    '    '                Dim idn As String = instr.RawIO.ReadString()

    '    '                instruments.Add(instr)
    '    '                Console.WriteLine($"GPIB Address {addr} Connected: {idn}")
    '    '            Catch ex As Exception
    '    '                MessageBox.Show($" GPIB {i + 1} (Addr: {addr}) Error Connect !!!  " & ex.Message)

    '    '            End Try
    '    '        End If
    '    '    Next
    '    '    'USB(CCS-HPP, OCS)
    '    '    Dim usbAddresses As String() = {
    '    '        "USB0::0x0123::0x4567::SN12345::0::INSTR",
    '    '        "USB0::0x0987::0x6543::SN67890::0::INSTR"
    '    '    }

    '    '    For Each usbAddr In usbAddresses
    '    '        Try
    '    '            Dim usbInstr = CType(.rm.open(usbAddr), IMessageBasedSession)
    '    '            usbInstr.TimeoutMilliseconds = 5000
    '    '            intruments.Add(usbInstr)
    '    '        Catch ex As Exception
    '    '            MessageBox.Show($"USB Device {usbAddr} Can not Connect!!!")
    '    '        End Try
    '    '    Next
    '    '    MessageBox.Show($"Connected  {instruments.Count} Devices ♥♥♥")
    '    'Catch ex As Exception
    '    '    MessageBox.Show("Error pls Contact Production !!!" & ex.Message)
    '    'End Try


    '    'Try
    '    '    'Todo: กี่เครื่องไม่รุ้ตอนนี้ 
    '    '    instrument1 = rm.Open("GPIB0::" & txtAddress1.Text & "::INSTR")
    '    '    instrument1.TimeoutMilliseconds = 5000


    '    '    instrument2 = rm.Open("GPIB0::" & txtAddress2.Text & "::INSTR")
    '    '    instrument2.TimeoutMilliseconds = 5000

    '    '    instrument3 = rm.Open("GPIB0::" & txtAddress3.Text & "::INSTR")
    '    '    instrument3.TimeoutMilliseconds = 5000

    '    '    instrument4 = rm.Open("GPIB0::" & txtAddress4.Text & "::INSTR")
    '    '    instrument4.TimeoutMilliseconds = 5000

    '    '    instrument5 = rm.Open("GPIB0::" & txtAddress5.Text & "::INSTR")
    '    '    instrument5.TimeoutMilliseconds = 5000

    '    '    instrument6 = rm.Open("GPIB0::" & txtAddress6.Text & "::INSTR")
    '    '    instrument6.TimeoutMilliseconds = 5000

    '    '    'Todo: พี่ย้งบอกมี 2 เครื่องเป็น USB CCS-HHP, keysight oscilloscope
    '    '    usbInstrument1 = rm.Open("USB0::0x0123::0x4567::SN12345::0::INSTR")
    '    '    usbIntrument1.TimeoutMillisecond = 5000
    '    '    usbInstrument2 = rm.Open("USB0::0x0987::0x6543::SN67890::0::INSTR")
    '    '    usbIntrument2.TimeoutMillisecond = 5000

    '    '    MessageBox.Show("Connected All Devices ♥ ")
    '    'Catch ex As Exception
    '    '    MessageBox.Show("Connect Error !!!!!" & ex.Message)
    '    'End Try
    'End Sub
End Class