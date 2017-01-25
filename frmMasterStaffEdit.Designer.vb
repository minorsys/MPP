<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterStaffEdit
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
        Me.lblStaffBranch = New System.Windows.Forms.Label()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Id_staffLabel = New System.Windows.Forms.Label()
        Me.Staff_nameLabel = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Staff_kanaLabel = New System.Windows.Forms.Label()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_staffTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.PhoneNumDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.dtpMenkyoLimit = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStaffPhonenum = New System.Windows.Forms.ComboBox()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbStaffCarnum = New System.Windows.Forms.ComboBox()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PhoneNumTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLimitMenkyo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStaff_Carnum = New System.Windows.Forms.Label()
        Me.lblStaff_phonenum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStaffBranch
        '
        Me.lblStaffBranch.AutoSize = True
        Me.lblStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "branch_id", True))
        Me.lblStaffBranch.Location = New System.Drawing.Point(97, 15)
        Me.lblStaffBranch.Name = "lblStaffBranch"
        Me.lblStaffBranch.Size = New System.Drawing.Size(78, 12)
        Me.lblStaffBranch.TabIndex = 31
        Me.lblStaffBranch.Text = "lblStaffBranch"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "branch_id:"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "id_staff", True))
        Me.lblStaffID.Location = New System.Drawing.Point(90, 6)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(53, 12)
        Me.lblStaffID.TabIndex = 1
        Me.lblStaffID.Text = "lblStaffID"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(208, 324)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(55, 23)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(145, 324)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(57, 23)
        Me.btnOK.TabIndex = 24
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Id_staffLabel
        '
        Me.Id_staffLabel.AutoSize = True
        Me.Id_staffLabel.Location = New System.Drawing.Point(22, 6)
        Me.Id_staffLabel.Name = "Id_staffLabel"
        Me.Id_staffLabel.Size = New System.Drawing.Size(40, 12)
        Me.Id_staffLabel.TabIndex = 26
        Me.Id_staffLabel.Text = "社員ID"
        '
        'Staff_nameLabel
        '
        Me.Staff_nameLabel.AutoSize = True
        Me.Staff_nameLabel.Location = New System.Drawing.Point(22, 31)
        Me.Staff_nameLabel.Name = "Staff_nameLabel"
        Me.Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Me.Staff_nameLabel.TabIndex = 27
        Me.Staff_nameLabel.Text = "氏名"
        '
        'txtStaffName
        '
        Me.txtStaffName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_name", True))
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtStaffName.Location = New System.Drawing.Point(90, 28)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(121, 19)
        Me.txtStaffName.TabIndex = 2
        '
        'Staff_kanaLabel
        '
        Me.Staff_kanaLabel.AutoSize = True
        Me.Staff_kanaLabel.Location = New System.Drawing.Point(22, 56)
        Me.Staff_kanaLabel.Name = "Staff_kanaLabel"
        Me.Staff_kanaLabel.Size = New System.Drawing.Size(44, 12)
        Me.Staff_kanaLabel.TabIndex = 28
        Me.Staff_kanaLabel.Text = "氏名ｶﾅ"
        '
        'txtStaffKana
        '
        Me.txtStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_kana", True))
        Me.txtStaffKana.Enabled = False
        Me.txtStaffKana.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txtStaffKana.Location = New System.Drawing.Point(90, 53)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(121, 19)
        Me.txtStaffKana.TabIndex = 3
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(22, 81)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 29
        Me.Branch_idLabel.Text = "所属"
        '
        'cmbBranch
        '
        Me.cmbBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblstaffBindingSource, "branch_id", True))
        Me.cmbBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbBranch.DisplayMember = "branch_name"
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(90, 78)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(121, 20)
        Me.cmbBranch.TabIndex = 4
        Me.cmbBranch.ValueMember = "id_branch"
        '
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'PhoneNumDBDataSetBindingSource
        '
        Me.PhoneNumDBDataSetBindingSource.DataSource = Me.PhoneNumDBDataSet
        Me.PhoneNumDBDataSetBindingSource.Position = 0
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'dtpMenkyoLimit
        '
        Me.dtpMenkyoLimit.CustomFormat = " "
        Me.dtpMenkyoLimit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "limit_menkyo", True))
        Me.dtpMenkyoLimit.Location = New System.Drawing.Point(90, 174)
        Me.dtpMenkyoLimit.Name = "dtpMenkyoLimit"
        Me.dtpMenkyoLimit.Size = New System.Drawing.Size(121, 19)
        Me.dtpMenkyoLimit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "備考"
        '
        'txtBiko
        '
        Me.txtBiko.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "biko", True))
        Me.txtBiko.Location = New System.Drawing.Point(90, 200)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(173, 118)
        Me.txtBiko.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "免許証期限"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "車両番号"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "電話番号"
        '
        'cmbStaffPhonenum
        '
        Me.cmbStaffPhonenum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblstaffBindingSource, "staff_phonenum", True))
        Me.cmbStaffPhonenum.DataSource = Me.TblPhoneNumBindingSource
        Me.cmbStaffPhonenum.DisplayMember = "phonenum"
        Me.cmbStaffPhonenum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffPhonenum.FormattingEnabled = True
        Me.cmbStaffPhonenum.Location = New System.Drawing.Point(90, 125)
        Me.cmbStaffPhonenum.Name = "cmbStaffPhonenum"
        Me.cmbStaffPhonenum.Size = New System.Drawing.Size(121, 20)
        Me.cmbStaffPhonenum.TabIndex = 39
        Me.cmbStaffPhonenum.ValueMember = "phonenum"
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSetBindingSource
        '
        'cmbStaffCarnum
        '
        Me.cmbStaffCarnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblstaffBindingSource, "staff_carnum", True))
        Me.cmbStaffCarnum.DataSource = Me.TblcarBindingSource
        Me.cmbStaffCarnum.DisplayMember = "carnum1"
        Me.cmbStaffCarnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffCarnum.FormattingEnabled = True
        Me.cmbStaffCarnum.Location = New System.Drawing.Point(90, 150)
        Me.cmbStaffCarnum.Name = "cmbStaffCarnum"
        Me.cmbStaffCarnum.Size = New System.Drawing.Size(121, 20)
        Me.cmbStaffCarnum.TabIndex = 40
        Me.cmbStaffCarnum.ValueMember = "carnum1"
        '
        'TblcarBindingSource
        '
        Me.TblcarBindingSource.DataMember = "tbl_car"
        Me.TblcarBindingSource.DataSource = Me.PhoneNumDBDataSetBindingSource
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLimitMenkyo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblStaff_Carnum)
        Me.GroupBox1.Controls.Add(Me.lblStaff_phonenum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblStaffBranch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 76)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "temp data"
        '
        'lblLimitMenkyo
        '
        Me.lblLimitMenkyo.AutoSize = True
        Me.lblLimitMenkyo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "limit_menkyo", True))
        Me.lblLimitMenkyo.Location = New System.Drawing.Point(97, 51)
        Me.lblLimitMenkyo.Name = "lblLimitMenkyo"
        Me.lblLimitMenkyo.Size = New System.Drawing.Size(70, 12)
        Me.lblLimitMenkyo.TabIndex = 37
        Me.lblLimitMenkyo.Text = "limit_menkyo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 12)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "limit_menkyo:"
        '
        'lblStaff_Carnum
        '
        Me.lblStaff_Carnum.AutoSize = True
        Me.lblStaff_Carnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_carnum", True))
        Me.lblStaff_Carnum.Location = New System.Drawing.Point(97, 39)
        Me.lblStaff_Carnum.Name = "lblStaff_Carnum"
        Me.lblStaff_Carnum.Size = New System.Drawing.Size(83, 12)
        Me.lblStaff_Carnum.TabIndex = 35
        Me.lblStaff_Carnum.Text = "lblStaff_carnum"
        '
        'lblStaff_phonenum
        '
        Me.lblStaff_phonenum.AutoSize = True
        Me.lblStaff_phonenum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_phonenum", True))
        Me.lblStaff_phonenum.Location = New System.Drawing.Point(97, 27)
        Me.lblStaff_phonenum.Name = "lblStaff_phonenum"
        Me.lblStaff_phonenum.Size = New System.Drawing.Size(97, 12)
        Me.lblStaff_phonenum.TabIndex = 34
        Me.lblStaff_phonenum.Text = "lblStaff_phonenum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 12)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "staff_carnum:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 12)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "staff_phonenum:"
        '
        'frmMasterStaffEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(278, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbStaffCarnum)
        Me.Controls.Add(Me.cmbStaffPhonenum)
        Me.Controls.Add(Me.dtpMenkyoLimit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Id_staffLabel)
        Me.Controls.Add(Me.Staff_nameLabel)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Staff_kanaLabel)
        Me.Controls.Add(Me.txtStaffKana)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.Name = "frmMasterStaffEdit"
        Me.Text = "社員マスタ編集"
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStaffBranch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Id_staffLabel As Label
    Friend WithEvents Staff_nameLabel As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Staff_kanaLabel As Label
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents PhoneNumDBDataSetBindingSource As BindingSource
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents dtpMenkyoLimit As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStaffPhonenum As ComboBox
    Friend WithEvents cmbStaffCarnum As ComboBox
    Friend WithEvents TblPhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblStaff_Carnum As Label
    Friend WithEvents lblStaff_phonenum As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLimitMenkyo As Label
    Friend WithEvents Label8 As Label
End Class
