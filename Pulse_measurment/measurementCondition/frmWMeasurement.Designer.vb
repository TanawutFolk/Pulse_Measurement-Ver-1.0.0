<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWMeasurement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabsWaveform = New System.Windows.Forms.TabControl()
        Me.WaveForm1 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab1 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab1 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab1 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab1 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab1 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab1 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab1 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab1 = New System.Windows.Forms.TextBox()
        Me.txtTimediv_tab1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAtt_tab1 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab1 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab1 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab1 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab1 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab1 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab1 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab1 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab1 = New System.Windows.Forms.TextBox()
        Me.Label229 = New System.Windows.Forms.Label()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.Label234 = New System.Windows.Forms.Label()
        Me.Label235 = New System.Windows.Forms.Label()
        Me.Label236 = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.Label239 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab1 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WaveForm2 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab2 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab2 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab2 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab2 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab2 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab2 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab2 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab2 = New System.Windows.Forms.TextBox()
        Me.txtTimediv_tab2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAtt_tab2 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab2 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab2 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab2 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab2 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab2 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab2 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab2 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab2 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab2 = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.WaveForm3 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab3 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab3 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab3 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab3 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab3 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab3 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab3 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab3 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab3 = New System.Windows.Forms.TextBox()
        Me.txtTimediv_tab3 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtAtt_tab3 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab3 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab3 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab3 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab3 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab3 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab3 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab3 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab3 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab3 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab3 = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.WaveForm4 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab4 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab4 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab4 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab4 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab4 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab4 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab4 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab4 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab4 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtAtt_tab4 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab4 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab4 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab4 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab4 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab4 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab4 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab4 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab4 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab4 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab4 = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.WaveForm5 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab5 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab5 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab5 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab5 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab5 = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab5 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab5 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab5 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab5 = New System.Windows.Forms.TextBox()
        Me.txtTimediv_tab5 = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txtAtt_tab5 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab5 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab5 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab5 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab5 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab5 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab5 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab5 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab5 = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab5 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab5 = New System.Windows.Forms.ComboBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.WaveForm6 = New System.Windows.Forms.TabPage()
        Me.cboTrigger_tab6 = New System.Windows.Forms.ComboBox()
        Me.cboCh2coup_tab6 = New System.Windows.Forms.ComboBox()
        Me.cboCh1coup_tab6 = New System.Windows.Forms.ComboBox()
        Me.txtTriggerMode_tab6 = New System.Windows.Forms.TextBox()
        Me.txtTriggerLevel_tab6 = New System.Windows.Forms.TextBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.txtTriggerType_tab6 = New System.Windows.Forms.TextBox()
        Me.txtCh2Volt_tab6 = New System.Windows.Forms.TextBox()
        Me.txtCh1Volt_tab6 = New System.Windows.Forms.TextBox()
        Me.txtDatapoint_tab6 = New System.Windows.Forms.TextBox()
        Me.txtTimediv_tab6 = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.txtAtt_tab6 = New System.Windows.Forms.TextBox()
        Me.txtTld_tab6 = New System.Windows.Forms.TextBox()
        Me.txtTc_tab6 = New System.Windows.Forms.TextBox()
        Me.txtAvg_tab6 = New System.Windows.Forms.TextBox()
        Me.txtDelay_tab6 = New System.Windows.Forms.TextBox()
        Me.txtPulse_tab6 = New System.Windows.Forms.TextBox()
        Me.txtDuty_tab6 = New System.Windows.Forms.TextBox()
        Me.txtFrequen_tab6 = New System.Windows.Forms.TextBox()
        Me.txtIf_tab6 = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.cboMeasurePoint2_tab6 = New System.Windows.Forms.ComboBox()
        Me.cboMeasurePoint1_tab6 = New System.Windows.Forms.ComboBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.btnCancleILm = New System.Windows.Forms.Button()
        Me.btnSaveILm = New System.Windows.Forms.Button()
        Me.tabsWaveform.SuspendLayout()
        Me.WaveForm1.SuspendLayout()
        Me.WaveForm2.SuspendLayout()
        Me.WaveForm3.SuspendLayout()
        Me.WaveForm4.SuspendLayout()
        Me.WaveForm5.SuspendLayout()
        Me.WaveForm6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabsWaveform
        '
        Me.tabsWaveform.Controls.Add(Me.WaveForm1)
        Me.tabsWaveform.Controls.Add(Me.WaveForm2)
        Me.tabsWaveform.Controls.Add(Me.WaveForm3)
        Me.tabsWaveform.Controls.Add(Me.WaveForm4)
        Me.tabsWaveform.Controls.Add(Me.WaveForm5)
        Me.tabsWaveform.Controls.Add(Me.WaveForm6)
        Me.tabsWaveform.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabsWaveform.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabsWaveform.Location = New System.Drawing.Point(0, 0)
        Me.tabsWaveform.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabsWaveform.Name = "tabsWaveform"
        Me.tabsWaveform.Padding = New System.Drawing.Point(18, 3)
        Me.tabsWaveform.SelectedIndex = 0
        Me.tabsWaveform.Size = New System.Drawing.Size(750, 518)
        Me.tabsWaveform.TabIndex = 1
        '
        'WaveForm1
        '
        Me.WaveForm1.Controls.Add(Me.cboTrigger_tab1)
        Me.WaveForm1.Controls.Add(Me.cboCh2coup_tab1)
        Me.WaveForm1.Controls.Add(Me.cboCh1coup_tab1)
        Me.WaveForm1.Controls.Add(Me.txtTriggerMode_tab1)
        Me.WaveForm1.Controls.Add(Me.txtTriggerLevel_tab1)
        Me.WaveForm1.Controls.Add(Me.Label3)
        Me.WaveForm1.Controls.Add(Me.Label6)
        Me.WaveForm1.Controls.Add(Me.txtTriggerType_tab1)
        Me.WaveForm1.Controls.Add(Me.txtCh2Volt_tab1)
        Me.WaveForm1.Controls.Add(Me.txtCh1Volt_tab1)
        Me.WaveForm1.Controls.Add(Me.txtDatapoint_tab1)
        Me.WaveForm1.Controls.Add(Me.txtTimediv_tab1)
        Me.WaveForm1.Controls.Add(Me.Label1)
        Me.WaveForm1.Controls.Add(Me.Label7)
        Me.WaveForm1.Controls.Add(Me.Label8)
        Me.WaveForm1.Controls.Add(Me.Label9)
        Me.WaveForm1.Controls.Add(Me.Label13)
        Me.WaveForm1.Controls.Add(Me.Label18)
        Me.WaveForm1.Controls.Add(Me.Label19)
        Me.WaveForm1.Controls.Add(Me.Label20)
        Me.WaveForm1.Controls.Add(Me.Label21)
        Me.WaveForm1.Controls.Add(Me.txtAtt_tab1)
        Me.WaveForm1.Controls.Add(Me.txtTld_tab1)
        Me.WaveForm1.Controls.Add(Me.txtTc_tab1)
        Me.WaveForm1.Controls.Add(Me.txtAvg_tab1)
        Me.WaveForm1.Controls.Add(Me.txtDelay_tab1)
        Me.WaveForm1.Controls.Add(Me.txtPulse_tab1)
        Me.WaveForm1.Controls.Add(Me.txtDuty_tab1)
        Me.WaveForm1.Controls.Add(Me.txtFrequen_tab1)
        Me.WaveForm1.Controls.Add(Me.txtIf_tab1)
        Me.WaveForm1.Controls.Add(Me.Label229)
        Me.WaveForm1.Controls.Add(Me.Label231)
        Me.WaveForm1.Controls.Add(Me.Label232)
        Me.WaveForm1.Controls.Add(Me.Label234)
        Me.WaveForm1.Controls.Add(Me.Label235)
        Me.WaveForm1.Controls.Add(Me.Label236)
        Me.WaveForm1.Controls.Add(Me.Label237)
        Me.WaveForm1.Controls.Add(Me.Label238)
        Me.WaveForm1.Controls.Add(Me.Label239)
        Me.WaveForm1.Controls.Add(Me.Label240)
        Me.WaveForm1.Controls.Add(Me.cboMeasurePoint2_tab1)
        Me.WaveForm1.Controls.Add(Me.cboMeasurePoint1_tab1)
        Me.WaveForm1.Controls.Add(Me.Label2)
        Me.WaveForm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm1.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm1.Name = "WaveForm1"
        Me.WaveForm1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm1.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm1.TabIndex = 0
        Me.WaveForm1.Text = "WaveForm1"
        Me.WaveForm1.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab1
        '
        Me.cboTrigger_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab1.FormattingEnabled = True
        Me.cboTrigger_tab1.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab1.Name = "cboTrigger_tab1"
        Me.cboTrigger_tab1.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab1.TabIndex = 445
        '
        'cboCh2coup_tab1
        '
        Me.cboCh2coup_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab1.FormattingEnabled = True
        Me.cboCh2coup_tab1.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab1.Name = "cboCh2coup_tab1"
        Me.cboCh2coup_tab1.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab1.TabIndex = 444
        '
        'cboCh1coup_tab1
        '
        Me.cboCh1coup_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab1.FormattingEnabled = True
        Me.cboCh1coup_tab1.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab1.Name = "cboCh1coup_tab1"
        Me.cboCh1coup_tab1.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab1.TabIndex = 443
        '
        'txtTriggerMode_tab1
        '
        Me.txtTriggerMode_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab1.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab1.Name = "txtTriggerMode_tab1"
        Me.txtTriggerMode_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab1.TabIndex = 442
        '
        'txtTriggerLevel_tab1
        '
        Me.txtTriggerLevel_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab1.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab1.Name = "txtTriggerLevel_tab1"
        Me.txtTriggerLevel_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab1.TabIndex = 441
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 420)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 440
        Me.Label3.Text = "Trigger mode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 389)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 439
        Me.Label6.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab1
        '
        Me.txtTriggerType_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab1.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab1.Name = "txtTriggerType_tab1"
        Me.txtTriggerType_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab1.TabIndex = 438
        '
        'txtCh2Volt_tab1
        '
        Me.txtCh2Volt_tab1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab1.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab1.Name = "txtCh2Volt_tab1"
        Me.txtCh2Volt_tab1.ReadOnly = True
        Me.txtCh2Volt_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab1.TabIndex = 437
        '
        'txtCh1Volt_tab1
        '
        Me.txtCh1Volt_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab1.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab1.Name = "txtCh1Volt_tab1"
        Me.txtCh1Volt_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab1.TabIndex = 436
        '
        'txtDatapoint_tab1
        '
        Me.txtDatapoint_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab1.Location = New System.Drawing.Point(457, 162)
        Me.txtDatapoint_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab1.Name = "txtDatapoint_tab1"
        Me.txtDatapoint_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab1.TabIndex = 435
        '
        'txtTimediv_tab1
        '
        Me.txtTimediv_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimediv_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimediv_tab1.Location = New System.Drawing.Point(457, 128)
        Me.txtTimediv_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimediv_tab1.Name = "txtTimediv_tab1"
        Me.txtTimediv_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTimediv_tab1.TabIndex = 434
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 358)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 433
        Me.Label1.Text = "Trigger type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 432
        Me.Label7.Text = "Trigger source"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 295)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 18)
        Me.Label8.TabIndex = 431
        Me.Label8.Text = "CH.2 Volts/div [V/div]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 262)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 430
        Me.Label9.Text = "CH2. Coupling"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(313, 232)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 18)
        Me.Label13.TabIndex = 429
        Me.Label13.Text = "CH.1 Volts/div [V/div]"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(312, 196)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 18)
        Me.Label18.TabIndex = 428
        Me.Label18.Text = "CH1. Coupling"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(312, 162)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 18)
        Me.Label19.TabIndex = 427
        Me.Label19.Text = "Data Point [pts]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(313, 128)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 18)
        Me.Label20.TabIndex = 426
        Me.Label20.Text = "Time/div [us/div]"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label21.Location = New System.Drawing.Point(312, 98)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 18)
        Me.Label21.TabIndex = 425
        Me.Label21.Text = "OSC setting"
        '
        'txtAtt_tab1
        '
        Me.txtAtt_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab1.Location = New System.Drawing.Point(179, 388)
        Me.txtAtt_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab1.Name = "txtAtt_tab1"
        Me.txtAtt_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab1.TabIndex = 424
        '
        'txtTld_tab1
        '
        Me.txtTld_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab1.Location = New System.Drawing.Point(179, 358)
        Me.txtTld_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab1.Name = "txtTld_tab1"
        Me.txtTld_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab1.TabIndex = 423
        '
        'txtTc_tab1
        '
        Me.txtTc_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab1.Location = New System.Drawing.Point(179, 327)
        Me.txtTc_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab1.Name = "txtTc_tab1"
        Me.txtTc_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab1.TabIndex = 422
        '
        'txtAvg_tab1
        '
        Me.txtAvg_tab1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab1.Location = New System.Drawing.Point(179, 293)
        Me.txtAvg_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab1.Name = "txtAvg_tab1"
        Me.txtAvg_tab1.ReadOnly = True
        Me.txtAvg_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab1.TabIndex = 421
        '
        'txtDelay_tab1
        '
        Me.txtDelay_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab1.Location = New System.Drawing.Point(179, 260)
        Me.txtDelay_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab1.Name = "txtDelay_tab1"
        Me.txtDelay_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab1.TabIndex = 420
        '
        'txtPulse_tab1
        '
        Me.txtPulse_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab1.Location = New System.Drawing.Point(179, 229)
        Me.txtPulse_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab1.Name = "txtPulse_tab1"
        Me.txtPulse_tab1.ReadOnly = True
        Me.txtPulse_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab1.TabIndex = 419
        '
        'txtDuty_tab1
        '
        Me.txtDuty_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab1.Location = New System.Drawing.Point(179, 196)
        Me.txtDuty_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab1.Name = "txtDuty_tab1"
        Me.txtDuty_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab1.TabIndex = 418
        '
        'txtFrequen_tab1
        '
        Me.txtFrequen_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab1.Location = New System.Drawing.Point(179, 162)
        Me.txtFrequen_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab1.Name = "txtFrequen_tab1"
        Me.txtFrequen_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab1.TabIndex = 417
        '
        'txtIf_tab1
        '
        Me.txtIf_tab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab1.Location = New System.Drawing.Point(179, 128)
        Me.txtIf_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab1.Name = "txtIf_tab1"
        Me.txtIf_tab1.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab1.TabIndex = 416
        '
        'Label229
        '
        Me.Label229.AutoSize = True
        Me.Label229.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label229.Location = New System.Drawing.Point(59, 389)
        Me.Label229.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label229.Name = "Label229"
        Me.Label229.Size = New System.Drawing.Size(65, 18)
        Me.Label229.TabIndex = 415
        Me.Label229.Text = "ATT [dB]"
        '
        'Label231
        '
        Me.Label231.AutoSize = True
        Me.Label231.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label231.Location = New System.Drawing.Point(58, 358)
        Me.Label231.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(56, 18)
        Me.Label231.TabIndex = 414
        Me.Label231.Text = "Tld [⁰C]"
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label232.Location = New System.Drawing.Point(58, 327)
        Me.Label232.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(53, 18)
        Me.Label232.TabIndex = 413
        Me.Label232.Text = "Tc [⁰C]"
        '
        'Label234
        '
        Me.Label234.AutoSize = True
        Me.Label234.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label234.Location = New System.Drawing.Point(58, 295)
        Me.Label234.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label234.Name = "Label234"
        Me.Label234.Size = New System.Drawing.Size(101, 18)
        Me.Label234.TabIndex = 412
        Me.Label234.Text = "Average [time]"
        '
        'Label235
        '
        Me.Label235.AutoSize = True
        Me.Label235.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label235.Location = New System.Drawing.Point(58, 262)
        Me.Label235.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label235.Name = "Label235"
        Me.Label235.Size = New System.Drawing.Size(101, 18)
        Me.Label235.TabIndex = 411
        Me.Label235.Text = "Delay time[us]"
        '
        'Label236
        '
        Me.Label236.AutoSize = True
        Me.Label236.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label236.Location = New System.Drawing.Point(59, 232)
        Me.Label236.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label236.Name = "Label236"
        Me.Label236.Size = New System.Drawing.Size(115, 18)
        Me.Label236.TabIndex = 410
        Me.Label236.Text = "Pulse Width [us]"
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label237.Location = New System.Drawing.Point(58, 196)
        Me.Label237.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(101, 18)
        Me.Label237.TabIndex = 409
        Me.Label237.Text = "Duty cycle [%]"
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label238.Location = New System.Drawing.Point(58, 162)
        Me.Label238.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(118, 18)
        Me.Label238.TabIndex = 408
        Me.Label238.Text = "Frequency [KHz]"
        '
        'Label239
        '
        Me.Label239.AutoSize = True
        Me.Label239.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label239.Location = New System.Drawing.Point(59, 128)
        Me.Label239.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label239.Name = "Label239"
        Me.Label239.Size = New System.Drawing.Size(49, 18)
        Me.Label239.TabIndex = 407
        Me.Label239.Text = "If [mA]"
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label240.Location = New System.Drawing.Point(58, 98)
        Me.Label240.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(109, 18)
        Me.Label240.TabIndex = 406
        Me.Label240.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab1
        '
        Me.cboMeasurePoint2_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab1.FormattingEnabled = True
        Me.cboMeasurePoint2_tab1.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab1.Name = "cboMeasurePoint2_tab1"
        Me.cboMeasurePoint2_tab1.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab1.TabIndex = 405
        '
        'cboMeasurePoint1_tab1
        '
        Me.cboMeasurePoint1_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab1.FormattingEnabled = True
        Me.cboMeasurePoint1_tab1.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab1.Name = "cboMeasurePoint1_tab1"
        Me.cboMeasurePoint1_tab1.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab1.TabIndex = 404
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(565, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 18)
        Me.Label2.TabIndex = 403
        Me.Label2.Text = "Measurement point"
        '
        'WaveForm2
        '
        Me.WaveForm2.Controls.Add(Me.cboTrigger_tab2)
        Me.WaveForm2.Controls.Add(Me.cboCh2coup_tab2)
        Me.WaveForm2.Controls.Add(Me.cboCh1coup_tab2)
        Me.WaveForm2.Controls.Add(Me.txtTriggerMode_tab2)
        Me.WaveForm2.Controls.Add(Me.txtTriggerLevel_tab2)
        Me.WaveForm2.Controls.Add(Me.Label4)
        Me.WaveForm2.Controls.Add(Me.Label5)
        Me.WaveForm2.Controls.Add(Me.txtTriggerType_tab2)
        Me.WaveForm2.Controls.Add(Me.txtCh2Volt_tab2)
        Me.WaveForm2.Controls.Add(Me.txtCh1Volt_tab2)
        Me.WaveForm2.Controls.Add(Me.txtDatapoint_tab2)
        Me.WaveForm2.Controls.Add(Me.txtTimediv_tab2)
        Me.WaveForm2.Controls.Add(Me.Label10)
        Me.WaveForm2.Controls.Add(Me.Label11)
        Me.WaveForm2.Controls.Add(Me.Label12)
        Me.WaveForm2.Controls.Add(Me.Label14)
        Me.WaveForm2.Controls.Add(Me.Label15)
        Me.WaveForm2.Controls.Add(Me.Label16)
        Me.WaveForm2.Controls.Add(Me.Label17)
        Me.WaveForm2.Controls.Add(Me.Label22)
        Me.WaveForm2.Controls.Add(Me.Label23)
        Me.WaveForm2.Controls.Add(Me.txtAtt_tab2)
        Me.WaveForm2.Controls.Add(Me.txtTld_tab2)
        Me.WaveForm2.Controls.Add(Me.txtTc_tab2)
        Me.WaveForm2.Controls.Add(Me.txtAvg_tab2)
        Me.WaveForm2.Controls.Add(Me.txtDelay_tab2)
        Me.WaveForm2.Controls.Add(Me.txtPulse_tab2)
        Me.WaveForm2.Controls.Add(Me.txtDuty_tab2)
        Me.WaveForm2.Controls.Add(Me.txtFrequen_tab2)
        Me.WaveForm2.Controls.Add(Me.txtIf_tab2)
        Me.WaveForm2.Controls.Add(Me.Label24)
        Me.WaveForm2.Controls.Add(Me.Label25)
        Me.WaveForm2.Controls.Add(Me.Label26)
        Me.WaveForm2.Controls.Add(Me.Label27)
        Me.WaveForm2.Controls.Add(Me.Label28)
        Me.WaveForm2.Controls.Add(Me.Label29)
        Me.WaveForm2.Controls.Add(Me.Label30)
        Me.WaveForm2.Controls.Add(Me.Label31)
        Me.WaveForm2.Controls.Add(Me.Label32)
        Me.WaveForm2.Controls.Add(Me.Label33)
        Me.WaveForm2.Controls.Add(Me.cboMeasurePoint2_tab2)
        Me.WaveForm2.Controls.Add(Me.cboMeasurePoint1_tab2)
        Me.WaveForm2.Controls.Add(Me.Label34)
        Me.WaveForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm2.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm2.Name = "WaveForm2"
        Me.WaveForm2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm2.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm2.TabIndex = 1
        Me.WaveForm2.Text = "WaveForm2"
        Me.WaveForm2.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab2
        '
        Me.cboTrigger_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab2.FormattingEnabled = True
        Me.cboTrigger_tab2.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab2.Name = "cboTrigger_tab2"
        Me.cboTrigger_tab2.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab2.TabIndex = 445
        '
        'cboCh2coup_tab2
        '
        Me.cboCh2coup_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab2.FormattingEnabled = True
        Me.cboCh2coup_tab2.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab2.Name = "cboCh2coup_tab2"
        Me.cboCh2coup_tab2.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab2.TabIndex = 444
        '
        'cboCh1coup_tab2
        '
        Me.cboCh1coup_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab2.FormattingEnabled = True
        Me.cboCh1coup_tab2.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab2.Name = "cboCh1coup_tab2"
        Me.cboCh1coup_tab2.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab2.TabIndex = 443
        '
        'txtTriggerMode_tab2
        '
        Me.txtTriggerMode_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab2.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab2.Name = "txtTriggerMode_tab2"
        Me.txtTriggerMode_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab2.TabIndex = 442
        '
        'txtTriggerLevel_tab2
        '
        Me.txtTriggerLevel_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab2.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab2.Name = "txtTriggerLevel_tab2"
        Me.txtTriggerLevel_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab2.TabIndex = 441
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 420)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 440
        Me.Label4.Text = "Trigger mode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 389)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 439
        Me.Label5.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab2
        '
        Me.txtTriggerType_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab2.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab2.Name = "txtTriggerType_tab2"
        Me.txtTriggerType_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab2.TabIndex = 438
        '
        'txtCh2Volt_tab2
        '
        Me.txtCh2Volt_tab2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab2.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab2.Name = "txtCh2Volt_tab2"
        Me.txtCh2Volt_tab2.ReadOnly = True
        Me.txtCh2Volt_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab2.TabIndex = 437
        '
        'txtCh1Volt_tab2
        '
        Me.txtCh1Volt_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab2.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab2.Name = "txtCh1Volt_tab2"
        Me.txtCh1Volt_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab2.TabIndex = 436
        '
        'txtDatapoint_tab2
        '
        Me.txtDatapoint_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab2.Location = New System.Drawing.Point(457, 162)
        Me.txtDatapoint_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab2.Name = "txtDatapoint_tab2"
        Me.txtDatapoint_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab2.TabIndex = 435
        '
        'txtTimediv_tab2
        '
        Me.txtTimediv_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimediv_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimediv_tab2.Location = New System.Drawing.Point(457, 128)
        Me.txtTimediv_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimediv_tab2.Name = "txtTimediv_tab2"
        Me.txtTimediv_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTimediv_tab2.TabIndex = 434
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 358)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 433
        Me.Label10.Text = "Trigger type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(312, 327)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 432
        Me.Label11.Text = "Trigger source"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 295)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 18)
        Me.Label12.TabIndex = 431
        Me.Label12.Text = "CH.2 Volts/div [V/div]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(312, 262)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 430
        Me.Label14.Text = "CH2. Coupling"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(313, 232)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 18)
        Me.Label15.TabIndex = 429
        Me.Label15.Text = "CH.1 Volts/div [V/div]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(312, 196)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 18)
        Me.Label16.TabIndex = 428
        Me.Label16.Text = "CH1. Coupling"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(312, 162)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 18)
        Me.Label17.TabIndex = 427
        Me.Label17.Text = "Data Point [pts]"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(313, 128)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 18)
        Me.Label22.TabIndex = 426
        Me.Label22.Text = "Time/div [us/div]"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label23.Location = New System.Drawing.Point(312, 98)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 18)
        Me.Label23.TabIndex = 425
        Me.Label23.Text = "OSC setting"
        '
        'txtAtt_tab2
        '
        Me.txtAtt_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab2.Location = New System.Drawing.Point(179, 388)
        Me.txtAtt_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab2.Name = "txtAtt_tab2"
        Me.txtAtt_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab2.TabIndex = 424
        '
        'txtTld_tab2
        '
        Me.txtTld_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab2.Location = New System.Drawing.Point(179, 358)
        Me.txtTld_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab2.Name = "txtTld_tab2"
        Me.txtTld_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab2.TabIndex = 423
        '
        'txtTc_tab2
        '
        Me.txtTc_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab2.Location = New System.Drawing.Point(179, 327)
        Me.txtTc_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab2.Name = "txtTc_tab2"
        Me.txtTc_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab2.TabIndex = 422
        '
        'txtAvg_tab2
        '
        Me.txtAvg_tab2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab2.Location = New System.Drawing.Point(179, 293)
        Me.txtAvg_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab2.Name = "txtAvg_tab2"
        Me.txtAvg_tab2.ReadOnly = True
        Me.txtAvg_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab2.TabIndex = 421
        '
        'txtDelay_tab2
        '
        Me.txtDelay_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab2.Location = New System.Drawing.Point(179, 260)
        Me.txtDelay_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab2.Name = "txtDelay_tab2"
        Me.txtDelay_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab2.TabIndex = 420
        '
        'txtPulse_tab2
        '
        Me.txtPulse_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab2.Location = New System.Drawing.Point(179, 229)
        Me.txtPulse_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab2.Name = "txtPulse_tab2"
        Me.txtPulse_tab2.ReadOnly = True
        Me.txtPulse_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab2.TabIndex = 419
        '
        'txtDuty_tab2
        '
        Me.txtDuty_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab2.Location = New System.Drawing.Point(179, 196)
        Me.txtDuty_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab2.Name = "txtDuty_tab2"
        Me.txtDuty_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab2.TabIndex = 418
        '
        'txtFrequen_tab2
        '
        Me.txtFrequen_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab2.Location = New System.Drawing.Point(179, 162)
        Me.txtFrequen_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab2.Name = "txtFrequen_tab2"
        Me.txtFrequen_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab2.TabIndex = 417
        '
        'txtIf_tab2
        '
        Me.txtIf_tab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab2.Location = New System.Drawing.Point(179, 128)
        Me.txtIf_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab2.Name = "txtIf_tab2"
        Me.txtIf_tab2.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab2.TabIndex = 416
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(59, 389)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 18)
        Me.Label24.TabIndex = 415
        Me.Label24.Text = "ATT [dB]"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(58, 358)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 18)
        Me.Label25.TabIndex = 414
        Me.Label25.Text = "Tld [⁰C]"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(58, 327)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 18)
        Me.Label26.TabIndex = 413
        Me.Label26.Text = "Tc [⁰C]"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(58, 295)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 18)
        Me.Label27.TabIndex = 412
        Me.Label27.Text = "Average [time]"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(58, 262)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 18)
        Me.Label28.TabIndex = 411
        Me.Label28.Text = "Delay time[us]"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(59, 232)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(115, 18)
        Me.Label29.TabIndex = 410
        Me.Label29.Text = "Pulse Width [us]"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(58, 196)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 18)
        Me.Label30.TabIndex = 409
        Me.Label30.Text = "Duty cycle [%]"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(58, 162)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(118, 18)
        Me.Label31.TabIndex = 408
        Me.Label31.Text = "Frequency [KHz]"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(59, 128)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 18)
        Me.Label32.TabIndex = 407
        Me.Label32.Text = "If [mA]"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label33.Location = New System.Drawing.Point(58, 98)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(109, 18)
        Me.Label33.TabIndex = 406
        Me.Label33.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab2
        '
        Me.cboMeasurePoint2_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab2.FormattingEnabled = True
        Me.cboMeasurePoint2_tab2.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab2.Name = "cboMeasurePoint2_tab2"
        Me.cboMeasurePoint2_tab2.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab2.TabIndex = 405
        '
        'cboMeasurePoint1_tab2
        '
        Me.cboMeasurePoint1_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab2.FormattingEnabled = True
        Me.cboMeasurePoint1_tab2.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab2.Name = "cboMeasurePoint1_tab2"
        Me.cboMeasurePoint1_tab2.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab2.TabIndex = 404
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label34.Location = New System.Drawing.Point(565, 98)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(135, 18)
        Me.Label34.TabIndex = 403
        Me.Label34.Text = "Measurement point"
        '
        'WaveForm3
        '
        Me.WaveForm3.Controls.Add(Me.cboTrigger_tab3)
        Me.WaveForm3.Controls.Add(Me.cboCh2coup_tab3)
        Me.WaveForm3.Controls.Add(Me.cboCh1coup_tab3)
        Me.WaveForm3.Controls.Add(Me.txtTriggerMode_tab3)
        Me.WaveForm3.Controls.Add(Me.txtTriggerLevel_tab3)
        Me.WaveForm3.Controls.Add(Me.Label35)
        Me.WaveForm3.Controls.Add(Me.Label36)
        Me.WaveForm3.Controls.Add(Me.txtTriggerType_tab3)
        Me.WaveForm3.Controls.Add(Me.txtCh2Volt_tab3)
        Me.WaveForm3.Controls.Add(Me.txtCh1Volt_tab3)
        Me.WaveForm3.Controls.Add(Me.txtDatapoint_tab3)
        Me.WaveForm3.Controls.Add(Me.txtTimediv_tab3)
        Me.WaveForm3.Controls.Add(Me.Label37)
        Me.WaveForm3.Controls.Add(Me.Label38)
        Me.WaveForm3.Controls.Add(Me.Label39)
        Me.WaveForm3.Controls.Add(Me.Label40)
        Me.WaveForm3.Controls.Add(Me.Label41)
        Me.WaveForm3.Controls.Add(Me.Label42)
        Me.WaveForm3.Controls.Add(Me.Label43)
        Me.WaveForm3.Controls.Add(Me.Label44)
        Me.WaveForm3.Controls.Add(Me.Label45)
        Me.WaveForm3.Controls.Add(Me.txtAtt_tab3)
        Me.WaveForm3.Controls.Add(Me.txtTld_tab3)
        Me.WaveForm3.Controls.Add(Me.txtTc_tab3)
        Me.WaveForm3.Controls.Add(Me.txtAvg_tab3)
        Me.WaveForm3.Controls.Add(Me.txtDelay_tab3)
        Me.WaveForm3.Controls.Add(Me.txtPulse_tab3)
        Me.WaveForm3.Controls.Add(Me.txtDuty_tab3)
        Me.WaveForm3.Controls.Add(Me.txtFrequen_tab3)
        Me.WaveForm3.Controls.Add(Me.txtIf_tab3)
        Me.WaveForm3.Controls.Add(Me.Label46)
        Me.WaveForm3.Controls.Add(Me.Label47)
        Me.WaveForm3.Controls.Add(Me.Label48)
        Me.WaveForm3.Controls.Add(Me.Label49)
        Me.WaveForm3.Controls.Add(Me.Label50)
        Me.WaveForm3.Controls.Add(Me.Label51)
        Me.WaveForm3.Controls.Add(Me.Label52)
        Me.WaveForm3.Controls.Add(Me.Label53)
        Me.WaveForm3.Controls.Add(Me.Label54)
        Me.WaveForm3.Controls.Add(Me.Label55)
        Me.WaveForm3.Controls.Add(Me.cboMeasurePoint2_tab3)
        Me.WaveForm3.Controls.Add(Me.cboMeasurePoint1_tab3)
        Me.WaveForm3.Controls.Add(Me.Label56)
        Me.WaveForm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm3.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm3.Name = "WaveForm3"
        Me.WaveForm3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm3.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm3.TabIndex = 2
        Me.WaveForm3.Text = "WaveForm3"
        Me.WaveForm3.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab3
        '
        Me.cboTrigger_tab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab3.FormattingEnabled = True
        Me.cboTrigger_tab3.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab3.Name = "cboTrigger_tab3"
        Me.cboTrigger_tab3.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab3.TabIndex = 445
        '
        'cboCh2coup_tab3
        '
        Me.cboCh2coup_tab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab3.FormattingEnabled = True
        Me.cboCh2coup_tab3.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab3.Name = "cboCh2coup_tab3"
        Me.cboCh2coup_tab3.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab3.TabIndex = 444
        '
        'cboCh1coup_tab3
        '
        Me.cboCh1coup_tab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab3.FormattingEnabled = True
        Me.cboCh1coup_tab3.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab3.Name = "cboCh1coup_tab3"
        Me.cboCh1coup_tab3.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab3.TabIndex = 443
        '
        'txtTriggerMode_tab3
        '
        Me.txtTriggerMode_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab3.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab3.Name = "txtTriggerMode_tab3"
        Me.txtTriggerMode_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab3.TabIndex = 442
        '
        'txtTriggerLevel_tab3
        '
        Me.txtTriggerLevel_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab3.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab3.Name = "txtTriggerLevel_tab3"
        Me.txtTriggerLevel_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab3.TabIndex = 441
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(313, 420)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 18)
        Me.Label35.TabIndex = 440
        Me.Label35.Text = "Trigger mode"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(313, 389)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(117, 18)
        Me.Label36.TabIndex = 439
        Me.Label36.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab3
        '
        Me.txtTriggerType_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab3.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab3.Name = "txtTriggerType_tab3"
        Me.txtTriggerType_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab3.TabIndex = 438
        '
        'txtCh2Volt_tab3
        '
        Me.txtCh2Volt_tab3.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab3.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab3.Name = "txtCh2Volt_tab3"
        Me.txtCh2Volt_tab3.ReadOnly = True
        Me.txtCh2Volt_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab3.TabIndex = 437
        '
        'txtCh1Volt_tab3
        '
        Me.txtCh1Volt_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab3.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab3.Name = "txtCh1Volt_tab3"
        Me.txtCh1Volt_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab3.TabIndex = 436
        '
        'txtDatapoint_tab3
        '
        Me.txtDatapoint_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab3.Location = New System.Drawing.Point(457, 162)
        Me.txtDatapoint_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab3.Name = "txtDatapoint_tab3"
        Me.txtDatapoint_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab3.TabIndex = 435
        '
        'txtTimediv_tab3
        '
        Me.txtTimediv_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimediv_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimediv_tab3.Location = New System.Drawing.Point(457, 128)
        Me.txtTimediv_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimediv_tab3.Name = "txtTimediv_tab3"
        Me.txtTimediv_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTimediv_tab3.TabIndex = 434
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(312, 358)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(85, 18)
        Me.Label37.TabIndex = 433
        Me.Label37.Text = "Trigger type"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(312, 327)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 18)
        Me.Label38.TabIndex = 432
        Me.Label38.Text = "Trigger source"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(312, 295)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(144, 18)
        Me.Label39.TabIndex = 431
        Me.Label39.Text = "CH.2 Volts/div [V/div]"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(312, 262)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 18)
        Me.Label40.TabIndex = 430
        Me.Label40.Text = "CH2. Coupling"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(313, 232)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(144, 18)
        Me.Label41.TabIndex = 429
        Me.Label41.Text = "CH.1 Volts/div [V/div]"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(312, 196)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 18)
        Me.Label42.TabIndex = 428
        Me.Label42.Text = "CH1. Coupling"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(312, 162)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(109, 18)
        Me.Label43.TabIndex = 427
        Me.Label43.Text = "Data Point [pts]"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(313, 128)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(113, 18)
        Me.Label44.TabIndex = 426
        Me.Label44.Text = "Time/div [us/div]"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label45.Location = New System.Drawing.Point(312, 98)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 18)
        Me.Label45.TabIndex = 425
        Me.Label45.Text = "OSC setting"
        '
        'txtAtt_tab3
        '
        Me.txtAtt_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab3.Location = New System.Drawing.Point(179, 388)
        Me.txtAtt_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab3.Name = "txtAtt_tab3"
        Me.txtAtt_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab3.TabIndex = 424
        '
        'txtTld_tab3
        '
        Me.txtTld_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab3.Location = New System.Drawing.Point(179, 358)
        Me.txtTld_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab3.Name = "txtTld_tab3"
        Me.txtTld_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab3.TabIndex = 423
        '
        'txtTc_tab3
        '
        Me.txtTc_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab3.Location = New System.Drawing.Point(179, 327)
        Me.txtTc_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab3.Name = "txtTc_tab3"
        Me.txtTc_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab3.TabIndex = 422
        '
        'txtAvg_tab3
        '
        Me.txtAvg_tab3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab3.Location = New System.Drawing.Point(179, 293)
        Me.txtAvg_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab3.Name = "txtAvg_tab3"
        Me.txtAvg_tab3.ReadOnly = True
        Me.txtAvg_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab3.TabIndex = 421
        '
        'txtDelay_tab3
        '
        Me.txtDelay_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab3.Location = New System.Drawing.Point(179, 260)
        Me.txtDelay_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab3.Name = "txtDelay_tab3"
        Me.txtDelay_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab3.TabIndex = 420
        '
        'txtPulse_tab3
        '
        Me.txtPulse_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab3.Location = New System.Drawing.Point(179, 229)
        Me.txtPulse_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab3.Name = "txtPulse_tab3"
        Me.txtPulse_tab3.ReadOnly = True
        Me.txtPulse_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab3.TabIndex = 419
        '
        'txtDuty_tab3
        '
        Me.txtDuty_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab3.Location = New System.Drawing.Point(179, 196)
        Me.txtDuty_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab3.Name = "txtDuty_tab3"
        Me.txtDuty_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab3.TabIndex = 418
        '
        'txtFrequen_tab3
        '
        Me.txtFrequen_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab3.Location = New System.Drawing.Point(179, 162)
        Me.txtFrequen_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab3.Name = "txtFrequen_tab3"
        Me.txtFrequen_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab3.TabIndex = 417
        '
        'txtIf_tab3
        '
        Me.txtIf_tab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab3.Location = New System.Drawing.Point(179, 128)
        Me.txtIf_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab3.Name = "txtIf_tab3"
        Me.txtIf_tab3.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab3.TabIndex = 416
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(59, 389)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(65, 18)
        Me.Label46.TabIndex = 415
        Me.Label46.Text = "ATT [dB]"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(58, 358)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 18)
        Me.Label47.TabIndex = 414
        Me.Label47.Text = "Tld [⁰C]"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(58, 327)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(53, 18)
        Me.Label48.TabIndex = 413
        Me.Label48.Text = "Tc [⁰C]"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(58, 295)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(101, 18)
        Me.Label49.TabIndex = 412
        Me.Label49.Text = "Average [time]"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(58, 262)
        Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(101, 18)
        Me.Label50.TabIndex = 411
        Me.Label50.Text = "Delay time[us]"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(59, 232)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(115, 18)
        Me.Label51.TabIndex = 410
        Me.Label51.Text = "Pulse Width [us]"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(58, 196)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(101, 18)
        Me.Label52.TabIndex = 409
        Me.Label52.Text = "Duty cycle [%]"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(58, 162)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(118, 18)
        Me.Label53.TabIndex = 408
        Me.Label53.Text = "Frequency [KHz]"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(59, 128)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(49, 18)
        Me.Label54.TabIndex = 407
        Me.Label54.Text = "If [mA]"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label55.Location = New System.Drawing.Point(58, 98)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(109, 18)
        Me.Label55.TabIndex = 406
        Me.Label55.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab3
        '
        Me.cboMeasurePoint2_tab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab3.FormattingEnabled = True
        Me.cboMeasurePoint2_tab3.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab3.Name = "cboMeasurePoint2_tab3"
        Me.cboMeasurePoint2_tab3.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab3.TabIndex = 405
        '
        'cboMeasurePoint1_tab3
        '
        Me.cboMeasurePoint1_tab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab3.FormattingEnabled = True
        Me.cboMeasurePoint1_tab3.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab3.Name = "cboMeasurePoint1_tab3"
        Me.cboMeasurePoint1_tab3.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab3.TabIndex = 404
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label56.Location = New System.Drawing.Point(565, 98)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(135, 18)
        Me.Label56.TabIndex = 403
        Me.Label56.Text = "Measurement point"
        '
        'WaveForm4
        '
        Me.WaveForm4.Controls.Add(Me.cboTrigger_tab4)
        Me.WaveForm4.Controls.Add(Me.cboCh2coup_tab4)
        Me.WaveForm4.Controls.Add(Me.cboCh1coup_tab4)
        Me.WaveForm4.Controls.Add(Me.txtTriggerMode_tab4)
        Me.WaveForm4.Controls.Add(Me.txtTriggerLevel_tab4)
        Me.WaveForm4.Controls.Add(Me.Label57)
        Me.WaveForm4.Controls.Add(Me.Label58)
        Me.WaveForm4.Controls.Add(Me.txtTriggerType_tab4)
        Me.WaveForm4.Controls.Add(Me.txtCh2Volt_tab4)
        Me.WaveForm4.Controls.Add(Me.txtCh1Volt_tab4)
        Me.WaveForm4.Controls.Add(Me.TextBox45)
        Me.WaveForm4.Controls.Add(Me.txtDatapoint_tab4)
        Me.WaveForm4.Controls.Add(Me.Label59)
        Me.WaveForm4.Controls.Add(Me.Label60)
        Me.WaveForm4.Controls.Add(Me.Label61)
        Me.WaveForm4.Controls.Add(Me.Label62)
        Me.WaveForm4.Controls.Add(Me.Label63)
        Me.WaveForm4.Controls.Add(Me.Label64)
        Me.WaveForm4.Controls.Add(Me.Label65)
        Me.WaveForm4.Controls.Add(Me.Label66)
        Me.WaveForm4.Controls.Add(Me.Label67)
        Me.WaveForm4.Controls.Add(Me.txtAtt_tab4)
        Me.WaveForm4.Controls.Add(Me.txtTld_tab4)
        Me.WaveForm4.Controls.Add(Me.txtTc_tab4)
        Me.WaveForm4.Controls.Add(Me.txtAvg_tab4)
        Me.WaveForm4.Controls.Add(Me.txtDelay_tab4)
        Me.WaveForm4.Controls.Add(Me.txtPulse_tab4)
        Me.WaveForm4.Controls.Add(Me.txtDuty_tab4)
        Me.WaveForm4.Controls.Add(Me.txtFrequen_tab4)
        Me.WaveForm4.Controls.Add(Me.txtIf_tab4)
        Me.WaveForm4.Controls.Add(Me.Label68)
        Me.WaveForm4.Controls.Add(Me.Label69)
        Me.WaveForm4.Controls.Add(Me.Label70)
        Me.WaveForm4.Controls.Add(Me.Label71)
        Me.WaveForm4.Controls.Add(Me.Label72)
        Me.WaveForm4.Controls.Add(Me.Label73)
        Me.WaveForm4.Controls.Add(Me.Label74)
        Me.WaveForm4.Controls.Add(Me.Label75)
        Me.WaveForm4.Controls.Add(Me.Label76)
        Me.WaveForm4.Controls.Add(Me.Label77)
        Me.WaveForm4.Controls.Add(Me.cboMeasurePoint2_tab4)
        Me.WaveForm4.Controls.Add(Me.cboMeasurePoint1_tab4)
        Me.WaveForm4.Controls.Add(Me.Label78)
        Me.WaveForm4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm4.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm4.Name = "WaveForm4"
        Me.WaveForm4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm4.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm4.TabIndex = 3
        Me.WaveForm4.Text = "WaveForm4"
        Me.WaveForm4.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab4
        '
        Me.cboTrigger_tab4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab4.FormattingEnabled = True
        Me.cboTrigger_tab4.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab4.Name = "cboTrigger_tab4"
        Me.cboTrigger_tab4.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab4.TabIndex = 445
        '
        'cboCh2coup_tab4
        '
        Me.cboCh2coup_tab4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab4.FormattingEnabled = True
        Me.cboCh2coup_tab4.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab4.Name = "cboCh2coup_tab4"
        Me.cboCh2coup_tab4.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab4.TabIndex = 444
        '
        'cboCh1coup_tab4
        '
        Me.cboCh1coup_tab4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab4.FormattingEnabled = True
        Me.cboCh1coup_tab4.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab4.Name = "cboCh1coup_tab4"
        Me.cboCh1coup_tab4.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab4.TabIndex = 443
        '
        'txtTriggerMode_tab4
        '
        Me.txtTriggerMode_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab4.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab4.Name = "txtTriggerMode_tab4"
        Me.txtTriggerMode_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab4.TabIndex = 442
        '
        'txtTriggerLevel_tab4
        '
        Me.txtTriggerLevel_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab4.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab4.Name = "txtTriggerLevel_tab4"
        Me.txtTriggerLevel_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab4.TabIndex = 441
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(313, 420)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(96, 18)
        Me.Label57.TabIndex = 440
        Me.Label57.Text = "Trigger mode"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(313, 389)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(117, 18)
        Me.Label58.TabIndex = 439
        Me.Label58.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab4
        '
        Me.txtTriggerType_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab4.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab4.Name = "txtTriggerType_tab4"
        Me.txtTriggerType_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab4.TabIndex = 438
        '
        'txtCh2Volt_tab4
        '
        Me.txtCh2Volt_tab4.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab4.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab4.Name = "txtCh2Volt_tab4"
        Me.txtCh2Volt_tab4.ReadOnly = True
        Me.txtCh2Volt_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab4.TabIndex = 437
        '
        'txtCh1Volt_tab4
        '
        Me.txtCh1Volt_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab4.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab4.Name = "txtCh1Volt_tab4"
        Me.txtCh1Volt_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab4.TabIndex = 436
        '
        'TextBox45
        '
        Me.TextBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox45.Location = New System.Drawing.Point(457, 162)
        Me.TextBox45.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(84, 24)
        Me.TextBox45.TabIndex = 435
        '
        'txtDatapoint_tab4
        '
        Me.txtDatapoint_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab4.Location = New System.Drawing.Point(457, 128)
        Me.txtDatapoint_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab4.Name = "txtDatapoint_tab4"
        Me.txtDatapoint_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab4.TabIndex = 434
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(312, 358)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(85, 18)
        Me.Label59.TabIndex = 433
        Me.Label59.Text = "Trigger type"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(312, 327)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(104, 18)
        Me.Label60.TabIndex = 432
        Me.Label60.Text = "Trigger source"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(312, 295)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(144, 18)
        Me.Label61.TabIndex = 431
        Me.Label61.Text = "CH.2 Volts/div [V/div]"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(312, 262)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(104, 18)
        Me.Label62.TabIndex = 430
        Me.Label62.Text = "CH2. Coupling"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(313, 232)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(144, 18)
        Me.Label63.TabIndex = 429
        Me.Label63.Text = "CH.1 Volts/div [V/div]"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(312, 196)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(104, 18)
        Me.Label64.TabIndex = 428
        Me.Label64.Text = "CH1. Coupling"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(312, 162)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(109, 18)
        Me.Label65.TabIndex = 427
        Me.Label65.Text = "Data Point [pts]"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(313, 128)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(113, 18)
        Me.Label66.TabIndex = 426
        Me.Label66.Text = "Time/div [us/div]"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label67.Location = New System.Drawing.Point(312, 98)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(88, 18)
        Me.Label67.TabIndex = 425
        Me.Label67.Text = "OSC setting"
        '
        'txtAtt_tab4
        '
        Me.txtAtt_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab4.Location = New System.Drawing.Point(179, 388)
        Me.txtAtt_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab4.Name = "txtAtt_tab4"
        Me.txtAtt_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab4.TabIndex = 424
        '
        'txtTld_tab4
        '
        Me.txtTld_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab4.Location = New System.Drawing.Point(179, 358)
        Me.txtTld_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab4.Name = "txtTld_tab4"
        Me.txtTld_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab4.TabIndex = 423
        '
        'txtTc_tab4
        '
        Me.txtTc_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab4.Location = New System.Drawing.Point(179, 327)
        Me.txtTc_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab4.Name = "txtTc_tab4"
        Me.txtTc_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab4.TabIndex = 422
        '
        'txtAvg_tab4
        '
        Me.txtAvg_tab4.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab4.Location = New System.Drawing.Point(179, 293)
        Me.txtAvg_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab4.Name = "txtAvg_tab4"
        Me.txtAvg_tab4.ReadOnly = True
        Me.txtAvg_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab4.TabIndex = 421
        '
        'txtDelay_tab4
        '
        Me.txtDelay_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab4.Location = New System.Drawing.Point(179, 260)
        Me.txtDelay_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab4.Name = "txtDelay_tab4"
        Me.txtDelay_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab4.TabIndex = 420
        '
        'txtPulse_tab4
        '
        Me.txtPulse_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab4.Location = New System.Drawing.Point(179, 229)
        Me.txtPulse_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab4.Name = "txtPulse_tab4"
        Me.txtPulse_tab4.ReadOnly = True
        Me.txtPulse_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab4.TabIndex = 419
        '
        'txtDuty_tab4
        '
        Me.txtDuty_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab4.Location = New System.Drawing.Point(179, 196)
        Me.txtDuty_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab4.Name = "txtDuty_tab4"
        Me.txtDuty_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab4.TabIndex = 418
        '
        'txtFrequen_tab4
        '
        Me.txtFrequen_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab4.Location = New System.Drawing.Point(179, 162)
        Me.txtFrequen_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab4.Name = "txtFrequen_tab4"
        Me.txtFrequen_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab4.TabIndex = 417
        '
        'txtIf_tab4
        '
        Me.txtIf_tab4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab4.Location = New System.Drawing.Point(179, 128)
        Me.txtIf_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab4.Name = "txtIf_tab4"
        Me.txtIf_tab4.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab4.TabIndex = 416
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(59, 389)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(65, 18)
        Me.Label68.TabIndex = 415
        Me.Label68.Text = "ATT [dB]"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(58, 358)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(56, 18)
        Me.Label69.TabIndex = 414
        Me.Label69.Text = "Tld [⁰C]"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(58, 327)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(53, 18)
        Me.Label70.TabIndex = 413
        Me.Label70.Text = "Tc [⁰C]"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(58, 295)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(101, 18)
        Me.Label71.TabIndex = 412
        Me.Label71.Text = "Average [time]"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(58, 262)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(101, 18)
        Me.Label72.TabIndex = 411
        Me.Label72.Text = "Delay time[us]"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(59, 232)
        Me.Label73.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(115, 18)
        Me.Label73.TabIndex = 410
        Me.Label73.Text = "Pulse Width [us]"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(58, 196)
        Me.Label74.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(101, 18)
        Me.Label74.TabIndex = 409
        Me.Label74.Text = "Duty cycle [%]"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(58, 162)
        Me.Label75.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(118, 18)
        Me.Label75.TabIndex = 408
        Me.Label75.Text = "Frequency [KHz]"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(59, 128)
        Me.Label76.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(49, 18)
        Me.Label76.TabIndex = 407
        Me.Label76.Text = "If [mA]"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label77.Location = New System.Drawing.Point(58, 98)
        Me.Label77.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(109, 18)
        Me.Label77.TabIndex = 406
        Me.Label77.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab4
        '
        Me.cboMeasurePoint2_tab4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab4.FormattingEnabled = True
        Me.cboMeasurePoint2_tab4.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab4.Name = "cboMeasurePoint2_tab4"
        Me.cboMeasurePoint2_tab4.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab4.TabIndex = 405
        '
        'cboMeasurePoint1_tab4
        '
        Me.cboMeasurePoint1_tab4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab4.FormattingEnabled = True
        Me.cboMeasurePoint1_tab4.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab4.Name = "cboMeasurePoint1_tab4"
        Me.cboMeasurePoint1_tab4.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab4.TabIndex = 404
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label78.Location = New System.Drawing.Point(565, 98)
        Me.Label78.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(135, 18)
        Me.Label78.TabIndex = 403
        Me.Label78.Text = "Measurement point"
        '
        'WaveForm5
        '
        Me.WaveForm5.Controls.Add(Me.cboTrigger_tab5)
        Me.WaveForm5.Controls.Add(Me.cboCh2coup_tab5)
        Me.WaveForm5.Controls.Add(Me.cboCh1coup_tab5)
        Me.WaveForm5.Controls.Add(Me.txtTriggerMode_tab5)
        Me.WaveForm5.Controls.Add(Me.txtTriggerLevel_tab5)
        Me.WaveForm5.Controls.Add(Me.Label79)
        Me.WaveForm5.Controls.Add(Me.Label80)
        Me.WaveForm5.Controls.Add(Me.txtTriggerType_tab5)
        Me.WaveForm5.Controls.Add(Me.txtCh2Volt_tab5)
        Me.WaveForm5.Controls.Add(Me.txtCh1Volt_tab5)
        Me.WaveForm5.Controls.Add(Me.txtDatapoint_tab5)
        Me.WaveForm5.Controls.Add(Me.txtTimediv_tab5)
        Me.WaveForm5.Controls.Add(Me.Label81)
        Me.WaveForm5.Controls.Add(Me.Label82)
        Me.WaveForm5.Controls.Add(Me.Label83)
        Me.WaveForm5.Controls.Add(Me.Label84)
        Me.WaveForm5.Controls.Add(Me.Label85)
        Me.WaveForm5.Controls.Add(Me.Label86)
        Me.WaveForm5.Controls.Add(Me.Label87)
        Me.WaveForm5.Controls.Add(Me.Label88)
        Me.WaveForm5.Controls.Add(Me.Label89)
        Me.WaveForm5.Controls.Add(Me.txtAtt_tab5)
        Me.WaveForm5.Controls.Add(Me.txtTld_tab5)
        Me.WaveForm5.Controls.Add(Me.txtTc_tab5)
        Me.WaveForm5.Controls.Add(Me.txtAvg_tab5)
        Me.WaveForm5.Controls.Add(Me.txtDelay_tab5)
        Me.WaveForm5.Controls.Add(Me.txtPulse_tab5)
        Me.WaveForm5.Controls.Add(Me.txtDuty_tab5)
        Me.WaveForm5.Controls.Add(Me.txtFrequen_tab5)
        Me.WaveForm5.Controls.Add(Me.txtIf_tab5)
        Me.WaveForm5.Controls.Add(Me.Label90)
        Me.WaveForm5.Controls.Add(Me.Label91)
        Me.WaveForm5.Controls.Add(Me.Label92)
        Me.WaveForm5.Controls.Add(Me.Label93)
        Me.WaveForm5.Controls.Add(Me.Label94)
        Me.WaveForm5.Controls.Add(Me.Label95)
        Me.WaveForm5.Controls.Add(Me.Label96)
        Me.WaveForm5.Controls.Add(Me.Label97)
        Me.WaveForm5.Controls.Add(Me.Label98)
        Me.WaveForm5.Controls.Add(Me.Label99)
        Me.WaveForm5.Controls.Add(Me.cboMeasurePoint2_tab5)
        Me.WaveForm5.Controls.Add(Me.cboMeasurePoint1_tab5)
        Me.WaveForm5.Controls.Add(Me.Label100)
        Me.WaveForm5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm5.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm5.Name = "WaveForm5"
        Me.WaveForm5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm5.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm5.TabIndex = 4
        Me.WaveForm5.Text = "WaveForm5"
        Me.WaveForm5.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab5
        '
        Me.cboTrigger_tab5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab5.FormattingEnabled = True
        Me.cboTrigger_tab5.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab5.Name = "cboTrigger_tab5"
        Me.cboTrigger_tab5.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab5.TabIndex = 445
        '
        'cboCh2coup_tab5
        '
        Me.cboCh2coup_tab5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab5.FormattingEnabled = True
        Me.cboCh2coup_tab5.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab5.Name = "cboCh2coup_tab5"
        Me.cboCh2coup_tab5.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab5.TabIndex = 444
        '
        'cboCh1coup_tab5
        '
        Me.cboCh1coup_tab5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab5.FormattingEnabled = True
        Me.cboCh1coup_tab5.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab5.Name = "cboCh1coup_tab5"
        Me.cboCh1coup_tab5.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab5.TabIndex = 443
        '
        'txtTriggerMode_tab5
        '
        Me.txtTriggerMode_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab5.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab5.Name = "txtTriggerMode_tab5"
        Me.txtTriggerMode_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab5.TabIndex = 442
        '
        'txtTriggerLevel_tab5
        '
        Me.txtTriggerLevel_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab5.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab5.Name = "txtTriggerLevel_tab5"
        Me.txtTriggerLevel_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab5.TabIndex = 441
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(313, 420)
        Me.Label79.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(96, 18)
        Me.Label79.TabIndex = 440
        Me.Label79.Text = "Trigger mode"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(313, 389)
        Me.Label80.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(117, 18)
        Me.Label80.TabIndex = 439
        Me.Label80.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab5
        '
        Me.txtTriggerType_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab5.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab5.Name = "txtTriggerType_tab5"
        Me.txtTriggerType_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab5.TabIndex = 438
        '
        'txtCh2Volt_tab5
        '
        Me.txtCh2Volt_tab5.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab5.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab5.Name = "txtCh2Volt_tab5"
        Me.txtCh2Volt_tab5.ReadOnly = True
        Me.txtCh2Volt_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab5.TabIndex = 437
        '
        'txtCh1Volt_tab5
        '
        Me.txtCh1Volt_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab5.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab5.Name = "txtCh1Volt_tab5"
        Me.txtCh1Volt_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab5.TabIndex = 436
        '
        'txtDatapoint_tab5
        '
        Me.txtDatapoint_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab5.Location = New System.Drawing.Point(457, 162)
        Me.txtDatapoint_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab5.Name = "txtDatapoint_tab5"
        Me.txtDatapoint_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab5.TabIndex = 435
        '
        'txtTimediv_tab5
        '
        Me.txtTimediv_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimediv_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimediv_tab5.Location = New System.Drawing.Point(457, 128)
        Me.txtTimediv_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimediv_tab5.Name = "txtTimediv_tab5"
        Me.txtTimediv_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTimediv_tab5.TabIndex = 434
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(312, 358)
        Me.Label81.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(85, 18)
        Me.Label81.TabIndex = 433
        Me.Label81.Text = "Trigger type"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(312, 327)
        Me.Label82.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(104, 18)
        Me.Label82.TabIndex = 432
        Me.Label82.Text = "Trigger source"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(312, 295)
        Me.Label83.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(144, 18)
        Me.Label83.TabIndex = 431
        Me.Label83.Text = "CH.2 Volts/div [V/div]"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(312, 262)
        Me.Label84.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(104, 18)
        Me.Label84.TabIndex = 430
        Me.Label84.Text = "CH2. Coupling"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(313, 232)
        Me.Label85.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(144, 18)
        Me.Label85.TabIndex = 429
        Me.Label85.Text = "CH.1 Volts/div [V/div]"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(312, 196)
        Me.Label86.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(104, 18)
        Me.Label86.TabIndex = 428
        Me.Label86.Text = "CH1. Coupling"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(312, 162)
        Me.Label87.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(109, 18)
        Me.Label87.TabIndex = 427
        Me.Label87.Text = "Data Point [pts]"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(313, 128)
        Me.Label88.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(113, 18)
        Me.Label88.TabIndex = 426
        Me.Label88.Text = "Time/div [us/div]"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label89.Location = New System.Drawing.Point(312, 98)
        Me.Label89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(88, 18)
        Me.Label89.TabIndex = 425
        Me.Label89.Text = "OSC setting"
        '
        'txtAtt_tab5
        '
        Me.txtAtt_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab5.Location = New System.Drawing.Point(178, 388)
        Me.txtAtt_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab5.Name = "txtAtt_tab5"
        Me.txtAtt_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab5.TabIndex = 424
        '
        'txtTld_tab5
        '
        Me.txtTld_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab5.Location = New System.Drawing.Point(178, 358)
        Me.txtTld_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab5.Name = "txtTld_tab5"
        Me.txtTld_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab5.TabIndex = 423
        '
        'txtTc_tab5
        '
        Me.txtTc_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab5.Location = New System.Drawing.Point(178, 327)
        Me.txtTc_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab5.Name = "txtTc_tab5"
        Me.txtTc_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab5.TabIndex = 422
        '
        'txtAvg_tab5
        '
        Me.txtAvg_tab5.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab5.Location = New System.Drawing.Point(178, 293)
        Me.txtAvg_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab5.Name = "txtAvg_tab5"
        Me.txtAvg_tab5.ReadOnly = True
        Me.txtAvg_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab5.TabIndex = 421
        '
        'txtDelay_tab5
        '
        Me.txtDelay_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab5.Location = New System.Drawing.Point(178, 260)
        Me.txtDelay_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab5.Name = "txtDelay_tab5"
        Me.txtDelay_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab5.TabIndex = 420
        '
        'txtPulse_tab5
        '
        Me.txtPulse_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab5.Location = New System.Drawing.Point(178, 229)
        Me.txtPulse_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab5.Name = "txtPulse_tab5"
        Me.txtPulse_tab5.ReadOnly = True
        Me.txtPulse_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab5.TabIndex = 419
        '
        'txtDuty_tab5
        '
        Me.txtDuty_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab5.Location = New System.Drawing.Point(178, 196)
        Me.txtDuty_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab5.Name = "txtDuty_tab5"
        Me.txtDuty_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab5.TabIndex = 418
        '
        'txtFrequen_tab5
        '
        Me.txtFrequen_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab5.Location = New System.Drawing.Point(178, 162)
        Me.txtFrequen_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab5.Name = "txtFrequen_tab5"
        Me.txtFrequen_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab5.TabIndex = 417
        '
        'txtIf_tab5
        '
        Me.txtIf_tab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab5.Location = New System.Drawing.Point(178, 128)
        Me.txtIf_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab5.Name = "txtIf_tab5"
        Me.txtIf_tab5.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab5.TabIndex = 416
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(59, 389)
        Me.Label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(65, 18)
        Me.Label90.TabIndex = 415
        Me.Label90.Text = "ATT [dB]"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(58, 358)
        Me.Label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(56, 18)
        Me.Label91.TabIndex = 414
        Me.Label91.Text = "Tld [⁰C]"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(58, 327)
        Me.Label92.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(53, 18)
        Me.Label92.TabIndex = 413
        Me.Label92.Text = "Tc [⁰C]"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(58, 295)
        Me.Label93.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(101, 18)
        Me.Label93.TabIndex = 412
        Me.Label93.Text = "Average [time]"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(58, 262)
        Me.Label94.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(101, 18)
        Me.Label94.TabIndex = 411
        Me.Label94.Text = "Delay time[us]"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(59, 232)
        Me.Label95.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(115, 18)
        Me.Label95.TabIndex = 410
        Me.Label95.Text = "Pulse Width [us]"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(58, 196)
        Me.Label96.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(101, 18)
        Me.Label96.TabIndex = 409
        Me.Label96.Text = "Duty cycle [%]"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(58, 162)
        Me.Label97.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(118, 18)
        Me.Label97.TabIndex = 408
        Me.Label97.Text = "Frequency [KHz]"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(59, 128)
        Me.Label98.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(49, 18)
        Me.Label98.TabIndex = 407
        Me.Label98.Text = "If [mA]"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label99.Location = New System.Drawing.Point(58, 98)
        Me.Label99.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(109, 18)
        Me.Label99.TabIndex = 406
        Me.Label99.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab5
        '
        Me.cboMeasurePoint2_tab5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab5.FormattingEnabled = True
        Me.cboMeasurePoint2_tab5.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab5.Name = "cboMeasurePoint2_tab5"
        Me.cboMeasurePoint2_tab5.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab5.TabIndex = 405
        '
        'cboMeasurePoint1_tab5
        '
        Me.cboMeasurePoint1_tab5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab5.FormattingEnabled = True
        Me.cboMeasurePoint1_tab5.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab5.Name = "cboMeasurePoint1_tab5"
        Me.cboMeasurePoint1_tab5.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab5.TabIndex = 404
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label100.Location = New System.Drawing.Point(565, 98)
        Me.Label100.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(135, 18)
        Me.Label100.TabIndex = 403
        Me.Label100.Text = "Measurement point"
        '
        'WaveForm6
        '
        Me.WaveForm6.Controls.Add(Me.cboTrigger_tab6)
        Me.WaveForm6.Controls.Add(Me.cboCh2coup_tab6)
        Me.WaveForm6.Controls.Add(Me.cboCh1coup_tab6)
        Me.WaveForm6.Controls.Add(Me.txtTriggerMode_tab6)
        Me.WaveForm6.Controls.Add(Me.txtTriggerLevel_tab6)
        Me.WaveForm6.Controls.Add(Me.Label101)
        Me.WaveForm6.Controls.Add(Me.Label102)
        Me.WaveForm6.Controls.Add(Me.txtTriggerType_tab6)
        Me.WaveForm6.Controls.Add(Me.txtCh2Volt_tab6)
        Me.WaveForm6.Controls.Add(Me.txtCh1Volt_tab6)
        Me.WaveForm6.Controls.Add(Me.txtDatapoint_tab6)
        Me.WaveForm6.Controls.Add(Me.txtTimediv_tab6)
        Me.WaveForm6.Controls.Add(Me.Label103)
        Me.WaveForm6.Controls.Add(Me.Label104)
        Me.WaveForm6.Controls.Add(Me.Label105)
        Me.WaveForm6.Controls.Add(Me.Label106)
        Me.WaveForm6.Controls.Add(Me.Label107)
        Me.WaveForm6.Controls.Add(Me.Label108)
        Me.WaveForm6.Controls.Add(Me.Label109)
        Me.WaveForm6.Controls.Add(Me.Label110)
        Me.WaveForm6.Controls.Add(Me.Label111)
        Me.WaveForm6.Controls.Add(Me.txtAtt_tab6)
        Me.WaveForm6.Controls.Add(Me.txtTld_tab6)
        Me.WaveForm6.Controls.Add(Me.txtTc_tab6)
        Me.WaveForm6.Controls.Add(Me.txtAvg_tab6)
        Me.WaveForm6.Controls.Add(Me.txtDelay_tab6)
        Me.WaveForm6.Controls.Add(Me.txtPulse_tab6)
        Me.WaveForm6.Controls.Add(Me.txtDuty_tab6)
        Me.WaveForm6.Controls.Add(Me.txtFrequen_tab6)
        Me.WaveForm6.Controls.Add(Me.txtIf_tab6)
        Me.WaveForm6.Controls.Add(Me.Label112)
        Me.WaveForm6.Controls.Add(Me.Label113)
        Me.WaveForm6.Controls.Add(Me.Label114)
        Me.WaveForm6.Controls.Add(Me.Label115)
        Me.WaveForm6.Controls.Add(Me.Label116)
        Me.WaveForm6.Controls.Add(Me.Label117)
        Me.WaveForm6.Controls.Add(Me.Label118)
        Me.WaveForm6.Controls.Add(Me.Label119)
        Me.WaveForm6.Controls.Add(Me.Label120)
        Me.WaveForm6.Controls.Add(Me.Label121)
        Me.WaveForm6.Controls.Add(Me.cboMeasurePoint2_tab6)
        Me.WaveForm6.Controls.Add(Me.cboMeasurePoint1_tab6)
        Me.WaveForm6.Controls.Add(Me.Label122)
        Me.WaveForm6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveForm6.Location = New System.Drawing.Point(4, 26)
        Me.WaveForm6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm6.Name = "WaveForm6"
        Me.WaveForm6.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WaveForm6.Size = New System.Drawing.Size(742, 488)
        Me.WaveForm6.TabIndex = 5
        Me.WaveForm6.Text = "WaveForm6"
        Me.WaveForm6.UseVisualStyleBackColor = True
        '
        'cboTrigger_tab6
        '
        Me.cboTrigger_tab6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrigger_tab6.FormattingEnabled = True
        Me.cboTrigger_tab6.Location = New System.Drawing.Point(457, 323)
        Me.cboTrigger_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTrigger_tab6.Name = "cboTrigger_tab6"
        Me.cboTrigger_tab6.Size = New System.Drawing.Size(85, 25)
        Me.cboTrigger_tab6.TabIndex = 445
        '
        'cboCh2coup_tab6
        '
        Me.cboCh2coup_tab6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh2coup_tab6.FormattingEnabled = True
        Me.cboCh2coup_tab6.Location = New System.Drawing.Point(457, 260)
        Me.cboCh2coup_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh2coup_tab6.Name = "cboCh2coup_tab6"
        Me.cboCh2coup_tab6.Size = New System.Drawing.Size(85, 25)
        Me.cboCh2coup_tab6.TabIndex = 444
        '
        'cboCh1coup_tab6
        '
        Me.cboCh1coup_tab6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCh1coup_tab6.FormattingEnabled = True
        Me.cboCh1coup_tab6.Location = New System.Drawing.Point(457, 193)
        Me.cboCh1coup_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCh1coup_tab6.Name = "cboCh1coup_tab6"
        Me.cboCh1coup_tab6.Size = New System.Drawing.Size(85, 25)
        Me.cboCh1coup_tab6.TabIndex = 443
        '
        'txtTriggerMode_tab6
        '
        Me.txtTriggerMode_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerMode_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerMode_tab6.Location = New System.Drawing.Point(457, 419)
        Me.txtTriggerMode_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerMode_tab6.Name = "txtTriggerMode_tab6"
        Me.txtTriggerMode_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerMode_tab6.TabIndex = 442
        '
        'txtTriggerLevel_tab6
        '
        Me.txtTriggerLevel_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerLevel_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerLevel_tab6.Location = New System.Drawing.Point(457, 388)
        Me.txtTriggerLevel_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerLevel_tab6.Name = "txtTriggerLevel_tab6"
        Me.txtTriggerLevel_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerLevel_tab6.TabIndex = 441
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(313, 420)
        Me.Label101.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(96, 18)
        Me.Label101.TabIndex = 440
        Me.Label101.Text = "Trigger mode"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(313, 389)
        Me.Label102.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(117, 18)
        Me.Label102.TabIndex = 439
        Me.Label102.Text = "Trigger Level[%] "
        '
        'txtTriggerType_tab6
        '
        Me.txtTriggerType_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerType_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerType_tab6.Location = New System.Drawing.Point(457, 357)
        Me.txtTriggerType_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTriggerType_tab6.Name = "txtTriggerType_tab6"
        Me.txtTriggerType_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTriggerType_tab6.TabIndex = 438
        '
        'txtCh2Volt_tab6
        '
        Me.txtCh2Volt_tab6.BackColor = System.Drawing.SystemColors.Window
        Me.txtCh2Volt_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh2Volt_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh2Volt_tab6.Location = New System.Drawing.Point(457, 293)
        Me.txtCh2Volt_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh2Volt_tab6.Name = "txtCh2Volt_tab6"
        Me.txtCh2Volt_tab6.ReadOnly = True
        Me.txtCh2Volt_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtCh2Volt_tab6.TabIndex = 437
        '
        'txtCh1Volt_tab6
        '
        Me.txtCh1Volt_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCh1Volt_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCh1Volt_tab6.Location = New System.Drawing.Point(457, 229)
        Me.txtCh1Volt_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCh1Volt_tab6.Name = "txtCh1Volt_tab6"
        Me.txtCh1Volt_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtCh1Volt_tab6.TabIndex = 436
        '
        'txtDatapoint_tab6
        '
        Me.txtDatapoint_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatapoint_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatapoint_tab6.Location = New System.Drawing.Point(457, 162)
        Me.txtDatapoint_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDatapoint_tab6.Name = "txtDatapoint_tab6"
        Me.txtDatapoint_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtDatapoint_tab6.TabIndex = 435
        '
        'txtTimediv_tab6
        '
        Me.txtTimediv_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimediv_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimediv_tab6.Location = New System.Drawing.Point(457, 128)
        Me.txtTimediv_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTimediv_tab6.Name = "txtTimediv_tab6"
        Me.txtTimediv_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTimediv_tab6.TabIndex = 434
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(312, 358)
        Me.Label103.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(85, 18)
        Me.Label103.TabIndex = 433
        Me.Label103.Text = "Trigger type"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(312, 327)
        Me.Label104.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(104, 18)
        Me.Label104.TabIndex = 432
        Me.Label104.Text = "Trigger source"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(312, 295)
        Me.Label105.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(144, 18)
        Me.Label105.TabIndex = 431
        Me.Label105.Text = "CH.2 Volts/div [V/div]"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(312, 262)
        Me.Label106.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(104, 18)
        Me.Label106.TabIndex = 430
        Me.Label106.Text = "CH2. Coupling"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(313, 232)
        Me.Label107.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(144, 18)
        Me.Label107.TabIndex = 429
        Me.Label107.Text = "CH.1 Volts/div [V/div]"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(312, 196)
        Me.Label108.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(104, 18)
        Me.Label108.TabIndex = 428
        Me.Label108.Text = "CH1. Coupling"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(312, 162)
        Me.Label109.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(109, 18)
        Me.Label109.TabIndex = 427
        Me.Label109.Text = "Data Point [pts]"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(313, 128)
        Me.Label110.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(113, 18)
        Me.Label110.TabIndex = 426
        Me.Label110.Text = "Time/div [us/div]"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label111.Location = New System.Drawing.Point(312, 98)
        Me.Label111.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(88, 18)
        Me.Label111.TabIndex = 425
        Me.Label111.Text = "OSC setting"
        '
        'txtAtt_tab6
        '
        Me.txtAtt_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtt_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt_tab6.Location = New System.Drawing.Point(178, 388)
        Me.txtAtt_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAtt_tab6.Name = "txtAtt_tab6"
        Me.txtAtt_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtAtt_tab6.TabIndex = 424
        '
        'txtTld_tab6
        '
        Me.txtTld_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTld_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTld_tab6.Location = New System.Drawing.Point(178, 358)
        Me.txtTld_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTld_tab6.Name = "txtTld_tab6"
        Me.txtTld_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTld_tab6.TabIndex = 423
        '
        'txtTc_tab6
        '
        Me.txtTc_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTc_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc_tab6.Location = New System.Drawing.Point(178, 327)
        Me.txtTc_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTc_tab6.Name = "txtTc_tab6"
        Me.txtTc_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtTc_tab6.TabIndex = 422
        '
        'txtAvg_tab6
        '
        Me.txtAvg_tab6.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvg_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg_tab6.Location = New System.Drawing.Point(178, 293)
        Me.txtAvg_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvg_tab6.Name = "txtAvg_tab6"
        Me.txtAvg_tab6.ReadOnly = True
        Me.txtAvg_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtAvg_tab6.TabIndex = 421
        '
        'txtDelay_tab6
        '
        Me.txtDelay_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay_tab6.Location = New System.Drawing.Point(178, 260)
        Me.txtDelay_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDelay_tab6.Name = "txtDelay_tab6"
        Me.txtDelay_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtDelay_tab6.TabIndex = 420
        '
        'txtPulse_tab6
        '
        Me.txtPulse_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse_tab6.Location = New System.Drawing.Point(178, 229)
        Me.txtPulse_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPulse_tab6.Name = "txtPulse_tab6"
        Me.txtPulse_tab6.ReadOnly = True
        Me.txtPulse_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtPulse_tab6.TabIndex = 419
        '
        'txtDuty_tab6
        '
        Me.txtDuty_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuty_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty_tab6.Location = New System.Drawing.Point(178, 196)
        Me.txtDuty_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuty_tab6.Name = "txtDuty_tab6"
        Me.txtDuty_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtDuty_tab6.TabIndex = 418
        '
        'txtFrequen_tab6
        '
        Me.txtFrequen_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequen_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequen_tab6.Location = New System.Drawing.Point(178, 162)
        Me.txtFrequen_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFrequen_tab6.Name = "txtFrequen_tab6"
        Me.txtFrequen_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtFrequen_tab6.TabIndex = 417
        '
        'txtIf_tab6
        '
        Me.txtIf_tab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIf_tab6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIf_tab6.Location = New System.Drawing.Point(178, 128)
        Me.txtIf_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIf_tab6.Name = "txtIf_tab6"
        Me.txtIf_tab6.Size = New System.Drawing.Size(84, 24)
        Me.txtIf_tab6.TabIndex = 416
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(59, 389)
        Me.Label112.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(65, 18)
        Me.Label112.TabIndex = 415
        Me.Label112.Text = "ATT [dB]"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(58, 358)
        Me.Label113.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(56, 18)
        Me.Label113.TabIndex = 414
        Me.Label113.Text = "Tld [⁰C]"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(58, 327)
        Me.Label114.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(53, 18)
        Me.Label114.TabIndex = 413
        Me.Label114.Text = "Tc [⁰C]"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(58, 295)
        Me.Label115.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(101, 18)
        Me.Label115.TabIndex = 412
        Me.Label115.Text = "Average [time]"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(58, 262)
        Me.Label116.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(101, 18)
        Me.Label116.TabIndex = 411
        Me.Label116.Text = "Delay time[us]"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(59, 232)
        Me.Label117.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(115, 18)
        Me.Label117.TabIndex = 410
        Me.Label117.Text = "Pulse Width [us]"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(58, 196)
        Me.Label118.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(101, 18)
        Me.Label118.TabIndex = 409
        Me.Label118.Text = "Duty cycle [%]"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(58, 162)
        Me.Label119.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(118, 18)
        Me.Label119.TabIndex = 408
        Me.Label119.Text = "Frequency [KHz]"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(59, 128)
        Me.Label120.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(49, 18)
        Me.Label120.TabIndex = 407
        Me.Label120.Text = "If [mA]"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label121.Location = New System.Drawing.Point(58, 98)
        Me.Label121.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(109, 18)
        Me.Label121.TabIndex = 406
        Me.Label121.Text = "Pulse condition"
        '
        'cboMeasurePoint2_tab6
        '
        Me.cboMeasurePoint2_tab6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint2_tab6.FormattingEnabled = True
        Me.cboMeasurePoint2_tab6.Location = New System.Drawing.Point(574, 171)
        Me.cboMeasurePoint2_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint2_tab6.Name = "cboMeasurePoint2_tab6"
        Me.cboMeasurePoint2_tab6.Size = New System.Drawing.Size(114, 25)
        Me.cboMeasurePoint2_tab6.TabIndex = 405
        '
        'cboMeasurePoint1_tab6
        '
        Me.cboMeasurePoint1_tab6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMeasurePoint1_tab6.FormattingEnabled = True
        Me.cboMeasurePoint1_tab6.Location = New System.Drawing.Point(574, 131)
        Me.cboMeasurePoint1_tab6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMeasurePoint1_tab6.Name = "cboMeasurePoint1_tab6"
        Me.cboMeasurePoint1_tab6.Size = New System.Drawing.Size(83, 25)
        Me.cboMeasurePoint1_tab6.TabIndex = 404
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label122.Location = New System.Drawing.Point(565, 98)
        Me.Label122.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(135, 18)
        Me.Label122.TabIndex = 403
        Me.Label122.Text = "Measurement point"
        '
        'btnCancleILm
        '
        Me.btnCancleILm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancleILm.Location = New System.Drawing.Point(623, 524)
        Me.btnCancleILm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancleILm.Name = "btnCancleILm"
        Me.btnCancleILm.Size = New System.Drawing.Size(77, 30)
        Me.btnCancleILm.TabIndex = 470
        Me.btnCancleILm.Text = "Cancle"
        Me.btnCancleILm.UseVisualStyleBackColor = True
        '
        'btnSaveILm
        '
        Me.btnSaveILm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveILm.Location = New System.Drawing.Point(531, 524)
        Me.btnSaveILm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveILm.Name = "btnSaveILm"
        Me.btnSaveILm.Size = New System.Drawing.Size(77, 30)
        Me.btnSaveILm.TabIndex = 469
        Me.btnSaveILm.Text = "Save"
        Me.btnSaveILm.UseVisualStyleBackColor = True
        '
        'frmWMeasurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 569)
        Me.Controls.Add(Me.btnCancleILm)
        Me.Controls.Add(Me.btnSaveILm)
        Me.Controls.Add(Me.tabsWaveform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmWMeasurement"
        Me.Text = "frmWMeasurement"
        Me.tabsWaveform.ResumeLayout(False)
        Me.WaveForm1.ResumeLayout(False)
        Me.WaveForm1.PerformLayout()
        Me.WaveForm2.ResumeLayout(False)
        Me.WaveForm2.PerformLayout()
        Me.WaveForm3.ResumeLayout(False)
        Me.WaveForm3.PerformLayout()
        Me.WaveForm4.ResumeLayout(False)
        Me.WaveForm4.PerformLayout()
        Me.WaveForm5.ResumeLayout(False)
        Me.WaveForm5.PerformLayout()
        Me.WaveForm6.ResumeLayout(False)
        Me.WaveForm6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabsWaveform As TabControl
    Friend WithEvents WaveForm2 As TabPage
    Friend WithEvents WaveForm3 As TabPage
    Friend WithEvents WaveForm4 As TabPage
    Friend WithEvents WaveForm5 As TabPage
    Friend WithEvents WaveForm6 As TabPage
    Friend WithEvents WaveForm1 As TabPage
    Friend WithEvents cboTrigger_tab2 As ComboBox
    Friend WithEvents cboCh2coup_tab2 As ComboBox
    Friend WithEvents cboCh1coup_tab2 As ComboBox
    Friend WithEvents txtTriggerMode_tab2 As TextBox
    Friend WithEvents txtTriggerLevel_tab2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTriggerType_tab2 As TextBox
    Friend WithEvents txtCh2Volt_tab2 As TextBox
    Friend WithEvents txtCh1Volt_tab2 As TextBox
    Friend WithEvents txtDatapoint_tab2 As TextBox
    Friend WithEvents txtTimediv_tab2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAtt_tab2 As TextBox
    Friend WithEvents txtTld_tab2 As TextBox
    Friend WithEvents txtTc_tab2 As TextBox
    Friend WithEvents txtAvg_tab2 As TextBox
    Friend WithEvents txtDelay_tab2 As TextBox
    Friend WithEvents txtPulse_tab2 As TextBox
    Friend WithEvents txtDuty_tab2 As TextBox
    Friend WithEvents txtFrequen_tab2 As TextBox
    Friend WithEvents txtIf_tab2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents cboMeasurePoint2_tab2 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab2 As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cboTrigger_tab3 As ComboBox
    Friend WithEvents cboCh2coup_tab3 As ComboBox
    Friend WithEvents cboCh1coup_tab3 As ComboBox
    Friend WithEvents txtTriggerMode_tab3 As TextBox
    Friend WithEvents txtTriggerLevel_tab3 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtTriggerType_tab3 As TextBox
    Friend WithEvents txtCh2Volt_tab3 As TextBox
    Friend WithEvents txtCh1Volt_tab3 As TextBox
    Friend WithEvents txtDatapoint_tab3 As TextBox
    Friend WithEvents txtTimediv_tab3 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txtAtt_tab3 As TextBox
    Friend WithEvents txtTld_tab3 As TextBox
    Friend WithEvents txtTc_tab3 As TextBox
    Friend WithEvents txtAvg_tab3 As TextBox
    Friend WithEvents txtDelay_tab3 As TextBox
    Friend WithEvents txtPulse_tab3 As TextBox
    Friend WithEvents txtDuty_tab3 As TextBox
    Friend WithEvents txtFrequen_tab3 As TextBox
    Friend WithEvents txtIf_tab3 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents cboMeasurePoint2_tab3 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab3 As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents cboTrigger_tab4 As ComboBox
    Friend WithEvents cboCh2coup_tab4 As ComboBox
    Friend WithEvents cboCh1coup_tab4 As ComboBox
    Friend WithEvents txtTriggerMode_tab4 As TextBox
    Friend WithEvents txtTriggerLevel_tab4 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents txtTriggerType_tab4 As TextBox
    Friend WithEvents txtCh2Volt_tab4 As TextBox
    Friend WithEvents txtCh1Volt_tab4 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents txtDatapoint_tab4 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtAtt_tab4 As TextBox
    Friend WithEvents txtTld_tab4 As TextBox
    Friend WithEvents txtTc_tab4 As TextBox
    Friend WithEvents txtAvg_tab4 As TextBox
    Friend WithEvents txtDelay_tab4 As TextBox
    Friend WithEvents txtPulse_tab4 As TextBox
    Friend WithEvents txtDuty_tab4 As TextBox
    Friend WithEvents txtFrequen_tab4 As TextBox
    Friend WithEvents txtIf_tab4 As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents cboMeasurePoint2_tab4 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab4 As ComboBox
    Friend WithEvents Label78 As Label
    Friend WithEvents cboTrigger_tab5 As ComboBox
    Friend WithEvents cboCh2coup_tab5 As ComboBox
    Friend WithEvents cboCh1coup_tab5 As ComboBox
    Friend WithEvents txtTriggerMode_tab5 As TextBox
    Friend WithEvents txtTriggerLevel_tab5 As TextBox
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents txtTriggerType_tab5 As TextBox
    Friend WithEvents txtCh2Volt_tab5 As TextBox
    Friend WithEvents txtCh1Volt_tab5 As TextBox
    Friend WithEvents txtDatapoint_tab5 As TextBox
    Friend WithEvents txtTimediv_tab5 As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents txtAtt_tab5 As TextBox
    Friend WithEvents txtTld_tab5 As TextBox
    Friend WithEvents txtTc_tab5 As TextBox
    Friend WithEvents txtAvg_tab5 As TextBox
    Friend WithEvents txtDelay_tab5 As TextBox
    Friend WithEvents txtPulse_tab5 As TextBox
    Friend WithEvents txtDuty_tab5 As TextBox
    Friend WithEvents txtFrequen_tab5 As TextBox
    Friend WithEvents txtIf_tab5 As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents cboMeasurePoint2_tab5 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab5 As ComboBox
    Friend WithEvents Label100 As Label
    Friend WithEvents cboTrigger_tab1 As ComboBox
    Friend WithEvents cboCh2coup_tab1 As ComboBox
    Friend WithEvents cboCh1coup_tab1 As ComboBox
    Friend WithEvents txtTriggerMode_tab1 As TextBox
    Friend WithEvents txtTriggerLevel_tab1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTriggerType_tab1 As TextBox
    Friend WithEvents txtCh2Volt_tab1 As TextBox
    Friend WithEvents txtCh1Volt_tab1 As TextBox
    Friend WithEvents txtDatapoint_tab1 As TextBox
    Friend WithEvents txtTimediv_tab1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtAtt_tab1 As TextBox
    Friend WithEvents txtTld_tab1 As TextBox
    Friend WithEvents txtTc_tab1 As TextBox
    Friend WithEvents txtAvg_tab1 As TextBox
    Friend WithEvents txtDelay_tab1 As TextBox
    Friend WithEvents txtPulse_tab1 As TextBox
    Friend WithEvents txtDuty_tab1 As TextBox
    Friend WithEvents txtFrequen_tab1 As TextBox
    Friend WithEvents txtIf_tab1 As TextBox
    Friend WithEvents Label229 As Label
    Friend WithEvents Label231 As Label
    Friend WithEvents Label232 As Label
    Friend WithEvents Label234 As Label
    Friend WithEvents Label235 As Label
    Friend WithEvents Label236 As Label
    Friend WithEvents Label237 As Label
    Friend WithEvents Label238 As Label
    Friend WithEvents Label239 As Label
    Friend WithEvents Label240 As Label
    Friend WithEvents cboMeasurePoint2_tab1 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTrigger_tab6 As ComboBox
    Friend WithEvents cboCh2coup_tab6 As ComboBox
    Friend WithEvents cboCh1coup_tab6 As ComboBox
    Friend WithEvents txtTriggerMode_tab6 As TextBox
    Friend WithEvents txtTriggerLevel_tab6 As TextBox
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents txtTriggerType_tab6 As TextBox
    Friend WithEvents txtCh2Volt_tab6 As TextBox
    Friend WithEvents txtCh1Volt_tab6 As TextBox
    Friend WithEvents txtDatapoint_tab6 As TextBox
    Friend WithEvents txtTimediv_tab6 As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents txtAtt_tab6 As TextBox
    Friend WithEvents txtTld_tab6 As TextBox
    Friend WithEvents txtTc_tab6 As TextBox
    Friend WithEvents txtAvg_tab6 As TextBox
    Friend WithEvents txtDelay_tab6 As TextBox
    Friend WithEvents txtPulse_tab6 As TextBox
    Friend WithEvents txtDuty_tab6 As TextBox
    Friend WithEvents txtFrequen_tab6 As TextBox
    Friend WithEvents txtIf_tab6 As TextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents cboMeasurePoint2_tab6 As ComboBox
    Friend WithEvents cboMeasurePoint1_tab6 As ComboBox
    Friend WithEvents Label122 As Label
    Friend WithEvents btnCancleILm As Button
    Friend WithEvents btnSaveILm As Button
End Class
