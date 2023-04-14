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
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.CapitalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.populationTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sizeTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.Lastbutton = New System.Windows.Forms.Button()
        Me.Previousbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.countryComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(113, 163)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CountryTextBox.TabIndex = 0
        '
        'CapitalTextBox
        '
        Me.CapitalTextBox.Location = New System.Drawing.Point(113, 209)
        Me.CapitalTextBox.Name = "CapitalTextBox"
        Me.CapitalTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CapitalTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Capital:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Population:"
        '
        'populationTextBox
        '
        Me.populationTextBox.Location = New System.Drawing.Point(113, 253)
        Me.populationTextBox.Name = "populationTextBox"
        Me.populationTextBox.Size = New System.Drawing.Size(125, 27)
        Me.populationTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Size:"
        '
        'sizeTextBox
        '
        Me.sizeTextBox.Location = New System.Drawing.Point(113, 297)
        Me.sizeTextBox.Name = "sizeTextBox"
        Me.sizeTextBox.Size = New System.Drawing.Size(125, 27)
        Me.sizeTextBox.TabIndex = 6
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayPictureBox.Location = New System.Drawing.Point(310, 163)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(258, 161)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 8
        Me.DisplayPictureBox.TabStop = False
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(176, 41)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(94, 29)
        Me.NewButton.TabIndex = 9
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(304, 41)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 29)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(424, 41)
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
        Me.addButton.Location = New System.Drawing.Point(551, 41)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(94, 29)
        Me.addButton.TabIndex = 17
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(55, 41)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 29)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'countryComboBox
        '
        Me.countryComboBox.FormattingEnabled = True
        Me.countryComboBox.Location = New System.Drawing.Point(615, 140)
        Me.countryComboBox.Name = "countryComboBox"
        Me.countryComboBox.Size = New System.Drawing.Size(151, 28)
        Me.countryComboBox.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.countryComboBox)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.Previousbutton)
        Me.Controls.Add(Me.Lastbutton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sizeTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.populationTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CapitalTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Name = "Form1"
        Me.Text = "Countries"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents CapitalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents populationTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sizeTextBox As TextBox
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents NewButton As Button
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
    Friend WithEvents countryComboBox As ComboBox
End Class
