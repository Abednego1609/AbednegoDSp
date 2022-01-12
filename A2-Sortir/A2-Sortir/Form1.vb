Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr As New List(Of Char)
        For Each huruf As Char In TextBox1.Text
            arr.Add(huruf)

        Next
        arr.Sort()
        Label2.Text = ""
        For Each urut As Char In arr
            Label2.Text = Label2.Text + urut
        Next
        
    End Sub
End Class
