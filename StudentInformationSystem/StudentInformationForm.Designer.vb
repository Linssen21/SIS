<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInformationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInformationForm))
        Me.TabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Uploadbutton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.MaterialDivider10 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.EmailBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UContactBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.HomeAddBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.CityAddBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CivilStatsComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.CitizenBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ReligionBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.BirthPlaceBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.BDayTimePick = New MetroFramework.Controls.MetroDateTime()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.IDBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.LNameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MNameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FNameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaterialDivider12 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider11 = New MaterialSkin.Controls.MaterialDivider()
        Me.CancelBut = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SaveButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider9 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CourseComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.YearBox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.YearBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.YearBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SecondaryBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ElementaryBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider8 = New MaterialSkin.Controls.MaterialDivider()
        Me.PrimaryBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MContactBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MOccupationBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider7 = New MaterialSkin.Controls.MaterialDivider()
        Me.MotherBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FContactBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FOccupationBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider6 = New MaterialSkin.Controls.MaterialDivider()
        Me.FatherBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabSelector
        '
        Me.TabSelector.BaseTabControl = Me.MaterialTabControl1
        Me.TabSelector.Depth = 0
        Me.TabSelector.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabSelector.Location = New System.Drawing.Point(0, 0)
        Me.TabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabSelector.Name = "TabSelector"
        Me.TabSelector.Size = New System.Drawing.Size(1073, 46)
        Me.TabSelector.TabIndex = 21
        Me.TabSelector.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 46)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1073, 497)
        Me.MaterialTabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Uploadbutton)
        Me.TabPage1.Controls.Add(Me.picStudent)
        Me.TabPage1.Controls.Add(Me.MaterialDivider10)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.MaterialDivider5)
        Me.TabPage1.Controls.Add(Me.EmailBox)
        Me.TabPage1.Controls.Add(Me.UContactBox)
        Me.TabPage1.Controls.Add(Me.HomeAddBox)
        Me.TabPage1.Controls.Add(Me.CityAddBox)
        Me.TabPage1.Controls.Add(Me.MaterialDivider4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CivilStatsComboBox)
        Me.TabPage1.Controls.Add(Me.CitizenBox)
        Me.TabPage1.Controls.Add(Me.ReligionBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GenderComboBox)
        Me.TabPage1.Controls.Add(Me.MaterialDivider3)
        Me.TabPage1.Controls.Add(Me.BirthPlaceBox)
        Me.TabPage1.Controls.Add(Me.BDayTimePick)
        Me.TabPage1.Controls.Add(Me.MaterialDivider2)
        Me.TabPage1.Controls.Add(Me.IDBox)
        Me.TabPage1.Controls.Add(Me.MaterialDivider1)
        Me.TabPage1.Controls.Add(Me.LNameBox)
        Me.TabPage1.Controls.Add(Me.MNameBox)
        Me.TabPage1.Controls.Add(Me.FNameBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1065, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Information"
        '
        'Uploadbutton
        '
        Me.Uploadbutton.AutoSize = True
        Me.Uploadbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Uploadbutton.Depth = 0
        Me.Uploadbutton.Location = New System.Drawing.Point(59, 146)
        Me.Uploadbutton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Uploadbutton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Uploadbutton.Name = "Uploadbutton"
        Me.Uploadbutton.Primary = False
        Me.Uploadbutton.Size = New System.Drawing.Size(65, 36)
        Me.Uploadbutton.TabIndex = 15
        Me.Uploadbutton.Text = "Upload"
        Me.Uploadbutton.UseVisualStyleBackColor = True
        '
        'picStudent
        '
        Me.picStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picStudent.Image = Global.StudentInformationSystem.My.Resources.Resources.photo
        Me.picStudent.Location = New System.Drawing.Point(21, 18)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(136, 120)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudent.TabIndex = 25
        Me.picStudent.TabStop = False
        '
        'MaterialDivider10
        '
        Me.MaterialDivider10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider10.Depth = 0
        Me.MaterialDivider10.Location = New System.Drawing.Point(571, 33)
        Me.MaterialDivider10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider10.Name = "MaterialDivider10"
        Me.MaterialDivider10.Size = New System.Drawing.Size(1, 368)
        Me.MaterialDivider10.TabIndex = 24
        Me.MaterialDivider10.Text = "MaterialDivider10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(84, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Birth Date"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(590, 236)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(3, 178)
        Me.MaterialDivider5.TabIndex = 20
        Me.MaterialDivider5.Text = "MaterialDivider5"
        '
        'EmailBox
        '
        Me.EmailBox.Depth = 0
        Me.EmailBox.Hint = "E-Mail Add"
        Me.EmailBox.Location = New System.Drawing.Point(610, 392)
        Me.EmailBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailBox.SelectedText = ""
        Me.EmailBox.SelectionLength = 0
        Me.EmailBox.SelectionStart = 0
        Me.EmailBox.Size = New System.Drawing.Size(290, 23)
        Me.EmailBox.TabIndex = 14
        Me.EmailBox.UseSystemPasswordChar = False
        '
        'UContactBox
        '
        Me.UContactBox.Depth = 0
        Me.UContactBox.Hint = "Contact Number"
        Me.UContactBox.Location = New System.Drawing.Point(610, 342)
        Me.UContactBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UContactBox.Name = "UContactBox"
        Me.UContactBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UContactBox.SelectedText = ""
        Me.UContactBox.SelectionLength = 0
        Me.UContactBox.SelectionStart = 0
        Me.UContactBox.Size = New System.Drawing.Size(290, 23)
        Me.UContactBox.TabIndex = 13
        Me.UContactBox.UseSystemPasswordChar = False
        '
        'HomeAddBox
        '
        Me.HomeAddBox.Depth = 0
        Me.HomeAddBox.Hint = "Home Address"
        Me.HomeAddBox.Location = New System.Drawing.Point(610, 293)
        Me.HomeAddBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.HomeAddBox.Name = "HomeAddBox"
        Me.HomeAddBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HomeAddBox.SelectedText = ""
        Me.HomeAddBox.SelectionLength = 0
        Me.HomeAddBox.SelectionStart = 0
        Me.HomeAddBox.Size = New System.Drawing.Size(290, 23)
        Me.HomeAddBox.TabIndex = 12
        Me.HomeAddBox.UseSystemPasswordChar = False
        '
        'CityAddBox
        '
        Me.CityAddBox.Depth = 0
        Me.CityAddBox.Hint = "City Address"
        Me.CityAddBox.Location = New System.Drawing.Point(610, 244)
        Me.CityAddBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.CityAddBox.Name = "CityAddBox"
        Me.CityAddBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CityAddBox.SelectedText = ""
        Me.CityAddBox.SelectionLength = 0
        Me.CityAddBox.SelectionStart = 0
        Me.CityAddBox.Size = New System.Drawing.Size(290, 23)
        Me.CityAddBox.TabIndex = 11
        Me.CityAddBox.UseSystemPasswordChar = False
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(590, 44)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(3, 164)
        Me.MaterialDivider4.TabIndex = 15
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(607, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cvil Status"
        '
        'CivilStatsComboBox
        '
        Me.CivilStatsComboBox.DisplayFocus = True
        Me.CivilStatsComboBox.FormattingEnabled = True
        Me.CivilStatsComboBox.ItemHeight = 23
        Me.CivilStatsComboBox.Items.AddRange(New Object() {"Single", "Married", "Widowed", "its Complicated"})
        Me.CivilStatsComboBox.Location = New System.Drawing.Point(693, 178)
        Me.CivilStatsComboBox.Name = "CivilStatsComboBox"
        Me.CivilStatsComboBox.Size = New System.Drawing.Size(121, 29)
        Me.CivilStatsComboBox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CivilStatsComboBox.TabIndex = 10
        Me.CivilStatsComboBox.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CivilStatsComboBox.UseSelectable = True
        Me.CivilStatsComboBox.UseStyleColors = True
        '
        'CitizenBox
        '
        Me.CitizenBox.Depth = 0
        Me.CitizenBox.Hint = "Citizenship"
        Me.CitizenBox.Location = New System.Drawing.Point(610, 128)
        Me.CitizenBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.CitizenBox.Name = "CitizenBox"
        Me.CitizenBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CitizenBox.SelectedText = ""
        Me.CitizenBox.SelectionLength = 0
        Me.CitizenBox.SelectionStart = 0
        Me.CitizenBox.Size = New System.Drawing.Size(290, 23)
        Me.CitizenBox.TabIndex = 9
        Me.CitizenBox.UseSystemPasswordChar = False
        '
        'ReligionBox
        '
        Me.ReligionBox.Depth = 0
        Me.ReligionBox.Hint = "Religion"
        Me.ReligionBox.Location = New System.Drawing.Point(610, 82)
        Me.ReligionBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReligionBox.Name = "ReligionBox"
        Me.ReligionBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ReligionBox.SelectedText = ""
        Me.ReligionBox.SelectionLength = 0
        Me.ReligionBox.SelectionStart = 0
        Me.ReligionBox.Size = New System.Drawing.Size(290, 23)
        Me.ReligionBox.TabIndex = 8
        Me.ReligionBox.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(607, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Gender"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DisplayFocus = True
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.ItemHeight = 23
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(670, 36)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 29)
        Me.GenderComboBox.Style = MetroFramework.MetroColorStyle.Blue
        Me.GenderComboBox.TabIndex = 7
        Me.GenderComboBox.Theme = MetroFramework.MetroThemeStyle.Light
        Me.GenderComboBox.UseSelectable = True
        Me.GenderComboBox.UseStyleColors = True
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(74, 327)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(3, 87)
        Me.MaterialDivider3.TabIndex = 8
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'BirthPlaceBox
        '
        Me.BirthPlaceBox.Depth = 0
        Me.BirthPlaceBox.Hint = "Birth Place"
        Me.BirthPlaceBox.Location = New System.Drawing.Point(86, 388)
        Me.BirthPlaceBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.BirthPlaceBox.Name = "BirthPlaceBox"
        Me.BirthPlaceBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BirthPlaceBox.SelectedText = ""
        Me.BirthPlaceBox.SelectionLength = 0
        Me.BirthPlaceBox.SelectionStart = 0
        Me.BirthPlaceBox.Size = New System.Drawing.Size(370, 23)
        Me.BirthPlaceBox.TabIndex = 6
        Me.BirthPlaceBox.UseSystemPasswordChar = False
        '
        'BDayTimePick
        '
        Me.BDayTimePick.AllowDrop = True
        Me.BDayTimePick.Location = New System.Drawing.Point(175, 338)
        Me.BDayTimePick.MinimumSize = New System.Drawing.Size(0, 29)
        Me.BDayTimePick.Name = "BDayTimePick"
        Me.BDayTimePick.Size = New System.Drawing.Size(200, 29)
        Me.BDayTimePick.TabIndex = 5
        Me.BDayTimePick.Value = New Date(2017, 10, 16, 0, 0, 0, 0)
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(184, 34)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(3, 62)
        Me.MaterialDivider2.TabIndex = 5
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'IDBox
        '
        Me.IDBox.Depth = 0
        Me.IDBox.Hint = "Student ID"
        Me.IDBox.Location = New System.Drawing.Point(198, 56)
        Me.IDBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.IDBox.Name = "IDBox"
        Me.IDBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDBox.SelectedText = ""
        Me.IDBox.SelectionLength = 0
        Me.IDBox.SelectionStart = 0
        Me.IDBox.Size = New System.Drawing.Size(151, 23)
        Me.IDBox.TabIndex = 1
        Me.IDBox.UseSystemPasswordChar = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(74, 207)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(3, 100)
        Me.MaterialDivider1.TabIndex = 3
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'LNameBox
        '
        Me.LNameBox.Depth = 0
        Me.LNameBox.Hint = "Last Name"
        Me.LNameBox.Location = New System.Drawing.Point(87, 288)
        Me.LNameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.LNameBox.Name = "LNameBox"
        Me.LNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LNameBox.SelectedText = ""
        Me.LNameBox.SelectionLength = 0
        Me.LNameBox.SelectionStart = 0
        Me.LNameBox.Size = New System.Drawing.Size(342, 23)
        Me.LNameBox.TabIndex = 4
        Me.LNameBox.TabStop = False
        Me.LNameBox.UseSystemPasswordChar = False
        '
        'MNameBox
        '
        Me.MNameBox.Depth = 0
        Me.MNameBox.Hint = "Middle Name"
        Me.MNameBox.Location = New System.Drawing.Point(87, 245)
        Me.MNameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.MNameBox.Name = "MNameBox"
        Me.MNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MNameBox.SelectedText = ""
        Me.MNameBox.SelectionLength = 0
        Me.MNameBox.SelectionStart = 0
        Me.MNameBox.Size = New System.Drawing.Size(332, 23)
        Me.MNameBox.TabIndex = 3
        Me.MNameBox.TabStop = False
        Me.MNameBox.UseSystemPasswordChar = False
        '
        'FNameBox
        '
        Me.FNameBox.Depth = 0
        Me.FNameBox.Hint = "First Name"
        Me.FNameBox.Location = New System.Drawing.Point(86, 201)
        Me.FNameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.FNameBox.Name = "FNameBox"
        Me.FNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FNameBox.SelectedText = ""
        Me.FNameBox.SelectionLength = 0
        Me.FNameBox.SelectionStart = 0
        Me.FNameBox.Size = New System.Drawing.Size(333, 23)
        Me.FNameBox.TabIndex = 2
        Me.FNameBox.TabStop = False
        Me.FNameBox.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.MaterialDivider12)
        Me.TabPage2.Controls.Add(Me.MaterialDivider11)
        Me.TabPage2.Controls.Add(Me.CancelBut)
        Me.TabPage2.Controls.Add(Me.SaveButton)
        Me.TabPage2.Controls.Add(Me.MaterialDivider9)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.CourseComboBox)
        Me.TabPage2.Controls.Add(Me.YearBox3)
        Me.TabPage2.Controls.Add(Me.YearBox2)
        Me.TabPage2.Controls.Add(Me.YearBox1)
        Me.TabPage2.Controls.Add(Me.SecondaryBox)
        Me.TabPage2.Controls.Add(Me.ElementaryBox)
        Me.TabPage2.Controls.Add(Me.MaterialDivider8)
        Me.TabPage2.Controls.Add(Me.PrimaryBox)
        Me.TabPage2.Controls.Add(Me.MContactBox)
        Me.TabPage2.Controls.Add(Me.MOccupationBox)
        Me.TabPage2.Controls.Add(Me.MaterialDivider7)
        Me.TabPage2.Controls.Add(Me.MotherBox)
        Me.TabPage2.Controls.Add(Me.FContactBox)
        Me.TabPage2.Controls.Add(Me.FOccupationBox)
        Me.TabPage2.Controls.Add(Me.MaterialDivider6)
        Me.TabPage2.Controls.Add(Me.FatherBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1065, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Educational & Family Background"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(727, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 30)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Note: Save Button is Disabled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           if a Field was Skipped."
        '
        'MaterialDivider12
        '
        Me.MaterialDivider12.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider12.Depth = 0
        Me.MaterialDivider12.Location = New System.Drawing.Point(704, 355)
        Me.MaterialDivider12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider12.Name = "MaterialDivider12"
        Me.MaterialDivider12.Size = New System.Drawing.Size(5, 44)
        Me.MaterialDivider12.TabIndex = 28
        Me.MaterialDivider12.Text = "MaterialDivider12"
        '
        'MaterialDivider11
        '
        Me.MaterialDivider11.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider11.Depth = 0
        Me.MaterialDivider11.Location = New System.Drawing.Point(387, 6)
        Me.MaterialDivider11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider11.Name = "MaterialDivider11"
        Me.MaterialDivider11.Size = New System.Drawing.Size(1, 368)
        Me.MaterialDivider11.TabIndex = 26
        Me.MaterialDivider11.Text = "MaterialDivider11"
        '
        'CancelBut
        '
        Me.CancelBut.AutoSize = True
        Me.CancelBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelBut.Depth = 0
        Me.CancelBut.Location = New System.Drawing.Point(551, 363)
        Me.CancelBut.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CancelBut.MouseState = MaterialSkin.MouseState.HOVER
        Me.CancelBut.Name = "CancelBut"
        Me.CancelBut.Primary = False
        Me.CancelBut.Size = New System.Drawing.Size(64, 36)
        Me.CancelBut.TabIndex = 25
        Me.CancelBut.Text = "Cancel"
        Me.CancelBut.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Depth = 0
        Me.SaveButton.Location = New System.Drawing.Point(432, 363)
        Me.SaveButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Primary = True
        Me.SaveButton.Size = New System.Drawing.Size(97, 36)
        Me.SaveButton.TabIndex = 24
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'MaterialDivider9
        '
        Me.MaterialDivider9.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider9.Depth = 0
        Me.MaterialDivider9.Location = New System.Drawing.Point(415, 202)
        Me.MaterialDivider9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider9.Name = "MaterialDivider9"
        Me.MaterialDivider9.Size = New System.Drawing.Size(3, 58)
        Me.MaterialDivider9.TabIndex = 23
        Me.MaterialDivider9.Text = "MaterialDivider9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(429, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Course"
        '
        'CourseComboBox
        '
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.ItemHeight = 23
        Me.CourseComboBox.Location = New System.Drawing.Point(504, 219)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(415, 29)
        Me.CourseComboBox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CourseComboBox.TabIndex = 20
        Me.CourseComboBox.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CourseComboBox.UseSelectable = True
        Me.CourseComboBox.UseStyleColors = True
        '
        'YearBox3
        '
        Me.YearBox3.Depth = 0
        Me.YearBox3.Hint = "Year Graduated"
        Me.YearBox3.Location = New System.Drawing.Point(772, 132)
        Me.YearBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.YearBox3.Name = "YearBox3"
        Me.YearBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YearBox3.SelectedText = ""
        Me.YearBox3.SelectionLength = 0
        Me.YearBox3.SelectionStart = 0
        Me.YearBox3.Size = New System.Drawing.Size(160, 23)
        Me.YearBox3.TabIndex = 19
        Me.YearBox3.UseSystemPasswordChar = False
        '
        'YearBox2
        '
        Me.YearBox2.Depth = 0
        Me.YearBox2.Hint = "Year Graduated"
        Me.YearBox2.Location = New System.Drawing.Point(772, 85)
        Me.YearBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.YearBox2.Name = "YearBox2"
        Me.YearBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YearBox2.SelectedText = ""
        Me.YearBox2.SelectionLength = 0
        Me.YearBox2.SelectionStart = 0
        Me.YearBox2.Size = New System.Drawing.Size(160, 23)
        Me.YearBox2.TabIndex = 18
        Me.YearBox2.UseSystemPasswordChar = False
        '
        'YearBox1
        '
        Me.YearBox1.Depth = 0
        Me.YearBox1.Hint = "Year Graduated"
        Me.YearBox1.Location = New System.Drawing.Point(772, 38)
        Me.YearBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.YearBox1.Name = "YearBox1"
        Me.YearBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YearBox1.SelectedText = ""
        Me.YearBox1.SelectionLength = 0
        Me.YearBox1.SelectionStart = 0
        Me.YearBox1.Size = New System.Drawing.Size(160, 23)
        Me.YearBox1.TabIndex = 17
        Me.YearBox1.UseSystemPasswordChar = False
        '
        'SecondaryBox
        '
        Me.SecondaryBox.Depth = 0
        Me.SecondaryBox.Hint = "Secondary"
        Me.SecondaryBox.Location = New System.Drawing.Point(432, 132)
        Me.SecondaryBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SecondaryBox.Name = "SecondaryBox"
        Me.SecondaryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SecondaryBox.SelectedText = ""
        Me.SecondaryBox.SelectionLength = 0
        Me.SecondaryBox.SelectionStart = 0
        Me.SecondaryBox.Size = New System.Drawing.Size(310, 23)
        Me.SecondaryBox.TabIndex = 16
        Me.SecondaryBox.UseSystemPasswordChar = False
        '
        'ElementaryBox
        '
        Me.ElementaryBox.Depth = 0
        Me.ElementaryBox.Hint = "Elementary"
        Me.ElementaryBox.Location = New System.Drawing.Point(432, 85)
        Me.ElementaryBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ElementaryBox.Name = "ElementaryBox"
        Me.ElementaryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ElementaryBox.SelectedText = ""
        Me.ElementaryBox.SelectionLength = 0
        Me.ElementaryBox.SelectionStart = 0
        Me.ElementaryBox.Size = New System.Drawing.Size(310, 23)
        Me.ElementaryBox.TabIndex = 15
        Me.ElementaryBox.UseSystemPasswordChar = False
        '
        'MaterialDivider8
        '
        Me.MaterialDivider8.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider8.Depth = 0
        Me.MaterialDivider8.Location = New System.Drawing.Point(415, 31)
        Me.MaterialDivider8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider8.Name = "MaterialDivider8"
        Me.MaterialDivider8.Size = New System.Drawing.Size(3, 132)
        Me.MaterialDivider8.TabIndex = 14
        Me.MaterialDivider8.Text = "MaterialDivider8"
        '
        'PrimaryBox
        '
        Me.PrimaryBox.Depth = 0
        Me.PrimaryBox.Hint = "Primary"
        Me.PrimaryBox.Location = New System.Drawing.Point(432, 39)
        Me.PrimaryBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PrimaryBox.Name = "PrimaryBox"
        Me.PrimaryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrimaryBox.SelectedText = ""
        Me.PrimaryBox.SelectionLength = 0
        Me.PrimaryBox.SelectionStart = 0
        Me.PrimaryBox.Size = New System.Drawing.Size(310, 23)
        Me.PrimaryBox.TabIndex = 13
        Me.PrimaryBox.UseSystemPasswordChar = False
        '
        'MContactBox
        '
        Me.MContactBox.Depth = 0
        Me.MContactBox.Hint = "Contact No"
        Me.MContactBox.Location = New System.Drawing.Point(72, 307)
        Me.MContactBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.MContactBox.Name = "MContactBox"
        Me.MContactBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MContactBox.SelectedText = ""
        Me.MContactBox.SelectionLength = 0
        Me.MContactBox.SelectionStart = 0
        Me.MContactBox.Size = New System.Drawing.Size(277, 23)
        Me.MContactBox.TabIndex = 12
        Me.MContactBox.UseSystemPasswordChar = False
        '
        'MOccupationBox
        '
        Me.MOccupationBox.Depth = 0
        Me.MOccupationBox.Hint = "Occupation"
        Me.MOccupationBox.Location = New System.Drawing.Point(72, 256)
        Me.MOccupationBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.MOccupationBox.Name = "MOccupationBox"
        Me.MOccupationBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MOccupationBox.SelectedText = ""
        Me.MOccupationBox.SelectionLength = 0
        Me.MOccupationBox.SelectionStart = 0
        Me.MOccupationBox.Size = New System.Drawing.Size(277, 23)
        Me.MOccupationBox.TabIndex = 11
        Me.MOccupationBox.UseSystemPasswordChar = False
        '
        'MaterialDivider7
        '
        Me.MaterialDivider7.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider7.Depth = 0
        Me.MaterialDivider7.Location = New System.Drawing.Point(55, 202)
        Me.MaterialDivider7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider7.Name = "MaterialDivider7"
        Me.MaterialDivider7.Size = New System.Drawing.Size(3, 132)
        Me.MaterialDivider7.TabIndex = 10
        Me.MaterialDivider7.Text = "MaterialDivider7"
        '
        'MotherBox
        '
        Me.MotherBox.Depth = 0
        Me.MotherBox.Hint = "Mother's Name"
        Me.MotherBox.Location = New System.Drawing.Point(72, 206)
        Me.MotherBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.MotherBox.Name = "MotherBox"
        Me.MotherBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MotherBox.SelectedText = ""
        Me.MotherBox.SelectionLength = 0
        Me.MotherBox.SelectionStart = 0
        Me.MotherBox.Size = New System.Drawing.Size(277, 23)
        Me.MotherBox.TabIndex = 9
        Me.MotherBox.UseSystemPasswordChar = False
        '
        'FContactBox
        '
        Me.FContactBox.Depth = 0
        Me.FContactBox.Hint = "Contact No"
        Me.FContactBox.Location = New System.Drawing.Point(72, 134)
        Me.FContactBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.FContactBox.Name = "FContactBox"
        Me.FContactBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FContactBox.SelectedText = ""
        Me.FContactBox.SelectionLength = 0
        Me.FContactBox.SelectionStart = 0
        Me.FContactBox.Size = New System.Drawing.Size(277, 23)
        Me.FContactBox.TabIndex = 3
        Me.FContactBox.UseSystemPasswordChar = False
        '
        'FOccupationBox
        '
        Me.FOccupationBox.Depth = 0
        Me.FOccupationBox.Hint = "Occupation"
        Me.FOccupationBox.Location = New System.Drawing.Point(72, 85)
        Me.FOccupationBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.FOccupationBox.Name = "FOccupationBox"
        Me.FOccupationBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FOccupationBox.SelectedText = ""
        Me.FOccupationBox.SelectionLength = 0
        Me.FOccupationBox.SelectionStart = 0
        Me.FOccupationBox.Size = New System.Drawing.Size(277, 23)
        Me.FOccupationBox.TabIndex = 2
        Me.FOccupationBox.UseSystemPasswordChar = False
        '
        'MaterialDivider6
        '
        Me.MaterialDivider6.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MaterialDivider6.Depth = 0
        Me.MaterialDivider6.Location = New System.Drawing.Point(55, 31)
        Me.MaterialDivider6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider6.Name = "MaterialDivider6"
        Me.MaterialDivider6.Size = New System.Drawing.Size(3, 132)
        Me.MaterialDivider6.TabIndex = 6
        Me.MaterialDivider6.Text = "MaterialDivider6"
        '
        'FatherBox
        '
        Me.FatherBox.Depth = 0
        Me.FatherBox.Hint = "Father's Name"
        Me.FatherBox.Location = New System.Drawing.Point(72, 38)
        Me.FatherBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.FatherBox.Name = "FatherBox"
        Me.FatherBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FatherBox.SelectedText = ""
        Me.FatherBox.SelectionLength = 0
        Me.FatherBox.SelectionStart = 0
        Me.FatherBox.Size = New System.Drawing.Size(277, 23)
        Me.FatherBox.TabIndex = 1
        Me.FatherBox.UseSystemPasswordChar = False
        '
        'StudentInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1073, 543)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.TabSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentInformationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StudentInformationForm"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LNameBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MNameBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents HomeAddBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents CityAddBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CivilStatsComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CitizenBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ReligionBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GenderComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents BirthPlaceBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents BDayTimePick As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents IDBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CancelBut As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents SaveButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider9 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CourseComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents YearBox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents YearBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents YearBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SecondaryBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ElementaryBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider8 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PrimaryBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MContactBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MOccupationBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider7 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MotherBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FContactBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FOccupationBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider6 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents FatherBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider10 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider11 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider12 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Uploadbutton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
    Friend WithEvents EmailBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UContactBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FNameBox As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
