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
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
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
        TextBox6.TabIndex = 65
        TextBox6.Text = "Filter Dokter"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(145, 179)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(232, 31)
        TextBox5.TabIndex = 59
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(145, 142)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(232, 31)
        TextBox4.TabIndex = 58
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(145, 105)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 31)
        TextBox2.TabIndex = 56
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 31)
        TextBox1.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 179)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 25)
        Label7.TabIndex = 54
        Label7.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 52
        Label5.Text = "Kuantitas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 50
        Label3.Text = "Indikasi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 49
        Label2.Text = "Nama Obat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(589, 25)
        Label1.TabIndex = 48
        Label1.Text = "Dikembangkan Oleh: D3 Teknik Informatika - Politeknik Negeri Semarang" & vbCrLf
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(719, 379)
        Button4.Name = "Button4"
        Button4.Size = New Size(74, 34)
        Button4.TabIndex = 47
        Button4.Text = "Hapus"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(648, 379)
        Button3.Name = "Button3"
        Button3.Size = New Size(65, 34)
        Button3.TabIndex = 46
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(145, 231)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 34)
        Button2.TabIndex = 45
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(8, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 44
        Button1.Text = "<< Kembali "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(414, 68)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(379, 284)
        ListView1.TabIndex = 66
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form4"
        Text = "Filter Obat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
End Class
