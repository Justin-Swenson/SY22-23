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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.volumelabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Length:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Height:"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(111, 81)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(125, 27)
        Me.LengthTextBox.TabIndex = 4
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(111, 114)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(125, 27)
        Me.WidthTextBox.TabIndex = 5
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(111, 147)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(125, 27)
        Me.HeightTextBox.TabIndex = 6
        '
        'volumelabel
        '
        Me.volumelabel.AutoSize = True
        Me.volumelabel.Location = New System.Drawing.Point(116, 185)
        Me.volumelabel.Name = "volumelabel"
        Me.volumelabel.Size = New System.Drawing.Size(0, 20)
        Me.volumelabel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Volume:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.volumelabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents volumelabel As Label
    Friend WithEvents Label4 As Label
End Class
