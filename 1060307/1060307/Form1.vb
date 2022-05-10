Public Class Form1
    Dim suit(3) As String
    Dim d(100)
    Dim card As New ArrayList
    Dim gno As Integer
    Dim rno As Integer
    Dim pn, pf, pn1 As New ArrayList
    Dim bn, bf, bn1 As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        Call sp1()
        Call sp2()
        Call sp3()
        Call wdata()
    End Sub
    Sub rdata()
        FileOpen(1, "c:\丙設資料\1060307.sm", OpenMode.Input)
        Input(1, gno)
        rno = 0
        Do While Not EOF(1)
            rno = rno + 1
            Input(1, d(rno))
        Loop
        FileClose(1)

    End Sub

    Sub sp1()
        Dim bal() As Byte = {226, 153, 160}
        Dim ba2() As Byte = {226, 153, 165}
        Dim ba3() As Byte = {226, 153, 166}
        Dim ba4() As Byte = {226, 153, 163}
        suit(0) = System.Text.Encoding.UTF8.GetString(bal)
        suit(1) = System.Text.Encoding.UTF8.GetString(ba2)
        suit(2) = System.Text.Encoding.UTF8.GetString(ba3)
        suit(3) = System.Text.Encoding.UTF8.GetString(ba4)


    End Sub

    Sub sp2()
        For i = 1 To rno
            Dim t = Int(Val(d(i) * 52))
            If card.IndexOf(t) = -1 Then card.Add(t)

        Next
    End Sub

    Sub sp3()
        For i = 0 To gno * 2 - 1
            Dim f = card(i) \ 13
            Dim n = card(i) Mod 13 + 1
            Dim disp = {"*", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
            Dim n1 = disp(n)
            If n = 1 Then n = n + 13

            If i Mod 2 = 0 Then
                pn.Add(n) : pf.Add(f) : pn1.Add(n1)
            Else
                bn.Add(n) : bf.Add(f) : bn1.Add(n1)
            End If
        Next
    End Sub

    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("序號")
        dt.Columns.Add("玩家")
        dt.Columns.Add("莊家")
        dt.Columns.Add("結果")
        For i = 0 To gno - 1
            Dim dr As DataRow = dt.NewRow
            dr(0) = i + 1
            dr(1) = suit(pf(i)) & pn1(i)
            dr(2) = suit(bf(i)) & bn1(i)
            If pn(i) > bn(i) Then dr(3) = "玩家贏"
            If pn(i) < bn(i) Then dr(3) = "莊家贏"
            If pn(i) = bn(i) Then dr(3) = "平手"
            dt.Rows.Add(dr)
        Next
        dgv.DataSource = dt
    End Sub

End Class