Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim h(3), w(3), bmi(3), s_bmi
        FileOpen(1, "C:\丙設資料\1060304.SM", OpenMode.Input)

        For i = 1 To 3
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2

        Next
        FileClose(1)

        s_bmi = bmi(1)
        For i = 1 To 3
            If bmi(i) < s_bmi Then
                s_bmi = bmi(i)
            End If

        Next
        Dim s_bmi45 As Integer = s_bmi

        If s_bmi45 >= 20 And s_bmi45 <= 25 Then
            txt.Text = "第四題結果：最小BMI值=" & s_bmi45 & "，正常"
        Else
            txt.Text = "第四題結果：最小BMI值=" & s_bmi45 & "，不正常"
        End If

    End Sub
End Class
