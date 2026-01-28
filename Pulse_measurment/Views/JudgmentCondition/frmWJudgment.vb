Public Class frmWJudgment

    Private Judge_Data As Wave_Judge_Group

    ' --------------------- btn Cancel ---------------------
    Private Sub btnCancleILm_Click(sender As Object, e As EventArgs) Handles btnCancleILm.Click
        Me.Close()
    End Sub

    ' --------------------- btn Save ---------------------
    Private Sub btnSaveWj_Click(sender As Object, e As EventArgs) Handles btnSaveWj.Click
        Try
            ' >>>>>>> TAB 1 (Wave1) <<<<<<<
            Judge_Data.Wave1.Select1 = cboSelect1_tab1.Text
            Judge_Data.Wave1.Select2 = cboSelect2_tab1.Text

            Judge_Data.Wave1.RiseTime_Min = CDbl(txtRisemin_tab1.Text)
            Judge_Data.Wave1.RiseTime_Max = CDbl(txtRisemax_tab1.Text)
            Judge_Data.Wave1.RiseTime_Start = CDbl(txtRiseStart_tab1.Text)
            Judge_Data.Wave1.RiseTime_Stop = CDbl(txtRiseStop_tab1.Text)

            Judge_Data.Wave1.FallTime_Min = CDbl(txtFallmin_tab1.Text)
            Judge_Data.Wave1.FallTime_Max = CDbl(txtFallmax_tab1.Text)
            Judge_Data.Wave1.FallTime_Start = CDbl(txtFallStart_tab1.Text)
            Judge_Data.Wave1.FallTime_Stop = CDbl(txtFallStop_tab1.Text)

            Judge_Data.Wave1.LockingTime_Min = CDbl(txtFbgLocktimemin_tab1.Text)
            Judge_Data.Wave1.LockingTime_Max = CDbl(txtFbgLocktimemax_tab1.Text)

            Judge_Data.Wave1.SlewRate_Min = CDbl(txtSlew_tab1.Text)
            Judge_Data.Wave1.SlewRate_Max = CDbl(txtSlewmax_tab1.Text)

            ' >>>>>>> TAB 2 (Wave2) <<<<<<<
            Judge_Data.Wave2.Select1 = cboSelect1_tab2.Text
            Judge_Data.Wave2.Select2 = cboSelect2_tab2.Text

            Judge_Data.Wave2.RiseTime_Min = CDbl(txtRisemin_tab2.Text)
            Judge_Data.Wave2.RiseTime_Max = CDbl(txtRisemax_tab2.Text)
            Judge_Data.Wave2.RiseTime_Start = CDbl(txtRiseStart_tab2.Text)
            Judge_Data.Wave2.RiseTime_Stop = CDbl(txtRiseStop_tab2.Text)

            Judge_Data.Wave2.FallTime_Min = CDbl(txtFallmin_tab2.Text)
            Judge_Data.Wave2.FallTime_Max = CDbl(txtFallmax_tab2.Text)
            Judge_Data.Wave2.FallTime_Start = CDbl(txtFallStart_tab2.Text)
            Judge_Data.Wave2.FallTime_Stop = CDbl(txtFallStop_tab2.Text)

            Judge_Data.Wave2.LockingTime_Min = CDbl(txtFbgLocktimemin_tab2.Text)
            Judge_Data.Wave2.LockingTime_Max = CDbl(txtFbgLocktimemax_tab2.Text)

            Judge_Data.Wave2.SlewRate_Min = CDbl(txtSlew_tab2.Text)
            Judge_Data.Wave2.SlewRate_Max = CDbl(txtSlewmax_tab2.Text)

            ' >>>>>>> TAB 3 (Wave3) <<<<<<<
            Judge_Data.Wave3.Select1 = cboSelect1_tab3.Text
            Judge_Data.Wave3.Select2 = cboSelect2_tab3.Text

            Judge_Data.Wave3.RiseTime_Min = CDbl(txtRisemin_tab3.Text)
            Judge_Data.Wave3.RiseTime_Max = CDbl(txtRisemax_tab3.Text)
            Judge_Data.Wave3.RiseTime_Start = CDbl(txtRiseStart_tab3.Text)
            Judge_Data.Wave3.RiseTime_Stop = CDbl(txtRiseStop_tab3.Text)

            Judge_Data.Wave3.FallTime_Min = CDbl(txtFallmin_tab3.Text)
            Judge_Data.Wave3.FallTime_Max = CDbl(txtFallmax_tab3.Text)
            Judge_Data.Wave3.FallTime_Start = CDbl(txtFallStart_tab3.Text)
            Judge_Data.Wave3.FallTime_Stop = CDbl(txtFallStop_tab3.Text)

            Judge_Data.Wave3.LockingTime_Min = CDbl(txtFbgLocktimemin_tab3.Text)
            Judge_Data.Wave3.LockingTime_Max = CDbl(txtFbgLocktimemax_tab3.Text)

            Judge_Data.Wave3.SlewRate_Min = CDbl(txtSlew_tab3.Text)
            Judge_Data.Wave3.SlewRate_Max = CDbl(txtSlewmax_tab3.Text)

            ' >>>>>>> TAB 4 (Wave4) <<<<<<<
            Judge_Data.Wave4.Select1 = cboSelect1_tab4.Text
            Judge_Data.Wave4.Select2 = cboSelect2_tab4.Text

            Judge_Data.Wave4.RiseTime_Min = CDbl(txtRisemin_tab4.Text)
            Judge_Data.Wave4.RiseTime_Max = CDbl(txtRisemax_tab4.Text)
            Judge_Data.Wave4.RiseTime_Start = CDbl(txtRiseStart_tab4.Text)
            Judge_Data.Wave4.RiseTime_Stop = CDbl(txtRiseStop_tab4.Text)

            Judge_Data.Wave4.FallTime_Min = CDbl(txtFallmin_tab4.Text)
            Judge_Data.Wave4.FallTime_Max = CDbl(txtFallmax_tab4.Text)
            Judge_Data.Wave4.FallTime_Start = CDbl(txtFallStart_tab4.Text)
            Judge_Data.Wave4.FallTime_Stop = CDbl(txtFallStop_tab4.Text)

            Judge_Data.Wave4.LockingTime_Min = CDbl(txtFbgLocktimemin_tab4.Text)
            Judge_Data.Wave4.LockingTime_Max = CDbl(txtFbgLocktimemax_tab4.Text)

            Judge_Data.Wave4.SlewRate_Min = CDbl(txtSlew_tab4.Text)
            Judge_Data.Wave4.SlewRate_Max = CDbl(txtSlewmax_tab4.Text)

            ' >>>>>>> TAB 5 (Wave5) <<<<<<<
            Judge_Data.Wave5.Select1 = cboSelect1_tab5.Text
            Judge_Data.Wave5.Select2 = cboSelect2_tab5.Text

            Judge_Data.Wave5.RiseTime_Min = CDbl(txtRisemin_tab5.Text)
            Judge_Data.Wave5.RiseTime_Max = CDbl(txtRisemax_tab5.Text)
            Judge_Data.Wave5.RiseTime_Start = CDbl(txtRiseStart_tab5.Text)
            Judge_Data.Wave5.RiseTime_Stop = CDbl(txtRiseStop_tab5.Text)

            Judge_Data.Wave5.FallTime_Min = CDbl(txtFallmin_tab5.Text)
            Judge_Data.Wave5.FallTime_Max = CDbl(txtFallmax_tab5.Text)
            Judge_Data.Wave5.FallTime_Start = CDbl(txtFallStart_tab5.Text)
            Judge_Data.Wave5.FallTime_Stop = CDbl(txtFallStop_tab5.Text)

            Judge_Data.Wave5.LockingTime_Min = CDbl(txtFbgLocktimemin_tab5.Text)
            Judge_Data.Wave5.LockingTime_Max = CDbl(txtFbgLocktimemax_tab5.Text)

            Judge_Data.Wave5.SlewRate_Min = CDbl(txtSlew_tab5.Text)
            Judge_Data.Wave5.SlewRate_Max = CDbl(txtSlewmax_tab5.Text)

            ' >>>>>>> TAB 6 (Wave6) <<<<<<<
            Judge_Data.Wave6.Select1 = cboSelect1_tab6.Text
            Judge_Data.Wave6.Select2 = cboSelect2_tab6.Text

            Judge_Data.Wave6.RiseTime_Min = CDbl(txtRisemin_tab6.Text)
            Judge_Data.Wave6.RiseTime_Max = CDbl(txtRisemax_tab6.Text)
            Judge_Data.Wave6.RiseTime_Start = CDbl(txtRiseStart_tab6.Text)
            Judge_Data.Wave6.RiseTime_Stop = CDbl(txtRiseStop_tab6.Text)

            Judge_Data.Wave6.FallTime_Min = CDbl(txtFallmin_tab6.Text)
            Judge_Data.Wave6.FallTime_Max = CDbl(txtFallmax_tab6.Text)
            Judge_Data.Wave6.FallTime_Start = CDbl(txtFallStart_tab6.Text)
            Judge_Data.Wave6.FallTime_Stop = CDbl(txtFallStop_tab6.Text)

            Judge_Data.Wave6.LockingTime_Min = CDbl(txtFbgLocktimemin_tab6.Text)
            Judge_Data.Wave6.LockingTime_Max = CDbl(txtFbgLocktimemax_tab6.Text)

            Judge_Data.Wave6.SlewRate_Min = CDbl(txtSlew_tab6.Text)
            Judge_Data.Wave6.SlewRate_Max = CDbl(txtSlewmax_tab6.Text)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Warning")
        End Try
    End Sub

    ' --------------------- ฟังก์ชัน Load ---------------------
    Public Sub LoadDataToScreen(data As Wave_Judge_Group)
        Judge_Data = data

        ' >>>>>>> TAB 1 <<<<<<<
        cboSelect1_tab1.Text = Judge_Data.Wave1.Select1
        cboSelect2_tab1.Text = Judge_Data.Wave1.Select2

        txtRisemin_tab1.Text = Judge_Data.Wave1.RiseTime_Min.ToString()
        txtRisemax_tab1.Text = Judge_Data.Wave1.RiseTime_Max.ToString()
        txtRiseStart_tab1.Text = Judge_Data.Wave1.RiseTime_Start.ToString()
        txtRiseStop_tab1.Text = Judge_Data.Wave1.RiseTime_Stop.ToString()

        txtFallmin_tab1.Text = Judge_Data.Wave1.FallTime_Min.ToString()
        txtFallmax_tab1.Text = Judge_Data.Wave1.FallTime_Max.ToString()
        txtFallStart_tab1.Text = Judge_Data.Wave1.FallTime_Start.ToString()
        txtFallStop_tab1.Text = Judge_Data.Wave1.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab1.Text = Judge_Data.Wave1.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab1.Text = Judge_Data.Wave1.LockingTime_Max.ToString()

        txtSlew_tab1.Text = Judge_Data.Wave1.SlewRate_Min.ToString()
        txtSlewmax_tab1.Text = Judge_Data.Wave1.SlewRate_Max.ToString()

        ' >>>>>>> TAB 2 <<<<<<<
        cboSelect1_tab2.Text = Judge_Data.Wave2.Select1
        cboSelect2_tab2.Text = Judge_Data.Wave2.Select2

        txtRisemin_tab2.Text = Judge_Data.Wave2.RiseTime_Min.ToString()
        txtRisemax_tab2.Text = Judge_Data.Wave2.RiseTime_Max.ToString()
        txtRiseStart_tab2.Text = Judge_Data.Wave2.RiseTime_Start.ToString()
        txtRiseStop_tab2.Text = Judge_Data.Wave2.RiseTime_Stop.ToString()

        txtFallmin_tab2.Text = Judge_Data.Wave2.FallTime_Min.ToString()
        txtFallmax_tab2.Text = Judge_Data.Wave2.FallTime_Max.ToString()
        txtFallStart_tab2.Text = Judge_Data.Wave2.FallTime_Start.ToString()
        txtFallStop_tab2.Text = Judge_Data.Wave2.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab2.Text = Judge_Data.Wave2.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab2.Text = Judge_Data.Wave2.LockingTime_Max.ToString()

        txtSlew_tab2.Text = Judge_Data.Wave2.SlewRate_Min.ToString()
        txtSlewmax_tab2.Text = Judge_Data.Wave2.SlewRate_Max.ToString()

        ' >>>>>>> TAB 3 <<<<<<<
        cboSelect1_tab3.Text = Judge_Data.Wave3.Select1
        cboSelect2_tab3.Text = Judge_Data.Wave3.Select2

        txtRisemin_tab3.Text = Judge_Data.Wave3.RiseTime_Min.ToString()
        txtRisemax_tab3.Text = Judge_Data.Wave3.RiseTime_Max.ToString()
        txtRiseStart_tab3.Text = Judge_Data.Wave3.RiseTime_Start.ToString()
        txtRiseStop_tab3.Text = Judge_Data.Wave3.RiseTime_Stop.ToString()

        txtFallmin_tab3.Text = Judge_Data.Wave3.FallTime_Min.ToString()
        txtFallmax_tab3.Text = Judge_Data.Wave3.FallTime_Max.ToString()
        txtFallStart_tab3.Text = Judge_Data.Wave3.FallTime_Start.ToString()
        txtFallStop_tab3.Text = Judge_Data.Wave3.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab3.Text = Judge_Data.Wave3.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab3.Text = Judge_Data.Wave3.LockingTime_Max.ToString()

        txtSlew_tab3.Text = Judge_Data.Wave3.SlewRate_Min.ToString()
        txtSlewmax_tab3.Text = Judge_Data.Wave3.SlewRate_Max.ToString()

        ' >>>>>>> TAB 4 <<<<<<<
        cboSelect1_tab4.Text = Judge_Data.Wave4.Select1
        cboSelect2_tab4.Text = Judge_Data.Wave4.Select2

        txtRisemin_tab4.Text = Judge_Data.Wave4.RiseTime_Min.ToString()
        txtRisemax_tab4.Text = Judge_Data.Wave4.RiseTime_Max.ToString()
        txtRiseStart_tab4.Text = Judge_Data.Wave4.RiseTime_Start.ToString()
        txtRiseStop_tab4.Text = Judge_Data.Wave4.RiseTime_Stop.ToString()

        txtFallmin_tab4.Text = Judge_Data.Wave4.FallTime_Min.ToString()
        txtFallmax_tab4.Text = Judge_Data.Wave4.FallTime_Max.ToString()
        txtFallStart_tab4.Text = Judge_Data.Wave4.FallTime_Start.ToString()
        txtFallStop_tab4.Text = Judge_Data.Wave4.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab4.Text = Judge_Data.Wave4.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab4.Text = Judge_Data.Wave4.LockingTime_Max.ToString()

        txtSlew_tab4.Text = Judge_Data.Wave4.SlewRate_Min.ToString()
        txtSlewmax_tab4.Text = Judge_Data.Wave4.SlewRate_Max.ToString()

        ' >>>>>>> TAB 5 <<<<<<<
        cboSelect1_tab5.Text = Judge_Data.Wave5.Select1
        cboSelect2_tab5.Text = Judge_Data.Wave5.Select2

        txtRisemin_tab5.Text = Judge_Data.Wave5.RiseTime_Min.ToString()
        txtRisemax_tab5.Text = Judge_Data.Wave5.RiseTime_Max.ToString()
        txtRiseStart_tab5.Text = Judge_Data.Wave5.RiseTime_Start.ToString()
        txtRiseStop_tab5.Text = Judge_Data.Wave5.RiseTime_Stop.ToString()

        txtFallmin_tab5.Text = Judge_Data.Wave5.FallTime_Min.ToString()
        txtFallmax_tab5.Text = Judge_Data.Wave5.FallTime_Max.ToString()
        txtFallStart_tab5.Text = Judge_Data.Wave5.FallTime_Start.ToString()
        txtFallStop_tab5.Text = Judge_Data.Wave5.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab5.Text = Judge_Data.Wave5.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab5.Text = Judge_Data.Wave5.LockingTime_Max.ToString()

        txtSlew_tab5.Text = Judge_Data.Wave5.SlewRate_Min.ToString()
        txtSlewmax_tab5.Text = Judge_Data.Wave5.SlewRate_Max.ToString()

        ' >>>>>>> TAB 6 <<<<<<<
        cboSelect1_tab6.Text = Judge_Data.Wave6.Select1
        cboSelect2_tab6.Text = Judge_Data.Wave6.Select2

        txtRisemin_tab6.Text = Judge_Data.Wave6.RiseTime_Min.ToString()
        txtRisemax_tab6.Text = Judge_Data.Wave6.RiseTime_Max.ToString()
        txtRiseStart_tab6.Text = Judge_Data.Wave6.RiseTime_Start.ToString()
        txtRiseStop_tab6.Text = Judge_Data.Wave6.RiseTime_Stop.ToString()

        txtFallmin_tab6.Text = Judge_Data.Wave6.FallTime_Min.ToString()
        txtFallmax_tab6.Text = Judge_Data.Wave6.FallTime_Max.ToString()
        txtFallStart_tab6.Text = Judge_Data.Wave6.FallTime_Start.ToString()
        txtFallStop_tab6.Text = Judge_Data.Wave6.FallTime_Stop.ToString()

        txtFbgLocktimemin_tab6.Text = Judge_Data.Wave6.LockingTime_Min.ToString()
        txtFbgLocktimemax_tab6.Text = Judge_Data.Wave6.LockingTime_Max.ToString()

        txtSlew_tab6.Text = Judge_Data.Wave6.SlewRate_Min.ToString()
        txtSlewmax_tab6.Text = Judge_Data.Wave6.SlewRate_Max.ToString()
    End Sub

End Class