<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.UsernameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PasswordBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LoginButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FP = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Depth = 0
        Me.UsernameBox.Hint = ""
        Me.UsernameBox.Location = New System.Drawing.Point(61, 193)
        Me.UsernameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameBox.SelectedText = ""
        Me.UsernameBox.SelectionLength = 0
        Me.UsernameBox.SelectionStart = 0
        Me.UsernameBox.Size = New System.Drawing.Size(272, 23)
        Me.UsernameBox.TabIndex = 0
        Me.UsernameBox.TabStop = False
        Me.UsernameBox.UseSystemPasswordChar = False
        '
        'PasswordBox
        '
        Me.PasswordBox.Depth = 0
        Me.PasswordBox.Hint = ""
        Me.PasswordBox.Location = New System.Drawing.Point(61, 265)
        Me.PasswordBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordBox.SelectedText = ""
        Me.PasswordBox.SelectionLength = 0
        Me.PasswordBox.SelectionStart = 0
        Me.PasswordBox.Size = New System.Drawing.Size(272, 23)
        Me.PasswordBox.TabIndex = 0
        Me.PasswordBox.TabStop = False
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'LoginButton
        '
        Me.LoginButton.Depth = 0
        Me.LoginButton.Location = New System.Drawing.Point(64, 353)
        Me.LoginButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Primary = True
        Me.LoginButton.Size = New System.Drawing.Size(252, 34)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.TabStop = False
        Me.LoginButton.Text = "Log In"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(64, 396)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(252, 37)
        Me.MaterialRaisedButton2.TabIndex = 0
        Me.MaterialRaisedButton2.TabStop = False
        Me.MaterialRaisedButton2.Text = "Cancel"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(64, 296)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(128, 30)
        Me.MaterialCheckBox1.TabIndex = 6
        Me.MaterialCheckBox1.Text = "Show Password"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.LowPoly
        Me.PictureBox1.Location = New System.Drawing.Point(379, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StudentInformationSystem.My.Resources.Resources.LowPoly
        Me.PictureBox2.Location = New System.Drawing.Point(0, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ADMINISTRATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(58, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(57, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password"
        '
        'FP
        '
        Me.FP.AutoSize = True
        Me.FP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FP.Location = New System.Drawing.Point(255, 465)
        Me.FP.Name = "FP"
        Me.FP.Size = New System.Drawing.Size(118, 13)
        Me.FP.TabIndex = 12
        Me.FP.Text = "FORGOT PASSWORD"
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 501)
        Me.Controls.Add(Me.FP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PasswordBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LoginButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FP As System.Windows.Forms.Label

End Class
