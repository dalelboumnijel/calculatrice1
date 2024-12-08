<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.equal = New System.Windows.Forms.Button()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.Lab1 = New System.Windows.Forms.Label()
        Me.Lab2 = New System.Windows.Forms.Label()
        Me.rest = New System.Windows.Forms.Button()
        Me.lbl_res = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btn4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn4.Location = New System.Drawing.Point(366, 310)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(145, 39)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "/"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btn2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn2.Location = New System.Drawing.Point(366, 230)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(145, 39)
        Me.Btn2.TabIndex = 5
        Me.Btn2.Text = "-"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btn3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn3.Location = New System.Drawing.Point(140, 310)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(145, 39)
        Me.Btn3.TabIndex = 8
        Me.Btn3.Text = "*"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btn1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn1.Location = New System.Drawing.Point(140, 230)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(145, 39)
        Me.Btn1.TabIndex = 10
        Me.Btn1.Text = "+"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'txt_A
        '
        Me.txt_A.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txt_A.Location = New System.Drawing.Point(244, 29)
        Me.txt_A.Multiline = True
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(474, 38)
        Me.txt_A.TabIndex = 11
        '
        'equal
        '
        Me.equal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.equal.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equal.Location = New System.Drawing.Point(585, 230)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(133, 39)
        Me.equal.TabIndex = 15
        Me.equal.Text = "="
        Me.equal.UseVisualStyleBackColor = False
        '
        'txt_B
        '
        Me.txt_B.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txt_B.Location = New System.Drawing.Point(245, 97)
        Me.txt_B.Multiline = True
        Me.txt_B.Name = "txt_B"
        Me.txt_B.Size = New System.Drawing.Size(473, 37)
        Me.txt_B.TabIndex = 16
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Lab1.Font = New System.Drawing.Font("Algerian", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lab1.Location = New System.Drawing.Point(99, 25)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(47, 41)
        Me.Lab1.TabIndex = 17
        Me.Lab1.Text = "A"
        '
        'Lab2
        '
        Me.Lab2.AutoSize = True
        Me.Lab2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Lab2.Font = New System.Drawing.Font("Algerian", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lab2.Location = New System.Drawing.Point(99, 97)
        Me.Lab2.Name = "Lab2"
        Me.Lab2.Size = New System.Drawing.Size(43, 41)
        Me.Lab2.TabIndex = 18
        Me.Lab2.Text = "B"
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.rest.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rest.Location = New System.Drawing.Point(585, 310)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(133, 39)
        Me.rest.TabIndex = 19
        Me.rest.Text = "rest"
        Me.rest.UseVisualStyleBackColor = False
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.Font = New System.Drawing.Font("Algerian", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res.Location = New System.Drawing.Point(312, 385)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(222, 45)
        Me.lbl_res.TabIndex = 20
        Me.lbl_res.Text = "Resultat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.rest)
        Me.Controls.Add(Me.Lab2)
        Me.Controls.Add(Me.Lab1)
        Me.Controls.Add(Me.txt_B)
        Me.Controls.Add(Me.equal)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents txt_A As TextBox
    Friend WithEvents equal As Button
    Friend WithEvents txt_B As TextBox
    Friend WithEvents Lab1 As Label
    Friend WithEvents Lab2 As Label
    Friend WithEvents rest As Button
    Friend WithEvents lbl_res As Label
End Class
