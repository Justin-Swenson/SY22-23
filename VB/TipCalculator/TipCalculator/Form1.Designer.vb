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
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipTextBox = New System.Windows.Forms.TextBox()
        Me.GrandtotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.enterbutton = New System.Windows.Forms.Button()
        Me.tipLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(12, 103)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(146, 22)
        Me.PriceTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter price here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please enter tip percent here"
        '
        'TipTextBox
        '
        Me.TipTextBox.Location = New System.Drawing.Point(12, 190)
        Me.TipTextBox.Name = "TipTextBox"
        Me.TipTextBox.Size = New System.Drawing.Size(146, 22)
        Me.TipTextBox.TabIndex = 4
        '
        'GrandtotalTextBox
        '
        Me.GrandtotalTextBox.Location = New System.Drawing.Point(9, 498)
        Me.GrandtotalTextBox.Name = "GrandtotalTextBox"
        Me.GrandtotalTextBox.Size = New System.Drawing.Size(149, 22)
        Me.GrandtotalTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 465)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grandtotal"
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(12, 278)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.Size = New System.Drawing.Size(146, 22)
        Me.taxTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "sales tax"
        '
        'enterbutton
        '
        Me.enterbutton.Location = New System.Drawing.Point(12, 321)
        Me.enterbutton.Name = "enterbutton"
        Me.enterbutton.Size = New System.Drawing.Size(75, 31)
        Me.enterbutton.TabIndex = 10
        Me.enterbutton.Text = "Enter"
        Me.enterbutton.UseVisualStyleBackColor = True
        '
        'tipLabel
        '
        Me.tipLabel.AutoSize = True
        Me.tipLabel.Location = New System.Drawing.Point(161, 196)
        Me.tipLabel.Name = "tipLabel"
        Me.tipLabel.Size = New System.Drawing.Size(0, 16)
        Me.tipLabel.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Blackadder ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(554, 39)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Thank you for dining at ""insert generic restaurant name"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Subtotal"
        '
        'SubTextBox
        '
        Me.SubTextBox.Location = New System.Drawing.Point(9, 412)
        Me.SubTextBox.Name = "SubTextBox"
        Me.SubTextBox.Size = New System.Drawing.Size(149, 22)
        Me.SubTextBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 532)
        Me.Controls.Add(Me.SubTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tipLabel)
        Me.Controls.Add(Me.enterbutton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrandtotalTextBox)
        Me.Controls.Add(Me.TipTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TipTextBox As TextBox
    Friend WithEvents GrandtotalTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents taxTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents enterbutton As Button
    Friend WithEvents tipLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SubTextBox As TextBox
End Class
