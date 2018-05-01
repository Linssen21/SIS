
Public Class ReportForm

    Private Sub ReportForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        StudentList.Panel2.Enabled = True

    End Sub

    Private Sub ReportForm_Leave(sender As Object, e As EventArgs) Handles Me.Leave


    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim photoUrl As String
        photoUrl = "\images\" & IDn & ".jpg"


        StudentList.cn.Open()
        StudentList.sqlQRY = "Select * from qryStudInfo where  ID = '" & IDn & "'"

        StudentList.viewreports()


        StudentList.cn.Close()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentList.Panel2.Enabled = True
        Me.Close()

    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class