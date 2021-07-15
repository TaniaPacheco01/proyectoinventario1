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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_menu))
        Me.btn_menu_productos = New System.Windows.Forms.Button()
        Me.btn_menu_admin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar_sesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_menu_productos
        '
        Me.btn_menu_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_menu_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.74627!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_productos.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_menu_productos.Location = New System.Drawing.Point(0, 131)
        Me.btn_menu_productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_menu_productos.Name = "btn_menu_productos"
        Me.btn_menu_productos.Size = New System.Drawing.Size(162, 65)
        Me.btn_menu_productos.TabIndex = 0
        Me.btn_menu_productos.Text = "Ir a productos"
        Me.btn_menu_productos.UseVisualStyleBackColor = False
        '
        'btn_menu_admin
        '
        Me.btn_menu_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_menu_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.74627!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_admin.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_menu_admin.Location = New System.Drawing.Point(0, 35)
        Me.btn_menu_admin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_menu_admin.Name = "btn_menu_admin"
        Me.btn_menu_admin.Size = New System.Drawing.Size(162, 57)
        Me.btn_menu_admin.TabIndex = 1
        Me.btn_menu_admin.Text = "Administrar"
        Me.btn_menu_admin.UseVisualStyleBackColor = False
        Me.btn_menu_admin.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar_sesion)
        Me.Panel1.Controls.Add(Me.btn_menu_admin)
        Me.Panel1.Controls.Add(Me.btn_menu_productos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 360)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(340, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn_cerrar_sesion
        '
        Me.btn_cerrar_sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrar_sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.74627!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar_sesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_cerrar_sesion.Location = New System.Drawing.Point(0, 295)
        Me.btn_cerrar_sesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cerrar_sesion.Name = "btn_cerrar_sesion"
        Me.btn_cerrar_sesion.Size = New System.Drawing.Size(162, 65)
        Me.btn_cerrar_sesion.TabIndex = 2
        Me.btn_cerrar_sesion.Text = "Cerrar sesion"
        Me.btn_cerrar_sesion.UseVisualStyleBackColor = False
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_menu"
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_menu_productos As Button
    Friend WithEvents btn_menu_admin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cerrar_sesion As Button
End Class
