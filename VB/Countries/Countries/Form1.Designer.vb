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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OriginTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.Lastbutton = New System.Windows.Forms.Button()
        Me.Previousbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.coinsComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RarityTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.currentLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(122, 188)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(173, 27)
        Me.NameTextBox.TabIndex = 0
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(122, 234)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(173, 27)
        Me.YearTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Year Created:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Orignin Country:"
        '
        'OriginTextBox
        '
        Me.OriginTextBox.Location = New System.Drawing.Point(122, 278)
        Me.OriginTextBox.Name = "OriginTextBox"
        Me.OriginTextBox.Size = New System.Drawing.Size(173, 27)
        Me.OriginTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Market Value:"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Location = New System.Drawing.Point(122, 322)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(173, 27)
        Me.ValueTextBox.TabIndex = 6
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayPictureBox.Location = New System.Drawing.Point(334, 150)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(217, 245)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 8
        Me.DisplayPictureBox.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(246, 41)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 29)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(362, 41)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"" "
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(122, 88)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(94, 29)
        Me.FirstButton.TabIndex = 13
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'Lastbutton
        '
        Me.Lastbutton.Location = New System.Drawing.Point(484, 88)
        Me.Lastbutton.Name = "Lastbutton"
        Me.Lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.Lastbutton.TabIndex = 14
        Me.Lastbutton.Text = "Last"
        Me.Lastbutton.UseVisualStyleBackColor = True
        '
        'Previousbutton
        '
        Me.Previousbutton.Location = New System.Drawing.Point(362, 88)
        Me.Previousbutton.Name = "Previousbutton"
        Me.Previousbutton.Size = New System.Drawing.Size(94, 29)
        Me.Previousbutton.TabIndex = 15
        Me.Previousbutton.Text = "Previous"
        Me.Previousbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(246, 88)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 16
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(484, 41)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(94, 29)
        Me.addButton.TabIndex = 17
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(122, 41)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 29)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'coinsComboBox
        '
        Me.coinsComboBox.FormattingEnabled = True
        Me.coinsComboBox.Location = New System.Drawing.Point(122, 150)
        Me.coinsComboBox.Name = "coinsComboBox"
        Me.coinsComboBox.Size = New System.Drawing.Size(173, 28)
        Me.coinsComboBox.TabIndex = 19
        '
        'DisplayPictureBox2
        '
        Me.DisplayPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayPictureBox2.Location = New System.Drawing.Point(557, 150)
        Me.DisplayPictureBox2.Name = "DisplayPictureBox2"
        Me.DisplayPictureBox2.Size = New System.Drawing.Size(217, 245)
        Me.DisplayPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox2.TabIndex = 20
        Me.DisplayPictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "&Rarity:"
        '
        'RarityTextBox
        '
        Me.RarityTextBox.Location = New System.Drawing.Point(122, 368)
        Me.RarityTextBox.Name = "RarityTextBox"
        Me.RarityTextBox.Size = New System.Drawing.Size(173, 27)
        Me.RarityTextBox.TabIndex = 21
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'currentLabel
        '
        Me.currentLabel.AutoSize = True
        Me.currentLabel.Location = New System.Drawing.Point(123, 410)
        Me.currentLabel.Name = "currentLabel"
        Me.currentLabel.Size = New System.Drawing.Size(13, 20)
        Me.currentLabel.TabIndex = 23
        Me.currentLabel.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Coin:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.currentLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RarityTextBox)
        Me.Controls.Add(Me.DisplayPictureBox2)
        Me.Controls.Add(Me.coinsComboBox)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.Previousbutton)
        Me.Controls.Add(Me.Lastbutton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ValueTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OriginTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Form1"
        Me.Text = "Coins"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OriginTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ValueTextBox As TextBox
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DebugTextBox As TextBox
    Friend WithEvents FirstButton As Button
    Friend WithEvents Lastbutton As Button
    Friend WithEvents Previousbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents coinsComboBox As ComboBox
    Friend WithEvents DisplayPictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RarityTextBox As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents currentLabel As Label
    Friend WithEvents Label6 As Label
End Class
