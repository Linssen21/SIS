
Public Class StudentInformationForm


     
    
    
    Dim idPH As Integer
    Dim img As String = "photo.jpg"
    Public id, studid, accountID, fName, mName, lName, bPlace, gender, citizenship, religion, civilStatus, cityAddress, homeAddress, contactNo, emailAdd, photoUrl As String
    Dim bDate As String
    Public newid As String


    Dim fatherName, fatherOccupation, fatherContactNo, motherName, motherOccupation, motherContactNo, primary, primaryYG, elementary, elementaryYG, secondary, secondaryYG, courseID, course As String


 
    
    Private Sub StudentInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Loads all the data in the CourseComboBox
        Dim dtable As DataTable = DTTable("SELECT CourseID, Course ", "CourseTbl", " ORDER BY CourseID")
        CourseComboBox.Items.Clear()
        If dtable.Rows.Count > 0 Then
            For i As Integer = 0 To dtable.Rows.Count - 1
                CourseComboBox.Items.Add(dtable.Rows(i).Item(1).ToString)
            Next
            CourseComboBox.Text = "Course"
        Else
            CourseComboBox.Text = ""
        End If
        If EditStudent = False Then
            img = System.Environment.CurrentDirectory + "\" + img
            Dim DT As DataTable = DTTable("SELECT ID ", "PersonlDTbl", " ORDER BY ID DESC")
            If DT.Rows.Count > 0 Then
                idPH = Convert.ToInt32(DT.Rows(0).Item("ID"))
            Else
                idPH = 0
            End If
            idPH = idPH + 1
            ' IDBox.Text = idPH.ToString("000000")
            newid = idPH.ToString("000000")
        Else
            Dim DT As DataTable = DTTable("SELECT * ", "PersonlDTbl", " WHERE ID='" & IDNumber & "'")
            Dim DTEmp As DataTable = DTTable("SELECT * ", "qryStudInfo", " WHERE ID='" & IDNumber & "'")
            ' IDBox.Text = IDNumber
            newid = IDNumber

            IDBox.Text = DT.Rows(0).Item("StudentID")
            FNameBox.Text = DT.Rows(0).Item("FirstName")

            MNameBox.Text = DT.Rows(0).Item("MiddleName")
            LNameBox.Text = DT.Rows(0).Item("LastName")
            BDayTimePick.Text = DT.Rows(0).Item("BirthDate")
            BirthPlaceBox.Text = DT.Rows(0).Item("BirthPlace")
            GenderComboBox.Text = DT.Rows(0).Item("Gender")
            CitizenBox.Text = DT.Rows(0).Item("Citizenship")
            ReligionBox.Text = DT.Rows(0).Item("Religion")
            CivilStatsComboBox.Text = DT.Rows(0).Item("CivilStatus")
            CityAddBox.Text = DT.Rows(0).Item("CityAddress")
            HomeAddBox.Text = DT.Rows(0).Item("HomeAddress")
            UContactBox.Text = DT.Rows(0).Item("ContactNo")
            EmailBox.Text = DT.Rows(0).Item("EmailAdd")

            FatherBox.Text = DTEmp.Rows(0).Item("FatherName")
            FOccupationBox.Text = DTEmp.Rows(0).Item("FatherOccupation")
            FContactBox.Text = DTEmp.Rows(0).Item("FatherContactNo")
            MotherBox.Text = DTEmp.Rows(0).Item("MotherName")
            MOccupationBox.Text = DTEmp.Rows(0).Item("MotherOccupation")
            MContactBox.Text = DTEmp.Rows(0).Item("MotherContactNo")
            PrimaryBox.Text = DTEmp.Rows(0).Item("PrimarySchool")
            YearBox1.Text = DTEmp.Rows(0).Item("PrimaryYG")
            ElementaryBox.Text = DTEmp.Rows(0).Item("Elementary")
            YearBox2.Text = DTEmp.Rows(0).Item("ElementaryYG")
            SecondaryBox.Text = DTEmp.Rows(0).Item("Secondary")
            YearBox3.Text = DTEmp.Rows(0).Item("SecondaryYG")
            CourseComboBox.Text = DTEmp.Rows(0).Item("Course")
            img = System.Environment.CurrentDirectory + DT.Rows(0).Item("PhotoUrl")

            picStudent.ImageLocation = img


            SaveButton.Text = "Edit"



        End If

    End Sub



    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click



        ' id = IDBox.Text
        id = newid

        studid = Trim(IDBox.Text)
        fName = Trim(FNameBox.Text)
        mName = Trim(MNameBox.Text)
        lName = Trim(LNameBox.Text)
        bDate = Trim(BDayTimePick.Text)
        bPlace = Trim(BirthPlaceBox.Text)
        gender = Trim(GenderComboBox.Text)
        citizenship = Trim(CitizenBox.Text)
        religion = Trim(ReligionBox.Text)
        civilStatus = Trim(CivilStatsComboBox.Text)
        cityAddress = Trim(CityAddBox.Text)
        homeAddress = Trim(HomeAddBox.Text)
        contactNo = Trim(UContactBox.Text)
        emailAdd = Trim(EmailBox.Text)
        photoUrl = "\images\" & id & ".jpg"

        fatherName = Trim(FatherBox.Text)
        fatherOccupation = Trim(FOccupationBox.Text)
        fatherContactNo = Trim(FContactBox.Text)
        motherName = Trim(MotherBox.Text)
        motherOccupation = Trim(MOccupationBox.Text)
        motherContactNo = Trim(MContactBox.Text)
        primary = Trim(PrimaryBox.Text)
        primaryYG = Trim(YearBox1.Text)
        elementary = Trim(ElementaryBox.Text)
        elementaryYG = Trim(YearBox2.Text)
        secondary = Trim(SecondaryBox.Text)
        secondaryYG = Trim(YearBox3.Text)
        course = CourseComboBox.Text

        Try
            courseID = DTTable("SELECT CourseID, Course ", "CourseTbl", " WHERE Course='" & course & "' ORDER BY CourseID").Rows(0).Item("CourseID").ToString
        Catch ex As Exception

        End Try

        Try

        Catch ex As Exception

        End Try

        Dim myid As String
        myid = Trim(IDBox.Text)










        If (studid <> "") And (fName <> "") And (lName <> "") And (bPlace <> "") And (gender <> "") And (citizenship <> "") And (religion <> "") And (civilStatus <> "") And (cityAddress <> "") And (homeAddress <> "") And (contactNo <> "") And (emailAdd <> "") And (fatherName <> "") And (fatherOccupation <> "") And (fatherContactNo <> "") And (motherName <> "") And (motherOccupation <> "") And (motherContactNo <> "") And (primary <> "") And (primaryYG <> "") And (elementary <> "") And (elementaryYG <> "") And (secondary <> "") And (secondaryYG <> "") And (courseID <> "") And (courseID <> "") Then
            Dim uaDT As DataTable = DTTable("SELECT StudentID", "PersonlDTbl", " WHERE (StudentID='" + myid + "') ")
           
                If EditStudent = False Then
                If (uaDT.Rows.Count >= 1) Then
                    MetroFramework.MetroMessageBox.Show(MainForm, "Student ID Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    RecordRow("INSERT INTO PersonlDTbl (ID, StudentID, FirstName, MiddleName, LastName, BirthDate, BirthPlace, Gender, Citizenship, Religion, CivilStatus, CityAddress, HomeAddress, ContactNo, EmailAdd, PhotoUrl) VALUES ('" & id & "','" & studid & "', '" & fName & "', '" & mName & "', '" & lName & "', '" & bDate & "', '" & bPlace & "', '" & gender & "', '" & citizenship & "', '" & religion & "', '" & civilStatus & "', '" & cityAddress & "', '" & homeAddress & "', '" & contactNo & "', '" & emailAdd & "', '" & photoUrl & "')")

                    'TEXT data type must have indent in Query e.g.( '" & fName & "'  )

                    RecordRow("INSERT INTO StudentInfoTbl (StudID, FatherName, FatherOccupation, FatherContactNo, MotherName, MotherOccupation, MotherContactNo, PrimarySchool, PrimaryYG, Elementary, ElementaryYG, Secondary, SecondaryYG,  CourseID) VALUES ('" & id & "', '" & fatherName & "', '" & fatherOccupation & "', '" & fatherContactNo & "', '" & motherName & "', '" & motherOccupation & "', '" & motherContactNo & "', '" & primary & "', '" & primaryYG & "', '" & elementary & "', '" & elementaryYG & "', '" & secondary & "', '" & secondaryYG & "', '" & courseID & "')")

                    loadPic(img, System.Environment.CurrentDirectory & photoUrl)

                    MetroFramework.MetroMessageBox.Show(MainForm, "Student Information Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                    DisplayForm(StudentList, HomeForm.HomeFormPanel)
                End If



            Else
                If (uaDT.Rows.Count >= 1) Then
                    MetroFramework.MetroMessageBox.Show(MainForm, "Student ID Already Exist " & vbNewLine & "Some of its Updated Data Will be Saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    RecordRow("UPDATE [PersonlDTbl] SET  [FirstName]='" & fName & "', [MiddleName]='" & mName & "', [LastName]='" & lName & "', [BirthDate]='" & bDate & "', [BirthPlace]='" & bPlace & "', [Gender]='" & gender & "', [Citizenship]='" & citizenship & "', [Religion]='" & religion & "', [CivilStatus]='" & civilStatus & "', [CityAddress]='" & cityAddress & "', [HomeAddress]='" & homeAddress & "', [ContactNo]='" & contactNo & "', [EmailAdd]='" & emailAdd & "', [PhotoUrl]='" & photoUrl & "' WHERE ([ID]='" & id & "')")

                    RecordRow("UPDATE [StudentInfoTbl] SET [FatherName]='" & fatherName & "', [FatherOccupation]='" & fatherOccupation & "', [FatherContactNo]='" & fatherContactNo & "', [MotherName]='" & motherName & "', [MotherOccupation]='" & motherOccupation & "', [MotherContactNo]='" & motherContactNo & "', [PrimarySchool]='" & primary & "', [PrimaryYG]='" & primaryYG & "', [Elementary]='" & elementary & "', [ElementaryYG]='" & elementaryYG & "', [Secondary]='" & secondary & "', [SecondaryYG]='" & secondaryYG & "', [CourseID]='" & courseID & "' WHERE ([StudID]='" & id & "')")
                    If (img <> System.Environment.CurrentDirectory & photoUrl) Then
                        loadPic(img, System.Environment.CurrentDirectory & photoUrl)
                    End If

                    Me.Close()
                    DisplayForm(StudentList, HomeForm.HomeFormPanel)
                Else

                    RecordRow("UPDATE [PersonlDTbl] SET  [StudentID]='" & studid & "', [FirstName]='" & fName & "', [MiddleName]='" & mName & "', [LastName]='" & lName & "', [BirthDate]='" & bDate & "', [BirthPlace]='" & bPlace & "', [Gender]='" & gender & "', [Citizenship]='" & citizenship & "', [Religion]='" & religion & "', [CivilStatus]='" & civilStatus & "', [CityAddress]='" & cityAddress & "', [HomeAddress]='" & homeAddress & "', [ContactNo]='" & contactNo & "', [EmailAdd]='" & emailAdd & "', [PhotoUrl]='" & photoUrl & "' WHERE ([ID]='" & id & "')")

                    RecordRow("UPDATE [StudentInfoTbl] SET [FatherName]='" & fatherName & "', [FatherOccupation]='" & fatherOccupation & "', [FatherContactNo]='" & fatherContactNo & "', [MotherName]='" & motherName & "', [MotherOccupation]='" & motherOccupation & "', [MotherContactNo]='" & motherContactNo & "', [PrimarySchool]='" & primary & "', [PrimaryYG]='" & primaryYG & "', [Elementary]='" & elementary & "', [ElementaryYG]='" & elementaryYG & "', [Secondary]='" & secondary & "', [SecondaryYG]='" & secondaryYG & "', [CourseID]='" & courseID & "' WHERE ([StudID]='" & id & "')")
                    If (img <> System.Environment.CurrentDirectory & photoUrl) Then
                        loadPic(img, System.Environment.CurrentDirectory & photoUrl)
                    End If
                    MetroFramework.MetroMessageBox.Show(MainForm, "Student Update Complete", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                    DisplayForm(StudentList, HomeForm.HomeFormPanel)

                End If
            End If


        Else
            MetroFramework.MetroMessageBox.Show(MainForm, "Please fill all of the Fields", "Information Requires", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DisplayToDataGrid("SELECT ID,StudentID, FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus,Course FROM qryStudInfo ORDER BY ID", StudentList.dgvStudent)
    End Sub







    Private Sub Uploadbutton_Click(sender As Object, e As EventArgs) Handles Uploadbutton.Click
        Dim open As New OpenFileDialog()
        open.Title = "Upload Picture"
        open.Filter = "JPG File (*.jpg)|*.jpg| PNG FILES(*.png)|*.png"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Using fs As IO.FileStream = IO.File.OpenRead(open.FileName)
                Dim im As Image = Image.FromStream(fs)
                picStudent.Image = im
                img = open.FileName
            End Using
        End If

    End Sub





    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        Me.Close()
        StudentList.ClearButton.PerformClick()

        DisplayForm(StudentList, HomeForm.HomeFormPanel)
    End Sub

    Private Sub FNameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FNameBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If

    End Sub
    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged
        If MaterialTabControl1.SelectedIndex = 1 Then
            FatherBox.SelectAll()
        Else
            FNameBox.SelectAll()

        End If
    End Sub
  

    Private Sub LNameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LNameBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub


    Private Sub MNameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MNameBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

   

    Private Sub ReligionBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReligionBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

  

    Private Sub CitizenBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CitizenBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

    

    Private Sub UContactBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UContactBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

   

    Private Sub FatherBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
         
    End Sub

  

    Private Sub FContactBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FContactBox.KeyPress

        If Not (Char.IsDigit(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

  

    Private Sub FOccupationBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FOccupationBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

   

    Private Sub MotherBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

    

    Private Sub MContactBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MContactBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

   

    Private Sub MOccupationBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MOccupationBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

   

    Private Sub PrimaryBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrimaryBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

    

    Private Sub SecondaryBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SecondaryBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

    

    Private Sub ElementaryBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ElementaryBox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " ")
        End If
    End Sub

   

    Private Sub YearBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YearBox1.KeyPress
        If (Char.IsLetter(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub YearBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YearBox2.KeyPress
        If (Char.IsLetter(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

  

   

    Private Sub YearBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles YearBox3.KeyPress
        If (Char.IsLetter(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub






    Private Sub IDBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IDBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            FNameBox.SelectAll()

        End If
    End Sub
    Private Sub FNameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FNameBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            MNameBox.SelectAll()

        End If
        If e.KeyCode = Keys.Tab Then
            MNameBox.SelectAll()

        End If
    End Sub


    Private Sub MNameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MNameBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LNameBox.SelectAll()

        End If
    End Sub
    Private Sub LNameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LNameBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            BDayTimePick.Focus()

        End If
    End Sub

    Private Sub BDayTimePick_KeyDown(sender As Object, e As KeyEventArgs) Handles BDayTimePick.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            BirthPlaceBox.SelectAll()

        End If
    End Sub

     
   
    

    Private Sub BirthPlaceBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BirthPlaceBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            GenderComboBox.Focus()

        End If
    End Sub

    Private Sub GenderComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles GenderComboBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            ReligionBox.SelectAll()

        End If
    End Sub

    Private Sub ReligionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ReligionBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CitizenBox.SelectAll()

        End If
    End Sub
    Private Sub CitizenBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CitizenBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CivilStatsComboBox.Focus()

        End If
    End Sub

    Private Sub CivilStatsComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CivilStatsComboBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CityAddBox.SelectAll()

        End If
    End Sub
   
   
   
    

    Private Sub CityAddBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CityAddBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            HomeAddBox.SelectAll()

        End If
    End Sub

   

    Private Sub HomeAddBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HomeAddBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            UContactBox.SelectAll()

        End If
    End Sub


    Private Sub UContactBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UContactBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            EmailBox.SelectAll()

        End If

    End Sub

    Private Sub EmailBox_KeyDown(sender As Object, e As KeyEventArgs) Handles EmailBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            MaterialTabControl1.SelectTab(TabPage2)




        End If
    End Sub

    Private Sub FatherBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FatherBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            FOccupationBox.SelectAll()


        End If
    End Sub


    Private Sub FOccupationBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FOccupationBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            FContactBox.SelectAll()


        End If
    End Sub



    
    Private Sub FContactBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FContactBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            MotherBox.SelectAll()


        End If
    End Sub

    Private Sub MotherBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MotherBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            MOccupationBox.SelectAll()


        End If
    End Sub
    Private Sub MOccupationBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MOccupationBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            MContactBox.SelectAll()


        End If
    End Sub
    Private Sub MContactBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MContactBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            PrimaryBox.SelectAll()


        End If
    End Sub
    Private Sub PrimaryBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PrimaryBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            YearBox1.SelectAll()


        End If
    End Sub
    

    Private Sub YearBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles YearBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            ElementaryBox.SelectAll()


        End If
    End Sub

   




    Private Sub ElementaryBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ElementaryBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            YearBox2.SelectAll()


        End If
    End Sub

   
    Private Sub YearBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles YearBox2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            SecondaryBox.SelectAll()


        End If
    End Sub


    Private Sub SecondaryBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SecondaryBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            YearBox3.SelectAll()


        End If
    End Sub


     
    Private Sub YearBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles YearBox3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CourseComboBox.Focus()



        End If
    End Sub
    
   
   

    

    

   


    Private Sub CourseComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseComboBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            SaveButton_Click(Me, EventArgs.Empty)
        End If
    End Sub


    Private Sub IDBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDBox.KeyPress
        If (Char.IsLetter(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub YearBox1_Click(sender As Object, e As EventArgs) Handles YearBox1.Click

    End Sub
End Class