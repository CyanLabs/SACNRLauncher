Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", "Player1")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", TextBox1.Text)
        Process.Start(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing).Replace("gta_sa.exe", "samp.exe"), "server.sacnr.com:7777")
    End Sub
End Class
