<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prueba
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prueba))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.picchabelo = New System.Windows.Forms.PictureBox()
        Me.pictman = New System.Windows.Forms.PictureBox()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.textmen = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picchabelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.AccessibleDescription = ""
        Me.btnexit.Location = New System.Drawing.Point(267, 187)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "salir"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'picchabelo
        '
        Me.picchabelo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picchabelo.Image = CType(resources.GetObject("picchabelo.Image"), System.Drawing.Image)
        Me.picchabelo.Location = New System.Drawing.Point(12, 12)
        Me.picchabelo.Name = "picchabelo"
        Me.picchabelo.Size = New System.Drawing.Size(147, 161)
        Me.picchabelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picchabelo.TabIndex = 1
        Me.picchabelo.TabStop = False
        '
        'pictman
        '
        Me.pictman.Image = CType(resources.GetObject("pictman.Image"), System.Drawing.Image)
        Me.pictman.InitialImage = CType(resources.GetObject("pictman.InitialImage"), System.Drawing.Image)
        Me.pictman.Location = New System.Drawing.Point(186, 12)
        Me.pictman.Name = "pictman"
        Me.pictman.Size = New System.Drawing.Size(128, 161)
        Me.pictman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictman.TabIndex = 2
        Me.pictman.TabStop = False
        '
        'lblmensaje
        '
        Me.lblmensaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblmensaje.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmensaje.Location = New System.Drawing.Point(40, 192)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(145, 18)
        Me.lblmensaje.TabIndex = 3
        Me.lblmensaje.Text = "                         "
        '
        'textmen
        '
        Me.textmen.Location = New System.Drawing.Point(62, 247)
        Me.textmen.Name = "textmen"
        Me.textmen.Size = New System.Drawing.Size(146, 20)
        Me.textmen.TabIndex = 4
        Me.textmen.Text = ","
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(267, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "VENTANA 2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = "kike"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 297)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textmen)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.pictman)
        Me.Controls.Add(Me.picchabelo)
        Me.Controls.Add(Me.btnexit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "primer programa "
        CType(Me.picchabelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents picchabelo As System.Windows.Forms.PictureBox
    Friend WithEvents pictman As System.Windows.Forms.PictureBox
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
    Friend WithEvents textmen As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
