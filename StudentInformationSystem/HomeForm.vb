Public Class HomeForm

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
    Public Sub StudentInfoTile_Click(sender As Object, e As EventArgs) Handles StudentInfoTile.Click
        EditStudent = False
        DisplayForm(StudentList, HomeFormPanel)

    End Sub


   

    
    Private Sub AdminTile_Click(sender As Object, e As EventArgs) Handles AdminTile.Click
        DisplayForm(AdministratorForm, HomeFormPanel)
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        DisplayForm(CourseForm, HomeFormPanel)
    End Sub

    Private Sub RecrodTile_Click(sender As Object, e As EventArgs) Handles RecrodTile.Click
        DisplayForm(RecordForm, HomeFormPanel)
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        DisplayForm(AboutUs, Me.Panel1)
        Panel1.BringToFront()
        DashBoardPanel.Enabled = False
    End Sub
End Class