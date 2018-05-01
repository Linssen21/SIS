<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.HomeFormPanel = New System.Windows.Forms.Panel()
        Me.DashBoardPanel = New System.Windows.Forms.Panel()
        Me.StudentInfoTile = New MetroFramework.Controls.MetroTile()
        Me.RecrodTile = New MetroFramework.Controls.MetroTile()
        Me.AdminTile = New MetroFramework.Controls.MetroTile()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HomeFormPanel.SuspendLayout()
        Me.DashBoardPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.MetroTile4.Location = New System.Drawing.Point(539, 217)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(258, 161)
        Me.MetroTile4.TabIndex = 10
        Me.MetroTile4.Text = "About Us"
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseSelectable = True
        '
        'HomeFormPanel
        '
        Me.HomeFormPanel.Controls.Add(Me.DashBoardPanel)
        Me.HomeFormPanel.Controls.Add(Me.Panel1)
        Me.HomeFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeFormPanel.Location = New System.Drawing.Point(0, 0)
        Me.HomeFormPanel.Name = "HomeFormPanel"
        Me.HomeFormPanel.Size = New System.Drawing.Size(1073, 543)
        Me.HomeFormPanel.TabIndex = 13
        '
        'DashBoardPanel
        '
        Me.DashBoardPanel.Controls.Add(Me.StudentInfoTile)
        Me.DashBoardPanel.Controls.Add(Me.MetroTile4)
        Me.DashBoardPanel.Controls.Add(Me.RecrodTile)
        Me.DashBoardPanel.Controls.Add(Me.AdminTile)
        Me.DashBoardPanel.Controls.Add(Me.MetroTile5)
        Me.DashBoardPanel.Location = New System.Drawing.Point(12, 12)
        Me.DashBoardPanel.Name = "DashBoardPanel"
        Me.DashBoardPanel.Size = New System.Drawing.Size(1049, 507)
        Me.DashBoardPanel.TabIndex = 13
        '
        'StudentInfoTile
        '
        Me.StudentInfoTile.ActiveControl = Nothing
        Me.StudentInfoTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.StudentInfoTile.Location = New System.Drawing.Point(45, 13)
        Me.StudentInfoTile.Name = "StudentInfoTile"
        Me.StudentInfoTile.Size = New System.Drawing.Size(253, 161)
        Me.StudentInfoTile.TabIndex = 7
        Me.StudentInfoTile.Text = "Student Information"
        Me.StudentInfoTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.students_cap__2_
        Me.StudentInfoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StudentInfoTile.UseCustomBackColor = True
        Me.StudentInfoTile.UseSelectable = True
        Me.StudentInfoTile.UseTileImage = True
        '
        'RecrodTile
        '
        Me.RecrodTile.ActiveControl = Nothing
        Me.RecrodTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.RecrodTile.Location = New System.Drawing.Point(366, 13)
        Me.RecrodTile.Name = "RecrodTile"
        Me.RecrodTile.Size = New System.Drawing.Size(253, 161)
        Me.RecrodTile.TabIndex = 8
        Me.RecrodTile.Text = "Records"
        Me.RecrodTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.database__1_
        Me.RecrodTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RecrodTile.UseCustomBackColor = True
        Me.RecrodTile.UseSelectable = True
        Me.RecrodTile.UseTileImage = True
        '
        'AdminTile
        '
        Me.AdminTile.ActiveControl = Nothing
        Me.AdminTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.AdminTile.Location = New System.Drawing.Point(682, 13)
        Me.AdminTile.Name = "AdminTile"
        Me.AdminTile.Size = New System.Drawing.Size(253, 161)
        Me.AdminTile.TabIndex = 12
        Me.AdminTile.Text = "Administrator"
        Me.AdminTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.icon
        Me.AdminTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AdminTile.UseCustomBackColor = True
        Me.AdminTile.UseSelectable = True
        Me.AdminTile.UseTileImage = True
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MetroTile5.Location = New System.Drawing.Point(196, 217)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(253, 161)
        Me.MetroTile5.TabIndex = 11
        Me.MetroTile5.Text = "Courses"
        Me.MetroTile5.TileImage = Global.StudentInformationSystem.My.Resources.Resources.language__1_
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile5.UseCustomBackColor = True
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(170, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 409)
        Me.Panel1.TabIndex = 14
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 543)
        Me.Controls.Add(Me.HomeFormPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HomeForm"
        Me.HomeFormPanel.ResumeLayout(False)
        Me.DashBoardPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents RecrodTile As MetroFramework.Controls.MetroTile
    Friend WithEvents StudentInfoTile As MetroFramework.Controls.MetroTile
    Friend WithEvents AdminTile As MetroFramework.Controls.MetroTile
    Friend WithEvents HomeFormPanel As System.Windows.Forms.Panel
    Friend WithEvents DashBoardPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
