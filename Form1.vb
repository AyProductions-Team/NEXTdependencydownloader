Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If WebView21.CanGoBack() Then
            WebView21.GoBack()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uri As New Uri("https://www.github.com/search?q=" & TextBox1.Text)
        WebView21.Source = uri
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim uri As New Uri("https://www.github.com/search?q=" & TextBox1.Text)
            WebView21.Source = uri
        End If
    End Sub
End Class
