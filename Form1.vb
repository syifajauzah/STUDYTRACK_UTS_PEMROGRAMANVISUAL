Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiapkanData()

        MaskedTextBox1.PasswordChar = "*"c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ErrorProvider1.Clear()

        If TextBox1.Text.Trim() = "" Then
            ErrorProvider1.SetError(TextBox1, "Username harus diisi")
            Exit Sub
        End If

        If MaskedTextBox1.Text.Trim() = "" Then
            ErrorProvider1.SetError(MaskedTextBox1, "Password harus diisi")
            Exit Sub
        End If

        If TextBox1.Text = "admin" AndAlso MaskedTextBox1.Text = "12345" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


End Class
