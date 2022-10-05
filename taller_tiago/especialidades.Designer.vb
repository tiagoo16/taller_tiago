<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class especialidades
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
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btninsertr = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Especialidad = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(287, 151)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNMOSTRAR.TabIndex = 40
        Me.BTNMOSTRAR.Text = "Mostrar"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(193, 151)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 39
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(22, 151)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 38
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Consultar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 36
        '
        'btninsertr
        '
        Me.btninsertr.Location = New System.Drawing.Point(103, 151)
        Me.btninsertr.Name = "btninsertr"
        Me.btninsertr.Size = New System.Drawing.Size(75, 23)
        Me.btninsertr.TabIndex = 35
        Me.btninsertr.Text = "Insertar"
        Me.btninsertr.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(4, 123)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(79, 13)
        Me.Label.TabIndex = 34
        Me.Label.Text = "Id Especialidad"
        '
        'Especialidad
        '
        Me.Especialidad.AutoSize = True
        Me.Especialidad.Location = New System.Drawing.Point(4, 41)
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.Size = New System.Drawing.Size(78, 13)
        Me.Especialidad.TabIndex = 33
        Me.Especialidad.Text = "Especialidades"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(88, 38)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(108, 20)
        Me.txtnombre.TabIndex = 31
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(88, 116)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(71, 20)
        Me.txtid.TabIndex = 41
        '
        'especialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 387)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.BTNMOSTRAR)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btninsertr)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Especialidad)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "especialidades"
        Me.Text = "especialidades"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btninsertr As Button
    Friend WithEvents Label As Label
    Friend WithEvents Especialidad As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtid As TextBox
End Class
