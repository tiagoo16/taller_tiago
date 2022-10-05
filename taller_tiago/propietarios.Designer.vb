<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class propietarios
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
        Me.components = New System.ComponentModel.Container()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.btninsertr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PropietariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_tiagoDataSet = New taller_tiago.taller_tiagoDataSet()
        Me.TallertiagoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropietariosTableAdapter = New taller_tiago.taller_tiagoDataSetTableAdapters.propietariosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_tiagoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallertiagoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(84, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(214, 20)
        Me.txtnombre.TabIndex = 0
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(84, 72)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(214, 20)
        Me.txttelefono.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 79)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(49, 13)
        Me.Label.TabIndex = 3
        Me.Label.Text = "Telefono"
        '
        'btninsertr
        '
        Me.btninsertr.Location = New System.Drawing.Point(121, 120)
        Me.btninsertr.Name = "btninsertr"
        Me.btninsertr.Size = New System.Drawing.Size(75, 23)
        Me.btninsertr.TabIndex = 4
        Me.btninsertr.Text = "Insertar"
        Me.btninsertr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'PropietariosBindingSource
        '
        Me.PropietariosBindingSource.DataMember = "propietarios"
        Me.PropietariosBindingSource.DataSource = Me.Taller_tiagoDataSet
        '
        'Taller_tiagoDataSet
        '
        Me.Taller_tiagoDataSet.DataSetName = "taller_tiagoDataSet"
        Me.Taller_tiagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TallertiagoDataSetBindingSource
        '
        Me.TallertiagoDataSetBindingSource.DataSource = Me.Taller_tiagoDataSet
        Me.TallertiagoDataSetBindingSource.Position = 0
        '
        'PropietariosTableAdapter
        '
        Me.PropietariosTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Consultar"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(25, 120)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 7
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(202, 120)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 17
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(283, 120)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNMOSTRAR.TabIndex = 18
        Me.BTNMOSTRAR.Text = "Mostrar"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(322, 36)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(71, 20)
        Me.txtid.TabIndex = 19
        '
        'propietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 385)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.BTNMOSTRAR)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btninsertr)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "propietarios"
        Me.Text = "propietarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_tiagoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallertiagoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents btninsertr As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TallertiagoDataSetBindingSource As BindingSource
    Friend WithEvents Taller_tiagoDataSet As taller_tiagoDataSet
    Friend WithEvents PropietariosBindingSource As BindingSource
    Friend WithEvents PropietariosTableAdapter As taller_tiagoDataSetTableAdapters.propietariosTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents txtid As TextBox
End Class
