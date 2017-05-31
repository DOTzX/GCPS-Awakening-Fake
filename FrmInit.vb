Public Class FrmInit

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        FrmLauncher.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Enabled = False
        If My.Computer.Network.IsAvailable = True Then
            Dim xDate As String = Format(Now.Date, "yyyMMdd")
            If xDate >= "20140402" Then
                Timer1.Enabled = True
                strfrmp.Show()
            Else
                MsgBox("Please wait on April 2nd, 2014.", vbExclamation, "")
                End
            End If
        Else
            MsgBox("No Internet Connection...", vbExclamation)
            End
        End If

    End Sub

End Class