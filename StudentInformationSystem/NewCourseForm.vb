Public Class NewCourseForm

    Dim coID, Ctitle, Old_coID As String


    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CourseForm.CoursesFormPanel.Enabled = True
        CourseForm.Panel2.SendToBack()
    End Sub

    
    Private Sub CoCancelButton_Click(sender As Object, e As EventArgs) Handles CoCancelButton.Click
        Button1.PerformClick()
    End Sub

    Private Sub NewCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseIDbox.SelectAll()
        Try
            If EditCourse = True Then
                Dim DT As DataTable = DTTable("SELECT * ", "CourseTbl", " WHERE CourseID='" & cID & "'")
                cID = CourseIDbox.Text
                CourseIDbox.Text = DT.Rows(0).Item("CourseID")
                CourseTitlebox.Text = DT.Rows(0).Item("Course")
                Old_coID = DT.Rows(0).Item("CourseID")
                CSave.Text = "Edit"
                CourseIDbox.Enabled = True


            End If
        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub CSave_Click(sender As Object, e As EventArgs) Handles CSave.Click
        coID = Trim(CourseIDbox.Text)
        Ctitle = Trim(CourseTitlebox.Text)


        If (coID <> "") And (Ctitle <> "") Then
            If EditCourse = False Then
                CourseIDbox.Enabled = True
                Try
                    'RecordRow("INSERT INTO AdminTbl (AdminId, Password) VALUES ('" & adminID & "', '" & Pass & "')")
                    RecordRow("INSERT INTO CourseTbl ([CourseID], [Course]) VALUES ('" & coID & "', '" & Ctitle & "');")

                    MetroFramework.MetroMessageBox.Show(MainForm, "Course Account Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                    CourseForm.CoursesFormPanel.Enabled = True
                    CourseForm.Panel2.SendToBack()

                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(MainForm, "Course ID Already Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CourseIDbox.Clear()
                    CourseTitlebox.Clear()
                    CourseIDbox.SelectAll()

                End Try
            Else

                Dim uaDT As DataTable = DTTable("SELECT CourseID", "CourseTbl", " WHERE (CourseID='" + coID + "') ")
                If (uaDT.Rows.Count >= 1) Then
                    MetroFramework.MetroMessageBox.Show(MainForm, "Course ID Already Exist " & vbNewLine & "Some of its Updated Data Will be Saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    RecordRow("UPDATE [CourseTbl] SET [Course]='" & Ctitle & "' WHERE ([CourseID]='" & coID & "')")

                    MetroFramework.MetroMessageBox.Show(MainForm, "Course Title was Succesfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.Close()
                    CourseForm.CoursesFormPanel.Enabled = True
                    CourseForm.Panel2.SendToBack()
                Else

                    RecordRow("UPDATE [CourseTbl] SET [Course]='" & Ctitle & "',[CourseID]='" & coID & "' WHERE ([CourseID]='" & Old_coID & "')")
                    RecordRow("UPDATE [StudentInfoTbl] SET [CourseID]='" & coID & "' WHERE ([CourseID]='" & Old_coID & "')")

                 
                    Me.Close()
                    CourseForm.CoursesFormPanel.Enabled = True
                    CourseForm.Panel2.SendToBack()
                End If



                End If
        Else
                MetroFramework.MetroMessageBox.Show(MainForm, "Fields Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CourseIDbox.SelectAll()


        End If
        DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl ORDER BY CourseID", CourseForm.dgvCourse)



    End Sub

    

 
    Private Sub CourseTitlebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseTitlebox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            CSave_Click(Me, EventArgs.Empty)
        End If
    End Sub

    

    Private Sub CourseIDbox_KeyDown(sender As Object, e As KeyEventArgs) Handles CourseIDbox.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CourseTitlebox.SelectAll()


        End If
    End Sub
End Class