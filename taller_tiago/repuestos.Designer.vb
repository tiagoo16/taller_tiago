<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repuestos
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btninsertr = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(340, 42)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(71, 20)
        Me.txtid.TabIndex = 30
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(295, 159)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNMOSTRAR.TabIndex = 29
        Me.BTNMOSTRAR.Text = "Mostrar"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(201, 159)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 28
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(30, 159)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 27
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Consultar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'btninsertr
        '
        Me.btninsertr.Location = New System.Drawing.Point(111, 159)
        Me.btninsertr.Name = "btninsertr"
        Me.btninsertr.Size = New System.Drawing.Size(75, 23)
        Me.btninsertr.TabIndex = 24
        Me.btninsertr.Text = "Insertar"
        Me.btninsertr.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 131)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(42, 13)
        Me.Label.TabIndex = 23
        Me.Label.Text = "Importe"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(12, 49)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 22
        Me.Descripcion.Text = "Descripcion"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(80, 133)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(51, 20)
        Me.txttelefono.TabIndex = 21
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(80, 46)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(214, 49)
        Me.txtnombre.TabIndex = 20
        '
        'repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 403)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.BTNMOSTRAR)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btninsertr)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "repuestos"
        Me.Text = "repuestos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btninsertr As Button
    Friend WithEvents Label As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtnombre As TextBox
End Class
