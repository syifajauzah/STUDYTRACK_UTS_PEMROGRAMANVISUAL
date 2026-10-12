<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        btnLogout = New Button()
        btnPomodoro = New Button()
        btnJadwal = New Button()
        btnTugas = New Button()
        btnDashboard = New Button()
        Panel2 = New Panel()
        lblSelesai = New Label()
        lblBelumSelesai = New Label()
        lblTotalTugas = New Label()
        StatusStrip1 = New StatusStrip()
        Label5 = New Label()
        ProgressBar1 = New ProgressBar()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnPomodoro)
        Panel1.Controls.Add(btnJadwal)
        Panel1.Controls.Add(btnTugas)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Location = New Point(23, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(253, 574)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(38, 410)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(169, 34)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnPomodoro
        ' 
        btnPomodoro.Location = New Point(38, 320)
        btnPomodoro.Name = "btnPomodoro"
        btnPomodoro.Size = New Size(169, 34)
        btnPomodoro.TabIndex = 4
        btnPomodoro.Text = "Pomodoro"
        btnPomodoro.UseVisualStyleBackColor = True
        ' 
        ' btnJadwal
        ' 
        btnJadwal.Location = New Point(38, 223)
        btnJadwal.Name = "btnJadwal"
        btnJadwal.Size = New Size(169, 34)
        btnJadwal.TabIndex = 3
        btnJadwal.Text = "Jadwal"
        btnJadwal.UseVisualStyleBackColor = True
        ' 
        ' btnTugas
        ' 
        btnTugas.Location = New Point(38, 130)
        btnTugas.Name = "btnTugas"
        btnTugas.Size = New Size(169, 34)
        btnTugas.TabIndex = 2
        btnTugas.Text = "Tugas"
        btnTugas.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(38, 45)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(169, 34)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblSelesai)
        Panel2.Controls.Add(lblBelumSelesai)
        Panel2.Controls.Add(lblTotalTugas)
        Panel2.Controls.Add(StatusStrip1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(294, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(619, 574)
        Panel2.TabIndex = 1
        ' 
        ' lblSelesai
        ' 
        lblSelesai.AutoSize = True
        lblSelesai.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelesai.Location = New Point(468, 161)
        lblSelesai.Name = "lblSelesai"
        lblSelesai.Size = New Size(79, 96)
        lblSelesai.TabIndex = 9
        lblSelesai.Text = "0"
        ' 
        ' lblBelumSelesai
        ' 
        lblBelumSelesai.AutoSize = True
        lblBelumSelesai.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBelumSelesai.Location = New Point(278, 161)
        lblBelumSelesai.Name = "lblBelumSelesai"
        lblBelumSelesai.Size = New Size(79, 96)
        lblBelumSelesai.TabIndex = 8
        lblBelumSelesai.Text = "0"
        ' 
        ' lblTotalTugas
        ' 
        lblTotalTugas.AutoSize = True
        lblTotalTugas.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalTugas.Location = New Point(64, 161)
        lblTotalTugas.Name = "lblTotalTugas"
        lblTotalTugas.Size = New Size(79, 96)
        lblTotalTugas.TabIndex = 7
        lblTotalTugas.Text = "0"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Location = New Point(0, 552)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(619, 22)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "Status: Login sebagai Mahasiswa"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 390)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 25)
        Label5.TabIndex = 5
        Label5.Text = "Progress Tugas"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(42, 455)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(261, 34)
        ProgressBar1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(482, 297)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 3
        Label4.Text = "Selesai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(253, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 2
        Label3.Text = "Belum Selesai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 297)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 1
        Label2.Text = "Total Tugas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 25)
        Label1.TabIndex = 0
        Label1.Text = "SELAMAT DATANG!"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(939, 610)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnPomodoro As Button
    Friend WithEvents btnJadwal As Button
    Friend WithEvents btnTugas As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblSelesai As Label
    Friend WithEvents lblBelumSelesai As Label
    Friend WithEvents lblTotalTugas As Label
End Class
