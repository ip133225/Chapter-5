Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEnterSales_Click(sender As Object, e As EventArgs) Handles btnEnterSales.Click
        Const intNUM_DAYS As Integer = 5
        Dim intCount As Integer = 1
        Dim decSales As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim strInput As String

        Do While intCount <= intNUM_DAYS

            strInput = InputBox("Enter a positive integer value. ")

            If Decimal.TryParse(strInput, decSales) Then

                decTotal += decSales

                intCount += 1
            Else

                MessageBox.Show("The sum of the numbers 1 though 10 is 55")
            End If
        Loop

        lblInteger.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
