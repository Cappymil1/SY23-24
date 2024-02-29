<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.countlabel = New System.Windows.Forms.Label()
        Me.Tmrcount = New System.Windows.Forms.Timer(Me.components)
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
        Me.PictureBox1.Location = New System.Drawing.Point(266, 221)
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
        Me.PictureBox5.Location = New System.Drawing.Point(304, 165)
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
        Me.PictureBox6.Location = New System.Drawing.Point(548, 162)
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
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.THErealplatformergame.My.Resources.Resources._8btkg8
        Me.PictureBox8.Location = New System.Drawing.Point(754, 243)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(43, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "restart"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 11
        '
        'countlabel
        '
        Me.countlabel.AutoSize = True
        Me.countlabel.Location = New System.Drawing.Point(19, 13)
        Me.countlabel.Name = "countlabel"
        Me.countlabel.Size = New System.Drawing.Size(80, 16)
        Me.countlabel.TabIndex = 12
        Me.countlabel.Text = "meme coins"
        '
        'Tmrcount
        '
        Me.Tmrcount.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.THErealplatformergame.My.Resources.Resources.casino
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 450)
        Me.Controls.Add(Me.countlabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox8)
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
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents countlabel As Label
    Friend WithEvents Tmrcount As Timer
End Class
