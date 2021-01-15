Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer = 0
        Dim TotalRepeticiones As Integer = CInt(TextBox1.Text)
        For I = 1 To TotalRepeticiones
            MsgBox("Esta lista de codigo ha sido repetida " & I & " veces",, "Repetir")
        Next
    End Sub
End Class
