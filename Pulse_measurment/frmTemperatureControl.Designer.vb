<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperatureControl
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCaseSettingTemp = New System.Windows.Forms.Label()
        Me.lblCasePresentTemp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCaseWaitingtime = New System.Windows.Forms.Label()
        Me.blCaseRemainingtime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTldRemainingTime = New System.Windows.Forms.Label()
        Me.lblTldWaittingTime = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTldPresentTemp = New System.Windows.Forms.Label()
        Me.lblTldSettngTilme = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblMosRemainingTime = New System.Windows.Forms.Label()
        Me.lblMosWaitingTime = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblMosPresentTemp = New System.Windows.Forms.Label()
        Me.lblMosSettingTemp = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblTimeout = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(74, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Case temperature"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(138, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Setting temp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(138, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Present temp."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(507, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Remaining time."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(507, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Waiting time."
        '
        'lblCaseSettingTemp
        '
        Me.lblCaseSettingTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCaseSettingTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseSettingTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaseSettingTemp.Location = New System.Drawing.Point(277, 98)
        Me.lblCaseSettingTemp.Name = "lblCaseSettingTemp"
        Me.lblCaseSettingTemp.Size = New System.Drawing.Size(136, 36)
        Me.lblCaseSettingTemp.TabIndex = 7
        Me.lblCaseSettingTemp.Text = "00.0"
        Me.lblCaseSettingTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCasePresentTemp
        '
        Me.lblCasePresentTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCasePresentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasePresentTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCasePresentTemp.Location = New System.Drawing.Point(277, 146)
        Me.lblCasePresentTemp.Name = "lblCasePresentTemp"
        Me.lblCasePresentTemp.Size = New System.Drawing.Size(136, 36)
        Me.lblCasePresentTemp.TabIndex = 8
        Me.lblCasePresentTemp.Text = "00.0"
        Me.lblCasePresentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(419, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "⁰C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(419, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "⁰C"
        '
        'lblCaseWaitingtime
        '
        Me.lblCaseWaitingtime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCaseWaitingtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseWaitingtime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaseWaitingtime.Location = New System.Drawing.Point(657, 98)
        Me.lblCaseWaitingtime.Name = "lblCaseWaitingtime"
        Me.lblCaseWaitingtime.Size = New System.Drawing.Size(136, 36)
        Me.lblCaseWaitingtime.TabIndex = 11
        Me.lblCaseWaitingtime.Text = "00.0"
        Me.lblCaseWaitingtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'blCaseRemainingtime
        '
        Me.blCaseRemainingtime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.blCaseRemainingtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blCaseRemainingtime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.blCaseRemainingtime.Location = New System.Drawing.Point(657, 146)
        Me.blCaseRemainingtime.Name = "blCaseRemainingtime"
        Me.blCaseRemainingtime.Size = New System.Drawing.Size(136, 36)
        Me.blCaseRemainingtime.TabIndex = 12
        Me.blCaseRemainingtime.Text = "00.0"
        Me.blCaseRemainingtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(814, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 22)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "sec"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(814, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 22)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "sec"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label14.Location = New System.Drawing.Point(814, 318)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "sec"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label15.Location = New System.Drawing.Point(814, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 22)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "sec"
        '
        'lblTldRemainingTime
        '
        Me.lblTldRemainingTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTldRemainingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTldRemainingTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTldRemainingTime.Location = New System.Drawing.Point(657, 311)
        Me.lblTldRemainingTime.Name = "lblTldRemainingTime"
        Me.lblTldRemainingTime.Size = New System.Drawing.Size(136, 36)
        Me.lblTldRemainingTime.TabIndex = 25
        Me.lblTldRemainingTime.Text = "00.0"
        Me.lblTldRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTldWaittingTime
        '
        Me.lblTldWaittingTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTldWaittingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTldWaittingTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTldWaittingTime.Location = New System.Drawing.Point(657, 263)
        Me.lblTldWaittingTime.Name = "lblTldWaittingTime"
        Me.lblTldWaittingTime.Size = New System.Drawing.Size(136, 36)
        Me.lblTldWaittingTime.TabIndex = 24
        Me.lblTldWaittingTime.Text = "00.0"
        Me.lblTldWaittingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label18.Location = New System.Drawing.Point(419, 318)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 22)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "⁰C"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label19.Location = New System.Drawing.Point(419, 269)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 22)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "⁰C"
        '
        'lblTldPresentTemp
        '
        Me.lblTldPresentTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTldPresentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTldPresentTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTldPresentTemp.Location = New System.Drawing.Point(277, 311)
        Me.lblTldPresentTemp.Name = "lblTldPresentTemp"
        Me.lblTldPresentTemp.Size = New System.Drawing.Size(136, 36)
        Me.lblTldPresentTemp.TabIndex = 21
        Me.lblTldPresentTemp.Text = "00.0"
        Me.lblTldPresentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTldSettngTilme
        '
        Me.lblTldSettngTilme.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTldSettngTilme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTldSettngTilme.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTldSettngTilme.Location = New System.Drawing.Point(277, 263)
        Me.lblTldSettngTilme.Name = "lblTldSettngTilme"
        Me.lblTldSettngTilme.Size = New System.Drawing.Size(136, 36)
        Me.lblTldSettngTilme.TabIndex = 20
        Me.lblTldSettngTilme.Text = "00.0"
        Me.lblTldSettngTilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label22.Location = New System.Drawing.Point(507, 318)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(138, 22)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Remaining time."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label23.Location = New System.Drawing.Point(507, 269)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 22)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Waiting time."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label24.Location = New System.Drawing.Point(138, 318)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(121, 22)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Present temp."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label25.Location = New System.Drawing.Point(138, 269)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 22)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Setting temp."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label26.Location = New System.Drawing.Point(74, 221)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(137, 22)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Tld temperature"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label27.Location = New System.Drawing.Point(814, 481)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 22)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "sec"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label28.Location = New System.Drawing.Point(814, 434)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 22)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "sec"
        '
        'lblMosRemainingTime
        '
        Me.lblMosRemainingTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMosRemainingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMosRemainingTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMosRemainingTime.Location = New System.Drawing.Point(657, 474)
        Me.lblMosRemainingTime.Name = "lblMosRemainingTime"
        Me.lblMosRemainingTime.Size = New System.Drawing.Size(136, 36)
        Me.lblMosRemainingTime.TabIndex = 38
        Me.lblMosRemainingTime.Text = "00.0"
        Me.lblMosRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMosWaitingTime
        '
        Me.lblMosWaitingTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMosWaitingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMosWaitingTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMosWaitingTime.Location = New System.Drawing.Point(657, 426)
        Me.lblMosWaitingTime.Name = "lblMosWaitingTime"
        Me.lblMosWaitingTime.Size = New System.Drawing.Size(136, 36)
        Me.lblMosWaitingTime.TabIndex = 37
        Me.lblMosWaitingTime.Text = "00.0"
        Me.lblMosWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label31.Location = New System.Drawing.Point(419, 481)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(29, 22)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "⁰C"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label32.Location = New System.Drawing.Point(419, 432)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 22)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "⁰C"
        '
        'lblMosPresentTemp
        '
        Me.lblMosPresentTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMosPresentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMosPresentTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMosPresentTemp.Location = New System.Drawing.Point(277, 474)
        Me.lblMosPresentTemp.Name = "lblMosPresentTemp"
        Me.lblMosPresentTemp.Size = New System.Drawing.Size(136, 36)
        Me.lblMosPresentTemp.TabIndex = 34
        Me.lblMosPresentTemp.Text = "00.0"
        Me.lblMosPresentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMosSettingTemp
        '
        Me.lblMosSettingTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMosSettingTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMosSettingTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMosSettingTemp.Location = New System.Drawing.Point(277, 426)
        Me.lblMosSettingTemp.Name = "lblMosSettingTemp"
        Me.lblMosSettingTemp.Size = New System.Drawing.Size(136, 36)
        Me.lblMosSettingTemp.TabIndex = 33
        Me.lblMosSettingTemp.Text = "00.0"
        Me.lblMosSettingTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label35.Location = New System.Drawing.Point(507, 481)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(138, 22)
        Me.Label35.TabIndex = 32
        Me.Label35.Text = "Remaining time."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label36.Location = New System.Drawing.Point(507, 432)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(113, 22)
        Me.Label36.TabIndex = 31
        Me.Label36.Text = "Waiting time."
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label37.Location = New System.Drawing.Point(128, 481)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(121, 22)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "Present temp."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label38.Location = New System.Drawing.Point(128, 432)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(153, 22)
        Me.Label38.TabIndex = 29
        Me.Label38.Text = "Setting temp max."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label39.Location = New System.Drawing.Point(74, 384)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(158, 22)
        Me.Label39.TabIndex = 28
        Me.Label39.Text = "MOS Temperature"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label40.Location = New System.Drawing.Point(534, 594)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(38, 22)
        Me.Label40.TabIndex = 43
        Me.Label40.Text = "sec"
        '
        'lblTimeout
        '
        Me.lblTimeout.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTimeout.Location = New System.Drawing.Point(378, 586)
        Me.lblTimeout.Name = "lblTimeout"
        Me.lblTimeout.Size = New System.Drawing.Size(136, 36)
        Me.lblTimeout.TabIndex = 42
        Me.lblTimeout.Text = "00.0"
        Me.lblTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label42.Location = New System.Drawing.Point(279, 594)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(81, 22)
        Me.Label42.TabIndex = 41
        Me.Label42.Text = "Time-out"
        '
        'btnCancle
        '
        Me.btnCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancle.Location = New System.Drawing.Point(686, 574)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(166, 69)
        Me.btnCancle.TabIndex = 44
        Me.btnCancle.Text = "Cancle"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'frmTemperatureControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.lblTimeout)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lblMosRemainingTime)
        Me.Controls.Add(Me.lblMosWaitingTime)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lblMosPresentTemp)
        Me.Controls.Add(Me.lblMosSettingTemp)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTldRemainingTime)
        Me.Controls.Add(Me.lblTldWaittingTime)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblTldPresentTemp)
        Me.Controls.Add(Me.lblTldSettngTilme)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.blCaseRemainingtime)
        Me.Controls.Add(Me.lblCaseWaitingtime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCasePresentTemp)
        Me.Controls.Add(Me.lblCaseSettingTemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemperatureControl"
        Me.Text = "frmTemperatureControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCaseSettingTemp As Label
    Friend WithEvents lblCasePresentTemp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCaseWaitingtime As Label
    Friend WithEvents blCaseRemainingtime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTldRemainingTime As Label
    Friend WithEvents lblTldWaittingTime As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblTldPresentTemp As Label
    Friend WithEvents lblTldSettngTilme As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblMosRemainingTime As Label
    Friend WithEvents lblMosWaitingTime As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblMosPresentTemp As Label
    Friend WithEvents lblMosSettingTemp As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblTimeout As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents btnCancle As Button
End Class
