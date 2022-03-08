Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\丙設資料\1060303.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        For i = 1 To m0
            If m0 Mod i = 0 Then
                m1 = m1 + 1
            End If
        Next
        If m1 = 2 Then
            txt.Text = "第三題結果：" & m0 & " is a prime number"
        Else
            txt.Text = "第三題結果：" & m0 & " is not a prime number"
        End If

    End Sub
End Class