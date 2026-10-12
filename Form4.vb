Public Class Form4

    Private waktuTersisa As Integer = 25 * 60
    Private sesiKe As Integer = 1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()

        For Each row As DataRow In TabelTugas.Rows
            ComboBox1.Items.Add(row("Nama Tugas").ToString())
        Next

        ComboBox1.SelectedIndex = -1

        Timer1.Interval = 1000
        Timer1.Enabled = False

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 25 * 60
        ProgressBar1.Value = 25 * 60

        lblTimer.Text = "25:00"

        GroupBox1.Text = "Status Sesi"

        NotifyIcon1.Visible = True
        NotifyIcon1.Text = "Student Productivity - Pomodoro"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tugas terlebih dahulu.", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Timer1.Stop()

        waktuTersisa = 25 * 60

        lblTimer.Text = "25:00"

        ProgressBar1.Value = ProgressBar1.Maximum

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If waktuTersisa > 0 Then

            waktuTersisa -= 1

            Dim menit As Integer = waktuTersisa \ 60
            Dim detik As Integer = waktuTersisa Mod 60

            lblTimer.Text = menit.ToString("00") & ":" & detik.ToString("00")

            ProgressBar1.Value = waktuTersisa

        Else

            Timer1.Stop()

            NotifyIcon1.BalloonTipTitle = "Pomodoro selesai!"
            NotifyIcon1.BalloonTipText = "Waktu fokus selesai. Saatnya istirahat."
            NotifyIcon1.ShowBalloonTip(5000)

            MessageBox.Show(
                "Waktu Pomodoro selesai!" & vbCrLf &
                "Saatnya istirahat.",
                "Pomodoro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class