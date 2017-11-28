Public Class FizzBuzzWoofForm
    Private Sub btnFizz_Click(sender As Object, e As EventArgs) Handles btnFizz.Click

        Dim txtNum As Integer = txtNumber.Text
        Dim intCount As Integer = 1

        ' This is a remodeled version of the previous code. This should adjust any listing errors.

        Do Until intCount = (txtNum + 1)
            If intCount Mod 3 = 0 Then
                If intCount Mod 5 = 0 Then
                    If intCount Mod 7 = 0 Then
                        lstResults.Items.Add("FizzBuzzWoof")
                    Else
                        lstResults.Items.Add("FizzBuzz")
                    End If
                Else
                    lstResults.Items.Add("Fizz")
                End If
            ElseIf intCount Mod 7 = 0 Then
                If intCount Mod 5 = 0 Then
                    lstResults.Items.Add("BuzzWoof")
                ElseIf intCount Mod 3 = 0 Then
                    lstResults.Items.Add("FizzWoof")
                Else
                    lstResults.Items.Add("Woof")
                End If
            ElseIf intCount Mod 5 = 0 Then
                lstResults.Items.Add("Buzz")
            Else
                lstResults.Items.Add(intCount)
            End If
            intCount += 1
        Loop
        
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstResults.Items.Clear()
        txtNumber.Clear()
    End Sub
End Class
