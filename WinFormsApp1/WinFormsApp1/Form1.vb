Public Class Form1
    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\丙設資料\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m1 = m0
        m2 = m1 / 10
        m3 = m1 Mod 10
        m4 = m4 & m3

    End Sub
End Class
