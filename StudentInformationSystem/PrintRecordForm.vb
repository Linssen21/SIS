Public Class PrintRecordForm

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        RecordForm.RecordTabControl.Enabled = True
        RecordForm.MaterialTabSelector1.Enabled = True


    End Sub

    Private Sub PrintRecordForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RecordForm.RecordTabControl.Enabled = True
        RecordForm.MaterialTabSelector1.Enabled = True
    End Sub

    Private Sub PrintRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim kurso As String
        kurso = RecordForm.CourseComboBox.Text
        If kurso = "" Then
            RecordForm.sqlQRY = "Select * from qryStudInfo"
            RecordForm.viewreports2()
        Else

            RecordForm.cn.Open()

            RecordForm.sqlQRY = "Select * from qryStudInfo where  Course = '" & kurso & "'"

            RecordForm.viewreports2()



            RecordForm.cn.Close()
        End If

    End Sub
End Class