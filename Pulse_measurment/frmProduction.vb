Imports System.IO
Imports Newtonsoft.Json

Public Class frmProduction

    ' ตัวแปรสูตรกลาง (ถังพักข้อมูล)
    Public CurrentRecipe As New ProductionParameters()

    ' =========================================================
    ' 1. Form Load: ตั้งค่าเริ่มต้นเมื่อเปิดหน้าจอ
    ' =========================================================
    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดรายชื่อ Operator จากไฟล์ Text (ถ้ามี)
        Dim opFile As String = Path.Combine(Application.StartupPath, "SampleData\Operator.txt")
        If File.Exists(opFile) Then
            Dim lines As String() = File.ReadAllLines(opFile)
            cboOperator.Items.AddRange(lines)
        End If
    End Sub

    ' =========================================================
    ' 2. ปุ่ม Select Parameter (โหลดไฟล์สูตร)
    ' =========================================================
    Private Sub btnSelectParam_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "JSON Files|*.json|All Files|*.*"

        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                txtParameterFile.Text = dlg.FileName

                Dim json As String = File.ReadAllText(dlg.FileName)
                CurrentRecipe = JsonConvert.DeserializeObject(Of ProductionParameters)(json)

                UpdateScreenFromRecipe()

                MessageBox.Show("โหลดสูตรสำเร็จ!")

            Catch ex As Exception
                MessageBox.Show("อ่านไฟล์ไม่ได้: " & ex.Message)
            End Try
        End If
    End Sub


    ' 3. ปุ่ม Save Parameter (บันทึกสูตร)
    ' ----------------------------------------------------------
    Private Sub btnSaveParam_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' --- เพิ่ม Logic ตรงนี้ครับ ---
        ' ถ้าในกล่องข้อความยังว่างเปล่า (แปลว่าเป็นสูตรใหม่ หรือยังไม่ได้เลือกที่เก็บ)
        If txtParameterFile.Text = "" Then
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "JSON Files|*.json|All Files|*.*"
            dlg.Title = "บันทึกสูตรการผลิต (Save Recipe)"
            dlg.FileName = "NewRecipe.json" ' ตั้งชื่อ Default ให้หน่อย

            ' ให้ User เลือกที่เซฟ
            If dlg.ShowDialog() = DialogResult.OK Then
                ' พอเลือกเสร็จ เอา Path มาใส่ในกล่องข้อความ
                txtParameterFile.Text = dlg.FileName
            Else
                ' ถ้า User กด Cancel ก็ให้ออกไปเลย ไม่ต้องเซฟ
                Return
            End If
        End If
        ' -----------------------------

        ' (ส่วนข้างล่างนี้เหมือนเดิมครับ คือการบันทึก)
        Try
            ' 1. เอาค่าจากหน้าจอ เก็บลงตัวแปร
            UpdateRecipeFromScreen()

            ' 2. แปลงตัวแปรเป็น JSON
            Dim json As String = JsonConvert.SerializeObject(CurrentRecipe, Formatting.Indented)

            ' 3. เขียนลงไฟล์ (ตาม Path ที่ได้มาข้างบน)
            File.WriteAllText(txtParameterFile.Text, json)

            MessageBox.Show("บันทึกเรียบร้อยแล้ว!", "Success")

        Catch ex As Exception
            MessageBox.Show("บันทึกไม่ได้: " & ex.Message)
        End Try
    End Sub

    ' btnSelectDataFolder เลือกโฟลเดอร์เก็บData--------------------------
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
        cboOperator.Text = CurrentRecipe.OperatorName
        txtPathNumber.Text = CurrentRecipe.PartNumber
        txtLotNumber.Text = CurrentRecipe.LotNumber
        txtSerialNumber.Text = CurrentRecipe.SerialNumber
        txtFBG1.Text = CurrentRecipe.FBG1
        txtFBG2.Text = CurrentRecipe.FBG2
        txtDatafolder.Text = CurrentRecipe.DataFolder
        txtVoltWat.Text = CurrentRecipe.PowerCorrection.ToString()

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
        CurrentRecipe.OperatorName = cboOperator.Text
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

    'btnAdd Operator ------------------------------------------------ 
    Private Sub btnOperatorAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newName As String = InputBox("กรุณากรอกชื่อ Operator:", "Add Operator")
        If newName <> "" Then
            ' เพิ่มลง ComboBox
            cboOperator.Items.Add(newName)
            cboOperator.SelectedItem = newName

            ' บันทึกต่อท้ายไฟล์ Text
            Dim opFile As String = Path.Combine(Application.StartupPath, "SampleData\Operator.txt")
            File.AppendAllText(opFile, newName & vbCrLf)
        End If
    End Sub

    ' btnReturn ------------------------------------------------
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub


    '---------------- btn IL , WL , W Measurement ------------------------------------------------------------------------------------
    ' btn IL Condition Measurement
    ' =========================================================
    Private Sub btnMeasureIL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureIL_condition.Click

        Dim frm As New frmILMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_IL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureIL_condition.BackColor = Color.LightGreen
        End If
    End Sub


    ' btn WL Condition Measurement
    ' =========================================================
    Private Sub btnMeasureWL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureWL_condition.Click
        Dim frm As New frmWLMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_WL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureWL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    ' btn Waveform Condition Measurement
    ' =========================================================
    Private Sub btnMeasureWave_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureWave_condition.Click
        Dim frm As New frmWMeasurement()

        frm.LoadDataToScreen(CurrentRecipe.Meas_W_Settings)
        If frm.ShowDialog() = DialogResult.OK Then
            btnMeasureWave_condition.BackColor = Color.LightGreen
        End If
    End Sub

    '---------------- btn IL , WL , W Judgment ------------------------------------------------------------------------------------
    ' btn IL Condition Judgment
    ' =========================================================
    Private Sub btnJudgIL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgIL_condition.Click
        Dim frm As New frmiLJudgment()

        ' ส่งข้อมูล Judge IL ไป
        frm.LoadDataToScreen(CurrentRecipe.Judge_IL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgIL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    ' btn WL Condition Judgment
    ' =========================================================
    Private Sub btnJudgWL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgWL_condition.Click
        Dim frm As New frmWLJudgment()

        ' ส่งข้อมูล Judge WL ไป
        frm.LoadDataToScreen(CurrentRecipe.Judge_WL_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgWL_condition.BackColor = Color.LightGreen
        End If
    End Sub

    ' btn W Condition Judgment
    ' =========================================================
    Private Sub btnJudgW_condition_Click(sender As Object, e As EventArgs) Handles btnJudgW_condition.Click
        Dim frm As New frmWJudgment()

        ' ส่งข้อมูล Judge Wave ไป
        frm.LoadDataToScreen(CurrentRecipe.Judge_W_Settings)

        If frm.ShowDialog() = DialogResult.OK Then
            btnJudgW_condition.BackColor = Color.LightGreen
        End If
    End Sub
End Class