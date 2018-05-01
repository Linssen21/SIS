Imports MetroFramework
Imports MaterialSkin
Public Class MainForm

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey400, Primary.BlueGrey500, Primary.BlueGrey700, Accent.LightBlue200, TextShade.WHITE)
        DisplayForm(HomeForm, MainPnl)
        UserId = AdminName.Text


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to terminate the system?", "Terminate System", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            'Application.Exit()
            Application.[Exit]()
        Else
            Exit Sub
        End If

    End Sub

    
   
   

   
  
    
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   

    Public Sub MainPnl_Paint(sender As Object, e As PaintEventArgs) Handles MainPnl.Paint

    End Sub

    Private Sub LogOutBut_Click(sender As Object, e As EventArgs) Handles LogOutBut.Click


        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Application.Restart()
        Else
            Exit Sub
        End If


    End Sub
End Class