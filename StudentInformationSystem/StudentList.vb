Imports System.Reflection

Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms


Public Class StudentList



    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayToDataGrid("SELECT ID,StudentID, FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus, Course FROM qryStudInfo ORDER BY ID", dgvStudent)
        DataGridPropertyStudlist(dgvStudent)
        DataGridStudInfo(dgvStudent)

        dgvStudent.HorizontalScrollingOffset = dgvStudent.HorizontalScrollingOffset + 1 'avoid datagrid bug appearance

        'dgvStudent.FirstDisplayedScrollingRowIndex = dgvStudent.Rows.Count - 1

    End Sub

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet

    Public sqlQRY As String = ""

    Public reportPath As String = "StudentInformationSystem.Report1.rdlc"

    Public sReportDataSource As New ReportDataSource
    Public ImagePath As String

    Public img As String
    Public cn As New OleDbConnection(conStr)
    Public r(0) As ReportParameter


    Public Sub viewreports()

        ds = New DataSet
        da = New OleDbDataAdapter(sqlQRY, cn)
        da.Fill(ds, "qryStudInfo")

        ReportForm.ReportViewer1.LocalReport.ReportEmbeddedResource = reportPath
        ReportForm.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportForm.ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportForm.ReportViewer1.ZoomPercent = 60

        sReportDataSource.Name = "DataSet1"
        sReportDataSource.Value = ds.Tables(0)
        ReportForm.ReportViewer1.LocalReport.DataSources.Add(sReportDataSource)


        img = System.Environment.CurrentDirectory


        r(0) = New ReportParameter("img_rpt", "file://" + img + "\images\" + IDn + ".jpg", True)


        ReportForm.ReportViewer1.LocalReport.EnableExternalImages = True
        ReportForm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})

        ReportForm.ReportViewer1.RefreshReport()
        

    End Sub

   







    Private Sub PrintStuddentButton_Click(sender As Object, e As EventArgs) Handles PrintStuddentButton.Click
        If dgvStudent.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Student's Information To print", "Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()

        Else
            Dim i As New Integer
            i = dgvStudent.CurrentRow.Index
            IDn = dgvStudent.Item("ID", i).Value.ToString()
            Me.Panel2.Enabled = False

            ReportForm.Show()
        End If



    End Sub












    Private Sub HomeTile_Click(sender As Object, e As EventArgs) Handles HomeTile.Click
        Me.Close()
        EditStudent = False
        DisplayForm(HomeForm, MainForm.MainPnl)
    End Sub


    Private Sub AddTile_Click(sender As Object, e As EventArgs) Handles AddTile.Click

        EditStudent = False

        DisplayForm(StudentInformationForm, Me.StudentInformationPanel)



    End Sub

    Private Sub EditStudentButton_Click(sender As Object, e As EventArgs) Handles EditStudentButton.Click
        If dgvStudent.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Student's Information To Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            EditStudent = True
            Dim i As New Integer
            i = dgvStudent.CurrentRow.Index
            IDNumber = dgvStudent.Item("ID", i).Value.ToString()
            DisplayForm(StudentInformationForm, Me.StudentInformationPanel)
        End If






    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchBox.Clear()
        DisplayToDataGrid("SELECT ID,StudentID, FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus,Course FROM qryStudInfo ORDER BY ID", dgvStudent)

    End Sub










    Private Sub DeleteTile_Click(sender As Object, e As EventArgs) Handles DeleteTile.Click
        
        If dgvStudent.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Student's Information To Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            Dim i As Integer
            i = dgvStudent.CurrentRow.Index
            IDNumber = dgvStudent.Item("ID", i).Value.ToString()
            If MetroFramework.MetroMessageBox.Show(MainForm, "The operation cannot be undone! Continue?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                RecordRow("DELETE FROM [PersonlDTbl] WHERE [ID]='" & IDNumber & "'")
                RecordRow("DELETE FROM [StudentInfoTbl] WHERE [StudID]='" & IDNumber & "'")

                System.IO.File.Delete(System.Environment.CurrentDirectory & "\images\" & IDNumber & ".jpg")

                ' DisplayToDataGrid("SELECT ID, FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus FROM qryStudInfo ORDER BY LastName", dgvStudent)


                DisplayToDataGrid("SELECT ID,StudentID, FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus FROM qryStudInfo ORDER BY ID", dgvStudent)
            End If
        End If
    End Sub

    

    Private Sub SearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBox.KeyPress
        Try
            DisplayToDataGrid("SELECT ID, StudentID,FullName, BirthDate, Gender, Citizenship, Religion, CivilStatus,Course FROM qryStudInfo WHERE FullName LIKE '%" & SearchBox.Text & "%' or Gender LIKE '%" & SearchBox.Text & "%' or StudentID LIKE '%" & SearchBox.Text & "%' or Citizenship LIKE '%" & SearchBox.Text & "%' or Religion LIKE '%" & SearchBox.Text & "%' or CourseID LIKE '%" & SearchBox.Text & "%' or CivilStatus LIKE '%" & SearchBox.Text & "%'  ORDER BY FullName", dgvStudent)
        Catch ex As Exception

        End Try

    End Sub

 

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class