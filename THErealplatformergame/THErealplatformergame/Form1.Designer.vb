<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Picground = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.e = New System.Windows.Forms.PictureBox()
        Me.Tmrcount = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.w = New System.Windows.Forms.PictureBox()
        Me.e2 = New System.Windows.Forms.PictureBox()
        Me.e4 = New System.Windows.Forms.PictureBox()
        Me.e3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mover4 = New THErealplatformergame.mover()
        Me.Mover2 = New THErealplatformergame.mover()
        Me.Mover1 = New THErealplatformergame.mover()
        Me.Mover3 = New THErealplatformergame.mover()
        Me.scoretextbox = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picground
        '
        Me.Picground.Image = Global.THErealplatformergame.My.Resources.Resources.em_the_therapist
        Me.Picground.Location = New System.Drawing.Point(-4, 408)
        Me.Picground.Name = "Picground"
        Me.Picground.Size = New System.Drawing.Size(1166, 50)
        Me.Picground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picground.TabIndex = 0
        Me.Picground.TabStop = False
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.Transparent
        Me.Picair.Location = New System.Drawing.Point(-4, -25)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(1176, 386)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'Picplayer
        '
        Me.Picplayer.Image = Global.THErealplatformergame.My.Resources.Resources.bruh
        Me.Picplayer.Location = New System.Drawing.Point(12, 299)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(56, 50)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picplayer.TabIndex = 2
        Me.Picplayer.TabStop = False
        '
        'Tmrright
        '
        Me.Tmrright.Interval = 50
        '
        'Tmrleft
        '
        Me.Tmrleft.Interval = 50
        '
        'Tmrup
        '
        Me.Tmrup.Interval = 50
        '
        'Tmrgamelogic
        '
        Me.Tmrgamelogic.Interval = 50
        '
        'Tmrgravity
        '
        Me.Tmrgravity.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.THErealplatformergame.My.Resources.Resources.vectored
        Me.PictureBox1.Location = New System.Drawing.Point(331, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.THErealplatformergame.My.Resources.Resources.vectored
        Me.PictureBox2.Location = New System.Drawing.Point(517, 218)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.THErealplatformergame.My.Resources.Resources.vectored
        Me.PictureBox3.Location = New System.Drawing.Point(714, 299)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.THErealplatformergame.My.Resources.Resources.vectored
        Me.PictureBox4.Location = New System.Drawing.Point(868, 109)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(108, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.THErealplatformergame.My.Resources.Resources.freepizza
        Me.PictureBox5.Location = New System.Drawing.Point(368, 192)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "collectable"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.THErealplatformergame.My.Resources.Resources.freepizza
        Me.PictureBox6.Location = New System.Drawing.Point(2048, 162)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "collectable"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.THErealplatformergame.My.Resources.Resources.freepizza
        Me.PictureBox7.Location = New System.Drawing.Point(896, 53)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "collectable"
        '
        'e
        '
        Me.e.Image = Global.THErealplatformergame.My.Resources.Resources._8btkg8
        Me.e.Location = New System.Drawing.Point(206, 45)
        Me.e.Name = "e"
        Me.e.Size = New System.Drawing.Size(43, 50)
        Me.e.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e.TabIndex = 10
        Me.e.TabStop = False
        Me.e.Tag = "restart"
        '
        'Tmrcount
        '
        Me.Tmrcount.Enabled = True
        Me.Tmrcount.Interval = 1
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.THErealplatformergame.My.Resources.Resources.freepizza
        Me.PictureBox9.Location = New System.Drawing.Point(542, 162)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "collectable"
        '
        'w
        '
        Me.w.Image = Global.THErealplatformergame.My.Resources.Resources.freepizza
        Me.w.Location = New System.Drawing.Point(736, 243)
        Me.w.Name = "w"
        Me.w.Size = New System.Drawing.Size(56, 50)
        Me.w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.w.TabIndex = 13
        Me.w.TabStop = False
        Me.w.Tag = "collectable"
        '
        'e2
        '
        Me.e2.Image = Global.THErealplatformergame.My.Resources.Resources._8btkg8
        Me.e2.Location = New System.Drawing.Point(858, 211)
        Me.e2.Name = "e2"
        Me.e2.Size = New System.Drawing.Size(56, 50)
        Me.e2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e2.TabIndex = 17
        Me.e2.TabStop = False
        Me.e2.Tag = "restart"
        '
        'e4
        '
        Me.e4.Image = Global.THErealplatformergame.My.Resources.Resources._8btkg8
        Me.e4.Location = New System.Drawing.Point(579, 56)
        Me.e4.Name = "e4"
        Me.e4.Size = New System.Drawing.Size(56, 50)
        Me.e4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e4.TabIndex = 21
        Me.e4.TabStop = False
        Me.e4.Tag = "restart"
        '
        'e3
        '
        Me.e3.Image = Global.THErealplatformergame.My.Resources.Resources._8btkg8
        Me.e3.Location = New System.Drawing.Point(55, 170)
        Me.e3.Name = "e3"
        Me.e3.Size = New System.Drawing.Size(56, 50)
        Me.e3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e3.TabIndex = 20
        Me.e3.TabStop = False
        Me.e3.Tag = "restart"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "SCORE"
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 100
        Me.Mover4.Location = New System.Drawing.Point(25, 180)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(238, 21)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.e3
        Me.Mover4.TabIndex = 19
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 100
        Me.Mover2.Location = New System.Drawing.Point(828, 221)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(238, 21)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.e2
        Me.Mover2.TabIndex = 16
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(186, 55)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(238, 21)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.e
        Me.Mover1.TabIndex = 14
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 100
        Me.Mover3.Location = New System.Drawing.Point(559, 66)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(238, 21)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.e4
        Me.Mover3.TabIndex = 18
        '
        'scoretextbox
        '
        Me.scoretextbox.AutoSize = True
        Me.scoretextbox.Location = New System.Drawing.Point(56, 45)
        Me.scoretextbox.Name = "scoretextbox"
        Me.scoretextbox.Size = New System.Drawing.Size(14, 16)
        Me.scoretextbox.TabIndex = 23
        Me.scoretextbox.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Purple
        Me.TextBox1.Location = New System.Drawing.Point(-2, -3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 24
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.THErealplatformergame.My.Resources.Resources._8cl638
        Me.PictureBox8.Location = New System.Drawing.Point(525, 313)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 25
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "end"
        Me.PictureBox8.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THErealplatformergame.My.Resources.Resources.casino
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 450)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.scoretextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.e4)
        Me.Controls.Add(Me.e3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.e2)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.w)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.e)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.Picair)
        Me.Controls.Add(Me.Picground)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover3)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picground As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Tmrright As Timer
    Friend WithEvents Tmrleft As Timer
    Friend WithEvents Tmrup As Timer
    Friend WithEvents Tmrgamelogic As Timer
    Friend WithEvents Tmrgravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents e As PictureBox
    Friend WithEvents Tmrcount As Timer
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents w As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Mover2 As mover
    Friend WithEvents e2 As PictureBox
    Friend WithEvents Mover3 As mover
    Friend WithEvents Mover4 As mover
    Friend WithEvents e3 As PictureBox
    Friend WithEvents e4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scoretextbox As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
