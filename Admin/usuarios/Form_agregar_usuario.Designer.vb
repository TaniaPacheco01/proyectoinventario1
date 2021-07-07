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
        Me.btn_agregar_volver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_agregar_nivel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel"
        '
        'txt_agregar_usuario
        '
        Me.txt_agregar_usuario.Location = New System.Drawing.Point(356, 132)
        Me.txt_agregar_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_agregar_usuario.Name = "txt_agregar_usuario"
        Me.txt_agregar_usuario.Size = New System.Drawing.Size(180, 26)
        Me.txt_agregar_usuario.TabIndex = 4
        '
        'txt_agregar_contrasena
        '
        Me.txt_agregar_contrasena.Location = New System.Drawing.Point(356, 219)
        Me.txt_agregar_contrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_agregar_contrasena.Name = "txt_agregar_contrasena"
        Me.txt_agregar_contrasena.Size = New System.Drawing.Size(180, 26)
        Me.txt_agregar_contrasena.TabIndex = 5
        '
        'btn_agregar_usuario
        '
        Me.btn_agregar_usuario.BackColor = System.Drawing.Color.Blue
        Me.btn_agregar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar_usuario.Location = New System.Drawing.Point(209, 425)
        Me.btn_agregar_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_agregar_usuario.Name = "btn_agregar_usuario"
        Me.btn_agregar_usuario.Size = New System.Drawing.Size(188, 71)
        Me.btn_agregar_usuario.TabIndex = 6
        Me.btn_agregar_usuario.Text = "Agregar"
        Me.btn_agregar_usuario.UseVisualStyleBackColor = False
        '
        'btn_agregar_volver
        '
        Me.btn_agregar_volver.BackColor = System.Drawing.Color.Blue
        Me.btn_agregar_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_volver.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar_volver.Location = New System.Drawing.Point(467, 425)
        Me.btn_agregar_volver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_agregar_volver.Name = "btn_agregar_volver"
        Me.btn_agregar_volver.Size = New System.Drawing.Size(166, 71)
        Me.btn_agregar_volver.TabIndex = 7
        Me.btn_agregar_volver.Text = "Volver"
        Me.btn_agregar_volver.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Complete el registro"
        '
        'cmb_agregar_nivel
        '
        Me.cmb_agregar_nivel.FormattingEnabled = True
        Me.cmb_agregar_nivel.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmb_agregar_nivel.Location = New System.Drawing.Point(356, 305)
        Me.cmb_agregar_nivel.Name = "cmb_agregar_nivel"
        Me.cmb_agregar_nivel.Size = New System.Drawing.Size(180, 28)
        Me.cmb_agregar_nivel.TabIndex = 10
        '
        'Form_agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(831, 570)
        Me.Controls.Add(Me.cmb_agregar_nivel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_agregar_volver)
        Me.Controls.Add(Me.btn_agregar_usuario)
        Me.Controls.Add(Me.txt_agregar_contrasena)
        Me.Controls.Add(Me.txt_agregar_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents btn_agregar_volver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_agregar_nivel As ComboBox
End Class
