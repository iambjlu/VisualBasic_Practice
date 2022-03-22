Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "c:\丙設資料\1060305.sm", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose(1)

        For i = 1 To 2
            For j = 1 To 2
                c(i, j) = a(i, j) + b(i, j)
            Next
        Next

        Dim m1
        m1 = m1 & "[" & c(1, 1) & "         " & c(1, 2) & "]" & vbNewLine      '註:中間空格有9格'
        m1 = m1 & "[" & c(2, 1) & "      " & c(2, 2) & "]" & vbNewLine         '註:中間空格有6格'
        txt.Text = "第五題結果 : " & vbNewLine & m1
    End Sub
End Class