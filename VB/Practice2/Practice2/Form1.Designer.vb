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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BerberPictureBox = New System.Windows.Forms.PictureBox()
        Me.NylonPictureBox = New System.Windows.Forms.PictureBox()
        Me.WoolPictureBox = New System.Windows.Forms.PictureBox()
        Me.Displaypicturebox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pricelabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        CType(Me.BerberPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NylonPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WoolPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Displaypicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Wool", "Berber", "Nylon"})
        Me.ComboBox1.Location = New System.Drawing.Point(136, 216)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'BerberPictureBox
        '
        Me.BerberPictureBox.Image = CType(resources.GetObject("BerberPictureBox.Image"), System.Drawing.Image)
        Me.BerberPictureBox.Location = New System.Drawing.Point(688, 110)
        Me.BerberPictureBox.Name = "BerberPictureBox"
        Me.BerberPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.BerberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BerberPictureBox.TabIndex = 2
        Me.BerberPictureBox.TabStop = False
        Me.BerberPictureBox.Visible = False
        '
        'NylonPictureBox
        '
        Me.NylonPictureBox.Image = CType(resources.GetObject("NylonPictureBox.Image"), System.Drawing.Image)
        Me.NylonPictureBox.Location = New System.Drawing.Point(688, 216)
        Me.NylonPictureBox.Name = "NylonPictureBox"
        Me.NylonPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.NylonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NylonPictureBox.TabIndex = 3
        Me.NylonPictureBox.TabStop = False
        Me.NylonPictureBox.Visible = False
        '
        'WoolPictureBox
        '
        Me.WoolPictureBox.Image = CType(resources.GetObject("WoolPictureBox.Image"), System.Drawing.Image)
        Me.WoolPictureBox.Location = New System.Drawing.Point(688, 4)
        Me.WoolPictureBox.Name = "WoolPictureBox"
        Me.WoolPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.WoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WoolPictureBox.TabIndex = 4
        Me.WoolPictureBox.TabStop = False
        Me.WoolPictureBox.Visible = False
        '
        'Displaypicturebox
        '
        Me.Displaypicturebox.Location = New System.Drawing.Point(136, 35)
        Me.Displaypicturebox.Name = "Displaypicturebox"
        Me.Displaypicturebox.Size = New System.Drawing.Size(175, 175)
        Me.Displaypicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Displaypicturebox.TabIndex = 5
        Me.Displaypicturebox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Price:"
        '
        'Pricelabel
        '
        Me.Pricelabel.AutoSize = True
        Me.Pricelabel.Location = New System.Drawing.Point(186, 249)
        Me.Pricelabel.Name = "Pricelabel"
        Me.Pricelabel.Size = New System.Drawing.Size(0, 20)
        Me.Pricelabel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Width:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Length:"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(199, 277)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(125, 27)
        Me.LengthTextBox.TabIndex = 11
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(199, 310)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(125, 27)
        Me.WidthTextBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cost:"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(181, 344)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(0, 20)
        Me.CostLabel.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pricelabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Displaypicturebox)
        Me.Controls.Add(Me.WoolPictureBox)
        Me.Controls.Add(Me.NylonPictureBox)
        Me.Controls.Add(Me.BerberPictureBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BerberPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NylonPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WoolPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Displaypicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BerberPictureBox As PictureBox
    Friend WithEvents NylonPictureBox As PictureBox
    Friend WithEvents WoolPictureBox As PictureBox
    Friend WithEvents Displaypicturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pricelabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CostLabel As Label
End Class
