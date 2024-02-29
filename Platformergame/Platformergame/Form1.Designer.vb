<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2dplatformer
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
        Me.TMRright = New System.Windows.Forms.Timer(Me.components)
        Me.TMRleft = New System.Windows.Forms.Timer(Me.components)
        Me.TMRUp = New System.Windows.Forms.Timer(Me.components)
        Me.Timergamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.Timergravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Picground = New System.Windows.Forms.PictureBox()
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMRright
        '
        Me.TMRright.Interval = 20
        '
        'TMRleft
        '
        Me.TMRleft.Interval = 20
        '
        'TMRUp
        '
        Me.TMRUp.Interval = 20
        '
        'Timergamelogic
        '
        Me.Timergamelogic.Interval = 20
        '
        'Timergravity
        '
        Me.Timergravity.Interval = 20
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Platformergame.My.Resources.Resources.vectored
        Me.PictureBox4.Location = New System.Drawing.Point(319, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Platformergame.My.Resources.Resources.vectored
        Me.PictureBox3.Location = New System.Drawing.Point(568, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Platformergame.My.Resources.Resources.vectored
        Me.PictureBox2.Location = New System.Drawing.Point(285, 214)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Platformergame.My.Resources.Resources.vectored
        Me.PictureBox1.Location = New System.Drawing.Point(552, 283)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'Picground
        '
        Me.Picground.Location = New System.Drawing.Point(0, 402)
        Me.Picground.Name = "Picground"
        Me.Picground.Size = New System.Drawing.Size(836, 79)
        Me.Picground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picground.TabIndex = 2
        Me.Picground.TabStop = False
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.Color.Red
        Me.Picplayer.Image = Global.Platformergame.My.Resources.Resources.bruh
        Me.Picplayer.Location = New System.Drawing.Point(35, 263)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(38, 35)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.Transparent
        Me.Picair.Location = New System.Drawing.Point(0, -8)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(802, 350)
        Me.Picair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'Form2dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Platformergame.My.Resources.Resources.casino
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picground)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.Picair)
        Me.Name = "Form2dplatformer"
        Me.Text = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents Picground As PictureBox
    Friend WithEvents TMRright As Timer
    Friend WithEvents TMRleft As Timer
    Friend WithEvents TMRUp As Timer
    Friend WithEvents Timergamelogic As Timer
    Friend WithEvents Timergravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
