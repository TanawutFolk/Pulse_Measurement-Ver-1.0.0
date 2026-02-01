Imports Newtonsoft.Json
Imports System.IO

Public Class frmPreferance
    '-------------------------------- btnCancle --------------------------------
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

    '-------------------------------- btnSave--------------------------------
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
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Parameters
 Select a Parameter Folder "

        If txtParamsFolder.Text <> "" Then dlg.SelectedPath = txtParamsFolder.Text

        If dlg.ShowDialog() = DialogResult.OK Then
            txtParamsFolder.Text = dlg.SelectedPath
        End If
    End Sub
    '-------------------------------- btnSelectDataFolder --------------------------------
    Private Sub btnSelectdataFolder_Click(sender As Object, e As EventArgs) Handles btnSelectdataFolder.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Data
 Select a Data Folder"

        If txtDataFolder.Text <> "" Then dlg.SelectedPath = txtDataFolder.Text

        If dlg.ShowDialog() = DialogResult.OK Then
            txtDataFolder.Text = dlg.SelectedPath
        End If
    End Sub

    '-------------------------------- SaveAllData Function --------------------------------
    Private Sub SaveAllData()
        Try
            Dim data As New PreferanceConfig()

            ' Tab 1: GPIB 
            data.GPIB_address.LDT_5910C_TempControlLD = CDbl(txtLDT_5910CTempControlLD.Text)
            data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz = CDbl(txtAQ6370D_OpticspAnalyz.Text)
            data.GPIB_address.SANTEC_OVA_100_OpticAttenua = CDbl(txtOVA_100_OpticAttenua.Text)
            data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch = CDbl(txtAQ2211_Opticswich.Text)
            data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope = CDbl(txtDSO_X_4154GOsciloscope.Text)
            data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase = CDbl(txtSYSTEMAT_845TempControlBase.Text)
            data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter = CDbl(txtKey34416A_Digitlmultimeter.Text)

            ' Tab 2: Power Measurement
            data.Power_Measurement.LaserStar_comport = CDbl(txtLasercomport.Text)
            data.Power_Measurement.Delaytime = CDbl(txtDelaytime.Text)
            data.Power_Measurement.Average = CDbl(txtAverage.Text)

            ' Tab 3: Various Folder (String อยู่แล้ว ไม่ต้องแปลง)
            data.VariousKinds_Folders.ParamsFolder = txtParamsFolder.Text
            data.VariousKinds_Folders.DataFolder = txtDataFolder.Text

            ' Tab 4: R cable
            data.Rcable.Rprobe = CDbl(txtRprobe.Text)
            data.Rcable.Rtec = CDbl(txtRtec.Text)

            ' Tab 5: TEC Condition
            ' --- Zone 1 ---
            data.TEC_Condition.Case_Waitmultiply = CDbl(txtCase_WaitFactor.Text)
            data.TEC_Condition.Case_WaitPlus = CDbl(txtCase_WaitBase.Text)
            data.TEC_Condition.Case_Error = CDbl(txtCase_Error.Text)
            ' --- Zone 2 ---
            data.TEC_Condition.LD_Waitmultiply = CDbl(txtLD_WaitFactor.Text)
            data.TEC_Condition.LD_WaitPlus = CDbl(txtLD_WaitBase.Text)
            data.TEC_Condition.LD_Error = CDbl(txtLD_Error.Text)
            ' --- Zone 3 ---
            data.TEC_Condition.Det_WaitFactor = CDbl(txtDet_WaitFactor.Text)
            data.TEC_Condition.Det_WaitBase = CDbl(txtDet_WaitBase.Text)
            data.TEC_Condition.Det_Error = CDbl(txtDet_Error.Text)
            data.TEC_Condition.Det_SetTemp = CDbl(txtDet_SetTemp.Text)
            ' --- Timeout ---
            data.TEC_Condition.Timeout = CDbl(txtTecTimeout.Text)

            ' --- Gain (Radio Button) ---
            If rbGain1.Checked Then data.TEC_Condition.GainValue = 1
            If rbGain3.Checked Then data.TEC_Condition.GainValue = 3
            If rbGain10.Checked Then data.TEC_Condition.GainValue = 10
            If rbGain30.Checked Then data.TEC_Condition.GainValue = 30
            If rbGain100.Checked Then data.TEC_Condition.GainValue = 100
            If rbGain300.Checked Then data.TEC_Condition.GainValue = 300

            ' Tab 6: CCS HPP
            data.CCS_HPP.MaxAvgCurrent = CDbl(txtMaxAvgCurrent.Text)
            data.CCS_HPP.MaximumCWCurrent = CDbl(txtMaximumCWCurrent.Text)
            data.CCS_HPP.MaxpeakCurrent = CDbl(txtMaxpeakCurrent.Text)

            data.CCS_HPP.Lasermode = cboLasermode.Text
            data.CCS_HPP.duration = cboduration.Text

            data.CCS_HPP.BFMgain = CDbl(txtBFMgain.Text)
            data.CCS_HPP.BFMconvers = CDbl(txtBFMconvers.Text)

            data.CCS_HPP.Comport = (txtComport.Text)
            data.CCS_HPP.Baudrate = CInt(txtBaudrate.Text)

            ' Tab 7: General Set
            data.General_Setting.DelayTimeOffset = CDbl(txtDelaygeneral.Text)

            ' Save to JSON file
            Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText("PreferanceSave.json", json)

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    '-------------------------------- LoadData Function --------------------------------
    Private Sub LoadData()
        ' เช็คก่อนว่ามีไฟล์ให้โหลดไหม ถ้าเปิดครั้งแรกจะยังไม่มีไฟล์ ก็ข้ามไป
        If File.Exists("PreferanceSave.json") Then
            Try
                ' 1. อ่านไฟล์
                Dim json As String = File.ReadAllText("PreferanceSave.json")

                ' 2. แปลงจากข้อความ JSON กลับเป็น Class
                Dim data As PreferanceConfig = JsonConvert.DeserializeObject(Of PreferanceConfig)(json)

                ' 3. เอาค่าใส่ TextBox ทีละช่อง ย้อนศรกับตอน Save

                ' --- Tab 1: GPIB ---
                txtLDT_5910CTempControlLD.Text = data.GPIB_address.LDT_5910C_TempControlLD.ToString()
                txtAQ6370D_OpticspAnalyz.Text = data.GPIB_address.YOKOGAWA_AQ6370D_OpticSpectAnalyz.ToString()
                txtOVA_100_OpticAttenua.Text = data.GPIB_address.SANTEC_OVA_100_OpticAttenua.ToString()
                txtAQ2211_Opticswich.Text = data.GPIB_address.YOKOGAWA_AQ2211_OpticSwitch.ToString()
                txtDSO_X_4154GOsciloscope.Text = data.GPIB_address.KEYSIGHT_DSO_X_4154GOsciloscope.ToString()
                txtSYSTEMAT_845TempControlBase.Text = data.GPIB_address.FUKKO_SYSTEMAT_845TempControlBase.ToString()
                txtKey34416A_Digitlmultimeter.Text = data.GPIB_address.KEYSIGHT_34416A_Digitlmultimeter.ToString()

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

                ' ComboBox คืนค่าString 
                cboLasermode.Text = data.CCS_HPP.Lasermode
                cboduration.Text = data.CCS_HPP.duration

                txtBFMgain.Text = data.CCS_HPP.BFMgain.ToString()
                txtBFMconvers.Text = data.CCS_HPP.BFMconvers.ToString()
                'ComboBox คืนค่าString 
                txtComport.Text = data.CCS_HPP.Comport

                txtBaudrate.Text = data.CCS_HPP.Baudrate.ToString()

                ' --- Tab 7: General ---
                txtDelaygeneral.Text = data.General_Setting.DelayTimeOffset.ToString()

            Catch ex As Exception
                MessageBox.Show("โหลดข้อมูลเก่าไม่สำเร็จ: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmPreferance_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboLasermode.Items.Clear()
        cboLasermode.Items.Add("ACC")  ' บรรทัดที่ 1
        cboLasermode.Items.Add("APC")  ' บรรทัดที่ 2

        cboduration.Items.Clear()
        cboduration.Items.Add("int")  ' บรรทัดที่ 1
        cboduration.Items.Add("int")  ' บรรทัดที่ 2

        LoadData()
    End Sub
End Class


