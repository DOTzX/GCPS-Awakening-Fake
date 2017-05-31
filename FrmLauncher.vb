Imports System.Net

Public Class FrmLauncher
    Private mouseOffset As Point

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label12.Text = "Checking Latest Version...."
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label3.Visible = True
        Label12.Text = "Checking File GCID Location...."
        Timer2.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label12.Text = "Checking File...."
        Timer4.Enabled = False
        Timer5.Enabled = True
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label12.Text = "Download Micro File...."
        Timer3.Enabled = True
        Timer5.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label4.Text = "10.0.0.0"
        Label12.Text = "All Complete."
        Label11.Text = "100%"
        Label13.Text = "100%"
        PictureBox1.Width = 402
        PictureBox2.Width = 402
        pNormal.Visible = True
        pNotNormal.Visible = False
        pNormal.Image = My.Resources.enable
        Timer3.Enabled = False
    End Sub

    Private Sub pNormal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pNormal.Click
        Me.Hide()
        FrmGG.Show()
    End Sub

    Private Sub pNormal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pNormal.MouseDown
        pNormal.Image = My.Resources.pressed
    End Sub

    Private Sub pNormal_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pNormal.MouseHover
        pNormal.Image = My.Resources.hover
    End Sub

    Private Sub pNormal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pNormal.MouseLeave
        pNormal.Image = My.Resources.enable
    End Sub

    Private Sub pNormal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pNormal.MouseMove
        pNormal.Image = My.Resources.hover
    End Sub

    Private Sub pNormal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pNormal.MouseUp
        pNormal.Image = My.Resources.hover
    End Sub

    Private Sub Label14_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Label14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

End Class
