<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_modificar_productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_modificar_productos))
        Me.txt_productos_modificar_unidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_productos_modificar_existencia = New System.Windows.Forms.TextBox()
        Me.txt_productos_modificar_precio = New System.Windows.Forms.TextBox()
        Me.txt_productos_modificar_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_productos_modificar_codigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_modificar_productos = New System.Windows.Forms.Button()
        Me.txt_modificar_productos_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_productos_modificar_unidad
        '
        Me.txt_productos_modificar_unidad.Location = New System.Drawing.Point(287, 220)
        Me.txt_productos_modificar_unidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_modificar_unidad.Name = "txt_productos_modificar_unidad"
        Me.txt_productos_modificar_unidad.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_modificar_unidad.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 29)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Unidad"
        '
        'txt_productos_modificar_existencia
        '
        Me.txt_productos_modificar_existencia.Location = New System.Drawing.Point(287, 318)
        Me.txt_productos_modificar_existencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_modificar_existencia.Name = "txt_productos_modificar_existencia"
        Me.txt_productos_modificar_existencia.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_modificar_existencia.TabIndex = 37
        '
        'txt_productos_modificar_precio
        '
        Me.txt_productos_modificar_precio.Location = New System.Drawing.Point(287, 269)
        Me.txt_productos_modificar_precio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_modificar_precio.Name = "txt_productos_modificar_precio"
        Me.txt_productos_modificar_precio.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_modificar_precio.TabIndex = 36
        '
        'txt_productos_modificar_descripcion
        '
        Me.txt_productos_modificar_descripcion.Location = New System.Drawing.Point(287, 170)
        Me.txt_productos_modificar_descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_modificar_descripcion.Name = "txt_productos_modificar_descripcion"
        Me.txt_productos_modificar_descripcion.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_modificar_descripcion.TabIndex = 35
        '
        'txt_productos_modificar_codigo
        '
        Me.txt_productos_modificar_codigo.Location = New System.Drawing.Point(287, 117)
        Me.txt_productos_modificar_codigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_modificar_codigo.Name = "txt_productos_modificar_codigo"
        Me.txt_productos_modificar_codigo.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_modificar_codigo.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "En existencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Precio unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 29)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Codigo"
        '
        'btn_modificar_productos
        '
        Me.btn_modificar_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar_productos.Location = New System.Drawing.Point(237, 418)
        Me.btn_modificar_productos.Name = "btn_modificar_productos"
        Me.btn_modificar_productos.Size = New System.Drawing.Size(156, 47)
        Me.btn_modificar_productos.TabIndex = 29
        Me.btn_modificar_productos.Text = "Modificar"
        Me.btn_modificar_productos.UseVisualStyleBackColor = False
        '
        'txt_modificar_productos_id
        '
        Me.txt_modificar_productos_id.Enabled = False
        Me.txt_modificar_productos_id.Location = New System.Drawing.Point(287, 37)
        Me.txt_modificar_productos_id.Name = "txt_modificar_productos_id"
        Me.txt_modificar_productos_id.Size = New System.Drawing.Size(117, 22)
        Me.txt_modificar_productos_id.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 29)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "ID de producto"
        '
        'Form_modificar_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 506)
        Me.Controls.Add(Me.txt_modificar_productos_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_productos_modificar_unidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_productos_modificar_existencia)
        Me.Controls.Add(Me.txt_productos_modificar_precio)
        Me.Controls.Add(Me.txt_productos_modificar_descripcion)
        Me.Controls.Add(Me.txt_productos_modificar_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_modificar_productos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_modificar_productos"
        Me.Text = "Modificar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_productos_modificar_unidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_productos_modificar_existencia As TextBox
    Friend WithEvents txt_productos_modificar_precio As TextBox
    Friend WithEvents txt_productos_modificar_descripcion As TextBox
    Friend WithEvents txt_productos_modificar_codigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_modificar_productos As Button
    Friend WithEvents txt_modificar_productos_id As TextBox
    Friend WithEvents Label4 As Label
End Class
