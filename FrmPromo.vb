Imports System.Runtime.InteropServices

Public Class strfrmp

    Dim strUrl As String
    Dim urlz As String
    Dim urlz1 As String

    '=== Mute webbrowser (work) ===
    Private Const DISABLE_SOUNDS As Integer = 21
    Private Const SET_FEATURE_ON_PROCESS As Integer = 2
    <DllImport("urlmon.dll")> _
    Public Shared Function CoInternetSetFeatureEnabled( _
    ByVal FeatureEntry As Integer, <MarshalAs(UnmanagedType.U4)> ByVal dwFlags As Integer, ByVal fEnable As Boolean) As Integer
    End Function
    'Usage = CoInternetSetFeatureEnabled(DISABLE_SOUNDS, SET_FEATURE_ON_PROCESS, True)
    '=== Mute webbrowser (work) ===

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        strUrl = WebBrowser1.Url.ToString()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Private Sub FrmPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CoInternetSetFeatureEnabled(DISABLE_SOUNDS, SET_FEATURE_ON_PROCESS, True)

        urlz = "http://adf.ly/rSqvv"
        urlz1 = "http://dotxhugo.hol.es/403Forbidden.html"
        Dim wkt As Integer = DateTime.Now.Second
        If wkt >= 15 Then
            urlz = "http://adf.ly/1Gfqvf"
            urlz1 = "http://dotxhugo.hol.es/MancingMania-1.html"
        ElseIf wkt >= 30 Then
            urlz = "http://adf.ly/1GfrOP"
            urlz1 = "http://dotxhugo.hol.es/MancingMania-2.html"
        ElseIf wkt >= 45 Then
            urlz = "http://adf.ly/1GfrTl"
            urlz1 = "http://dotxhugo.hol.es/MancingMania-3.html"
        End If

        Timer1.Enabled = True
        Me.Visible = False
        WebBrowser1.Navigate(urlz)
        WebBrowser1.ScriptErrorsSuppressed = True
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If My.Computer.Network.IsAvailable = True Then
            If WebBrowser1.StatusText = "Done" Then
                If strUrl = urlz Then
                    Dim allelements As HtmlElementCollection = WebBrowser1.Document.All
                    For Each webpageelement As HtmlElement In allelements
                        If webpageelement.GetAttribute("id") = "skip_ad_button" Then
                            webpageelement.InvokeMember("click")
                        End If
                    Next
                End If
            End If
            If strUrl = urlz1 Then
                Label1.Text = "Done"
                Timer2.Enabled = False
            End If
        Else
            Timer2.Enabled = False
            MsgBox("No Internet Connection...", vbExclamation)
            End
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Hide()
        Me.Visible = False
        Timer3.Enabled = False
    End Sub
End Class