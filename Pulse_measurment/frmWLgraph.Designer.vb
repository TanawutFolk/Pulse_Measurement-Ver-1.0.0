<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWLgraph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEasureme = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDataTime = New System.Windows.Forms.Label()
        Me.lblOperator_ID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(813, 584)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(74, 46)
        Me.btnDown.TabIndex = 34
        Me.btnDown.Text = "↓"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(893, 584)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(74, 46)
        Me.btnNext.TabIndex = 33
        Me.btnNext.Text = "NEXT"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnEasureme
        '
        Me.btnEasureme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEasureme.Location = New System.Drawing.Point(733, 584)
        Me.btnEasureme.Name = "btnEasureme"
        Me.btnEasureme.Size = New System.Drawing.Size(74, 46)
        Me.btnEasureme.TabIndex = 32
        Me.btnEasureme.Text = "easu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "reme"
        Me.btnEasureme.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(813, 532)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(74, 46)
        Me.btnUp.TabIndex = 31
        Me.btnUp.Text = "↑"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(893, 532)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(74, 46)
        Me.btnRight.TabIndex = 30
        Me.btnRight.Text = "→"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnleft
        '
        Me.btnleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnleft.Location = New System.Drawing.Point(733, 532)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(74, 46)
        Me.btnleft.TabIndex = 29
        Me.btnleft.Text = "←"
        Me.btnleft.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(735, 114)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(232, 387)
        Me.TextBox1.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "1st Measurement"
        '
        'lblDataTime
        '
        Me.lblDataTime.AutoSize = True
        Me.lblDataTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataTime.Location = New System.Drawing.Point(497, 90)
        Me.lblDataTime.Name = "lblDataTime"
        Me.lblDataTime.Size = New System.Drawing.Size(140, 18)
        Me.lblDataTime.TabIndex = 26
        Me.lblDataTime.Text = "2024/10/30 13:35:31"
        '
        'lblOperator_ID
        '
        Me.lblOperator_ID.AutoSize = True
        Me.lblOperator_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator_ID.Location = New System.Drawing.Point(497, 63)
        Me.lblOperator_ID.Name = "lblOperator_ID"
        Me.lblOperator_ID.Size = New System.Drawing.Size(58, 18)
        Me.lblOperator_ID.TabIndex = 25
        Me.lblOperator_ID.Text = "S00727"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Data/Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Operator"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(49, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 74)
        Me.Panel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "20241030-02"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AC22BXA01"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(371, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 26)
        Me.Panel3.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Spectrum"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(733, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 74)
        Me.Panel4.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product I-L/wavelength"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(219, 161)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(474, 340)
        Me.Chart1.TabIndex = 35
        Me.Chart1.Text = "Chart1"
        '
        'frmWLgraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnEasureme)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnleft)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDataTime)
        Me.Controls.Add(Me.lblOperator_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWLgraph"
        Me.Text = "WLgraph"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDown As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEasureme As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnleft As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDataTime As Label
    Friend WithEvents lblOperator_ID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
