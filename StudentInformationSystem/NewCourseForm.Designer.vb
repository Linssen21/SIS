<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCourseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCourseForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.CoCancelButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.CSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.CourseTitlebox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.CourseIDbox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 33)
        Me.Panel1.TabIndex = 10
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 45)
        Me.Panel2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Add Course"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 437)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(404, 1)
        Me.MaterialDivider1.TabIndex = 18
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(0, 74)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(1, 371)
        Me.MaterialDivider2.TabIndex = 19
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(403, 74)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(1, 371)
        Me.MaterialDivider3.TabIndex = 20
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'CoCancelButton
        '
        Me.CoCancelButton.Depth = 0
        Me.CoCancelButton.Location = New System.Drawing.Point(124, 366)
        Me.CoCancelButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CoCancelButton.Name = "CoCancelButton"
        Me.CoCancelButton.Primary = True
        Me.CoCancelButton.Size = New System.Drawing.Size(153, 40)
        Me.CoCancelButton.TabIndex = 26
        Me.CoCancelButton.Text = "Cancel"
        Me.CoCancelButton.UseVisualStyleBackColor = True
        '
        'CSave
        '
        Me.CSave.Depth = 0
        Me.CSave.Location = New System.Drawing.Point(124, 320)
        Me.CSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.CSave.Name = "CSave"
        Me.CSave.Primary = True
        Me.CSave.Size = New System.Drawing.Size(153, 40)
        Me.CSave.TabIndex = 23
        Me.CSave.Text = "Save"
        Me.CSave.UseVisualStyleBackColor = True
        '
        'CourseTitlebox
        '
        Me.CourseTitlebox.BackColor = System.Drawing.SystemColors.Control
        Me.CourseTitlebox.Depth = 0
        Me.CourseTitlebox.Hint = ""
        Me.CourseTitlebox.Location = New System.Drawing.Point(30, 227)
        Me.CourseTitlebox.MouseState = MaterialSkin.MouseState.HOVER
        Me.CourseTitlebox.Name = "CourseTitlebox"
        Me.CourseTitlebox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CourseTitlebox.SelectedText = ""
        Me.CourseTitlebox.SelectionLength = 0
        Me.CourseTitlebox.SelectionStart = 0
        Me.CourseTitlebox.Size = New System.Drawing.Size(337, 23)
        Me.CourseTitlebox.TabIndex = 22
        Me.CourseTitlebox.UseSystemPasswordChar = False
        '
        'CourseIDbox
        '
        Me.CourseIDbox.BackColor = System.Drawing.SystemColors.Control
        Me.CourseIDbox.Depth = 0
        Me.CourseIDbox.Hint = ""
        Me.CourseIDbox.Location = New System.Drawing.Point(30, 157)
        Me.CourseIDbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.CourseIDbox.Name = "CourseIDbox"
        Me.CourseIDbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CourseIDbox.SelectedText = ""
        Me.CourseIDbox.SelectionLength = 0
        Me.CourseIDbox.SelectionStart = 0
        Me.CourseIDbox.Size = New System.Drawing.Size(337, 23)
        Me.CourseIDbox.TabIndex = 21
        Me.CourseIDbox.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Course ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Course Title"
        '
        'NewCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(404, 438)
        Me.Controls.Add(Me.CoCancelButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CSave)
        Me.Controls.Add(Me.CourseTitlebox)
        Me.Controls.Add(Me.CourseIDbox)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewCourseForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents CoCancelButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CourseTitlebox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents CourseIDbox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
