<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnTambah = New Button()
        btnHapus = New Button()
        btnReset = New Button()
        cmbHari = New ComboBox()
        cmbMataKuliah = New ComboBox()
        dtpMulai = New DateTimePicker()
        dtpSelesai = New DateTimePicker()
        dgvJadwal = New DataGridView()
        btnKembali = New Button()
        CType(dgvJadwal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(337, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 25)
        Label1.TabIndex = 0
        Label1.Text = "JADWAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 25)
        Label2.TabIndex = 1
        Label2.Text = "Hari"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 2
        Label3.Text = "Mata Kuliah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 3
        Label4.Text = "Jam Mulai"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(38, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 25)
        Label5.TabIndex = 4
        Label5.Text = "Jam Selesai"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(182, 324)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(328, 324)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(473, 324)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' cmbHari
        ' 
        cmbHari.FormattingEnabled = True
        cmbHari.Location = New Point(182, 97)
        cmbHari.Name = "cmbHari"
        cmbHari.Size = New Size(403, 33)
        cmbHari.TabIndex = 8
        ' 
        ' cmbMataKuliah
        ' 
        cmbMataKuliah.FormattingEnabled = True
        cmbMataKuliah.Location = New Point(182, 161)
        cmbMataKuliah.Name = "cmbMataKuliah"
        cmbMataKuliah.Size = New Size(403, 33)
        cmbMataKuliah.TabIndex = 9
        ' 
        ' dtpMulai
        ' 
        dtpMulai.Format = DateTimePickerFormat.Time
        dtpMulai.Location = New Point(182, 221)
        dtpMulai.Name = "dtpMulai"
        dtpMulai.ShowUpDown = True
        dtpMulai.Size = New Size(403, 31)
        dtpMulai.TabIndex = 10
        ' 
        ' dtpSelesai
        ' 
        dtpSelesai.Format = DateTimePickerFormat.Time
        dtpSelesai.Location = New Point(182, 276)
        dtpSelesai.Name = "dtpSelesai"
        dtpSelesai.ShowUpDown = True
        dtpSelesai.Size = New Size(403, 31)
        dtpSelesai.TabIndex = 11
        ' 
        ' dgvJadwal
        ' 
        dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJadwal.Location = New Point(38, 374)
        dgvJadwal.Name = "dgvJadwal"
        dgvJadwal.RowHeadersWidth = 62
        dgvJadwal.Size = New Size(547, 125)
        dgvJadwal.TabIndex = 12
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(473, 527)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 34)
        btnKembali.TabIndex = 13
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(668, 628)
        Controls.Add(btnKembali)
        Controls.Add(dgvJadwal)
        Controls.Add(dtpSelesai)
        Controls.Add(dtpMulai)
        Controls.Add(cmbMataKuliah)
        Controls.Add(cmbHari)
        Controls.Add(btnReset)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        CType(dgvJadwal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents dtpSelesai As DateTimePicker
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents btnKembali As Button
End Class
