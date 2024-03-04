Public Class Clients
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub XVisualButton1_Click(sender As Object, e As EventArgs) Handles XVisualButton1.Click
        Client1.Show()
    End Sub

    Private Sub XVisualButton2_Click(sender As Object, e As EventArgs) Handles XVisualButton2.Click
        Client2.Show()
    End Sub

    Private Sub XVisualButton8_Click(sender As Object, e As EventArgs) Handles XVisualButton8.Click
        Client3.Show()
    End Sub

    Private Sub XVisualButton7_Click(sender As Object, e As EventArgs) Handles XVisualButton7.Click
        Client4.Show()
    End Sub
    Private Sub XVisualButton5_Click(sender As Object, e As EventArgs) Handles XVisualButton5.Click
        Client5.Show()
    End Sub

    Private Sub XVisualButton6_Click(sender As Object, e As EventArgs) Handles XVisualButton6.Click
        Client6.Show()
    End Sub

    Private Sub XVisualButton4_Click(sender As Object, e As EventArgs) Handles XVisualButton4.Click
        Client7.Show()
    End Sub

    Private Sub XVisualButton3_Click(sender As Object, e As EventArgs) Handles XVisualButton3.Click
        Client8.Show()
    End Sub

    Private Sub T_CheckedChanged(sender As Object) Handles T.CheckedChanged
        If T.Checked = True Then

            Client1.TopMost = True
            Client2.TopMost = True
            Client3.TopMost = True
            Client4.TopMost = True
            Client5.TopMost = True
            Client6.TopMost = True
            Client7.TopMost = True
            Client8.TopMost = True
        Else
            Client1.TopMost = False
            Client2.TopMost = False
            Client3.TopMost = False
            Client4.TopMost = False
            Client5.TopMost = False
            Client6.TopMost = False
            Client7.TopMost = False
            Client8.TopMost = False
        End If
    End Sub

    Private Sub M_CheckedChanged(sender As Object) Handles M.CheckedChanged
        If M.Checked = True Then

            Client1.WindowState = FormWindowState.Minimized
            Client2.WindowState = FormWindowState.Minimized
            Client3.WindowState = FormWindowState.Minimized
            Client4.WindowState = FormWindowState.Minimized
            Client5.WindowState = FormWindowState.Minimized
            Client6.WindowState = FormWindowState.Minimized
            Client7.WindowState = FormWindowState.Minimized
            Client8.WindowState = FormWindowState.Minimized

            Client1.ShowInTaskbar = False
            Client2.ShowInTaskbar = False
            Client3.ShowInTaskbar = False
            Client4.ShowInTaskbar = False
            Client5.ShowInTaskbar = False
            Client6.ShowInTaskbar = False
            Client7.ShowInTaskbar = False
            Client8.ShowInTaskbar = False
        Else
            Client1.WindowState = FormWindowState.Normal
            Client2.WindowState = FormWindowState.Normal
            Client3.WindowState = FormWindowState.Normal
            Client4.WindowState = FormWindowState.Normal
            Client5.WindowState = FormWindowState.Normal
            Client6.WindowState = FormWindowState.Normal
            Client7.WindowState = FormWindowState.Normal
            Client8.WindowState = FormWindowState.Normal

            Client1.ShowInTaskbar = True
            Client2.ShowInTaskbar = True
            Client3.ShowInTaskbar = True
            Client4.ShowInTaskbar = True
            Client5.ShowInTaskbar = True
            Client6.ShowInTaskbar = True
            Client7.ShowInTaskbar = True
            Client8.ShowInTaskbar = True
        End If
    End Sub
End Class