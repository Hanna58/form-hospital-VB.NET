Imports System.Runtime.CompilerServices

Public Class Form1
    Private form2 As Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form2 = New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class

Namespace Hospital

    Partial Public Class Form1
        Inherits Form

        Private form2 As Form
        Private Sub InitializeComponent()

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        End Sub

        Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
