Public Class Form1
    Public num1 As Double
    Public operacion As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpantalla.Text = txtpantalla.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpantalla.Text = txtpantalla.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpantalla.Text = txtpantalla.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpantalla.Text = txtpantalla.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpantalla.Text = txtpantalla.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpantalla.Text = txtpantalla.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpantalla.Text = txtpantalla.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpantalla.Text = txtpantalla.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpantalla.Text = txtpantalla.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpantalla.Text = txtpantalla.Text + "0"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        txtpantalla.Text = txtpantalla.Text + "."
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtpantalla.Text = ""
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        num1 = CDbl(txtpantalla.Text)
        txtpantalla.Text = ""
        operacion = 1
    End Sub

    Private Sub btnrest_Click(sender As Object, e As EventArgs) Handles btnrest.Click
        num1 = CDbl(txtpantalla.Text)
        txtpantalla.Text = ""
        operacion = 2
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        num1 = CDbl(txtpantalla.Text)
        txtpantalla.Text = ""
        operacion = 3
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        num1 = CDbl(txtpantalla.Text)
        txtpantalla.Text = ""
        operacion = 4
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        If (operacion = 1) Then
            txtpantalla.Text = num1 + CDbl(txtpantalla.Text)

        ElseIf (operacion = 2) Then
            txtpantalla.Text = num1 - CDbl(txtpantalla.Text)

        ElseIf (operacion = 3) Then
            txtpantalla.Text = num1 / CDbl(txtpantalla.Text)

        ElseIf (operacion = 4) Then
            txtpantalla.Text = num1 * CDbl(txtpantalla.Text)

        End If
    End Sub
End Class
