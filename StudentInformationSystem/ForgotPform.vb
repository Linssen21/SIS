Imports MaterialSkin
Imports System.Text.RegularExpressions

Public Class ForgotPForm
    Dim Adminname, Ques, Ans As String

    Private Sub ForgotPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        MaximizeBox = False
        QuestionLabel.Text = ""
        UsernameBox.SelectAll()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        'Search User
        Adminname = Trim(UsernameBox.Text)
        Ans = Trim(AnswerBox.Text)
        If (Adminname <> "") Then
            Dim uaDT As DataTable = DTTable("SELECT *", "AdminTbl", " WHERE (AdminID='" + Adminname + "') ")
            If (uaDT.Rows.Count = 1) Then
                QuestionLabel.Text = uaDT.Rows(0).Item(2).ToString()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "", "User Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                QuestionLabel.Text = ""
                UsernameBox.Clear()
                UsernameBox.SelectAll()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "", "Please insert yout Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            UsernameBox.SelectAll()


        End If

    End Sub

    Private Sub FpLoginButton_Click(sender As Object, e As EventArgs) Handles FpLoginButton.Click
        Adminname = Trim(UsernameBox.Text)
        Ans = Trim(AnswerBox.Text)
        If ((Adminname <> "") Or (Ans <> "")) Then
            Dim uaDT As DataTable = DTTable("SELECT *", "AdminTbl", " WHERE (AdminID='" + Adminname + "') AND (Answer='" + Ans + "') ")
            If (uaDT.Rows.Count = 1) Then
                MetroFramework.MetroMessageBox.Show(Me, "", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                MainForm.Show()
                Me.Close()
                LogIn.Hide()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "", "Admin ID and Answer Does not Match", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                AnswerBox.Clear()
                AnswerBox.SelectAll()
            End If

        Else
            MetroFramework.MetroMessageBox.Show(Me, "", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub AdmCancelButton_Click(sender As Object, e As EventArgs) Handles AdmCancelButton.Click
        Me.Close()
    End Sub

    Private Sub UsernameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event

            AnswerBox.SelectAll()
            MaterialRaisedButton1_Click(Me, EventArgs.Empty)

        End If
    End Sub

    Private Sub AnswerBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AnswerBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
             
            FpLoginButton_Click(Me, EventArgs.Empty)

        End If
    End Sub
End Class