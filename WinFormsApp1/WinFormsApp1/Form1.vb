Public Class Form1
    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\丙設資料\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m0 = 123321
        m1 = m0
        For i = 1 To 9
            m2 = m1 \ 10
            m3 = m1 Mod 10
            m4 = m4 & m3
            If m2 = 0 Then Exit For
            m1 = m2
        Next i

        If m0 = m4 Then
            txt_01.Text = "第一題結果 : " & m0 & " is a palindrome."
        Else
            txt_01.Text = "第一題結果 : " & m0 & " is not a palindrome."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
