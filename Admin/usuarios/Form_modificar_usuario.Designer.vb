<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_modificar_usuario
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
        Me.txt_modificar_usuario_usuario = New System.Windows.Forms.TextBox()
        Me.txt_modificar_usuario_contrasena = New System.Windows.Forms.TextBox()
        Me.btn_modificar_usuario_volver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_modificar_usuario_id = New System.Windows.Forms.TextBox()
        Me.DataGridView2_modificar_usuario = New System.Windows.Forms.DataGridView()
        Me.btn_modificar_form_modificar_usuario = New System.Windows.Forms.Button()
        Me.cmb_modificar_usuario_nivel = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView2_modificar_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel"
        '
        'txt_modificar_usuario_usuario
        '
        Me.txt_modificar_usuario_usuario.Location = New System.Drawing.Point(309, 146)
        Me.txt_modificar_usuario_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_modificar_usuario_usuario.Name = "txt_modificar_usuario_usuario"
        Me.txt_modificar_usuario_usuario.Size = New System.Drawing.Size(131, 26)
        Me.txt_modificar_usuario_usuario.TabIndex = 3
        '
        'txt_modificar_usuario_contrasena
        '
        Me.txt_modificar_usuario_contrasena.Location = New System.Drawing.Point(309, 218)
        Me.txt_modificar_usuario_contrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_modificar_usuario_contrasena.Name = "txt_modificar_usuario_contrasena"
        Me.txt_modificar_usuario_contrasena.Size = New System.Drawing.Size(131, 26)
        Me.txt_modificar_usuario_contrasena.TabIndex = 4
        '
        'btn_modificar_usuario_volver
        '
        Me.btn_modificar_usuario_volver.BackColor = System.Drawing.Color.Blue
        Me.btn_modificar_usuario_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_usuario_volver.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar_usuario_volver.Location = New System.Drawing.Point(364, 468)
        Me.btn_modificar_usuario_volver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_modificar_usuario_volver.Name = "btn_modificar_usuario_volver"
        Me.btn_modificar_usuario_volver.Size = New System.Drawing.Size(130, 49)
        Me.btn_modificar_usuario_volver.TabIndex = 7
        Me.btn_modificar_usuario_volver.Text = "Volver"
        Me.btn_modificar_usuario_volver.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ID de usuario"
        '
        'txt_modificar_usuario_id
        '
        Me.txt_modificar_usuario_id.Enabled = False
        Me.txt_modificar_usuario_id.Location = New System.Drawing.Point(309, 73)
        Me.txt_modificar_usuario_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_modificar_usuario_id.Name = "txt_modificar_usuario_id"
        Me.txt_modificar_usuario_id.Size = New System.Drawing.Size(112, 26)
        Me.txt_modificar_usuario_id.TabIndex = 9
        '
        'DataGridView2_modificar_usuario
        '
        Me.DataGridView2_modificar_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2_modificar_usuario.Location = New System.Drawing.Point(578, 68)
        Me.DataGridView2_modificar_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2_modificar_usuario.Name = "DataGridView2_modificar_usuario"
        Me.DataGridView2_modificar_usuario.RowHeadersWidth = 51
        Me.DataGridView2_modificar_usuario.RowTemplate.Height = 24
        Me.DataGridView2_modificar_usuario.Size = New System.Drawing.Size(550, 375)
        Me.DataGridView2_modificar_usuario.TabIndex = 10
        '
        'btn_modificar_form_modificar_usuario
        '
        Me.btn_modificar_form_modificar_usuario.BackColor = System.Drawing.Color.Blue
        Me.btn_modificar_form_modificar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_form_modificar_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar_form_modificar_usuario.Location = New System.Drawing.Point(135, 468)
        Me.btn_modificar_form_modificar_usuario.Name = "btn_modificar_form_modificar_usuario"
        Me.btn_modificar_form_modificar_usuario.Size = New System.Drawing.Size(139, 47)
        Me.btn_modificar_form_modificar_usuario.TabIndex = 12
        Me.btn_modificar_form_modificar_usuario.Text = "Modificar"
        Me.btn_modificar_form_modificar_usuario.UseVisualStyleBackColor = False
        '
        'cmb_modificar_usuario_nivel
        '
        Me.cmb_modificar_usuario_nivel.FormattingEnabled = True
        Me.cmb_modificar_usuario_nivel.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmb_modificar_usuario_nivel.Location = New System.Drawing.Point(309, 297)
        Me.cmb_modificar_usuario_nivel.Name = "cmb_modificar_usuario_nivel"
        Me.cmb_modificar_usuario_nivel.Size = New System.Drawing.Size(131, 28)
        Me.cmb_modificar_usuario_nivel.TabIndex = 13
        '
        'Form_modificar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1195, 711)
        Me.Controls.Add(Me.cmb_modificar_usuario_nivel)
        Me.Controls.Add(Me.btn_modificar_form_modificar_usuario)
        Me.Controls.Add(Me.DataGridView2_modificar_usuario)
        Me.Controls.Add(Me.txt_modificar_usuario_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_modificar_usuario_volver)
        Me.Controls.Add(Me.txt_modificar_usuario_contrasena)
        Me.Controls.Add(Me.txt_modificar_usuario_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_modificar_usuario"
        Me.Text = "Modificar usuario"
        CType(Me.DataGridView2_modificar_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_modificar_usuario_usuario As TextBox
    Friend WithEvents txt_modificar_usuario_contrasena As TextBox
    Friend WithEvents btn_modificar_usuario_volver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_modificar_usuario_id As TextBox
    Friend WithEvents DataGridView2_modificar_usuario As DataGridView
    Friend WithEvents btn_modificar_form_modificar_usuario As Button
    Friend WithEvents cmb_modificar_usuario_nivel As ComboBox
End Class
