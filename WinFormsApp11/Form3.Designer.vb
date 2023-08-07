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
        TextBox6 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(414, 381)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(178, 31)
        TextBox6.TabIndex = 43
        TextBox6.Text = "Filter Dokter"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(320, 145)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(57, 33)
        ComboBox2.TabIndex = 41
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(257, 146)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(57, 33)
        ComboBox1.TabIndex = 40
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(251, 227)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(126, 29)
        RadioButton2.TabIndex = 39
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(145, 227)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(100, 29)
        RadioButton1.TabIndex = 38
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(145, 262)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(232, 31)
        TextBox5.TabIndex = 37
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(145, 189)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(232, 31)
        TextBox4.TabIndex = 36
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(145, 146)
        TextBox3.MaxLength = 4
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(106, 31)
        TextBox3.TabIndex = 35
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(145, 105)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 31)
        TextBox2.TabIndex = 34
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 31)
        TextBox1.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 262)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 25)
        Label7.TabIndex = 32
        Label7.Text = "Spesifikasi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 25)
        Label6.TabIndex = 31
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 25)
        Label5.TabIndex = 30
        Label5.Text = "Tempat Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 29
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 25)
        Label3.TabIndex = 28
        Label3.Text = "NIK (No. KTP)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 25)
        Label2.TabIndex = 27
        Label2.Text = "Nama Lengkap"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(589, 25)
        Label1.TabIndex = 26
        Label1.Text = "Dikembangkan Oleh: D3 Teknik Informatika - Politeknik Negeri Semarang" & vbCrLf
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(719, 379)
        Button4.Name = "Button4"
        Button4.Size = New Size(74, 34)
        Button4.TabIndex = 25
        Button4.Text = "Hapus"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(648, 379)
        Button3.Name = "Button3"
        Button3.Size = New Size(65, 34)
        Button3.TabIndex = 24
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(145, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 34)
        Button2.TabIndex = 23
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(8, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 22
        Button1.Text = "<< Kembali "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(414, 64)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(379, 284)
        ListView1.TabIndex = 44
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(TextBox6)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Data Dokter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
End Class
