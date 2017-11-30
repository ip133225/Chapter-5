Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnEnterSales.Click
        Const intNUM_Days As Integer = 5 ' The number of days
        Dim intCount As Integer = 1 ' Loop counter
        Dim decSales As Decimal = 0 ' To hold holiday sales
        Dim decTotal As Decimal = 0 ' To hold the total sales
        Dim strInput As String          'To hold string input

        Do While intCount <= intNUM_Days
            strInput = InputBox("Enter the sales for day " & intCount.ToString())
            If Decimal.TryParse(strInput, decSales) Then
                ' decTotal =+ decSales
                decTotal = decSales + decTotal
                'intCount += 1
                intCount = intCount + 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
