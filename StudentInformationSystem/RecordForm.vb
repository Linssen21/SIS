Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class RecordForm

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet

    Public sqlQRY As String = ""



    Public sReportDataSource As New ReportDataSource
    Public ImagePath As String


    Public cn As New OleDbConnection(conStr)





    Public reportPath2 As String = "StudentInformationSystem.Report2.rdlc"
    Public Sub viewreports2()

        ds = New DataSet
        da = New OleDbDataAdapter(sqlQRY, cn)
        da.Fill(ds, "qryStudInfo")
        PrintRecordForm.ReportViewer1.LocalReport.ReportEmbeddedResource = reportPath2
        PrintRecordForm.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        PrintRecordForm.ReportViewer1.ZoomMode = ZoomMode.Percent
        PrintRecordForm.ReportViewer1.ZoomPercent = 60

        sReportDataSource.Name = "DataSet1"
        sReportDataSource.Value = ds.Tables(0)
        PrintRecordForm.ReportViewer1.LocalReport.DataSources.Add(sReportDataSource)
        PrintRecordForm.ReportViewer1.RefreshReport()


    End Sub

 






    Private Sub RecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayToDataGrid("SELECT ID,StudentID, FullName, Course, BirthDate, Gender, Citizenship, Religion, CivilStatus, CityAddress, HomeAddress, ContactNo, EmailAdd, PrimarySchool, PrimaryYG, Elementary, ElementaryYG, Secondary, SecondaryYG FROM qryStudInfo ORDER BY ID", dgvStudent)
        DataGridPropertyStudlist(dgvStudent)
        DataGridStudInfo2(dgvStudent)
        DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl ORDER BY courseID", dgvCourse)
        DataGridProperty(dgvCourse)
        DisplayToDataGrid("SELECT AdminId, Password FROM AdminTbl ORDER BY AdminID", dgvAdmin)
        DataGridProperty(dgvAdmin)

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




    End Sub

    Private Sub HomeTile_Click(sender As Object, e As EventArgs) Handles HomeTile.Click
        Me.Close()
        DisplayForm(HomeForm, MainForm.MainPnl)

    End Sub

    Private Sub dgvAdmin_Click(sender As Object, e As EventArgs) Handles Adminlabel.Click

    End Sub

    Private Sub CourseComboBox_CausesValidationChanged(sender As Object, e As EventArgs) Handles CourseComboBox.CausesValidationChanged

    End Sub

    Private Sub CourseComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseComboBox.SelectedIndexChanged
        Dim course As String
        course = CourseComboBox.Text

        DisplayToDataGrid("SELECT ID,StudentID, FullName, Course, BirthDate, Gender, Citizenship, Religion, CivilStatus, CityAddress, HomeAddress, ContactNo, EmailAdd, PrimarySchool, PrimaryYG, Elementary, ElementaryYG, Secondary, SecondaryYG FROM qryStudInfo WHERE Course='" & course & "' ORDER BY ID", dgvStudent)

    End Sub

    Private Sub PrintStuddentButton_Click(sender As Object, e As EventArgs) Handles PrintStuddentButton.Click

        If dgvStudent.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Student's Information To print", "Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            PrintRecordForm.Show()
            RecordTabControl.Enabled = False
            MaterialTabSelector1.Enabled = False
        End If


    End Sub

    
    Private Sub ResButton_Click(sender As Object, e As EventArgs) Handles ResButton.Click
        CourseComboBox.Items.Clear()

        If CourseComboBox.Text = "" Then
            Dim dtable As DataTable = DTTable("SELECT CourseID, Course ", "CourseTbl", " ORDER BY CourseID")

            If dtable.Rows.Count > 0 Then
                For i As Integer = 0 To dtable.Rows.Count - 1
                    CourseComboBox.Items.Add(dtable.Rows(i).Item(1).ToString)
                Next
                CourseComboBox.Text = "Course"
            Else
                CourseComboBox.Text = ""
            End If
        End If
        DisplayToDataGrid("SELECT ID,StudentID ,FullName, Course, BirthDate, Gender, Citizenship, Religion, CivilStatus, CityAddress, HomeAddress, ContactNo, EmailAdd, PrimarySchool, PrimaryYG, Elementary, ElementaryYG, Secondary, SecondaryYG FROM qryStudInfo ORDER BY ID", dgvStudent)
        DataGridPropertyStudlist(dgvStudent)
       

    End Sub

    Private Sub CourseComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CourseComboBox.SelectedValueChanged

    End Sub

     
    Private Sub HomeTile1_Click(sender As Object, e As EventArgs) Handles HomeTile1.Click
        Me.Close()
        DisplayForm(HomeForm, MainForm.MainPnl)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class