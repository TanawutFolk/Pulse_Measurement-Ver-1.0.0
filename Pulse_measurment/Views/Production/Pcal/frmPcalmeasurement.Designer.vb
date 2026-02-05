<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPcalmeasurement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRemeasurement = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPcalmW = New System.Windows.Forms.Label()
        Me.btnNextprocedure = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRemeasurement
        '
        Me.btnRemeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemeasurement.Location = New System.Drawing.Point(24, 150)
        Me.btnRemeasurement.Name = "btnRemeasurement"
        Me.btnRemeasurement.Size = New System.Drawing.Size(193, 39)
        Me.btnRemeasurement.TabIndex = 0
        Me.btnRemeasurement.Text = "Remeasurement"
        Me.btnRemeasurement.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancle.Location = New System.Drawing.Point(223, 150)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(121, 39)
        Me.btnCancle.TabIndex = 1
        Me.btnCancle.Text = "Cancel"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pcal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(333, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "mW"
        '
        'lblPcalmW
        '
        Me.lblPcalmW.AutoSize = True
        Me.lblPcalmW.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPcalmW.Location = New System.Drawing.Point(258, 77)
        Me.lblPcalmW.Name = "lblPcalmW"
        Me.lblPcalmW.Size = New System.Drawing.Size(63, 34)
        Me.lblPcalmW.TabIndex = 5
        Me.lblPcalmW.Text = "000"
        '
        'btnNextprocedure
        '
        Me.btnNextprocedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextprocedure.Location = New System.Drawing.Point(350, 150)
        Me.btnNextprocedure.Name = "btnNextprocedure"
        Me.btnNextprocedure.Size = New System.Drawing.Size(219, 39)
        Me.btnNextprocedure.TabIndex = 6
        Me.btnNextprocedure.Text = "The Next Procedure"
        Me.btnNextprocedure.UseVisualStyleBackColor = True
        '
        'frmPcalmeasurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNextprocedure)
        Me.Controls.Add(Me.lblPcalmW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnRemeasurement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmPcalmeasurement"
        Me.Text = "The next procedure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemeasurement As Button
    Friend WithEvents btnCancle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPcalmW As Label
    Friend WithEvents btnNextprocedure As Button
End Class
