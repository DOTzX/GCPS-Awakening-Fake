Imports System.Runtime.InteropServices

Public Class FrmLogin
    Private mouseOffset As Point

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = My.Resources.preslog
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.hovlog
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.enalog
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Image = My.Resources.hovlog
    End Sub

    Private Sub PictureBox3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseClick
        PictureBox3.Image = My.Resources.presexit
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        PictureBox3.Image = My.Resources.presexit
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Image = My.Resources.hovexit
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.enaexit
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Image = My.Resources.hovexit
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Format(Now.Date, "ddMM") = "0204" Then
            MsgBox("Anda telah di troll ~" & vbCrLf & _
                   "Have fun, don't take it seriously :p" & vbCrLf & _
                   "Sudahi saja terima kenyataan ga ada Private Server di Indonesia." & vbCrLf &
                   "Kecuali ada orang yang benar benar ingin membuatnya dan menyediakan servernya sendiri." & vbCrLf & vbCrLf & _
                   "Julianto Chang beserta yang bersangkutan yang terlibat," & vbCrLf & _
                   "Memohon maaf sebesar-besarnya karena telah meng-troll kalian." & vbCrLf & vbCrLf & _
                   "File troll-an ini dapat kalian share untuk mengtroll teman anda - Free for Share~" & vbCrLf & vbCrLf & _
                   "Software sepenuhnya dibuat oleh : DOTX" & vbCrLf & "UI Patcher, Loading, dan Login Screen sepenuhnya dibuat oleh : Julianto Chang." & vbCrLf & vbCrLf & _
                   "Beri penilaianmu tentang kinerja trollan kami dengan mengirim pesan ke Julianto Chang (http://fb.me/juliantochang)" & vbCrLf & _
                   "Bagi yang sudah melihat pesan ini, mohon di rahasiakan ya... mohon kerja samanya~", vbExclamation, "")
        Else
            MsgBox("Fail Log-in.", vbExclamation, "")
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox4.Visible = False
        Label2.Visible = False
        Timer1.Enabled = False
    End Sub
End Class