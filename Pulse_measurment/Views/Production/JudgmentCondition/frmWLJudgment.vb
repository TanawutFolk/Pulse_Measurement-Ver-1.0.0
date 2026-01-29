Public Class frmWLJudgment

    Private Judge_Data As WL_Judge_Group

    ' --------------------- ปุ่ม Cancel ---------------------
    Private Sub btnCancleILm_Click(sender As Object, e As EventArgs) Handles btnCancleILm.Click
        Me.Close()
    End Sub

    ' --------------------- ปุ่ม Save ---------------------
    Private Sub btnSaveWLj_Click(sender As Object, e As EventArgs) Handles btnSaveWLj.Click
        Try
            ' >>>>>>> TAB 1 <<<<<<<
            Judge_Data.Spec1.Select1 = cboSelect1_tab1.Text
            Judge_Data.Spec1.Select2 = cboSelect2_tab1.Text
            Judge_Data.Spec1.PinBand_Min = CDbl(txtPinBandmin_tab1.Text)
            Judge_Data.Spec1.PinBand_Max = CDbl(txtPinBandmax_tab1.Text)

            ' >>>>>>> TAB 2 <<<<<<<
            Judge_Data.Spec2.Select1 = cboSelect1_tab2.Text
            Judge_Data.Spec2.Select2 = cboSelect2_tab2.Text
            Judge_Data.Spec2.PinBand_Min = CDbl(txtPinBandmin_tab2.Text)
            Judge_Data.Spec2.PinBand_Max = CDbl(txtPinBandmax_tab2.Text)

            ' >>>>>>> TAB 3 <<<<<<<
            Judge_Data.Spec3.Select1 = cboSelect1_tab3.Text
            Judge_Data.Spec3.Select2 = cboSelect2_tab3.Text
            Judge_Data.Spec3.PinBand_Min = CDbl(txtPinBandmin_tab3.Text)
            Judge_Data.Spec3.PinBand_Max = CDbl(txtPinBandmax_tab3.Text)

            ' >>>>>>> TAB 4 <<<<<<<
            Judge_Data.Spec4.Select1 = cboSelect1_tab4.Text
            Judge_Data.Spec4.Select2 = cboSelect2_tab4.Text
            Judge_Data.Spec4.PinBand_Min = CDbl(txtPinBandmin_tab4.Text)
            Judge_Data.Spec4.PinBand_Max = CDbl(txtPinBandmax_tab4.Text)

            ' >>>>>>> TAB 5 <<<<<<<
            Judge_Data.Spec5.Select1 = cboSelect1_tab5.Text
            Judge_Data.Spec5.Select2 = cboSelect2_tab5.Text
            Judge_Data.Spec5.PinBand_Min = CDbl(txtPinBandmin_tab5.Text)
            Judge_Data.Spec5.PinBand_Max = CDbl(txtPinBandmax_tab5.Text)

            ' >>>>>>> TAB 6 <<<<<<<
            Judge_Data.Spec6.Select1 = cboSelect1_tab6.Text
            Judge_Data.Spec6.Select2 = cboSelect2_tab6.Text
            Judge_Data.Spec6.PinBand_Min = CDbl(txtPinBandmin_tab6.Text)
            Judge_Data.Spec6.PinBand_Max = CDbl(txtPinBandmax_tab6.Text)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Warning")
        End Try
    End Sub

    ' --------------------- ฟังก์ชัน Load ---------------------
    Public Sub LoadDataToScreen(data As WL_Judge_Group)
        Judge_Data = data

        ' >>>>>>> TAB 1 <<<<<<<
        cboSelect1_tab1.Text = Judge_Data.Spec1.Select1
        cboSelect2_tab1.Text = Judge_Data.Spec1.Select2
        txtPinBandmin_tab1.Text = Judge_Data.Spec1.PinBand_Min.ToString()
        txtPinBandmax_tab1.Text = Judge_Data.Spec1.PinBand_Max.ToString()

        ' >>>>>>> TAB 2 <<<<<<<
        cboSelect1_tab2.Text = Judge_Data.Spec2.Select1
        cboSelect2_tab2.Text = Judge_Data.Spec2.Select2
        txtPinBandmin_tab2.Text = Judge_Data.Spec2.PinBand_Min.ToString()
        txtPinBandmax_tab2.Text = Judge_Data.Spec2.PinBand_Max.ToString()

        ' >>>>>>> TAB 3 <<<<<<<
        cboSelect1_tab3.Text = Judge_Data.Spec3.Select1
        cboSelect2_tab3.Text = Judge_Data.Spec3.Select2
        txtPinBandmin_tab3.Text = Judge_Data.Spec3.PinBand_Min.ToString()
        txtPinBandmax_tab3.Text = Judge_Data.Spec3.PinBand_Max.ToString()

        ' >>>>>>> TAB 4 <<<<<<<
        cboSelect1_tab4.Text = Judge_Data.Spec4.Select1
        cboSelect2_tab4.Text = Judge_Data.Spec4.Select2
        txtPinBandmin_tab4.Text = Judge_Data.Spec4.PinBand_Min.ToString()
        txtPinBandmax_tab4.Text = Judge_Data.Spec4.PinBand_Max.ToString()

        ' >>>>>>> TAB 5 <<<<<<<
        cboSelect1_tab5.Text = Judge_Data.Spec5.Select1
        cboSelect2_tab5.Text = Judge_Data.Spec5.Select2
        txtPinBandmin_tab5.Text = Judge_Data.Spec5.PinBand_Min.ToString()
        txtPinBandmax_tab5.Text = Judge_Data.Spec5.PinBand_Max.ToString()

        ' >>>>>>> TAB 6 <<<<<<<
        cboSelect1_tab6.Text = Judge_Data.Spec6.Select1
        cboSelect2_tab6.Text = Judge_Data.Spec6.Select2
        txtPinBandmin_tab6.Text = Judge_Data.Spec6.PinBand_Min.ToString()
        txtPinBandmax_tab6.Text = Judge_Data.Spec6.PinBand_Max.ToString()

    End Sub


End Class