<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_agregar_productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_agregar_productos))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_agregar_productos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_productos_agregar_codigo = New System.Windows.Forms.TextBox()
        Me.txt_productos_agregar_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_productos_agregar_precio = New System.Windows.Forms.TextBox()
        Me.txt_productos_agregar_existencia = New System.Windows.Forms.TextBox()
        Me.txt_productos_agregar_unidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Complete el registro"
        '
        'btn_agregar_productos
        '
        Me.btn_agregar_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_agregar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar_productos.Location = New System.Drawing.Point(231, 400)
        Me.btn_agregar_productos.Name = "btn_agregar_productos"
        Me.btn_agregar_productos.Size = New System.Drawing.Size(156, 47)
        Me.btn_agregar_productos.TabIndex = 16
        Me.btn_agregar_productos.Text = "Agregar"
        Me.btn_agregar_productos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Precio unitario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "En existencia"
        '
        'txt_productos_agregar_codigo
        '
        Me.txt_productos_agregar_codigo.Location = New System.Drawing.Point(281, 99)
        Me.txt_productos_agregar_codigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_agregar_codigo.Name = "txt_productos_agregar_codigo"
        Me.txt_productos_agregar_codigo.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_agregar_codigo.TabIndex = 23
        '
        'txt_productos_agregar_descripcion
        '
        Me.txt_productos_agregar_descripcion.Location = New System.Drawing.Point(281, 152)
        Me.txt_productos_agregar_descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_agregar_descripcion.Name = "txt_productos_agregar_descripcion"
        Me.txt_productos_agregar_descripcion.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_agregar_descripcion.TabIndex = 24
        '
        'txt_productos_agregar_precio
        '
        Me.txt_productos_agregar_precio.Location = New System.Drawing.Point(281, 251)
        Me.txt_productos_agregar_precio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_agregar_precio.Name = "txt_productos_agregar_precio"
        Me.txt_productos_agregar_precio.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_agregar_precio.TabIndex = 25
        '
        'txt_productos_agregar_existencia
        '
        Me.txt_productos_agregar_existencia.Location = New System.Drawing.Point(281, 300)
        Me.txt_productos_agregar_existencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_agregar_existencia.Name = "txt_productos_agregar_existencia"
        Me.txt_productos_agregar_existencia.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_agregar_existencia.TabIndex = 26
        '
        'txt_productos_agregar_unidad
        '
        Me.txt_productos_agregar_unidad.Location = New System.Drawing.Point(281, 202)
        Me.txt_productos_agregar_unidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productos_agregar_unidad.Name = "txt_productos_agregar_unidad"
        Me.txt_productos_agregar_unidad.Size = New System.Drawing.Size(145, 22)
        Me.txt_productos_agregar_unidad.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 29)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Unidad"
        '
        'Form_agregar_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 484)
        Me.Controls.Add(Me.txt_productos_agregar_unidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_productos_agregar_existencia)
        Me.Controls.Add(Me.txt_productos_agregar_precio)
        Me.Controls.Add(Me.txt_productos_agregar_descripcion)
        Me.Controls.Add(Me.txt_productos_agregar_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_agregar_productos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_agregar_productos"
        Me.Text = "Agregar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_agregar_productos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_productos_agregar_codigo As TextBox
    Friend WithEvents txt_productos_agregar_descripcion As TextBox
    Friend WithEvents txt_productos_agregar_precio As TextBox
    Friend WithEvents txt_productos_agregar_existencia As TextBox
    Friend WithEvents txt_productos_agregar_unidad As TextBox
    Friend WithEvents Label6 As Label
End Class
