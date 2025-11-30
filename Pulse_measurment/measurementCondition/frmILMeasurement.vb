Public Class frmILMeasurement
    Private Sub btnCancleILm_Click(sender As Object, e As EventArgs) Handles btnCancleILm.Click
        Me.Close()
    End Sub

    ' ---------------------btnSaveAll_Click---------------------
    Private IL_Data As IL_Group_Settings
    Private Sub btnSaveILm_Click(sender As Object, e As EventArgs) Handles btnSaveILm.Click

        Try

            ' >>>>>>> TAB 1 <<<<<<<
            ' โซน 1
            IL_Data.L1.IfStart = CDbl(txtStart_tab1.Text)
            IL_Data.L1.IfStep = CDbl(txStep_tab1.Text)
            IL_Data.L1.IfStop = CDbl(txStop_tab1.Text)
            IL_Data.L1.Frequency = CDbl(txtFrequn_tab1.Text)
            IL_Data.L1.DutyCycle = CDbl(txtDutycycle_tab1.Text)
            IL_Data.L1.PulseWidth = CDbl(txtPulse_tab1.Text)
            IL_Data.L1.DelayTime = CDbl(txtDelay_tab1.Text)
            IL_Data.L1.PowerAvg = CInt(txtPoweravg_tab1.Text)
            IL_Data.L1.Tc = CDbl(txtTc_tab1.Text)
            IL_Data.L1.Tld = CDbl(txtTld_tab1.Text)
            IL_Data.L1.ICAL = CDbl(txtIcal_tab1.Text)
            IL_Data.L1.ATT = CDbl(txtAtt_tab1.Text)

            ' โซน 2
            IL_Data.L1.FCP = CDbl(txtFcp_tab1.Text)
            IL_Data.L1.FPP = CDbl(txtFpp_tab1.Text)
            IL_Data.L1.FRP = CDbl(txtFrp_tab1.Text)
            IL_Data.L1.FCP2 = CDbl(txtFcp2_tab1.Text)
            IL_Data.L1.FPP2 = CDbl(txtFpp2_tab1.Text)
            IL_Data.L1.FRP2 = CDbl(txtFrp2_tab1.Text)
            IL_Data.L1.FPP3 = CDbl(txtFpp3_tab1.Text)
            IL_Data.L1.FPP4 = CDbl(txtFpp4_tab1.Text)

            ' โซน 3 (Graph)
            IL_Data.L1.Scale_If = CDbl(txtIfscale_tab1.Text)
            IL_Data.L1.Div_If = CDbl(txtIfdiv_tab1.Text)
            IL_Data.L1.Scale_Vf = CDbl(txtVfscale_tab1.Text)
            IL_Data.L1.Div_Vf = CDbl(txtVfdiv_tab1.Text)
            IL_Data.L1.Scale_Po = CDbl(txtPoscale_tab1.Text)
            IL_Data.L1.Div_Po = CDbl(txtPodiv_tab1.Text)
            IL_Data.L1.Scale_SE = CDbl(txtSescale_tab1.Text)
            IL_Data.L1.Div_SE = CDbl(txtSediv_tab1.Text)
            IL_Data.L1.Scale_Rd = CDbl(txtRdscale_tab1.Text)
            IL_Data.L1.Div_Rd = CDbl(txtRddiv_tab1.Text)
            IL_Data.L1.Scale_Im = CDbl(txtImscale_tab1.Text)
            IL_Data.L1.Div_Im = CDbl(txtImdiv_tab1.Text)

            ' >>>>>>> TAB 2 <<<<<<<
            IL_Data.L2.IfStart = CDbl(txtStart_tab2.Text)
            IL_Data.L2.IfStep = CDbl(txStep_tab2.Text)
            IL_Data.L2.IfStop = CDbl(txStop_tab2.Text)
            IL_Data.L2.Frequency = CDbl(txtFrequn_tab2.Text)
            IL_Data.L2.DutyCycle = CDbl(txtDutycycle_tab2.Text)
            IL_Data.L2.PulseWidth = CDbl(txtPulse_tab2.Text)
            IL_Data.L2.DelayTime = CDbl(txtDelay_tab2.Text)
            IL_Data.L2.PowerAvg = CInt(txtPoweravg_tab2.Text)
            IL_Data.L2.Tc = CDbl(txtTc_tab2.Text)
            IL_Data.L2.Tld = CDbl(txtTld_tab2.Text)
            IL_Data.L2.ICAL = CDbl(txtIcal_tab2.Text)
            IL_Data.L2.ATT = CDbl(txtAtt_tab2.Text)

            IL_Data.L2.FCP = CDbl(txtFcp_tab2.Text)
            IL_Data.L2.FPP = CDbl(txtFpp_tab2.Text)
            IL_Data.L2.FRP = CDbl(txtFrp_tab2.Text)
            IL_Data.L2.FCP2 = CDbl(txtFcp2_tab2.Text)
            IL_Data.L2.FPP2 = CDbl(txtFpp2_tab2.Text)
            IL_Data.L2.FRP2 = CDbl(txtFrp2_tab2.Text)
            IL_Data.L2.FPP3 = CDbl(txtFpp3_tab2.Text)
            IL_Data.L2.FPP4 = CDbl(txtFpp4_tab2.Text)

            IL_Data.L2.Scale_If = CDbl(txtIfscale_tab2.Text)
            IL_Data.L2.Div_If = CDbl(txtIfdiv_tab2.Text)
            IL_Data.L2.Scale_Vf = CDbl(txtVfscale_tab2.Text)
            IL_Data.L2.Div_Vf = CDbl(txtVfdiv_tab2.Text)
            IL_Data.L2.Scale_Po = CDbl(txtPoscale_tab2.Text)
            IL_Data.L2.Div_Po = CDbl(txtPodiv_tab2.Text)
            IL_Data.L2.Scale_SE = CDbl(txtSescale_tab2.Text)
            IL_Data.L2.Div_SE = CDbl(txtSediv_tab2.Text)
            IL_Data.L2.Scale_Rd = CDbl(txtRdscale_tab2.Text)
            IL_Data.L2.Div_Rd = CDbl(txtRddiv_tab2.Text)
            IL_Data.L2.Scale_Im = CDbl(txtImscale_tab2.Text)
            IL_Data.L2.Div_Im = CDbl(txtImdiv_tab2.Text)

            ' >>>>>>> TAB 3 <<<<<<<
            IL_Data.L3.IfStart = CDbl(txtStart_tab3.Text)
            IL_Data.L3.IfStep = CDbl(txStep_tab3.Text)
            IL_Data.L3.IfStop = CDbl(txStop_tab3.Text)
            IL_Data.L3.Frequency = CDbl(txtFrequn_tab3.Text)
            IL_Data.L3.DutyCycle = CDbl(txtDutycycle_tab3.Text)
            IL_Data.L3.PulseWidth = CDbl(txtPulse_tab3.Text)
            IL_Data.L3.DelayTime = CDbl(txtDelay_tab3.Text)
            IL_Data.L3.PowerAvg = CInt(txtPoweravg_tab3.Text)
            IL_Data.L3.Tc = CDbl(txtTc_tab3.Text)
            IL_Data.L3.Tld = CDbl(txtTld_tab3.Text)
            IL_Data.L3.ICAL = CDbl(txtIcal_tab3.Text)
            IL_Data.L3.ATT = CDbl(txtAtt_tab3.Text)

            IL_Data.L3.FCP = CDbl(txtFcp_tab3.Text)
            IL_Data.L3.FPP = CDbl(txtFpp_tab3.Text)
            IL_Data.L3.FRP = CDbl(txtFrp_tab3.Text)
            IL_Data.L3.FCP2 = CDbl(txtFcp2_tab3.Text)
            IL_Data.L3.FPP2 = CDbl(txtFpp2_tab3.Text)
            IL_Data.L3.FRP2 = CDbl(txtFrp2_tab3.Text)
            IL_Data.L3.FPP3 = CDbl(txtFpp3_tab3.Text)
            IL_Data.L3.FPP4 = CDbl(txtFpp4_tab3.Text)

            IL_Data.L3.Scale_If = CDbl(txtIfscale_tab3.Text)
            IL_Data.L3.Div_If = CDbl(txtIfdiv_tab3.Text)
            IL_Data.L3.Scale_Vf = CDbl(txtVfscale_tab3.Text)
            IL_Data.L3.Div_Vf = CDbl(txtVfdiv_tab3.Text)
            IL_Data.L3.Scale_Po = CDbl(txtPoscale_tab3.Text)
            IL_Data.L3.Div_Po = CDbl(txtPodiv_tab3.Text)
            IL_Data.L3.Scale_SE = CDbl(txtSescale_tab3.Text)
            IL_Data.L3.Div_SE = CDbl(txtSediv_tab3.Text)
            IL_Data.L3.Scale_Rd = CDbl(txtRdscale_tab3.Text)
            IL_Data.L3.Div_Rd = CDbl(txtRddiv_tab3.Text)
            IL_Data.L3.Scale_Im = CDbl(txtImscale_tab3.Text)
            IL_Data.L3.Div_Im = CDbl(txtImdiv_tab3.Text)

            ' >>>>>>> TAB 4 <<<<<<<
            IL_Data.L4.IfStart = CDbl(txtStart_tab4.Text)
            IL_Data.L4.IfStep = CDbl(txStep_tab4.Text)
            IL_Data.L4.IfStop = CDbl(txStop_tab4.Text)
            IL_Data.L4.Frequency = CDbl(txtFrequn_tab4.Text)
            IL_Data.L4.DutyCycle = CDbl(txtDutycycle_tab4.Text)
            IL_Data.L4.PulseWidth = CDbl(txtPulse_tab4.Text)
            IL_Data.L4.DelayTime = CDbl(txtDelay_tab4.Text)
            IL_Data.L4.PowerAvg = CInt(txtPoweravg_tab4.Text)
            IL_Data.L4.Tc = CDbl(txtTc_tab4.Text)
            IL_Data.L4.Tld = CDbl(txtTld_tab4.Text)
            IL_Data.L4.ICAL = CDbl(txtIcal_tab4.Text)
            IL_Data.L4.ATT = CDbl(txtAtt_tab4.Text)

            IL_Data.L4.FCP = CDbl(txtFcp_tab4.Text)
            IL_Data.L4.FPP = CDbl(txtFpp_tab4.Text)
            IL_Data.L4.FRP = CDbl(txtFrp_tab4.Text)
            IL_Data.L4.FCP2 = CDbl(txtFcp2_tab4.Text)
            IL_Data.L4.FPP2 = CDbl(txtFpp2_tab4.Text)
            IL_Data.L4.FRP2 = CDbl(txtFrp2_tab4.Text)
            IL_Data.L4.FPP3 = CDbl(txtFpp3_tab4.Text)
            IL_Data.L4.FPP4 = CDbl(txtFpp4_tab4.Text)

            IL_Data.L4.Scale_If = CDbl(txtIfscale_tab4.Text)
            IL_Data.L4.Div_If = CDbl(txtIfdiv_tab4.Text)
            IL_Data.L4.Scale_Vf = CDbl(txtVfscale_tab4.Text)
            IL_Data.L4.Div_Vf = CDbl(txtVfdiv_tab4.Text)
            IL_Data.L4.Scale_Po = CDbl(txtPoscale_tab4.Text)
            IL_Data.L4.Div_Po = CDbl(txtPodiv_tab4.Text)
            IL_Data.L4.Scale_SE = CDbl(txtSescale_tab4.Text)
            IL_Data.L4.Div_SE = CDbl(txtSediv_tab4.Text)
            IL_Data.L4.Scale_Rd = CDbl(txtRdscale_tab4.Text)
            IL_Data.L4.Div_Rd = CDbl(txtRddiv_tab4.Text)
            IL_Data.L4.Scale_Im = CDbl(txtImscale_tab4.Text)
            IL_Data.L4.Div_Im = CDbl(txtImdiv_tab4.Text)

            ' >>>>>>> TAB 5 <<<<<<<
            IL_Data.L5.IfStart = CDbl(txtStart_tab5.Text)
            IL_Data.L5.IfStep = CDbl(txStep_tab5.Text)
            IL_Data.L5.IfStop = CDbl(txStop_tab5.Text)
            IL_Data.L5.Frequency = CDbl(txtFrequn_tab5.Text)
            IL_Data.L5.DutyCycle = CDbl(txtDutycycle_tab5.Text)
            IL_Data.L5.PulseWidth = CDbl(txtPulse_tab5.Text)
            IL_Data.L5.DelayTime = CDbl(txtDelay_tab5.Text)
            IL_Data.L5.PowerAvg = CInt(txtPoweravg_tab5.Text)
            IL_Data.L5.Tc = CDbl(txtTc_tab5.Text)
            IL_Data.L5.Tld = CDbl(txtTld_tab5.Text)
            IL_Data.L5.ICAL = CDbl(txtIcal_tab5.Text)
            IL_Data.L5.ATT = CDbl(txtAtt_tab5.Text)

            IL_Data.L5.FCP = CDbl(txtFcp_tab5.Text)
            IL_Data.L5.FPP = CDbl(txtFpp_tab5.Text)
            IL_Data.L5.FRP = CDbl(txtFrp_tab5.Text)
            IL_Data.L5.FCP2 = CDbl(txtFcp2_tab5.Text)
            IL_Data.L5.FPP2 = CDbl(txtFpp2_tab5.Text)
            IL_Data.L5.FRP2 = CDbl(txtFrp2_tab5.Text)
            IL_Data.L5.FPP3 = CDbl(txtFpp3_tab5.Text)
            IL_Data.L5.FPP4 = CDbl(txtFpp4_tab5.Text)

            IL_Data.L5.Scale_If = CDbl(txtIfscale_tab5.Text)
            IL_Data.L5.Div_If = CDbl(txtIfdiv_tab5.Text)
            IL_Data.L5.Scale_Vf = CDbl(txtVfscale_tab5.Text)
            IL_Data.L5.Div_Vf = CDbl(txtVfdiv_tab5.Text)
            IL_Data.L5.Scale_Po = CDbl(txtPoscale_tab5.Text)
            IL_Data.L5.Div_Po = CDbl(txtPodiv_tab.Text)
            IL_Data.L5.Scale_SE = CDbl(txtSescale_tab5.Text)
            IL_Data.L5.Div_SE = CDbl(txtSediv_tab5.Text)
            IL_Data.L5.Scale_Rd = CDbl(txtRdscale_tab5.Text)
            IL_Data.L5.Div_Rd = CDbl(txtRddiv_tab5.Text)
            IL_Data.L5.Scale_Im = CDbl(txtImscale_tab5.Text)
            IL_Data.L5.Div_Im = CDbl(txtImdiv_tab5.Text)

            ' >>>>>>> TAB 6 <<<<<<<
            IL_Data.L6.IfStart = CDbl(txtStart_tab6.Text)
            IL_Data.L6.IfStep = CDbl(txStep_tab6.Text)
            IL_Data.L6.IfStop = CDbl(txStop_tab6.Text)
            IL_Data.L6.Frequency = CDbl(txtFrequn_tab6.Text)
            IL_Data.L6.DutyCycle = CDbl(txtDutycycle_tab6.Text)
            IL_Data.L6.PulseWidth = CDbl(txtPulse_tab6.Text)
            IL_Data.L6.DelayTime = CDbl(txtDelay_tab6.Text)
            IL_Data.L6.PowerAvg = CInt(txtPoweravg_tab6.Text)
            IL_Data.L6.Tc = CDbl(txtTc_tab6.Text)
            IL_Data.L6.Tld = CDbl(txtTld_tab6.Text)
            IL_Data.L6.ICAL = CDbl(txtIcal_tab6.Text)
            IL_Data.L6.ATT = CDbl(txtAtt_tab6.Text)

            IL_Data.L6.FCP = CDbl(txtFcp_tab6.Text)
            IL_Data.L6.FPP = CDbl(txtFpp_tab6.Text)
            IL_Data.L6.FRP = CDbl(txtFrp_tab6.Text)
            IL_Data.L6.FCP2 = CDbl(txtFcp2_tab6.Text)
            IL_Data.L6.FPP2 = CDbl(txtFpp2_tab6.Text)
            IL_Data.L6.FRP2 = CDbl(txtFrp2_tab6.Text)
            IL_Data.L6.FPP3 = CDbl(txtFpp3_tab6.Text)
            IL_Data.L6.FPP4 = CDbl(txtFpp4_tab6.Text)

            IL_Data.L6.Scale_If = CDbl(txtIfscale_tab6.Text)
            IL_Data.L6.Div_If = CDbl(txtIfdiv_tab6.Text)
            IL_Data.L6.Scale_Vf = CDbl(txtVfscale_tab6.Text)
            IL_Data.L6.Div_Vf = CDbl(txtVfdiv_tab6.Text)
            IL_Data.L6.Scale_Po = CDbl(txtPoscale_tab6.Text)
            IL_Data.L6.Div_Po = CDbl(txtPodiv_tab6.Text)
            IL_Data.L6.Scale_SE = CDbl(txtSescale_tab6.Text)
            IL_Data.L6.Div_SE = CDbl(txtSediv_tab6.Text)
            IL_Data.L6.Scale_Rd = CDbl(txtRdscale_tab6.Text)
            IL_Data.L6.Div_Rd = CDbl(txtRddiv_tab6.Text)
            IL_Data.L6.Scale_Im = CDbl(txtImscale_tab6.Text)
            IL_Data.L6.Div_Im = CDbl(txtImdiv_tab6.Text)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("กรุณากรอกตัวเลขให้ครบทุกช่อง", "Warning")
        End Try
    End Sub

    ' ------ฟังก์ชัน Load เอาข้อมูลจากตัวแปร มาแสดงในหน้าจอ--------------------
    Public Sub LoadDataToScreen(data As IL_Group_Settings)
        IL_Data = data
        '--------tab 1----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab1.Text = IL_Data.L1.IfStart.ToString()
        txStep_tab1.Text = IL_Data.L1.IfStep.ToString()
        txStop_tab1.Text = IL_Data.L1.IfStop.ToString()
        txtFrequn_tab1.Text = IL_Data.L1.Frequency.ToString()
        txtDutycycle_tab1.Text = IL_Data.L1.DutyCycle.ToString()
        txtPulse_tab1.Text = IL_Data.L1.PulseWidth.ToString()
        txtDelay_tab1.Text = IL_Data.L1.DelayTime.ToString()
        txtPoweravg_tab1.Text = IL_Data.L1.PowerAvg.ToString()
        txtTc_tab1.Text = IL_Data.L1.Tc.ToString()
        txtTld_tab1.Text = IL_Data.L1.Tld.ToString()
        txtIcal_tab1.Text = IL_Data.L1.ICAL.ToString()
        txtAtt_tab1.Text = IL_Data.L1.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab1.Text = IL_Data.L1.FCP.ToString()
        txtFpp_tab1.Text = IL_Data.L1.FPP.ToString()
        txtFrp_tab1.Text = IL_Data.L1.FRP.ToString()
        txtFcp2_tab1.Text = IL_Data.L1.FCP2.ToString()
        txtFpp2_tab1.Text = IL_Data.L1.FPP2.ToString()
        txtFrp2_tab1.Text = IL_Data.L1.FRP2.ToString()
        txtFpp3_tab1.Text = IL_Data.L1.FPP3.ToString()
        txtFpp4_tab1.Text = IL_Data.L1.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab1.Text = IL_Data.L1.Scale_If.ToString()
        txtIfdiv_tab1.Text = IL_Data.L1.Div_If.ToString() ' <-- ของคุณน่าจะเป็น txtIfdiv_tab1 แก้ตรงนี้เอานะ
        ' Vf
        txtVfscale_tab1.Text = IL_Data.L1.Scale_Vf.ToString()
        txtVfdiv_tab1.Text = IL_Data.L1.Div_Vf.ToString()
        ' Po
        txtPoscale_tab1.Text = IL_Data.L1.Scale_Po.ToString()
        txtPodiv_tab1.Text = IL_Data.L1.Div_Po.ToString()
        ' SE
        txtSescale_tab1.Text = IL_Data.L1.Scale_SE.ToString()
        txtSediv_tab1.Text = IL_Data.L1.Div_SE.ToString()
        ' Rd
        txtRdscale_tab1.Text = IL_Data.L1.Scale_Rd.ToString()
        txtRddiv_tab1.Text = IL_Data.L1.Div_Rd.ToString()
        ' Im
        txtImscale_tab1.Text = IL_Data.L1.Scale_Im.ToString()
        txtImdiv_tab1.Text = IL_Data.L1.Div_Im.ToString()

        '--------tab 2----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab2.Text = IL_Data.L2.IfStart.ToString()
        txStep_tab2.Text = IL_Data.L2.IfStep.ToString()
        txStop_tab2.Text = IL_Data.L2.IfStop.ToString()
        txtFrequn_tab2.Text = IL_Data.L2.Frequency.ToString()
        txtDutycycle_tab2.Text = IL_Data.L2.DutyCycle.ToString()
        txtPulse_tab2.Text = IL_Data.L2.PulseWidth.ToString()
        txtDelay_tab2.Text = IL_Data.L2.DelayTime.ToString()
        txtPoweravg_tab2.Text = IL_Data.L2.PowerAvg.ToString()
        txtTc_tab2.Text = IL_Data.L2.Tc.ToString()
        txtTld_tab2.Text = IL_Data.L2.Tld.ToString()
        txtIcal_tab2.Text = IL_Data.L2.ICAL.ToString()
        txtAtt_tab2.Text = IL_Data.L2.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab2.Text = IL_Data.L2.FCP.ToString()
        txtFpp_tab2.Text = IL_Data.L2.FPP.ToString()
        txtFrp_tab2.Text = IL_Data.L2.FRP.ToString()
        txtFcp2_tab2.Text = IL_Data.L2.FCP2.ToString()
        txtFpp2_tab2.Text = IL_Data.L2.FPP2.ToString()
        txtFrp2_tab2.Text = IL_Data.L2.FRP2.ToString()
        txtFpp3_tab2.Text = IL_Data.L2.FPP3.ToString()
        txtFpp4_tab2.Text = IL_Data.L2.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab2.Text = IL_Data.L2.Scale_If.ToString()
        txtIfdiv_tab2.Text = IL_Data.L2.Div_If.ToString() ' <-- ของคุณน่าจะเป็น txtIfdiv_tab2 แก้ตรงนี้เอานะ
        ' Vf
        txtVfscale_tab2.Text = IL_Data.L2.Scale_Vf.ToString()
        txtVfdiv_tab2.Text = IL_Data.L2.Div_Vf.ToString()
        ' Po
        txtPoscale_tab2.Text = IL_Data.L2.Scale_Po.ToString()
        txtPodiv_tab2.Text = IL_Data.L2.Div_Po.ToString()
        ' SE
        txtSescale_tab2.Text = IL_Data.L2.Scale_SE.ToString()
        txtSediv_tab2.Text = IL_Data.L2.Div_SE.ToString()
        ' Rd
        txtRdscale_tab2.Text = IL_Data.L2.Scale_Rd.ToString()
        txtRddiv_tab2.Text = IL_Data.L2.Div_Rd.ToString()
        ' Im
        txtImscale_tab2.Text = IL_Data.L2.Scale_Im.ToString()
        txtImdiv_tab2.Text = IL_Data.L2.Div_Im.ToString()

        '--------tab 3----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab3.Text = IL_Data.L3.IfStart.ToString()
        txStep_tab3.Text = IL_Data.L3.IfStep.ToString()
        txStop_tab3.Text = IL_Data.L3.IfStop.ToString()
        txtFrequn_tab3.Text = IL_Data.L3.Frequency.ToString()
        txtDutycycle_tab3.Text = IL_Data.L3.DutyCycle.ToString()
        txtPulse_tab3.Text = IL_Data.L3.PulseWidth.ToString()
        txtDelay_tab3.Text = IL_Data.L3.DelayTime.ToString()
        txtPoweravg_tab3.Text = IL_Data.L3.PowerAvg.ToString()
        txtTc_tab3.Text = IL_Data.L3.Tc.ToString()
        txtTld_tab3.Text = IL_Data.L3.Tld.ToString()
        txtIcal_tab3.Text = IL_Data.L3.ICAL.ToString()
        txtAtt_tab3.Text = IL_Data.L3.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab3.Text = IL_Data.L3.FCP.ToString()
        txtFpp_tab3.Text = IL_Data.L3.FPP.ToString()
        txtFrp_tab3.Text = IL_Data.L3.FRP.ToString()
        txtFcp2_tab3.Text = IL_Data.L3.FCP2.ToString()
        txtFpp2_tab3.Text = IL_Data.L3.FPP2.ToString()
        txtFrp2_tab3.Text = IL_Data.L3.FRP2.ToString()
        txtFpp3_tab3.Text = IL_Data.L3.FPP3.ToString()
        txtFpp4_tab3.Text = IL_Data.L3.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab3.Text = IL_Data.L3.Scale_If.ToString()
        txtIfdiv_tab3.Text = IL_Data.L3.Div_If.ToString()
        ' Vf
        txtVfscale_tab3.Text = IL_Data.L3.Scale_Vf.ToString()
        txtVfdiv_tab3.Text = IL_Data.L3.Div_Vf.ToString()
        ' Po
        txtPoscale_tab3.Text = IL_Data.L3.Scale_Po.ToString()
        txtPodiv_tab3.Text = IL_Data.L3.Div_Po.ToString()
        ' SE
        txtSescale_tab3.Text = IL_Data.L3.Scale_SE.ToString()
        txtSediv_tab3.Text = IL_Data.L3.Div_SE.ToString()
        ' Rd
        txtRdscale_tab3.Text = IL_Data.L3.Scale_Rd.ToString()
        txtRddiv_tab3.Text = IL_Data.L3.Div_Rd.ToString()
        ' Im
        txtImscale_tab3.Text = IL_Data.L3.Scale_Im.ToString()
        txtImdiv_tab3.Text = IL_Data.L3.Div_Im.ToString()

        '--------tab 4----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab4.Text = IL_Data.L4.IfStart.ToString()
        txStep_tab4.Text = IL_Data.L4.IfStep.ToString()
        txStop_tab4.Text = IL_Data.L4.IfStop.ToString()
        txtFrequn_tab4.Text = IL_Data.L4.Frequency.ToString()
        txtDutycycle_tab4.Text = IL_Data.L4.DutyCycle.ToString()
        txtPulse_tab4.Text = IL_Data.L4.PulseWidth.ToString()
        txtDelay_tab4.Text = IL_Data.L4.DelayTime.ToString()
        txtPoweravg_tab4.Text = IL_Data.L4.PowerAvg.ToString()
        txtTc_tab4.Text = IL_Data.L4.Tc.ToString()
        txtTld_tab4.Text = IL_Data.L4.Tld.ToString()
        txtIcal_tab4.Text = IL_Data.L4.ICAL.ToString()
        txtAtt_tab4.Text = IL_Data.L4.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab4.Text = IL_Data.L4.FCP.ToString()
        txtFpp_tab4.Text = IL_Data.L4.FPP.ToString()
        txtFrp_tab4.Text = IL_Data.L4.FRP.ToString()
        txtFcp2_tab4.Text = IL_Data.L4.FCP2.ToString()
        txtFpp2_tab4.Text = IL_Data.L4.FPP2.ToString()
        txtFrp2_tab4.Text = IL_Data.L4.FRP2.ToString()
        txtFpp3_tab4.Text = IL_Data.L4.FPP3.ToString()
        txtFpp4_tab4.Text = IL_Data.L4.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab4.Text = IL_Data.L4.Scale_If.ToString()
        txtIfdiv_tab4.Text = IL_Data.L4.Div_If.ToString()
        ' Vf
        txtVfscale_tab4.Text = IL_Data.L4.Scale_Vf.ToString()
        txtVfdiv_tab4.Text = IL_Data.L4.Div_Vf.ToString()
        ' Po
        txtPoscale_tab4.Text = IL_Data.L4.Scale_Po.ToString()
        txtPodiv_tab4.Text = IL_Data.L4.Div_Po.ToString()
        ' SE
        txtSescale_tab4.Text = IL_Data.L4.Scale_SE.ToString()
        txtSediv_tab4.Text = IL_Data.L4.Div_SE.ToString()
        ' Rd
        txtRdscale_tab4.Text = IL_Data.L4.Scale_Rd.ToString()
        txtRddiv_tab4.Text = IL_Data.L4.Div_Rd.ToString()
        ' Im
        txtImscale_tab4.Text = IL_Data.L4.Scale_Im.ToString()
        txtImdiv_tab4.Text = IL_Data.L4.Div_Im.ToString()

        '--------tab 5----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab5.Text = IL_Data.L5.IfStart.ToString()
        txStep_tab5.Text = IL_Data.L5.IfStep.ToString()
        txStop_tab5.Text = IL_Data.L5.IfStop.ToString()
        txtFrequn_tab5.Text = IL_Data.L5.Frequency.ToString()
        txtDutycycle_tab5.Text = IL_Data.L5.DutyCycle.ToString()
        txtPulse_tab5.Text = IL_Data.L5.PulseWidth.ToString()
        txtDelay_tab5.Text = IL_Data.L5.DelayTime.ToString()
        txtPoweravg_tab5.Text = IL_Data.L5.PowerAvg.ToString()
        txtTc_tab5.Text = IL_Data.L5.Tc.ToString()
        txtTld_tab5.Text = IL_Data.L5.Tld.ToString()
        txtIcal_tab5.Text = IL_Data.L5.ICAL.ToString()
        txtAtt_tab5.Text = IL_Data.L5.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab5.Text = IL_Data.L5.FCP.ToString()
        txtFpp_tab5.Text = IL_Data.L5.FPP.ToString()
        txtFrp_tab5.Text = IL_Data.L5.FRP.ToString()
        txtFcp2_tab5.Text = IL_Data.L5.FCP2.ToString()
        txtFpp2_tab5.Text = IL_Data.L5.FPP2.ToString()
        txtFrp2_tab5.Text = IL_Data.L5.FRP2.ToString()
        txtFpp3_tab5.Text = IL_Data.L5.FPP3.ToString()
        txtFpp4_tab5.Text = IL_Data.L5.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab5.Text = IL_Data.L5.Scale_If.ToString()
        txtIfdiv_tab5.Text = IL_Data.L5.Div_If.ToString()
        ' Vf
        txtVfscale_tab5.Text = IL_Data.L5.Scale_Vf.ToString()
        txtVfdiv_tab5.Text = IL_Data.L5.Div_Vf.ToString()
        ' Po
        txtPoscale_tab5.Text = IL_Data.L5.Scale_Po.ToString()
        txtPodiv_tab.Text = IL_Data.L5.Div_Po.ToString()
        ' SE
        txtSescale_tab5.Text = IL_Data.L5.Scale_SE.ToString()
        txtSediv_tab5.Text = IL_Data.L5.Div_SE.ToString()
        ' Rd
        txtRdscale_tab5.Text = IL_Data.L5.Scale_Rd.ToString()
        txtRddiv_tab5.Text = IL_Data.L5.Div_Rd.ToString()
        ' Im
        txtImscale_tab5.Text = IL_Data.L5.Scale_Im.ToString()
        txtImdiv_tab5.Text = IL_Data.L5.Div_Im.ToString()

        '--------tab 6----------------------------------------
        ' --- โซน 1: If Sweep ฝั่งซ้าย ---
        txtStart_tab6.Text = IL_Data.L6.IfStart.ToString()
        txStep_tab6.Text = IL_Data.L6.IfStep.ToString()
        txStop_tab6.Text = IL_Data.L6.IfStop.ToString()
        txtFrequn_tab6.Text = IL_Data.L6.Frequency.ToString()
        txtDutycycle_tab6.Text = IL_Data.L6.DutyCycle.ToString()
        txtPulse_tab6.Text = IL_Data.L6.PulseWidth.ToString()
        txtDelay_tab6.Text = IL_Data.L6.DelayTime.ToString()
        txtPoweravg_tab6.Text = IL_Data.L6.PowerAvg.ToString()
        txtTc_tab6.Text = IL_Data.L6.Tc.ToString()
        txtTld_tab6.Text = IL_Data.L6.Tld.ToString()
        txtIcal_tab6.Text = IL_Data.L6.ICAL.ToString()
        txtAtt_tab6.Text = IL_Data.L6.ATT.ToString()

        ' --- โซน 2: IL Point ตรงกลาง ---
        txtFcp_tab6.Text = IL_Data.L6.FCP.ToString()
        txtFpp_tab6.Text = IL_Data.L6.FPP.ToString()
        txtFrp_tab6.Text = IL_Data.L6.FRP.ToString()
        txtFcp2_tab6.Text = IL_Data.L6.FCP2.ToString()
        txtFpp2_tab6.Text = IL_Data.L6.FPP2.ToString()
        txtFrp2_tab6.Text = IL_Data.L6.FRP2.ToString()
        txtFpp3_tab6.Text = IL_Data.L6.FPP3.ToString()
        txtFpp4_tab6.Text = IL_Data.L6.FPP4.ToString()

        ' --- โซน 3: Graph Scale/Div ฝั่งขวา ---
        ' If
        txtIfscale_tab6.Text = IL_Data.L6.Scale_If.ToString()
        txtIfdiv_tab6.Text = IL_Data.L6.Div_If.ToString()
        ' Vf
        txtVfscale_tab6.Text = IL_Data.L6.Scale_Vf.ToString()
        txtVfdiv_tab6.Text = IL_Data.L6.Div_Vf.ToString()
        ' Po
        txtPoscale_tab6.Text = IL_Data.L6.Scale_Po.ToString()
        txtPodiv_tab6.Text = IL_Data.L6.Div_Po.ToString()
        ' SE
        txtSescale_tab6.Text = IL_Data.L6.Scale_SE.ToString()
        txtSediv_tab6.Text = IL_Data.L6.Div_SE.ToString()
        ' Rd
        txtRdscale_tab6.Text = IL_Data.L6.Scale_Rd.ToString()
        txtRddiv_tab6.Text = IL_Data.L6.Div_Rd.ToString()
        ' Im
        txtImscale_tab6.Text = IL_Data.L6.Scale_Im.ToString()
        txtImdiv_tab6.Text = IL_Data.L6.Div_Im.ToString()
    End Sub

End Class