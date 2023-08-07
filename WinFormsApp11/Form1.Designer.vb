<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(42, 64)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Data Pasien"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(229, 64)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 34)
        Button2.TabIndex = 1
        Button2.Text = "Data Dokter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(433, 64)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 2
        Button3.Text = "Data Obat"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(42, 46)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 34)
        Button4.TabIndex = 3
        Button4.Text = "Data CheckUp"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button5.Location = New Point(651, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(42, 34)
        Button5.TabIndex = 4
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(74, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 156)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Master Data"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Location = New Point(74, 236)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(693, 121)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Pemeriksaan/CheckUp "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 391)
        Label1.Name = "Label1"
        Label1.Size = New Size(594, 50)
        Label1.TabIndex = 7
        Label1.Text = "Dikembangkan Oleh: D3 Teknik Informatika - Politeknik Negeri Semarang " & vbCrLf & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(798, 440)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rumah Sakit Mitra Sehat"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
End Class
