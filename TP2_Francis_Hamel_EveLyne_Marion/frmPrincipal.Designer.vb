<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnMeilleurResultat = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnCharger = New System.Windows.Forms.Button()
        Me.btnCommentJouer = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatAppearance.BorderSize = 4
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Gold
        Me.btnNew.Location = New System.Drawing.Point(564, 53)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(227, 52)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Nouvelle Partie"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnMeilleurResultat
        '
        Me.btnMeilleurResultat.BackColor = System.Drawing.Color.Transparent
        Me.btnMeilleurResultat.FlatAppearance.BorderSize = 4
        Me.btnMeilleurResultat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMeilleurResultat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMeilleurResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeilleurResultat.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnMeilleurResultat.Location = New System.Drawing.Point(564, 253)
        Me.btnMeilleurResultat.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnMeilleurResultat.Name = "btnMeilleurResultat"
        Me.btnMeilleurResultat.Size = New System.Drawing.Size(226, 77)
        Me.btnMeilleurResultat.TabIndex = 1
        Me.btnMeilleurResultat.Text = "Meilleurs Résultats"
        Me.btnMeilleurResultat.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.BorderSize = 4
        Me.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnQuitter.Location = New System.Drawing.Point(564, 344)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(226, 49)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnCharger
        '
        Me.btnCharger.BackColor = System.Drawing.Color.Transparent
        Me.btnCharger.FlatAppearance.BorderSize = 4
        Me.btnCharger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCharger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCharger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCharger.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnCharger.Location = New System.Drawing.Point(564, 119)
        Me.btnCharger.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnCharger.Name = "btnCharger"
        Me.btnCharger.Size = New System.Drawing.Size(227, 53)
        Me.btnCharger.TabIndex = 3
        Me.btnCharger.Text = "Charger Partie"
        Me.btnCharger.UseVisualStyleBackColor = False
        '
        'btnCommentJouer
        '
        Me.btnCommentJouer.BackColor = System.Drawing.Color.Transparent
        Me.btnCommentJouer.FlatAppearance.BorderSize = 4
        Me.btnCommentJouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCommentJouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCommentJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommentJouer.ForeColor = System.Drawing.Color.Aqua
        Me.btnCommentJouer.Location = New System.Drawing.Point(564, 186)
        Me.btnCommentJouer.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnCommentJouer.Name = "btnCommentJouer"
        Me.btnCommentJouer.Size = New System.Drawing.Size(227, 53)
        Me.btnCommentJouer.TabIndex = 4
        Me.btnCommentJouer.Text = "Comment Jouer"
        Me.btnCommentJouer.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.TP2_Francis_Hamel_EveLyne_Marion.My.Resources.Resources.soustitre2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(49, 297)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(440, 54)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.TP2_Francis_Hamel_EveLyne_Marion.My.Resources.Resources.soustitre1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(34, 215)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(482, 61)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TP2_Francis_Hamel_EveLyne_Marion.My.Resources.Resources.title
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(56, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 139)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(817, 437)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCommentJouer)
        Me.Controls.Add(Me.btnCharger)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnMeilleurResultat)
        Me.Controls.Add(Me.btnNew)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmPrincipal"
        Me.Text = "Sauvons les réfugiés !"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnMeilleurResultat As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnCharger As Button
    Friend WithEvents btnCommentJouer As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
