Public Class registration
    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowsePic.Click

        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "C:\"
        ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Login.Show()
    End Sub
End Class