Public Class LoginControl

    Public Event SwitchToRegisterControl()

    Private UsernameInput As WatermarkTextBox
    Private PasswordInput As WatermarkTextBox

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' TODO: ...
        'Credentials.Submit(UsernameInput.Text, PasswordInput.Text)
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        RaiseEvent SwitchToRegisterControl()
    End Sub

    Private Sub RecoverButton_Click(sender As Object, e As EventArgs) Handles RecoverButton.Click

    End Sub

    Private Sub LoginTableLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginTableLayoutPanel.Paint

        ' Remove Button Borders
        LoginButton.FlatAppearance.BorderSize = 0
        RegisterButton.FlatAppearance.BorderSize = 0
        RecoverButton.FlatAppearance.BorderSize = 0

        ' Add Username Watermark Text Box
        UsernameInput = New WatermarkTextBox With {
            .Font = New Font("Montserrat Thin", 16, FontStyle.Regular, GraphicsUnit.Point),
            .WatermarkText = "username",
            .WaterMarkColor = Color.FromArgb(255, 235, 226, 218),
            .ForeColor = Color.FromArgb(255, 166, 144, 126),
            .BackColor = Color.FromArgb(255, 255, 251, 248),
            .TextAlign = HorizontalAlignment.Center,
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None,
            .CausesValidation = False
        }
        UsernameTableLayoutPanel.Controls.Add(UsernameInput, 1, 0)

        ' Add Password Watermark Text Box
        PasswordInput = New WatermarkTextBox With {
          .Font = New Font("Montserrat Thin", 16, FontStyle.Regular, GraphicsUnit.Point),
          .WatermarkText = "password",
          .WaterMarkColor = Color.FromArgb(255, 235, 226, 218),
          .ForeColor = Color.FromArgb(255, 166, 144, 126),
          .BackColor = Color.FromArgb(255, 255, 251, 248),
          .TextAlign = HorizontalAlignment.Center,
          .Dock = DockStyle.Fill,
          .BorderStyle = BorderStyle.None,
          .PasswordChar = "*",
          .CausesValidation = False
        }
        PasswordTableLayoutPanel.Controls.Add(PasswordInput, 1, 0)

    End Sub

End Class