Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        If Val(TextBox1.Text) < 3 Then
            CheckBox1.Checked = True
        Else
            If Val(TextBox1.Text) > 3 And Val(TextBox1.Text) <= 3.5 Then
                CheckBox2.Checked = True
            Else
                CheckBox3.Checked = True
            End If
        End If
    End Sub
End Class