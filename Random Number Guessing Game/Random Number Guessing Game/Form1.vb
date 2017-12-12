Public Class Form1
    Dim rand As New Random
    Dim PCNumber As Integer
    Dim userGuess As Integer
    Dim Wrong As Integer

    Sub RNG()
        userGuess = InputBox("Enter a number between 1 and 100")
        If userGuess > PCNumber Then
            MessageBox.Show("Guess to High! Try again.")
            Wrong = Wrong + 1
        ElseIf userGuess < PCNumber Then
            MessageBox.Show("Guess to Low! Try again.")
            Wrong = Wrong + 1
        End If
    End Sub



    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click

        PCNumber = rand.Next(100)

        Do While userGuess <> PCNumber
            RNG()
        Loop
        lblWrong.Text = ("You Took " & Wrong.ToString & " Guesses.")
        lblAnswer.Text = ("Correct You Win!!! The Number Was " & PCNumber & "!")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
