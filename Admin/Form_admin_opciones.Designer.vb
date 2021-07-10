<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_admin_opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_admin_opciones))
        Me.btn_productos_admin = New System.Windows.Forms.Button()
        Me.btn_usuarios_admin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_productos_admin
        '
        Me.btn_productos_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_productos_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.8209!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos_admin.ForeColor = System.Drawing.Color.White
        Me.btn_productos_admin.Location = New System.Drawing.Point(262, 83)
        Me.btn_productos_admin.Name = "btn_productos_admin"
        Me.btn_productos_admin.Size = New System.Drawing.Size(137, 44)
        Me.btn_productos_admin.TabIndex = 0
        Me.btn_productos_admin.Text = "Productos"
        Me.btn_productos_admin.UseVisualStyleBackColor = False
        '
        'btn_usuarios_admin
        '
        Me.btn_usuarios_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_usuarios_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.8209!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios_admin.ForeColor = System.Drawing.Color.White
        Me.btn_usuarios_admin.Location = New System.Drawing.Point(79, 83)
        Me.btn_usuarios_admin.Name = "btn_usuarios_admin"
        Me.btn_usuarios_admin.Size = New System.Drawing.Size(124, 44)
        Me.btn_usuarios_admin.TabIndex = 1
        Me.btn_usuarios_admin.Text = "Usuarios"
        Me.btn_usuarios_admin.UseVisualStyleBackColor = False
        '
        'Form_admin_opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(485, 210)
        Me.Controls.Add(Me.btn_usuarios_admin)
        Me.Controls.Add(Me.btn_productos_admin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_admin_opciones"
        Me.Text = "Administrar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_productos_admin As Button
    Friend WithEvents btn_usuarios_admin As Button
End Class
