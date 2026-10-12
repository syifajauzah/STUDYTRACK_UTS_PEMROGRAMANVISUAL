Imports System.Windows

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiapkanData()
        TampilkanStatistik()
    End Sub

    Private Sub TampilkanStatistik()

        Dim total As Integer = TabelTugas.Rows.Count
        Dim selesai As Integer = 0
        Dim belumSelesai As Integer = 0

        For Each row As DataRow In TabelTugas.Rows
            If row("Status").ToString() = "Selesai" Then
                selesai += 1
            Else
                belumSelesai += 1
            End If
        Next

        lblTotalTugas.Text = total.ToString()
        lblSelesai.Text = selesai.ToString()
        lblBelumSelesai.Text = belumSelesai.ToString()

        If total > 0 Then
            ProgressBar1.Value = CInt((selesai / total) * 100)
        Else
            ProgressBar1.Value = 0
        End If

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TampilkanStatistik()
    End Sub

    Private Sub btnTugas_Click(sender As Object, e As EventArgs) Handles btnTugas.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwal_Click(sender As Object, e As EventArgs) Handles btnJadwal.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnPomodoro_Click(sender As Object, e As EventArgs) Handles btnPomodoro.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim jawaban As DialogResult

        jawaban = MessageBox.Show(
            "Apakah Anda yakin ingin logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TampilkanStatistik()
    End Sub

End Class