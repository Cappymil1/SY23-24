<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productcontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.pricelabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.inventorylabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(47, 119)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(48, 16)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "Label1"
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Location = New System.Drawing.Point(3, 119)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(48, 16)
        Me.pricelabel.TabIndex = 2
        Me.pricelabel.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'inventorylabel
        '
        Me.inventorylabel.AutoSize = True
        Me.inventorylabel.Location = New System.Drawing.Point(101, 119)
        Me.inventorylabel.Name = "inventorylabel"
        Me.inventorylabel.Size = New System.Drawing.Size(48, 16)
        Me.inventorylabel.TabIndex = 3
        Me.inventorylabel.Text = "Label1"
        '
        'productcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.inventorylabel)
        Me.Controls.Add(Me.pricelabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "productcontrol"
        Me.Size = New System.Drawing.Size(148, 148)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents pricelabel As Label
    Friend WithEvents inventorylabel As Label
End Class
