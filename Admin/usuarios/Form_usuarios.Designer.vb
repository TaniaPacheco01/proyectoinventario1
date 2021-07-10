<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_usuarios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_inicio_form_usuarios = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_buscar_usuarios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_modificar_usuarios = New System.Windows.Forms.Button()
        Me.btn_agregar_ir_a_registro = New System.Windows.Forms.Button()
        Me.btn_eliminar_usuarios = New System.Windows.Forms.Button()
        Me.DataGridView1_usuarios = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_inicio_form_usuarios)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1_usuarios)
        Me.SplitContainer1.Size = New System.Drawing.Size(1184, 494)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_inicio_form_usuarios
        '
        Me.btn_inicio_form_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_inicio_form_usuarios.BackgroundImage = CType(resources.GetObject("btn_inicio_form_usuarios.BackgroundImage"), System.Drawing.Image)
        Me.btn_inicio_form_usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_inicio_form_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.8209!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio_form_usuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_inicio_form_usuarios.Location = New System.Drawing.Point(3, 3)
        Me.btn_inicio_form_usuarios.Name = "btn_inicio_form_usuarios"
        Me.btn_inicio_form_usuarios.Size = New System.Drawing.Size(141, 47)
        Me.btn_inicio_form_usuarios.TabIndex = 2
        Me.btn_inicio_form_usuarios.Text = "      Inicio"
        Me.btn_inicio_form_usuarios.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_buscar_usuarios)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txt_buscar_usuarios
        '
        Me.txt_buscar_usuarios.Location = New System.Drawing.Point(81, 32)
        Me.txt_buscar_usuarios.Name = "txt_buscar_usuarios"
        Me.txt_buscar_usuarios.Size = New System.Drawing.Size(153, 22)
        Me.txt_buscar_usuarios.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.20895!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_modificar_usuarios)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_ir_a_registro)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar_usuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accionnes"
        '
        'btn_modificar_usuarios
        '
        Me.btn_modificar_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_usuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar_usuarios.Location = New System.Drawing.Point(10, 39)
        Me.btn_modificar_usuarios.Name = "btn_modificar_usuarios"
        Me.btn_modificar_usuarios.Size = New System.Drawing.Size(130, 37)
        Me.btn_modificar_usuarios.TabIndex = 5
        Me.btn_modificar_usuarios.Text = "Modificar"
        Me.btn_modificar_usuarios.UseVisualStyleBackColor = False
        '
        'btn_agregar_ir_a_registro
        '
        Me.btn_agregar_ir_a_registro.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_agregar_ir_a_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_ir_a_registro.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_ir_a_registro.Location = New System.Drawing.Point(10, 82)
        Me.btn_agregar_ir_a_registro.Name = "btn_agregar_ir_a_registro"
        Me.btn_agregar_ir_a_registro.Size = New System.Drawing.Size(133, 37)
        Me.btn_agregar_ir_a_registro.TabIndex = 4
        Me.btn_agregar_ir_a_registro.Text = "Agregar"
        Me.btn_agregar_ir_a_registro.UseVisualStyleBackColor = False
        '
        'btn_eliminar_usuarios
        '
        Me.btn_eliminar_usuarios.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_usuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar_usuarios.Location = New System.Drawing.Point(11, 125)
        Me.btn_eliminar_usuarios.Name = "btn_eliminar_usuarios"
        Me.btn_eliminar_usuarios.Size = New System.Drawing.Size(132, 37)
        Me.btn_eliminar_usuarios.TabIndex = 3
        Me.btn_eliminar_usuarios.Text = "Eliminar"
        Me.btn_eliminar_usuarios.UseVisualStyleBackColor = False
        '
        'DataGridView1_usuarios
        '
        Me.DataGridView1_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.DataGridView1_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1_usuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1_usuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.DataGridView1_usuarios.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1_usuarios.Name = "DataGridView1_usuarios"
        Me.DataGridView1_usuarios.RowHeadersWidth = 51
        Me.DataGridView1_usuarios.RowTemplate.Height = 24
        Me.DataGridView1_usuarios.Size = New System.Drawing.Size(805, 494)
        Me.DataGridView1_usuarios.TabIndex = 0
        '
        'Form_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 494)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form_usuarios"
        Me.Text = "Usuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1_usuarios As DataGridView
    Friend WithEvents btn_modificar_usuarios As Button
    Friend WithEvents btn_agregar_ir_a_registro As Button
    Friend WithEvents btn_eliminar_usuarios As Button
    Friend WithEvents txt_buscar_usuarios As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inicio_form_usuarios As Button
End Class
