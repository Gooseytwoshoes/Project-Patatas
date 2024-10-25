Public Class Form2
    Public Sub revert()
        'revert back appearance
        txt_password.Visible = True
        lbl_password.Visible = True

        lbl_username.Text = "Username"
        btn_login.Text = "Login"
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If btn_login.Text = "Login" Then
            'modify appearance
            txt_password.Visible = False
            lbl_password.Visible = False

            lbl_username.Text = "Verification code"
            btn_login.Text = "Verify"
        Else
            revert()

            'pass parameter "OLD"
            Form3.Show()
            Form1.Hide()
            Close()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If btn_login.Text IsNot "Login" Then
            revert()
        End If
        Close()
    End Sub
End Class