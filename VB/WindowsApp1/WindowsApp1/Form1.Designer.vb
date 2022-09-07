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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.CCtextbox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.amtextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuyButton
        '
        Me.BuyButton.Location = New System.Drawing.Point(66, 411)
        Me.BuyButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(95, 30)
        Me.BuyButton.TabIndex = 1
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = True
        '
        'CCtextbox
        '
        Me.CCtextbox.Location = New System.Drawing.Point(149, 184)
        Me.CCtextbox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CCtextbox.Name = "CCtextbox"
        Me.CCtextbox.Size = New System.Drawing.Size(267, 28)
        Me.CCtextbox.TabIndex = 2
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(149, 122)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(267, 28)
        Me.nameTextBox.TabIndex = 4
        '
        'ExpTextBox
        '
        Me.ExpTextBox.Location = New System.Drawing.Point(149, 247)
        Me.ExpTextBox.Name = "ExpTextBox"
        Me.ExpTextBox.Size = New System.Drawing.Size(267, 28)
        Me.ExpTextBox.TabIndex = 5
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(149, 306)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(267, 28)
        Me.ZipTextBox.TabIndex = 8
        '
        'amtextBox
        '
        Me.amtextBox.Location = New System.Drawing.Point(149, 364)
        Me.amtextBox.Name = "amtextBox"
        Me.amtextBox.Size = New System.Drawing.Size(267, 28)
        Me.amtextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Credit card #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Expiration Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Amount "
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(206, 411)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(84, 29)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 72)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Amazonk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 39)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Totally not malware "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(688, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(669, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(319, 27)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Give me your mom's credit card"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(493, -6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 124)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(629, -6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(129, 124)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(334, 27)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Vbucks and Robux free generator"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(682, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 36)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = " "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(-20, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(41, 78)
        Me.Panel1.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(487, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(283, 36)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Totally legit program"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(452, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Fee"
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(493, 364)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(211, 28)
        Me.FeeTextBox.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 526)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.amtextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.ExpTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.CCtextbox)
        Me.Controls.Add(Me.BuyButton)
        Me.Font = New System.Drawing.Font("Bodoni MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "My App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuyButton As Button
    Friend WithEvents CCtextbox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents ExpTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents amtextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FeeTextBox As TextBox
End Class
