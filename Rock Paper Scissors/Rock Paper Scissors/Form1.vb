Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Randomize()

        Dim number As Integer

        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3

        number = (3 * Rnd())

        If RadioButton1.Checked And number = ROCK Then
            Label1.Text = "The Computer Threw. Draw!"
        ElseIf RadioButton1.Checked And number = PAPER Then
            Label1.Text = "The Computer Threw. You Lose!"
        ElseIf RadioButton1.Checked And number = SCISSORS Then
            Label1.Text = "The Computer Threw. You Win!"

        ElseIf RadioButton2.Checked And number = ROCK Then
            Label1.Text = "The Computer Threw. You Win!"
        ElseIf RadioButton2.Checked And number = PAPER Then
            Label1.Text = "The Computer Threw. Draw!"
        ElseIf RadioButton2.Checked And number = SCISSORS Then
            Label1.Text = "The Computer Threw. You Win!"

        ElseIf RadioButton3.Checked And number = ROCK Then
            Label1.Text = "The Computer Threw. You Lose!"
        ElseIf RadioButton3.Checked And number = PAPER Then
            Label1.Text = "The Computer Threw. You Win!"
        ElseIf RadioButton3.Checked And number = SCISSORS Then
            Label1.Text = "The Computer Threw. Draw!"

        End If
    End Sub
End Class
