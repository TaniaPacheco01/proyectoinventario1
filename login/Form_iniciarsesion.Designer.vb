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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login_iniciar = New System.Windows.Forms.Button()
        Me.btn_login_salir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_nivel_login = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label_login_bienvenido
        '
        Me.Label_login_bienvenido.AutoSize = True
        Me.Label_login_bienvenido.BackColor = System.Drawing.Color.Silver
        Me.Label_login_bienvenido.Font = New System.Drawing.Font("Berlin Sans FB Demi", 25.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_bienvenido.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label_login_bienvenido.Location = New System.Drawing.Point(344, 11)
        Me.Label_login_bienvenido.Name = "Label_login_bienvenido"
        Me.Label_login_bienvenido.Size = New System.Drawing.Size(274, 56)
        Me.Label_login_bienvenido.TabIndex = 0
        Me.Label_login_bienvenido.Text = "Bienvenido"
        '
        'Label_login_ingresadatos
        '
        Me.Label_login_ingresadatos.AutoSize = True
        Me.Label_login_ingresadatos.BackColor = System.Drawing.Color.Silver
        Me.Label_login_ingresadatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_login_ingresadatos.Location = New System.Drawing.Point(346, 166)
        Me.Label_login_ingresadatos.Name = "Label_login_ingresadatos"
        Me.Label_login_ingresadatos.Size = New System.Drawing.Size(277, 39)
        Me.Label_login_ingresadatos.TabIndex = 1
        Me.Label_login_ingresadatos.Text = "Ingresa tus datos"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(404, 296)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(286, 26)
        Me.txt_usuario.TabIndex = 2
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Location = New System.Drawing.Point(404, 389)
        Me.txt_contrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contrasena.Size = New System.Drawing.Size(286, 26)
        Me.txt_contrasena.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(126, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "      Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(163, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "      Usuario"
        '
        'btn_login_iniciar
        '
        Me.btn_login_iniciar.BackColor = System.Drawing.Color.Blue
        Me.btn_login_iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_iniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login_iniciar.Image = CType(resources.GetObject("btn_login_iniciar.Image"), System.Drawing.Image)
        Me.btn_login_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_login_iniciar.Location = New System.Drawing.Point(238, 572)
        Me.btn_login_iniciar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_login_iniciar.Name = "btn_login_iniciar"
        Me.btn_login_iniciar.Size = New System.Drawing.Size(199, 61)
        Me.btn_login_iniciar.TabIndex = 6
        Me.btn_login_iniciar.Text = "Iniciar"
        Me.btn_login_iniciar.UseVisualStyleBackColor = False
        '
        'btn_login_salir
        '
        Me.btn_login_salir.BackColor = System.Drawing.Color.Blue
        Me.btn_login_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_salir.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_login_salir.Location = New System.Drawing.Point(526, 572)
        Me.btn_login_salir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_login_salir.Name = "btn_login_salir"
        Me.btn_login_salir.Size = New System.Drawing.Size(187, 61)
        Me.btn_login_salir.TabIndex = 8
        Me.btn_login_salir.Text = "Salir"
        Me.btn_login_salir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(212, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 36)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "      Nivel"
        '
        'cmb_nivel_login
        '
        Me.cmb_nivel_login.FormattingEnabled = True
        Me.cmb_nivel_login.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmb_nivel_login.Location = New System.Drawing.Point(404, 464)
        Me.cmb_nivel_login.Name = "cmb_nivel_login"
        Me.cmb_nivel_login.Size = New System.Drawing.Size(286, 28)
        Me.cmb_nivel_login.TabIndex = 11
        '
        'Form_iniciarsesion
        '
        Me.AcceptButton = Me.btn_login_iniciar
        Me.AccessibleDescription = "Iniciar sesion"
        Me.AccessibleName = "Iniciar sesion"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(909, 725)
        Me.Controls.Add(Me.cmb_nivel_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_login_salir)
        Me.Controls.Add(Me.btn_login_iniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contrasena)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label_login_ingresadatos)
        Me.Controls.Add(Me.Label_login_bienvenido)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_iniciarsesion"
        Me.Text = "Iniciar sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_login_bienvenido As Label
    Friend WithEvents Label_login_ingresadatos As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_login_iniciar As Button
    Friend WithEvents btn_login_salir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_nivel_login As ComboBox
End Class
