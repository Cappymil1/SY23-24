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
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.coinreturnbutton = New System.Windows.Forms.Button()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.nickelpb = New System.Windows.Forms.PictureBox()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.NickelButton = New System.Windows.Forms.Button()
        Me.DimeButton = New System.Windows.Forms.Button()
        Me.QuarterButton = New System.Windows.Forms.Button()
        Me.DollarButton = New System.Windows.Forms.Button()
        Me.buyButton = New System.Windows.Forms.Button()
        Me.idtextbox = New System.Windows.Forms.TextBox()
        Me.Productcontrol16 = New VendingMachine.productcontrol()
        Me.Productcontrol15 = New VendingMachine.productcontrol()
        Me.Productcontrol14 = New VendingMachine.productcontrol()
        Me.Productcontrol13 = New VendingMachine.productcontrol()
        Me.Productcontrol12 = New VendingMachine.productcontrol()
        Me.Productcontrol11 = New VendingMachine.productcontrol()
        Me.Productcontrol10 = New VendingMachine.productcontrol()
        Me.Productcontrol9 = New VendingMachine.productcontrol()
        Me.Productcontrol8 = New VendingMachine.productcontrol()
        Me.Productcontrol7 = New VendingMachine.productcontrol()
        Me.Productcontrol6 = New VendingMachine.productcontrol()
        Me.Productcontrol5 = New VendingMachine.productcontrol()
        Me.Productcontrol4 = New VendingMachine.productcontrol()
        Me.Productcontrol3 = New VendingMachine.productcontrol()
        Me.Productcontrol2 = New VendingMachine.productcontrol()
        Me.Productcontrol1 = New VendingMachine.productcontrol()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(172, 30)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(61, 25)
        Me.totalLabel.TabIndex = 4
        Me.totalLabel.Text = "$0.00"
        '
        'coinreturnbutton
        '
        Me.coinreturnbutton.Location = New System.Drawing.Point(159, 78)
        Me.coinreturnbutton.Name = "coinreturnbutton"
        Me.coinreturnbutton.Size = New System.Drawing.Size(91, 23)
        Me.coinreturnbutton.TabIndex = 5
        Me.coinreturnbutton.Text = "Coin return"
        Me.coinreturnbutton.UseVisualStyleBackColor = True
        '
        'quarterpb
        '
        Me.quarterpb.Image = Global.VendingMachine.My.Resources.Resources.quarter
        Me.quarterpb.Location = New System.Drawing.Point(12, 641)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(78, 36)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quarterpb.TabIndex = 9
        Me.quarterpb.TabStop = False
        '
        'dimepb
        '
        Me.dimepb.Image = Global.VendingMachine.My.Resources.Resources.dime
        Me.dimepb.Location = New System.Drawing.Point(12, 683)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(78, 36)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimepb.TabIndex = 8
        Me.dimepb.TabStop = False
        '
        'nickelpb
        '
        Me.nickelpb.Image = Global.VendingMachine.My.Resources.Resources.Nickel
        Me.nickelpb.Location = New System.Drawing.Point(12, 725)
        Me.nickelpb.Name = "nickelpb"
        Me.nickelpb.Size = New System.Drawing.Size(78, 36)
        Me.nickelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelpb.TabIndex = 7
        Me.nickelpb.TabStop = False
        '
        'dollarpb
        '
        Me.dollarpb.Image = Global.VendingMachine.My.Resources.Resources.Dollarcoin
        Me.dollarpb.Location = New System.Drawing.Point(12, 599)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(78, 36)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarpb.TabIndex = 6
        Me.dollarpb.TabStop = False
        '
        'NickelButton
        '
        Me.NickelButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.Nickel
        Me.NickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NickelButton.Location = New System.Drawing.Point(27, 434)
        Me.NickelButton.Name = "NickelButton"
        Me.NickelButton.Size = New System.Drawing.Size(96, 96)
        Me.NickelButton.TabIndex = 3
        Me.NickelButton.UseVisualStyleBackColor = True
        '
        'DimeButton
        '
        Me.DimeButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dime
        Me.DimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DimeButton.Location = New System.Drawing.Point(129, 434)
        Me.DimeButton.Name = "DimeButton"
        Me.DimeButton.Size = New System.Drawing.Size(96, 93)
        Me.DimeButton.TabIndex = 2
        Me.DimeButton.UseVisualStyleBackColor = True
        '
        'QuarterButton
        '
        Me.QuarterButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.quarter
        Me.QuarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QuarterButton.Location = New System.Drawing.Point(27, 340)
        Me.QuarterButton.Name = "QuarterButton"
        Me.QuarterButton.Size = New System.Drawing.Size(96, 88)
        Me.QuarterButton.TabIndex = 1
        Me.QuarterButton.UseVisualStyleBackColor = True
        '
        'DollarButton
        '
        Me.DollarButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.Dollarcoin
        Me.DollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DollarButton.Location = New System.Drawing.Point(129, 340)
        Me.DollarButton.Name = "DollarButton"
        Me.DollarButton.Size = New System.Drawing.Size(96, 93)
        Me.DollarButton.TabIndex = 0
        Me.DollarButton.UseVisualStyleBackColor = True
        '
        'buyButton
        '
        Me.buyButton.Location = New System.Drawing.Point(159, 136)
        Me.buyButton.Name = "buyButton"
        Me.buyButton.Size = New System.Drawing.Size(100, 23)
        Me.buyButton.TabIndex = 26
        Me.buyButton.Text = "buy"
        Me.buyButton.UseVisualStyleBackColor = True
        '
        'idtextbox
        '
        Me.idtextbox.Location = New System.Drawing.Point(159, 184)
        Me.idtextbox.Name = "idtextbox"
        Me.idtextbox.Size = New System.Drawing.Size(100, 22)
        Me.idtextbox.TabIndex = 27
        '
        'Productcontrol16
        '
        Me.Productcontrol16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol16.count = 5
        Me.Productcontrol16.Location = New System.Drawing.Point(831, 520)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.productID = "D4"
        Me.Productcontrol16.productpicture = Global.VendingMachine.My.Resources.Resources.goated_poptart_duo
        Me.Productcontrol16.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Productcontrol16.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol16.TabIndex = 25
        '
        'Productcontrol15
        '
        Me.Productcontrol15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol15.count = 5
        Me.Productcontrol15.Location = New System.Drawing.Point(677, 520)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.productID = "D3"
        Me.Productcontrol15.productpicture = Global.VendingMachine.My.Resources.Resources.cookies_and_cream_poptarts
        Me.Productcontrol15.productPrice = New Decimal(New Integer() {15, 0, 0, 131072})
        Me.Productcontrol15.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol15.TabIndex = 24
        '
        'Productcontrol14
        '
        Me.Productcontrol14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol14.count = 5
        Me.Productcontrol14.Location = New System.Drawing.Point(523, 520)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.productID = "D2"
        Me.Productcontrol14.productpicture = Global.VendingMachine.My.Resources.Resources.fudge_poptarts
        Me.Productcontrol14.productPrice = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.Productcontrol14.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol14.TabIndex = 23
        '
        'Productcontrol13
        '
        Me.Productcontrol13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol13.count = 5
        Me.Productcontrol13.Location = New System.Drawing.Point(369, 520)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.productID = "D1"
        Me.Productcontrol13.productpicture = Global.VendingMachine.My.Resources.Resources.smores_poptarts
        Me.Productcontrol13.productPrice = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.Productcontrol13.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol13.TabIndex = 22
        '
        'Productcontrol12
        '
        Me.Productcontrol12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol12.count = 5
        Me.Productcontrol12.Location = New System.Drawing.Point(831, 366)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.productID = "C4"
        Me.Productcontrol12.productpicture = Global.VendingMachine.My.Resources.Resources.c4_energy
        Me.Productcontrol12.productPrice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Productcontrol12.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol12.TabIndex = 21
        '
        'Productcontrol11
        '
        Me.Productcontrol11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol11.count = 5
        Me.Productcontrol11.Location = New System.Drawing.Point(677, 366)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.productID = "C3"
        Me.Productcontrol11.productpicture = Global.VendingMachine.My.Resources.Resources.tots
        Me.Productcontrol11.productPrice = New Decimal(New Integer() {215, 0, 0, 131072})
        Me.Productcontrol11.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol11.TabIndex = 20
        '
        'Productcontrol10
        '
        Me.Productcontrol10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol10.count = 5
        Me.Productcontrol10.Location = New System.Drawing.Point(523, 366)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.productID = "C2"
        Me.Productcontrol10.productpicture = Global.VendingMachine.My.Resources.Resources.cheese_pizza
        Me.Productcontrol10.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol10.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol10.TabIndex = 19
        '
        'Productcontrol9
        '
        Me.Productcontrol9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol9.count = 5
        Me.Productcontrol9.Location = New System.Drawing.Point(369, 366)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.productID = "C1"
        Me.Productcontrol9.productpicture = Global.VendingMachine.My.Resources.Resources.coca_cola_espuma
        Me.Productcontrol9.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol9.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol9.TabIndex = 18
        '
        'Productcontrol8
        '
        Me.Productcontrol8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol8.count = 5
        Me.Productcontrol8.Location = New System.Drawing.Point(831, 212)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.productID = "B4"
        Me.Productcontrol8.productpicture = Global.VendingMachine.My.Resources.Resources.mickeyd_sfries
        Me.Productcontrol8.productPrice = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Productcontrol8.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol8.TabIndex = 17
        '
        'Productcontrol7
        '
        Me.Productcontrol7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol7.count = 5
        Me.Productcontrol7.Location = New System.Drawing.Point(677, 212)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.productID = "B3"
        Me.Productcontrol7.productpicture = Global.VendingMachine.My.Resources.Resources.seetpotatofries
        Me.Productcontrol7.productPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol7.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol7.TabIndex = 16
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol6.count = 5
        Me.Productcontrol6.Location = New System.Drawing.Point(523, 212)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productID = "B2"
        Me.Productcontrol6.productpicture = Global.VendingMachine.My.Resources.Resources.beans_on_toast_with_cheese
        Me.Productcontrol6.productPrice = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.Productcontrol6.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol6.TabIndex = 15
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol5.count = 5
        Me.Productcontrol5.Location = New System.Drawing.Point(369, 212)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productID = "B1"
        Me.Productcontrol5.productpicture = Global.VendingMachine.My.Resources.Resources.piza_rols
        Me.Productcontrol5.productPrice = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.Productcontrol5.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol5.TabIndex = 14
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol4.count = 5
        Me.Productcontrol4.Location = New System.Drawing.Point(831, 58)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productID = "A4"
        Me.Productcontrol4.productpicture = Global.VendingMachine.My.Resources.Resources.macncheesepizza
        Me.Productcontrol4.productPrice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol4.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol4.TabIndex = 13
        '
        'Productcontrol3
        '
        Me.Productcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol3.count = 5
        Me.Productcontrol3.Location = New System.Drawing.Point(677, 58)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.productID = "A3"
        Me.Productcontrol3.productpicture = Global.VendingMachine.My.Resources.Resources.fries
        Me.Productcontrol3.productPrice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol3.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol3.TabIndex = 12
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol2.count = 5
        Me.Productcontrol2.Location = New System.Drawing.Point(523, 58)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productID = "A2"
        Me.Productcontrol2.productpicture = Global.VendingMachine.My.Resources.Resources.onionrings
        Me.Productcontrol2.productPrice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol2.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol2.TabIndex = 11
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol1.count = 5
        Me.Productcontrol1.Location = New System.Drawing.Point(369, 58)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productID = "A1"
        Me.Productcontrol1.productpicture = Global.VendingMachine.My.Resources.Resources.curlyfries
        Me.Productcontrol1.productPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol1.Size = New System.Drawing.Size(148, 148)
        Me.Productcontrol1.TabIndex = 10
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(523, 693)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(302, 157)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 28
        Me.ProductPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 862)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.idtextbox)
        Me.Controls.Add(Me.buyButton)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.nickelpb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.coinreturnbutton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.NickelButton)
        Me.Controls.Add(Me.DimeButton)
        Me.Controls.Add(Me.QuarterButton)
        Me.Controls.Add(Me.DollarButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DollarButton As Button
    Friend WithEvents QuarterButton As Button
    Friend WithEvents DimeButton As Button
    Friend WithEvents NickelButton As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents coinreturnbutton As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents nickelpb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents Productcontrol3 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
    Friend WithEvents Productcontrol7 As productcontrol
    Friend WithEvents Productcontrol8 As productcontrol
    Friend WithEvents Productcontrol9 As productcontrol
    Friend WithEvents Productcontrol10 As productcontrol
    Friend WithEvents Productcontrol11 As productcontrol
    Friend WithEvents Productcontrol12 As productcontrol
    Friend WithEvents Productcontrol13 As productcontrol
    Friend WithEvents Productcontrol14 As productcontrol
    Friend WithEvents Productcontrol15 As productcontrol
    Friend WithEvents Productcontrol16 As productcontrol
    Friend WithEvents buyButton As Button
    Friend WithEvents idtextbox As TextBox
    Friend WithEvents ProductPictureBox As PictureBox
End Class
