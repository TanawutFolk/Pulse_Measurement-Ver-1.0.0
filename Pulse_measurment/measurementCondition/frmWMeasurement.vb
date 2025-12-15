Public Class frmWMeasurement

    Private Sub btnCancleILm_Click(sender As Object, e As EventArgs) Handles btnCancleILm.Click
        Me.Close()
    End Sub

    ' ---------------------btnSaveAll_Click---------------------
    Private W_Data As W_Group_Settings
    Private Sub btnSaveWm_Click(sender As Object, e As EventArgs) Handles btnSaveWm.Click
        Try

            ' >>>>>>> TAB 1 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave1.IfPulse = CDbl(txtIf_tab1.Text)
            W_Data.Wave1.Frequency = CDbl(txtFrequen_tab1.Text)
            W_Data.Wave1.DutyCycle = CDbl(txtDuty_tab1.Text)
            W_Data.Wave1.PulseWidth = GetVal(txtPulse_tab1.Text)
            W_Data.Wave1.DelayTime = CDbl(txtDelay_tab1.Text)
            W_Data.Wave1.Average = CDbl(txtAvg_tab1.Text)
            W_Data.Wave1.Tc = CDbl(txtTc_tab1.Text)
            W_Data.Wave1.Tld = CDbl(txtTld_tab1.Text)
            W_Data.Wave1.ATT = CDbl(txtAtt_tab1.Text)

            ' โซน 2 OSC Setting
            W_Data.Wave1.TimePerDiv = CDbl(txtTimediv_tab1.Text)
            W_Data.Wave1.DataPoint = CInt(txtDatapoint_tab1.Text)

            W_Data.Wave1.CH1_Coupling = cboCh1coup_tab1.Text
            W_Data.Wave1.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab1.Text)

            W_Data.Wave1.CH2_Coupling = cboCh2coup_tab1.Text
            W_Data.Wave1.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab1.Text)

            W_Data.Wave1.TriggerSource = cboTrigger_tab1.Text
            W_Data.Wave1.TriggerType = txtTriggerType_tab1.Text
            W_Data.Wave1.TriggerLevel = CDbl(txtTriggerLevel_tab1.Text)
            W_Data.Wave1.TriggerMode = txtTriggerMode_tab1.Text

            ' โซน 3 Measurement point
            W_Data.Wave1.Point1 = cboMeasurePoint1_tab1.Text
            W_Data.Wave1.Point2 = cboMeasurePoint2_tab1.Text

            ' >>>>>>> TAB 2 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave2.IfPulse = CDbl(txtIf_tab2.Text)
            W_Data.Wave2.Frequency = CDbl(txtFrequen_tab2.Text)
            W_Data.Wave2.DutyCycle = CDbl(txtDuty_tab2.Text)
            W_Data.Wave2.PulseWidth = GetVal(txtPulse_tab2.Text)
            W_Data.Wave2.DelayTime = CDbl(txtDelay_tab2.Text)
            W_Data.Wave2.Average = CDbl(txtAvg_tab2.Text)
            W_Data.Wave2.Tc = CDbl(txtTc_tab2.Text)
            W_Data.Wave2.Tld = CDbl(txtTld_tab2.Text)
            W_Data.Wave2.ATT = CDbl(txtAtt_tab2.Text)

            ' โซน 2 OSC Setting
            W_Data.Wave2.TimePerDiv = CDbl(txtTimediv_tab2.Text)
            W_Data.Wave2.DataPoint = CInt(txtDatapoint_tab2.Text)

            W_Data.Wave2.CH1_Coupling = cboCh1coup_tab2.Text
            W_Data.Wave2.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab2.Text)

            W_Data.Wave2.CH2_Coupling = cboCh2coup_tab2.Text
            W_Data.Wave2.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab2.Text)

            W_Data.Wave2.TriggerSource = cboTrigger_tab2.Text
            W_Data.Wave2.TriggerType = txtTriggerType_tab2.Text
            W_Data.Wave2.TriggerLevel = CDbl(txtTriggerLevel_tab2.Text)
            W_Data.Wave2.TriggerMode = txtTriggerMode_tab2.Text

            ' โซน 3 Measurement point
            W_Data.Wave2.Point1 = cboMeasurePoint1_tab2.Text
            W_Data.Wave2.Point2 = cboMeasurePoint2_tab2.Text

            ' >>>>>>> TAB 3 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave3.IfPulse = CDbl(txtIf_tab3.Text)
            W_Data.Wave3.Frequency = CDbl(txtFrequen_tab3.Text)
            W_Data.Wave3.DutyCycle = CDbl(txtDuty_tab3.Text)
            W_Data.Wave3.PulseWidth = GetVal(txtPulse_tab3.Text)
            W_Data.Wave3.DelayTime = CDbl(txtDelay_tab3.Text)
            W_Data.Wave3.Average = CDbl(txtAvg_tab3.Text)
            W_Data.Wave3.Tc = CDbl(txtTc_tab3.Text)
            W_Data.Wave3.Tld = CDbl(txtTld_tab3.Text)
            W_Data.Wave3.ATT = CDbl(txtAtt_tab3.Text)

            ' โซน 2 OSC Setting
            W_Data.Wave3.TimePerDiv = CDbl(txtTimediv_tab3.Text)
            W_Data.Wave3.DataPoint = CInt(txtDatapoint_tab3.Text)

            W_Data.Wave3.CH1_Coupling = cboCh1coup_tab3.Text
            W_Data.Wave3.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab3.Text)

            W_Data.Wave3.CH2_Coupling = cboCh2coup_tab3.Text
            W_Data.Wave3.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab3.Text)

            W_Data.Wave3.TriggerSource = cboTrigger_tab3.Text
            W_Data.Wave3.TriggerType = txtTriggerType_tab3.Text
            W_Data.Wave3.TriggerLevel = CDbl(txtTriggerLevel_tab3.Text)
            W_Data.Wave3.TriggerMode = txtTriggerMode_tab3.Text

            ' โซน 3 Measurement point
            W_Data.Wave3.Point1 = cboMeasurePoint1_tab3.Text
            W_Data.Wave3.Point2 = cboMeasurePoint2_tab3.Text

            ' >>>>>>> TAB 4 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave4.IfPulse = CDbl(txtIf_tab4.Text)
            W_Data.Wave4.Frequency = CDbl(txtFrequen_tab4.Text)
            W_Data.Wave4.DutyCycle = CDbl(txtDuty_tab4.Text)
            W_Data.Wave4.PulseWidth = GetVal(txtPulse_tab4.Text)
            W_Data.Wave4.DelayTime = CDbl(txtDelay_tab4.Text)
            W_Data.Wave4.Average = CDbl(txtAvg_tab4.Text)
            W_Data.Wave4.Tc = CDbl(txtTc_tab4.Text)
            W_Data.Wave4.Tld = CDbl(txtTld_tab4.Text)
            W_Data.Wave4.ATT = CDbl(txtAtt_tab4.Text)

            ' โซน 2 OSC Setting
            ' W_Data.Wave4.TimePerDiv = CDbl(txtTimediv_tab4.Text)  ' TODO: Fix control name in Designer
            W_Data.Wave4.DataPoint = CInt(txtDatapoint_tab4.Text)

            W_Data.Wave4.CH1_Coupling = cboCh1coup_tab4.Text
            W_Data.Wave4.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab4.Text)

            W_Data.Wave4.CH2_Coupling = cboCh2coup_tab4.Text
            W_Data.Wave4.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab4.Text)

            W_Data.Wave4.TriggerSource = cboTrigger_tab4.Text
            W_Data.Wave4.TriggerType = txtTriggerType_tab4.Text
            W_Data.Wave4.TriggerLevel = CDbl(txtTriggerLevel_tab4.Text)
            W_Data.Wave4.TriggerMode = txtTriggerMode_tab4.Text

            ' โซน 3 Measurement point
            W_Data.Wave4.Point1 = cboMeasurePoint1_tab4.Text
            W_Data.Wave4.Point2 = cboMeasurePoint2_tab4.Text

            ' >>>>>>> TAB 5 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave5.IfPulse = CDbl(txtIf_tab5.Text)
            W_Data.Wave5.Frequency = CDbl(txtFrequen_tab5.Text)
            W_Data.Wave5.DutyCycle = CDbl(txtDuty_tab5.Text)
            W_Data.Wave5.PulseWidth = GetVal(txtPulse_tab5.Text)
            W_Data.Wave5.DelayTime = CDbl(txtDelay_tab5.Text)
            W_Data.Wave5.Average = CDbl(txtAvg_tab5.Text)
            W_Data.Wave5.Tc = CDbl(txtTc_tab5.Text)
            W_Data.Wave5.Tld = CDbl(txtTld_tab5.Text)
            W_Data.Wave5.ATT = CDbl(txtAtt_tab5.Text)

            ' โซน 2 OSC Setting
            W_Data.Wave5.TimePerDiv = CDbl(txtTimediv_tab5.Text)
            W_Data.Wave5.DataPoint = CInt(txtDatapoint_tab5.Text)

            W_Data.Wave5.CH1_Coupling = cboCh1coup_tab5.Text
            W_Data.Wave5.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab5.Text)

            W_Data.Wave5.CH2_Coupling = cboCh2coup_tab5.Text
            W_Data.Wave5.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab5.Text)

            W_Data.Wave5.TriggerSource = cboTrigger_tab5.Text
            W_Data.Wave5.TriggerType = txtTriggerType_tab5.Text
            W_Data.Wave5.TriggerLevel = CDbl(txtTriggerLevel_tab5.Text)
            W_Data.Wave5.TriggerMode = txtTriggerMode_tab5.Text

            ' โซน 3 Measurement point
            W_Data.Wave5.Point1 = cboMeasurePoint1_tab5.Text
            W_Data.Wave5.Point2 = cboMeasurePoint2_tab5.Text

            ' >>>>>>> TAB 6 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' โซน 1 Pulse Condition
            W_Data.Wave6.IfPulse = CDbl(txtIf_tab6.Text)
            W_Data.Wave6.Frequency = CDbl(txtFrequen_tab6.Text)
            W_Data.Wave6.DutyCycle = CDbl(txtDuty_tab6.Text)
            W_Data.Wave6.PulseWidth = GetVal(txtPulse_tab6.Text)
            W_Data.Wave6.DelayTime = CDbl(txtDelay_tab6.Text)
            W_Data.Wave6.Average = CDbl(txtAvg_tab6.Text)
            W_Data.Wave6.Tc = CDbl(txtTc_tab6.Text)
            W_Data.Wave6.Tld = CDbl(txtTld_tab6.Text)
            W_Data.Wave6.ATT = CDbl(txtAtt_tab6.Text)

            ' โซน 2 OSC Setting
            W_Data.Wave6.TimePerDiv = CDbl(txtTimediv_tab6.Text)
            W_Data.Wave6.DataPoint = CInt(txtDatapoint_tab6.Text)

            W_Data.Wave6.CH1_Coupling = cboCh1coup_tab6.Text
            W_Data.Wave6.CH1_VoltPerDiv = CDbl(txtCh1Volt_tab6.Text)

            W_Data.Wave6.CH2_Coupling = cboCh2coup_tab6.Text
            W_Data.Wave6.CH2_VoltPerDiv = CDbl(txtCh2Volt_tab6.Text)

            W_Data.Wave6.TriggerSource = cboTrigger_tab6.Text
            W_Data.Wave6.TriggerType = txtTriggerType_tab6.Text
            W_Data.Wave6.TriggerLevel = CDbl(txtTriggerLevel_tab6.Text)
            W_Data.Wave6.TriggerMode = txtTriggerMode_tab6.Text

            ' โซน 3 Measurement point
            W_Data.Wave6.Point1 = cboMeasurePoint1_tab6.Text
            W_Data.Wave6.Point2 = cboMeasurePoint2_tab6.Text

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error in saving W Measurement settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --------------------- ฟังก์ชัน Load (ดึงข้อมูลมาโชว์) ---------------------
    Public Sub LoadDataToScreen(data As W_Group_Settings)
        W_Data = data

        ' >>>>>>> TAB 1 <<<<<<<
        txtIf_tab1.Text = W_Data.Wave1.IfPulse.ToString()
        txtFrequen_tab1.Text = W_Data.Wave1.Frequency.ToString()
        txtDuty_tab1.Text = W_Data.Wave1.DutyCycle.ToString()
        txtPulse_tab1.Text = W_Data.Wave1.PulseWidth.ToString()
        txtDelay_tab1.Text = W_Data.Wave1.DelayTime.ToString()
        txtAvg_tab1.Text = W_Data.Wave1.Average.ToString()
        txtTc_tab1.Text = W_Data.Wave1.Tc.ToString()
        txtTld_tab1.Text = W_Data.Wave1.Tld.ToString()
        txtAtt_tab1.Text = W_Data.Wave1.ATT.ToString()

        txtTimediv_tab1.Text = W_Data.Wave1.TimePerDiv.ToString()
        txtDatapoint_tab1.Text = W_Data.Wave1.DataPoint.ToString()

        cboCh1coup_tab1.Text = W_Data.Wave1.CH1_Coupling
        txtCh1Volt_tab1.Text = W_Data.Wave1.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab1.Text = W_Data.Wave1.CH2_Coupling
        txtCh2Volt_tab1.Text = W_Data.Wave1.CH2_VoltPerDiv.ToString()

        cboTrigger_tab1.Text = W_Data.Wave1.TriggerSource
        txtTriggerType_tab1.Text = W_Data.Wave1.TriggerType
        txtTriggerLevel_tab1.Text = W_Data.Wave1.TriggerLevel.ToString()
        txtTriggerMode_tab1.Text = W_Data.Wave1.TriggerMode

        cboMeasurePoint1_tab1.Text = W_Data.Wave1.Point1
        cboMeasurePoint2_tab1.Text = W_Data.Wave1.Point2

        ' >>>>>>> TAB 2 <<<<<<<
        txtIf_tab2.Text = W_Data.Wave2.IfPulse.ToString()
        txtFrequen_tab2.Text = W_Data.Wave2.Frequency.ToString()
        txtDuty_tab2.Text = W_Data.Wave2.DutyCycle.ToString()
        txtPulse_tab2.Text = W_Data.Wave2.PulseWidth.ToString()
        txtDelay_tab2.Text = W_Data.Wave2.DelayTime.ToString()
        txtAvg_tab2.Text = W_Data.Wave2.Average.ToString()
        txtTc_tab2.Text = W_Data.Wave2.Tc.ToString()
        txtTld_tab2.Text = W_Data.Wave2.Tld.ToString()
        txtAtt_tab2.Text = W_Data.Wave2.ATT.ToString()

        txtTimediv_tab2.Text = W_Data.Wave2.TimePerDiv.ToString()
        txtDatapoint_tab2.Text = W_Data.Wave2.DataPoint.ToString()

        cboCh1coup_tab2.Text = W_Data.Wave2.CH1_Coupling
        txtCh1Volt_tab2.Text = W_Data.Wave2.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab2.Text = W_Data.Wave2.CH2_Coupling
        txtCh2Volt_tab2.Text = W_Data.Wave2.CH2_VoltPerDiv.ToString()

        cboTrigger_tab2.Text = W_Data.Wave2.TriggerSource
        txtTriggerType_tab2.Text = W_Data.Wave2.TriggerType
        txtTriggerLevel_tab2.Text = W_Data.Wave2.TriggerLevel.ToString()
        txtTriggerMode_tab2.Text = W_Data.Wave2.TriggerMode

        cboMeasurePoint1_tab2.Text = W_Data.Wave2.Point1
        cboMeasurePoint2_tab2.Text = W_Data.Wave2.Point2

        ' >>>>>>> TAB 3 <<<<<<<
        txtIf_tab3.Text = W_Data.Wave3.IfPulse.ToString()
        txtFrequen_tab3.Text = W_Data.Wave3.Frequency.ToString()
        txtDuty_tab3.Text = W_Data.Wave3.DutyCycle.ToString()
        txtPulse_tab3.Text = W_Data.Wave3.PulseWidth.ToString()
        txtDelay_tab3.Text = W_Data.Wave3.DelayTime.ToString()
        txtAvg_tab3.Text = W_Data.Wave3.Average.ToString()
        txtTc_tab3.Text = W_Data.Wave3.Tc.ToString()
        txtTld_tab3.Text = W_Data.Wave3.Tld.ToString()
        txtAtt_tab3.Text = W_Data.Wave3.ATT.ToString()

        txtTimediv_tab3.Text = W_Data.Wave3.TimePerDiv.ToString()
        txtDatapoint_tab3.Text = W_Data.Wave3.DataPoint.ToString()

        cboCh1coup_tab3.Text = W_Data.Wave3.CH1_Coupling
        txtCh1Volt_tab3.Text = W_Data.Wave3.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab3.Text = W_Data.Wave3.CH2_Coupling
        txtCh2Volt_tab3.Text = W_Data.Wave3.CH2_VoltPerDiv.ToString()

        cboTrigger_tab3.Text = W_Data.Wave3.TriggerSource
        txtTriggerType_tab3.Text = W_Data.Wave3.TriggerType
        txtTriggerLevel_tab3.Text = W_Data.Wave3.TriggerLevel.ToString()
        txtTriggerMode_tab3.Text = W_Data.Wave3.TriggerMode

        cboMeasurePoint1_tab3.Text = W_Data.Wave3.Point1
        cboMeasurePoint2_tab3.Text = W_Data.Wave3.Point2

        ' >>>>>>> TAB 4 <<<<<<<
        txtIf_tab4.Text = W_Data.Wave4.IfPulse.ToString()
        txtFrequen_tab4.Text = W_Data.Wave4.Frequency.ToString()
        txtDuty_tab4.Text = W_Data.Wave4.DutyCycle.ToString()
        txtPulse_tab4.Text = W_Data.Wave4.PulseWidth.ToString()
        txtDelay_tab4.Text = W_Data.Wave4.DelayTime.ToString()
        txtAvg_tab4.Text = W_Data.Wave4.Average.ToString()
        txtTc_tab4.Text = W_Data.Wave4.Tc.ToString()
        txtTld_tab4.Text = W_Data.Wave4.Tld.ToString()
        txtAtt_tab4.Text = W_Data.Wave4.ATT.ToString()

        ' txtTimediv_tab4.Text = W_Data.Wave4.TimePerDiv.ToString()  ' TODO: Fix control name
        txtDatapoint_tab4.Text = W_Data.Wave4.DataPoint.ToString()

        cboCh1coup_tab4.Text = W_Data.Wave4.CH1_Coupling
        txtCh1Volt_tab4.Text = W_Data.Wave4.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab4.Text = W_Data.Wave4.CH2_Coupling
        txtCh2Volt_tab4.Text = W_Data.Wave4.CH2_VoltPerDiv.ToString()

        cboTrigger_tab4.Text = W_Data.Wave4.TriggerSource
        txtTriggerType_tab4.Text = W_Data.Wave4.TriggerType
        txtTriggerLevel_tab4.Text = W_Data.Wave4.TriggerLevel.ToString()
        txtTriggerMode_tab4.Text = W_Data.Wave4.TriggerMode

        cboMeasurePoint1_tab4.Text = W_Data.Wave4.Point1
        cboMeasurePoint2_tab4.Text = W_Data.Wave4.Point2

        ' >>>>>>> TAB 5 <<<<<<<
        txtIf_tab5.Text = W_Data.Wave5.IfPulse.ToString()
        txtFrequen_tab5.Text = W_Data.Wave5.Frequency.ToString()
        txtDuty_tab5.Text = W_Data.Wave5.DutyCycle.ToString()
        txtPulse_tab5.Text = W_Data.Wave5.PulseWidth.ToString()
        txtDelay_tab5.Text = W_Data.Wave5.DelayTime.ToString()
        txtAvg_tab5.Text = W_Data.Wave5.Average.ToString()
        txtTc_tab5.Text = W_Data.Wave5.Tc.ToString()
        txtTld_tab5.Text = W_Data.Wave5.Tld.ToString()
        txtAtt_tab5.Text = W_Data.Wave5.ATT.ToString()

        txtTimediv_tab5.Text = W_Data.Wave5.TimePerDiv.ToString()
        txtDatapoint_tab5.Text = W_Data.Wave5.DataPoint.ToString()

        cboCh1coup_tab5.Text = W_Data.Wave5.CH1_Coupling
        txtCh1Volt_tab5.Text = W_Data.Wave5.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab5.Text = W_Data.Wave5.CH2_Coupling
        txtCh2Volt_tab5.Text = W_Data.Wave5.CH2_VoltPerDiv.ToString()

        cboTrigger_tab5.Text = W_Data.Wave5.TriggerSource
        txtTriggerType_tab5.Text = W_Data.Wave5.TriggerType
        txtTriggerLevel_tab5.Text = W_Data.Wave5.TriggerLevel.ToString()
        txtTriggerMode_tab5.Text = W_Data.Wave5.TriggerMode

        cboMeasurePoint1_tab5.Text = W_Data.Wave5.Point1
        cboMeasurePoint2_tab5.Text = W_Data.Wave5.Point2

        ' >>>>>>> TAB 6 <<<<<<<
        txtIf_tab6.Text = W_Data.Wave6.IfPulse.ToString()
        txtFrequen_tab6.Text = W_Data.Wave6.Frequency.ToString()
        txtDuty_tab6.Text = W_Data.Wave6.DutyCycle.ToString()
        txtPulse_tab6.Text = W_Data.Wave6.PulseWidth.ToString()
        txtDelay_tab6.Text = W_Data.Wave6.DelayTime.ToString()
        txtAvg_tab6.Text = W_Data.Wave6.Average.ToString()
        txtTc_tab6.Text = W_Data.Wave6.Tc.ToString()
        txtTld_tab6.Text = W_Data.Wave6.Tld.ToString()
        txtAtt_tab6.Text = W_Data.Wave6.ATT.ToString()

        txtTimediv_tab6.Text = W_Data.Wave6.TimePerDiv.ToString()
        txtDatapoint_tab6.Text = W_Data.Wave6.DataPoint.ToString()

        cboCh1coup_tab6.Text = W_Data.Wave6.CH1_Coupling
        txtCh1Volt_tab6.Text = W_Data.Wave6.CH1_VoltPerDiv.ToString()

        cboCh2coup_tab6.Text = W_Data.Wave6.CH2_Coupling
        txtCh2Volt_tab6.Text = W_Data.Wave6.CH2_VoltPerDiv.ToString()

        cboTrigger_tab6.Text = W_Data.Wave6.TriggerSource
        txtTriggerType_tab6.Text = W_Data.Wave6.TriggerType
        txtTriggerLevel_tab6.Text = W_Data.Wave6.TriggerLevel.ToString()
        txtTriggerMode_tab6.Text = W_Data.Wave6.TriggerMode

        cboMeasurePoint1_tab6.Text = W_Data.Wave6.Point1
        cboMeasurePoint2_tab6.Text = W_Data.Wave6.Point2

    End Sub

    Private Function GetVal(text As String) As Double
        If text Is Nothing Then Return 0
        text = text.Trim()

        If text = "" Or text = "-" Then
            Return 0
        End If

        If IsNumeric(text) Then
            Return CDbl(text)
        Else
            Return 0
        End If
    End Function


End Class