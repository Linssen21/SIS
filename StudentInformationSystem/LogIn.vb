Imports MaterialSkin
Imports System.Text.RegularExpressions


Public Class LogIn

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        MaximizeBox = False



        UsernameBox.SelectAll()

        '       Try
        'con.Open()
        'MsgBox("connected", MsgBoxStyle.Information)
        'Catch ex As Exception
        ' MsgBox(ex.Message.ToString)
        ' End Try
       




    End Sub


    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked = True Then
            PasswordBox.UseSystemPasswordChar = False
        Else
            PasswordBox.UseSystemPasswordChar = True

        End If
        

    End Sub

   

    Private Sub UsernameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameBox.KeyDown
        If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
            PasswordBox.Focus()
            PasswordBox.SelectAll()

        End If
    End Sub


     
   



    Private Sub UsernameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameBox.KeyPress

        'Don't Accepts Special Characters
        If Not (Char.IsLetterOrDigit(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(9) Then


            PasswordBox.Focus()
            SendKeys.Send("{TAB}")

        End If



    End Sub
    Private Sub PasswordBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordBox.KeyPress
        'Don't Accepts Special Characters
        If Not (Char.IsLetterOrDigit(e.KeyChar)) And e.KeyChar <> "-" And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            LoginButton_Click(Me, EventArgs.Empty)
        End If
        If e.KeyChar = Chr(9) Then

            UsernameBox.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub
   
   


  
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim uname As String, pword As String
        uname = Trim(UsernameBox.Text)
        pword = Trim(PasswordBox.Text)
        'If ((Not String.IsNullOrEmpty(uname)) Or (Not String.IsNullOrEmpty(pword)))
        If ((uname <> "") Or (pword <> "")) Then
            Dim uaDT As DataTable = DTTable("SELECT *", "AdminTbl", " WHERE (AdminID='" + uname + "') AND (Password='" + pword + "')")
            If (uaDT.Rows.Count = 1) Then
                userName = uaDT.Rows(0).Item(0).ToString()

                MainForm.Show()
                ForgotPForm.Close()
                Me.Hide()




                MainForm.AdminName.Text = userName
            Else
                MetroFramework.MetroMessageBox.Show(Me, "", "Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                UsernameBox.Clear()
                PasswordBox.Clear()
                UsernameBox.SelectAll()



            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UsernameBox.SelectAll()

        End If
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Application.Exit()

    End Sub

   


    

    Private Sub MaterialCheckBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialCheckBox1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            LoginButton_Click(Me, EventArgs.Empty)
        End If
    End Sub

  

   
   
    Private Sub FP_Click(sender As Object, e As EventArgs) Handles FP.Click
        ForgotPForm.Show()
    End Sub
End Class
