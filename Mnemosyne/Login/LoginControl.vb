Public Class LoginControl

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

    End Sub

    Private Sub RecoverButton_Click(sender As Object, e As EventArgs) Handles RecoverButton.Click

    End Sub

    Private Sub LoginTableLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginTableLayoutPanel.Paint
        LoginButton.FlatAppearance.BorderSize = 0
        RegisterButton.FlatAppearance.BorderSize = 0
        RecoverButton.FlatAppearance.BorderSize = 0
    End Sub

End Class