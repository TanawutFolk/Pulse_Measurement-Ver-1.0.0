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

    '-------------------------------- btnSelectparasFolder --------------------------------
    Private Sub btnSelectparasFolder_Click(sender As Object, e As EventArgs) Handles btnSelectparasFolder.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Parameters"

        If txtParamsFolder.Text <> "" Then dlg.SelectedPath = txtParamsFolder.Text

        If dlg.ShowDialog() = DialogResult.OK Then
            txtParamsFolder.Text = dlg.SelectedPath
        End If
    End Sub
    '-------------------------------- btnSelectdataFolder --------------------------------
    Private Sub btnSelectdataFolder_Click(sender As Object, e As EventArgs) Handles btnSelectdataFolder.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บ Data"

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
            data.GPIB.LDT_5910C_TempControlLD = CDbl(txtLDT_5910CTempControlLD.Text)
            data.GPIB.AQ6370D_OpticSpectAnalyz = CDbl(txtAQ6370D_OpticspAnalyz.Text)
            data.GPIB.OVA_100_OpticAttenua = CDbl(txtOVA_100_OpticAttenua.Text)
            data.GPIB.AQ2211_OpticSwitch = CDbl(txtAQ2211_Opticswich.Text)
            data.GPIB.DSO_X_4154GOsciloscope = CDbl(txtDSO_X_4154GOsciloscope.Text)
            data.GPIB.SYSTEMAT_845TempControlBase = CDbl(txtSYSTEMAT_845TempControlBase.Text)
            data.GPIB.Key34416A_Digitlmultimeter = CDbl(txtKey34416A_Digitlmultimeter.Text)

            ' Tab 2: Power Measurement
            data.Power.Laser_comport = CDbl(txtLasercomport.Text)
            data.Power.Delaytime = CDbl(txtDelaytime.Text)
            data.Power.Average = CDbl(txtAverage.Text)

            ' Tab 3: Various Folder (String อยู่แล้ว ไม่ต้องแปลง)
            data.Folders.ParamsFolder = txtParamsFolder.Text
            data.Folders.DataFolder = txtDataFolder.Text

            ' Tab 4: R cable
            data.Cable.Rprobe = CDbl(txtRprobe.Text)
            data.Cable.Rtec = CDbl(txtRtec.Text)

            ' Tab 5: TEC Condition
            ' --- Zone 1 ---
            data.TEC.Case_WaitFactor = CDbl(txtCase_WaitFactor.Text)
            data.TEC.Case_WaitBase = CDbl(txtCase_WaitBase.Text)
            data.TEC.Case_Error = CDbl(txtCase_Error.Text)
            ' --- Zone 2 ---
            data.TEC.LD_WaitFactor = CDbl(txtLD_WaitFactor.Text)
            data.TEC.LD_WaitBase = CDbl(txtLD_WaitBase.Text)
            data.TEC.LD_Error = CDbl(txtLD_Error.Text)
            ' --- Zone 3 ---
            data.TEC.Det_WaitFactor = CDbl(txtDet_WaitFactor.Text)
            data.TEC.Det_WaitBase = CDbl(txtDet_WaitBase.Text)
            data.TEC.Det_Error = CDbl(txtDet_Error.Text)
            data.TEC.Det_SetTemp = CDbl(txtDet_SetTemp.Text)
            ' --- Timeout ---
            data.TEC.Timeout = CDbl(txtTecTimeout.Text)

            ' --- Gain (Radio Button) ---
            If rbGain1.Checked Then data.TEC.GainValue = 1
            If rbGain3.Checked Then data.TEC.GainValue = 3
            If rbGain10.Checked Then data.TEC.GainValue = 10
            If rbGain30.Checked Then data.TEC.GainValue = 30
            If rbGain100.Checked Then data.TEC.GainValue = 100
            If rbGain300.Checked Then data.TEC.GainValue = 300

            ' Tab 6: CCS HPP
            data.CCS.MaxAvgCurrent = CDbl(txtMaxAvgCurrent.Text)
            data.CCS.MaximumCWCurrent = CDbl(txtMaximumCWCurrent.Text)
            data.CCS.MaxpeakCurrent = CDbl(txtMaxpeakCurrent.Text)

            data.CCS.Lasermode = cboLasermode.Text
            data.CCS.duration = cboduration.Text

            data.CCS.BFMgain = CDbl(txtBFMgain.Text)
            data.CCS.BFMconvers = CDbl(txtBFMconvers.Text)

            data.CCS.Comport = (txtComport.Text)
            data.CCS.Baudrate = CInt(txtBaudrate.Text)

            ' Tab 7: General Set
            data.General.DelayTimeOffset = CDbl(txtDelaygeneral.Text)

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

                ' 3. เอาค่าไปหยอดใส่ TextBox ทีละช่อง ย้อนศรกับตอน Save

                ' --- Tab 1: GPIB ---
                txtLDT_5910CTempControlLD.Text = data.GPIB.LDT_5910C_TempControlLD.ToString()
                txtAQ6370D_OpticspAnalyz.Text = data.GPIB.AQ6370D_OpticSpectAnalyz.ToString()
                txtOVA_100_OpticAttenua.Text = data.GPIB.OVA_100_OpticAttenua.ToString()
                txtAQ2211_Opticswich.Text = data.GPIB.AQ2211_OpticSwitch.ToString()
                txtDSO_X_4154GOsciloscope.Text = data.GPIB.DSO_X_4154GOsciloscope.ToString()
                txtSYSTEMAT_845TempControlBase.Text = data.GPIB.SYSTEMAT_845TempControlBase.ToString()
                txtKey34416A_Digitlmultimeter.Text = data.GPIB.Key34416A_Digitlmultimeter.ToString()

                ' --- Tab 2: Power ---
                txtLasercomport.Text = data.Power.Laser_comport.ToString()
                txtDelaytime.Text = data.Power.Delaytime.ToString()
                txtAverage.Text = data.Power.Average.ToString()

                ' --- Tab 3: Folders ---
                txtParamsFolder.Text = data.Folders.ParamsFolder
                txtDataFolder.Text = data.Folders.DataFolder

                ' --- Tab 4: Cable ---
                txtRprobe.Text = data.Cable.Rprobe.ToString()
                txtRtec.Text = data.Cable.Rtec.ToString()

                ' --- Tab 5: TEC ---
                txtCase_WaitFactor.Text = data.TEC.Case_WaitFactor.ToString()
                txtCase_WaitBase.Text = data.TEC.Case_WaitBase.ToString()
                txtCase_Error.Text = data.TEC.Case_Error.ToString()

                txtLD_WaitFactor.Text = data.TEC.LD_WaitFactor.ToString()
                txtLD_WaitBase.Text = data.TEC.LD_WaitBase.ToString()
                txtLD_Error.Text = data.TEC.LD_Error.ToString()

                txtDet_WaitFactor.Text = data.TEC.Det_WaitFactor.ToString()
                txtDet_WaitBase.Text = data.TEC.Det_WaitBase.ToString()
                txtDet_Error.Text = data.TEC.Det_Error.ToString()
                txtDet_SetTemp.Text = data.TEC.Det_SetTemp.ToString()

                txtTecTimeout.Text = data.TEC.Timeout.ToString()

                ' Radio Button (Gain)
                Select Case data.TEC.GainValue
                    Case 1 : rbGain1.Checked = True
                    Case 3 : rbGain3.Checked = True
                    Case 10 : rbGain10.Checked = True
                    Case 30 : rbGain30.Checked = True
                    Case 100 : rbGain100.Checked = True
                    Case 300 : rbGain300.Checked = True
                End Select

                ' --- Tab 6: CCS ---
                txtMaxAvgCurrent.Text = data.CCS.MaxAvgCurrent.ToString()
                txtMaximumCWCurrent.Text = data.CCS.MaximumCWCurrent.ToString()
                txtMaxpeakCurrent.Text = data.CCS.MaxpeakCurrent.ToString()

                ' ComboBox คืนค่าString 
                cboLasermode.Text = data.CCS.Lasermode
                cboduration.Text = data.CCS.duration

                txtBFMgain.Text = data.CCS.BFMgain.ToString()
                txtBFMconvers.Text = data.CCS.BFMconvers.ToString()
                'ComboBox คืนค่าString 
                txtComport.Text = data.CCS.Comport

                txtBaudrate.Text = data.CCS.Baudrate.ToString()

                ' --- Tab 7: General ---
                txtDelaygeneral.Text = data.General.DelayTimeOffset.ToString()

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

Public Class GPIBSettings

    Public Property LDT_5910C_TempControlLD As Double
    Public Property AQ6370D_OpticSpectAnalyz As Double
    Public Property OVA_100_OpticAttenua As Double
    Public Property AQ2211_OpticSwitch As Double
    Public Property DSO_X_4154GOsciloscope As Double
    Public Property SYSTEMAT_845TempControlBase As Double
    Public Property Key34416A_Digitlmultimeter As Double

End Class
Public Class PowerMeasurement

    Public Property Laser_comport As Double
    Public Property Delaytime As Double
    Public Property Average As Double
End Class
Public Class VariousFolder

    Public Property ParamsFolder As String
    Public Property DataFolder As String

End Class
Public Class Rcable

    Public Property Rprobe As Double
    Public Property Rtec As Double

End Class
Public Class TEC_Condition
    ' --- Zone 1: Case ---
    Public Property Case_WaitFactor As Double
    Public Property Case_WaitBase As Double
    Public Property Case_Error As Double

    ' --- Zone 2: LD ---
    Public Property LD_WaitFactor As Double
    Public Property LD_WaitBase As Double
    Public Property LD_Error As Double

    ' --- Zone 3: Detector ---
    Public Property Det_WaitFactor As Double
    Public Property Det_WaitBase As Double
    Public Property Det_Error As Double
    Public Property Det_SetTemp As Double

    ' --- Zone 4: Timeout ---
    Public Property Timeout As Double

    ' --- Zone 5: Gain ---
    Public Property GainValue As Integer
End Class

Public Class CCS_HPP

    Public Property MaxAvgCurrent As Double
    Public Property MaximumCWCurrent As Double
    Public Property MaxpeakCurrent As Double
    Public Property Lasermode As String
    Public Property duration As String
    Public Property BFMgain As Double
    Public Property BFMconvers As Double
    Public Property Comport As String
    Public Property Baudrate As Double

End Class

Public Class GeneralSet

    Public Property DelayTimeOffset As Double

End Class
'-------------------------------- PreferanceConfig --------------------------------
Public Class PreferanceConfig
    Public Property GPIB As New GPIBSettings()
    Public Property Power As New PowerMeasurement()
    Public Property Folders As New VariousFolder()
    Public Property Cable As New Rcable()
    Public Property TEC As New TEC_Condition()
    Public Property CCS As New CCS_HPP()
    Public Property General As New GeneralSet()
End Class


