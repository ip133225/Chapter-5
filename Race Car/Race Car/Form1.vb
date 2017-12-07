Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random

        For intCount1 = 16 To rand.Next(250) + 420
            picOCar.Left = intCount1
        Next

        For intCount2 = 16 To rand.Next(250) + 420
            picBCar.Left = intCount2
        Next

        For intCount3 = 16 To rand.Next(250) + 420
            picRCar.Left = intCount3
        Next

        lblORaceS.Text = ("Orange car: " & intCount1)
        lblBRaceS.Text = ("Blue car: " & intCount2)
        lblRRaceS.Text = ("Red car: " & intCount3)

        If intCount1 > intCount2 And intCount1 > intCount3 Then 'Orange
            lblWinner.Text = ("Orange car Wins!!")
            If radOBet.Checked = True Then
                lblBet.Text = ("You won the bet!")
            ElseIf radBBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            ElseIf radRBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            End If
        End If

        If intCount2 > intCount1 And intCount2 > intCount3 Then 'Blue
            lblWinner.Text = ("Blue car Wins!!")
            If radBBet.Checked = True Then
                lblBet.Text = ("You won the bet!")
            ElseIf radRBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            ElseIf radOBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            End If
        End If

        If intCount3 > intCount1 And intCount3 > intCount2 Then 'Red
            lblWinner.Text = ("Red car Wins!!")
            If radRBet.Checked = True Then
                lblBet.Text = ("You won the bet!")
            ElseIf radBBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            ElseIf radOBet.Checked = True Then
                lblBet.Text = ("You lost the bet!")
            End If
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim intCount As Integer

        For intCount = 0 To 0
            picOCar.Left = intCount
            picBCar.Left = intCount
            picRCar.Left = intCount
        Next
        lblBRaceS.Text = String.Empty
        lblORaceS.Text = String.Empty
        lblRRaceS.Text = String.Empty
        lblWinner.Text = String.Empty
        lblBet.Text = String.Empty
        radRBet.Checked = False
        radBBet.Checked = False
        radOBet.Checked = False
    End Sub

    Private Sub radOBet_CheckedChanged(sender As Object, e As EventArgs) Handles radOBet.CheckedChanged

    End Sub
End Class
  
