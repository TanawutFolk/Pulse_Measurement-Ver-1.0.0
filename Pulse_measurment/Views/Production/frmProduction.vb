Imports System.IO
Imports Newtonsoft.Json

Public Class frmProduction


    ' --- Load 
    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' --- btnSelect Parameter โหลดไฟล์สูตร
    Private Sub btnSelectParam_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "JSON Files|*.json|All Files|*.*"

        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                txtParameterFile.Text = dlg.FileName

                Dim json As String = File.ReadAllText(dlg.FileName)
                CurrentRecipe = JsonConvert.DeserializeObject(Of ProductionParameters)(json)

                UpdateScreenFromRecipe()

                MessageBox.Show("Load Parameters File Complete")

            Catch ex As Exception
                MessageBox.Show("Can not read file: " & ex.Message)
            End Try
        End If
    End Sub


    ' --- btnSave Parameter บันทึกสูตร
    Private Sub btnSaveParam_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim dlg As New SaveFileDialog()
        dlg.Filter = "JSON Files|*.json|All Files|*.*"
        dlg.Title = "Save File"

        ' ตั้ง Initial Directory ไปที่ SampleData
        Dim sampleDataPath As String = Path.Combine(Application.StartupPath, "SampleData")
        If Directory.Exists(sampleDataPath) Then
            dlg.InitialDirectory = sampleDataPath
        End If

        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                ' 1. เอาค่าจากหน้าจอ เก็บลงตัวแปร Class
                UpdateRecipeFromScreen()

                ' 2. แปลงตัวแปรเป็น JSON
                Dim json As String = JsonConvert.SerializeObject(CurrentRecipe, Formatting.Indented)

                ' 3. เขียนลงไฟล์
                File.WriteAllText(dlg.FileName, json)

                ' 4. โชว์ Path ให้ User เห็น
                txtParameterFile.Text = dlg.FileName

                MessageBox.Show("บันทึกสูตรเรียบร้อยแล้ว!" & vbCrLf & "ไฟล์: " & Path.GetFileName(dlg.FileName), "Success")

            Catch ex As Exception
                MessageBox.Show("บันทึกไม่ได้: " & ex.Message, "Error")
            End Try
        End If
    End Sub

    ' ---btnSelectData folder
    Private Sub btnSelectDataFolder_Click(sender As Object, e As EventArgs) Handles btnSelectDataFolder.Click
        ' ใช้ FolderBrowserDialog (เลือกโฟลเดอร์ ไม่ใช่เลือกไฟล์)
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "เลือกโฟลเดอร์สำหรับเก็บผลการวัด (Measurement Data)"

        ' ถ้าในกล่องมีค่าเดิม ให้เปิดไปที่นั่นก่อน
        If txtDatafolder.Text <> "" And Directory.Exists(txtDatafolder.Text) Then
            dlg.SelectedPath = txtDatafolder.Text
        End If

        If dlg.ShowDialog() = DialogResult.OK Then
            ' เอา Path ที่เลือกมาใส่ในกล่อง
            txtDatafolder.Text = dlg.SelectedPath
        End If
    End Sub


    ' =========================================================
    ' Helper Sub: ย้ายข้อมูลจาก Class -> หน้าจอ
    ' =========================================================
    Private Sub UpdateScreenFromRecipe()
        ' Header Info
        txtMachineNO.Text = CurrentRecipe.MachineNo
        txtOperator.Text = CurrentRecipe.OperatorName
        txtPathNumber.Text = CurrentRecipe.PartNumber
        txtLotNumber.Text = CurrentRecipe.LotNumber
        txtSerialNumber.Text = CurrentRecipe.SerialNumber
        txtFBG1.Text = CurrentRecipe.FBG1
        txtFBG2.Text = CurrentRecipe.FBG2
        txtDatafolder.Text = CurrentRecipe.DataFolder
        txtVoltWat.Text = CurrentRecipe.PowerCorrection

        ' Measurement Checkboxes
        cbMeasureIL1.Checked = CurrentRecipe.Meas_Enable_IL1
        cbMeasureIL2.Checked = CurrentRecipe.Meas_Enable_IL2
        cbMeasureIL3.Checked = CurrentRecipe.Meas_Enable_IL3
        cbMeasureIL4.Checked = CurrentRecipe.Meas_Enable_IL4
        cbMeasureIL5.Checked = CurrentRecipe.Meas_Enable_IL5
        cbMeasureIL6.Checked = CurrentRecipe.Meas_Enable_IL6

        cbMeasure_Spectrum1.Checked = CurrentRecipe.Meas_Enable_Spec1
        cbMeasure_Spectrum2.Checked = CurrentRecipe.Meas_Enable_Spec2
        cbMeasure_Spectrum3.Checked = CurrentRecipe.Meas_Enable_Spec3
        cbMeasure_Spectrum4.Checked = CurrentRecipe.Meas_Enable_Spec4
        cbMeasure_Spectrum5.Checked = CurrentRecipe.Meas_Enable_Spec5
        cbMeasure_Spectrum6.Checked = CurrentRecipe.Meas_Enable_Spec6

        cbMeasure_Waveform1.Checked = CurrentRecipe.Meas_Enable_Wave1
        cbMeasure_Waveform2.Checked = CurrentRecipe.Meas_Enable_Wave2
        cbMeasure_Waveform3.Checked = CurrentRecipe.Meas_Enable_Wave3
        cbMeasure_Waveform4.Checked = CurrentRecipe.Meas_Enable_Wave4
        cbMeasure_Waveform5.Checked = CurrentRecipe.Meas_Enable_Wave5
        cbMeasure_Waveform6.Checked = CurrentRecipe.Meas_Enable_Wave6

        ' Use Calory Meter
        cbMeasure_Use_calory_meter.Checked = CurrentRecipe.Meas_UseCaloryMeter

        'Judgment Checkboxes
        cbJudgIL1.Checked = CurrentRecipe.Judge_Enable_IL1
        cbJudgIL2.Checked = CurrentRecipe.Judge_Enable_IL2
        cbJudgIL3.Checked = CurrentRecipe.Judge_Enable_IL3
        cbJudgIL4.Checked = CurrentRecipe.Judge_Enable_IL4
        cbJudgIL5.Checked = CurrentRecipe.Judge_Enable_IL5
        cbJudgIL6.Checked = CurrentRecipe.Judge_Enable_IL6

        cbJudg_Spectrum1.Checked = CurrentRecipe.Judge_Enable_Spec1
        cbJudg_Spectrum2.Checked = CurrentRecipe.Judge_Enable_Spec2
        cbJudg_Spectrum3.Checked = CurrentRecipe.Judge_Enable_Spec3
        cbJudg_Spectrum4.Checked = CurrentRecipe.Judge_Enable_Spec4
        cbJudg_Spectrum5.Checked = CurrentRecipe.Judge_Enable_Spec5
        cbJudg_Spectrum6.Checked = CurrentRecipe.Judge_Enable_Spec6

        cbJudg_Waveform1.Checked = CurrentRecipe.Judge_Enable_Wave1
        cbJudg_Waveform2.Checked = CurrentRecipe.Judge_Enable_Wave2
        cbJudg_Waveform3.Checked = CurrentRecipe.Judge_Enable_Wave3
        cbJudg_Waveform4.Checked = CurrentRecipe.Judge_Enable_Wave4
        cbJudg_Waveform5.Checked = CurrentRecipe.Judge_Enable_Wave5
        cbJudg_Waveform6.Checked = CurrentRecipe.Judge_Enable_Wave6
    End Sub

    ' =========================================================
    ' Helper Sub: ย้ายข้อมูลจาก หน้าจอ -> Class
    ' =========================================================
    Private Sub UpdateRecipeFromScreen()
        ' Header Info
        CurrentRecipe.ParameterFile = txtParameterFile.Text
        CurrentRecipe.OperatorName = txtOperator.Text
        CurrentRecipe.MachineNo = txtMachineNO.Text
        CurrentRecipe.PartNumber = txtPathNumber.Text
        CurrentRecipe.LotNumber = txtLotNumber.Text
        CurrentRecipe.SerialNumber = txtSerialNumber.Text
        CurrentRecipe.FBG1 = txtFBG1.Text
        CurrentRecipe.FBG2 = txtFBG2.Text
        CurrentRecipe.DataFolder = txtDatafolder.Text

        ' แปลงตัวเลข ใช้ TryParse กัน Error
        Double.TryParse(txtVoltWat.Text, CurrentRecipe.PowerCorrection)

        ' Measurement Checkboxes
        CurrentRecipe.Meas_Enable_IL1 = cbMeasureIL1.Checked
        CurrentRecipe.Meas_Enable_IL2 = cbMeasureIL2.Checked
        CurrentRecipe.Meas_Enable_IL3 = cbMeasureIL3.Checked
        CurrentRecipe.Meas_Enable_IL4 = cbMeasureIL4.Checked
        CurrentRecipe.Meas_Enable_IL5 = cbMeasureIL5.Checked
        CurrentRecipe.Meas_Enable_IL6 = cbMeasureIL6.Checked

        CurrentRecipe.Meas_Enable_Spec1 = cbMeasure_Spectrum1.Checked
        CurrentRecipe.Meas_Enable_Spec2 = cbMeasure_Spectrum2.Checked
        CurrentRecipe.Meas_Enable_Spec3 = cbMeasure_Spectrum3.Checked
        CurrentRecipe.Meas_Enable_Spec4 = cbMeasure_Spectrum4.Checked
        CurrentRecipe.Meas_Enable_Spec5 = cbMeasure_Spectrum5.Checked
        CurrentRecipe.Meas_Enable_Spec6 = cbMeasure_Spectrum6.Checked

        CurrentRecipe.Meas_Enable_Wave1 = cbMeasure_Waveform1.Checked
        CurrentRecipe.Meas_Enable_Wave2 = cbMeasure_Waveform2.Checked
        CurrentRecipe.Meas_Enable_Wave3 = cbMeasure_Waveform3.Checked
        CurrentRecipe.Meas_Enable_Wave4 = cbMeasure_Waveform4.Checked
        CurrentRecipe.Meas_Enable_Wave5 = cbMeasure_Waveform5.Checked
        CurrentRecipe.Meas_Enable_Wave6 = cbMeasure_Waveform6.Checked

        ' Use Calory Meter
        CurrentRecipe.Meas_UseCaloryMeter = cbMeasure_Use_calory_meter.Checked

        ' Judgment Checkboxes
        CurrentRecipe.Judge_Enable_IL1 = cbJudgIL1.Checked
        CurrentRecipe.Judge_Enable_IL2 = cbJudgIL2.Checked
        CurrentRecipe.Judge_Enable_IL3 = cbJudgIL3.Checked
        CurrentRecipe.Judge_Enable_IL4 = cbJudgIL4.Checked
        CurrentRecipe.Judge_Enable_IL5 = cbJudgIL5.Checked
        CurrentRecipe.Judge_Enable_IL6 = cbJudgIL6.Checked

        CurrentRecipe.Judge_Enable_Spec1 = cbJudg_Spectrum1.Checked
        CurrentRecipe.Judge_Enable_Spec2 = cbJudg_Spectrum2.Checked
        CurrentRecipe.Judge_Enable_Spec3 = cbJudg_Spectrum3.Checked
        CurrentRecipe.Judge_Enable_Spec4 = cbJudg_Spectrum4.Checked
        CurrentRecipe.Judge_Enable_Spec5 = cbJudg_Spectrum5.Checked
        CurrentRecipe.Judge_Enable_Spec6 = cbJudg_Spectrum6.Checked

        CurrentRecipe.Judge_Enable_Wave1 = cbJudg_Waveform1.Checked
        CurrentRecipe.Judge_Enable_Wave2 = cbJudg_Waveform2.Checked
        CurrentRecipe.Judge_Enable_Wave3 = cbJudg_Waveform3.Checked
        CurrentRecipe.Judge_Enable_Wave4 = cbJudg_Waveform4.Checked
        CurrentRecipe.Judge_Enable_Wave5 = cbJudg_Waveform5.Checked
        CurrentRecipe.Judge_Enable_Wave6 = cbJudg_Waveform6.Checked
    End Sub

    '---------------- btn IL , WL , W Measurement ------------------------------------------
    '--- btn Open IL Condition Measurement
    Private Sub btnMeasureIL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureIL_condition.Click

        Dim frm As New frmILMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_IL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureIL_condition.BackColor = Color.LightGreen
        End If
    End Sub
    '--- btn Open WL Condition Measurement
    Private Sub btnMeasureWL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureWL_condition.Click
        Dim frm As New frmWLMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_WL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureWL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    '--- btn Open W Condition Measurement
    Private Sub btnMeasureWave_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureWave_condition.Click
        Dim frm As New frmWMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_W_Settings)
        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureWave_condition.BackColor = Color.LightGreen
        End If
    End Sub


    '---------------- btn IL , WL , W Judgment ---------------------------------------------
    '--- btn Open IL Condition Measurement
    Private Sub btnJudgIL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgIL_condition.Click
        Dim frm As New frmiLJudgment()
        frm.LoadDataToScreen(CurrentRecipe.Judge_IL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgIL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    '--- btn Open WL Condition Measurement
    Private Sub btnJudgWL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgWL_condition.Click
        Dim frm As New frmWLJudgment()
        frm.LoadDataToScreen(CurrentRecipe.Judge_WL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgWL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    '--- btn Open W Condition Measurement
    Private Sub btnJudgW_condition_Click(sender As Object, e As EventArgs) Handles btnJudgW_condition.Click
        Dim frm As New frmWJudgment()
        frm.LoadDataToScreen(CurrentRecipe.Judge_W_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgW_condition.BackColor = Color.LightGreen
        End If
    End Sub

    ' btnReturn ------------------------------------------------
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub
End Class