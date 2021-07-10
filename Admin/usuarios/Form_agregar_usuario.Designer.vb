<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_agregar_usuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_agregar_usuario = New System.Windows.Forms.TextBox()
        Me.txt_agregar_contrasena = New System.Windows.Forms.TextBox()
        Me.btn_agregar_usuario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_agregar_nivel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel"
        '
        'txt_agregar_usuario
        '
        Me.txt_agregar_usuario.Location = New System.Drawing.Point(254, 104)
        Me.txt_agregar_usuario.Name = "txt_agregar_usuario"
        Me.txt_agregar_usuario.Size = New System.Drawing.Size(160, 22)
        Me.txt_agregar_usuario.TabIndex = 4
        '
        'txt_agregar_contrasena
        '
        Me.txt_agregar_contrasena.Location = New System.Drawing.Point(254, 169)
        Me.txt_agregar_contrasena.Name = "txt_agregar_contrasena"
        Me.txt_agregar_contrasena.Size = New System.Drawing.Size(160, 22)
        Me.txt_agregar_contrasena.TabIndex = 5
        '
        'btn_agregar_usuario
        '
        Me.btn_agregar_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_agregar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar_usuario.Location = New System.Drawing.Point(208, 340)
        Me.btn_agregar_usuario.Name = "btn_agregar_usuario"
        Me.btn_agregar_usuario.Size = New System.Drawing.Size(155, 50)
        Me.btn_agregar_usuario.TabIndex = 6
        Me.btn_agregar_usuario.Text = "Agregar"
        Me.btn_agregar_usuario.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Complete el registro"
        '
        'cmb_agregar_nivel
        '
        Me.cmb_agregar_nivel.FormattingEnabled = True
        Me.cmb_agregar_nivel.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmb_agregar_nivel.Location = New System.Drawing.Point(254, 242)
        Me.cmb_agregar_nivel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_agregar_nivel.Name = "cmb_agregar_nivel"
        Me.cmb_agregar_nivel.Size = New System.Drawing.Size(160, 24)
        Me.cmb_agregar_nivel.TabIndex = 10
        '
        'Form_agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 424)
        Me.Controls.Add(Me.cmb_agregar_nivel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_agregar_usuario)
        Me.Controls.Add(Me.txt_agregar_contrasena)
        Me.Controls.Add(Me.txt_agregar_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_agregar_usuario"
        Me.Text = "Agregar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_agregar_usuario As TextBox
    Friend WithEvents txt_agregar_contrasena As TextBox
    Friend WithEvents btn_agregar_usuario As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_agregar_nivel As ComboBox
End Class
