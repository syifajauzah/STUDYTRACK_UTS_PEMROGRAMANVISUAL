Public Class Form3

    Private IDTerpilih As Integer = -1

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SiapkanData()

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Pemrograman Web")
        ComboBox1.Items.Add("Database")
        ComboBox1.Items.Add("Grafika Komputer")
        ComboBox1.Items.Add("Kecerdasan Buatan")
        ComboBox1.Items.Add("Matematika")
        ComboBox1.SelectedIndex = -1

        DateTimePicker1.Value = Date.Today

        DataGridView1.DataSource = TabelTugas
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False

        ToolTip1.SetToolTip(Button1, "Menambahkan tugas baru")
        ToolTip1.SetToolTip(Button2, "Mengubah tugas yang dipilih")
        ToolTip1.SetToolTip(Button3, "Menghapus tugas yang dipilih")
        ToolTip1.SetToolTip(Button4, "Mengosongkan input")
        ToolTip1.SetToolTip(Button5, "Mencari tugas")

    End Sub

    Private Function AmbilPrioritas() As String

        If RadioButton1.Checked Then
            Return "Rendah"
        ElseIf RadioButton2.Checked Then
            Return "Sedang"
        ElseIf RadioButton3.Checked Then
            Return "Tinggi"
        End If

        Return ""

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ErrorProvider1.Clear()

        If TextBox1.Text.Trim() = "" Then
            ErrorProvider1.SetError(TextBox1, "Nama tugas harus diisi.")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Pilih mata kuliah.")
            Exit Sub
        End If

        If AmbilPrioritas() = "" Then
            ErrorProvider1.SetError(GroupBox1, "Pilih prioritas.")
            Exit Sub
        End If

        Dim idBaru As Integer = 1

        If TabelTugas.Rows.Count > 0 Then
            idBaru = CInt(TabelTugas.Compute("MAX(ID)", "")) + 1
        End If

        TabelTugas.Rows.Add(
            idBaru,
            TextBox1.Text.Trim(),
            ComboBox1.Text,
            DateTimePicker1.Value.Date,
            AmbilPrioritas(),
            RichTextBox1.Text,
            "Belum Selesai"
        )

        MessageBox.Show(
            "Tugas berhasil ditambahkan.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        BersihkanInput()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ErrorProvider1.Clear()

        If IDTerpilih = -1 Then
            MessageBox.Show(
                "Pilih tugas yang ingin diedit terlebih dahulu.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        If TextBox1.Text.Trim() = "" Then
            ErrorProvider1.SetError(TextBox1, "Nama tugas harus diisi.")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Pilih mata kuliah.")
            Exit Sub
        End If

        If AmbilPrioritas() = "" Then
            ErrorProvider1.SetError(GroupBox1, "Pilih prioritas.")
            Exit Sub
        End If

        Dim rows() As DataRow = TabelTugas.Select("ID = " & IDTerpilih)

        If rows.Length > 0 Then

            rows(0)("Nama Tugas") = TextBox1.Text.Trim()
            rows(0)("Mata Kuliah") = ComboBox1.Text
            rows(0)("Deadline") = DateTimePicker1.Value.Date
            rows(0)("Prioritas") = AmbilPrioritas()
            rows(0)("Catatan") = RichTextBox1.Text

            MessageBox.Show(
                "Tugas berhasil diperbarui.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Else

            MessageBox.Show(
                "Data tugas tidak ditemukan.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        End If

        BersihkanInput()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If IDTerpilih = -1 Then
            MessageBox.Show(
                "Pilih tugas yang ingin dihapus terlebih dahulu.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim jawaban As DialogResult

        jawaban = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus tugas ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then

            Dim rows() As DataRow = TabelTugas.Select("ID = " & IDTerpilih)

            If rows.Length > 0 Then
                TabelTugas.Rows.Remove(rows(0))
            End If

            MessageBox.Show(
                "Tugas berhasil dihapus.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            BersihkanInput()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        BersihkanInput()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim kata As String = TextBox2.Text.Trim().ToLower()

        If kata = "" Then

            DataGridView1.DataSource = TabelTugas
            DataGridView1.ClearSelection()
            Exit Sub

        End If

        Dim hasil As DataTable = TabelTugas.Clone()

        For Each row As DataRow In TabelTugas.Rows

            If row("Nama Tugas").ToString().ToLower().Contains(kata) OrElse
               row("Mata Kuliah").ToString().ToLower().Contains(kata) Then

                hasil.ImportRow(row)

            End If

        Next

        DataGridView1.DataSource = hasil
        DataGridView1.ClearSelection()

        If hasil.Rows.Count = 0 Then

            MessageBox.Show(
                "Tugas tidak ditemukan.",
                "Pencarian",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DataGridView1.Rows(e.RowIndex).Cells("ID").Value Is Nothing Then
            Exit Sub
        End If

        IDTerpilih = CInt(DataGridView1.Rows(e.RowIndex).Cells("ID").Value)

        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("Nama Tugas").Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("Mata Kuliah").Value.ToString()
        DateTimePicker1.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells("Deadline").Value)
        RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells("Catatan").Value.ToString()

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        Select Case DataGridView1.Rows(e.RowIndex).Cells("Prioritas").Value.ToString()

            Case "Rendah"
                RadioButton1.Checked = True

            Case "Sedang"
                RadioButton2.Checked = True

            Case "Tinggi"
                RadioButton3.Checked = True

        End Select

    End Sub

    Private Sub BersihkanInput()

        TextBox1.Clear()

        ComboBox1.SelectedIndex = -1

        DateTimePicker1.Value = Date.Today

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        RichTextBox1.Clear()

        TextBox2.Clear()

        IDTerpilih = -1

        ErrorProvider1.Clear()

        DataGridView1.DataSource = TabelTugas
        DataGridView1.ClearSelection()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        If DataGridView1.SelectedRows.Count = 0 Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

        Form2.Show()
        Me.Hide()

    End Sub

End Class