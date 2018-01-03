Public Class Game_of_Luck

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Dim num As Integer ' variable to hold random number

        Const PIG = 1
        Const ELEPHANT = 2
        Const FOX = 3
        Const BUNNY = 4
        Const OWL = 5

        num = CInt((5 * Rnd())) ' generate random numbers 1-5

        If num = PIG Then
            picBunny.Visible = False
            picElephant.Visible = False
            picFox.Visible = False
            picOwl.Visible = False
            lblResult.Text = "You got pig! You're not lucky and sometimes you smell. "
        ElseIf num = ELEPHANT Then
            picBunny.Visible = False
            picPig.Visible = False
            picFox.Visible = False
            picOwl.Visible = False
            lblResult.Text = "You got elephant! You're lucky and you have a great memory. "
        ElseIf num = FOX Then
            picBunny.Visible = False
            picElephant.Visible = False
            picPig.Visible = False
            picOwl.Visible = False
            lblResult.Text = "You got fox! You're not lucky and need to be more honest. "
        ElseIf num = BUNNY Then
            picPig.Visible = False
            picElephant.Visible = False
            picFox.Visible = False
            picOwl.Visible = False
            lblResult.Text = "You got white rabbit! You're lucky and very sweet. "
        ElseIf num = OWL Then
            picBunny.Visible = False
            picElephant.Visible = False
            picFox.Visible = False
            picPig.Visible = False
            lblResult.Text = "You got owl! You're luck and very wise. "
        End If
    End Sub

    Private Sub btnSpinAgain_Click(sender As Object, e As EventArgs) Handles btnSpinAgain.Click
        picBunny.Visible = True
        picElephant.Visible = True
        picFox.Visible = True
        picOwl.Visible = True
        picPig.Visible = True
        lblResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class