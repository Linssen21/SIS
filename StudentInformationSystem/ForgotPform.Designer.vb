<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPForm
    ' Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdmCancelButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FpLoginButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.UsernameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.AnswerBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Question:"
        '
        'AdmCancelButton
        '
        Me.AdmCancelButton.Depth = 0
        Me.AdmCancelButton.Location = New System.Drawing.Point(190, 323)
        Me.AdmCancelButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AdmCancelButton.Name = "AdmCancelButton"
        Me.AdmCancelButton.Primary = True
        Me.AdmCancelButton.Size = New System.Drawing.Size(112, 33)
        Me.AdmCancelButton.TabIndex = 34
        Me.AdmCancelButton.Text = "Cancel"
        Me.AdmCancelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Username"
        '
        'FpLoginButton
        '
        Me.FpLoginButton.Depth = 0
        Me.FpLoginButton.Location = New System.Drawing.Point(51, 323)
        Me.FpLoginButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.FpLoginButton.Name = "FpLoginButton"
        Me.FpLoginButton.Primary = True
        Me.FpLoginButton.Size = New System.Drawing.Size(112, 33)
        Me.FpLoginButton.TabIndex = 30
        Me.FpLoginButton.Text = "Log In"
        Me.FpLoginButton.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider2.Location = New System.Drawing.Point(1, 417)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(402, 1)
        Me.MaterialDivider2.TabIndex = 28
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1, 418)
        Me.MaterialDivider1.TabIndex = 25
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.BackColor = System.Drawing.Color.White
        Me.QuestionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.QuestionLabel.Location = New System.Drawing.Point(37, 214)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(68, 18)
        Me.QuestionLabel.TabIndex = 40
        Me.QuestionLabel.Text = "Question"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.LowPoly
        Me.PictureBox1.Location = New System.Drawing.Point(372, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 419)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 26)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Note: You Must Answer The Question Correctly " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Log In Your Account."
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.BackColor = System.Drawing.Color.White
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(35, 143)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(109, 29)
        Me.MaterialRaisedButton1.TabIndex = 43
        Me.MaterialRaisedButton1.Text = "Search User"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialDivider3.Location = New System.Drawing.Point(403, 0)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(1, 418)
        Me.MaterialDivider3.TabIndex = 35
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'UsernameBox
        '
        Me.UsernameBox.Depth = 0
        Me.UsernameBox.Hint = ""
        Me.UsernameBox.Location = New System.Drawing.Point(36, 114)
        Me.UsernameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameBox.SelectedText = ""
        Me.UsernameBox.SelectionLength = 0
        Me.UsernameBox.SelectionStart = 0
        Me.UsernameBox.Size = New System.Drawing.Size(267, 23)
        Me.UsernameBox.TabIndex = 44
        Me.UsernameBox.UseSystemPasswordChar = False
        '
        'AnswerBox
        '
        Me.AnswerBox.Depth = 0
        Me.AnswerBox.Hint = ""
        Me.AnswerBox.Location = New System.Drawing.Point(36, 276)
        Me.AnswerBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnswerBox.SelectedText = ""
        Me.AnswerBox.SelectionLength = 0
        Me.AnswerBox.SelectionStart = 0
        Me.AnswerBox.Size = New System.Drawing.Size(267, 23)
        Me.AnswerBox.TabIndex = 45
        Me.AnswerBox.UseSystemPasswordChar = False
        '
        'ForgotPForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 418)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AdmCancelButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FpLoginButton)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdmCancelButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FpLoginButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents UsernameBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AnswerBox As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
