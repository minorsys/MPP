<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSyakenUpload
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.cmbCarnum = New System.Windows.Forms.ComboBox()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.dtpSyakenLimit = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFileSelect
        '
        Me.btnFileSelect.Location = New System.Drawing.Point(170, 12)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnFileSelect.TabIndex = 0
        Me.btnFileSelect.Text = "ファイル選択"
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Enabled = False
        Me.txtFilePath.Location = New System.Drawing.Point(13, 15)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(151, 19)
        Me.txtFilePath.TabIndex = 1
        '
        'cmbCarnum
        '
        Me.cmbCarnum.DataSource = Me.TblcarBindingSource
        Me.cmbCarnum.DisplayMember = "carnum1"
        Me.cmbCarnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnum.FormattingEnabled = True
        Me.cmbCarnum.Location = New System.Drawing.Point(151, 45)
        Me.cmbCarnum.Name = "cmbCarnum"
        Me.cmbCarnum.Size = New System.Drawing.Size(94, 20)
        Me.cmbCarnum.TabIndex = 2
        Me.cmbCarnum.ValueMember = "carnum1"
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
        'dtpSyakenLimit
        '
        Me.dtpSyakenLimit.CustomFormat = "yyyyMMdd"
        Me.dtpSyakenLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSyakenLimit.Location = New System.Drawing.Point(151, 71)
        Me.dtpSyakenLimit.Name = "dtpSyakenLimit"
        Me.dtpSyakenLimit.Size = New System.Drawing.Size(94, 19)
        Me.dtpSyakenLimit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "新しい車検証の期限"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "車両番号"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(170, 96)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 6
        Me.btnUpload.Text = "アップロード"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'frmSyakenUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(257, 131)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpSyakenLimit)
        Me.Controls.Add(Me.cmbCarnum)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnFileSelect)
        Me.Name = "frmSyakenUpload"
        Me.Text = "車検証アップロード"
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFileSelect As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents cmbCarnum As ComboBox
    Friend WithEvents dtpSyakenLimit As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
End Class
