<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoursesFormPanel = New System.Windows.Forms.Panel()
        Me.SearchBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ClearButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DeleteTile = New MetroFramework.Controls.MetroTile()
        Me.EditStudentButton = New MetroFramework.Controls.MetroTile()
        Me.AddTile = New MetroFramework.Controls.MetroTile()
        Me.HomeTile = New MetroFramework.Controls.MetroTile()
        Me.dgvCourse = New MetroFramework.Controls.MetroGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.CoursesFormPanel.SuspendLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(437, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Courses"
        '
        'CoursesFormPanel
        '
        Me.CoursesFormPanel.Controls.Add(Me.SearchBox)
        Me.CoursesFormPanel.Controls.Add(Me.ClearButton)
        Me.CoursesFormPanel.Controls.Add(Me.DeleteTile)
        Me.CoursesFormPanel.Controls.Add(Me.EditStudentButton)
        Me.CoursesFormPanel.Controls.Add(Me.AddTile)
        Me.CoursesFormPanel.Controls.Add(Me.HomeTile)
        Me.CoursesFormPanel.Controls.Add(Me.dgvCourse)
        Me.CoursesFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoursesFormPanel.Location = New System.Drawing.Point(0, 35)
        Me.CoursesFormPanel.Name = "CoursesFormPanel"
        Me.CoursesFormPanel.Size = New System.Drawing.Size(995, 466)
        Me.CoursesFormPanel.TabIndex = 6
        '
        'SearchBox
        '
        Me.SearchBox.Depth = 0
        Me.SearchBox.Hint = "Search"
        Me.SearchBox.Location = New System.Drawing.Point(235, 22)
        Me.SearchBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.SelectionLength = 0
        Me.SearchBox.SelectionStart = 0
        Me.SearchBox.Size = New System.Drawing.Size(241, 23)
        Me.SearchBox.TabIndex = 18
        Me.SearchBox.UseSystemPasswordChar = False
        '
        'ClearButton
        '
        Me.ClearButton.AutoSize = True
        Me.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearButton.Depth = 0
        Me.ClearButton.Location = New System.Drawing.Point(480, 18)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ClearButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Primary = False
        Me.ClearButton.Size = New System.Drawing.Size(54, 36)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteTile
        '
        Me.DeleteTile.ActiveControl = Nothing
        Me.DeleteTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.DeleteTile.Location = New System.Drawing.Point(821, 208)
        Me.DeleteTile.Name = "DeleteTile"
        Me.DeleteTile.Size = New System.Drawing.Size(87, 77)
        Me.DeleteTile.TabIndex = 17
        Me.DeleteTile.Text = "Delete"
        Me.DeleteTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.delete
        Me.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteTile.UseCustomBackColor = True
        Me.DeleteTile.UseSelectable = True
        Me.DeleteTile.UseTileImage = True
        '
        'EditStudentButton
        '
        Me.EditStudentButton.ActiveControl = Nothing
        Me.EditStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.EditStudentButton.Location = New System.Drawing.Point(705, 208)
        Me.EditStudentButton.Name = "EditStudentButton"
        Me.EditStudentButton.Size = New System.Drawing.Size(87, 77)
        Me.EditStudentButton.TabIndex = 16
        Me.EditStudentButton.Text = "Edit"
        Me.EditStudentButton.TileImage = Global.StudentInformationSystem.My.Resources.Resources.pencil_tool
        Me.EditStudentButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EditStudentButton.UseCustomBackColor = True
        Me.EditStudentButton.UseSelectable = True
        Me.EditStudentButton.UseTileImage = True
        '
        'AddTile
        '
        Me.AddTile.ActiveControl = Nothing
        Me.AddTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AddTile.Location = New System.Drawing.Point(821, 91)
        Me.AddTile.Name = "AddTile"
        Me.AddTile.Size = New System.Drawing.Size(87, 77)
        Me.AddTile.TabIndex = 15
        Me.AddTile.Text = "Add "
        Me.AddTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.language__2_
        Me.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddTile.UseCustomBackColor = True
        Me.AddTile.UseSelectable = True
        Me.AddTile.UseTileImage = True
        '
        'HomeTile
        '
        Me.HomeTile.ActiveControl = Nothing
        Me.HomeTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.HomeTile.Location = New System.Drawing.Point(705, 91)
        Me.HomeTile.Name = "HomeTile"
        Me.HomeTile.Size = New System.Drawing.Size(87, 77)
        Me.HomeTile.TabIndex = 14
        Me.HomeTile.Text = "Home"
        Me.HomeTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.home
        Me.HomeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HomeTile.UseCustomBackColor = True
        Me.HomeTile.UseSelectable = True
        Me.HomeTile.UseTileImage = True
        '
        'dgvCourse
        '
        Me.dgvCourse.AllowUserToResizeRows = False
        Me.dgvCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCourse.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCourse.EnableHeadersVisualStyles = False
        Me.dgvCourse.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCourse.Location = New System.Drawing.Point(68, 91)
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCourse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourse.Size = New System.Drawing.Size(606, 325)
        Me.dgvCourse.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(273, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 438)
        Me.Panel2.TabIndex = 7
        '
        'CourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 501)
        Me.Controls.Add(Me.CoursesFormPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CourseForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CoursesFormPanel.ResumeLayout(False)
        Me.CoursesFormPanel.PerformLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CoursesFormPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvCourse As MetroFramework.Controls.MetroGrid
    Friend WithEvents DeleteTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EditStudentButton As MetroFramework.Controls.MetroTile
    Friend WithEvents AddTile As MetroFramework.Controls.MetroTile
    Friend WithEvents HomeTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SearchBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ClearButton As MaterialSkin.Controls.MaterialFlatButton
End Class
