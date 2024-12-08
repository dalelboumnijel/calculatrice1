Public Class Form1
    Dim op As Char
    Private Sub equal_Click_1(sender As Object, e As EventArgs) Handles equal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then

        End If
        Dim a = Integer.Parse(txt_A.Text)
        Dim b = Integer.Parse(txt_B.Text)
        Dim rest As Double
        Dim test = True
        If op = "+" Then
            rest = a + b
        ElseIf op = "-" Then
            rest = a - b
        ElseIf op = "*" Then
            rest = a * b
        ElseIf op = "/" And Not b = 0 Then
            rest = a / b
        Else
            MessageBox.Show("veuillez choisir un opérateur")
            test = False

        End If
        If test = True Then
            lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + rest.ToString
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles rest.Click

    End Sub

    Private Sub Btn1_Click_1(sender As Object, e As EventArgs) Handles Btn1.Click
        op = "+"
    End Sub

    Private Sub Btn2_Click_1(sender As Object, e As EventArgs) Handles Btn2.Click
        op = "-"
    End Sub

    Private Sub Btn3_Click_1(sender As Object, e As EventArgs) Handles Btn3.Click
        op = "*"
    End Sub

    Private Sub Btn4_Click_1(sender As Object, e As EventArgs) Handles Btn4.Click
        op = "/"
    End Sub
End Class
