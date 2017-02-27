<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdopen = New System.Windows.Forms.Button()
        Me.cmdconvers = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdcolor = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdopen
        '
        Me.cmdopen.Location = New System.Drawing.Point(407, 145)
        Me.cmdopen.Name = "cmdopen"
        Me.cmdopen.Size = New System.Drawing.Size(216, 32)
        Me.cmdopen.TabIndex = 0
        Me.cmdopen.Text = "Open / Select My Photo.."
        Me.ToolTip1.SetToolTip(Me.cmdopen, "Choisissez votre image à transformer en icône")
        Me.cmdopen.UseVisualStyleBackColor = True
        '
        'cmdconvers
        '
        Me.cmdconvers.Enabled = False
        Me.cmdconvers.Location = New System.Drawing.Point(407, 183)
        Me.cmdconvers.Name = "cmdconvers"
        Me.cmdconvers.Size = New System.Drawing.Size(214, 65)
        Me.cmdconvers.TabIndex = 1
        Me.cmdconvers.Text = "Convert Now"
        Me.ToolTip1.SetToolTip(Me.cmdconvers, "Convertir l'image en icône")
        Me.cmdconvers.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Pic.Location = New System.Drawing.Point(12, 10)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(369, 205)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic.TabIndex = 2
        Me.Pic.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdcolor)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 133)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Choisissez votre taille d'icône avant d'ouvrir une image")
        '
        'cmdcolor
        '
        Me.cmdcolor.Location = New System.Drawing.Point(169, 26)
        Me.cmdcolor.Name = "cmdcolor"
        Me.cmdcolor.Size = New System.Drawing.Size(45, 23)
        Me.cmdcolor.TabIndex = 5
        Me.cmdcolor.Text = "temp"
        Me.cmdcolor.UseVisualStyleBackColor = True
        Me.cmdcolor.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(52, 96)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Change to 96 * 96"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(52, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Change to 48 * 48"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(52, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Change to 32 * 32"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(201, 232)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(170, 12)
        Me.lblinfo.TabIndex = 4
        Me.lblinfo.Text = "Eslam Nawara  |  Copyright © 2017-2018"
        '
        'ToolTip1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Creer icône"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "https://github.com/eslamnawara"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.cmdconvers)
        Me.Controls.Add(Me.cmdopen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Convert to Icon 1.3.1 © - Change all my Photos into Icons"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdopen As System.Windows.Forms.Button
    Friend WithEvents cmdconvers As System.Windows.Forms.Button
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmdcolor As Button
    Friend WithEvents lblinfo As Label
    Friend WithEvents Label1 As Label
End Class
