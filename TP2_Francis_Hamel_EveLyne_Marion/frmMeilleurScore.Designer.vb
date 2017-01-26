<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeilleurScore
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
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'lstScore
        '
        Me.lstScore.BackColor = System.Drawing.Color.Black
        Me.lstScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstScore.ForeColor = System.Drawing.Color.Aqua
        Me.lstScore.FormattingEnabled = true
        Me.lstScore.ItemHeight = 20
        Me.lstScore.Location = New System.Drawing.Point(59, 95)
        Me.lstScore.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(486, 284)
        Me.lstScore.TabIndex = 0
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblScore.Location = New System.Drawing.Point(13, 38)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(586, 50)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Meilleurs Résultats"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.BorderSize = 4
        Me.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnQuitter.Location = New System.Drawing.Point(244, 393)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(103, 48)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = false
        '
        'frmMeilleurScore
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(613, 484)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lstScore)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmMeilleurScore"
        Me.Text = "frmMeilleurScore"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lstScore As ListBox
    Friend WithEvents lblScore As Label
    Friend WithEvents btnQuitter As Button
End Class
