Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\丙設資料\1060302.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        For i = 1 To m0
            For j = 1 To i
                m1 = m1 & j
            Next
            m1 = m1 & vbNewLine
        Next
        txt.Text = "第二題結果 : " & vbNewLine & m1
    End Sub
End Class
