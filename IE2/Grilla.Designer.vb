<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grilla
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Elimina = New System.Windows.Forms.Button
        Me.Modifica = New System.Windows.Forms.Button
        Me.Nuevo = New System.Windows.Forms.Button
        Me.TurnosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vocal1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vocal2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.AsignaturaDataGridViewTextBoxColumn, Me.DocenteDataGridViewTextBoxColumn, Me.Vocal1DataGridViewTextBoxColumn, Me.Vocal2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TurnosCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(624, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'Elimina
        '
        Me.Elimina.Location = New System.Drawing.Point(163, 227)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(75, 23)
        Me.Elimina.TabIndex = 1
        Me.Elimina.Text = "Elimina"
        Me.Elimina.UseVisualStyleBackColor = True
        '
        'Modifica
        '
        Me.Modifica.Location = New System.Drawing.Point(269, 227)
        Me.Modifica.Name = "Modifica"
        Me.Modifica.Size = New System.Drawing.Size(75, 23)
        Me.Modifica.TabIndex = 2
        Me.Modifica.Text = "Modifica"
        Me.Modifica.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(381, 227)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo.TabIndex = 3
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'TurnosCollectionBindingSource
        '
        Me.TurnosCollectionBindingSource.DataSource = GetType(IE2.TurnosCollection)
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignaturaDataGridViewTextBoxColumn
        '
        Me.AsignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.Name = "AsignaturaDataGridViewTextBoxColumn"
        Me.AsignaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocenteDataGridViewTextBoxColumn
        '
        Me.DocenteDataGridViewTextBoxColumn.DataPropertyName = "Docente"
        Me.DocenteDataGridViewTextBoxColumn.HeaderText = "Docente"
        Me.DocenteDataGridViewTextBoxColumn.Name = "DocenteDataGridViewTextBoxColumn"
        Me.DocenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Vocal1DataGridViewTextBoxColumn
        '
        Me.Vocal1DataGridViewTextBoxColumn.DataPropertyName = "Vocal1"
        Me.Vocal1DataGridViewTextBoxColumn.HeaderText = "Vocal1"
        Me.Vocal1DataGridViewTextBoxColumn.Name = "Vocal1DataGridViewTextBoxColumn"
        Me.Vocal1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Vocal2DataGridViewTextBoxColumn
        '
        Me.Vocal2DataGridViewTextBoxColumn.DataPropertyName = "Vocal2"
        Me.Vocal2DataGridViewTextBoxColumn.HeaderText = "Vocal2"
        Me.Vocal2DataGridViewTextBoxColumn.Name = "Vocal2DataGridViewTextBoxColumn"
        Me.Vocal2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Grilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 262)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.Modifica)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Grilla"
        Me.Text = "Grilla"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents Modifica As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsignaturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vocal1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vocal2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnosCollectionBindingSource As System.Windows.Forms.BindingSource
End Class
