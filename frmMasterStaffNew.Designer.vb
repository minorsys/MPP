<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterStaffNew
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
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Id_staffLabel = New System.Windows.Forms.Label()
        Me.Staff_nameLabel = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Staff_kanaLabel = New System.Windows.Forms.Label()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_staffTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpMenkyoLimit = New System.Windows.Forms.DateTimePicker()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PhoneNumTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(92, 10)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(11, 12)
        Me.lblStaffID.TabIndex = 1
        Me.lblStaffID.Text = "-"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(210, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "閉じる"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(147, 258)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(57, 23)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "登録"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Id_staffLabel
        '
        Me.Id_staffLabel.AutoSize = True
        Me.Id_staffLabel.Location = New System.Drawing.Point(12, 10)
        Me.Id_staffLabel.Name = "Id_staffLabel"
        Me.Id_staffLabel.Size = New System.Drawing.Size(40, 12)
        Me.Id_staffLabel.TabIndex = 8
        Me.Id_staffLabel.Text = "社員ID"
        '
        'Staff_nameLabel
        '
        Me.Staff_nameLabel.AutoSize = True
        Me.Staff_nameLabel.Location = New System.Drawing.Point(12, 35)
        Me.Staff_nameLabel.Name = "Staff_nameLabel"
        Me.Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Me.Staff_nameLabel.TabIndex = 9
        Me.Staff_nameLabel.Text = "氏名"
        '
        'txtStaffName
        '
        Me.txtStaffName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtStaffName.Location = New System.Drawing.Point(93, 31)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(121, 19)
        Me.txtStaffName.TabIndex = 2
        '
        'Staff_kanaLabel
        '
        Me.Staff_kanaLabel.AutoSize = True
        Me.Staff_kanaLabel.Location = New System.Drawing.Point(12, 60)
        Me.Staff_kanaLabel.Name = "Staff_kanaLabel"
        Me.Staff_kanaLabel.Size = New System.Drawing.Size(44, 12)
        Me.Staff_kanaLabel.TabIndex = 12
        Me.Staff_kanaLabel.Text = "氏名ｶﾅ"
        '
        'txtStaffKana
        '
        Me.txtStaffKana.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txtStaffKana.Location = New System.Drawing.Point(93, 56)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(121, 19)
        Me.txtStaffKana.TabIndex = 3
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(12, 85)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 16
        Me.Branch_idLabel.Text = "所属"
        '
        'cmbBranch
        '
        Me.cmbBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblstaffBindingSource, "branch_id", True))
        Me.cmbBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbBranch.DisplayMember = "branch_name"
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(93, 81)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(121, 20)
        Me.cmbBranch.TabIndex = 4
        Me.cmbBranch.ValueMember = "id_branch"
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
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "免許証期限"
        '
        'txtBiko
        '
        Me.txtBiko.Location = New System.Drawing.Point(92, 134)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(173, 118)
        Me.txtBiko.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "備考"
        '
        'dtpMenkyoLimit
        '
        Me.dtpMenkyoLimit.CustomFormat = " "
        Me.dtpMenkyoLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMenkyoLimit.Location = New System.Drawing.Point(93, 109)
        Me.dtpMenkyoLimit.Name = "dtpMenkyoLimit"
        Me.dtpMenkyoLimit.Size = New System.Drawing.Size(121, 19)
        Me.dtpMenkyoLimit.TabIndex = 7
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'TblcarBindingSource
        '
        Me.TblcarBindingSource.DataMember = "tbl_car"
        Me.TblcarBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'frmMasterStaffNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(277, 291)
        Me.Controls.Add(Me.dtpMenkyoLimit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Id_staffLabel)
        Me.Controls.Add(Me.Staff_nameLabel)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Staff_kanaLabel)
        Me.Controls.Add(Me.txtStaffKana)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.Name = "frmMasterStaffNew"
        Me.Text = "社員マスタ新規"
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStaffID As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Id_staffLabel As Label
    Friend WithEvents Staff_nameLabel As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Staff_kanaLabel As Label
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpMenkyoLimit As DateTimePicker
    Friend WithEvents TblPhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
End Class
