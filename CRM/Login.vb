Public Class Login
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
