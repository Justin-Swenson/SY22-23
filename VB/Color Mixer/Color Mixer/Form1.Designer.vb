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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RedScrollBar = New System.Windows.Forms.HScrollBar()
        Me.GreenScrollBar = New System.Windows.Forms.HScrollBar()
        Me.BlueScrollBar = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Red (0 to 255)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Green (0 to 255)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Blue (0 to 255)"
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(381, 42)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(233, 245)
        Me.ColorButton.TabIndex = 6
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(12, 361)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 77)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RedScrollBar
        '
        Me.RedScrollBar.Location = New System.Drawing.Point(36, 83)
        Me.RedScrollBar.Maximum = 255
        Me.RedScrollBar.Name = "RedScrollBar"
        Me.RedScrollBar.Size = New System.Drawing.Size(307, 29)
        Me.RedScrollBar.TabIndex = 9
        '
        'GreenScrollBar
        '
        Me.GreenScrollBar.Location = New System.Drawing.Point(36, 183)
        Me.GreenScrollBar.Maximum = 255
        Me.GreenScrollBar.Name = "GreenScrollBar"
        Me.GreenScrollBar.Size = New System.Drawing.Size(307, 29)
        Me.GreenScrollBar.TabIndex = 10
        '
        'BlueScrollBar
        '
        Me.BlueScrollBar.Location = New System.Drawing.Point(40, 293)
        Me.BlueScrollBar.Name = "BlueScrollBar"
        Me.BlueScrollBar.Size = New System.Drawing.Size(303, 41)
        Me.BlueScrollBar.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 450)
        Me.Controls.Add(Me.BlueScrollBar)
        Me.Controls.Add(Me.GreenScrollBar)
        Me.Controls.Add(Me.RedScrollBar)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Color Mixer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RedScrollBar As HScrollBar
    Friend WithEvents GreenScrollBar As HScrollBar
    Friend WithEvents BlueScrollBar As HScrollBar
End Class
