Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Input As String
        Dim Input1 As String
        Dim Input2 As String
        Dim huruf As Char = ""
        Dim huruf1 As Char = ""
        Dim huruf2 As Char = ""
        Dim hitung As Integer = 0
        Dim hitung2 As Integer = 0
        Dim kecil As String = ""
        Dim konsonandump As String = ""
        Dim hasil = ""
        Input = Trim(TextBox1.Text)
        Do While hitung <= Input.Length - 1
            huruf = Input.Chars(hitung)
            If huruf >= "A" AndAlso huruf <= "Z" Then
            Else
                kecil = kecil + huruf
            End If
            hitung = hitung + 1
        Loop
        Label1.Text = kecil
        Label2.Text = kecil
        Input1 = Label1.Text
        Input2 = Label2.Text
        hitung = 0
        hitung2 = 0
        Do While hitung <= Input1.Length - 1
            huruf1 = Input1.Chars(hitung)
            Do While hitung2 <= Input2.Length - 1
                If Not Input1.Chars(hitung) = Input2.Chars(hitung2) Then
                    hasil = hasil + Input2.Chars(hitung2)
                End If
                hitung2 = hitung2 + 1
            Loop
            hitung = hitung + 1
        Loop




        'Dim arr As New List(Of Char)
        'For Each huruf2 As Char In TextBox1.Text
        ' arr.Add(huruf2)
        '
        '        Next
        'Do While hitung <= Input.Length - 1
        ' huruf = Input.Chars(hitung)
        ' MsgBox(huruf)
        ' hitung = hitung + 1
        ' Loop


    End Sub
End Class
