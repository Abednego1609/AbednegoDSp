Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tampil, temp
        tampil = ""
        If TextBox1.Text >= 1 And TextBox1.Text <= 9 Then
            For ulangi As Integer = 1 To TextBox1.Text
                For bil As Integer = 1 To TextBox1.Text
                    temp = ""
                    If bil = TextBox1.Text Then
                        temp = "hop! "
                    Else
                        temp = bil & " "
                    End If
                    tampil = tampil + temp
                    Label2.Text = tampil
                Next
            Next
        ElseIf TextBox1.Text >= 10 And TextBox1.Text <= 20 Then
            tampil = "Apa?"
            Label2.Text = tampil
        Else
            Label2.Text = ""
            MsgBox("Ketikkan Angka 1 sampai dengan 20", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class
