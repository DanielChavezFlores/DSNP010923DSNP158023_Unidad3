<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.Media = New System.Windows.Forms.Button()
        Me.Cajero = New System.Windows.Forms.Button()
        Me.Impuesto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Media
        '
        Me.Media.BackColor = System.Drawing.Color.Peru
        Me.Media.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Media.Location = New System.Drawing.Point(138, 70)
        Me.Media.Name = "Media"
        Me.Media.Size = New System.Drawing.Size(186, 98)
        Me.Media.TabIndex = 0
        Me.Media.Text = "Media Armonica"
        Me.Media.UseVisualStyleBackColor = False
        '
        'Cajero
        '
        Me.Cajero.BackColor = System.Drawing.Color.DarkOrange
        Me.Cajero.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cajero.Location = New System.Drawing.Point(138, 196)
        Me.Cajero.Name = "Cajero"
        Me.Cajero.Size = New System.Drawing.Size(186, 98)
        Me.Cajero.TabIndex = 1
        Me.Cajero.Text = "Cajero Automatico"
        Me.Cajero.UseVisualStyleBackColor = False
        '
        'Impuesto
        '
        Me.Impuesto.BackColor = System.Drawing.Color.DarkGreen
        Me.Impuesto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impuesto.Location = New System.Drawing.Point(138, 317)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Size = New System.Drawing.Size(186, 98)
        Me.Impuesto.TabIndex = 2
        Me.Impuesto.Text = "Calculo de impuesto"
        Me.Impuesto.UseVisualStyleBackColor = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(455, 450)
        Me.Controls.Add(Me.Impuesto)
        Me.Controls.Add(Me.Cajero)
        Me.Controls.Add(Me.Media)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Principal"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Media As Button
    Friend WithEvents Cajero As Button
    Friend WithEvents Impuesto As Button
End Class
