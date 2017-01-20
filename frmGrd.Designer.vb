<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrd))
        Me.DtMainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DtMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DtMainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grdMain = New System.Windows.Forms.DataGridView()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        Me.btn15tU = New System.Windows.Forms.Button()
        Me.btn10tU = New System.Windows.Forms.Button()
        Me.btn7tU = New System.Windows.Forms.Button()
        Me.btn4tU = New System.Windows.Forms.Button()
        Me.btn3tU = New System.Windows.Forms.Button()
        Me.btn2tU = New System.Windows.Forms.Button()
        Me.btn2tHira = New System.Windows.Forms.Button()
        Me.btnAllCar = New System.Windows.Forms.Button()
        Me.btn8000 = New System.Windows.Forms.Button()
        Me.btn7000 = New System.Windows.Forms.Button()
        Me.btn6000 = New System.Windows.Forms.Button()
        Me.btn5000 = New System.Windows.Forms.Button()
        Me.btn4000 = New System.Windows.Forms.Button()
        Me.btn3000 = New System.Windows.Forms.Button()
        Me.btn2000 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn9000 = New System.Windows.Forms.Button()
        Me.btnWa = New System.Windows.Forms.Button()
        Me.btnRa = New System.Windows.Forms.Button()
        Me.btnYa = New System.Windows.Forms.Button()
        Me.btnMa = New System.Windows.Forms.Button()
        Me.btnHa = New System.Windows.Forms.Button()
        Me.btnNa = New System.Windows.Forms.Button()
        Me.btnTa = New System.Windows.Forms.Button()
        Me.btnSa = New System.Windows.Forms.Button()
        Me.btnKa = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBranchCar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBranchStaff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilterKana = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilterPhonenum = New System.Windows.Forms.TextBox()
        Me.lblHowManyRecords = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.DtMainTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.dtMainTableAdapter()
        Me.TableAdapterManager = New MPP.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.max_load = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_syaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_menkyo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtMainBindingNavigator.SuspendLayout()
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtMainBindingNavigator
        '
        Me.DtMainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DtMainBindingNavigator.BindingSource = Me.DtMainBindingSource
        Me.DtMainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DtMainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DtMainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DtMainBindingNavigatorSaveItem})
        Me.DtMainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DtMainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DtMainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DtMainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DtMainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DtMainBindingNavigator.Name = "DtMainBindingNavigator"
        Me.DtMainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DtMainBindingNavigator.Size = New System.Drawing.Size(836, 25)
        Me.DtMainBindingNavigator.TabIndex = 0
        Me.DtMainBindingNavigator.Text = "BindingNavigator1"
        Me.DtMainBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'DtMainBindingSource
        '
        Me.DtMainBindingSource.DataMember = "dtMain"
        Me.DtMainBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DtMainBindingNavigatorSaveItem
        '
        Me.DtMainBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DtMainBindingNavigatorSaveItem.Enabled = False
        Me.DtMainBindingNavigatorSaveItem.Image = CType(resources.GetObject("DtMainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DtMainBindingNavigatorSaveItem.Name = "DtMainBindingNavigatorSaveItem"
        Me.DtMainBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DtMainBindingNavigatorSaveItem.Text = "データの保存"
        '
        'grdMain
        '
        Me.grdMain.AllowUserToAddRows = False
        Me.grdMain.AllowUserToDeleteRows = False
        Me.grdMain.AutoGenerateColumns = False
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.max_load, Me.limit_syaken, Me.limit_menkyo})
        Me.grdMain.DataSource = Me.DtMainBindingSource
        Me.grdMain.Location = New System.Drawing.Point(172, 68)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.ReadOnly = True
        Me.grdMain.RowHeadersWidth = 30
        Me.grdMain.RowTemplate.Height = 21
        Me.grdMain.Size = New System.Drawing.Size(781, 449)
        Me.grdMain.TabIndex = 1
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(12, 12)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(80, 23)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "管理メニュー"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFilterClear)
        Me.GroupBox1.Controls.Add(Me.btn15tU)
        Me.GroupBox1.Controls.Add(Me.btn10tU)
        Me.GroupBox1.Controls.Add(Me.btn7tU)
        Me.GroupBox1.Controls.Add(Me.btn4tU)
        Me.GroupBox1.Controls.Add(Me.btn3tU)
        Me.GroupBox1.Controls.Add(Me.btn2tU)
        Me.GroupBox1.Controls.Add(Me.btn2tHira)
        Me.GroupBox1.Controls.Add(Me.btnAllCar)
        Me.GroupBox1.Controls.Add(Me.btn8000)
        Me.GroupBox1.Controls.Add(Me.btn7000)
        Me.GroupBox1.Controls.Add(Me.btn6000)
        Me.GroupBox1.Controls.Add(Me.btn5000)
        Me.GroupBox1.Controls.Add(Me.btn4000)
        Me.GroupBox1.Controls.Add(Me.btn3000)
        Me.GroupBox1.Controls.Add(Me.btn2000)
        Me.GroupBox1.Controls.Add(Me.btn1000)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.btn9000)
        Me.GroupBox1.Controls.Add(Me.btnWa)
        Me.GroupBox1.Controls.Add(Me.btnRa)
        Me.GroupBox1.Controls.Add(Me.btnYa)
        Me.GroupBox1.Controls.Add(Me.btnMa)
        Me.GroupBox1.Controls.Add(Me.btnHa)
        Me.GroupBox1.Controls.Add(Me.btnNa)
        Me.GroupBox1.Controls.Add(Me.btnTa)
        Me.GroupBox1.Controls.Add(Me.btnSa)
        Me.GroupBox1.Controls.Add(Me.btnKa)
        Me.GroupBox1.Controls.Add(Me.btnA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbBranchCar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbBranchStaff)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFilterKana)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFilterPhonenum)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 478)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "絞り込み"
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Location = New System.Drawing.Point(63, 447)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(84, 23)
        Me.btnFilterClear.TabIndex = 36
        Me.btnFilterClear.Text = "絞り込み解除"
        Me.btnFilterClear.UseVisualStyleBackColor = True
        '
        'btn15tU
        '
        Me.btn15tU.Location = New System.Drawing.Point(95, 326)
        Me.btn15tU.Name = "btn15tU"
        Me.btn15tU.Size = New System.Drawing.Size(52, 23)
        Me.btn15tU.TabIndex = 35
        Me.btn15tU.Text = "15tU"
        Me.btn15tU.UseVisualStyleBackColor = True
        '
        'btn10tU
        '
        Me.btn10tU.Location = New System.Drawing.Point(95, 297)
        Me.btn10tU.Name = "btn10tU"
        Me.btn10tU.Size = New System.Drawing.Size(52, 23)
        Me.btn10tU.TabIndex = 34
        Me.btn10tU.Text = "10tU"
        Me.btn10tU.UseVisualStyleBackColor = True
        '
        'btn7tU
        '
        Me.btn7tU.Location = New System.Drawing.Point(95, 268)
        Me.btn7tU.Name = "btn7tU"
        Me.btn7tU.Size = New System.Drawing.Size(52, 23)
        Me.btn7tU.TabIndex = 33
        Me.btn7tU.Text = "7tU"
        Me.btn7tU.UseVisualStyleBackColor = True
        '
        'btn4tU
        '
        Me.btn4tU.Location = New System.Drawing.Point(95, 239)
        Me.btn4tU.Name = "btn4tU"
        Me.btn4tU.Size = New System.Drawing.Size(52, 23)
        Me.btn4tU.TabIndex = 32
        Me.btn4tU.Text = "4tU"
        Me.btn4tU.UseVisualStyleBackColor = True
        '
        'btn3tU
        '
        Me.btn3tU.Location = New System.Drawing.Point(95, 210)
        Me.btn3tU.Name = "btn3tU"
        Me.btn3tU.Size = New System.Drawing.Size(52, 23)
        Me.btn3tU.TabIndex = 31
        Me.btn3tU.Text = "3tU"
        Me.btn3tU.UseVisualStyleBackColor = True
        '
        'btn2tU
        '
        Me.btn2tU.Location = New System.Drawing.Point(95, 181)
        Me.btn2tU.Name = "btn2tU"
        Me.btn2tU.Size = New System.Drawing.Size(52, 23)
        Me.btn2tU.TabIndex = 30
        Me.btn2tU.Text = "2tU"
        Me.btn2tU.UseVisualStyleBackColor = True
        '
        'btn2tHira
        '
        Me.btn2tHira.Location = New System.Drawing.Point(95, 152)
        Me.btn2tHira.Name = "btn2tHira"
        Me.btn2tHira.Size = New System.Drawing.Size(52, 23)
        Me.btn2tHira.TabIndex = 29
        Me.btn2tHira.Text = "2t平"
        Me.btn2tHira.UseVisualStyleBackColor = True
        '
        'btnAllCar
        '
        Me.btnAllCar.Location = New System.Drawing.Point(82, 121)
        Me.btnAllCar.Name = "btnAllCar"
        Me.btnAllCar.Size = New System.Drawing.Size(65, 23)
        Me.btnAllCar.TabIndex = 28
        Me.btnAllCar.Text = "車両のみ"
        Me.btnAllCar.UseVisualStyleBackColor = True
        '
        'btn8000
        '
        Me.btn8000.Location = New System.Drawing.Point(38, 384)
        Me.btn8000.Name = "btn8000"
        Me.btn8000.Size = New System.Drawing.Size(51, 23)
        Me.btn8000.TabIndex = 27
        Me.btn8000.Text = "8000-"
        Me.btn8000.UseVisualStyleBackColor = True
        '
        'btn7000
        '
        Me.btn7000.Location = New System.Drawing.Point(38, 355)
        Me.btn7000.Name = "btn7000"
        Me.btn7000.Size = New System.Drawing.Size(51, 23)
        Me.btn7000.TabIndex = 26
        Me.btn7000.Text = "7000-"
        Me.btn7000.UseVisualStyleBackColor = True
        '
        'btn6000
        '
        Me.btn6000.Location = New System.Drawing.Point(38, 326)
        Me.btn6000.Name = "btn6000"
        Me.btn6000.Size = New System.Drawing.Size(51, 23)
        Me.btn6000.TabIndex = 25
        Me.btn6000.Text = "6000-"
        Me.btn6000.UseVisualStyleBackColor = True
        '
        'btn5000
        '
        Me.btn5000.Location = New System.Drawing.Point(38, 297)
        Me.btn5000.Name = "btn5000"
        Me.btn5000.Size = New System.Drawing.Size(51, 23)
        Me.btn5000.TabIndex = 24
        Me.btn5000.Text = "5000-"
        Me.btn5000.UseVisualStyleBackColor = True
        '
        'btn4000
        '
        Me.btn4000.Location = New System.Drawing.Point(38, 268)
        Me.btn4000.Name = "btn4000"
        Me.btn4000.Size = New System.Drawing.Size(51, 23)
        Me.btn4000.TabIndex = 23
        Me.btn4000.Text = "4000-"
        Me.btn4000.UseVisualStyleBackColor = True
        '
        'btn3000
        '
        Me.btn3000.Location = New System.Drawing.Point(38, 239)
        Me.btn3000.Name = "btn3000"
        Me.btn3000.Size = New System.Drawing.Size(51, 23)
        Me.btn3000.TabIndex = 22
        Me.btn3000.Text = "3000-"
        Me.btn3000.UseVisualStyleBackColor = True
        '
        'btn2000
        '
        Me.btn2000.Location = New System.Drawing.Point(38, 210)
        Me.btn2000.Name = "btn2000"
        Me.btn2000.Size = New System.Drawing.Size(51, 23)
        Me.btn2000.TabIndex = 21
        Me.btn2000.Text = "2000-"
        Me.btn2000.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Location = New System.Drawing.Point(38, 181)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(51, 23)
        Me.btn1000.TabIndex = 20
        Me.btn1000.Text = "1000-"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(38, 152)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(51, 23)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "1-"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn9000
        '
        Me.btn9000.Location = New System.Drawing.Point(38, 413)
        Me.btn9000.Name = "btn9000"
        Me.btn9000.Size = New System.Drawing.Size(51, 23)
        Me.btn9000.TabIndex = 18
        Me.btn9000.Text = "9000-"
        Me.btn9000.UseVisualStyleBackColor = True
        '
        'btnWa
        '
        Me.btnWa.Location = New System.Drawing.Point(6, 413)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(26, 23)
        Me.btnWa.TabIndex = 17
        Me.btnWa.Text = "ﾜ"
        Me.btnWa.UseVisualStyleBackColor = True
        '
        'btnRa
        '
        Me.btnRa.Location = New System.Drawing.Point(6, 384)
        Me.btnRa.Name = "btnRa"
        Me.btnRa.Size = New System.Drawing.Size(26, 23)
        Me.btnRa.TabIndex = 16
        Me.btnRa.Text = "ﾗ"
        Me.btnRa.UseVisualStyleBackColor = True
        '
        'btnYa
        '
        Me.btnYa.Location = New System.Drawing.Point(6, 355)
        Me.btnYa.Name = "btnYa"
        Me.btnYa.Size = New System.Drawing.Size(26, 23)
        Me.btnYa.TabIndex = 15
        Me.btnYa.Text = "ﾔ"
        Me.btnYa.UseVisualStyleBackColor = True
        '
        'btnMa
        '
        Me.btnMa.Location = New System.Drawing.Point(6, 326)
        Me.btnMa.Name = "btnMa"
        Me.btnMa.Size = New System.Drawing.Size(26, 23)
        Me.btnMa.TabIndex = 14
        Me.btnMa.Text = "ﾏ"
        Me.btnMa.UseVisualStyleBackColor = True
        '
        'btnHa
        '
        Me.btnHa.Location = New System.Drawing.Point(6, 297)
        Me.btnHa.Name = "btnHa"
        Me.btnHa.Size = New System.Drawing.Size(26, 23)
        Me.btnHa.TabIndex = 13
        Me.btnHa.Text = "ﾊ"
        Me.btnHa.UseVisualStyleBackColor = True
        '
        'btnNa
        '
        Me.btnNa.Location = New System.Drawing.Point(6, 268)
        Me.btnNa.Name = "btnNa"
        Me.btnNa.Size = New System.Drawing.Size(26, 23)
        Me.btnNa.TabIndex = 12
        Me.btnNa.Text = "ﾅ"
        Me.btnNa.UseVisualStyleBackColor = True
        '
        'btnTa
        '
        Me.btnTa.Location = New System.Drawing.Point(6, 239)
        Me.btnTa.Name = "btnTa"
        Me.btnTa.Size = New System.Drawing.Size(26, 23)
        Me.btnTa.TabIndex = 11
        Me.btnTa.Text = "ﾀ"
        Me.btnTa.UseVisualStyleBackColor = True
        '
        'btnSa
        '
        Me.btnSa.Location = New System.Drawing.Point(6, 210)
        Me.btnSa.Name = "btnSa"
        Me.btnSa.Size = New System.Drawing.Size(26, 23)
        Me.btnSa.TabIndex = 10
        Me.btnSa.Text = "ｻ"
        Me.btnSa.UseVisualStyleBackColor = True
        '
        'btnKa
        '
        Me.btnKa.Location = New System.Drawing.Point(6, 181)
        Me.btnKa.Name = "btnKa"
        Me.btnKa.Size = New System.Drawing.Size(26, 23)
        Me.btnKa.TabIndex = 9
        Me.btnKa.Text = "ｶ"
        Me.btnKa.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(6, 152)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(26, 23)
        Me.btnA.TabIndex = 8
        Me.btnA.Text = "ｱ"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "所属(車両)"
        '
        'cmbBranchCar
        '
        Me.cmbBranchCar.FormattingEnabled = True
        Me.cmbBranchCar.Location = New System.Drawing.Point(82, 95)
        Me.cmbBranchCar.Name = "cmbBranchCar"
        Me.cmbBranchCar.Size = New System.Drawing.Size(65, 20)
        Me.cmbBranchCar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "所属(社員)"
        '
        'cmbBranchStaff
        '
        Me.cmbBranchStaff.FormattingEnabled = True
        Me.cmbBranchStaff.Location = New System.Drawing.Point(82, 69)
        Me.cmbBranchStaff.Name = "cmbBranchStaff"
        Me.cmbBranchStaff.Size = New System.Drawing.Size(65, 20)
        Me.cmbBranchStaff.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "氏名ｶﾅ"
        '
        'txtFilterKana
        '
        Me.txtFilterKana.Location = New System.Drawing.Point(82, 43)
        Me.txtFilterKana.Name = "txtFilterKana"
        Me.txtFilterKana.Size = New System.Drawing.Size(65, 19)
        Me.txtFilterKana.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "電話番号"
        '
        'txtFilterPhonenum
        '
        Me.txtFilterPhonenum.Location = New System.Drawing.Point(82, 18)
        Me.txtFilterPhonenum.Name = "txtFilterPhonenum"
        Me.txtFilterPhonenum.Size = New System.Drawing.Size(65, 19)
        Me.txtFilterPhonenum.TabIndex = 0
        '
        'lblHowManyRecords
        '
        Me.lblHowManyRecords.AutoSize = True
        Me.lblHowManyRecords.Location = New System.Drawing.Point(170, 520)
        Me.lblHowManyRecords.Name = "lblHowManyRecords"
        Me.lblHowManyRecords.Size = New System.Drawing.Size(108, 12)
        Me.lblHowManyRecords.TabIndex = 4
        Me.lblHowManyRecords.Text = "lblHowManyRecords"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(864, 523)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(89, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "選択行の編集"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'DtMainTableAdapter
        '
        Me.DtMainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_branchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_carTableAdapter = Nothing
        Me.TableAdapterManager.tbl_feeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PhoneNumTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MPP.PhoneNumDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "phonenum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "電話番号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn2.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "biko"
        Me.DataGridViewTextBoxColumn3.HeaderText = "biko"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "model"
        Me.DataGridViewTextBoxColumn4.HeaderText = "model"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "staff_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "staff_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_branch"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_branch"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "branch_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "所属"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_staff"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_staff"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "氏名"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "staff_kana"
        Me.DataGridViewTextBoxColumn10.HeaderText = "staff_kana"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "branch_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "branch_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "staff_phonenum"
        Me.DataGridViewTextBoxColumn12.HeaderText = "staff_phonenum"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "biko1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "biko1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "carnum1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "車番"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "carnum2"
        Me.DataGridViewTextBoxColumn15.HeaderText = "carnum2"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "carnum3"
        Me.DataGridViewTextBoxColumn16.HeaderText = "carnum3"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "carnum4"
        Me.DataGridViewTextBoxColumn17.HeaderText = "carnum4"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "musen"
        Me.DataGridViewTextBoxColumn18.HeaderText = "無線"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ton"
        Me.DataGridViewTextBoxColumn19.HeaderText = "車格"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "biko2"
        Me.DataGridViewTextBoxColumn20.HeaderText = "biko2"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "branch_id1"
        Me.DataGridViewTextBoxColumn21.HeaderText = "branch_id1"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "staff_id1"
        Me.DataGridViewTextBoxColumn22.HeaderText = "staff_id1"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "id_branch1"
        Me.DataGridViewTextBoxColumn23.HeaderText = "id_branch1"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "branch_name1"
        Me.DataGridViewTextBoxColumn24.HeaderText = "車庫"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'max_load
        '
        Me.max_load.DataPropertyName = "max_load"
        Me.max_load.HeaderText = "最大積載量"
        Me.max_load.Name = "max_load"
        Me.max_load.ReadOnly = True
        '
        'limit_syaken
        '
        Me.limit_syaken.DataPropertyName = "limit_syaken"
        Me.limit_syaken.HeaderText = "車検証期限"
        Me.limit_syaken.Name = "limit_syaken"
        Me.limit_syaken.ReadOnly = True
        '
        'limit_menkyo
        '
        Me.limit_menkyo.DataPropertyName = "limit_menkyo"
        Me.limit_menkyo.HeaderText = "免許証期限"
        Me.limit_menkyo.Name = "limit_menkyo"
        Me.limit_menkyo.ReadOnly = True
        '
        'frmGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 555)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblHowManyRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.grdMain)
        Me.Controls.Add(Me.DtMainBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrd"
        Me.Text = "MinoriPhone+"
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtMainBindingNavigator.ResumeLayout(False)
        Me.DtMainBindingNavigator.PerformLayout()
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents DtMainBindingSource As BindingSource
    Friend WithEvents DtMainTableAdapter As PhoneNumDBDataSetTableAdapters.dtMainTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DtMainBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DtMainBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grdMain As DataGridView
    Friend WithEvents btnAdmin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilterClear As Button
    Friend WithEvents btn15tU As Button
    Friend WithEvents btn10tU As Button
    Friend WithEvents btn7tU As Button
    Friend WithEvents btn4tU As Button
    Friend WithEvents btn3tU As Button
    Friend WithEvents btn2tU As Button
    Friend WithEvents btn2tHira As Button
    Friend WithEvents btnAllCar As Button
    Friend WithEvents btn8000 As Button
    Friend WithEvents btn7000 As Button
    Friend WithEvents btn6000 As Button
    Friend WithEvents btn5000 As Button
    Friend WithEvents btn4000 As Button
    Friend WithEvents btn3000 As Button
    Friend WithEvents btn2000 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn9000 As Button
    Friend WithEvents btnWa As Button
    Friend WithEvents btnRa As Button
    Friend WithEvents btnYa As Button
    Friend WithEvents btnMa As Button
    Friend WithEvents btnHa As Button
    Friend WithEvents btnNa As Button
    Friend WithEvents btnTa As Button
    Friend WithEvents btnSa As Button
    Friend WithEvents btnKa As Button
    Friend WithEvents btnA As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBranchCar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBranchStaff As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFilterKana As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilterPhonenum As TextBox
    Friend WithEvents lblHowManyRecords As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents max_load As DataGridViewTextBoxColumn
    Friend WithEvents limit_syaken As DataGridViewTextBoxColumn
    Friend WithEvents limit_menkyo As DataGridViewTextBoxColumn
End Class
