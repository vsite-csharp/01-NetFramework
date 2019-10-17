Public Class Form

    Private Sub ButtonGetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetTime.Click
        TextBoxTime.Text = ProvideTime.TimeProvider.GetDateTime("ime")
    End Sub
End Class
