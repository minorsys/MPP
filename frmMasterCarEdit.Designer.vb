<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCarEdit
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCarBranch = New System.Windows.Forms.Label()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Carnum1Label = New System.Windows.Forms.Label()
        Me.txtCarnum1 = New System.Windows.Forms.TextBox()
        Me.Carnum2Label = New System.Windows.Forms.Label()
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.Carnum3Label = New System.Windows.Forms.Label()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.Carnum4Label = New System.Windows.Forms.Label()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.MusenLabel = New System.Windows.Forms.Label()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.TonLabel = New System.Windows.Forms.Label()
        Me.BikoLabel = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.dtpSyaken = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaxLoad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 12)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "id:"
        '
        'lblCarBranch
        '
        Me.lblCarBranch.AutoSize = True
        Me.lblCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "branch_id", True))
        Me.lblCarBranch.Location = New System.Drawing.Point(205, 162)
        Me.lblCarBranch.Name = "lblCarBranch"
        Me.lblCarBranch.Size = New System.Drawing.Size(71, 12)
        Me.lblCarBranch.TabIndex = 90
        Me.lblCarBranch.Text = "lblCarBranch"
        '
        'txtTon
        '
        Me.txtTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "ton", True))
        Me.txtTon.Enabled = False
        Me.txtTon.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtTon.Location = New System.Drawing.Point(84, 134)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.Size = New System.Drawing.Size(81, 19)
        Me.txtTon.TabIndex = 6
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.DropDownWidth = 100
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(165, 133)
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(20, 20)
        Me.cmbTon.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "(き)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "(100)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "(足立)"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(221, 389)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(55, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(158, 389)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(57, 23)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Carnum1Label
        '
        Me.Carnum1Label.AutoSize = True
        Me.Carnum1Label.Location = New System.Drawing.Point(24, 12)
        Me.Carnum1Label.Name = "Carnum1Label"
        Me.Carnum1Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum1Label.TabIndex = 79
        Me.Carnum1Label.Text = "車両番号"
        '
        'txtCarnum1
        '
        Me.txtCarnum1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum1", True))
        Me.txtCarnum1.Enabled = False
        Me.txtCarnum1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum1.Location = New System.Drawing.Point(84, 9)
        Me.txtCarnum1.Name = "txtCarnum1"
        Me.txtCarnum1.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum1.TabIndex = 1
        '
        'Carnum2Label
        '
        Me.Carnum2Label.AutoSize = True
        Me.Carnum2Label.Location = New System.Drawing.Point(38, 37)
        Me.Carnum2Label.Name = "Carnum2Label"
        Me.Carnum2Label.Size = New System.Drawing.Size(29, 12)
        Me.Carnum2Label.TabIndex = 80
        Me.Carnum2Label.Text = "地名"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum2", True))
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(84, 34)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum2.TabIndex = 2
        '
        'Carnum3Label
        '
        Me.Carnum3Label.AutoSize = True
        Me.Carnum3Label.Location = New System.Drawing.Point(24, 62)
        Me.Carnum3Label.Name = "Carnum3Label"
        Me.Carnum3Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum3Label.TabIndex = 81
        Me.Carnum3Label.Text = "分類番号"
        '
        'txtCarnum3
        '
        Me.txtCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum3", True))
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(84, 59)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum3.TabIndex = 3
        '
        'Carnum4Label
        '
        Me.Carnum4Label.AutoSize = True
        Me.Carnum4Label.Location = New System.Drawing.Point(24, 87)
        Me.Carnum4Label.Name = "Carnum4Label"
        Me.Carnum4Label.Size = New System.Drawing.Size(43, 12)
        Me.Carnum4Label.TabIndex = 82
        Me.Carnum4Label.Text = "ひらがな"
        '
        'txtCarnum4
        '
        Me.txtCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum4", True))
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(84, 84)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum4.TabIndex = 4
        '
        'MusenLabel
        '
        Me.MusenLabel.AutoSize = True
        Me.MusenLabel.Location = New System.Drawing.Point(24, 112)
        Me.MusenLabel.Name = "MusenLabel"
        Me.MusenLabel.Size = New System.Drawing.Size(53, 12)
        Me.MusenLabel.TabIndex = 83
        Me.MusenLabel.Text = "無線番号"
        '
        'txtMusen
        '
        Me.txtMusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "musen", True))
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(84, 109)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(64, 19)
        Me.txtMusen.TabIndex = 5
        '
        'TonLabel
        '
        Me.TonLabel.AutoSize = True
        Me.TonLabel.Location = New System.Drawing.Point(38, 137)
        Me.TonLabel.Name = "TonLabel"
        Me.TonLabel.Size = New System.Drawing.Size(29, 12)
        Me.TonLabel.TabIndex = 84
        Me.TonLabel.Text = "車格"
        '
        'BikoLabel
        '
        Me.BikoLabel.AutoSize = True
        Me.BikoLabel.Location = New System.Drawing.Point(38, 237)
        Me.BikoLabel.Name = "BikoLabel"
        Me.BikoLabel.Size = New System.Drawing.Size(29, 12)
        Me.BikoLabel.TabIndex = 85
        Me.BikoLabel.Text = "備考"
        '
        'txtBiko
        '
        Me.txtBiko.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "biko", True))
        Me.txtBiko.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBiko.Location = New System.Drawing.Point(84, 234)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(192, 149)
        Me.txtBiko.TabIndex = 11
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(38, 162)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 86
        Me.Branch_idLabel.Text = "所属"
        '
        'cmbBranch
        '
        Me.cmbBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblcarBindingSource, "branch_id", True))
        Me.cmbBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbBranch.DisplayMember = "branch_name"
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.ItemHeight = 12
        Me.cmbBranch.Location = New System.Drawing.Point(84, 159)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(101, 20)
        Me.cmbBranch.TabIndex = 8
        Me.cmbBranch.ValueMember = "id_branch"
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
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'dtpSyaken
        '
        Me.dtpSyaken.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "limit_syaken", True))
        Me.dtpSyaken.Location = New System.Drawing.Point(84, 210)
        Me.dtpSyaken.Name = "dtpSyaken"
        Me.dtpSyaken.Size = New System.Drawing.Size(107, 19)
        Me.dtpSyaken.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(187, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "kg"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "車検証期限"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "最大積載量"
        '
        'txtMaxLoad
        '
        Me.txtMaxLoad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "max_load", True))
        Me.txtMaxLoad.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMaxLoad.Location = New System.Drawing.Point(84, 185)
        Me.txtMaxLoad.Name = "txtMaxLoad"
        Me.txtMaxLoad.Size = New System.Drawing.Size(100, 19)
        Me.txtMaxLoad.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "備考"
        '
        'frmMasterCarEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(306, 431)
        Me.Controls.Add(Me.dtpSyaken)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaxLoad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCarBranch)
        Me.Controls.Add(Me.txtTon)
        Me.Controls.Add(Me.cmbTon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Carnum1Label)
        Me.Controls.Add(Me.txtCarnum1)
        Me.Controls.Add(Me.Carnum2Label)
        Me.Controls.Add(Me.txtCarnum2)
        Me.Controls.Add(Me.Carnum3Label)
        Me.Controls.Add(Me.txtCarnum3)
        Me.Controls.Add(Me.Carnum4Label)
        Me.Controls.Add(Me.txtCarnum4)
        Me.Controls.Add(Me.MusenLabel)
        Me.Controls.Add(Me.txtMusen)
        Me.Controls.Add(Me.TonLabel)
        Me.Controls.Add(Me.BikoLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.Name = "frmMasterCarEdit"
        Me.Text = "frmMasterCarEdit"
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents lblCarBranch As Label
    Friend WithEvents txtTon As TextBox
    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Carnum1Label As Label
    Friend WithEvents txtCarnum1 As TextBox
    Friend WithEvents Carnum2Label As Label
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents Carnum3Label As Label
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents Carnum4Label As Label
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents MusenLabel As Label
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents TonLabel As Label
    Friend WithEvents BikoLabel As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents dtpSyaken As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaxLoad As TextBox
    Friend WithEvents Label7 As Label
End Class
