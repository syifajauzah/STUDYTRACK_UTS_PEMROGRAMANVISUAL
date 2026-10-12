<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label5 = New Label()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolTip1 = New ToolTip(components)
        ErrorProvider1 = New ErrorProvider(components)
        btnKembali = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(233, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 25)
        Label1.TabIndex = 0
        Label1.Text = "KELOLA TUGASMU!!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Tugas"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(194, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(401, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 3
        Label3.Text = "Mata Kuliah"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(194, 148)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(401, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 25)
        Label4.TabIndex = 5
        Label4.Text = "Deadline"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(194, 213)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(401, 31)
        DateTimePicker1.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(64, 262)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(540, 130)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Prioritas"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(428, 63)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(86, 29)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tinggi"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(219, 63)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Sedang"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(15, 63)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(96, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Rendah"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(64, 408)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 8
        Label5.Text = "Catatan"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(64, 436)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(540, 43)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(64, 496)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 10
        Button1.Text = "Tambah "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(211, 496)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 11
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(347, 496)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 12
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(492, 496)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 13
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 571)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 25)
        Label6.TabIndex = 14
        Label6.Text = "Cari"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(131, 565)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(328, 31)
        TextBox2.TabIndex = 15
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(492, 566)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 16
        Button5.Text = "Cari"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(64, 632)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(540, 145)
        DataGridView1.TabIndex = 17
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(64, 25)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 34)
        btnKembali.TabIndex = 18
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(640, 808)
        Controls.Add(btnKembali)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKembali As Button
End Class
