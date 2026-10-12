<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        lblTimer = New Label()
        btnKembali = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(240, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 25)
        Label1.TabIndex = 0
        Label1.Text = "PODOMORO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 1
        Label2.Text = "Tugas"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(49, 108)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(219, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(49, 278)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(416, 34)
        ProgressBar1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(49, 335)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "Mulai"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(193, 335)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 6
        Button2.Text = "Pause"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(340, 335)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 7
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(287, 108)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(178, 144)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(49, 400)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(416, 170)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Status Sesi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 25)
        Label5.TabIndex = 2
        Label5.Text = "Istirahat: 5 menit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 25)
        Label4.TabIndex = 1
        Label4.Text = "Fokus: 25 menit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 0
        Label3.Text = "Sesi ke-1"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimer.Location = New Point(75, 168)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(164, 74)
        lblTimer.TabIndex = 10
        lblTimer.Text = "25:00"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(491, 536)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 34)
        btnKembali.TabIndex = 11
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 597)
        Controls.Add(btnKembali)
        Controls.Add(lblTimer)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKembali As Button
End Class
