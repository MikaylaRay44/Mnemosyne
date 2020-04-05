Public Class Main

    Private Login As LoginControl
    Private Register As RegisterControl

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Login = New LoginControl()
        Register = New RegisterControl()

        AddHandler Login.SwitchToRegisterControl, AddressOf SwitchToRegisterControl
        AddHandler Register.SwitchToLoginControl, AddressOf SwitchToLoginControl

        SwitchToLoginControl()

    End Sub

    Private Sub SwitchToRegisterControl()
        MainPanel.SuspendLayout()
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(Register)
        MainPanel.ResumeLayout()
    End Sub

    Private Sub SwitchToLoginControl()
        MainPanel.SuspendLayout()
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(Login)
        MainPanel.ResumeLayout()
    End Sub

End Class