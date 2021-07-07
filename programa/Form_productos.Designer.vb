<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_productos
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar_productos = New System.Windows.Forms.Button()
        Me.GroupBox_form_productos = New System.Windows.Forms.GroupBox()
        Me.btn_modificar_productos = New System.Windows.Forms.Button()
        Me.btn_agregar_productos = New System.Windows.Forms.Button()
        Me.btn_eliminar_productos = New System.Windows.Forms.Button()
        Me.DataGridView2_productos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_buscar_productos = New System.Windows.Forms.TextBox()
        Me.btn_inicio_form_productos = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox_form_productos.SuspendLayout()
        CType(Me.DataGridView2_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_inicio_form_productos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox_form_productos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2_productos)
        Me.SplitContainer1.Size = New System.Drawing.Size(1133, 498)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_buscar_productos)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar_productos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btn_actualizar_productos
        '
        Me.btn_actualizar_productos.BackColor = System.Drawing.Color.Blue
        Me.btn_actualizar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_actualizar_productos.Location = New System.Drawing.Point(294, 60)
        Me.btn_actualizar_productos.Name = "btn_actualizar_productos"
        Me.btn_actualizar_productos.Size = New System.Drawing.Size(130, 37)
        Me.btn_actualizar_productos.TabIndex = 6
        Me.btn_actualizar_productos.Text = "Actualizar"
        Me.btn_actualizar_productos.UseVisualStyleBackColor = False
        '
        'GroupBox_form_productos
        '
        Me.GroupBox_form_productos.Controls.Add(Me.btn_modificar_productos)
        Me.GroupBox_form_productos.Controls.Add(Me.btn_agregar_productos)
        Me.GroupBox_form_productos.Controls.Add(Me.btn_eliminar_productos)
        Me.GroupBox_form_productos.Location = New System.Drawing.Point(460, 3)
        Me.GroupBox_form_productos.Name = "GroupBox_form_productos"
        Me.GroupBox_form_productos.Size = New System.Drawing.Size(475, 103)
        Me.GroupBox_form_productos.TabIndex = 2
        Me.GroupBox_form_productos.TabStop = False
        Me.GroupBox_form_productos.Text = "Accionnes"
        Me.GroupBox_form_productos.Visible = False
        '
        'btn_modificar_productos
        '
        Me.btn_modificar_productos.BackColor = System.Drawing.Color.Blue
        Me.btn_modificar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar_productos.Location = New System.Drawing.Point(16, 60)
        Me.btn_modificar_productos.Name = "btn_modificar_productos"
        Me.btn_modificar_productos.Size = New System.Drawing.Size(130, 37)
        Me.btn_modificar_productos.TabIndex = 5
        Me.btn_modificar_productos.Text = "Modificar"
        Me.btn_modificar_productos.UseVisualStyleBackColor = False
        '
        'btn_agregar_productos
        '
        Me.btn_agregar_productos.BackColor = System.Drawing.Color.Blue
        Me.btn_agregar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar_productos.Location = New System.Drawing.Point(171, 60)
        Me.btn_agregar_productos.Name = "btn_agregar_productos"
        Me.btn_agregar_productos.Size = New System.Drawing.Size(133, 37)
        Me.btn_agregar_productos.TabIndex = 4
        Me.btn_agregar_productos.Text = "Agregar"
        Me.btn_agregar_productos.UseVisualStyleBackColor = False
        '
        'btn_eliminar_productos
        '
        Me.btn_eliminar_productos.BackColor = System.Drawing.Color.Blue
        Me.btn_eliminar_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar_productos.Location = New System.Drawing.Point(325, 60)
        Me.btn_eliminar_productos.Name = "btn_eliminar_productos"
        Me.btn_eliminar_productos.Size = New System.Drawing.Size(132, 37)
        Me.btn_eliminar_productos.TabIndex = 3
        Me.btn_eliminar_productos.Text = "Eliminar"
        Me.btn_eliminar_productos.UseVisualStyleBackColor = False
        '
        'DataGridView2_productos
        '
        Me.DataGridView2_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2_productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2_productos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2_productos.Name = "DataGridView2_productos"
        Me.DataGridView2_productos.RowHeadersWidth = 62
        Me.DataGridView2_productos.RowTemplate.Height = 28
        Me.DataGridView2_productos.Size = New System.Drawing.Size(1133, 341)
        Me.DataGridView2_productos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.20895!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar"
        '
        'txt_buscar_productos
        '
        Me.txt_buscar_productos.Location = New System.Drawing.Point(100, 38)
        Me.txt_buscar_productos.Name = "txt_buscar_productos"
        Me.txt_buscar_productos.Size = New System.Drawing.Size(153, 22)
        Me.txt_buscar_productos.TabIndex = 8
        '
        'btn_inicio_form_productos
        '
        Me.btn_inicio_form_productos.BackColor = System.Drawing.Color.Blue
        Me.btn_inicio_form_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio_form_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_inicio_form_productos.Location = New System.Drawing.Point(961, 63)
        Me.btn_inicio_form_productos.Name = "btn_inicio_form_productos"
        Me.btn_inicio_form_productos.Size = New System.Drawing.Size(132, 37)
        Me.btn_inicio_form_productos.TabIndex = 6
        Me.btn_inicio_form_productos.Text = "Inicio"
        Me.btn_inicio_form_productos.UseVisualStyleBackColor = False
        '
        'Form_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1133, 498)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_productos"
        Me.Text = "Lista de productos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox_form_productos.ResumeLayout(False)
        CType(Me.DataGridView2_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_actualizar_productos As Button
    Friend WithEvents GroupBox_form_productos As GroupBox
    Friend WithEvents btn_modificar_productos As Button
    Friend WithEvents btn_agregar_productos As Button
    Friend WithEvents btn_eliminar_productos As Button
    Friend WithEvents DataGridView2_productos As DataGridView
    Friend WithEvents txt_buscar_productos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inicio_form_productos As Button
End Class
