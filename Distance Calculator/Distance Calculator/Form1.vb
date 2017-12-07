Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intSpeed As Integer
        Dim intTime As Integer
        Dim intDistance As Integer
        
        intSpeed = InputBox("Please Enter The Speed Of The Vehicle In Miles Per Hour")
        intTime = InputBox("Please Enter The Amount Of Time, In Hours, That The Vehicle Has Traveled")

        DistanceListBox.Items.Add("Vehicle Speed: " & intSpeed.ToString & " MPH" & ControlChars.CrLf)
        DistanceListBox.Items.Add("Hours Traveled: " & intTime.ToString & ControlChars.CrLf & ControlChars.CrLf)
        DistanceListBox.Items.Add("Hour" & ControlChars.Tab & ControlChars.Tab & "Miles Traveled" & ControlChars.CrLf)
        DistanceListBox.Items.Add("__________________________________" & ControlChars.CrLf)

        For IntHour As Integer = 1 To intTime

            intDistance = intSpeed * IntHour

            DistanceListBox.Items.Add(IntHour.ToString("d") & vbTab & intDistance.ToString("d"))

        Next
        DistanceListBox.Items.Add("Total Distance: " & intDistance.ToString("d"))

    End Sub
End Class
