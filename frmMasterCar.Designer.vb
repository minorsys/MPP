<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCar
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.grdCar = New System.Windows.Forms.DataGridView()
        Me.Carnum1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.max_load = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_syaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        CType(Me.grdCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(182, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "選択行の削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "選択行の編集"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "新規登録"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'grdCar
        '
        Me.grdCar.AllowUserToAddRows = False
        Me.grdCar.AllowUserToDeleteRows = False
        Me.grdCar.AllowUserToOrderColumns = True
        Me.grdCar.AutoGenerateColumns = False
        Me.grdCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Carnum1DataGridViewTextBoxColumn, Me.Carnum2DataGridViewTextBoxColumn, Me.Carnum3DataGridViewTextBoxColumn, Me.Carnum4DataGridViewTextBoxColumn, Me.MusenDataGridViewTextBoxColumn, Me.TonDataGridViewTextBoxColumn, Me.BikoDataGridViewTextBoxColumn, Me.BranchidDataGridViewTextBoxColumn, Me.StaffidDataGridViewTextBoxColumn, Me.max_load, Me.limit_syaken})
        Me.grdCar.DataSource = Me.TblcarBindingSource
        Me.grdCar.Location = New System.Drawing.Point(12, 41)
        Me.grdCar.Name = "grdCar"
        Me.grdCar.RowTemplate.Height = 21
        Me.grdCar.Size = New System.Drawing.Size(1059, 392)
        Me.grdCar.TabIndex = 6
        '
        'Carnum1DataGridViewTextBoxColumn
        '
        Me.Carnum1DataGridViewTextBoxColumn.DataPropertyName = "carnum1"
        Me.Carnum1DataGridViewTextBoxColumn.HeaderText = "車両番号"
        Me.Carnum1DataGridViewTextBoxColumn.Name = "Carnum1DataGridViewTextBoxColumn"
        Me.Carnum1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum2DataGridViewTextBoxColumn
        '
        Me.Carnum2DataGridViewTextBoxColumn.DataPropertyName = "carnum2"
        Me.Carnum2DataGridViewTextBoxColumn.HeaderText = "地名"
        Me.Carnum2DataGridViewTextBoxColumn.Name = "Carnum2DataGridViewTextBoxColumn"
        Me.Carnum2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum3DataGridViewTextBoxColumn
        '
        Me.Carnum3DataGridViewTextBoxColumn.DataPropertyName = "carnum3"
        Me.Carnum3DataGridViewTextBoxColumn.HeaderText = "分類番号"
        Me.Carnum3DataGridViewTextBoxColumn.Name = "Carnum3DataGridViewTextBoxColumn"
        Me.Carnum3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum4DataGridViewTextBoxColumn
        '
        Me.Carnum4DataGridViewTextBoxColumn.DataPropertyName = "carnum4"
        Me.Carnum4DataGridViewTextBoxColumn.HeaderText = "ひらがな"
        Me.Carnum4DataGridViewTextBoxColumn.Name = "Carnum4DataGridViewTextBoxColumn"
        Me.Carnum4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'MusenDataGridViewTextBoxColumn
        '
        Me.MusenDataGridViewTextBoxColumn.DataPropertyName = "musen"
        Me.MusenDataGridViewTextBoxColumn.HeaderText = "無線"
        Me.MusenDataGridViewTextBoxColumn.Name = "MusenDataGridViewTextBoxColumn"
        Me.MusenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TonDataGridViewTextBoxColumn
        '
        Me.TonDataGridViewTextBoxColumn.DataPropertyName = "ton"
        Me.TonDataGridViewTextBoxColumn.HeaderText = "車格"
        Me.TonDataGridViewTextBoxColumn.Name = "TonDataGridViewTextBoxColumn"
        Me.TonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BikoDataGridViewTextBoxColumn
        '
        Me.BikoDataGridViewTextBoxColumn.DataPropertyName = "biko"
        Me.BikoDataGridViewTextBoxColumn.HeaderText = "備考"
        Me.BikoDataGridViewTextBoxColumn.Name = "BikoDataGridViewTextBoxColumn"
        Me.BikoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchidDataGridViewTextBoxColumn
        '
        Me.BranchidDataGridViewTextBoxColumn.DataPropertyName = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.HeaderText = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.Name = "BranchidDataGridViewTextBoxColumn"
        Me.BranchidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffidDataGridViewTextBoxColumn
        '
        Me.StaffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.HeaderText = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.Name = "StaffidDataGridViewTextBoxColumn"
        Me.StaffidDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffidDataGridViewTextBoxColumn.Visible = False
        '
        'max_load
        '
        Me.max_load.DataPropertyName = "max_load"
        Me.max_load.HeaderText = "最大積載量"
        Me.max_load.Name = "max_load"
        '
        'limit_syaken
        '
        Me.limit_syaken.DataPropertyName = "limit_syaken"
        Me.limit_syaken.HeaderText = "車検証期限"
        Me.limit_syaken.Name = "limit_syaken"
        '
        'TblcarBindingSource
        '
        Me.TblcarBindingSource.DataMember = "tbl_car"
        Me.TblcarBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'frmMasterCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1091, 472)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.grdCar)
        Me.Name = "frmMasterCar"
        Me.Text = "車両マスタ"
        CType(Me.grdCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents grdCar As DataGridView
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Carnum1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BikoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents max_load As DataGridViewTextBoxColumn
    Friend WithEvents limit_syaken As DataGridViewTextBoxColumn
End Class
