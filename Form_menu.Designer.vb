<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu
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
        Me.btn_menu_productos = New System.Windows.Forms.Button()
        Me.btn_menu_admin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_menu_productos
        '
        Me.btn_menu_productos.Location = New System.Drawing.Point(4, 96)
        Me.btn_menu_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_menu_productos.Name = "btn_menu_productos"
        Me.btn_menu_productos.Size = New System.Drawing.Size(122, 51)
        Me.btn_menu_productos.TabIndex = 0
        Me.btn_menu_productos.Text = "Ir a productos"
        Me.btn_menu_productos.UseVisualStyleBackColor = True
        '
        'btn_menu_admin
        '
        Me.btn_menu_admin.Location = New System.Drawing.Point(4, 11)
        Me.btn_menu_admin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_menu_admin.Name = "btn_menu_admin"
        Me.btn_menu_admin.Size = New System.Drawing.Size(113, 43)
        Me.btn_menu_admin.TabIndex = 1
        Me.btn_menu_admin.Text = "administrador"
        Me.btn_menu_admin.UseVisualStyleBackColor = True
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.btn_menu_admin)
        Me.Controls.Add(Me.btn_menu_productos)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_menu_productos As Button
    Friend WithEvents btn_menu_admin As Button
End Class
