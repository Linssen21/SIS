Module ModGrid
    Public OleCn As New OleDb.OleDbConnection()
    Public OleDa As New OleDb.OleDbDataAdapter()

    Public Sub DisplayToDataGrid(ByVal sql As String, ByVal dgvLog As DataGridView)
        Dim dt As New DataTable

        OleCn.ConnectionString = conStr
        OleCn.Open()

        OleDa = New OleDb.OleDbDataAdapter(sql, OleCn)

        OleDa.Fill(dt)

        dgvLog.DataSource = dt
        OleCn.Close()
    End Sub

    Public Sub DataGridProperty(ByVal dgvLog As DataGridView)
        With dgvLog
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.SelectionBackColor = Color.DimGray
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.ForeColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .RowTemplate.Height = 30
        End With

    End Sub
    Public Sub DataGridPropertyStudlist(ByVal dgvLog As DataGridView)
        With dgvLog
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White

            .DefaultCellStyle.SelectionBackColor = Color.DimGray
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.ForeColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .RowTemplate.Height = 30



        End With

    End Sub

    Public Sub DataGridAdmin(ByVal dgvLog As DataGridView)
        dgvLog.AutoGenerateColumns = False
        With dgvLog
            With .Columns("AdminId")
                .HeaderText = "Admin ID"
                .Width = 140
            End With
            With .Columns("Password")
                .HeaderText = "Password"
                .Width = 140
            End With
            With .Columns("Question")
                .HeaderText = "Question"
                .Width = 310
            End With
            With .Columns("Answer")
                .HeaderText = "Answer"

                .Width = 150
            End With
        End With
    End Sub



    Public Sub DataGridStudInfo(ByVal dgvLog As DataGridView)
        dgvLog.AutoGenerateColumns = False
        With dgvLog
            With .Columns("ID")
                .Visible = False
            End With
            With .Columns("StudentID")
                .HeaderText = "Student ID"
                .Width = 120
            End With
            With .Columns("FullName")
                .HeaderText = "Full Name"
                .Width = 280
            End With
            With .Columns("BirthDate")
                .HeaderText = "Birthdate"
                .DefaultCellStyle.Format = "MMMM dd, yyyy"
                .Width = 150
            End With
            With .Columns("Gender")
                .HeaderText = "Gender"
                .Width = 100
            End With
            With .Columns("Citizenship")
                .HeaderText = "Citizenship"
                .Width = 100
            End With
            With .Columns("Religion")
                .HeaderText = "Religion"
                .Width = 150
            End With
            With .Columns("CivilStatus")
                .HeaderText = "Civil Status"
                .Width = 100
            End With
            With .Columns("Course")
                .HeaderText = "Course"
                .Width = 300
            End With

        End With
    End Sub

    Public Sub DataGridStudInfo2(ByVal dgvLog As DataGridView)
        dgvLog.AutoGenerateColumns = False
        With dgvLog
            With .Columns("ID")
                .Visible = False
            End With
            With .Columns("StudentID")
                .HeaderText = "Student ID"
                .Width = 120
            End With
            With .Columns("FullName")
                .HeaderText = "Full Name"
                .Width = 280
            End With
            With .Columns("Course")
                .HeaderText = "Course"
                .Width = 300
            End With
            With .Columns("BirthDate")
                .HeaderText = "Birthdate"
                .DefaultCellStyle.Format = "MMMM dd, yyyy"
                .Width = 180
            End With
            With .Columns("Gender")
                .HeaderText = "Gender"
                .Width = 100
            End With
            With .Columns("Citizenship")
                .HeaderText = "Citizenship"
                .Width = 100
            End With
            With .Columns("Religion")
                .HeaderText = "Religion"
                .Width = 150
            End With
            With .Columns("CivilStatus")
                .HeaderText = "Civil Status"
                .Width = 100
            End With
            With .Columns("CityAddress")
                .HeaderText = "City Address"
                .Width = 250
            End With
            With .Columns("HomeAddress")
                .HeaderText = "Home Address"
                .Width = 250
            End With
            With .Columns("ContactNo")
                .HeaderText = "Contact Number"
                .Width = 150
            End With
            With .Columns("EmailAdd")
                .HeaderText = "Email Address"
                .Width = 200
            End With
            With .Columns("PrimarySchool")
                .HeaderText = "Primary School"
                .Width = 240
            End With
            With .Columns("PrimaryYG")
                .HeaderText = "Primary Year Graduated"
                .Width = 150
            End With
            With .Columns("Elementary")
                .HeaderText = "Elementary School"
                .Width = 240
            End With
            With .Columns("ElementaryYG")
                .HeaderText = "Elementary Year Graduated"
                .Width = 150
            End With
            With .Columns("Secondary")
                .HeaderText = "Secondary School"
                .Width = 240
            End With
            With .Columns("SecondaryYG")
                .HeaderText = "Secondary Year Graduated "
                .Width = 150
            End With


        End With
    End Sub
End Module
