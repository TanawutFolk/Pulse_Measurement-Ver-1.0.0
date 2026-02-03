Imports System.IO
Imports Newtonsoft.Json

Public Class frmProduction

    Private Function GetProductListPath() As String
        Dim appPath As String = Application.StartupPath
        ' ถอยออกมา 1 ขั้น -> เข้าโฟลเดอร์ PRF -> ไฟล์ ProductList.txt
        Dim pathFile As String = Path.Combine(Directory.GetParent(appPath).FullName, "PRF", "ProductList.txt")
        Return pathFile
    End Function

    ' 3. เมื่อ User เลือกสินค้า (Event)
    Private Sub cboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct.SelectedIndexChanged
        ' ส่งค่าไปบอกตัวแปร Global ว่าตอนนี้เลือกสินค้ารุ่นนี้นะ
        GlobalVariables.CurrentProduct = cboProduct.Text
    End Sub

    ' 1. โหลดรายชื่อเข้า Dropdown (ใส่ใน Form_Load)
    ' =============================================================
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductList()
    End Sub

    Private Sub LoadProductList()
        Dim filePath As String = GetProductListPath()

        ' เคลียร์ของเก่าก่อน
        cboProduct.Items.Clear()

        ' ถ้ามีไฟล์ ให้โหลดมาใส่
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)

            For Each line As String In lines
                ' ตัดช่องว่างหน้าหลัง และเช็คว่าไม่ใช่บรรทัดว่าง
                If line.Trim() <> "" Then
                    cboProduct.Items.Add(line.Trim())
                End If
            Next
        Else
            ' ถ้ายังไม่มีไฟล์ (เปิดครั้งแรก) ให้สร้างไฟล์เปล่ารอไว้ หรือใส่ค่า Default
            Try
                Dim dir As String = Path.GetDirectoryName(filePath)
                If Not Directory.Exists(dir) Then Directory.CreateDirectory(dir)

                ' สร้างไฟล์พร้อมค่าเริ่มต้น
                File.WriteAllText(filePath, "1480" & vbCrLf & "980")

                ' โหลดค่าเริ่มต้นเข้า Dropdown
                cboProduct.Items.Add("1480")
                cboProduct.Items.Add("980")
            Catch ex As Exception
                ' กัน Error เรื่อง Permission
            End Try
        End If
    End Sub
    '' ตัวแปรสูตรกลาง 
    'Public CurrentRecipe As New ProductionParameters() ย้ายไปไฟล์

    ' =========================================================
    ' 1. Form Load ตั้งค่าเริ่มต้นเมื่อเปิดหน้าจอ
    ' =========================================================
    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดรายชื่อ Operator จากไฟล์ Opearator.txt 
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

        ' --- ส่วนที่ 1: ตรวจสอบก่อนว่าเลือก Product หรือยัง ---
        ' (สมมติว่าคุณเก็บชื่อรุ่นปัจจุบันไว้ใน GlobalSettings.CurrentProduct จากหน้า Main Menu)
        If String.IsNullOrEmpty(GlobalVariables.CurrentProduct) Then
            MessageBox.Show("กรุณาเลือกรุ่นสินค้า (Product) จากหน้าเมนูหลักก่อนครับ", "แจ้งเตือน")
            Return
        End If

        ' --- ส่วนที่ 2: สร้างชื่อไฟล์และ Path อัตโนมัติ (หัวใจสำคัญ) ---
        ' ไม่ใช้ SaveFileDialog แล้ว แต่กำหนดเองเลยตามโจทย์
        ' ชื่อไฟล์ = Pulse_ + รุ่น + .json
        Dim fileName As String = "Pulse_" & GlobalVariables.CurrentProduct & ".json"

        ' หา Path ของโฟลเดอร์ PRF (ใช้ฟังก์ชัน GetPRFPath ที่แนะนำไปรอบที่แล้ว)
        Dim fullPath As String = Path.Combine(GetPRFPath(), fileName)

        ' -----------------------------
        Try
            ' 1. เอาค่าจากหน้าจอ เก็บลงตัวแปร Class (โค้ดเดิม)
            UpdateRecipeFromScreen()

            ' 2. แปลงตัวแปรเป็น JSON (โค้ดเดิม)
            Dim json As String = JsonConvert.SerializeObject(CurrentRecipe, Formatting.Indented)

            ' 3. เขียนลงไฟล์ (ใช้ Path ใหม่ที่เราสร้างเอง)
            File.WriteAllText(fullPath, json)

            ' 4. โชว์ Path ให้ User เห็นในกล่องข้อความหน่อย จะได้ไม่งงว่าเซฟไปไหน
            txtParameterFile.Text = fullPath

            MessageBox.Show("บันทึกสูตรรุ่น " & GlobalVariables.CurrentProduct & " เรียบร้อยแล้ว!", "Success")

        Catch ex As Exception
            MessageBox.Show("บันทึกไม่ได้: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันสำหรับหาที่อยู่ของโฟลเดอร์ PRF
    Private Function GetPRFPath() As String
        ' ถอยออกมา 1 ขั้นจากโฟลเดอร์โปรแกรม (.exe) เพื่อหาโฟลเดอร์ PRF
        Dim appPath As String = Application.StartupPath
        Dim prfPath As String = Path.Combine(Directory.GetParent(appPath).FullName, "PRF")

        ' ถ้ายังไม่มีโฟลเดอร์นี้ ให้สร้างรอไว้เลย
        If Not Directory.Exists(prfPath) Then Directory.CreateDirectory(prfPath)

        Return prfPath
    End Function

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

    Private Sub btnOperatorAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newName As String = InputBox("กรุณากรอกชื่อ Operator", "Add Operator")

        ' ตัดช่องว่างหน้าหลังออก กัน user เคาะวรรคเล่น
        newName = newName.Trim()

        If newName <> "" Then
            ' 1. เพิ่มลง ComboBox และเลือก
            cboOperator.Items.Add(newName)
            cboOperator.SelectedItem = newName

            ' 2. บันทึกลงไฟล์
            Try
                Dim opFile As String = Path.Combine(Application.StartupPath, "SampleData\Operator.txt")

                ' เช็คก่อนว่ามีโฟลเดอร์ SampleData ไหม ถ้าไม่มี ให้สร้างใหม่
                Dim dir As String = Path.GetDirectoryName(opFile)
                If Not Directory.Exists(dir) Then Directory.CreateDirectory(dir)

                ' เขียนต่อท้ายไฟล์ Append
                File.AppendAllText(opFile, newName & vbCrLf)

            Catch ex As Exception
                MessageBox.Show("บันทึกชื่อลงไฟล์ไม่สำเร็จ  " & ex.Message)
            End Try
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub
End Class