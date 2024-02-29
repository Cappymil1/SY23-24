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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MoneyamountLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dollarPictureBoxbutton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Reelcontrol3 = New slotmachine.reelcontrol()
        Me.Reelcontrol2 = New slotmachine.reelcontrol()
        Me.Reelcontrol1 = New slotmachine.reelcontrol()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(229, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 87)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SPIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "[anger].jpg")
        Me.ImageList1.Images.SetKeyName(1, "2sides.jpg")
        Me.ImageList1.Images.SetKeyName(2, "8f7wz1.jpg")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(625, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Money that you have"
        '
        'MoneyamountLabel
        '
        Me.MoneyamountLabel.AutoSize = True
        Me.MoneyamountLabel.Location = New System.Drawing.Point(681, 299)
        Me.MoneyamountLabel.Name = "MoneyamountLabel"
        Me.MoneyamountLabel.Size = New System.Drawing.Size(14, 16)
        Me.MoneyamountLabel.TabIndex = 9
        Me.MoneyamountLabel.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(331, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "claim prize"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(331, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "show #'s"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dollarPictureBoxbutton
        '
        Me.dollarPictureBoxbutton.BackgroundImage = Global.slotmachine.My.Resources.Resources.Dollarcoin
        Me.dollarPictureBoxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dollarPictureBoxbutton.Location = New System.Drawing.Point(546, 360)
        Me.dollarPictureBoxbutton.Name = "dollarPictureBoxbutton"
        Me.dollarPictureBoxbutton.Size = New System.Drawing.Size(100, 50)
        Me.dollarPictureBoxbutton.TabIndex = 14
        Me.dollarPictureBoxbutton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.slotmachine.My.Resources.Resources.quarter
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(668, 358)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 52)
        Me.Button5.TabIndex = 15
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Reelcontrol3.itemvalue = 0
        Me.Reelcontrol3.Location = New System.Drawing.Point(523, 44)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol3.spintime = 2000
        Me.Reelcontrol3.TabIndex = 4
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Reelcontrol2.itemvalue = 0
        Me.Reelcontrol2.Location = New System.Drawing.Point(290, 44)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol2.spintime = 2000
        Me.Reelcontrol2.TabIndex = 3
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Reelcontrol1.itemvalue = 0
        Me.Reelcontrol1.Location = New System.Drawing.Point(86, 44)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol1.spintime = 2000
        Me.Reelcontrol1.TabIndex = 2
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.slotmachine.My.Resources.Resources.casino
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.dollarPictureBoxbutton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MoneyamountLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Reelcontrol1 As reelcontrol
    Friend WithEvents Reelcontrol2 As reelcontrol
    Friend WithEvents Reelcontrol3 As reelcontrol
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MoneyamountLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dollarPictureBoxbutton As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer2 As Timer
End Class
