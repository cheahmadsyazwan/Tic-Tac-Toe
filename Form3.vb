Public Class Form3
    Dim m, a, b, c As Integer

    Private Sub CarRacingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarRacingToolStripMenuItem.Click
        Dim carRace = New Form2()
        carRace.Show()
        Me.Hide()
    End Sub

    Private Sub TicTacToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicTacToolStripMenuItem.Click
        Dim tictac = New tictac()
        tictac.Show()
        Me.Hide()
    End Sub

    Public Property PictureBox4 As Object

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        m = m + 10
        If m < 1000 Then
            a = Int(1 + Rnd() * 3)
            b = Int(1 + Rnd() * 3)
            c = Int(1 + Rnd() * 3)

            Select Case a
                Case 1
                    PictureBox1.Image = My.Resources.panda
                Case 2
                    PictureBox1.Image = My.Resources.elephant
                Case 3
                    PictureBox1.Image = My.Resources.cat
            End Select

            Select Case b
                Case 1
                    PictureBox2.Image = My.Resources.panda
                Case 2
                    PictureBox2.Image = My.Resources.elephant
                Case 3
                    PictureBox2.Image = My.Resources.cat
            End Select

            Select Case c
                Case 1
                    PictureBox3.Image = My.Resources.panda
                Case 2
                    PictureBox3.Image = My.Resources.elephant
                Case 3
                    PictureBox3.Image = My.Resources.cat
            End Select

        Else
            Timer1.Enabled = False
            m = 0
            If a = b Then
                Label1.Text = "Good luck !, You won $100 !"
            ElseIf a = c Then
                Label1.Text = "Good luck !, You won $300 !"
            ElseIf a = b And b = c Then
                Label1.Text = "Good luck !, You won $500 !"
            ElseIf a = b And b = c Then
                Label1.Text = "Jackpot !, You won $1000 !"
            Else
                Label1.Text = "No lucky, please try again or insert coin :)"
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
End Class