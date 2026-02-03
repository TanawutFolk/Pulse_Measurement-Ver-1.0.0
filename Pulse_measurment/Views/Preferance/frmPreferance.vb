Imports Newtonsoft.Json
Imports System.IO

Public Class frmPreferance

    '-------------------------------- btnCancle (ปิดหน้าจอ) --------------------------------
    Private Sub CloseAll_Click(sender As Object, e As EventArgs) Handles _
        btnCancle.Click,
        btnCanclepowermea.Click,
        btnCanclevarious.Click,
        btnCanclercable.Click,
        btnCancletec.Click,
        btnCancleccs.Click,
        btnCancleGeneralSet.Click

        Me.Close()
    End Sub

    '-------------------------------- btnSave (ปุ่มบันทึก) --------------------------------
    Private Sub SaveAll_Click(sender As Object, e As EventArgs) Handles _
            btnSaveGPIBaddress.Click,
            btnSavepowermea.Click,
            btnSavevarious.Click,
            btnSaveRcable.Click,
            btnSaveTEC.Click,
            btnSaveCCS_HPP.Click,
            btnSaveGeneralSet.Click
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
            ' 1. ตรวจสอบก่อนว่า User เลือก Product หรือยัง (จากหน้า Main Menu)
            If GlobalVariables.CurrentProduct = "" Then
                MessageBox.Show("กรุณาเลือกรุ่นสินค้า (Product) ที่หน้าเมนูหลักก่อนครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim data As New PreferanceConfig()

            ' --- Tab 1: GPIB ---
            data.GPIB_address.LDT_5910C_TempControlLD = txtLDT_5910CTempControlLD.Text
            data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz = txtAQ6370D_OpticspAnalyz.Text
            data.GPIB_address.SANTEC_OVA_100_OpticAttenua = txtOVA_100_OpticAttenua.Text
            data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch = txtAQ2211_Opticswich.Text
            data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope = txtDSO_X_4154GOsciloscope.Text
            data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase = txtSYSTEMAT_845TempControlBase.Text
            data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter = txtKey34416A_Digitlmultimeter.Text

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

            ' --- Tab 7: General Set ---
            data.General_Setting.DelayTimeOffset = CDbl(txtDelaygeneral.Text)

            ' -------------------------------------------------------------
            ' ส่วนที่แก้ไข: สร้างชื่อไฟล์ตามรุ่น Product และเซฟลง PRF Folder
            ' -------------------------------------------------------------
            ' ชื่อไฟล์ = Pulse_รุ่น.json
            Dim fileName As String = "Pulse_" & GlobalVariables.CurrentProduct & ".json"

            ' หา Path ของโฟลเดอร์ PRF (ใช้ฟังก์ชันจาก GlobalVariables)
            Dim fullPath As String = Path.Combine(GlobalVariables.GetPRFPath(), fileName)

            ' แปลงเป็น JSON และบันทึกไฟล์
            Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(fullPath, json)

            MessageBox.Show("บันทึกการตั้งค่า (Preference) สำหรับรุ่น " & GlobalVariables.CurrentProduct & " เรียบร้อยแล้วที่:" & vbCrLf & fullPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    '-------------------------------- LoadData Function (หัวใจหลัก) --------------------------------
    Private Sub LoadData()
        ' ถ้ายังไม่เลือก Product ก็ไม่ต้องโหลด
        If GlobalVariables.CurrentProduct = "" Then Return

        ' สร้างชื่อไฟล์ที่ต้องการโหลด: Pulse_รุ่น.json
        Dim fileName As String = "Pulse_" & GlobalVariables.CurrentProduct & ".json"
        Dim fullPath As String = Path.Combine(GlobalVariables.GetPRFPath(), fileName)

        ' เช็คว่ามีไฟล์นี้จริงไหม
        If File.Exists(fullPath) Then
            Try
                ' 1. อ่านไฟล์
                Dim json As String = File.ReadAllText(fullPath)

                ' 2. แปลงจากข้อความ JSON กลับเป็น Class
                Dim data As PreferanceConfig = JsonConvert.DeserializeObject(Of PreferanceConfig)(json)

                ' 3. เอาค่าใส่ TextBox ทีละช่อง

                ' --- Tab 1: GPIB ---
                txtLDT_5910CTempControlLD.Text = data.GPIB_address.LDT_5910C_TempControlLD
                txtAQ6370D_OpticspAnalyz.Text = data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz
                txtOVA_100_OpticAttenua.Text = data.GPIB_address.SANTEC_OVA_100_OpticAttenua
                txtAQ2211_Opticswich.Text = data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch
                txtDSO_X_4154GOsciloscope.Text = data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope
                txtSYSTEMAT_845TempControlBase.Text = data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase
                txtKey34416A_Digitlmultimeter.Text = data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter

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

            Catch ex As Exception
                MessageBox.Show("โหลดข้อมูลไม่สำเร็จ: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmPreferance_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' ตั้งค่า Dropdown เริ่มต้น
        cboLasermode.Items.Clear()
        cboLasermode.Items.Add("ACC")
        cboLasermode.Items.Add("APC")

        cboduration.Items.Clear()
        cboduration.Items.Add("int")
        cboduration.Items.Add("int")

        ' โหลดข้อมูล (ถ้ามีการเลือก Product มาแล้ว)
        LoadData()
    End Sub
End Class