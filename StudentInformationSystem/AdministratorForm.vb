Public Class AdministratorForm

    Private Sub HomeTile_Click(sender As Object, e As EventArgs) Handles HomeTile.Click
        Me.Close()
        DisplayForm(HomeForm, MainForm.MainPnl)
    End Sub

    Private Sub AddTile_Click(sender As Object, e As EventArgs) Handles AddTile.Click
        EditAdmin = False
        NewAdminForm.AdminBox.Enabled = True
        NewAdminForm.MaterialCheckBox1.Checked = True
        DisplayForm(NewAdminForm, Me.Panel2)
        Panel2.BringToFront()
        AdministrationFormPanel.Enabled = False


    End Sub
 
    Private Sub AdministratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayToDataGrid("SELECT AdminId, Password,Question,Answer FROM AdminTbl ORDER BY AdminID", dgvAdmin)
        DataGridProperty(dgvAdmin)
        DataGridAdmin(dgvAdmin)
    End Sub

   
    
     

     
    Private Sub EditStudentButton_Click(sender As Object, e As EventArgs) Handles EditStudentButton.Click

        If dgvAdmin.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Admin To Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            EditAdmin = True

            NewAdminForm.AdminBox.Enabled = False
            NewAdminForm.MaterialCheckBox1.Checked = True
            NewAdminForm.PassBox.SelectAll()
            NewAdminForm.Label4.Text = "Edit Admin Account"
            Dim i As New Integer
            i = dgvAdmin.CurrentRow.Index
            AdID = dgvAdmin.Item("AdminID", i).Value.ToString()


            DisplayForm(NewAdminForm, Me.Panel2)
            Panel2.BringToFront()
            AdministrationFormPanel.Enabled = False

        End If

    End Sub

    

    Private Sub DeleteTile_Click(sender As Object, e As EventArgs) Handles DeleteTile.Click
        If dgvAdmin.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Admin To Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            Dim i As New Integer
            i = dgvAdmin.CurrentRow.Index
            AdID = dgvAdmin.Item("AdminID", i).Value.ToString()

            If DTTable("SELECT AdminID ", "AdminTbl", "").Rows.Count = 1 Then
                MetroFramework.MetroMessageBox.Show(MainForm, "Record cannot be deleted because it is currently the only registered user!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                If (AdID = MainForm.AdminName.Text) Then
                    MetroFramework.MetroMessageBox.Show(MainForm, "Active user account cannot be deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If (MetroFramework.MetroMessageBox.Show(MainForm, "This operation cannot be undone! Do you wish to continue?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes) Then

                        RecordRow("DELETE FROM AdminTbl WHERE AdminId='" & AdID & "'")
                        DisplayToDataGrid("SELECT * FROM AdminTbl ORDER BY AdminID", dgvAdmin)

                    End If
                End If
            End If
        End If


    End Sub

    Private Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click

    End Sub

    Private Sub SearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBox.KeyPress
        Try
            DisplayToDataGrid("SELECT * FROM AdminTbl WHERE AdminID LIKE '%" & SearchBox.Text & "%' or Password LIKE '%" & SearchBox.Text & "%' or Question LIKE '%" & SearchBox.Text & "%' or Answer LIKE '%" & SearchBox.Text & "%' ORDER BY AdminID", dgvAdmin)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchBox.Clear()
        DisplayToDataGrid("SELECT * FROM AdminTbl ORDER BY AdminID", dgvAdmin)

    End Sub
End Class