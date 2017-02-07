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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblCar_width = New System.Windows.Forms.Label()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.lblCarLength = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMasLoad = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSyakenUpdate = New System.Windows.Forms.Button()
        Me.lblSyakenLimit = New System.Windows.Forms.Label()
        Me.lblTon = New System.Windows.Forms.Label()
        Me.lblmusen = New System.Windows.Forms.Label()
        Me.lblCarnum4 = New System.Windows.Forms.Label()
        Me.lblCarnum3 = New System.Windows.Forms.Label()
        Me.lblCarnum2 = New System.Windows.Forms.Label()
        Me.btnClearCar = New System.Windows.Forms.Button()
        Me.cmbCarnumChange = New System.Windows.Forms.ComboBox()
        Me.cmbCarBranch = New System.Windows.Forms.ComboBox()
        Me.TblbranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCarnum = New System.Windows.Forms.Label()
        Me.txtBikoCar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMenkyoUpdate = New System.Windows.Forms.Button()
        Me.lblMenkyoLimit = New System.Windows.Forms.Label()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStaffKana = New System.Windows.Forms.Label()
        Me.txtBikoStaff = New System.Windows.Forms.TextBox()
        Me.btnClearStaff = New System.Windows.Forms.Button()
        Me.cmbStaffBranch = New System.Windows.Forms.ComboBox()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblModel = New System.Windows.Forms.Label()
        Me.btnClearPhone = New System.Windows.Forms.Button()
        Me.cmbPhonenumChange = New System.Windows.Forms.ComboBox()
        Me.lblPhonenum = New System.Windows.Forms.Label()
        Me.txtBikoPhone = New System.Windows.Forms.TextBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.cmbStaffNameChange = New System.Windows.Forms.ComboBox()
        Me.lblstaffID = New System.Windows.Forms.Label()
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
        Me.lblCarHeight = New System.Windows.Forms.Label()
        Me.lblBedLength = New System.Windows.Forms.Label()
        Me.lblBedWidth = New System.Windows.Forms.Label()
        Me.lblBedHeight = New System.Windows.Forms.Label()
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
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Branch_idLabel2.Location = New System.Drawing.Point(12, 124)
        Branch_idLabel2.Name = "Branch_idLabel2"
        Branch_idLabel2.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel2.TabIndex = 18
        Branch_idLabel2.Text = "車庫"
        '
        'Carnum1Label
        '
        Carnum1Label.AutoSize = True
        Carnum1Label.Location = New System.Drawing.Point(12, 34)
        Carnum1Label.Name = "Carnum1Label"
        Carnum1Label.Size = New System.Drawing.Size(29, 12)
        Carnum1Label.TabIndex = 0
        Carnum1Label.Text = "車番"
        '
        'MusenLabel
        '
        MusenLabel.AutoSize = True
        MusenLabel.Location = New System.Drawing.Point(12, 78)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(53, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線番号"
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(12, 100)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(12, 179)
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
        Branch_idLabel.Location = New System.Drawing.Point(12, 112)
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
        MailLabel.Location = New System.Drawing.Point(18, 89)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(27, 12)
        MailLabel.TabIndex = 2
        MailLabel.Text = "ﾒｰﾙ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(18, 115)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 4
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(18, 65)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "機種"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 169)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(29, 12)
        Label3.TabIndex = 20
        Label3.Text = "備考"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 148)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(65, 12)
        Label2.TabIndex = 22
        Label2.Text = "車検証期限"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 140)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(65, 12)
        Label4.TabIndex = 24
        Label4.Text = "免許証期限"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.btnSyakenUpdate)
        Me.GroupBox3.Controls.Add(Me.lblSyakenLimit)
        Me.GroupBox3.Controls.Add(Me.lblTon)
        Me.GroupBox3.Controls.Add(Me.lblmusen)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.lblCarnum4)
        Me.GroupBox3.Controls.Add(Me.lblCarnum3)
        Me.GroupBox3.Controls.Add(Me.lblCarnum2)
        Me.GroupBox3.Controls.Add(Me.btnClearCar)
        Me.GroupBox3.Controls.Add(Branch_idLabel2)
        Me.GroupBox3.Controls.Add(Me.cmbCarnumChange)
        Me.GroupBox3.Controls.Add(Me.cmbCarBranch)
        Me.GroupBox3.Controls.Add(Me.lblCarnum)
        Me.GroupBox3.Controls.Add(Carnum1Label)
        Me.GroupBox3.Controls.Add(MusenLabel)
        Me.GroupBox3.Controls.Add(TonLabel)
        Me.GroupBox3.Controls.Add(BikoLabel1)
        Me.GroupBox3.Controls.Add(Me.txtBikoCar)
        Me.GroupBox3.Location = New System.Drawing.Point(542, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 352)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblBedHeight)
        Me.GroupBox5.Controls.Add(Me.lblBedWidth)
        Me.GroupBox5.Controls.Add(Me.lblBedLength)
        Me.GroupBox5.Controls.Add(Me.lblCarHeight)
        Me.GroupBox5.Controls.Add(Me.lblCar_width)
        Me.GroupBox5.Controls.Add(Me.lblCarLength)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblMasLoad)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(264, 30)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 200)
        Me.GroupBox5.TabIndex = 100
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "車両寸法"
        '
        'lblCar_width
        '
        Me.lblCar_width.AutoSize = True
        Me.lblCar_width.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_width", True))
        Me.lblCar_width.Location = New System.Drawing.Point(73, 47)
        Me.lblCar_width.Name = "lblCar_width"
        Me.lblCar_width.Size = New System.Drawing.Size(52, 12)
        Me.lblCar_width.TabIndex = 117
        Me.lblCar_width.Text = "car_width"
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
        'lblCarLength
        '
        Me.lblCarLength.AutoSize = True
        Me.lblCarLength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_length", True))
        Me.lblCarLength.Location = New System.Drawing.Point(73, 22)
        Me.lblCarLength.Name = "lblCarLength"
        Me.lblCarLength.Size = New System.Drawing.Size(56, 12)
        Me.lblCarLength.TabIndex = 116
        Me.lblCarLength.Text = "car_length"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(129, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 12)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "mm"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(129, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 12)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "mm"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(129, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 12)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "mm"
        '
        'lblMasLoad
        '
        Me.lblMasLoad.AutoSize = True
        Me.lblMasLoad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "max_load", True))
        Me.lblMasLoad.Location = New System.Drawing.Point(72, 97)
        Me.lblMasLoad.Name = "lblMasLoad"
        Me.lblMasLoad.Size = New System.Drawing.Size(50, 12)
        Me.lblMasLoad.TabIndex = 43
        Me.lblMasLoad.Text = "maxLoad"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(129, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 12)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "cm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(129, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 12)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "cm"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(129, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 12)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "cm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "荷台高"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "荷台幅"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "荷台長"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 12)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "高さ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "幅"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 12)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "長さ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 12)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "最大積載量"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(130, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 12)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "kg"
        '
        'btnSyakenUpdate
        '
        Me.btnSyakenUpdate.Location = New System.Drawing.Point(185, 141)
        Me.btnSyakenUpdate.Name = "btnSyakenUpdate"
        Me.btnSyakenUpdate.Size = New System.Drawing.Size(59, 23)
        Me.btnSyakenUpdate.TabIndex = 46
        Me.btnSyakenUpdate.Text = "更新"
        Me.btnSyakenUpdate.UseVisualStyleBackColor = True
        '
        'lblSyakenLimit
        '
        Me.lblSyakenLimit.AutoSize = True
        Me.lblSyakenLimit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "limit_syaken", True))
        Me.lblSyakenLimit.Location = New System.Drawing.Point(87, 148)
        Me.lblSyakenLimit.Name = "lblSyakenLimit"
        Me.lblSyakenLimit.Size = New System.Drawing.Size(67, 12)
        Me.lblSyakenLimit.TabIndex = 38
        Me.lblSyakenLimit.Text = "SyakenLimit"
        '
        'lblTon
        '
        Me.lblTon.AutoSize = True
        Me.lblTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "ton", True))
        Me.lblTon.Location = New System.Drawing.Point(87, 100)
        Me.lblTon.Name = "lblTon"
        Me.lblTon.Size = New System.Drawing.Size(24, 12)
        Me.lblTon.TabIndex = 42
        Me.lblTon.Text = "Ton"
        '
        'lblmusen
        '
        Me.lblmusen.AutoSize = True
        Me.lblmusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "musen", True))
        Me.lblmusen.Location = New System.Drawing.Point(87, 78)
        Me.lblmusen.Name = "lblmusen"
        Me.lblmusen.Size = New System.Drawing.Size(38, 12)
        Me.lblmusen.TabIndex = 41
        Me.lblmusen.Text = "musen"
        '
        'lblCarnum4
        '
        Me.lblCarnum4.AutoSize = True
        Me.lblCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum4", True))
        Me.lblCarnum4.Location = New System.Drawing.Point(153, 57)
        Me.lblCarnum4.Name = "lblCarnum4"
        Me.lblCarnum4.Size = New System.Drawing.Size(43, 12)
        Me.lblCarnum4.TabIndex = 40
        Me.lblCarnum4.Text = "ひらがな"
        '
        'lblCarnum3
        '
        Me.lblCarnum3.AutoSize = True
        Me.lblCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum3", True))
        Me.lblCarnum3.Location = New System.Drawing.Point(131, 57)
        Me.lblCarnum3.Name = "lblCarnum3"
        Me.lblCarnum3.Size = New System.Drawing.Size(23, 12)
        Me.lblCarnum3.TabIndex = 39
        Me.lblCarnum3.Text = "000"
        '
        'lblCarnum2
        '
        Me.lblCarnum2.AutoSize = True
        Me.lblCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum2", True))
        Me.lblCarnum2.Location = New System.Drawing.Point(87, 57)
        Me.lblCarnum2.Name = "lblCarnum2"
        Me.lblCarnum2.Size = New System.Drawing.Size(29, 12)
        Me.lblCarnum2.TabIndex = 38
        Me.lblCarnum2.Text = "地名"
        '
        'btnClearCar
        '
        Me.btnClearCar.Location = New System.Drawing.Point(176, 30)
        Me.btnClearCar.Name = "btnClearCar"
        Me.btnClearCar.Size = New System.Drawing.Size(49, 20)
        Me.btnClearCar.TabIndex = 11
        Me.btnClearCar.Text = "クリア"
        Me.btnClearCar.UseVisualStyleBackColor = True
        '
        'cmbCarnumChange
        '
        Me.cmbCarnumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnumChange.DropDownWidth = 120
        Me.cmbCarnumChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCarnumChange.FormattingEnabled = True
        Me.cmbCarnumChange.Location = New System.Drawing.Point(155, 30)
        Me.cmbCarnumChange.MaxDropDownItems = 50
        Me.cmbCarnumChange.MaxLength = 50
        Me.cmbCarnumChange.Name = "cmbCarnumChange"
        Me.cmbCarnumChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbCarnumChange.TabIndex = 10
        '
        'cmbCarBranch
        '
        Me.cmbCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblcarBindingSource, "branch_id", True))
        Me.cmbCarBranch.DataSource = Me.TblbranchBindingSource1
        Me.cmbCarBranch.DisplayMember = "branch_name"
        Me.cmbCarBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarBranch.Enabled = False
        Me.cmbCarBranch.FormattingEnabled = True
        Me.cmbCarBranch.Location = New System.Drawing.Point(87, 120)
        Me.cmbCarBranch.Name = "cmbCarBranch"
        Me.cmbCarBranch.Size = New System.Drawing.Size(100, 20)
        Me.cmbCarBranch.TabIndex = 19
        Me.cmbCarBranch.ValueMember = "id_branch"
        '
        'TblbranchBindingSource1
        '
        Me.TblbranchBindingSource1.DataMember = "tbl_branch"
        Me.TblbranchBindingSource1.DataSource = Me.PhoneNumDBDataSet
        '
        'lblCarnum
        '
        Me.lblCarnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum1", True))
        Me.lblCarnum.Location = New System.Drawing.Point(87, 34)
        Me.lblCarnum.Name = "lblCarnum"
        Me.lblCarnum.Size = New System.Drawing.Size(100, 12)
        Me.lblCarnum.TabIndex = 18
        Me.lblCarnum.Text = "Carnum"
        '
        'txtBikoCar
        '
        Me.txtBikoCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "biko", True))
        Me.txtBikoCar.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoCar.Location = New System.Drawing.Point(89, 178)
        Me.txtBikoCar.Multiline = True
        Me.txtBikoCar.Name = "txtBikoCar"
        Me.txtBikoCar.Size = New System.Drawing.Size(155, 143)
        Me.txtBikoCar.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.btnMenkyoUpdate)
        Me.GroupBox2.Controls.Add(Me.lblMenkyoLimit)
        Me.GroupBox2.Controls.Add(Me.lblStaffKana)
        Me.GroupBox2.Controls.Add(Label4)
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
        Me.GroupBox2.Controls.Add(Branch_idLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 352)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
        '
        'btnMenkyoUpdate
        '
        Me.btnMenkyoUpdate.Location = New System.Drawing.Point(193, 135)
        Me.btnMenkyoUpdate.Name = "btnMenkyoUpdate"
        Me.btnMenkyoUpdate.Size = New System.Drawing.Size(59, 23)
        Me.btnMenkyoUpdate.TabIndex = 45
        Me.btnMenkyoUpdate.Text = "更新"
        Me.btnMenkyoUpdate.UseVisualStyleBackColor = True
        '
        'lblMenkyoLimit
        '
        Me.lblMenkyoLimit.AutoSize = True
        Me.lblMenkyoLimit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "limit_menkyo", True))
        Me.lblMenkyoLimit.Location = New System.Drawing.Point(103, 140)
        Me.lblMenkyoLimit.Name = "lblMenkyoLimit"
        Me.lblMenkyoLimit.Size = New System.Drawing.Size(69, 12)
        Me.lblMenkyoLimit.TabIndex = 44
        Me.lblMenkyoLimit.Text = "MenkyoLimit"
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'lblStaffKana
        '
        Me.lblStaffKana.AutoSize = True
        Me.lblStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_kana", True))
        Me.lblStaffKana.Location = New System.Drawing.Point(101, 84)
        Me.lblStaffKana.Name = "lblStaffKana"
        Me.lblStaffKana.Size = New System.Drawing.Size(67, 12)
        Me.lblStaffKana.TabIndex = 26
        Me.lblStaffKana.Text = "lblStaffKana"
        '
        'txtBikoStaff
        '
        Me.txtBikoStaff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "biko", True))
        Me.txtBikoStaff.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoStaff.Location = New System.Drawing.Point(103, 166)
        Me.txtBikoStaff.Multiline = True
        Me.txtBikoStaff.Name = "txtBikoStaff"
        Me.txtBikoStaff.Size = New System.Drawing.Size(155, 143)
        Me.txtBikoStaff.TabIndex = 20
        '
        'btnClearStaff
        '
        Me.btnClearStaff.Location = New System.Drawing.Point(193, 30)
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
        Me.cmbStaffBranch.Enabled = False
        Me.cmbStaffBranch.FormattingEnabled = True
        Me.cmbStaffBranch.Location = New System.Drawing.Point(103, 106)
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Controls.Add(Me.lblModel)
        Me.GroupBox1.Controls.Add(Me.btnClearPhone)
        Me.GroupBox1.Controls.Add(Me.cmbPhonenumChange)
        Me.GroupBox1.Controls.Add(PhonenumLabel)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(Me.lblPhonenum)
        Me.GroupBox1.Controls.Add(BikoLabel)
        Me.GroupBox1.Controls.Add(Me.txtBikoPhone)
        Me.GroupBox1.Controls.Add(ModelLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 284)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話情報"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "mail", True))
        Me.lblMail.Location = New System.Drawing.Point(53, 90)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(38, 12)
        Me.lblMail.TabIndex = 27
        Me.lblMail.Text = "lblMail"
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "model", True))
        Me.lblModel.Location = New System.Drawing.Point(53, 65)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(47, 12)
        Me.lblModel.TabIndex = 27
        Me.lblModel.Text = "lblModel"
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
        Me.txtBikoPhone.Location = New System.Drawing.Point(55, 113)
        Me.txtBikoPhone.Multiline = True
        Me.txtBikoPhone.Name = "txtBikoPhone"
        Me.txtBikoPhone.Size = New System.Drawing.Size(155, 143)
        Me.txtBikoPhone.TabIndex = 5
        '
        'lblStaffName
        '
        Me.lblStaffName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "staff_name", True))
        Me.lblStaffName.Location = New System.Drawing.Point(103, 59)
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
        Me.cmbStaffNameChange.Location = New System.Drawing.Point(170, 30)
        Me.cmbStaffNameChange.MaxDropDownItems = 50
        Me.cmbStaffNameChange.MaxLength = 50
        Me.cmbStaffNameChange.Name = "cmbStaffNameChange"
        Me.cmbStaffNameChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbStaffNameChange.TabIndex = 6
        '
        'lblstaffID
        '
        Me.lblstaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstaffBindingSource, "id_staff", True))
        Me.lblstaffID.Location = New System.Drawing.Point(103, 34)
        Me.lblstaffID.Name = "lblstaffID"
        Me.lblstaffID.Size = New System.Drawing.Size(100, 12)
        Me.lblstaffID.TabIndex = 17
        Me.lblstaffID.Text = "StaffID"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(907, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "キャンセル(&esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(826, 370)
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
        'lblCarHeight
        '
        Me.lblCarHeight.AutoSize = True
        Me.lblCarHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_height", True))
        Me.lblCarHeight.Location = New System.Drawing.Point(73, 72)
        Me.lblCarHeight.Name = "lblCarHeight"
        Me.lblCarHeight.Size = New System.Drawing.Size(56, 12)
        Me.lblCarHeight.TabIndex = 118
        Me.lblCarHeight.Text = "car_height"
        '
        'lblBedLength
        '
        Me.lblBedLength.AutoSize = True
        Me.lblBedLength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_length", True))
        Me.lblBedLength.Location = New System.Drawing.Point(73, 123)
        Me.lblBedLength.Name = "lblBedLength"
        Me.lblBedLength.Size = New System.Drawing.Size(58, 12)
        Me.lblBedLength.TabIndex = 119
        Me.lblBedLength.Text = "bed_length"
        '
        'lblBedWidth
        '
        Me.lblBedWidth.AutoSize = True
        Me.lblBedWidth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_width", True))
        Me.lblBedWidth.Location = New System.Drawing.Point(73, 148)
        Me.lblBedWidth.Name = "lblBedWidth"
        Me.lblBedWidth.Size = New System.Drawing.Size(54, 12)
        Me.lblBedWidth.TabIndex = 120
        Me.lblBedWidth.Text = "bed_width"
        '
        'lblBedHeight
        '
        Me.lblBedHeight.AutoSize = True
        Me.lblBedHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_height", True))
        Me.lblBedHeight.Location = New System.Drawing.Point(73, 173)
        Me.lblBedHeight.Name = "lblBedHeight"
        Me.lblBedHeight.Size = New System.Drawing.Size(58, 12)
        Me.lblBedHeight.TabIndex = 121
        Me.lblBedHeight.Text = "bed_height"
        '
        'frmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 400)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmModifier"
        Me.Text = "選択行の詳細/編集"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClearCar As Button
    Friend WithEvents cmbCarBranch As ComboBox
    Friend WithEvents cmbCarnumChange As ComboBox
    Friend WithEvents lblCarnum As Label
    Friend WithEvents txtBikoCar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClearStaff As Button
    Friend WithEvents cmbStaffBranch As ComboBox
    Friend WithEvents lblStaffName As Label
    Friend WithEvents cmbStaffNameChange As ComboBox
    Friend WithEvents lblstaffID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearPhone As Button
    Friend WithEvents cmbPhonenumChange As ComboBox
    Friend WithEvents lblPhonenum As Label
    Friend WithEvents txtBikoPhone As TextBox
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
    Friend WithEvents lblStaffKana As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblCarnum2 As Label
    Friend WithEvents lblCarnum3 As Label
    Friend WithEvents lblCarnum4 As Label
    Friend WithEvents lblmusen As Label
    Friend WithEvents lblTon As Label
    Friend WithEvents lblMasLoad As Label
    Friend WithEvents lblSyakenLimit As Label
    Friend WithEvents lblMenkyoLimit As Label
    Friend WithEvents btnSyakenUpdate As Button
    Friend WithEvents btnMenkyoUpdate As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblCar_width As Label
    Friend WithEvents lblCarLength As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblBedHeight As Label
    Friend WithEvents lblBedWidth As Label
    Friend WithEvents lblBedLength As Label
    Friend WithEvents lblCarHeight As Label
End Class
