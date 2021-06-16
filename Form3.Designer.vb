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
        Me.txt_agregar_nivel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel"
        '
        'txt_agregar_usuario
        '
        Me.txt_agregar_usuario.Location = New System.Drawing.Point(316, 145)
        Me.txt_agregar_usuario.Name = "txt_agregar_usuario"
        Me.txt_agregar_usuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_agregar_usuario.TabIndex = 4
        '
        'txt_agregar_contrasena
        '
        Me.txt_agregar_contrasena.Location = New System.Drawing.Point(316, 195)
        Me.txt_agregar_contrasena.Name = "txt_agregar_contrasena"
        Me.txt_agregar_contrasena.Size = New System.Drawing.Size(100, 22)
        Me.txt_agregar_contrasena.TabIndex = 5
        '
        'btn_agregar_usuario
        '
        Me.btn_agregar_usuario.Location = New System.Drawing.Point(242, 340)
        Me.btn_agregar_usuario.Name = "btn_agregar_usuario"
        Me.btn_agregar_usuario.Size = New System.Drawing.Size(82, 32)
        Me.btn_agregar_usuario.TabIndex = 6
        Me.btn_agregar_usuario.Text = "Agregar"
        Me.btn_agregar_usuario.UseVisualStyleBackColor = True
        '
        'btn_agregar_volver
        '
        Me.btn_agregar_volver.Location = New System.Drawing.Point(415, 340)
        Me.btn_agregar_volver.Name = "btn_agregar_volver"
        Me.btn_agregar_volver.Size = New System.Drawing.Size(86, 32)
        Me.btn_agregar_volver.TabIndex = 7
        Me.btn_agregar_volver.Text = "Volver"
        Me.btn_agregar_volver.UseVisualStyleBackColor = True
        '
        'txt_agregar_nivel
        '
        Me.txt_agregar_nivel.Location = New System.Drawing.Point(316, 244)
        Me.txt_agregar_nivel.Name = "txt_agregar_nivel"
        Me.txt_agregar_nivel.Size = New System.Drawing.Size(100, 22)
        Me.txt_agregar_nivel.TabIndex = 8
        '
        'Form_agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_agregar_nivel)
        Me.Controls.Add(Me.btn_agregar_volver)
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
    Friend WithEvents btn_agregar_volver As Button
    Friend WithEvents txt_agregar_nivel As TextBox
End Class
