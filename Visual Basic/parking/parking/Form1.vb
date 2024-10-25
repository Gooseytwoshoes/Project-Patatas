Public Class Form1
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        'pass parameter as "NEW"
        Form3.Show()
    End Sub

    Private Sub btn_old_Click(sender As Object, e As EventArgs) Handles btn_old.Click
        'go to login page (Form2) to pass parameter "OLD"
        Form2.Show()
    End Sub
End Class
