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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.yearcreatedTextBox = New System.Windows.Forms.TextBox()
        Me.marketvalueTextBox = New System.Windows.Forms.TextBox()
        Me.origincountryTextBox = New System.Windows.Forms.TextBox()
        Me.RarityTextBox = New System.Windows.Forms.TextBox()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.displayPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(127, 146)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(125, 27)
        Me.nameTextBox.TabIndex = 0
        '
        'yearcreatedTextBox
        '
        Me.yearcreatedTextBox.Location = New System.Drawing.Point(127, 204)
        Me.yearcreatedTextBox.Name = "yearcreatedTextBox"
        Me.yearcreatedTextBox.Size = New System.Drawing.Size(125, 27)
        Me.yearcreatedTextBox.TabIndex = 1
        '
        'marketvalueTextBox
        '
        Me.marketvalueTextBox.Location = New System.Drawing.Point(127, 320)
        Me.marketvalueTextBox.Name = "marketvalueTextBox"
        Me.marketvalueTextBox.Size = New System.Drawing.Size(125, 27)
        Me.marketvalueTextBox.TabIndex = 3
        '
        'origincountryTextBox
        '
        Me.origincountryTextBox.Location = New System.Drawing.Point(127, 262)
        Me.origincountryTextBox.Name = "origincountryTextBox"
        Me.origincountryTextBox.Size = New System.Drawing.Size(125, 27)
        Me.origincountryTextBox.TabIndex = 2
        '
        'RarityTextBox
        '
        Me.RarityTextBox.Location = New System.Drawing.Point(127, 378)
        Me.RarityTextBox.Name = "RarityTextBox"
        Me.RarityTextBox.Size = New System.Drawing.Size(125, 27)
        Me.RarityTextBox.TabIndex = 4
        '
        'displayPictureBox
        '
        Me.displayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayPictureBox.Location = New System.Drawing.Point(434, 146)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(167, 128)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 5
        Me.displayPictureBox.TabStop = False
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(250, 65)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(94, 29)
        Me.nextButton.TabIndex = 6
        Me.nextButton.Text = "&Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'displayPictureBox2
        '
        Me.displayPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.displayPictureBox2.Location = New System.Drawing.Point(434, 272)
        Me.displayPictureBox2.Name = "displayPictureBox2"
        Me.displayPictureBox2.Size = New System.Drawing.Size(167, 133)
        Me.displayPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox2.TabIndex = 7
        Me.displayPictureBox2.TabStop = False
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(481, 65)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(94, 29)
        Me.LastButton.TabIndex = 8
        Me.LastButton.Text = "&Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(127, 65)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(94, 29)
        Me.FirstButton.TabIndex = 9
        Me.FirstButton.Text = "&First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(364, 65)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(94, 29)
        Me.previousButton.TabIndex = 10
        Me.previousButton.Text = "&Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(127, 12)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 29)
        Me.DeleteButton.TabIndex = 22
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(481, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(94, 29)
        Me.addButton.TabIndex = 21
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(364, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(250, 12)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 29)
        Me.SaveButton.TabIndex = 19
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Year Created:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Orign Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Market Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Rarity:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.displayPictureBox2)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.RarityTextBox)
        Me.Controls.Add(Me.marketvalueTextBox)
        Me.Controls.Add(Me.origincountryTextBox)
        Me.Controls.Add(Me.yearcreatedTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents yearcreatedTextBox As TextBox
    Friend WithEvents marketvalueTextBox As TextBox
    Friend WithEvents origincountryTextBox As TextBox
    Friend WithEvents RarityTextBox As TextBox
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents nextButton As Button
    Friend WithEvents displayPictureBox2 As PictureBox
    Friend WithEvents LastButton As Button
    Friend WithEvents FirstButton As Button
    Friend WithEvents previousButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
