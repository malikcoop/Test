Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim z As Integer = x + y
        MessageBox.Show("Addition of " & x & "and " & y & "is :" & z)
        z = x - y
        MessageBox.Show("Deduction :" & z)

    End Sub

End Class
