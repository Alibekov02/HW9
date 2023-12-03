Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim baa As Integer
        Select Case ListBox1.SelectedIndex
            Case 0
                baa = 30
            Case 1
                baa = 25
            Case 2
                baa = 15
            Case 3
                baa = 40
            Case 4
                baa = 20
            Case 5
                baa = 10
        End Select
        TextBox2.Text = baa * Val(TextBox1.Text)
    End Sub
End Class