<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.btnRiemannUpper = New System.Windows.Forms.Button()
        Me.btnRiemannLower = New System.Windows.Forms.Button()
        Me.btnMidpoint = New System.Windows.Forms.Button()
        Me.btnTrapezoidal = New System.Windows.Forms.Button()
        Me.btnSimpson = New System.Windows.Forms.Button()
        Me.btnTaylor = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBoole = New System.Windows.Forms.Button()
        Me.btnThreeEight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelection
        '
        Me.lblSelection.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSelection.AutoSize = True
        Me.lblSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.Maroon
        Me.lblSelection.Location = New System.Drawing.Point(210, 56)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(175, 25)
        Me.lblSelection.TabIndex = 0
        Me.lblSelection.Text = "Selection Screen"
        '
        'btnRiemannUpper
        '
        Me.btnRiemannUpper.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRiemannUpper.Location = New System.Drawing.Point(54, 124)
        Me.btnRiemannUpper.Name = "btnRiemannUpper"
        Me.btnRiemannUpper.Size = New System.Drawing.Size(163, 41)
        Me.btnRiemannUpper.TabIndex = 1
        Me.btnRiemannUpper.Text = "Left Riemann Sum"
        Me.btnRiemannUpper.UseVisualStyleBackColor = True
        '
        'btnRiemannLower
        '
        Me.btnRiemannLower.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRiemannLower.Location = New System.Drawing.Point(54, 171)
        Me.btnRiemannLower.Name = "btnRiemannLower"
        Me.btnRiemannLower.Size = New System.Drawing.Size(163, 40)
        Me.btnRiemannLower.TabIndex = 2
        Me.btnRiemannLower.Text = "Right Riemann Sum"
        Me.btnRiemannLower.UseVisualStyleBackColor = True
        '
        'btnMidpoint
        '
        Me.btnMidpoint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMidpoint.Location = New System.Drawing.Point(54, 217)
        Me.btnMidpoint.Name = "btnMidpoint"
        Me.btnMidpoint.Size = New System.Drawing.Size(163, 39)
        Me.btnMidpoint.TabIndex = 3
        Me.btnMidpoint.Text = "Midpoint Rule"
        Me.btnMidpoint.UseVisualStyleBackColor = True
        '
        'btnTrapezoidal
        '
        Me.btnTrapezoidal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTrapezoidal.Location = New System.Drawing.Point(54, 262)
        Me.btnTrapezoidal.Name = "btnTrapezoidal"
        Me.btnTrapezoidal.Size = New System.Drawing.Size(163, 40)
        Me.btnTrapezoidal.TabIndex = 4
        Me.btnTrapezoidal.Text = "Trapezoid Rule"
        Me.btnTrapezoidal.UseVisualStyleBackColor = True
        '
        'btnSimpson
        '
        Me.btnSimpson.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSimpson.BackColor = System.Drawing.SystemColors.Control
        Me.btnSimpson.Location = New System.Drawing.Point(357, 124)
        Me.btnSimpson.Name = "btnSimpson"
        Me.btnSimpson.Size = New System.Drawing.Size(163, 41)
        Me.btnSimpson.TabIndex = 5
        Me.btnSimpson.Text = "Simpson's Rule"
        Me.btnSimpson.UseVisualStyleBackColor = False
        '
        'btnTaylor
        '
        Me.btnTaylor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnTaylor.Location = New System.Drawing.Point(357, 262)
        Me.btnTaylor.Name = "btnTaylor"
        Me.btnTaylor.Size = New System.Drawing.Size(163, 40)
        Me.btnTaylor.TabIndex = 7
        Me.btnTaylor.Text = "Series Approximation"
        Me.btnTaylor.UseVisualStyleBackColor = True
        '
        'btnMultiple
        '
        Me.btnMultiple.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMultiple.Location = New System.Drawing.Point(197, 355)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(163, 40)
        Me.btnMultiple.TabIndex = 9
        Me.btnMultiple.Text = "All Techniques"
        Me.btnMultiple.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Location = New System.Drawing.Point(12, 376)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(73, 52)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(475, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 52)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Numerical Integration App"
        '
        'btnBoole
        '
        Me.btnBoole.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBoole.Location = New System.Drawing.Point(357, 216)
        Me.btnBoole.Name = "btnBoole"
        Me.btnBoole.Size = New System.Drawing.Size(163, 40)
        Me.btnBoole.TabIndex = 15
        Me.btnBoole.Text = "Boole's Rule"
        Me.btnBoole.UseVisualStyleBackColor = True
        '
        'btnThreeEight
        '
        Me.btnThreeEight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnThreeEight.Location = New System.Drawing.Point(357, 171)
        Me.btnThreeEight.Name = "btnThreeEight"
        Me.btnThreeEight.Size = New System.Drawing.Size(163, 40)
        Me.btnThreeEight.TabIndex = 16
        Me.btnThreeEight.Text = "Simpson's 3/8 Rule"
        Me.btnThreeEight.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NumericalIntegrationApp.My.Resources.Resources.interation_math_is_cool
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 440)
        Me.Controls.Add(Me.btnThreeEight)
        Me.Controls.Add(Me.btnBoole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnTaylor)
        Me.Controls.Add(Me.btnSimpson)
        Me.Controls.Add(Me.btnTrapezoidal)
        Me.Controls.Add(Me.btnMidpoint)
        Me.Controls.Add(Me.btnRiemannLower)
        Me.Controls.Add(Me.btnRiemannUpper)
        Me.Controls.Add(Me.lblSelection)
        Me.DoubleBuffered = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelection As Label
    Friend WithEvents btnRiemannUpper As Button
    Friend WithEvents btnRiemannLower As Button
    Friend WithEvents btnMidpoint As Button
    Friend WithEvents btnTrapezoidal As Button
    Friend WithEvents btnSimpson As Button
    Friend WithEvents btnTaylor As Button
    Friend WithEvents btnMultiple As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBoole As Button
    Friend WithEvents btnThreeEight As Button
End Class
