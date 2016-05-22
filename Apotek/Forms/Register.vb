Public Class Register

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "hello" Then
            My.Settings.status = "aktif"
            My.Settings.Save()
        End If

        If My.Settings.status = "aktif" Then
            MessageBox.Show("Aplikasi telah berganti status menjadi Aktif", "Aktifasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If

    End Sub
End Class