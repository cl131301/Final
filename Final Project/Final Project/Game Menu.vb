Public Class Game_Menu

    Private Sub btnMatching_Click(sender As Object, e As EventArgs) Handles btnMatching.Click
        Dim box = New Matching
        box.Show()
    End Sub

    Private Sub btnHorseRace_Click(sender As Object, e As EventArgs) Handles btnHorseRace.Click
        Dim box = New Horse_Race
        box.Show()
    End Sub

    Private Sub btnLionsTigersBears_Click(sender As Object, e As EventArgs) Handles btnLionsTigersBears.Click
        Dim box = New Lions__Tigers__Bears
        box.Show()
    End Sub

    Private Sub btnGameOfLuck_Click(sender As Object, e As EventArgs) Handles btnGameOfLuck.Click
        Dim box = New Game_of_Luck
        box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New Types_of_Pets_Owned
        box.show()
    End Sub
End Class