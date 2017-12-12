<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.comboOrganisms = New System.Windows.Forms.ComboBox()
        Me.comboMultiply = New System.Windows.Forms.ComboBox()
        Me.txtBoxIncrease = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 207)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'comboOrganisms
        '
        Me.comboOrganisms.FormattingEnabled = True
        Me.comboOrganisms.Location = New System.Drawing.Point(41, 65)
        Me.comboOrganisms.Name = "comboOrganisms"
        Me.comboOrganisms.Size = New System.Drawing.Size(121, 21)
        Me.comboOrganisms.TabIndex = 2
        '
        'comboMultiply
        '
        Me.comboMultiply.FormattingEnabled = True
        Me.comboMultiply.Location = New System.Drawing.Point(41, 162)
        Me.comboMultiply.Name = "comboMultiply"
        Me.comboMultiply.Size = New System.Drawing.Size(121, 21)
        Me.comboMultiply.TabIndex = 3
        '
        'txtBoxIncrease
        '
        Me.txtBoxIncrease.Location = New System.Drawing.Point(41, 115)
        Me.txtBoxIncrease.Name = "txtBoxIncrease"
        Me.txtBoxIncrease.Size = New System.Drawing.Size(121, 20)
        Me.txtBoxIncrease.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(102, 207)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 262)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBoxIncrease)
        Me.Controls.Add(Me.comboMultiply)
        Me.Controls.Add(Me.comboOrganisms)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents comboOrganisms As System.Windows.Forms.ComboBox
    Friend WithEvents comboMultiply As System.Windows.Forms.ComboBox
    Friend WithEvents txtBoxIncrease As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
