<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm2dplatformer
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
        Me.Tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.Picground = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tmrright
        '
        '
        'Tmrleft
        '
        '
        'Tmrup
        '
        '
        'Tmrgravity
        '
        '
        'Picplayer
        '
        Me.Picplayer.Location = New System.Drawing.Point(12, 288)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(55, 52)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.Transparent
        Me.Picair.Location = New System.Drawing.Point(-9, -23)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(824, 363)
        Me.Picair.TabIndex = 2
        Me.Picair.TabStop = False
        '
        'Picground
        '
        Me.Picground.Image = Global.RealPlatromergame.My.Resources.Resources.em_the_therapist
        Me.Picground.Location = New System.Drawing.Point(-9, 404)
        Me.Picground.Name = "Picground"
        Me.Picground.Size = New System.Drawing.Size(1329, 61)
        Me.Picground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picground.TabIndex = 1
        Me.Picground.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox1.Location = New System.Drawing.Point(563, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox2.Location = New System.Drawing.Point(350, 217)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox3.Location = New System.Drawing.Point(903, 171)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox4.Location = New System.Drawing.Point(774, 256)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox5.Location = New System.Drawing.Point(605, 122)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.RealPlatromergame.My.Resources.Resources.vectored
        Me.PictureBox6.Location = New System.Drawing.Point(53, 160)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.RealPlatromergame.My.Resources.Resources._8btkg8
        Me.PictureBox7.Location = New System.Drawing.Point(798, 200)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(41, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "restart"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox8.Image = Global.RealPlatromergame.My.Resources.Resources.slip
        Me.PictureBox8.Location = New System.Drawing.Point(376, 160)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "collectable"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox9.Image = Global.RealPlatromergame.My.Resources.Resources.slip
        Me.PictureBox9.Location = New System.Drawing.Point(85, 104)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "collectable"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.Image = Global.RealPlatromergame.My.Resources.Resources.slip
        Me.PictureBox10.Location = New System.Drawing.Point(626, 66)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 12
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "collectable"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.RealPlatromergame.My.Resources.Resources.em_the_therapist
        Me.PictureBox11.Location = New System.Drawing.Point(-9, 685)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(1329, 61)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        '
        'Frm2dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RealPlatromergame.My.Resources.Resources.casino
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1312, 715)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
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
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "Frm2dplatformer"
        Me.Text = "Form1"
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picground As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents Tmrright As Timer
    Friend WithEvents Tmrleft As Timer
    Friend WithEvents Tmrup As Timer
    Friend WithEvents TmrGamelogic As Timer
    Friend WithEvents Tmrgravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
End Class
