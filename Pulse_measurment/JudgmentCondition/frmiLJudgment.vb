Public Class frmiLJudgment

    ' ตัวแปรรับส่งข้อมูล
    Private Judge_Data As IL_Judge_Group

    ' --------------------- btn Cancel ---------------------
    Private Sub btnCancleILj_Click(sender As Object, e As EventArgs) Handles btnCancleILj.Click
        Me.Close()
    End Sub
    ' --------------------- btn Save ---------------------
    Private Sub btnSaveILj_Click(sender As Object, e As EventArgs) Handles btnSaveILj.Click
        Try
            ' >>>>>>> TAB 1 <<<<<<<
            Judge_Data.L1.SelectPoint = cboSelect_tab1.Text
            Judge_Data.L1.Step_mA = CDbl(txtdLdIStep_tab1.Text)
            Judge_Data.L1.Smoothing_pt = CDbl(txtdLdISmoot_tab1.Text)
            Judge_Data.L1.PermissionRate = CDbl(txtdLdIPermis_tab1.Text)

            If rdoEachpoint_tab1.Checked Then Judge_Data.L1.KinkMethod = 0
            If rdoParallel_tab1.Checked Then Judge_Data.L1.KinkMethod = 1

            If rdoStart1_tab1.Checked Then Judge_Data.L1.StartMode = 1
            If rdoStart2_tab1.Checked Then Judge_Data.L1.StartMode = 2
            If rdoStart3_tab1.Checked Then Judge_Data.L1.StartMode = 3

            If rdoEnd1_tab1.Checked Then Judge_Data.L1.EndMode = 1
            If rdoEnd2_tab1.Checked Then Judge_Data.L1.EndMode = 2
            If rdoEnd3_tab1.Checked Then Judge_Data.L1.EndMode = 3

            Judge_Data.L1.Row1_Start_Cbo1 = cboOption1_1_tab1.Text
            Judge_Data.L1.Row1_Start_Cbo2 = cboOption1_2_tab1.Text
            Judge_Data.L1.Row1_Start_Val = CDbl(txtOption1_tab1.Text)

            Judge_Data.L1.Row1_End_Cbo1 = cboOption1End_1_tab1.Text
            Judge_Data.L1.Row1_End_Cbo2 = cboOption1End_2_tab1.Text
            Judge_Data.L1.Row1_End_Val = CDbl(txtOption1End_tab1.Text)

            Judge_Data.L1.Row2_Start_mA = CDbl(txtOption2_tab1.Text)
            Judge_Data.L1.Row2_End_mA = CDbl(txtOption2End_tab1.Text)

            Judge_Data.L1.Row3_Start_mW = CDbl(txtOption3_tab1.Text)
            Judge_Data.L1.Row3_End_mW = CDbl(txtOption3End_tab1.Text)

            If rdoPrimary_tab1.Checked Then Judge_Data.L1.LeastSquaresMode = 0
            If rdoSec_tab1.Checked Then Judge_Data.L1.LeastSquaresMode = 1
            Judge_Data.L1.NumOfPoint = CInt(txtNumpoint_tab1.Text)

            ' >>>>>>> TAB 2 <<<<<<<
            Judge_Data.L2.SelectPoint = cboSelect_tab2.Text
            Judge_Data.L2.Step_mA = CDbl(txtdLdIStep_tab2.Text)
            Judge_Data.L2.Smoothing_pt = CDbl(txtdLdISmoot_tab2.Text)
            Judge_Data.L2.PermissionRate = CDbl(txtdLdIPermis_tab2.Text)

            If rdoEachpoint_tab2.Checked Then Judge_Data.L2.KinkMethod = 0
            If rdoParallel_tab2.Checked Then Judge_Data.L2.KinkMethod = 1

            If rdoStart1_tab2.Checked Then Judge_Data.L2.StartMode = 1
            If rdoStart2_tab2.Checked Then Judge_Data.L2.StartMode = 2
            If rdoStart3_tab2.Checked Then Judge_Data.L2.StartMode = 3

            If rdoEnd1_tab2.Checked Then Judge_Data.L2.EndMode = 1
            If rdoEnd2_tab2.Checked Then Judge_Data.L2.EndMode = 2
            If rdoEnd3_tab2.Checked Then Judge_Data.L2.EndMode = 3

            Judge_Data.L2.Row1_Start_Cbo1 = cboOption1_1_tab2.Text
            Judge_Data.L2.Row1_Start_Cbo2 = cboOption1_2_tab2.Text
            Judge_Data.L2.Row1_Start_Val = CDbl(txtOption1_tab2.Text)

            Judge_Data.L2.Row1_End_Cbo1 = cboOption1End_1_tab2.Text
            Judge_Data.L2.Row1_End_Cbo2 = cboOption1End_2_tab2.Text
            Judge_Data.L2.Row1_End_Val = CDbl(txtOption1End_tab2.Text)

            Judge_Data.L2.Row2_Start_mA = CDbl(txtOption2_tab2.Text)
            Judge_Data.L2.Row2_End_mA = CDbl(txtOption2End_tab2.Text)

            Judge_Data.L2.Row3_Start_mW = CDbl(txtOption3_tab2.Text)
            Judge_Data.L2.Row3_End_mW = CDbl(txtOption3End_tab2.Text)

            If rdoPrimary_tab2.Checked Then Judge_Data.L2.LeastSquaresMode = 0
            If rdoSec_tab2.Checked Then Judge_Data.L2.LeastSquaresMode = 1
            Judge_Data.L2.NumOfPoint = CInt(txtNumpoint_tab2.Text)

            ' >>>>>>> TAB 3 <<<<<<<
            Judge_Data.L3.SelectPoint = cboSelect_tab3.Text
            Judge_Data.L3.Step_mA = CDbl(txtdLdIStep_tab3.Text)
            Judge_Data.L3.Smoothing_pt = CDbl(txtdLdISmoot_tab3.Text)
            Judge_Data.L3.PermissionRate = CDbl(txtdLdIPermis_tab3.Text)

            If rdoEachpoint_tab3.Checked Then Judge_Data.L3.KinkMethod = 0
            If rdoParallel_tab3.Checked Then Judge_Data.L3.KinkMethod = 1

            If rdoStart1_tab3.Checked Then Judge_Data.L3.StartMode = 1
            If rdoStart2_tab3.Checked Then Judge_Data.L3.StartMode = 2
            If rdoStart3_tab3.Checked Then Judge_Data.L3.StartMode = 3

            If rdoEnd1_tab3.Checked Then Judge_Data.L3.EndMode = 1
            If rdoEnd2_tab3.Checked Then Judge_Data.L3.EndMode = 2
            If rdoEnd3_tab3.Checked Then Judge_Data.L3.EndMode = 3

            Judge_Data.L3.Row1_Start_Cbo1 = cboOption1_1_tab3.Text
            Judge_Data.L3.Row1_Start_Cbo2 = cboOption1_2_tab3.Text
            Judge_Data.L3.Row1_Start_Val = CDbl(txtOption1_tab3.Text)

            Judge_Data.L3.Row1_End_Cbo1 = cboOption1End_1_tab3.Text
            Judge_Data.L3.Row1_End_Cbo2 = cboOption1End_2_tab3.Text
            Judge_Data.L3.Row1_End_Val = CDbl(txtOption1End_tab3.Text)

            Judge_Data.L3.Row2_Start_mA = CDbl(txtOption2_tab3.Text)
            Judge_Data.L3.Row2_End_mA = CDbl(txtOption2End_tab3.Text)

            Judge_Data.L3.Row3_Start_mW = CDbl(txtOption3_tab3.Text)
            Judge_Data.L3.Row3_End_mW = CDbl(txtOption3End_tab3.Text)

            If rdoPrimary_tab3.Checked Then Judge_Data.L3.LeastSquaresMode = 0
            If rdoSec_tab3.Checked Then Judge_Data.L3.LeastSquaresMode = 1
            Judge_Data.L3.NumOfPoint = CInt(txtNumpoint_tab3.Text)

            ' >>>>>>> TAB 4 <<<<<<<
            Judge_Data.L4.SelectPoint = cboSelect_tab4.Text
            Judge_Data.L4.Step_mA = CDbl(txtdLdIStep_tab4.Text)
            Judge_Data.L4.Smoothing_pt = CDbl(txtdLdISmoot_tab4.Text)
            Judge_Data.L4.PermissionRate = CDbl(txtdLdIPermisrate_tab4.Text)

            If rdoEachpoint_tab4.Checked Then Judge_Data.L4.KinkMethod = 0
            If rdoParallel_tab4.Checked Then Judge_Data.L4.KinkMethod = 1

            If rdoStart1_tab4.Checked Then Judge_Data.L4.StartMode = 1
            If rdoStart2_tab4.Checked Then Judge_Data.L4.StartMode = 2
            If rdoStart3_tab4.Checked Then Judge_Data.L4.StartMode = 3

            If rdoEnd1_tab4.Checked Then Judge_Data.L4.EndMode = 1
            If rdoEnd2_tab4.Checked Then Judge_Data.L4.EndMode = 2
            If rdoEnd3_tab4.Checked Then Judge_Data.L4.EndMode = 3

            Judge_Data.L4.Row1_Start_Cbo1 = cboOption1_1_tab4.Text
            Judge_Data.L4.Row1_Start_Cbo2 = cboOption1_2_tab4.Text
            Judge_Data.L4.Row1_Start_Val = CDbl(txtOption1_tab4.Text)

            Judge_Data.L4.Row1_End_Cbo1 = cboOption1End_1_tab4.Text
            Judge_Data.L4.Row1_End_Cbo2 = cboOption1End_2_tab4.Text
            Judge_Data.L4.Row1_End_Val = CDbl(txtOption1End_tab4.Text)

            Judge_Data.L4.Row2_Start_mA = CDbl(txtOption2_tab4.Text)
            Judge_Data.L4.Row2_End_mA = CDbl(txtOption2End_tab4.Text)

            Judge_Data.L4.Row3_Start_mW = CDbl(txtOption3_tab4.Text)
            Judge_Data.L4.Row3_End_mW = CDbl(txtOption3End_tab4.Text)

            If rdoPrimary_tab4.Checked Then Judge_Data.L4.LeastSquaresMode = 0
            If rdoSec_tab4.Checked Then Judge_Data.L4.LeastSquaresMode = 1
            Judge_Data.L4.NumOfPoint = CInt(txtNumpoint_tab4.Text)

            ' >>>>>>> TAB 5 <<<<<<<
            Judge_Data.L5.SelectPoint = cboSelect_tab5.Text
            Judge_Data.L5.Step_mA = CDbl(txtdLdIStep_tab5.Text)
            Judge_Data.L5.Smoothing_pt = CDbl(txtdLdISmoot_tab5.Text)
            Judge_Data.L5.PermissionRate = CDbl(txtdLdIPermis_tab5.Text)

            If rdoEachpoint_tab5.Checked Then Judge_Data.L5.KinkMethod = 0
            If rdoParallel_tab5.Checked Then Judge_Data.L5.KinkMethod = 1

            If rdoStart1_tab5.Checked Then Judge_Data.L5.StartMode = 1
            If rdoStart2_tab5.Checked Then Judge_Data.L5.StartMode = 2
            If rdoStart3_tab5.Checked Then Judge_Data.L5.StartMode = 3

            If rdoEnd1_tab5.Checked Then Judge_Data.L5.EndMode = 1
            If rdoEnd2_tab5.Checked Then Judge_Data.L5.EndMode = 2
            If rdoEnd3_tab5.Checked Then Judge_Data.L5.EndMode = 3

            Judge_Data.L5.Row1_Start_Cbo1 = cboOption1_1_tab5.Text
            Judge_Data.L5.Row1_Start_Cbo2 = cboOption1_2_tab5.Text
            Judge_Data.L5.Row1_Start_Val = CDbl(txtOption1_tab5.Text)

            Judge_Data.L5.Row1_End_Cbo1 = cboOption1End_1_tab5.Text
            Judge_Data.L5.Row1_End_Cbo2 = cboOption1End_2_tab5.Text
            Judge_Data.L5.Row1_End_Val = CDbl(txtOption1End_tab5.Text)

            Judge_Data.L5.Row2_Start_mA = CDbl(txtOption2_tab5.Text)
            Judge_Data.L5.Row2_End_mA = CDbl(txtOption2End_tab5.Text)

            Judge_Data.L5.Row3_Start_mW = CDbl(txtOption3_tab5.Text)
            Judge_Data.L5.Row3_End_mW = CDbl(txtOption3End_tab5.Text)

            If rdoPrimary_tab5.Checked Then Judge_Data.L5.LeastSquaresMode = 0
            If rdoSec_tab5.Checked Then Judge_Data.L5.LeastSquaresMode = 1
            Judge_Data.L5.NumOfPoint = CInt(txtNumpoint_tab5.Text)

            ' >>>>>>> TAB 6 <<<<<<<
            Judge_Data.L6.SelectPoint = cboSelect_tab6.Text
            Judge_Data.L6.Step_mA = CDbl(txtdLdIStep_tab6.Text)
            Judge_Data.L6.Smoothing_pt = CDbl(txtdLdISmoot_tab6.Text)
            Judge_Data.L6.PermissionRate = CDbl(txtdLdIPermis_tab6.Text)

            If rdoEachpoint_tab6.Checked Then Judge_Data.L6.KinkMethod = 0
            If rdoParallel_tab6.Checked Then Judge_Data.L6.KinkMethod = 1

            If rdoStart1_tab6.Checked Then Judge_Data.L6.StartMode = 1
            If rdoStart2_tab6.Checked Then Judge_Data.L6.StartMode = 2
            If rdoStart3_tab6.Checked Then Judge_Data.L6.StartMode = 3

            If rdoEnd1_tab6.Checked Then Judge_Data.L6.EndMode = 1
            If rdoEnd2_tab6.Checked Then Judge_Data.L6.EndMode = 2
            If rdoEnd3_tab6.Checked Then Judge_Data.L6.EndMode = 3

            Judge_Data.L6.Row1_Start_Cbo1 = cboOption1_1_tab6.Text
            Judge_Data.L6.Row1_Start_Cbo2 = cboOption1_2_tab6.Text
            Judge_Data.L6.Row1_Start_Val = CDbl(txtOption1_tab6.Text)

            Judge_Data.L6.Row1_End_Cbo1 = cboOption1End_1_tab6.Text
            Judge_Data.L6.Row1_End_Cbo2 = cboOption1End_2_tab6.Text
            Judge_Data.L6.Row1_End_Val = CDbl(txtOption1End_tab6.Text)

            Judge_Data.L6.Row2_Start_mA = CDbl(txtOption2_tab6.Text)
            Judge_Data.L6.Row2_End_mA = CDbl(txtOption2End_tab6.Text)

            Judge_Data.L6.Row3_Start_mW = CDbl(txtOption3_tab6.Text)
            Judge_Data.L6.Row3_End_mW = CDbl(txtOption3End_tab6.Text)

            If rdoPrimary_tab6.Checked Then Judge_Data.L6.LeastSquaresMode = 0
            If rdoSec_tab6.Checked Then Judge_Data.L6.LeastSquaresMode = 1
            Judge_Data.L6.NumOfPoint = CInt(txtNumpoint_tab6.Text)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Warning")
        End Try
    End Sub

    ' --------------------- ฟังก์ชัน Load (ดึงค่ามาโชว์) ---------------------
    Public Sub LoadDataToScreen(data As IL_Judge_Group)
        Judge_Data = data

        ' >>>>>>> TAB 1 <<<<<<<
        cboSelect_tab1.Text = Judge_Data.L1.SelectPoint
        txtdLdIStep_tab1.Text = Judge_Data.L1.Step_mA.ToString()
        txtdLdISmoot_tab1.Text = Judge_Data.L1.Smoothing_pt.ToString()
        txtdLdIPermis_tab1.Text = Judge_Data.L1.PermissionRate.ToString()

        If Judge_Data.L1.KinkMethod = 0 Then rdoEachpoint_tab1.Checked = True
        If Judge_Data.L1.KinkMethod = 1 Then rdoParallel_tab1.Checked = True

        Select Case Judge_Data.L1.StartMode
            Case 1 : rdoStart1_tab1.Checked = True
            Case 2 : rdoStart2_tab1.Checked = True
            Case 3 : rdoStart3_tab1.Checked = True
        End Select

        Select Case Judge_Data.L1.EndMode
            Case 1 : rdoEnd1_tab1.Checked = True
            Case 2 : rdoEnd2_tab1.Checked = True
            Case 3 : rdoEnd3_tab1.Checked = True
        End Select

        cboOption1_1_tab1.Text = Judge_Data.L1.Row1_Start_Cbo1
        cboOption1_2_tab1.Text = Judge_Data.L1.Row1_Start_Cbo2
        txtOption1_tab1.Text = Judge_Data.L1.Row1_Start_Val.ToString()

        cboOption1End_1_tab1.Text = Judge_Data.L1.Row1_End_Cbo1
        cboOption1End_2_tab1.Text = Judge_Data.L1.Row1_End_Cbo2
        txtOption1End_tab1.Text = Judge_Data.L1.Row1_End_Val.ToString()

        txtOption2_tab1.Text = Judge_Data.L1.Row2_Start_mA.ToString()
        txtOption2End_tab1.Text = Judge_Data.L1.Row2_End_mA.ToString()

        txtOption3_tab1.Text = Judge_Data.L1.Row3_Start_mW.ToString()
        txtOption3End_tab1.Text = Judge_Data.L1.Row3_End_mW.ToString()

        If Judge_Data.L1.LeastSquaresMode = 0 Then rdoPrimary_tab1.Checked = True
        If Judge_Data.L1.LeastSquaresMode = 1 Then rdoSec_tab1.Checked = True
        txtNumpoint_tab1.Text = Judge_Data.L1.NumOfPoint.ToString()

        ' >>>>>>> TAB 2 <<<<<<<
        cboSelect_tab2.Text = Judge_Data.L2.SelectPoint
        txtdLdIStep_tab2.Text = Judge_Data.L2.Step_mA.ToString()
        txtdLdISmoot_tab2.Text = Judge_Data.L2.Smoothing_pt.ToString()
        txtdLdIPermis_tab2.Text = Judge_Data.L2.PermissionRate.ToString()

        If Judge_Data.L2.KinkMethod = 0 Then rdoEachpoint_tab2.Checked = True
        If Judge_Data.L2.KinkMethod = 1 Then rdoParallel_tab2.Checked = True

        Select Case Judge_Data.L2.StartMode
            Case 1 : rdoStart1_tab2.Checked = True
            Case 2 : rdoStart2_tab2.Checked = True
            Case 3 : rdoStart3_tab2.Checked = True
        End Select

        Select Case Judge_Data.L2.EndMode
            Case 1 : rdoEnd1_tab2.Checked = True
            Case 2 : rdoEnd2_tab2.Checked = True
            Case 3 : rdoEnd3_tab2.Checked = True
        End Select

        cboOption1_1_tab2.Text = Judge_Data.L2.Row1_Start_Cbo1
        cboOption1_2_tab2.Text = Judge_Data.L2.Row1_Start_Cbo2
        txtOption1_tab2.Text = Judge_Data.L2.Row1_Start_Val.ToString()

        cboOption1End_1_tab2.Text = Judge_Data.L2.Row1_End_Cbo1
        cboOption1End_2_tab2.Text = Judge_Data.L2.Row1_End_Cbo2
        txtOption1End_tab2.Text = Judge_Data.L2.Row1_End_Val.ToString()

        txtOption2_tab2.Text = Judge_Data.L2.Row2_Start_mA.ToString()
        txtOption2End_tab2.Text = Judge_Data.L2.Row2_End_mA.ToString()

        txtOption3_tab2.Text = Judge_Data.L2.Row3_Start_mW.ToString()
        txtOption3End_tab2.Text = Judge_Data.L2.Row3_End_mW.ToString()

        If Judge_Data.L2.LeastSquaresMode = 0 Then rdoPrimary_tab2.Checked = True
        If Judge_Data.L2.LeastSquaresMode = 1 Then rdoSec_tab2.Checked = True
        txtNumpoint_tab2.Text = Judge_Data.L2.NumOfPoint.ToString()

        ' >>>>>>> TAB 3 <<<<<<<
        cboSelect_tab3.Text = Judge_Data.L3.SelectPoint
        txtdLdIStep_tab3.Text = Judge_Data.L3.Step_mA.ToString()
        txtdLdISmoot_tab3.Text = Judge_Data.L3.Smoothing_pt.ToString()
        txtdLdIPermis_tab3.Text = Judge_Data.L3.PermissionRate.ToString()

        If Judge_Data.L3.KinkMethod = 0 Then rdoEachpoint_tab3.Checked = True
        If Judge_Data.L3.KinkMethod = 1 Then rdoParallel_tab3.Checked = True

        Select Case Judge_Data.L3.StartMode
            Case 1 : rdoStart1_tab3.Checked = True
            Case 2 : rdoStart2_tab3.Checked = True
            Case 3 : rdoStart3_tab3.Checked = True
        End Select

        Select Case Judge_Data.L3.EndMode
            Case 1 : rdoEnd1_tab3.Checked = True
            Case 2 : rdoEnd2_tab3.Checked = True
            Case 3 : rdoEnd3_tab3.Checked = True
        End Select

        cboOption1_1_tab3.Text = Judge_Data.L3.Row1_Start_Cbo1
        cboOption1_2_tab3.Text = Judge_Data.L3.Row1_Start_Cbo2
        txtOption1_tab3.Text = Judge_Data.L3.Row1_Start_Val.ToString()

        cboOption1End_1_tab3.Text = Judge_Data.L3.Row1_End_Cbo1
        cboOption1End_2_tab3.Text = Judge_Data.L3.Row1_End_Cbo2
        txtOption1End_tab3.Text = Judge_Data.L3.Row1_End_Val.ToString()

        txtOption2_tab3.Text = Judge_Data.L3.Row2_Start_mA.ToString()
        txtOption2End_tab3.Text = Judge_Data.L3.Row2_End_mA.ToString()

        txtOption3_tab3.Text = Judge_Data.L3.Row3_Start_mW.ToString()
        txtOption3End_tab3.Text = Judge_Data.L3.Row3_End_mW.ToString()

        If Judge_Data.L3.LeastSquaresMode = 0 Then rdoPrimary_tab3.Checked = True
        If Judge_Data.L3.LeastSquaresMode = 1 Then rdoSec_tab3.Checked = True
        txtNumpoint_tab3.Text = Judge_Data.L3.NumOfPoint.ToString()

        ' >>>>>>> TAB 4 <<<<<<<
        cboSelect_tab4.Text = Judge_Data.L4.SelectPoint
        txtdLdIStep_tab4.Text = Judge_Data.L4.Step_mA.ToString()
        txtdLdISmoot_tab4.Text = Judge_Data.L4.Smoothing_pt.ToString()
        txtdLdIPermisrate_tab4.Text = Judge_Data.L4.PermissionRate.ToString()

        If Judge_Data.L4.KinkMethod = 0 Then rdoEachpoint_tab4.Checked = True
        If Judge_Data.L4.KinkMethod = 1 Then rdoParallel_tab4.Checked = True

        Select Case Judge_Data.L4.StartMode
            Case 1 : rdoStart1_tab4.Checked = True
            Case 2 : rdoStart2_tab4.Checked = True
            Case 3 : rdoStart3_tab4.Checked = True
        End Select

        Select Case Judge_Data.L4.EndMode
            Case 1 : rdoEnd1_tab4.Checked = True
            Case 2 : rdoEnd2_tab4.Checked = True
            Case 3 : rdoEnd3_tab4.Checked = True
        End Select

        cboOption1_1_tab4.Text = Judge_Data.L4.Row1_Start_Cbo1
        cboOption1_2_tab4.Text = Judge_Data.L4.Row1_Start_Cbo2
        txtOption1_tab4.Text = Judge_Data.L4.Row1_Start_Val.ToString()

        cboOption1End_1_tab4.Text = Judge_Data.L4.Row1_End_Cbo1
        cboOption1End_2_tab4.Text = Judge_Data.L4.Row1_End_Cbo2
        txtOption1End_tab4.Text = Judge_Data.L4.Row1_End_Val.ToString()

        txtOption2_tab4.Text = Judge_Data.L4.Row2_Start_mA.ToString()
        txtOption2End_tab4.Text = Judge_Data.L4.Row2_End_mA.ToString()

        txtOption3_tab4.Text = Judge_Data.L4.Row3_Start_mW.ToString()
        txtOption3End_tab4.Text = Judge_Data.L4.Row3_End_mW.ToString()

        If Judge_Data.L4.LeastSquaresMode = 0 Then rdoPrimary_tab4.Checked = True
        If Judge_Data.L4.LeastSquaresMode = 1 Then rdoSec_tab4.Checked = True
        txtNumpoint_tab4.Text = Judge_Data.L4.NumOfPoint.ToString()

        ' >>>>>>> TAB 5 <<<<<<<
        cboSelect_tab5.Text = Judge_Data.L5.SelectPoint
        txtdLdIStep_tab5.Text = Judge_Data.L5.Step_mA.ToString()
        txtdLdISmoot_tab5.Text = Judge_Data.L5.Smoothing_pt.ToString()
        txtdLdIPermis_tab5.Text = Judge_Data.L5.PermissionRate.ToString()

        If Judge_Data.L5.KinkMethod = 0 Then rdoEachpoint_tab5.Checked = True
        If Judge_Data.L5.KinkMethod = 1 Then rdoParallel_tab5.Checked = True

        Select Case Judge_Data.L5.StartMode
            Case 1 : rdoStart1_tab5.Checked = True
            Case 2 : rdoStart2_tab5.Checked = True
            Case 3 : rdoStart3_tab5.Checked = True
        End Select

        Select Case Judge_Data.L5.EndMode
            Case 1 : rdoEnd1_tab5.Checked = True
            Case 2 : rdoEnd2_tab5.Checked = True
            Case 3 : rdoEnd3_tab5.Checked = True
        End Select

        cboOption1_1_tab5.Text = Judge_Data.L5.Row1_Start_Cbo1
        cboOption1_2_tab5.Text = Judge_Data.L5.Row1_Start_Cbo2
        txtOption1_tab5.Text = Judge_Data.L5.Row1_Start_Val.ToString()

        cboOption1End_1_tab5.Text = Judge_Data.L5.Row1_End_Cbo1
        cboOption1End_2_tab5.Text = Judge_Data.L5.Row1_End_Cbo2
        txtOption1End_tab5.Text = Judge_Data.L5.Row1_End_Val.ToString()

        txtOption2_tab5.Text = Judge_Data.L5.Row2_Start_mA.ToString()
        txtOption2End_tab5.Text = Judge_Data.L5.Row2_End_mA.ToString()

        txtOption3_tab5.Text = Judge_Data.L5.Row3_Start_mW.ToString()
        txtOption3End_tab5.Text = Judge_Data.L5.Row3_End_mW.ToString()

        If Judge_Data.L5.LeastSquaresMode = 0 Then rdoPrimary_tab5.Checked = True
        If Judge_Data.L5.LeastSquaresMode = 1 Then rdoSec_tab5.Checked = True
        txtNumpoint_tab5.Text = Judge_Data.L5.NumOfPoint.ToString()

        ' >>>>>>> TAB 6 <<<<<<<
        cboSelect_tab6.Text = Judge_Data.L6.SelectPoint
        txtdLdIStep_tab6.Text = Judge_Data.L6.Step_mA.ToString()
        txtdLdISmoot_tab6.Text = Judge_Data.L6.Smoothing_pt.ToString()
        txtdLdIPermis_tab6.Text = Judge_Data.L6.PermissionRate.ToString()

        If Judge_Data.L6.KinkMethod = 0 Then rdoEachpoint_tab6.Checked = True
        If Judge_Data.L6.KinkMethod = 1 Then rdoParallel_tab6.Checked = True

        Select Case Judge_Data.L6.StartMode
            Case 1 : rdoStart1_tab6.Checked = True
            Case 2 : rdoStart2_tab6.Checked = True
            Case 3 : rdoStart3_tab6.Checked = True
        End Select

        Select Case Judge_Data.L6.EndMode
            Case 1 : rdoEnd1_tab6.Checked = True
            Case 2 : rdoEnd2_tab6.Checked = True
            Case 3 : rdoEnd3_tab6.Checked = True
        End Select

        cboOption1_1_tab6.Text = Judge_Data.L6.Row1_Start_Cbo1
        cboOption1_2_tab6.Text = Judge_Data.L6.Row1_Start_Cbo2
        txtOption1_tab6.Text = Judge_Data.L6.Row1_Start_Val.ToString()

        cboOption1End_1_tab6.Text = Judge_Data.L6.Row1_End_Cbo1
        cboOption1End_2_tab6.Text = Judge_Data.L6.Row1_End_Cbo2
        txtOption1End_tab6.Text = Judge_Data.L6.Row1_End_Val.ToString()

        txtOption2_tab6.Text = Judge_Data.L6.Row2_Start_mA.ToString()
        txtOption2End_tab6.Text = Judge_Data.L6.Row2_End_mA.ToString()

        txtOption3_tab6.Text = Judge_Data.L6.Row3_Start_mW.ToString()
        txtOption3End_tab6.Text = Judge_Data.L6.Row3_End_mW.ToString()

        If Judge_Data.L6.LeastSquaresMode = 0 Then rdoPrimary_tab6.Checked = True
        If Judge_Data.L6.LeastSquaresMode = 1 Then rdoSec_tab6.Checked = True
        txtNumpoint_tab6.Text = Judge_Data.L6.NumOfPoint.ToString()

    End Sub
End Class