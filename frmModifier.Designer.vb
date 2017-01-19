<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifier
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
        Dim Branch_idLabel2 As System.Windows.Forms.Label
        Dim Carnum1Label As System.Windows.Forms.Label
        Dim MusenLabel As System.Windows.Forms.Label
        Dim TonLabel As System.Windows.Forms.Label
        Dim BikoLabel1 As System.Windows.Forms.Label
        Dim Id_staffLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim Branch_idLabel As System.Windows.Forms.Label
        Dim PhonenumLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.btnClearCar = New System.Windows.Forms.Button()
        Me.cmbCarBranch = New System.Windows.Forms.ComboBox()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.TblbranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCarnumChange = New System.Windows.Forms.ComboBox()
        Me.lblCarnum = New System.Windows.Forms.Label()
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.txtBikoCar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBikoStaff = New System.Windows.Forms.TextBox()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClearStaff = New System.Windows.Forms.Button()
        Me.cmbStaffBranch = New System.Windows.Forms.ComboBox()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearPhone = New System.Windows.Forms.Button()
        Me.cmbPhonenumChange = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPhonenum = New System.Windows.Forms.Label()
        Me.txtBikoPhone = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.cmbStaffNameChange = New System.Windows.Forms.ComboBox()
        Me.lblstaffID = New System.Windows.Forms.Label()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblCarBranch = New System.Windows.Forms.Label()
        Me.lblStaffBranch = New System.Windows.Forms.Label()
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_staffTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Tbl_PhoneNumTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Branch_idLabel2 = New System.Windows.Forms.Label()
        Carnum1Label = New System.Windows.Forms.Label()
        MusenLabel = New System.Windows.Forms.Label()
        TonLabel = New System.Windows.Forms.Label()
        BikoLabel1 = New System.Windows.Forms.Label()
        Id_staffLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        Branch_idLabel = New System.Windows.Forms.Label()
        PhonenumLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Branch_idLabel2
        '
        Branch_idLabel2.AutoSize = True
        Branch_idLabel2.Location = New System.Drawing.Point(11, 275)
        Branch_idLabel2.Name = "Branch_idLabel2"
        Branch_idLabel2.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel2.TabIndex = 18
        Branch_idLabel2.Text = "車庫"
        '
        'Carnum1Label
        '
        Carnum1Label.AutoSize = True
        Carnum1Label.Location = New System.Drawing.Point(13, 34)
        Carnum1Label.Name = "Carnum1Label"
        Carnum1Label.Size = New System.Drawing.Size(29, 12)
        Carnum1Label.TabIndex = 0
        Carnum1Label.Text = "車番"
        '
        'MusenLabel
        '
        MusenLabel.AutoSize = True
        MusenLabel.Location = New System.Drawing.Point(11, 88)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(29, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線"
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(11, 113)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(11, 138)
        BikoLabel1.Name = "BikoLabel1"
        BikoLabel1.Size = New System.Drawing.Size(29, 12)
        BikoLabel1.TabIndex = 12
        BikoLabel1.Text = "備考"
        '
        'Id_staffLabel
        '
        Id_staffLabel.AutoSize = True
        Id_staffLabel.Location = New System.Drawing.Point(12, 34)
        Id_staffLabel.Name = "Id_staffLabel"
        Id_staffLabel.Size = New System.Drawing.Size(40, 12)
        Id_staffLabel.TabIndex = 0
        Id_staffLabel.Text = "社員ID"
        '
        'Staff_nameLabel
        '
        Staff_nameLabel.AutoSize = True
        Staff_nameLabel.Location = New System.Drawing.Point(12, 59)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Staff_nameLabel.TabIndex = 2
        Staff_nameLabel.Text = "氏名"
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(12, 84)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(44, 12)
        Staff_kanaLabel.TabIndex = 4
        Staff_kanaLabel.Text = "氏名ｶﾅ"
        '
        'Branch_idLabel
        '
        Branch_idLabel.AutoSize = True
        Branch_idLabel.Location = New System.Drawing.Point(12, 109)
        Branch_idLabel.Name = "Branch_idLabel"
        Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel.TabIndex = 6
        Branch_idLabel.Text = "所属"
        '
        'PhonenumLabel
        '
        PhonenumLabel.AutoSize = True
        PhonenumLabel.Location = New System.Drawing.Point(18, 38)
        PhonenumLabel.Name = "PhonenumLabel"
        PhonenumLabel.Size = New System.Drawing.Size(29, 12)
        PhonenumLabel.TabIndex = 0
        PhonenumLabel.Text = "番号"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(17, 89)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(27, 12)
        MailLabel.TabIndex = 2
        MailLabel.Text = "ﾒｰﾙ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(17, 115)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 4
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(17, 65)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "機種"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 138)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(29, 12)
        Label3.TabIndex = 20
        Label3.Text = "備考"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "編集"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmbTon)
        Me.GroupBox3.Controls.Add(Me.btnClearCar)
        Me.GroupBox3.Controls.Add(Branch_idLabel2)
        Me.GroupBox3.Controls.Add(Me.cmbCarBranch)
        Me.GroupBox3.Controls.Add(Me.cmbCarnumChange)
        Me.GroupBox3.Controls.Add(Me.lblCarnum)
        Me.GroupBox3.Controls.Add(Carnum1Label)
        Me.GroupBox3.Controls.Add(Me.txtCarnum2)
        Me.GroupBox3.Controls.Add(Me.txtCarnum3)
        Me.GroupBox3.Controls.Add(Me.txtCarnum4)
        Me.GroupBox3.Controls.Add(MusenLabel)
        Me.GroupBox3.Controls.Add(Me.txtMusen)
        Me.GroupBox3.Controls.Add(TonLabel)
        Me.GroupBox3.Controls.Add(Me.txtTon)
        Me.GroupBox3.Controls.Add(BikoLabel1)
        Me.GroupBox3.Controls.Add(Me.txtBikoCar)
        Me.GroupBox3.Location = New System.Drawing.Point(519, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 322)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.DropDownWidth = 120
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(175, 110)
        Me.cmbTon.MaxDropDownItems = 30
        Me.cmbTon.MaxLength = 50
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(17, 20)
        Me.cmbTon.TabIndex = 17
        '
        'btnClearCar
        '
        Me.btnClearCar.Location = New System.Drawing.Point(161, 30)
        Me.btnClearCar.Name = "btnClearCar"
        Me.btnClearCar.Size = New System.Drawing.Size(49, 20)
        Me.btnClearCar.TabIndex = 11
        Me.btnClearCar.Text = "クリア"
        Me.btnClearCar.UseVisualStyleBackColor = True
        '
        'cmbCarBranch
        '
        Me.cmbCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblcarBindingSource, "branch_id", True))
        Me.cmbCarBranch.DataSource = Me.TblbranchBindingSource1
        Me.cmbCarBranch.DisplayMember = "branch_name"
        Me.cmbCarBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarBranch.FormattingEnabled = True
        Me.cmbCarBranch.Location = New System.Drawing.Point(71, 272)
        Me.cmbCarBranch.Name = "cmbCarBranch"
        Me.cmbCarBranch.Size = New System.Drawing.Size(100, 20)
        Me.cmbCarBranch.TabIndex = 19
        Me.cmbCarBranch.ValueMember = "id_branch"
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
        'TblbranchBindingSource1
        '
        Me.TblbranchBindingSource1.DataMember = "tbl_branch"
        Me.TblbranchBindingSource1.DataSource = Me.PhoneNumDBDataSet
        '
        'cmbCarnumChange
        '
        Me.cmbCarnumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnumChange.DropDownWidth = 120
        Me.cmbCarnumChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCarnumChange.FormattingEnabled = True
        Me.cmbCarnumChange.Location = New System.Drawing.Point(140, 30)
        Me.cmbCarnumChange.MaxDropDownItems = 50
        Me.cmbCarnumChange.MaxLength = 50
        Me.cmbCarnumChange.Name = "cmbCarnumChange"
        Me.cmbCarnumChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbCarnumChange.TabIndex = 10
        '
        'lblCarnum
        '
        Me.lblCarnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum1", True))
        Me.lblCarnum.Location = New System.Drawing.Point(71, 34)
        Me.lblCarnum.Name = "lblCarnum"
        Me.lblCarnum.Size = New System.Drawing.Size(100, 12)
        Me.lblCarnum.TabIndex = 18
        Me.lblCarnum.Text = "Carnum"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum2", True))
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(71, 59)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(53, 19)
        Me.txtCarnum2.TabIndex = 12
        '
        'txtCarnum3
        '
        Me.txtCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum3", True))
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(130, 59)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(39, 19)
        Me.txtCarnum3.TabIndex = 13
        '
        'txtCarnum4
        '
        Me.txtCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum4", True))
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(175, 59)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(35, 19)
        Me.txtCarnum4.TabIndex = 14
        '
        'txtMusen
        '
        Me.txtMusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "musen", True))
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(71, 85)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(100, 19)
        Me.txtMusen.TabIndex = 15
        '
        'txtTon
        '
        Me.txtTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "ton", True))
        Me.txtTon.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtTon.Location = New System.Drawing.Point(71, 110)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.ReadOnly = True
        Me.txtTon.Size = New System.Drawing.Size(100, 19)
        Me.txtTon.TabIndex = 16
        '
        'txtBikoCar
        '
        Me.txtBikoCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "biko", True))
        Me.txtBikoCar.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoCar.Location = New System.Drawing.Point(71, 135)
        Me.txtBikoCar.Multiline = True
        Me.txtBikoCar.Name = "txtBikoCar"
        Me.txtBikoCar.Size = New System.Drawing.Size(139, 131)
        Me.txtBikoCar.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtBikoStaff)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.btnClearStaff)
        Me.GroupBox2.Controls.Add(Me.cmbStaffBranch)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.lblStaffName)
        Me.GroupBox2.Controls.Add(Me.cmbStaffNameChange)
        Me.GroupBox2.Controls.Add(Id_staffLabel)
        Me.GroupBox2.Controls.Add(Me.lblstaffID)
        Me.GroupBox2.Controls.Add(Staff_nameLabel)
        Me.GroupBox2.Controls.Add(Staff_kanaLabel)
        Me.GroupBox2.Controls.Add(Me.txtStaffKana)
        Me.GroupBox2.Controls.Add(Branch_idLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 322)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
        '
        'txtBikoStaff
        '
        Me.txtBikoStaff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "biko", True))
        Me.txtBikoStaff.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoStaff.Location = New System.Drawing.Point(80, 135)
        Me.txtBikoStaff.Multiline = True
        Me.txtBikoStaff.Name = "txtBikoStaff"
        Me.txtBikoStaff.Size = New System.Drawing.Size(139, 169)
        Me.txtBikoStaff.TabIndex = 20
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'btnClearStaff
        '
        Me.btnClearStaff.Location = New System.Drawing.Point(170, 30)
        Me.btnClearStaff.Name = "btnClearStaff"
        Me.btnClearStaff.Size = New System.Drawing.Size(49, 20)
        Me.btnClearStaff.TabIndex = 7
        Me.btnClearStaff.Text = "クリア"
        Me.btnClearStaff.UseVisualStyleBackColor = True
        '
        'cmbStaffBranch
        '
        Me.cmbStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblstaffBindingSource, "branch_id", True))
        Me.cmbStaffBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbStaffBranch.DisplayMember = "branch_name"
        Me.cmbStaffBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffBranch.FormattingEnabled = True
        Me.cmbStaffBranch.Location = New System.Drawing.Point(80, 106)
        Me.cmbStaffBranch.Name = "cmbStaffBranch"
        Me.cmbStaffBranch.Size = New System.Drawing.Size(99, 20)
        Me.cmbStaffBranch.TabIndex = 9
        Me.cmbStaffBranch.ValueMember = "id_branch"
        '
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnClearPhone)
        Me.GroupBox1.Controls.Add(Me.cmbPhonenumChange)
        Me.GroupBox1.Controls.Add(PhonenumLabel)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.lblPhonenum)
        Me.GroupBox1.Controls.Add(BikoLabel)
        Me.GroupBox1.Controls.Add(Me.txtBikoPhone)
        Me.GroupBox1.Controls.Add(ModelLabel)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Location = New System.Drawing.Point(254, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 274)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話情報"
        '
        'btnClearPhone
        '
        Me.btnClearPhone.Location = New System.Drawing.Point(171, 30)
        Me.btnClearPhone.Name = "btnClearPhone"
        Me.btnClearPhone.Size = New System.Drawing.Size(49, 20)
        Me.btnClearPhone.TabIndex = 2
        Me.btnClearPhone.Text = "クリア"
        Me.btnClearPhone.UseVisualStyleBackColor = True
        '
        'cmbPhonenumChange
        '
        Me.cmbPhonenumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhonenumChange.DropDownWidth = 150
        Me.cmbPhonenumChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbPhonenumChange.FormattingEnabled = True
        Me.cmbPhonenumChange.Location = New System.Drawing.Point(148, 30)
        Me.cmbPhonenumChange.MaxDropDownItems = 50
        Me.cmbPhonenumChange.MaxLength = 50
        Me.cmbPhonenumChange.Name = "cmbPhonenumChange"
        Me.cmbPhonenumChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbPhonenumChange.TabIndex = 1
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "mail", True))
        Me.txtMail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMail.Location = New System.Drawing.Point(55, 86)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(161, 19)
        Me.txtMail.TabIndex = 4
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'lblPhonenum
        '
        Me.lblPhonenum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "phonenum", True))
        Me.lblPhonenum.Location = New System.Drawing.Point(53, 36)
        Me.lblPhonenum.Name = "lblPhonenum"
        Me.lblPhonenum.Size = New System.Drawing.Size(100, 12)
        Me.lblPhonenum.TabIndex = 15
        Me.lblPhonenum.Text = "Phonenum"
        '
        'txtBikoPhone
        '
        Me.txtBikoPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "biko", True))
        Me.txtBikoPhone.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoPhone.Location = New System.Drawing.Point(55, 112)
        Me.txtBikoPhone.Multiline = True
        Me.txtBikoPhone.Name = "txtBikoPhone"
        Me.txtBikoPhone.Size = New System.Drawing.Size(161, 146)
        Me.txtBikoPhone.TabIndex = 5
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "model", True))
        Me.txtModel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtModel.Location = New System.Drawing.Point(55, 62)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(110, 19)
        Me.txtModel.TabIndex = 3
        '
        'lblStaffName
        '
        Me.lblStaffName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_name", True))
        Me.lblStaffName.Location = New System.Drawing.Point(80, 59)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(100, 16)
        Me.lblStaffName.TabIndex = 19
        Me.lblStaffName.Text = "lblStaffName"
        '
        'cmbStaffNameChange
        '
        Me.cmbStaffNameChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffNameChange.DropDownWidth = 180
        Me.cmbStaffNameChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbStaffNameChange.FormattingEnabled = True
        Me.cmbStaffNameChange.Location = New System.Drawing.Point(147, 30)
        Me.cmbStaffNameChange.MaxDropDownItems = 50
        Me.cmbStaffNameChange.MaxLength = 50
        Me.cmbStaffNameChange.Name = "cmbStaffNameChange"
        Me.cmbStaffNameChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbStaffNameChange.TabIndex = 6
        '
        'lblstaffID
        '
        Me.lblstaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "id_staff", True))
        Me.lblstaffID.Location = New System.Drawing.Point(80, 34)
        Me.lblstaffID.Name = "lblstaffID"
        Me.lblstaffID.Size = New System.Drawing.Size(100, 12)
        Me.lblstaffID.TabIndex = 17
        Me.lblstaffID.Text = "StaffID"
        '
        'txtStaffKana
        '
        Me.txtStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_kana", True))
        Me.txtStaffKana.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txtStaffKana.Location = New System.Drawing.Point(80, 81)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(99, 19)
        Me.txtStaffKana.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(676, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "キャンセル(&esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(595, 370)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblCarBranch
        '
        Me.lblCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "branch_id", True))
        Me.lblCarBranch.Location = New System.Drawing.Point(123, 30)
        Me.lblCarBranch.Name = "lblCarBranch"
        Me.lblCarBranch.Size = New System.Drawing.Size(83, 12)
        Me.lblCarBranch.TabIndex = 29
        Me.lblCarBranch.Text = "lblCarBranch"
        '
        'lblStaffBranch
        '
        Me.lblStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "branch_id", True))
        Me.lblStaffBranch.Location = New System.Drawing.Point(123, 18)
        Me.lblStaffBranch.Name = "lblStaffBranch"
        Me.lblStaffBranch.Size = New System.Drawing.Size(78, 12)
        Me.lblStaffBranch.TabIndex = 31
        Me.lblStaffBranch.Text = "lblStaffBranch"
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblStaffBranch)
        Me.GroupBox4.Controls.Add(Me.lblCarBranch)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 408)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 50)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "temp data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 12)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "tblCar-branchID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 12)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "tblStaff-branchID"
        '
        'frmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 402)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmModifier"
        Me.Text = "選択行の編集"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents btnClearCar As Button
    Friend WithEvents cmbCarBranch As ComboBox
    Friend WithEvents cmbCarnumChange As ComboBox
    Friend WithEvents lblCarnum As Label
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents txtTon As TextBox
    Friend WithEvents txtBikoCar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClearStaff As Button
    Friend WithEvents cmbStaffBranch As ComboBox
    Friend WithEvents lblStaffName As Label
    Friend WithEvents cmbStaffNameChange As ComboBox
    Friend WithEvents lblstaffID As Label
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearPhone As Button
    Friend WithEvents cmbPhonenumChange As ComboBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblPhonenum As Label
    Friend WithEvents txtBikoPhone As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblCarBranch As Label
    Friend WithEvents lblStaffBranch As Label
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents TblbranchBindingSource1 As BindingSource
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents TblPhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
    Friend WithEvents txtBikoStaff As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
End Class
