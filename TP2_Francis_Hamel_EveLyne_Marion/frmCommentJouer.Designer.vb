<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentJouer
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
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblExplication1 = New System.Windows.Forms.Label()
        Me.lblExplication2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.BorderSize = 4
        Me.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnQuitter.Location = New System.Drawing.Point(330, 483)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(138, 47)
        Me.btnQuitter.TabIndex = 1
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'lblExplication1
        '
        Me.lblExplication1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblExplication1.Location = New System.Drawing.Point(12, 396)
        Me.lblExplication1.Name = "lblExplication1"
        Me.lblExplication1.Size = New System.Drawing.Size(782, 28)
        Me.lblExplication1.TabIndex = 2
        Me.lblExplication1.Text = "Tenter de survivre le plus longtemps possible sans vous faire attraper par les au" &
    "torités"
        Me.lblExplication1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblExplication2
        '
        Me.lblExplication2.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblExplication2.Location = New System.Drawing.Point(7, 433)
        Me.lblExplication2.Name = "lblExplication2"
        Me.lblExplication2.Size = New System.Drawing.Size(787, 32)
        Me.lblExplication2.TabIndex = 3
        Me.lblExplication2.Text = "Mais sachez que les citoyens peuvent peut-être vous aider... ou pas"
        Me.lblExplication2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(782, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comment Jouer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TP2_Francis_Hamel_EveLyne_Marion.My.Resources.Resources.control
        Me.PictureBox1.Location = New System.Drawing.Point(93, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 294)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmCommentJouer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(806, 556)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExplication2)
        Me.Controls.Add(Me.lblExplication1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmCommentJouer"
        Me.Text = "Comment Jouer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblExplication1 As Label
    Friend WithEvents lblExplication2 As Label
    Friend WithEvents Label1 As Label
End Class
