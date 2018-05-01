<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAdminForm))
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.AdminBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PassBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AdminSaveButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdmCancelButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AnswerBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.QuestionBox = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 27)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1, 411)
        Me.MaterialDivider1.TabIndex = 0
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'AdminBox
        '
        Me.AdminBox.BackColor = System.Drawing.SystemColors.Control
        Me.AdminBox.Depth = 0
        Me.AdminBox.Hint = ""
        Me.AdminBox.Location = New System.Drawing.Point(58, 120)
        Me.AdminBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.AdminBox.Name = "AdminBox"
        Me.AdminBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdminBox.SelectedText = ""
        Me.AdminBox.SelectionLength = 0
        Me.AdminBox.SelectionStart = 0
        Me.AdminBox.Size = New System.Drawing.Size(252, 23)
        Me.AdminBox.TabIndex = 1
        Me.AdminBox.UseSystemPasswordChar = False
        '
        'PassBox
        '
        Me.PassBox.BackColor = System.Drawing.SystemColors.Control
        Me.PassBox.Depth = 0
        Me.PassBox.Hint = ""
        Me.PassBox.Location = New System.Drawing.Point(58, 175)
        Me.PassBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PassBox.SelectedText = ""
        Me.PassBox.SelectionLength = 0
        Me.PassBox.SelectionStart = 0
        Me.PassBox.Size = New System.Drawing.Size(252, 23)
        Me.PassBox.TabIndex = 2
        Me.PassBox.UseSystemPasswordChar = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider2.Location = New System.Drawing.Point(0, 437)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(404, 1)
        Me.MaterialDivider2.TabIndex = 4
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 33)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(371, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AdminSaveButton
        '
        Me.AdminSaveButton.Depth = 0
        Me.AdminSaveButton.Location = New System.Drawing.Point(74, 383)
        Me.AdminSaveButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AdminSaveButton.Name = "AdminSaveButton"
        Me.AdminSaveButton.Primary = True
        Me.AdminSaveButton.Size = New System.Drawing.Size(112, 33)
        Me.AdminSaveButton.TabIndex = 13
        Me.AdminSaveButton.Text = "Save"
        Me.AdminSaveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(54, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 45)
        Me.Panel2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Create Admin Account"
        '
        'AdmCancelButton
        '
        Me.AdmCancelButton.Depth = 0
        Me.AdmCancelButton.Location = New System.Drawing.Point(198, 383)
        Me.AdmCancelButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AdmCancelButton.Name = "AdmCancelButton"
        Me.AdmCancelButton.Primary = True
        Me.AdmCancelButton.Size = New System.Drawing.Size(112, 33)
        Me.AdmCancelButton.TabIndex = 17
        Me.AdmCancelButton.Text = "Cancel"
        Me.AdmCancelButton.UseVisualStyleBackColor = True
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(403, 14)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(1, 424)
        Me.MaterialDivider3.TabIndex = 18
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(58, 201)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(128, 30)
        Me.MaterialCheckBox1.TabIndex = 19
        Me.MaterialCheckBox1.Text = "Show Password"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(54, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Question"
        '
        'AnswerBox
        '
        Me.AnswerBox.BackColor = System.Drawing.SystemColors.Control
        Me.AnswerBox.Depth = 0
        Me.AnswerBox.Hint = ""
        Me.AnswerBox.Location = New System.Drawing.Point(58, 328)
        Me.AnswerBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnswerBox.SelectedText = ""
        Me.AnswerBox.SelectionLength = 0
        Me.AnswerBox.SelectionStart = 0
        Me.AnswerBox.Size = New System.Drawing.Size(252, 23)
        Me.AnswerBox.TabIndex = 21
        Me.AnswerBox.UseSystemPasswordChar = False
        '
        'QuestionBox
        '
        Me.QuestionBox.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.QuestionBox.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.QuestionBox.FormattingEnabled = True
        Me.QuestionBox.ItemHeight = 19
        Me.QuestionBox.Items.AddRange(New Object() {"What is The Name of Your Dog?", "What is the name of your Favourite Aunt?", "Who Do you Love?", "Who is Your Crush?"})
        Me.QuestionBox.Location = New System.Drawing.Point(58, 265)
        Me.QuestionBox.Name = "QuestionBox"
        Me.QuestionBox.Size = New System.Drawing.Size(272, 25)
        Me.QuestionBox.TabIndex = 24
        Me.QuestionBox.UseSelectable = True
        '
        'NewAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(404, 438)
        Me.Controls.Add(Me.QuestionBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.AdmCancelButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdminSaveButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.AdminBox)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewAdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewAdminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents AdminBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PassBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdminSaveButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdmCancelButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AnswerBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents QuestionBox As MetroFramework.Controls.MetroComboBox
End Class
