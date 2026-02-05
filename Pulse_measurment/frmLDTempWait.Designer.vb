<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLDTempWait
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLDTempWait))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltmr = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.pnTldstatus = New System.Windows.Forms.Panel()
        Me.pnTcstatus = New System.Windows.Forms.Panel()
        Me.lblTldStatus = New System.Windows.Forms.Label()
        Me.lblTcStatus = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblTcactual = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTcset = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTldactual = New System.Windows.Forms.Label()
        Me.txtTldset = New System.Windows.Forms.TextBox()
        'Me.bgworkerTempCtrl = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox2.Controls.Add(Me.lbltmr)
        Me.GroupBox2.Controls.Add(Me.lblSec)
        Me.GroupBox2.Controls.Add(Me.lblCounter)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 176)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(559, 71)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time out"
        '
        'lbltmr
        '
        Me.lbltmr.AutoSize = True
        Me.lbltmr.Location = New System.Drawing.Point(255, 34)
        Me.lbltmr.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbltmr.Name = "lbltmr"
        Me.lbltmr.Size = New System.Drawing.Size(44, 18)
        Me.lbltmr.TabIndex = 12
        Me.lbltmr.Text = "lbltmr"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(347, 34)
        Me.lblSec.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(42, 18)
        Me.lblSec.TabIndex = 11
        Me.lblSec.Text = "(sec)"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(155, 34)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(61, 18)
        Me.lblCounter.TabIndex = 8
        Me.lblCounter.Text = "Counter"
        '
        'pnTldstatus
        '
        Me.pnTldstatus.BackColor = System.Drawing.Color.GreenYellow
        Me.pnTldstatus.Location = New System.Drawing.Point(332, 263)
        Me.pnTldstatus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnTldstatus.Name = "pnTldstatus"
        Me.pnTldstatus.Size = New System.Drawing.Size(49, 37)
        Me.pnTldstatus.TabIndex = 24
        '
        'pnTcstatus
        '
        Me.pnTcstatus.BackColor = System.Drawing.Color.Tomato
        Me.pnTcstatus.Location = New System.Drawing.Point(31, 263)
        Me.pnTcstatus.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnTcstatus.Name = "pnTcstatus"
        Me.pnTcstatus.Size = New System.Drawing.Size(49, 37)
        Me.pnTcstatus.TabIndex = 23
        '
        'lblTldStatus
        '
        Me.lblTldStatus.AutoSize = True
        Me.lblTldStatus.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTldStatus.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTldStatus.Location = New System.Drawing.Point(392, 268)
        Me.lblTldStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTldStatus.Name = "lblTldStatus"
        Me.lblTldStatus.Size = New System.Drawing.Size(112, 33)
        Me.lblTldStatus.TabIndex = 22
        Me.lblTldStatus.Text = "Ts Ready"
        '
        'lblTcStatus
        '
        Me.lblTcStatus.AutoSize = True
        Me.lblTcStatus.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTcStatus.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTcStatus.Location = New System.Drawing.Point(87, 268)
        Me.lblTcStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTcStatus.Name = "lblTcStatus"
        Me.lblTcStatus.Size = New System.Drawing.Size(156, 33)
        Me.lblTcStatus.TabIndex = 21
        Me.lblTcStatus.Text = "Tc not Ready"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(472, 325)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 32)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tmrCountdown
        '
        '
        'lblTcactual
        '
        Me.lblTcactual.AutoSize = True
        Me.lblTcactual.Location = New System.Drawing.Point(424, 98)
        Me.lblTcactual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTcactual.Name = "lblTcactual"
        Me.lblTcactual.Size = New System.Drawing.Size(78, 18)
        Me.lblTcactual.TabIndex = 9
        Me.lblTcactual.Text = "lblTcactual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tc actual (degC)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ts actual (degC)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tc set (degC)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ts set (degC)"
        '
        'txtTcset
        '
        Me.txtTcset.Enabled = False
        Me.txtTcset.Location = New System.Drawing.Point(428, 47)
        Me.txtTcset.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTcset.Name = "txtTcset"
        Me.txtTcset.ReadOnly = True
        Me.txtTcset.Size = New System.Drawing.Size(72, 24)
        Me.txtTcset.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.lblTcactual)
        Me.GroupBox1.Controls.Add(Me.lblTldactual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTcset)
        Me.GroupBox1.Controls.Add(Me.txtTldset)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(559, 150)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperature"
        '
        'lblTldactual
        '
        Me.lblTldactual.AutoSize = True
        Me.lblTldactual.Location = New System.Drawing.Point(159, 98)
        Me.lblTldactual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTldactual.Name = "lblTldactual"
        Me.lblTldactual.Size = New System.Drawing.Size(81, 18)
        Me.lblTldactual.TabIndex = 8
        Me.lblTldactual.Text = "lblTldactual"
        '
        'txtTldset
        '
        Me.txtTldset.Enabled = False
        Me.txtTldset.Location = New System.Drawing.Point(161, 46)
        Me.txtTldset.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTldset.Name = "txtTldset"
        Me.txtTldset.ReadOnly = True
        Me.txtTldset.Size = New System.Drawing.Size(72, 24)
        Me.txtTldset.TabIndex = 0
        ''
        ''bgworkerTempCtrl
        ''
        'Me.bgworkerTempCtrl.WorkerReportsProgress = True
        'Me.bgworkerTempCtrl.WorkerSupportsCancellation = True
        '
        'frmLDTempWait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 373)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnTldstatus)
        Me.Controls.Add(Me.pnTcstatus)
        Me.Controls.Add(Me.lblTldStatus)
        Me.Controls.Add(Me.lblTcStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLDTempWait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Control"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltmr As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents pnTldstatus As System.Windows.Forms.Panel
    Friend WithEvents pnTcstatus As System.Windows.Forms.Panel
    Friend WithEvents lblTldStatus As System.Windows.Forms.Label
    Friend WithEvents lblTcStatus As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents lblTcactual As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTcset As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTldactual As System.Windows.Forms.Label
    Friend WithEvents txtTldset As System.Windows.Forms.TextBox
    Friend WithEvents bgworkerTempCtrl As System.ComponentModel.BackgroundWorker
End Class
