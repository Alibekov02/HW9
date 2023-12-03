Imports System.Reflection.Emit

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text = "Салам" Then
            Label1.Text = "Selam"
        Else
            Label1.Text = "Салам"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class