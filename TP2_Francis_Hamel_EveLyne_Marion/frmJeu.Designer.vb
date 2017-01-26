<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJeu
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
        Me.pctbox_GrilleJeu = New System.Windows.Forms.PictureBox()
        Me.lblErreur = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctbox_GrilleJeu,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pctbox_GrilleJeu
        '
        Me.pctbox_GrilleJeu.BackColor = System.Drawing.Color.Black
        Me.pctbox_GrilleJeu.Location = New System.Drawing.Point(49, 74)
        Me.pctbox_GrilleJeu.Margin = New System.Windows.Forms.Padding(4)
        Me.pctbox_GrilleJeu.Name = "pctbox_GrilleJeu"
        Me.pctbox_GrilleJeu.Size = New System.Drawing.Size(700, 700)
        Me.pctbox_GrilleJeu.TabIndex = 0
        Me.pctbox_GrilleJeu.TabStop = False
        '
        'lblErreur
        '
        Me.lblErreur.AutoSize = True
        Me.lblErreur.BackColor = System.Drawing.Color.Black
        Me.lblErreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErreur.ForeColor = System.Drawing.Color.Gold
        Me.lblErreur.Location = New System.Drawing.Point(801, 234)
        Me.lblErreur.Name = "lblErreur"
        Me.lblErreur.Size = New System.Drawing.Size(0, 32)
        Me.lblErreur.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.BorderSize = 4
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnSave.Location = New System.Drawing.Point(806, 74)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 58)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = false
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
        Me.btnQuitter.Location = New System.Drawing.Point(806, 149)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(178, 58)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(49, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Jeu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmJeu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.TP2_Francis_Hamel_EveLyne_Marion.My.Resources.Resources.FondJeu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 821)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblErreur)
        Me.Controls.Add(Me.pctbox_GrilleJeu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmJeu"
        Me.Text = "frmJeu"
        CType(Me.pctbox_GrilleJeu,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pctbox_GrilleJeu As PictureBox
    Friend WithEvents lblErreur As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents Label1 As Label
End Class
