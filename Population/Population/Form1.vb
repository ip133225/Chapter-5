Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim intCount As Integer = 1
        Dim dblTotal As Double
        Dim dblPopulationPerc As Double
        dblPopulationPerc = CDbl(txtBoxIncrease.Text) / 100
        lstPopulation.Items.Add("Day       Approximate Population")
        lstPopulation.Items.Add("-----------------------------------")
        lstPopulation.Items.Add(intCount & "         " & dblPopulationPerc.ToString("p"))
        Do While intCount < 10
            intCount = intCount + 1
            dblTotal = CDbl(txtBoxIncrease.Text) * dblPopulationPerc
            lstPopulation.Items.Add(intCount.ToString & "        " & dblTotal.ToString("n"))
        Loop
    End Sub
End Class
