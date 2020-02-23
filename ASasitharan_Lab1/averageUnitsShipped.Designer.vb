<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class averageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInputDisplay = New System.Windows.Forms.TextBox()
        Me.averageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(58, 62)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(42, 18)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(228, 62)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(46, 18)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day 1"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(133, 63)
        Me.txtUnits.Multiline = True
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(72, 25)
        Me.txtUnits.TabIndex = 3
        Me.averageUnitsShippedTips.SetToolTip(Me.txtUnits, "Enter the amount of units")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 347)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.averageUnitsShippedTips.SetToolTip(Me.btnEnter, "Enter's the amount of units inputted")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(133, 347)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.averageUnitsShippedTips.SetToolTip(Me.btnReset, "Reset's the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(231, 347)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.averageUnitsShippedTips.SetToolTip(Me.btnExit, "Exits the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(64, 284)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(210, 36)
        Me.lblOutput.TabIndex = 8
        '
        'txtInputDisplay
        '
        Me.txtInputDisplay.Location = New System.Drawing.Point(64, 108)
        Me.txtInputDisplay.Multiline = True
        Me.txtInputDisplay.Name = "txtInputDisplay"
        Me.txtInputDisplay.ReadOnly = True
        Me.txtInputDisplay.Size = New System.Drawing.Size(210, 157)
        Me.txtInputDisplay.TabIndex = 9
        Me.txtInputDisplay.TabStop = False
        Me.averageUnitsShippedTips.SetToolTip(Me.txtInputDisplay, "All inputs will be displayed here")
        '
        'averageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(336, 438)
        Me.Controls.Add(Me.txtInputDisplay)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "averageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInputDisplay As TextBox
    Friend WithEvents averageUnitsShippedTips As ToolTip
End Class
