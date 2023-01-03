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
        Me.LTextBox = New System.Windows.Forms.TextBox()
        Me.WTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LTextBox
        '
        Me.LTextBox.Location = New System.Drawing.Point(55, 59)
        Me.LTextBox.Name = "LTextBox"
        Me.LTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LTextBox.TabIndex = 0
        '
        'WTextBox
        '
        Me.WTextBox.Location = New System.Drawing.Point(55, 114)
        Me.WTextBox.Name = "WTextBox"
        Me.WTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width"
        '
        'CButton
        '
        Me.CButton.Location = New System.Drawing.Point(58, 178)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(97, 23)
        Me.CButton.TabIndex = 4
        Me.CButton.Text = "Calculate"
        Me.CButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Area"
        '
        'ATextBox
        '
        Me.ATextBox.Location = New System.Drawing.Point(55, 240)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(100, 22)
        Me.ATextBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ATextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WTextBox)
        Me.Controls.Add(Me.LTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTextBox As TextBox
    Friend WithEvents WTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ATextBox As TextBox
End Class
