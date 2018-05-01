Public Class CourseForm

   
   
    Private Sub AddTile_Click(sender As Object, e As EventArgs) Handles AddTile.Click
        DisplayForm(NewCourseForm, Me.Panel2)
        Panel2.BringToFront()
        CoursesFormPanel.Enabled = False
        EditCourse = False
        NewCourseForm.CourseIDbox.Enabled = True

        Panel2.BringToFront()

    End Sub

    Private Sub HomeTile_Click(sender As Object, e As EventArgs) Handles HomeTile.Click
        Me.Close()
        DisplayForm(HomeForm, MainForm.MainPnl)
    End Sub

     

    Private Sub EditStudentButton_Click(sender As Object, e As EventArgs) Handles EditStudentButton.Click
        If dgvCourse.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Course To Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            EditCourse = True

            NewCourseForm.CourseIDbox.Enabled = False

            NewCourseForm.CourseTitlebox.SelectAll()
            NewCourseForm.Label4.Text = "Edit Course Title"
            Dim i As New Integer
            i = dgvCourse.CurrentRow.Index
            cID = dgvCourse.Item("CourseID", i).Value.ToString()


            DisplayForm(NewCourseForm, Me.Panel2)
            Panel2.BringToFront()
            CoursesFormPanel.Enabled = False
        End If
    End Sub

    Private Sub DeleteTile_Click(sender As Object, e As EventArgs) Handles DeleteTile.Click
        If dgvCourse.Rows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(MainForm, "There is no Course To Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearButton.PerformClick()
        Else
            Dim i As New Integer
            i = dgvCourse.CurrentRow.Index
            cID = dgvCourse.Item("CourseID", i).Value.ToString()
            If DTTable("SELECT * ", "StudentInfoTbl", " WHERE CourseID='" & cID & "'").Rows.Count > 0 Then
                MetroFramework.MetroMessageBox.Show(MainForm, "The Course cannot be Deleted, because there are still Students enrolled in it!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                If MetroFramework.MetroMessageBox.Show(MainForm, "The operation cannot be undone! Continue?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    RecordRow("DELETE FROM [CourseTbl] WHERE [CourseID]='" & cID & "'")
                    DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl ORDER BY courseID", dgvCourse)


                End If

            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl ORDER BY courseID", dgvCourse)
        DataGridProperty(dgvCourse)
    End Sub

 

    Private Sub SearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBox.KeyPress


        Try
            DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl WHERE CourseID LIKE '%" & SearchBox.Text & "%' or Course LIKE '%" & SearchBox.Text & "%' ORDER BY CourseID", dgvCourse)
            DataGridProperty(dgvCourse)


         
        Catch ex As Exception

        End Try
       


    End Sub

     

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayToDataGrid("SELECT CourseID, Course FROM CourseTbl ORDER BY courseID", dgvCourse)
        DataGridProperty(dgvCourse)
        SearchBox.Clear()
    End Sub

    Private Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click

    End Sub
End Class