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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.psComboBox = New System.Windows.Forms.ComboBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.enComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.widRadioButton = New System.Windows.Forms.RadioButton()
        Me.marriedRadioButton = New System.Windows.Forms.RadioButton()
        Me.singleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.npTextBox = New System.Windows.Forms.TextBox()
        Me.dayNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.sssTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.payTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dayNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.psComboBox)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.enComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.widRadioButton)
        Me.GroupBox1.Controls.Add(Me.marriedRadioButton)
        Me.GroupBox1.Controls.Add(Me.singleRadioButton)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Data Records Here"
        '
        'psComboBox
        '
        Me.psComboBox.FormattingEnabled = True
        Me.psComboBox.Items.AddRange(New Object() {"A", "B", "C"})
        Me.psComboBox.Location = New System.Drawing.Point(174, 82)
        Me.psComboBox.Name = "psComboBox"
        Me.psComboBox.Size = New System.Drawing.Size(148, 21)
        Me.psComboBox.TabIndex = 9
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(174, 48)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.nameTextBox.TabIndex = 8
        '
        'enComboBox
        '
        Me.enComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.enComboBox.FormattingEnabled = True
        Me.enComboBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.enComboBox.Location = New System.Drawing.Point(174, 17)
        Me.enComboBox.Name = "enComboBox"
        Me.enComboBox.Size = New System.Drawing.Size(148, 21)
        Me.enComboBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Civil Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Position Code"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(6, 55)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(99, 19)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee Number"
        '
        'widRadioButton
        '
        Me.widRadioButton.AutoSize = True
        Me.widRadioButton.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widRadioButton.ForeColor = System.Drawing.Color.Black
        Me.widRadioButton.Location = New System.Drawing.Point(217, 171)
        Me.widRadioButton.Name = "widRadioButton"
        Me.widRadioButton.Size = New System.Drawing.Size(77, 23)
        Me.widRadioButton.TabIndex = 2
        Me.widRadioButton.TabStop = True
        Me.widRadioButton.Text = "Widowed"
        Me.widRadioButton.UseVisualStyleBackColor = True
        '
        'marriedRadioButton
        '
        Me.marriedRadioButton.AutoSize = True
        Me.marriedRadioButton.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marriedRadioButton.ForeColor = System.Drawing.Color.Black
        Me.marriedRadioButton.Location = New System.Drawing.Point(111, 171)
        Me.marriedRadioButton.Name = "marriedRadioButton"
        Me.marriedRadioButton.Size = New System.Drawing.Size(71, 23)
        Me.marriedRadioButton.TabIndex = 1
        Me.marriedRadioButton.TabStop = True
        Me.marriedRadioButton.Text = "Married"
        Me.marriedRadioButton.UseVisualStyleBackColor = True
        '
        'singleRadioButton
        '
        Me.singleRadioButton.AutoSize = True
        Me.singleRadioButton.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.singleRadioButton.ForeColor = System.Drawing.Color.Black
        Me.singleRadioButton.Location = New System.Drawing.Point(6, 171)
        Me.singleRadioButton.Name = "singleRadioButton"
        Me.singleRadioButton.Size = New System.Drawing.Size(59, 23)
        Me.singleRadioButton.TabIndex = 0
        Me.singleRadioButton.TabStop = True
        Me.singleRadioButton.Text = "Single"
        Me.singleRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.npTextBox)
        Me.GroupBox2.Controls.Add(Me.dayNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.taxTextBox)
        Me.GroupBox2.Controls.Add(Me.sssTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.payTextBox)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(346, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 194)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Computations"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Net Pay"
        '
        'npTextBox
        '
        Me.npTextBox.Enabled = False
        Me.npTextBox.Location = New System.Drawing.Point(179, 153)
        Me.npTextBox.Name = "npTextBox"
        Me.npTextBox.Size = New System.Drawing.Size(148, 20)
        Me.npTextBox.TabIndex = 18
        '
        'dayNumericUpDown
        '
        Me.dayNumericUpDown.Location = New System.Drawing.Point(179, 18)
        Me.dayNumericUpDown.Name = "dayNumericUpDown"
        Me.dayNumericUpDown.Size = New System.Drawing.Size(77, 20)
        Me.dayNumericUpDown.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "No. Of Days Worked"
        '
        'taxTextBox
        '
        Me.taxTextBox.Enabled = False
        Me.taxTextBox.Location = New System.Drawing.Point(179, 118)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.Size = New System.Drawing.Size(148, 20)
        Me.taxTextBox.TabIndex = 15
        '
        'sssTextBox
        '
        Me.sssTextBox.Enabled = False
        Me.sssTextBox.Location = New System.Drawing.Point(179, 87)
        Me.sssTextBox.Name = "sssTextBox"
        Me.sssTextBox.Size = New System.Drawing.Size(148, 20)
        Me.sssTextBox.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "WithHolding Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "SSS Contribution"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Basic Pay"
        '
        'payTextBox
        '
        Me.payTextBox.Enabled = False
        Me.payTextBox.Location = New System.Drawing.Point(179, 52)
        Me.payTextBox.Name = "payTextBox"
        Me.payTextBox.Size = New System.Drawing.Size(148, 20)
        Me.payTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Curlz MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 47)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("Curlz MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(117, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 47)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "COMPUTE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Curlz MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(260, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 47)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(685, 280)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Quiz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dayNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents psComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents widRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents marriedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents singleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents npTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dayNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sssTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents payTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
