﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_eliminar_usuarios
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
        Me.btn_buscar_usuario = New System.Windows.Forms.Button()
        Me.btn_eliminar_usuario = New System.Windows.Forms.Button()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.txt_idusuario = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID de usuarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'btn_buscar_usuario
        '
        Me.btn_buscar_usuario.BackColor = System.Drawing.Color.Blue
        Me.btn_buscar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_buscar_usuario.Location = New System.Drawing.Point(548, 99)
        Me.btn_buscar_usuario.Name = "btn_buscar_usuario"
        Me.btn_buscar_usuario.Size = New System.Drawing.Size(110, 46)
        Me.btn_buscar_usuario.TabIndex = 3
        Me.btn_buscar_usuario.Text = "Buscar"
        Me.btn_buscar_usuario.UseVisualStyleBackColor = False
        '
        'btn_eliminar_usuario
        '
        Me.btn_eliminar_usuario.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar_usuario.Location = New System.Drawing.Point(548, 195)
        Me.btn_eliminar_usuario.Name = "btn_eliminar_usuario"
        Me.btn_eliminar_usuario.Size = New System.Drawing.Size(110, 43)
        Me.btn_eliminar_usuario.TabIndex = 4
        Me.btn_eliminar_usuario.Text = "Eliminar"
        Me.btn_eliminar_usuario.UseVisualStyleBackColor = False
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(339, 88)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_buscar_usuario.TabIndex = 5
        '
        'txt_idusuario
        '
        Me.txt_idusuario.Location = New System.Drawing.Point(339, 162)
        Me.txt_idusuario.Name = "txt_idusuario"
        Me.txt_idusuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_idusuario.TabIndex = 6
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(339, 229)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(100, 22)
        Me.txt_nombre_usuario.TabIndex = 7
        '
        'Form_eliminar_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(754, 372)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.txt_idusuario)
        Me.Controls.Add(Me.txt_buscar_usuario)
        Me.Controls.Add(Me.btn_eliminar_usuario)
        Me.Controls.Add(Me.btn_buscar_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_eliminar_usuarios"
        Me.Text = "Eliminar usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_buscar_usuario As Button
    Friend WithEvents btn_eliminar_usuario As Button
    Friend WithEvents txt_buscar_usuario As TextBox
    Friend WithEvents txt_idusuario As TextBox
    Friend WithEvents txt_nombre_usuario As TextBox
End Class