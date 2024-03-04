Imports CefSharp
Imports CefSharp.WinForms
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Client3
    Public WithEvents browser As ChromiumWebBrowser
    Public Sub New()


        InitializeComponent()




    End Sub

    Private Sub Client3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim DLMsg As New WebClient()
        Dim StatusX As String = DLMsg.DownloadString("https://pastebin.com/raw/DWFdLrpQ")
        DLL.Text = StatusX

        Dim setting As New CefSettings
        setting.RemoteDebuggingPort = 5473
        setting.CefCommandLineArgs.Add("enable-media-stream", "enable-media-stream")
        setting.CefCommandLineArgs.Add("renderer-process-limit", "1")

        Try
            CefSharp.Cef.Initialize(setting)
        Catch ex As Exception

        End Try
        browser = New ChromiumWebBrowser("https://discord.com/login")
        Panel1.Controls.Add(browser)

    End Sub

    Private Sub XVisualButton1_Click(sender As Object, e As EventArgs)

        browser.ExecuteScriptAsync(DLL.Text)
        browser.ExecuteScriptAsync(vbNewLine & vbNewLine & "login('" & TextBox1.Text & "')")
        Me.Text = TextBox1.Text

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Me.Height = 30 Then
            Me.Height = 500
        Else
            Me.Height = 30
        End If
    End Sub

End Class