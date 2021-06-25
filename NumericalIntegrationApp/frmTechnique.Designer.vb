<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTechnique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechnique))
        Me.lblTechName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboxFunctions = New System.Windows.Forms.ComboBox()
        Me.txtLowerBound = New System.Windows.Forms.TextBox()
        Me.txtSubinterval = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpBoxParam = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtUpperBound = New System.Windows.Forms.TextBox()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.lblSubinterval = New System.Windows.Forms.Label()
        Me.lblLowerBound = New System.Windows.Forms.Label()
        Me.grpBoxResults = New System.Windows.Forms.GroupBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.grpBoxParam.SuspendLayout()
        Me.grpBoxResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTechName
        '
        Me.lblTechName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTechName.AutoSize = True
        Me.lblTechName.BackColor = System.Drawing.Color.Transparent
        Me.lblTechName.Font = New System.Drawing.Font("Modern No. 20", 17.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechName.ForeColor = System.Drawing.Color.Black
        Me.lblTechName.Location = New System.Drawing.Point(95, 84)
        Me.lblTechName.Name = "lblTechName"
        Me.lblTechName.Size = New System.Drawing.Size(0, 25)
        Me.lblTechName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Function:"
        '
        'CboxFunctions
        '
        Me.CboxFunctions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CboxFunctions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboxFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxFunctions.FormattingEnabled = True
        Me.CboxFunctions.Items.AddRange(New Object() {"f(x) = x²", "f(x) = x²+1", "f(x) = sin(x²)", "f(x) = e^(x^2)"})
        Me.CboxFunctions.Location = New System.Drawing.Point(121, 119)
        Me.CboxFunctions.Name = "CboxFunctions"
        Me.CboxFunctions.Size = New System.Drawing.Size(200, 32)
        Me.CboxFunctions.TabIndex = 1
        '
        'txtLowerBound
        '
        Me.txtLowerBound.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLowerBound.Location = New System.Drawing.Point(121, 168)
        Me.txtLowerBound.Name = "txtLowerBound"
        Me.txtLowerBound.Size = New System.Drawing.Size(89, 29)
        Me.txtLowerBound.TabIndex = 2
        '
        'txtSubinterval
        '
        Me.txtSubinterval.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSubinterval.Location = New System.Drawing.Point(121, 260)
        Me.txtSubinterval.Name = "txtSubinterval"
        Me.txtSubinterval.Size = New System.Drawing.Size(89, 29)
        Me.txtSubinterval.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(12, 464)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(101, 67)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClear.Location = New System.Drawing.Point(258, 464)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 67)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpBoxParam
        '
        Me.grpBoxParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.grpBoxParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpBoxParam.BackColor = System.Drawing.Color.Maroon
        Me.grpBoxParam.Controls.Add(Me.Label1)
        Me.grpBoxParam.Controls.Add(Me.lblTerms)
        Me.grpBoxParam.Controls.Add(Me.lblTechName)
        Me.grpBoxParam.Controls.Add(Me.txtTerms)
        Me.grpBoxParam.Controls.Add(Me.btnGraph)
        Me.grpBoxParam.Controls.Add(Me.btnCalculate)
        Me.grpBoxParam.Controls.Add(Me.txtUpperBound)
        Me.grpBoxParam.Controls.Add(Me.lblUpperBound)
        Me.grpBoxParam.Controls.Add(Me.lblSubinterval)
        Me.grpBoxParam.Controls.Add(Me.btnClear)
        Me.grpBoxParam.Controls.Add(Me.lblLowerBound)
        Me.grpBoxParam.Controls.Add(Me.btnBack)
        Me.grpBoxParam.Controls.Add(Me.Label5)
        Me.grpBoxParam.Controls.Add(Me.txtSubinterval)
        Me.grpBoxParam.Controls.Add(Me.CboxFunctions)
        Me.grpBoxParam.Controls.Add(Me.txtLowerBound)
        Me.grpBoxParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxParam.Location = New System.Drawing.Point(12, 22)
        Me.grpBoxParam.Name = "grpBoxParam"
        Me.grpBoxParam.Size = New System.Drawing.Size(394, 578)
        Me.grpBoxParam.TabIndex = 14
        Me.grpBoxParam.TabStop = False
        Me.grpBoxParam.Text = "Parameters:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Numerical Integration App"
        '
        'lblTerms
        '
        Me.lblTerms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTerms.AutoSize = True
        Me.lblTerms.BackColor = System.Drawing.Color.Transparent
        Me.lblTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms.Location = New System.Drawing.Point(18, 312)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(55, 18)
        Me.lblTerms.TabIndex = 18
        Me.lblTerms.Text = "Terms:"
        '
        'txtTerms
        '
        Me.txtTerms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTerms.Location = New System.Drawing.Point(121, 305)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(89, 29)
        Me.txtTerms.TabIndex = 6
        '
        'btnGraph
        '
        Me.btnGraph.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraph.Location = New System.Drawing.Point(139, 507)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(101, 49)
        Me.btnGraph.TabIndex = 7
        Me.btnGraph.Text = "Graph"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(139, 422)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 49)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtUpperBound
        '
        Me.txtUpperBound.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUpperBound.Location = New System.Drawing.Point(121, 214)
        Me.txtUpperBound.Name = "txtUpperBound"
        Me.txtUpperBound.Size = New System.Drawing.Size(89, 29)
        Me.txtUpperBound.TabIndex = 3
        '
        'lblUpperBound
        '
        Me.lblUpperBound.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUpperBound.AutoSize = True
        Me.lblUpperBound.BackColor = System.Drawing.Color.Transparent
        Me.lblUpperBound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpperBound.Location = New System.Drawing.Point(15, 225)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(99, 18)
        Me.lblUpperBound.TabIndex = 14
        Me.lblUpperBound.Text = "Upper Bound:"
        '
        'lblSubinterval
        '
        Me.lblSubinterval.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubinterval.AutoSize = True
        Me.lblSubinterval.BackColor = System.Drawing.Color.Transparent
        Me.lblSubinterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubinterval.Location = New System.Drawing.Point(15, 271)
        Me.lblSubinterval.Name = "lblSubinterval"
        Me.lblSubinterval.Size = New System.Drawing.Size(92, 18)
        Me.lblSubinterval.TabIndex = 6
        Me.lblSubinterval.Text = "Subintervals:"
        '
        'lblLowerBound
        '
        Me.lblLowerBound.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLowerBound.AutoSize = True
        Me.lblLowerBound.BackColor = System.Drawing.Color.Transparent
        Me.lblLowerBound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowerBound.Location = New System.Drawing.Point(15, 181)
        Me.lblLowerBound.Name = "lblLowerBound"
        Me.lblLowerBound.Size = New System.Drawing.Size(100, 18)
        Me.lblLowerBound.TabIndex = 5
        Me.lblLowerBound.Text = "Lower Bound:"
        '
        'grpBoxResults
        '
        Me.grpBoxResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoxResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpBoxResults.BackColor = System.Drawing.Color.Maroon
        Me.grpBoxResults.Controls.Add(Me.txtResults)
        Me.grpBoxResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxResults.Location = New System.Drawing.Point(396, 22)
        Me.grpBoxResults.Name = "grpBoxResults"
        Me.grpBoxResults.Size = New System.Drawing.Size(508, 578)
        Me.grpBoxResults.TabIndex = 0
        Me.grpBoxResults.TabStop = False
        Me.grpBoxResults.Text = "Results:"
        '
        'txtResults
        '
        Me.txtResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtResults.Location = New System.Drawing.Point(16, 40)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(477, 516)
        Me.txtResults.TabIndex = 0
        Me.txtResults.TabStop = False
        '
        'frmTechnique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 625)
        Me.Controls.Add(Me.grpBoxResults)
        Me.Controls.Add(Me.grpBoxParam)
        Me.DoubleBuffered = True
        Me.Name = "frmTechnique"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NIA"
        Me.grpBoxParam.ResumeLayout(False)
        Me.grpBoxParam.PerformLayout()
        Me.grpBoxResults.ResumeLayout(False)
        Me.grpBoxResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTechName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboxFunctions As ComboBox
    Friend WithEvents txtLowerBound As TextBox
    Friend WithEvents txtSubinterval As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpBoxParam As GroupBox
    Friend WithEvents lblSubinterval As Label
    Friend WithEvents lblLowerBound As Label
    Friend WithEvents grpBoxResults As GroupBox
    Friend WithEvents txtUpperBound As TextBox
    Friend WithEvents lblUpperBound As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnGraph As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTerms As Label
    Friend WithEvents txtTerms As TextBox
End Class
