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
        Me.Label1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnCrystalReport = New System.Windows.Forms.Button()
        Me.btnFrameWork = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShortcut = New System.Windows.Forms.Button()
        Me.btnSetupAll = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 137)
        Me.Label1.Multiline = True
        Me.Label1.Name = "Label1"
        Me.Label1.ReadOnly = True
        Me.Label1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Label1.Size = New System.Drawing.Size(722, 354)
        Me.Label1.TabIndex = 1
        Me.Label1.TabStop = False
        Me.Label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 108)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(722, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'btnCrystalReport
        '
        Me.btnCrystalReport.Location = New System.Drawing.Point(113, 3)
        Me.btnCrystalReport.Name = "btnCrystalReport"
        Me.btnCrystalReport.Size = New System.Drawing.Size(104, 81)
        Me.btnCrystalReport.TabIndex = 3
        Me.btnCrystalReport.Text = "Crystalreport"
        Me.btnCrystalReport.UseVisualStyleBackColor = True
        '
        'btnFrameWork
        '
        Me.btnFrameWork.Location = New System.Drawing.Point(3, 3)
        Me.btnFrameWork.Name = "btnFrameWork"
        Me.btnFrameWork.Size = New System.Drawing.Size(104, 81)
        Me.btnFrameWork.TabIndex = 4
        Me.btnFrameWork.Text = "Framework"
        Me.btnFrameWork.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(223, 3)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(104, 81)
        Me.btnSQL.TabIndex = 5
        Me.btnSQL.Text = "Sqlserver"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnShortcut)
        Me.Panel1.Controls.Add(Me.btnFrameWork)
        Me.Panel1.Controls.Add(Me.btnSQL)
        Me.Panel1.Controls.Add(Me.btnCrystalReport)
        Me.Panel1.Location = New System.Drawing.Point(293, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 90)
        Me.Panel1.TabIndex = 6
        '
        'btnShortcut
        '
        Me.btnShortcut.Location = New System.Drawing.Point(333, 3)
        Me.btnShortcut.Name = "btnShortcut"
        Me.btnShortcut.Size = New System.Drawing.Size(104, 81)
        Me.btnShortcut.TabIndex = 6
        Me.btnShortcut.Text = "Shortcut"
        Me.btnShortcut.UseVisualStyleBackColor = True
        '
        'btnSetupAll
        '
        Me.btnSetupAll.Location = New System.Drawing.Point(12, 21)
        Me.btnSetupAll.Name = "btnSetupAll"
        Me.btnSetupAll.Size = New System.Drawing.Size(104, 81)
        Me.btnSetupAll.TabIndex = 7
        Me.btnSetupAll.Text = "Setup All"
        Me.btnSetupAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(746, 503)
        Me.Controls.Add(Me.btnSetupAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMEGA Setup"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCrystalReport As System.Windows.Forms.Button
    Friend WithEvents btnFrameWork As System.Windows.Forms.Button
    Friend WithEvents btnSQL As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnShortcut As System.Windows.Forms.Button
    Friend WithEvents btnSetupAll As System.Windows.Forms.Button

End Class
