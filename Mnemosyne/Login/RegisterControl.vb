Public Class RegisterControl

    Public Event SwitchToLoginControl()

    Private UsernameInput As WatermarkTextBox
    Private PasswordInput As WatermarkTextBox
    Private EmailInput As WatermarkTextBox
    Private PhoneInput As WatermarkTextBox

    Private Sub TermsOfServiceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TermsOfServiceLinkLabel.LinkClicked
        ' TODO: Show an html page or a txt file with the terms of service in it.
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' if terms of service checkbox is not checked don't proceed
        ' else store everything in the credentials database?
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        RaiseEvent SwitchToLoginControl()
    End Sub

    Private Sub RegisterTableLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles RegisterTableLayoutPanel.Paint

        ' Remove Button Borders
        ReturnButton.FlatAppearance.BorderSize = 0
        RegisterButton.FlatAppearance.BorderSize = 0

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

        ' Add Email Watermark Text Box
        EmailInput = New WatermarkTextBox With {
            .Font = New Font("Montserrat Thin", 16, FontStyle.Regular, GraphicsUnit.Point),
            .WatermarkText = "email",
            .WaterMarkColor = Color.FromArgb(255, 235, 226, 218),
            .ForeColor = Color.FromArgb(255, 166, 144, 126),
            .BackColor = Color.FromArgb(255, 255, 251, 248),
            .TextAlign = HorizontalAlignment.Center,
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None,
            .CausesValidation = False
        }
        EmailTableLayoutPanel.Controls.Add(EmailInput, 1, 0)

        ' Add Phone Watermark Text Box
        PhoneInput = New WatermarkTextBox With {
            .Font = New Font("Montserrat Thin", 16, FontStyle.Regular, GraphicsUnit.Point),
            .WatermarkText = "phone",
            .WaterMarkColor = Color.FromArgb(255, 235, 226, 218),
            .ForeColor = Color.FromArgb(255, 166, 144, 126),
            .BackColor = Color.FromArgb(255, 255, 251, 248),
            .TextAlign = HorizontalAlignment.Center,
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None,
            .CausesValidation = False
        }
        PhoneTableLayoutPanel.Controls.Add(PhoneInput, 1, 0)

    End Sub

End Class