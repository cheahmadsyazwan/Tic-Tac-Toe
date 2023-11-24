

Public Class tictac

    Dim checker As Boolean
    Dim plusone As Integer = 0
    Private lblPlayerO As Object
    Private lblPlayerX As Object

    Private Sub Enable_Flase()
        btnTic1.Enabled = False
        btnTic2.Enabled = False
        btnTic3.Enabled = False
        btnTic4.Enabled = False
        btnTic5.Enabled = False
        btnTic6.Enabled = False
        btnTic7.Enabled = False
        btnTic8.Enabled = False
        btnTic9.Enabled = False
    End Sub

    Private Sub score()
        If (btnTic1.Text = "X" And btnTic2.Text = "X" And btnTic3.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If

        If (btnTic1.Text = "X" And btnTic4.Text = "X" And btnTic7.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If

        If (btnTic1.Text = "X" And btnTic5.Text = "X" And btnTic9.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Crimson
            btnTic5.BackColor = System.Drawing.Color.Crimson
            btnTic9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            ' Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If


        If (btnTic3.Text = "X" And btnTic5.Text = "X" And btnTic7.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If

        If (btnTic2.Text = "X" And btnTic5.Text = "X" And btnTic8.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If

        If (btnTic3.Text = "X" And btnTic6.Text = "X" And btnTic9.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Crimson
            btnTic5.BackColor = System.Drawing.Color.Crimson
            btnTic9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            'Label4.text = Convert.ToString(plusone)
            Enable_False()
        End If


        If (btnTic4.Text = "X" And btnTic5.Text = "X" And btnTic6.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If

        If (btnTic7.Text = "X" And btnTic8.Text = "X" And btnTic9.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text)
            'Label4.text = Convert.ToString(plusone)
            Label4.Text = Convert.ToString(Label4.Text) + 1
            Enable_False()
        End If


        If (btnTic1.Text = "O" And btnTic2.Text = "O" And btnTic3.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1
            Enable_False()
        End If

        If (btnTic1.Text = "O" And btnTic4.Text = "O" And btnTic7.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone)
            Enable_False()
        End If

        If (btnTic1.Text = "O" And btnTic5.Text = "O" And btnTic9.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.Crimson
            btnTic5.BackColor = System.Drawing.Color.Crimson
            btnTic9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1
            Enable_False()
        End If


        If (btnTic3.Text = "O" And btnTic5.Text = "O" And btnTic7.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1
            Enable_False()
        End If

        If (btnTic2.Text = "O" And btnTic5.Text = "O" And btnTic8.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.Text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1
            Enable_False()
        End If

        If (btnTic3.Text = "O" And btnTic6.Text = "O" And btnTic9.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.Crimson
            btnTic5.BackColor = System.Drawing.Color.Crimson
            btnTic9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1

            Enable_False()
        End If


        If (btnTic4.Text = "O" And btnTic5.Text = "O" And btnTic6.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1

            Enable_False()
        End If

        If (btnTic7.Text = "O" And btnTic8.Text = "O" And btnTic9.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text)
            'Label3.text = Convert.ToString(plusone)
            Label3.Text = Convert.ToString(Label3.Text) + 1

            Enable_False()
        End If
    End Sub

    Private Sub Enable_False()
        'Throw New NotImplementedException()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTic1_Click(sender As Object, e As EventArgs) Handles btnTic1.Click
        If (checker = False) Then
            btnTic1.Text = "X"
            checker = True
        Else
            btnTic1.Text = "O"
            checker = False
        End If
        score()
        btnTic1.Enabled = False
    End Sub

    Private Sub btnTic2_Click(sender As Object, e As EventArgs) Handles btnTic2.Click
        If (checker = False) Then
            btnTic2.Text = "X"
            checker = True
        Else
            btnTic2.Text = "O"
            checker = False
        End If
        score()
        btnTic2.Enabled = False
    End Sub

    Private Sub btnTic3_Click(sender As Object, e As EventArgs) Handles btnTic3.Click
        If (checker = False) Then
            btnTic3.Text = "X"
            checker = True
        Else
            btnTic3.Text = "O"
            checker = False
        End If
        score()
        btnTic3.Enabled = False
    End Sub

    Private Sub btnTic4_Click(sender As Object, e As EventArgs) Handles btnTic4.Click
        If (checker = False) Then
            btnTic4.Text = "X"
            checker = True
        Else
            btnTic4.Text = "O"
            checker = False
        End If
        score()
        btnTic4.Enabled = False
    End Sub

    Private Sub btnTic5_Click(sender As Object, e As EventArgs) Handles btnTic5.Click
        If (checker = False) Then
            btnTic5.Text = "X"
            checker = True
        Else
            btnTic5.Text = "O"
            checker = False
        End If
        score()
        btnTic5.Enabled = False
    End Sub

    Private Sub btnTic6_Click(sender As Object, e As EventArgs) Handles btnTic6.Click
        If (checker = False) Then
            btnTic6.Text = "X"
            checker = True
        Else
            btnTic6.Text = "O"
            checker = False
        End If
        score()
        btnTic6.Enabled = False
    End Sub

    Private Sub btnTic7_Click(sender As Object, e As EventArgs) Handles btnTic7.Click
        If (checker = False) Then
            btnTic7.Text = "X"
            checker = True
        Else
            btnTic7.Text = "O"
            checker = False
        End If
        score()
        btnTic7.Enabled = False
    End Sub

    Private Sub btnTic8_Click(sender As Object, e As EventArgs) Handles btnTic8.Click
        If (checker = False) Then
            btnTic8.Text = "X"
            checker = True
        Else
            btnTic8.Text = "O"
            checker = False
        End If
        score()
        btnTic8.Enabled = False
    End Sub

    Private Sub btnTic9_Click(sender As Object, e As EventArgs) Handles btnTic9.Click
        If (checker = False) Then
            btnTic9.Text = "X"
            checker = True
        Else
            btnTic9.Text = "O"
            checker = False
        End If
        score()
        btnTic9.Enabled = False
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btnTic1.Enabled = True
        btnTic2.Enabled = True
        btnTic3.Enabled = True
        btnTic4.Enabled = True
        btnTic5.Enabled = True
        btnTic6.Enabled = True
        btnTic7.Enabled = True
        btnTic8.Enabled = True
        btnTic9.Enabled = True


        btnTic1.Text = ""
        btnTic2.Text = ""
        btnTic3.Text = ""
        btnTic4.Text = ""
        btnTic5.Text = ""
        btnTic6.Text = ""
        btnTic7.Text = ""
        btnTic8.Text = ""
        btnTic9.Text = ""

        Label4.Text = "0"
        Label3.Text = "0"

        btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        btnTic2.BackColor = Color.WhiteSmoke
        btnTic3.BackColor = Color.WhiteSmoke
        btnTic4.BackColor = Color.WhiteSmoke
        btnTic5.BackColor = Color.WhiteSmoke
        btnTic6.BackColor = Color.WhiteSmoke
        btnTic7.BackColor = Color.WhiteSmoke
        btnTic8.BackColor = Color.WhiteSmoke
        btnTic9.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        btnTic1.Enabled = True
        btnTic2.Enabled = True
        btnTic3.Enabled = True
        btnTic4.Enabled = True
        btnTic5.Enabled = True
        btnTic6.Enabled = True
        btnTic7.Enabled = True
        btnTic8.Enabled = True
        btnTic9.Enabled = True


        btnTic1.Text = ""
        btnTic2.Text = ""
        btnTic3.Text = ""
        btnTic4.Text = ""
        btnTic5.Text = ""
        btnTic6.Text = ""
        btnTic7.Text = ""
        btnTic8.Text = ""
        btnTic9.Text = ""

        btnNewGame.Enabled = True

        btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        btnTic2.BackColor = Color.WhiteSmoke
        btnTic3.BackColor = Color.WhiteSmoke
        btnTic4.BackColor = Color.WhiteSmoke
        btnTic5.BackColor = Color.WhiteSmoke
        btnTic6.BackColor = Color.WhiteSmoke
        btnTic7.BackColor = Color.WhiteSmoke
        btnTic8.BackColor = Color.WhiteSmoke
        btnTic9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub SpinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpinToolStripMenuItem.Click
        Dim spin = New Form3()
        spin.Show()
        Me.Hide()
    End Sub

    Private Sub CarRacingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarRacingToolStripMenuItem.Click
        Dim carRace = New Form2()
        carRace.Show()
        Me.Hide()
    End Sub
End Class


