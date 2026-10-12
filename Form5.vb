Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbHari.Items.Clear()
        cmbHari.Items.Add("Senin")
        cmbHari.Items.Add("Selasa")
        cmbHari.Items.Add("Rabu")
        cmbHari.Items.Add("Kamis")
        cmbHari.Items.Add("Jumat")
        cmbHari.Items.Add("Sabtu")
        cmbHari.Items.Add("Minggu")

        cmbHari.SelectedIndex = -1

        cmbMataKuliah.Items.Clear()
        cmbMataKuliah.Items.Add("Pemrograman Web")
        cmbMataKuliah.Items.Add("Database")
        cmbMataKuliah.Items.Add("Grafika Komputer")
        cmbMataKuliah.Items.Add("Kecerdasan Buatan")
        cmbMataKuliah.Items.Add("Matematika")

        cmbMataKuliah.SelectedIndex = -1

        dtpMulai.Format = DateTimePickerFormat.Time
        dtpMulai.ShowUpDown = True

        dtpSelesai.Format = DateTimePickerFormat.Time
        dtpSelesai.ShowUpDown = True

        dtpMulai.Value = Date.Today.AddHours(8)
        dtpSelesai.Value = Date.Today.AddHours(10)

        dgvJadwal.Columns.Clear()

        dgvJadwal.Columns.Add("Hari", "Hari")
        dgvJadwal.Columns.Add("MataKuliah", "Mata Kuliah")
        dgvJadwal.Columns.Add("JamMulai", "Jam Mulai")
        dgvJadwal.Columns.Add("JamSelesai", "Jam Selesai")

        dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJadwal.MultiSelect = False
        dgvJadwal.ReadOnly = True
        dgvJadwal.AllowUserToAddRows = False

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If cmbHari.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih hari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbMataKuliah.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih mata kuliah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpSelesai.Value <= dtpMulai.Value Then
            MessageBox.Show("Jam selesai harus lebih besar dari jam mulai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dgvJadwal.Rows.Add(
            cmbHari.Text,
            cmbMataKuliah.Text,
            dtpMulai.Value.ToString("HH:mm"),
            dtpSelesai.Value.ToString("HH:mm")
        )

        MessageBox.Show(
            "Jadwal berhasil ditambahkan.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        ResetInput()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If dgvJadwal.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Pilih jadwal yang ingin dihapus.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim jawaban As DialogResult

        jawaban = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus jadwal ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then
            dgvJadwal.Rows.RemoveAt(dgvJadwal.SelectedRows(0).Index)
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetInput()
    End Sub

    Private Sub ResetInput()

        cmbHari.SelectedIndex = -1
        cmbMataKuliah.SelectedIndex = -1

        dtpMulai.Value = Date.Today.AddHours(8)
        dtpSelesai.Value = Date.Today.AddHours(10)

        dgvJadwal.ClearSelection()

    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class