<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tictac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTic9 = New System.Windows.Forms.Button()
        Me.btnTic8 = New System.Windows.Forms.Button()
        Me.btnTic7 = New System.Windows.Forms.Button()
        Me.btnTic6 = New System.Windows.Forms.Button()
        Me.btnTic5 = New System.Windows.Forms.Button()
        Me.btnTic4 = New System.Windows.Forms.Button()
        Me.btnTic3 = New System.Windows.Forms.Button()
        Me.btnTic2 = New System.Windows.Forms.Button()
        Me.btnTic1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarRacingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 94)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(-2, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(711, 91)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tic Tac Toe Game"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 653)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.btnNewGame)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Location = New System.Drawing.Point(674, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(645, 608)
        Me.Panel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 91)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 91)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 91)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Player O"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 91)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Player X"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 46.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(326, 382)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(295, 87)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "Exit"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 46.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(14, 290)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(607, 87)
        Me.btnNewGame.TabIndex = 10
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 46.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(14, 383)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(306, 87)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Reset"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnTic9)
        Me.Panel3.Controls.Add(Me.btnTic8)
        Me.Panel3.Controls.Add(Me.btnTic7)
        Me.Panel3.Controls.Add(Me.btnTic6)
        Me.Panel3.Controls.Add(Me.btnTic5)
        Me.Panel3.Controls.Add(Me.btnTic4)
        Me.Panel3.Controls.Add(Me.btnTic3)
        Me.Panel3.Controls.Add(Me.btnTic2)
        Me.Panel3.Controls.Add(Me.btnTic1)
        Me.Panel3.Location = New System.Drawing.Point(24, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(644, 608)
        Me.Panel3.TabIndex = 1
        '
        'btnTic9
        '
        Me.btnTic9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic9.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic9.Location = New System.Drawing.Point(425, 391)
        Me.btnTic9.Name = "btnTic9"
        Me.btnTic9.Size = New System.Drawing.Size(200, 193)
        Me.btnTic9.TabIndex = 8
        Me.btnTic9.UseVisualStyleBackColor = False
        '
        'btnTic8
        '
        Me.btnTic8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic8.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic8.Location = New System.Drawing.Point(219, 391)
        Me.btnTic8.Name = "btnTic8"
        Me.btnTic8.Size = New System.Drawing.Size(200, 193)
        Me.btnTic8.TabIndex = 7
        Me.btnTic8.UseVisualStyleBackColor = False
        '
        'btnTic7
        '
        Me.btnTic7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic7.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic7.Location = New System.Drawing.Point(13, 391)
        Me.btnTic7.Name = "btnTic7"
        Me.btnTic7.Size = New System.Drawing.Size(200, 193)
        Me.btnTic7.TabIndex = 6
        Me.btnTic7.UseVisualStyleBackColor = False
        '
        'btnTic6
        '
        Me.btnTic6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic6.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic6.Location = New System.Drawing.Point(425, 199)
        Me.btnTic6.Name = "btnTic6"
        Me.btnTic6.Size = New System.Drawing.Size(200, 186)
        Me.btnTic6.TabIndex = 5
        Me.btnTic6.UseVisualStyleBackColor = False
        '
        'btnTic5
        '
        Me.btnTic5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic5.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic5.Location = New System.Drawing.Point(219, 199)
        Me.btnTic5.Name = "btnTic5"
        Me.btnTic5.Size = New System.Drawing.Size(200, 186)
        Me.btnTic5.TabIndex = 4
        Me.btnTic5.UseVisualStyleBackColor = False
        '
        'btnTic4
        '
        Me.btnTic4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic4.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic4.Location = New System.Drawing.Point(13, 199)
        Me.btnTic4.Name = "btnTic4"
        Me.btnTic4.Size = New System.Drawing.Size(200, 186)
        Me.btnTic4.TabIndex = 3
        Me.btnTic4.UseVisualStyleBackColor = False
        '
        'btnTic3
        '
        Me.btnTic3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic3.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic3.Location = New System.Drawing.Point(425, 15)
        Me.btnTic3.Name = "btnTic3"
        Me.btnTic3.Size = New System.Drawing.Size(200, 178)
        Me.btnTic3.TabIndex = 2
        Me.btnTic3.UseVisualStyleBackColor = False
        '
        'btnTic2
        '
        Me.btnTic2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic2.Location = New System.Drawing.Point(219, 15)
        Me.btnTic2.Name = "btnTic2"
        Me.btnTic2.Size = New System.Drawing.Size(200, 178)
        Me.btnTic2.TabIndex = 1
        Me.btnTic2.UseVisualStyleBackColor = False
        '
        'btnTic1
        '
        Me.btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic1.Font = New System.Drawing.Font("Microsoft Sans Serif", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic1.Location = New System.Drawing.Point(13, 15)
        Me.btnTic1.Name = "btnTic1"
        Me.btnTic1.Size = New System.Drawing.Size(200, 178)
        Me.btnTic1.TabIndex = 0
        Me.btnTic1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GamesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1368, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpinToolStripMenuItem, Me.CarRacingToolStripMenuItem})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'SpinToolStripMenuItem
        '
        Me.SpinToolStripMenuItem.Name = "SpinToolStripMenuItem"
        Me.SpinToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.SpinToolStripMenuItem.Text = "Spin"
        '
        'CarRacingToolStripMenuItem
        '
        Me.CarRacingToolStripMenuItem.Name = "CarRacingToolStripMenuItem"
        Me.CarRacingToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.CarRacingToolStripMenuItem.Text = "Car Racing"
        '
        'tictac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1368, 797)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "tictac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTic1 As Button
    Friend WithEvents btnTic9 As Button
    Friend WithEvents btnTic8 As Button
    Friend WithEvents btnTic7 As Button
    Friend WithEvents btnTic6 As Button
    Friend WithEvents btnTic5 As Button
    Friend WithEvents btnTic4 As Button
    Friend WithEvents btnTic3 As Button
    Friend WithEvents btnTic2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarRacingToolStripMenuItem As ToolStripMenuItem
End Class
