Public Class Login

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        If My.Settings.status = "aktif" Then
            Dim pegawai As New PegawaiClass
            If pegawai.login(UsernameText.Text, PasswordText.Text, sesi) = True Then
                FormObat.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Aplikasi belum terdaftar, harap menghubungi pembuat produk", "Register Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        'End

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            dbPath = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Register.ShowDialog()
        Register.Dispose()
    End Sub
End Class
