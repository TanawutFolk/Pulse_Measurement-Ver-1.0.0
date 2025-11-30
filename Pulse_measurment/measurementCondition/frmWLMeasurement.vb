Public Class frmWLMeasurement
    Private Sub btnCancleWLm_Click(sender As Object, e As EventArgs) Handles btnCancleWLm.Click
        Me.Close()
    End Sub

    ' ---------------------btnSaveAll_Click---------------------
    Private WL_Data As WL_Group_Settings
    Private Sub btnSaveWLm_Click(sender As Object, e As EventArgs) Handles btnSaveWLm.Click

        Try
            ' >>>>>>> TAB 1 (Spec1, _tab1) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec1.IfPulse = CDbl(txtIf_tab1.Text)
            WL_Data.Spec1.Frequency = CDbl(txtFrequen_tab1.Text)
            WL_Data.Spec1.DutyCycle = CDbl(txtDuty_tab1.Text)
            WL_Data.Spec1.PulseWidth = CDbl(txtPulse_tab1.Text)
            WL_Data.Spec1.DelayTime = CDbl(txtDelayTimeTab1.Text)
            WL_Data.Spec1.Tc = CDbl(txtTc_tab1.Text)
            WL_Data.Spec1.Tld = CDbl(txtTld_tab1.Text)
            WL_Data.Spec1.ATT = CDbl(txtAtt_tab1.Text)

            WL_Data.Spec1.WLCenter = CDbl(txtWlcenter_tab1.Text)
            WL_Data.Spec1.Span = CDbl(txtSpan_tab1.Text)
            WL_Data.Spec1.RefLevel = CDbl(txtRef_tab1.Text)
            WL_Data.Spec1.Resolution = CDbl(txtResolution_tab1.Text)
            WL_Data.Spec1.Sensitivity = cboSen_tab1.Text ' (String)
            WL_Data.Spec1.Points = CInt(txtPoint_tab1.Text)
            WL_Data.Spec1.Average = CInt(txtAvgtime_tab1.Text)
            WL_Data.Spec1.SweepSpeed = CInt(txtSweepSpeed_tab1.Text)

            WL_Data.Spec1.Point1 = cboMeasurePoint1_tab1.Text ' (String)
            WL_Data.Spec1.Point2 = cboMeasurePoint2_tab1.Text ' (String)


            ' >>>>>>> TAB 2 (Spec2, _tab2) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec2.IfPulse = CDbl(txtIf_tab2.Text)
            WL_Data.Spec2.Frequency = CDbl(txtFrequen_tab2.Text)
            WL_Data.Spec2.DutyCycle = CDbl(txtDuty_tab2.Text)
            WL_Data.Spec2.PulseWidth = CDbl(txtPulse_tab2.Text)
            WL_Data.Spec2.DelayTime = CDbl(txtDelayTimeTab2.Text)
            WL_Data.Spec2.Tc = CDbl(txtTc_tab2.Text)
            WL_Data.Spec2.Tld = CDbl(txtTld_tab2.Text)
            WL_Data.Spec2.ATT = CDbl(txtAtt_tab2.Text)

            WL_Data.Spec2.WLCenter = CDbl(txtWlcenter_tab2.Text)
            WL_Data.Spec2.Span = CDbl(txtSpan_tab2.Text)
            WL_Data.Spec2.RefLevel = CDbl(txtRef_tab2.Text)
            WL_Data.Spec2.Resolution = CDbl(txtResolution_tab2.Text)
            WL_Data.Spec2.Sensitivity = cboSen_tab2.Text
            WL_Data.Spec2.Points = CInt(txtPoint_tab2.Text)
            WL_Data.Spec2.Average = CInt(txtAvgtime_tab2.Text)
            WL_Data.Spec2.SweepSpeed = CInt(txtSweepSpeed_tab2.Text)

            WL_Data.Spec2.Point1 = cboMeasurePoint1_tab2.Text
            WL_Data.Spec2.Point2 = cboMeasurePoint2_tab2.Text


            ' >>>>>>> TAB 3 (Spec3, _tab3) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec3.IfPulse = CDbl(txtIf_tab3.Text)
            WL_Data.Spec3.Frequency = CDbl(txtFrequen_tab3.Text)
            WL_Data.Spec3.DutyCycle = CDbl(txtDuty_tab3.Text)
            WL_Data.Spec3.PulseWidth = CDbl(txtPulse_tab3.Text)
            WL_Data.Spec3.DelayTime = CDbl(txtDelayTimeTab3.Text)
            WL_Data.Spec3.Tc = CDbl(txtTc_tab3.Text)
            WL_Data.Spec3.Tld = CDbl(txtTld_tab3.Text)
            WL_Data.Spec3.ATT = CDbl(txtAtt_tab3.Text)

            WL_Data.Spec3.WLCenter = CDbl(txtWlcenter_tab3.Text)
            WL_Data.Spec3.Span = CDbl(txtSpan_tab3.Text)
            WL_Data.Spec3.RefLevel = CDbl(txtRef_tab3.Text)
            WL_Data.Spec3.Resolution = CDbl(txtResolution_tab3.Text)
            WL_Data.Spec3.Sensitivity = cboSen_tab3.Text
            WL_Data.Spec3.Points = CInt(txtPoint_tab3.Text)
            WL_Data.Spec3.Average = CInt(txtAvgtime_tab3.Text)
            WL_Data.Spec3.SweepSpeed = CInt(txtSweepSpeed_tab3.Text)

            WL_Data.Spec3.Point1 = cboMeasurePoint1_tab3.Text
            WL_Data.Spec3.Point2 = cboMeasurePoint2_tab3.Text


            ' >>>>>>> TAB 4 (Spec4, _tab4) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec4.IfPulse = CDbl(txtIf_tab4.Text)
            WL_Data.Spec4.Frequency = CDbl(txtFrequen_tab4.Text)
            WL_Data.Spec4.DutyCycle = CDbl(txtDuty_tab4.Text)
            WL_Data.Spec4.PulseWidth = CDbl(txtPulse_tab4.Text)
            WL_Data.Spec4.DelayTime = CDbl(txtDelayTimeTab4.Text)
            WL_Data.Spec4.Tc = CDbl(txtTc_tab4.Text)
            WL_Data.Spec4.Tld = CDbl(txtTld_tab4.Text)
            WL_Data.Spec4.ATT = CDbl(txtAtt_tab4.Text)

            WL_Data.Spec4.WLCenter = CDbl(txtWlcenter_tab4.Text)
            WL_Data.Spec4.Span = CDbl(txtSpan_tab4.Text)
            WL_Data.Spec4.RefLevel = CDbl(txtRef_tab4.Text)
            WL_Data.Spec4.Resolution = CDbl(txtResolution_tab4.Text)
            WL_Data.Spec4.Sensitivity = cboSen_tab4.Text
            WL_Data.Spec4.Points = CInt(txtPoint_tab4.Text)
            WL_Data.Spec4.Average = CInt(txtAvgtime_tab4.Text)
            WL_Data.Spec4.SweepSpeed = CInt(txtSweepSpeed_tab4.Text)

            WL_Data.Spec4.Point1 = cboMeasurePoint1_tab4.Text
            WL_Data.Spec4.Point2 = cboMeasurePoint2_tab4.Text


            ' >>>>>>> TAB 5 (Spec5, _tab5) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec5.IfPulse = CDbl(txtIf_tab5.Text)
            WL_Data.Spec5.Frequency = CDbl(txtFrequen_tab5.Text)
            WL_Data.Spec5.DutyCycle = CDbl(txtDuty_tab5.Text)
            WL_Data.Spec5.PulseWidth = CDbl(txtPulse_tab5.Text)
            WL_Data.Spec5.DelayTime = CDbl(txtDelayTimeTab5.Text)
            WL_Data.Spec5.Tc = CDbl(txtTc_tab5.Text)
            WL_Data.Spec5.Tld = CDbl(txtTld_tab5.Text)
            WL_Data.Spec5.ATT = CDbl(txtAtt_tab5.Text)

            WL_Data.Spec5.WLCenter = CDbl(txtWlcenter_tab5.Text)
            WL_Data.Spec5.Span = CDbl(txtSpan_tab5.Text)
            WL_Data.Spec5.RefLevel = CDbl(txtRef_tab5.Text)
            WL_Data.Spec5.Resolution = CDbl(txtResolution_tab5.Text)
            WL_Data.Spec5.Sensitivity = cboSen_tab5.Text
            WL_Data.Spec5.Points = CInt(txtPoint_tab5.Text)
            WL_Data.Spec5.Average = CInt(txtAvgtime_tab5.Text)
            WL_Data.Spec5.SweepSpeed = CInt(txtSweepSpeed_tab5.Text)

            WL_Data.Spec5.Point1 = cboMeasurePoint1_tab5.Text
            WL_Data.Spec5.Point2 = cboMeasurePoint2_tab5.Text


            ' >>>>>>> TAB 6 (Spec6, _tab6) <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            WL_Data.Spec6.IfPulse = CDbl(txtIf_tab6.Text)
            WL_Data.Spec6.Frequency = CDbl(txtFrequen_tab6.Text)
            WL_Data.Spec6.DutyCycle = CDbl(txtDuty_tab6.Text)
            WL_Data.Spec6.PulseWidth = CDbl(txtPulse_tab6.Text)
            WL_Data.Spec6.DelayTime = CDbl(txtDelayTimeTab6.Text)
            WL_Data.Spec6.Tc = CDbl(txtTc_tab6.Text)
            WL_Data.Spec6.Tld = CDbl(txtTld_tab6.Text)
            WL_Data.Spec6.ATT = CDbl(txtAtt_tab6.Text)

            WL_Data.Spec6.WLCenter = CDbl(txtWlcenter_tab6.Text)
            WL_Data.Spec6.Span = CDbl(txtSpan_tab6.Text)
            WL_Data.Spec6.RefLevel = CDbl(txtRef_tab6.Text)
            WL_Data.Spec6.Resolution = CDbl(txtResolution_tab6.Text)
            WL_Data.Spec6.Sensitivity = cboSen_tab6.Text
            WL_Data.Spec6.Points = CInt(txtPoint_tab6.Text)
            WL_Data.Spec6.Average = CInt(txtAvgtime_tab6.Text)
            WL_Data.Spec6.SweepSpeed = CInt(txtSweepSpeed_tab6.Text)

            WL_Data.Spec6.Point1 = cboMeasurePoint1_tab6.Text
            WL_Data.Spec6.Point2 = cboMeasurePoint2_tab6.Text

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("กรุณากรอกตัวเลขให้ครบทุกช่อง", "Warning")
        End Try
    End Sub

    ' --------------------- ฟังก์ชัน Load ดึงข้อมูลมาโชว์ ---------------------
    Public Sub LoadDataToScreen(data As WL_Group_Settings)
        WL_Data = data

        ' >>>>>>> TAB 1 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab1.Text = WL_Data.Spec1.IfPulse.ToString()
        txtFrequen_tab1.Text = WL_Data.Spec1.Frequency.ToString()
        txtDuty_tab1.Text = WL_Data.Spec1.DutyCycle.ToString()
        txtPulse_tab1.Text = WL_Data.Spec1.PulseWidth.ToString()
        txtDelayTimeTab1.Text = WL_Data.Spec1.DelayTime.ToString()
        txtTc_tab1.Text = WL_Data.Spec1.Tc.ToString()
        txtTld_tab1.Text = WL_Data.Spec1.Tld.ToString()
        txtAtt_tab1.Text = WL_Data.Spec1.ATT.ToString()

        txtWlcenter_tab1.Text = WL_Data.Spec1.WLCenter.ToString()
        txtSpan_tab1.Text = WL_Data.Spec1.Span.ToString()
        txtRef_tab1.Text = WL_Data.Spec1.RefLevel.ToString()
        txtResolution_tab1.Text = WL_Data.Spec1.Resolution.ToString()
        cboSen_tab1.Text = WL_Data.Spec1.Sensitivity
        txtPoint_tab1.Text = WL_Data.Spec1.Points.ToString()
        txtAvgtime_tab1.Text = WL_Data.Spec1.Average.ToString()
        txtSweepSpeed_tab1.Text = WL_Data.Spec1.SweepSpeed.ToString()

        cboMeasurePoint1_tab1.Text = WL_Data.Spec1.Point1
        cboMeasurePoint2_tab1.Text = WL_Data.Spec1.Point2

        ' >>>>>>> TAB 2 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab2.Text = WL_Data.Spec2.IfPulse.ToString()
        txtFrequen_tab2.Text = WL_Data.Spec2.Frequency.ToString()
        txtDuty_tab2.Text = WL_Data.Spec2.DutyCycle.ToString()
        txtPulse_tab2.Text = WL_Data.Spec2.PulseWidth.ToString()
        txtDelayTimeTab2.Text = WL_Data.Spec2.DelayTime.ToString()
        txtTc_tab2.Text = WL_Data.Spec2.Tc.ToString()
        txtTld_tab2.Text = WL_Data.Spec2.Tld.ToString()
        txtAtt_tab2.Text = WL_Data.Spec2.ATT.ToString()

        txtWlcenter_tab2.Text = WL_Data.Spec2.WLCenter.ToString()
        txtSpan_tab2.Text = WL_Data.Spec2.Span.ToString()
        txtRef_tab2.Text = WL_Data.Spec2.RefLevel.ToString()
        txtResolution_tab2.Text = WL_Data.Spec2.Resolution.ToString()
        cboSen_tab2.Text = WL_Data.Spec2.Sensitivity
        txtPoint_tab2.Text = WL_Data.Spec2.Points.ToString()
        txtAvgtime_tab2.Text = WL_Data.Spec2.Average.ToString()
        txtSweepSpeed_tab2.Text = WL_Data.Spec2.SweepSpeed.ToString()

        cboMeasurePoint1_tab2.Text = WL_Data.Spec2.Point1
        cboMeasurePoint2_tab2.Text = WL_Data.Spec2.Point2

        ' >>>>>>> TAB 3 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab3.Text = WL_Data.Spec3.IfPulse.ToString()
        txtFrequen_tab3.Text = WL_Data.Spec3.Frequency.ToString()
        txtDuty_tab3.Text = WL_Data.Spec3.DutyCycle.ToString()
        txtPulse_tab3.Text = WL_Data.Spec3.PulseWidth.ToString()
        txtDelayTimeTab3.Text = WL_Data.Spec3.DelayTime.ToString()
        txtTc_tab3.Text = WL_Data.Spec3.Tc.ToString()
        txtTld_tab3.Text = WL_Data.Spec3.Tld.ToString()
        txtAtt_tab3.Text = WL_Data.Spec3.ATT.ToString()

        txtWlcenter_tab3.Text = WL_Data.Spec3.WLCenter.ToString()
        txtSpan_tab3.Text = WL_Data.Spec3.Span.ToString()
        txtRef_tab3.Text = WL_Data.Spec3.RefLevel.ToString()
        txtResolution_tab3.Text = WL_Data.Spec3.Resolution.ToString()
        cboSen_tab3.Text = WL_Data.Spec3.Sensitivity
        txtPoint_tab3.Text = WL_Data.Spec3.Points.ToString()
        txtAvgtime_tab3.Text = WL_Data.Spec3.Average.ToString()
        txtSweepSpeed_tab3.Text = WL_Data.Spec3.SweepSpeed.ToString()

        cboMeasurePoint1_tab3.Text = WL_Data.Spec3.Point1
        cboMeasurePoint2_tab3.Text = WL_Data.Spec3.Point2

        ' >>>>>>> TAB 4 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab4.Text = WL_Data.Spec4.IfPulse.ToString()
        txtFrequen_tab4.Text = WL_Data.Spec4.Frequency.ToString()
        txtDuty_tab4.Text = WL_Data.Spec4.DutyCycle.ToString()
        txtPulse_tab4.Text = WL_Data.Spec4.PulseWidth.ToString()
        txtDelayTimeTab4.Text = WL_Data.Spec4.DelayTime.ToString()
        txtTc_tab4.Text = WL_Data.Spec4.Tc.ToString()
        txtTld_tab4.Text = WL_Data.Spec4.Tld.ToString()
        txtAtt_tab4.Text = WL_Data.Spec4.ATT.ToString()

        txtWlcenter_tab4.Text = WL_Data.Spec4.WLCenter.ToString()
        txtSpan_tab4.Text = WL_Data.Spec4.Span.ToString()
        txtRef_tab4.Text = WL_Data.Spec4.RefLevel.ToString()
        txtResolution_tab4.Text = WL_Data.Spec4.Resolution.ToString()
        cboSen_tab4.Text = WL_Data.Spec4.Sensitivity
        txtPoint_tab4.Text = WL_Data.Spec4.Points.ToString()
        txtAvgtime_tab4.Text = WL_Data.Spec4.Average.ToString()
        txtSweepSpeed_tab4.Text = WL_Data.Spec4.SweepSpeed.ToString()

        cboMeasurePoint1_tab4.Text = WL_Data.Spec4.Point1
        cboMeasurePoint2_tab4.Text = WL_Data.Spec4.Point2

        ' >>>>>>> TAB 5 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab5.Text = WL_Data.Spec5.IfPulse.ToString()
        txtFrequen_tab5.Text = WL_Data.Spec5.Frequency.ToString()
        txtDuty_tab5.Text = WL_Data.Spec5.DutyCycle.ToString()
        txtPulse_tab5.Text = WL_Data.Spec5.PulseWidth.ToString()
        txtDelayTimeTab5.Text = WL_Data.Spec5.DelayTime.ToString()
        txtTc_tab5.Text = WL_Data.Spec5.Tc.ToString()
        txtTld_tab5.Text = WL_Data.Spec5.Tld.ToString()
        txtAtt_tab5.Text = WL_Data.Spec5.ATT.ToString()

        txtWlcenter_tab5.Text = WL_Data.Spec5.WLCenter.ToString()
        txtSpan_tab5.Text = WL_Data.Spec5.Span.ToString()
        txtRef_tab5.Text = WL_Data.Spec5.RefLevel.ToString()
        txtResolution_tab5.Text = WL_Data.Spec5.Resolution.ToString()
        cboSen_tab5.Text = WL_Data.Spec5.Sensitivity
        txtPoint_tab5.Text = WL_Data.Spec5.Points.ToString()
        txtAvgtime_tab5.Text = WL_Data.Spec5.Average.ToString()
        txtSweepSpeed_tab5.Text = WL_Data.Spec5.SweepSpeed.ToString()

        cboMeasurePoint1_tab5.Text = WL_Data.Spec5.Point1
        cboMeasurePoint2_tab5.Text = WL_Data.Spec5.Point2

        ' >>>>>>> TAB 6 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        txtIf_tab6.Text = WL_Data.Spec6.IfPulse.ToString()
        txtFrequen_tab6.Text = WL_Data.Spec6.Frequency.ToString()
        txtDuty_tab6.Text = WL_Data.Spec6.DutyCycle.ToString()
        txtPulse_tab6.Text = WL_Data.Spec6.PulseWidth.ToString()
        txtDelayTimeTab6.Text = WL_Data.Spec6.DelayTime.ToString()
        txtTc_tab6.Text = WL_Data.Spec6.Tc.ToString()
        txtTld_tab6.Text = WL_Data.Spec6.Tld.ToString()
        txtAtt_tab6.Text = WL_Data.Spec6.ATT.ToString()

        txtWlcenter_tab6.Text = WL_Data.Spec6.WLCenter.ToString()
        txtSpan_tab6.Text = WL_Data.Spec6.Span.ToString()
        txtRef_tab6.Text = WL_Data.Spec6.RefLevel.ToString()
        txtResolution_tab6.Text = WL_Data.Spec6.Resolution.ToString()
        cboSen_tab6.Text = WL_Data.Spec6.Sensitivity
        txtPoint_tab6.Text = WL_Data.Spec6.Points.ToString()
        txtAvgtime_tab6.Text = WL_Data.Spec6.Average.ToString()
        txtSweepSpeed_tab6.Text = WL_Data.Spec6.SweepSpeed.ToString()

        cboMeasurePoint1_tab6.Text = WL_Data.Spec6.Point1
        cboMeasurePoint2_tab6.Text = WL_Data.Spec6.Point2

    End Sub

End Class