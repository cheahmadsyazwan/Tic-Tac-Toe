<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.race1 = New System.Windows.Forms.PictureBox()
        Me.race2 = New System.Windows.Forms.PictureBox()
        Me.race3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TicTacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicTacToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.race1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SCORE 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(237, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SPEED 0"
        '
        'race1
        '
        Me.race1.Image = Global.Tic_Tac_Toe_1.My.Resources.Resources.car_2
        Me.race1.Location = New System.Drawing.Point(268, 210)
        Me.race1.Name = "race1"
        Me.race1.Size = New System.Drawing.Size(35, 71)
        Me.race1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race1.TabIndex = 11
        Me.race1.TabStop = False
        '
        'race2
        '
        Me.race2.Image = Global.Tic_Tac_Toe_1.My.Resources.Resources.car_3
        Me.race2.Location = New System.Drawing.Point(147, 77)
        Me.race2.Name = "race2"
        Me.race2.Size = New System.Drawing.Size(35, 71)
        Me.race2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race2.TabIndex = 10
        Me.race2.TabStop = False
        '
        'race3
        '
        Me.race3.Image = Global.Tic_Tac_Toe_1.My.Resources.Resources.car_1
        Me.race3.Location = New System.Drawing.Point(23, 210)
        Me.race3.Name = "race3"
        Me.race3.Size = New System.Drawing.Size(36, 71)
        Me.race3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race3.TabIndex = 9
        Me.race3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox5.Location = New System.Drawing.Point(218, 322)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(14, 131)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Location = New System.Drawing.Point(217, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(14, 131)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox6.Location = New System.Drawing.Point(99, 322)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(14, 131)
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Location = New System.Drawing.Point(99, 170)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(14, 131)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(218, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 148)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(99, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 148)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'car
        '
        Me.car.Image = Global.Tic_Tac_Toe_1.My.Resources.Resources.car_1
        Me.car.Location = New System.Drawing.Point(147, 344)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(36, 71)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 13
        Me.car.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Interval = 10
        '
        'RightSide
        '
        Me.RightSide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'RacerMover1
        '
        Me.RacerMover1.Enabled = True
        Me.RacerMover1.Interval = 10
        '
        'RacerMover2
        '
        Me.RacerMover2.Enabled = True
        Me.RacerMover2.Interval = 10
        '
        'RacerMover3
        '
        Me.RacerMover3.Enabled = True
        Me.RacerMover3.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(36, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 72)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "GAMEOVER"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(83, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 71)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "REPLAY"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicTacToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TicTacToolStripMenuItem
        '
        Me.TicTacToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicTacToolStripMenuItem1, Me.SpinToolStripMenuItem})
        Me.TicTacToolStripMenuItem.Name = "TicTacToolStripMenuItem"
        Me.TicTacToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.TicTacToolStripMenuItem.Text = "Games"
        '
        'TicTacToolStripMenuItem1
        '
        Me.TicTacToolStripMenuItem1.Name = "TicTacToolStripMenuItem1"
        Me.TicTacToolStripMenuItem1.Size = New System.Drawing.Size(136, 26)
        Me.TicTacToolStripMenuItem1.Text = "Tic Tac"
        '
        'SpinToolStripMenuItem
        '
        Me.SpinToolStripMenuItem.Name = "SpinToolStripMenuItem"
        Me.SpinToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.SpinToolStripMenuItem.Text = "Spin"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(332, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.race1)
        Me.Controls.Add(Me.race2)
        Me.Controls.Add(Me.race3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(350, 500)
        Me.MinimumSize = New System.Drawing.Size(350, 500)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Racing Game"
        CType(Me.race1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RacerMover2 As Timer
    Friend WithEvents RacerMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TicTacToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicTacToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SpinToolStripMenuItem As ToolStripMenuItem
End Class
