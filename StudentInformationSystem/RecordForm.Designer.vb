<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStudent = New MetroFramework.Controls.MetroGrid()
        Me.RecordTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CourseComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.PrintStuddentButton = New MetroFramework.Controls.MetroTile()
        Me.HomeTile = New MetroFramework.Controls.MetroTile()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvAdmin = New MetroFramework.Controls.MetroGrid()
        Me.Adminlabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeTile1 = New MetroFramework.Controls.MetroTile()
        Me.dgvCourse = New MetroFramework.Controls.MetroGrid()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(451, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Record"
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
        Me.dgvStudent.Location = New System.Drawing.Point(22, 26)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudent.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudent.Size = New System.Drawing.Size(596, 363)
        Me.dgvStudent.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvStudent.TabIndex = 6
        Me.dgvStudent.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvStudent.UseStyleColors = True
        '
        'RecordTabControl
        '
        Me.RecordTabControl.Controls.Add(Me.TabPage1)
        Me.RecordTabControl.Controls.Add(Me.TabPage2)
        Me.RecordTabControl.Depth = 0
        Me.RecordTabControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RecordTabControl.Location = New System.Drawing.Point(0, 58)
        Me.RecordTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RecordTabControl.Name = "RecordTabControl"
        Me.RecordTabControl.SelectedIndex = 0
        Me.RecordTabControl.Size = New System.Drawing.Size(995, 443)
        Me.RecordTabControl.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ResButton)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CourseComboBox)
        Me.TabPage1.Controls.Add(Me.PrintStuddentButton)
        Me.TabPage1.Controls.Add(Me.HomeTile)
        Me.TabPage1.Controls.Add(Me.dgvStudent)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Page"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(638, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Note: You can Print a Student Report by Course or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Just Clear the ComboBox to pr" & _
    "int All Students."
        '
        'ResButton
        '
        Me.ResButton.Depth = 0
        Me.ResButton.Location = New System.Drawing.Point(641, 135)
        Me.ResButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ResButton.Name = "ResButton"
        Me.ResButton.Primary = True
        Me.ResButton.Size = New System.Drawing.Size(142, 40)
        Me.ResButton.TabIndex = 12
        Me.ResButton.Text = "RESET"
        Me.ResButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(637, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Filter By Course"
        '
        'CourseComboBox
        '
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.ItemHeight = 23
        Me.CourseComboBox.Items.AddRange(New Object() {"All Courses"})
        Me.CourseComboBox.Location = New System.Drawing.Point(639, 100)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(340, 29)
        Me.CourseComboBox.TabIndex = 9
        Me.CourseComboBox.UseSelectable = True
        '
        'PrintStuddentButton
        '
        Me.PrintStuddentButton.ActiveControl = Nothing
        Me.PrintStuddentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PrintStuddentButton.Location = New System.Drawing.Point(811, 234)
        Me.PrintStuddentButton.Name = "PrintStuddentButton"
        Me.PrintStuddentButton.Size = New System.Drawing.Size(87, 77)
        Me.PrintStuddentButton.TabIndex = 8
        Me.PrintStuddentButton.Text = "Print"
        Me.PrintStuddentButton.TileImage = Global.StudentInformationSystem.My.Resources.Resources.print
        Me.PrintStuddentButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PrintStuddentButton.UseCustomBackColor = True
        Me.PrintStuddentButton.UseSelectable = True
        Me.PrintStuddentButton.UseTileImage = True
        '
        'HomeTile
        '
        Me.HomeTile.ActiveControl = Nothing
        Me.HomeTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.HomeTile.Location = New System.Drawing.Point(702, 234)
        Me.HomeTile.Name = "HomeTile"
        Me.HomeTile.Size = New System.Drawing.Size(87, 77)
        Me.HomeTile.TabIndex = 7
        Me.HomeTile.Text = "Home"
        Me.HomeTile.TileImage = Global.StudentInformationSystem.My.Resources.Resources.home
        Me.HomeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HomeTile.UseCustomBackColor = True
        Me.HomeTile.UseSelectable = True
        Me.HomeTile.UseTileImage = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.dgvAdmin)
        Me.TabPage2.Controls.Add(Me.Adminlabel)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.HomeTile1)
        Me.TabPage2.Controls.Add(Me.dgvCourse)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Courses and Admin"
        '
        'dgvAdmin
        '
        Me.dgvAdmin.AllowUserToResizeRows = False
        Me.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdmin.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAdmin.EnableHeadersVisualStyles = False
        Me.dgvAdmin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvAdmin.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdmin.HighLightPercentage = 1.0!
        Me.dgvAdmin.Location = New System.Drawing.Point(477, 53)
        Me.dgvAdmin.Name = "dgvAdmin"
        Me.dgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdmin.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdmin.Size = New System.Drawing.Size(402, 215)
        Me.dgvAdmin.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvAdmin.TabIndex = 12
        Me.dgvAdmin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvAdmin.UseStyleColors = True
        '
        'Adminlabel
        '
        Me.Adminlabel.AutoSize = True
        Me.Adminlabel.BackColor = System.Drawing.SystemColors.Control
        Me.Adminlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adminlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Adminlabel.Location = New System.Drawing.Point(614, 309)
        Me.Adminlabel.Name = "Adminlabel"
        Me.Adminlabel.Size = New System.Drawing.Size(65, 24)
        Me.Adminlabel.TabIndex = 11
        Me.Adminlabel.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(173, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Course"
        '
        'HomeTile1
        '
        Me.HomeTile1.ActiveControl = Nothing
        Me.HomeTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.HomeTile1.Location = New System.Drawing.Point(892, 323)
        Me.HomeTile1.Name = "HomeTile1"
        Me.HomeTile1.Size = New System.Drawing.Size(87, 77)
        Me.HomeTile1.TabIndex = 8
        Me.HomeTile1.Text = "Home"
        Me.HomeTile1.TileImage = Global.StudentInformationSystem.My.Resources.Resources.home
        Me.HomeTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HomeTile1.UseCustomBackColor = True
        Me.HomeTile1.UseSelectable = True
        Me.HomeTile1.UseTileImage = True
        '
        'dgvCourse
        '
        Me.dgvCourse.AllowUserToResizeRows = False
        Me.dgvCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCourse.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCourse.EnableHeadersVisualStyles = False
        Me.dgvCourse.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCourse.HighLightPercentage = 1.0!
        Me.dgvCourse.Location = New System.Drawing.Point(25, 53)
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCourse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourse.Size = New System.Drawing.Size(402, 215)
        Me.dgvCourse.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvCourse.TabIndex = 7
        Me.dgvCourse.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvCourse.UseStyleColors = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RecordTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(995, 52)
        Me.MaterialTabSelector1.TabIndex = 8
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 501)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RecordTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RecordForm"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStudent As MetroFramework.Controls.MetroGrid
    Friend WithEvents RecordTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents HomeTile As MetroFramework.Controls.MetroTile
    Friend WithEvents PrintStuddentButton As MetroFramework.Controls.MetroTile
    Friend WithEvents Adminlabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HomeTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents dgvCourse As MetroFramework.Controls.MetroGrid
    Friend WithEvents dgvAdmin As MetroFramework.Controls.MetroGrid
    Friend WithEvents CourseComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ResButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
