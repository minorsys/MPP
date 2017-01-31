<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenkyoUpload
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
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpMenkyoLimit = New System.Windows.Forms.DateTimePicker()
        Me.cmbStaff = New System.Windows.Forms.ComboBox()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.Tbl_staffTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(169, 93)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 13
        Me.btnUpload.Text = "アップロード"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "氏名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "新しい免許証の期限"
        '
        'dtpMenkyoLimit
        '
        Me.dtpMenkyoLimit.CustomFormat = "yyyyMMdd"
        Me.dtpMenkyoLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMenkyoLimit.Location = New System.Drawing.Point(133, 66)
        Me.dtpMenkyoLimit.Name = "dtpMenkyoLimit"
        Me.dtpMenkyoLimit.Size = New System.Drawing.Size(111, 19)
        Me.dtpMenkyoLimit.TabIndex = 10
        '
        'cmbStaff
        '
        Me.cmbStaff.DataSource = Me.TblstaffBindingSource
        Me.cmbStaff.DisplayMember = "staff_name"
        Me.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaff.FormattingEnabled = True
        Me.cmbStaff.Location = New System.Drawing.Point(133, 40)
        Me.cmbStaff.Name = "cmbStaff"
        Me.cmbStaff.Size = New System.Drawing.Size(111, 20)
        Me.cmbStaff.TabIndex = 9
        Me.cmbStaff.ValueMember = "id_staff"
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFilePath
        '
        Me.txtFilePath.Enabled = False
        Me.txtFilePath.Location = New System.Drawing.Point(12, 12)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(151, 19)
        Me.txtFilePath.TabIndex = 8
        '
        'btnFileSelect
        '
        Me.btnFileSelect.Location = New System.Drawing.Point(169, 9)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnFileSelect.TabIndex = 7
        Me.btnFileSelect.Text = "ファイル選択"
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'frmMenkyoUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(264, 136)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpMenkyoLimit)
        Me.Controls.Add(Me.cmbStaff)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnFileSelect)
        Me.Name = "frmMenkyoUpload"
        Me.Text = "免許証アップロード"
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpMenkyoLimit As DateTimePicker
    Friend WithEvents cmbStaff As ComboBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnFileSelect As Button
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
End Class
