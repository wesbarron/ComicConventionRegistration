<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComic
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtBoxGroup = New System.Windows.Forms.TextBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdBtn3 = New System.Windows.Forms.RadioButton()
        Me.rdBtn2 = New System.Windows.Forms.RadioButton()
        Me.rdBtn1 = New System.Windows.Forms.RadioButton()
        Me.lblRegsCost = New System.Windows.Forms.Label()
        Me.lblRegsTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Comic_Convention_Registration.My.Resources.Resources.comic
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Crimson
        Me.lblHeading.Location = New System.Drawing.Point(103, 202)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(435, 40)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Crimson
        Me.lblGroupSize.Location = New System.Drawing.Point(215, 255)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(119, 27)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtBoxGroup
        '
        Me.txtBoxGroup.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxGroup.ForeColor = System.Drawing.Color.Crimson
        Me.txtBoxGroup.Location = New System.Drawing.Point(370, 252)
        Me.txtBoxGroup.Name = "txtBoxGroup"
        Me.txtBoxGroup.Size = New System.Drawing.Size(43, 34)
        Me.txtBoxGroup.TabIndex = 3
        Me.txtBoxGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpType.Controls.Add(Me.rdBtn3)
        Me.grpType.Controls.Add(Me.rdBtn2)
        Me.grpType.Controls.Add(Me.rdBtn1)
        Me.grpType.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.Location = New System.Drawing.Point(74, 314)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(493, 137)
        Me.grpType.TabIndex = 4
        Me.grpType.TabStop = False
        Me.grpType.Text = "Select Badge Type:"
        '
        'rdBtn3
        '
        Me.rdBtn3.AutoSize = True
        Me.rdBtn3.Location = New System.Drawing.Point(19, 98)
        Me.rdBtn3.Name = "rdBtn3"
        Me.rdBtn3.Size = New System.Drawing.Size(126, 31)
        Me.rdBtn3.TabIndex = 2
        Me.rdBtn3.TabStop = True
        Me.rdBtn3.Text = "Convention"
        Me.rdBtn3.UseVisualStyleBackColor = True
        '
        'rdBtn2
        '
        Me.rdBtn2.AutoSize = True
        Me.rdBtn2.Location = New System.Drawing.Point(19, 61)
        Me.rdBtn2.Name = "rdBtn2"
        Me.rdBtn2.Size = New System.Drawing.Size(257, 31)
        Me.rdBtn2.TabIndex = 1
        Me.rdBtn2.TabStop = True
        Me.rdBtn2.Text = "Convention + Autographs"
        Me.rdBtn2.UseVisualStyleBackColor = True
        '
        'rdBtn1
        '
        Me.rdBtn1.AutoSize = True
        Me.rdBtn1.Location = New System.Drawing.Point(19, 24)
        Me.rdBtn1.Name = "rdBtn1"
        Me.rdBtn1.Size = New System.Drawing.Size(356, 31)
        Me.rdBtn1.TabIndex = 0
        Me.rdBtn1.TabStop = True
        Me.rdBtn1.Text = "Convention + Superhero Experience"
        Me.rdBtn1.UseVisualStyleBackColor = True
        '
        'lblRegsCost
        '
        Me.lblRegsCost.AutoSize = True
        Me.lblRegsCost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegsCost.Location = New System.Drawing.Point(88, 473)
        Me.lblRegsCost.Name = "lblRegsCost"
        Me.lblRegsCost.Size = New System.Drawing.Size(178, 27)
        Me.lblRegsCost.TabIndex = 5
        Me.lblRegsCost.Text = "Registration Cost:"
        '
        'lblRegsTotal
        '
        Me.lblRegsTotal.AutoSize = True
        Me.lblRegsTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegsTotal.Location = New System.Drawing.Point(377, 473)
        Me.lblRegsTotal.Name = "lblRegsTotal"
        Me.lblRegsTotal.Size = New System.Drawing.Size(105, 27)
        Me.lblRegsTotal.TabIndex = 6
        Me.lblRegsTotal.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(74, 542)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 41)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(412, 542)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 617)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRegsTotal)
        Me.Controls.Add(Me.lblRegsCost)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.txtBoxGroup)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.Name = "frmComic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtBoxGroup As TextBox
    Friend WithEvents grpType As GroupBox
    Friend WithEvents rdBtn3 As RadioButton
    Friend WithEvents rdBtn2 As RadioButton
    Friend WithEvents rdBtn1 As RadioButton
    Friend WithEvents lblRegsCost As Label
    Friend WithEvents lblRegsTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
