<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainPnl = New System.Windows.Forms.Panel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.LogOutBut = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AdminName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPnl
        '
        Me.MainPnl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPnl.Location = New System.Drawing.Point(0, 139)
        Me.MainPnl.Name = "MainPnl"
        Me.MainPnl.Size = New System.Drawing.Size(995, 501)
        Me.MainPnl.TabIndex = 1
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.AccessibleName = "Pnl"
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 62)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(995, 78)
        Me.MaterialDivider1.TabIndex = 3
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'LogOutBut
        '
        Me.LogOutBut.AutoSize = True
        Me.LogOutBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogOutBut.Depth = 0
        Me.LogOutBut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogOutBut.Location = New System.Drawing.Point(914, 83)
        Me.LogOutBut.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LogOutBut.MouseState = MaterialSkin.MouseState.HOVER
        Me.LogOutBut.Name = "LogOutBut"
        Me.LogOutBut.Primary = True
        Me.LogOutBut.Size = New System.Drawing.Size(68, 36)
        Me.LogOutBut.TabIndex = 4
        Me.LogOutBut.Text = "Log out"
        Me.LogOutBut.UseVisualStyleBackColor = True
        '
        'AdminName
        '
        Me.AdminName.AutoSize = True
        Me.AdminName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminName.ForeColor = System.Drawing.Color.White
        Me.AdminName.Location = New System.Drawing.Point(72, 86)
        Me.AdminName.Name = "AdminName"
        Me.AdminName.Size = New System.Drawing.Size(150, 37)
        Me.AdminName.TabIndex = 16
        Me.AdminName.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Currently Log in As"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.CVSU_ICON_copy
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.substract__2_
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MinimizeButton.Location = New System.Drawing.Point(924, -1)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(36, 30)
        Me.MinimizeButton.TabIndex = 2
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(961, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(995, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AdminName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogOutBut)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.MainPnl)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Infromation System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainPnl As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents LogOutBut As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AdminName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
