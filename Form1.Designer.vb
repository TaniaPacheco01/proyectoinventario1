<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_iniciarsesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_iniciarsesion))
        Me.Label_login_bienvenido = New System.Windows.Forms.Label()
        Me.Label_login_ingresadatos = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label_login_contrasena = New System.Windows.Forms.Label()
        Me.Label_login_usuario = New System.Windows.Forms.Label()
        Me.Button_login_iniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_login_bienvenido
        '
        Me.Label_login_bienvenido.AutoSize = True
        Me.Label_login_bienvenido.BackColor = System.Drawing.Color.Silver
        Me.Label_login_bienvenido.Font = New System.Drawing.Font("Berlin Sans FB Demi", 25.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_bienvenido.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_login_bienvenido.Location = New System.Drawing.Point(723, 51)
        Me.Label_login_bienvenido.Name = "Label_login_bienvenido"
        Me.Label_login_bienvenido.Size = New System.Drawing.Size(234, 48)
        Me.Label_login_bienvenido.TabIndex = 0
        Me.Label_login_bienvenido.Text = "Bienvenido"
        '
        'Label_login_ingresadatos
        '
        Me.Label_login_ingresadatos.AutoSize = True
        Me.Label_login_ingresadatos.BackColor = System.Drawing.Color.Silver
        Me.Label_login_ingresadatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_ingresadatos.Location = New System.Drawing.Point(177, 180)
        Me.Label_login_ingresadatos.Name = "Label_login_ingresadatos"
        Me.Label_login_ingresadatos.Size = New System.Drawing.Size(238, 33)
        Me.Label_login_ingresadatos.TabIndex = 1
        Me.Label_login_ingresadatos.Text = "Ingresa tus datos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(291, 284)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(291, 383)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label_login_contrasena
        '
        Me.Label_login_contrasena.AutoSize = True
        Me.Label_login_contrasena.BackColor = System.Drawing.Color.Silver
        Me.Label_login_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_contrasena.Image = CType(resources.GetObject("Label_login_contrasena.Image"), System.Drawing.Image)
        Me.Label_login_contrasena.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_login_contrasena.Location = New System.Drawing.Point(63, 375)
        Me.Label_login_contrasena.Name = "Label_login_contrasena"
        Me.Label_login_contrasena.Size = New System.Drawing.Size(185, 29)
        Me.Label_login_contrasena.TabIndex = 4
        Me.Label_login_contrasena.Text = "      Contraseña"
        '
        'Label_login_usuario
        '
        Me.Label_login_usuario.AutoSize = True
        Me.Label_login_usuario.BackColor = System.Drawing.Color.Silver
        Me.Label_login_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_usuario.Image = CType(resources.GetObject("Label_login_usuario.Image"), System.Drawing.Image)
        Me.Label_login_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_login_usuario.Location = New System.Drawing.Point(63, 276)
        Me.Label_login_usuario.Name = "Label_login_usuario"
        Me.Label_login_usuario.Size = New System.Drawing.Size(142, 29)
        Me.Label_login_usuario.TabIndex = 5
        Me.Label_login_usuario.Text = "      Usuario"
        '
        'Button_login_iniciar
        '
        Me.Button_login_iniciar.BackColor = System.Drawing.Color.Blue
        Me.Button_login_iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_login_iniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_login_iniciar.Image = CType(resources.GetObject("Button_login_iniciar.Image"), System.Drawing.Image)
        Me.Button_login_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_login_iniciar.Location = New System.Drawing.Point(196, 490)
        Me.Button_login_iniciar.Name = "Button_login_iniciar"
        Me.Button_login_iniciar.Size = New System.Drawing.Size(219, 67)
        Me.Button_login_iniciar.TabIndex = 6
        Me.Button_login_iniciar.Text = "Iniciar"
        Me.Button_login_iniciar.UseVisualStyleBackColor = False
        '
        'Form_iniciarsesion
        '
        Me.AcceptButton = Me.Button_login_iniciar
        Me.AccessibleDescription = "Iniciar sesion"
        Me.AccessibleName = "Iniciar sesion"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1003, 795)
        Me.Controls.Add(Me.Button_login_iniciar)
        Me.Controls.Add(Me.Label_login_usuario)
        Me.Controls.Add(Me.Label_login_contrasena)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label_login_ingresadatos)
        Me.Controls.Add(Me.Label_login_bienvenido)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_iniciarsesion"
        Me.Text = "Iniciar sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_login_bienvenido As Label
    Friend WithEvents Label_login_ingresadatos As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label_login_contrasena As Label
    Friend WithEvents Label_login_usuario As Label
    Friend WithEvents Button_login_iniciar As Button
End Class
