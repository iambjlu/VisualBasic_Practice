Imports System.Text
Public Class Form1
    Dim b, a, op, y, x, ans As New ArrayList
    Dim rno As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rdata()
        Call sp()
        Call wdata()
    End Sub
    Sub rdata()
        FileOpen(8, "C:\丙設資料\1060308.SM", OpenMode.Input)
        Dim d
        Do Until EOF(8)
            Input(8, d) : b.Add(d)
            Input(8, d) : a.Add(d)
            Input(8, d) : op.Add(d)
            Input(8, d) : y.Add(d)
            Input(8, d) : x.Add(d)

            rno += 1
        Loop
        FileClose(8)
    End Sub
    Sub sp()
        Dim m1, m2, f As Integer
        For i = 0 To rno - 1
            Select Case op(i)
                Case "+"
                    m1 = b(i) * x(i) + a(i) * y(i)
                    m2 = a(i) * x(i)
                Case "-"
                    m1 = b(i) * x(i) - a(i) * y(i)
                    m2 = a(i) * x(i)
                Case "*"
                    m1 = b(i) * y(i)
                    m2 = a(i) * x(i)
                Case "/"
                    m1 = b(i) * x(i)
                    m2 = a(i) * y(i)
            End Select
            f = 2
            Do While f <= Math.Abs(m1) And f <= Math.Abs(m2)
                Do While m1 Mod f = 0 And m2 Mod f = 0
                    m1 = m1 \ f
                    m2 = m2 \ f
                Loop
                f = f + 1
            Loop
            If m1 = 0 Then
                ans.Add(0)
            ElseIf m2 = 1 Then
                ans.Add(m1)
            Else
                ans.Add(m1 & "/" & m2)
            End If
        Next

    End Sub

    Sub wdata()
        Dim dt As New DataTable
        dt.Columns.Add("VALUE1")
        dt.Columns.Add("OP")
        dt.Columns.Add("VALUE2")
        dt.Columns.Add("ANSWER")

        For i = 0 To rno - 1
            Dim dr As DataRow = dt.NewRow
            dr(0) = b(i) & "/" & a(i)
            dr(1) = op(i)
            dr(2) = y(i) & "/" & x(i)
            dr(3) = ans(i)
            dt.Rows.Add(dr)
        Next
        dgv.DataSource = dt

    End Sub
End Class
