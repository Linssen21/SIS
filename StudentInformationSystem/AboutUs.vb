Public Class AboutUs

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomeForm.Panel1.SendToBack()
        HomeForm.DashBoardPanel.Enabled = True
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click, MaterialLabel5.Click, MaterialLabel4.Click, MaterialLabel3.Click, MaterialLabel2.Click

    End Sub
End Class