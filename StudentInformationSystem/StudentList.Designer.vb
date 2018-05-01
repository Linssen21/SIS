<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentInformationPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DeleteTile = New MetroFramework.Controls.MetroTile()
        Me.ClearButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SearchBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgvStudent = New MetroFramework.Controls.MetroGrid()
        Me.HomeTile = New MetroFramework.Controls.MetroTile()
        Me.EditStudentButton = New MetroFramework.Controls.MetroTile()
        Me.PrintStuddentButton = New MetroFramework.Controls.MetroTile()
        Me.AddTile = New MetroFramework.Controls.MetroTile()
        Me.Panel1.SuspendLayout()
        Me.StudentInformationPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(384, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Information"
        '
        'StudentInformationPanel
        '
        Me.StudentInformationPanel.Controls.Add(Me.Panel2)
        Me.StudentInformationPanel.Controls.Add(Me.Panel1)
        Me.StudentInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentInformationPanel.Location = New System.Drawing.Point(0, 0)
        Me.StudentInformationPanel.Name = "StudentInformationPanel"
        Me.StudentInformationPanel.Size = New System.Drawing.Size(995, 501)
        Me.StudentInformationPanel.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DeleteTile)
        Me.Panel2.Controls.Add(Me.ClearButton)
        Me.Panel2.Controls.Add(Me.SearchBox)
        Me.Panel2.Controls.Add(Me.dgvStudent)
        Me.Panel2.Controls.Add(Me.HomeTile)
        Me.Panel2.Controls.Add(Me.EditStudentButton)
        Me.Panel2.Controls.Add(Me.PrintStuddentButton)
        Me.Panel2.Controls.Add(Me.AddTile)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 466)
        Me.Panel2.TabIndex = 5
        '
        'DeleteTile
        '
        Me.DeleteTile.ActiveControl = Nothing
        Me.DeleteTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DeleteTile.Location = New System.Drawing.Point(851, 180)
        Me.DeleteTile.Name = "DeleteTile"
        Me.DeleteTile.Size = New System.Drawing.Size(87, 77)
        Me.DeleteTile.TabIndex = 8
        Me.DeleteTile.Text = "Delete"
        Me.DeleteTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.delete
        Me.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteTile.UseCustomBackColor = True
        Me.DeleteTile.UseSelectable = True
        Me.DeleteTile.UseTileImage = True
        '
        'ClearButton
        '
        Me.ClearButton.AutoSize = True
        Me.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearButton.Depth = 0
        Me.ClearButton.Image = Global.StudentInformationSystem.My.Resources.Resources.close__4_
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearButton.Location = New System.Drawing.Point(481, 16)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ClearButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Primary = True
        Me.ClearButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ClearButton.Size = New System.Drawing.Size(54, 36)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Depth = 0
        Me.SearchBox.Hint = "Search"
        Me.SearchBox.Location = New System.Drawing.Point(233, 21)
        Me.SearchBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.SelectionLength = 0
        Me.SearchBox.SelectionStart = 0
        Me.SearchBox.Size = New System.Drawing.Size(241, 23)
        Me.SearchBox.TabIndex = 6
        Me.SearchBox.UseSystemPasswordChar = False
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToResizeRows = False
        Me.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudent.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudent.EnableHeadersVisualStyles = False
        Me.dgvStudent.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvStudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.HighLightPercentage = 1.0!
        Me.dgvStudent.Location = New System.Drawing.Point(52, 66)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudent.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudent.RowTemplate.Height = 30
        Me.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudent.Size = New System.Drawing.Size(645, 352)
        Me.dgvStudent.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvStudent.TabIndex = 5
        Me.dgvStudent.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvStudent.UseStyleColors = True
        '
        'HomeTile
        '
        Me.HomeTile.ActiveControl = Nothing
        Me.HomeTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.HomeTile.Location = New System.Drawing.Point(743, 66)
        Me.HomeTile.Name = "HomeTile"
        Me.HomeTile.Size = New System.Drawing.Size(87, 77)
        Me.HomeTile.TabIndex = 1
        Me.HomeTile.Text = "Home"
        Me.HomeTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.home
        Me.HomeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HomeTile.UseCustomBackColor = True
        Me.HomeTile.UseSelectable = True
        Me.HomeTile.UseTileImage = True
        '
        'EditStudentButton
        '
        Me.EditStudentButton.ActiveControl = Nothing
        Me.EditStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.EditStudentButton.Location = New System.Drawing.Point(743, 180)
        Me.EditStudentButton.Name = "EditStudentButton"
        Me.EditStudentButton.Size = New System.Drawing.Size(87, 77)
        Me.EditStudentButton.TabIndex = 3
        Me.EditStudentButton.Text = "Edit"
        Me.EditStudentButton.TileImage = Global.StudentInformationSystem.My.Resources.Resources.pencil_tool
        Me.EditStudentButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EditStudentButton.UseCustomBackColor = True
        Me.EditStudentButton.UseSelectable = True
        Me.EditStudentButton.UseTileImage = True
        '
        'PrintStuddentButton
        '
        Me.PrintStuddentButton.ActiveControl = Nothing
        Me.PrintStuddentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PrintStuddentButton.Location = New System.Drawing.Point(743, 288)
        Me.PrintStuddentButton.Name = "PrintStuddentButton"
        Me.PrintStuddentButton.Size = New System.Drawing.Size(87, 77)
        Me.PrintStuddentButton.TabIndex = 4
        Me.PrintStuddentButton.Text = "Print"
        Me.PrintStuddentButton.TileImage = Global.StudentInformationSystem.My.Resources.Resources.print
        Me.PrintStuddentButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PrintStuddentButton.UseCustomBackColor = True
        Me.PrintStuddentButton.UseSelectable = True
        Me.PrintStuddentButton.UseTileImage = True
        '
        'AddTile
        '
        Me.AddTile.ActiveControl = Nothing
        Me.AddTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AddTile.Location = New System.Drawing.Point(851, 66)
        Me.AddTile.Name = "AddTile"
        Me.AddTile.Size = New System.Drawing.Size(87, 77)
        Me.AddTile.TabIndex = 2
        Me.AddTile.Text = "Add "
        Me.AddTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.male_university_graduate_silhouette_with_the_cap
        Me.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddTile.UseCustomBackColor = True
        Me.AddTile.UseSelectable = True
        Me.AddTile.UseTileImage = True
        '
        'StudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 501)
        Me.Controls.Add(Me.StudentInformationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StudentList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StudentInformationPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HomeTile As MetroFramework.Controls.MetroTile
    Friend WithEvents AddTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EditStudentButton As MetroFramework.Controls.MetroTile
    Friend WithEvents PrintStuddentButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StudentInformationPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SearchBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgvStudent As MetroFramework.Controls.MetroGrid
    Friend WithEvents ClearButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DeleteTile As MetroFramework.Controls.MetroTile
End Class
