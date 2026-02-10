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
        Try
            'รับค่า User Input เก็บในตัวแปร
            UpdateRecipeFromScreen()

            'valid ข้อมูลครบไหม
            If String.IsNullOrEmpty(txtParameterFile.Text) Then
                MessageBox.Show("กรุณาเลือกไฟล์ Parameter ก่อน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(txtOperator.Text) Then
                MessageBox.Show("กรุณากรอกรหัสพนักงาน (Operator)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Initialize Machine (เชื่อมต่อเครื่องมือ)
            If mInitialMachine() = False Then
                MessageBox.Show("ไม่สามารถเชื่อมต่อเครื่องได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' รวบรวม Measurement Steps ที่เปิดใช้งาน (แต่ละ step มี Tc/Tld ต่างกันได้)
            Dim steps As List(Of MeasurementStep) = BuildMeasurementSteps()

            If steps.Count = 0 Then
                MessageBox.Show("ไม่มี Measurement ที่เปิดใช้งาน กรุณาเลือกอย่างน้อย 1 เงื่อนไข", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' วนลูปวัดทีละ Step ตั้ง Temp → รอ Steady → วัด
            For i As Integer = 0 To steps.Count - 1
                Dim currentStep As MeasurementStep = steps(i)

                gSysLog.LogOut("=== Step " & (i + 1) & "/" & steps.Count & ": " & currentStep.StepName & " (Tc=" & currentStep.Tc & ", Ts=" & currentStep.Tld & ") ===")

                ' 5.1 ตั้งค่าอุณหภูมิเป้าหมาย (ส่งคำสั่งไปที่ TEC Controller)
                dblTcSet = currentStep.Tc
                dblTsSet = currentStep.Tld

                gSysLog.LogOut("Setting Tc target = " & dblTcSet & " °C")
                If clsTc_ILX.LD_Temp(0, dblTcSet) = False Then
                    Throw New Exception("Failed to set Tc temperature")
                End If

                gSysLog.LogOut("Setting Ts target = " & dblTsSet & " °C")
                If clsTs_ILX.LD_Temp(0, dblTsSet) = False Then
                    Throw New Exception("Failed to set Ts temperature")
                End If

                ' 5.2 Control Temperature - รอ Temp Steady
                Dim frmTemp As New frmLDTempWait()
                If frmTemp.gfuncTempCtrl() = False Then
                    MessageBox.Show("Temperature control cancelled or failed at step: " & currentStep.StepName, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' 5.3 Temp Steady แล้ว → ทำการวัดตาม Type
                gSysLog.LogOut("Temperature Stable for " & currentStep.StepName & " → Start measurement")

                ' TODO: เพิ่ม code วัดจริงตรงนี้ตาม currentStep.MeasType
                ' Select Case currentStep.MeasType
                '     Case "IL"  : RunILMeasurement(currentStep.TabIndex)
                '     Case "WL"  : RunWLMeasurement(currentStep.TabIndex)
                '     Case "Wave": RunWaveMeasurement(currentStep.TabIndex)
                ' End Select

            Next

            ' 6. วัดครบทุก Step แล้ว
            MessageBox.Show("Measurement Complete! (" & steps.Count & " steps)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            gSysLog.LogOut("btnStart_Click," & ex.Message)
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    ' Class เก็บข้อมูล 1 Step ของการวัด
    ' =========================================================
    Private Class MeasurementStep
        Public Property StepName As String   ' เช่น "IL1", "WL3", "Wave2"
        Public Property MeasType As String   ' "IL", "WL", "Wave"
        Public Property TabIndex As Integer  ' 1-6
        Public Property Tc As Double         ' อุณหภูมิ Case
        Public Property Tld As Double        ' อุณหภูมิ LD
    End Class

    ' ----- สร้างรายการ Steps จาก Checkbox ที่เปิดใช้งาน -----
    Private Function BuildMeasurementSteps() As List(Of MeasurementStep)
        Dim steps As New List(Of MeasurementStep)

        ' --- IL Measurement (6 Tabs) ---
        Dim ilEnabled() As Boolean = {
            CurrentRecipe.Meas_Enable_IL1, CurrentRecipe.Meas_Enable_IL2,
            CurrentRecipe.Meas_Enable_IL3, CurrentRecipe.Meas_Enable_IL4,
            CurrentRecipe.Meas_Enable_IL5, CurrentRecipe.Meas_Enable_IL6
        }
        Dim ilSettings() As ILParameter = {
            CurrentRecipe.Meas_IL_Settings.L1, CurrentRecipe.Meas_IL_Settings.L2,
            CurrentRecipe.Meas_IL_Settings.L3, CurrentRecipe.Meas_IL_Settings.L4,
            CurrentRecipe.Meas_IL_Settings.L5, CurrentRecipe.Meas_IL_Settings.L6
        }
        For idx As Integer = 0 To 5
            If ilEnabled(idx) Then
                steps.Add(New MeasurementStep With {
                    .StepName = "IL" & (idx + 1),
                    .MeasType = "IL",
                    .TabIndex = idx + 1,
                    .Tc = ilSettings(idx).Tc,
                    .Tld = ilSettings(idx).Tld
                })
            End If
        Next

        ' --- WL (Spectrum) Measurement (6 Tabs) ---
        Dim wlEnabled() As Boolean = {
            CurrentRecipe.Meas_Enable_Spec1, CurrentRecipe.Meas_Enable_Spec2,
            CurrentRecipe.Meas_Enable_Spec3, CurrentRecipe.Meas_Enable_Spec4,
            CurrentRecipe.Meas_Enable_Spec5, CurrentRecipe.Meas_Enable_Spec6
        }
        Dim wlSettings() As WLParameter = {
            CurrentRecipe.Meas_WL_Settings.Spec1, CurrentRecipe.Meas_WL_Settings.Spec2,
            CurrentRecipe.Meas_WL_Settings.Spec3, CurrentRecipe.Meas_WL_Settings.Spec4,
            CurrentRecipe.Meas_WL_Settings.Spec5, CurrentRecipe.Meas_WL_Settings.Spec6
        }
        For idx As Integer = 0 To 5
            If wlEnabled(idx) Then
                steps.Add(New MeasurementStep With {
                    .StepName = "WL" & (idx + 1),
                    .MeasType = "WL",
                    .TabIndex = idx + 1,
                    .Tc = wlSettings(idx).Tc,
                    .Tld = wlSettings(idx).Tld
                })
            End If
        Next

        ' --- Waveform Measurement (6 Tabs) ---
        Dim waveEnabled() As Boolean = {
            CurrentRecipe.Meas_Enable_Wave1, CurrentRecipe.Meas_Enable_Wave2,
            CurrentRecipe.Meas_Enable_Wave3, CurrentRecipe.Meas_Enable_Wave4,
            CurrentRecipe.Meas_Enable_Wave5, CurrentRecipe.Meas_Enable_Wave6
        }
        Dim waveSettings() As WaveformParameter = {
            CurrentRecipe.Meas_W_Settings.Wave1, CurrentRecipe.Meas_W_Settings.Wave2,
            CurrentRecipe.Meas_W_Settings.Wave3, CurrentRecipe.Meas_W_Settings.Wave4,
            CurrentRecipe.Meas_W_Settings.Wave5, CurrentRecipe.Meas_W_Settings.Wave6
        }
        For idx As Integer = 0 To 5
            If waveEnabled(idx) Then
                steps.Add(New MeasurementStep With {
                    .StepName = "Wave" & (idx + 1),
                    .MeasType = "Wave",
                    .TabIndex = idx + 1,
                    .Tc = waveSettings(idx).Tc,
                    .Tld = waveSettings(idx).Tld
                })
            End If
        Next

        Return steps
    End Function

    ' Function mInitialMachine - Initialize all instruments
    Function mInitialMachine() As Boolean

        mInitialMachine = False

        Try
            ' ดึงค่า GPIB Address จาก CurrentPreferance (user ตั้งไว้ในหน้า Preference)
            Dim gpib As GPIBSettings = CurrentPreferance.GPIB_address

            '----------------------------------------------LD Initial--------------------------------------------------
            'LD1 (Board=0, Port=address จาก Preference)
            clsLD1_ILX.mGPIBNo = gpib.LDT_5910C_TempControlLD
            clsLD1_ILX.mGPIBUnit = 0
            If clsLD1_ILX.LD_Init(clsLD1_ILX.mGPIBUnit, clsLD1_ILX.mGPIBNo, False) = False Then
                gSysLog.LogOut("mInitialMachine: LD1 Init Failed (GPIB=" & gpib.LDT_5910C_TempControlLD & ")")
                Throw New Exception("LD1 initialization failed")
            End If

            'LD2 (ใช้ address เดียวกับ LD1 เพราะเป็นเครื่องเดียวกัน คนละ channel)
            clsLD2_ILX.mGPIBNo = gpib.LDT_5910C_TempControlLD
            clsLD2_ILX.mGPIBUnit = 0
            If clsLD2_ILX.LD_Init(clsLD2_ILX.mGPIBUnit, clsLD2_ILX.mGPIBNo, False) = False Then
                gSysLog.LogOut("mInitialMachine: LD2 Init Failed (GPIB=" & gpib.LDT_5910C_TempControlLD & ")")
                Throw New Exception("LD2 initialization failed")
            End If

            '----------------------------------------------TEC Initial--------------------------------------------------
            'Tc (Case Temperature Controller - FUKKO)
            clsTc_ILX.mGPIBNo = gpib.FUKKO_SYSTEMAT_845TempControlBase
            clsTc_ILX.mGPIBUnit = 0
            If clsTc_ILX.LD_Init(clsTc_ILX.mGPIBUnit, clsTc_ILX.mGPIBNo, False) = False Then
                gSysLog.LogOut("mInitialMachine: Tc Init Failed (GPIB=" & gpib.FUKKO_SYSTEMAT_845TempControlBase & ")")
                Throw New Exception("Tc initialization failed")
            End If

            'Ts (LD Temperature Controller - OFS)
            clsTs_ILX.mGPIBNo = gpib.OFS_1000_TempControlBase
            clsTs_ILX.mGPIBUnit = 0
            If clsTs_ILX.LD_Init(clsTs_ILX.mGPIBUnit, clsTs_ILX.mGPIBNo, False) = False Then
                gSysLog.LogOut("mInitialMachine: Ts Init Failed (GPIB=" & gpib.OFS_1000_TempControlBase & ")")
                Throw New Exception("Ts initialization failed")
            End If

            '----------------------------------------------TEC Output ON--------------------------------------------------
            ' เปิด TEC Output (ต้องเปิดก่อนถึงจะควบคุมอุณหภูมิได้)
            gSysLog.LogOut("mInitialMachine: Turning ON TEC outputs...")
            If clsTc_ILX.LD_TEC_ONOFF(1) = False Then
                gSysLog.LogOut("mInitialMachine: Tc TEC_ON Failed")
                Throw New Exception("Failed to turn ON Tc TEC")
            End If
            If clsTs_ILX.LD_TEC_ONOFF(1) = False Then
                gSysLog.LogOut("mInitialMachine: Ts TEC_ON Failed")
                Throw New Exception("Failed to turn ON Ts TEC")
            End If

            mInitialMachine = True
            gSysLog.LogOut("mInitialMachine: All instruments initialized (LD=" & gpib.LDT_5910C_TempControlLD & ", Tc=" & gpib.FUKKO_SYSTEMAT_845TempControlBase & ", Ts=" & gpib.OFS_1000_TempControlBase & ")")
            gSysLog.LogOut("mInitialMachine: TEC outputs are ON. Ready for temperature control.")

        Catch ex As Exception
            gSysLog.LogOut("mInitialMachine," & ex.Message)
            mInitialMachine = False
        End Try

    End Function

End Class