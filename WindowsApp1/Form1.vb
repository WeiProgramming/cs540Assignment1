Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles greetingLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles usaPictureBox.Click
        greetingLabel.Text = "Good Day!"
        exitButton.Text = "Exit"
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub belarusPictureBox_Click(sender As Object, e As EventArgs) Handles belarusPictureBox.Click
        greetingLabel.Text = "Добры дзень"
        exitButton.Text = "выхад"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub
End Class
