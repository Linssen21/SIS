Imports MetroFramework
Imports MaterialSkin
Public Class NewAdminForm
    Dim adminID, Pass, Ans, Que, Old_Pass, Old_ID As String

  

    Private Sub NewAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminBox.SelectAll()
        AdminBox.Enabled = True

        If EditAdmin = True Then
            Dim DT As DataTable = DTTable("SELECT * ", "AdminTbl", " WHERE AdminID='" & AdID & "'")
            AdID = AdminBox.Text
            AdminBox.Text = DT.Rows(0).Item("AdminID")
            PassBox.Text = DT.Rows(0).Item("Password")
            QuestionBox.Text = DT.Rows(0).Item("Question")
            AnswerBox.Text = DT.Rows(0).Item("Answer")
            AdminSaveButton.Text = "Edit"
            Old_Pass = DT.Rows(0).Item("Password")
            Old_ID = DT.Rows(0).Item("AdminID")
        End If


    End Sub



    Private Sub AdminSaveButton_Click(sender As Object, e As EventArgs) Handles AdminSaveButton.Click
        adminID = Trim(AdminBox.Text)
        Pass = Trim(PassBox.Text)
        Ans = Trim(AnswerBox.Text)
        Que = Trim(QuestionBox.Text)



        If (adminID <> "") And (Pass <> "") And (Ans <> "") And (Que <> "") Then
            If EditAdmin = False Then
                AdminBox.Enabled = True
                Try
                    'RecordRow("INSERT INTO AdminTbl (AdminId, Password) VALUES ('" & adminID & "', '" & Pass & "')")
                    RecordRow("INSERT INTO AdminTbl ([AdminID], [Password],[Question],[Answer]) VALUES ('" & adminID & "', '" & Pass & "', '" & Que & "', '" & Ans & "');")

                    MetroFramework.MetroMessageBox.Show(MainForm, "Admin Account Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.Close()
                    AdministratorForm.AdministrationFormPanel.Enabled = True
                    AdministratorForm.Panel2.SendToBack()

                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(MainForm, "Admin Username Already Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    AdminBox.Clear()
                    PassBox.Clear()
                    AdminBox.SelectAll()

                End Try
            Else
                Dim uaDT As DataTable = DTTable("SELECT AdminID", "AdminTbl", " WHERE (AdminID='" + adminID + "') ")
                If (uaDT.Rows.Count >= 1) Then
                    MetroFramework.MetroMessageBox.Show(MainForm, "Admin ID Already Exist " & vbNewLine & "Some of its Updated Data Will be Saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    RecordRow("UPDATE [AdminTbl] SET [Password]='" & Pass & "', [Question]='" & Que & "', [Answer]='" & Ans & "' WHERE ([AdminID]='" & adminID & "')")


                    Me.Close()
                    AdministratorForm.AdministrationFormPanel.Enabled = True
                    AdministratorForm.Panel2.SendToBack()
                Else

                    RecordRow("UPDATE [AdminTbl] SET [Password]='" & Pass & "', [AdminID]='" & adminID & "', [Question]='" & Que & "', [Answer]='" & Ans & "' WHERE ([AdminID]='" & Old_ID & "')")
                    Dim nid As String
                    nid = adminID
                    MetroFramework.MetroMessageBox.Show(MainForm, "Account was Succesfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.Close()
                    AdministratorForm.AdministrationFormPanel.Enabled = True
                    AdministratorForm.Panel2.SendToBack()
                    If (Old_ID = MainForm.AdminName.Text) Then
                        MainForm.AdminName.Text = adminID

                    End If

                End If







            End If
        Else
            MetroFramework.MetroMessageBox.Show(MainForm, "Fields Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AdminBox.SelectAll()


        End If
        DisplayToDataGrid("SELECT AdminId, Password,Question,Answer FROM AdminTbl ORDER BY AdminID", AdministratorForm.dgvAdmin)
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        AdministratorForm.AdministrationFormPanel.Enabled = True
        AdministratorForm.Panel2.SendToBack()
        'AdministratorForm.Close()

        'DisplayForm(AdministratorForm, HomeForm.HomeFormPanel)

    End Sub

   
    Private Sub AdmCancelButton_Click(sender As Object, e As EventArgs) Handles AdmCancelButton.Click
        Me.Close()
        AdministratorForm.AdministrationFormPanel.Enabled = True
        AdministratorForm.Panel2.SendToBack()
    End Sub

    

    Private Sub AdminBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AdminBox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            PassBox.SelectAll()

        End If
    End Sub

    Private Sub PassBox_Click(sender As Object, e As EventArgs) Handles PassBox.Click

    End Sub

    Private Sub PassBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PassBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            AdminSaveButton_Click(Me, EventArgs.Empty)

        End If
    End Sub

   
    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked = True Then
            PassBox.UseSystemPasswordChar = False
        Else
            PassBox.UseSystemPasswordChar = True

        End If
    End Sub
End Class