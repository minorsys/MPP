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
        Me.btnExportSyakenMenkyo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.max_load = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_syaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_menkyo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.car_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phonenum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carnum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.musen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ton = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.DtMainTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.dtMainTableAdapter()
        Me.TableAdapterManager = New MPP.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.btnEmergency = New System.Windows.Forms.Button()
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtMainBindingNavigator.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdMain.AllowUserToOrderColumns = True
        Me.grdMain.AutoGenerateColumns = False
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.phonenum, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.branch_name, Me.DataGridViewTextBoxColumn8, Me.staff_name, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.carnum1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.musen, Me.ton, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.car_branch, Me.max_load, Me.limit_syaken, Me.limit_menkyo, Me.DataGridViewTextBoxColumn28, Me.car_length, Me.car_width, Me.car_height, Me.bed_length, Me.bed_width, Me.bed_height})
        Me.grdMain.DataSource = Me.DtMainBindingSource
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.Location = New System.Drawing.Point(0, 0)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.ReadOnly = True
        Me.grdMain.RowHeadersWidth = 30
        Me.grdMain.RowTemplate.Height = 21
        Me.grdMain.Size = New System.Drawing.Size(948, 616)
        Me.grdMain.TabIndex = 1
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(9, 3)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(80, 23)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "管理メニュー"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnEmergency)
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 475)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "絞り込み"
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Location = New System.Drawing.Point(38, 443)
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
        Me.btnAllCar.Location = New System.Drawing.Point(38, 123)
        Me.btnAllCar.Name = "btnAllCar"
        Me.btnAllCar.Size = New System.Drawing.Size(84, 23)
        Me.btnAllCar.TabIndex = 28
        Me.btnAllCar.Text = "車両のみ表示"
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
        Me.lblHowManyRecords.Location = New System.Drawing.Point(12, 595)
        Me.lblHowManyRecords.Name = "lblHowManyRecords"
        Me.lblHowManyRecords.Size = New System.Drawing.Size(108, 12)
        Me.lblHowManyRecords.TabIndex = 4
        Me.lblHowManyRecords.Text = "lblHowManyRecords"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(17, 18)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(126, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "詳細表示/編集"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnExportSyakenMenkyo
        '
        Me.btnExportSyakenMenkyo.Location = New System.Drawing.Point(17, 47)
        Me.btnExportSyakenMenkyo.Name = "btnExportSyakenMenkyo"
        Me.btnExportSyakenMenkyo.Size = New System.Drawing.Size(125, 23)
        Me.btnExportSyakenMenkyo.TabIndex = 6
        Me.btnExportSyakenMenkyo.Text = "車検/免許ﾌｧｲﾙ出力"
        Me.btnExportSyakenMenkyo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.btnModify)
        Me.GroupBox2.Controls.Add(Me.btnExportSyakenMenkyo)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 77)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選択した行の操作"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHowManyRecords)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdmin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdMain)
        Me.SplitContainer1.Size = New System.Drawing.Size(1122, 616)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 8
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
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "emergency"
        Me.DataGridViewTextBoxColumn28.HeaderText = "emergency"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'car_length
        '
        Me.car_length.DataPropertyName = "car_length"
        Me.car_length.HeaderText = "車両_長さ"
        Me.car_length.Name = "car_length"
        Me.car_length.ReadOnly = True
        '
        'car_width
        '
        Me.car_width.DataPropertyName = "car_width"
        Me.car_width.HeaderText = "車両_幅"
        Me.car_width.Name = "car_width"
        Me.car_width.ReadOnly = True
        '
        'car_height
        '
        Me.car_height.DataPropertyName = "car_height"
        Me.car_height.HeaderText = "車両_高さ"
        Me.car_height.Name = "car_height"
        Me.car_height.ReadOnly = True
        '
        'bed_length
        '
        Me.bed_length.DataPropertyName = "bed_length"
        Me.bed_length.HeaderText = "荷台長"
        Me.bed_length.Name = "bed_length"
        Me.bed_length.ReadOnly = True
        '
        'bed_width
        '
        Me.bed_width.DataPropertyName = "bed_width"
        Me.bed_width.HeaderText = "荷台幅"
        Me.bed_width.Name = "bed_width"
        Me.bed_width.ReadOnly = True
        '
        'bed_height
        '
        Me.bed_height.DataPropertyName = "bed_height"
        Me.bed_height.HeaderText = "荷台高"
        Me.bed_height.Name = "bed_height"
        Me.bed_height.ReadOnly = True
        '
        'phonenum
        '
        Me.phonenum.DataPropertyName = "phonenum"
        Me.phonenum.HeaderText = "電話番号"
        Me.phonenum.Name = "phonenum"
        Me.phonenum.ReadOnly = True
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
        'branch_name
        '
        Me.branch_name.DataPropertyName = "branch_name"
        Me.branch_name.HeaderText = "所属"
        Me.branch_name.Name = "branch_name"
        Me.branch_name.ReadOnly = True
        Me.branch_name.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_staff"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_staff"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'staff_name
        '
        Me.staff_name.DataPropertyName = "staff_name"
        Me.staff_name.HeaderText = "氏名"
        Me.staff_name.Name = "staff_name"
        Me.staff_name.ReadOnly = True
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
        'carnum1
        '
        Me.carnum1.DataPropertyName = "carnum1"
        Me.carnum1.HeaderText = "車番"
        Me.carnum1.Name = "carnum1"
        Me.carnum1.ReadOnly = True
        Me.carnum1.Width = 50
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
        'musen
        '
        Me.musen.DataPropertyName = "musen"
        Me.musen.HeaderText = "無線"
        Me.musen.Name = "musen"
        Me.musen.ReadOnly = True
        Me.musen.Width = 50
        '
        'ton
        '
        Me.ton.DataPropertyName = "ton"
        Me.ton.HeaderText = "車格"
        Me.ton.Name = "ton"
        Me.ton.ReadOnly = True
        Me.ton.Width = 50
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
        'car_branch
        '
        Me.car_branch.DataPropertyName = "branch_name1"
        Me.car_branch.HeaderText = "車庫"
        Me.car_branch.Name = "car_branch"
        Me.car_branch.ReadOnly = True
        Me.car_branch.Width = 50
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
        'btnEmergency
        '
        Me.btnEmergency.Location = New System.Drawing.Point(95, 355)
        Me.btnEmergency.Name = "btnEmergency"
        Me.btnEmergency.Size = New System.Drawing.Size(52, 23)
        Me.btnEmergency.TabIndex = 37
        Me.btnEmergency.Text = "緊急"
        Me.btnEmergency.UseVisualStyleBackColor = True
        '
        'frmGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1122, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DtMainBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrd"
        Me.Text = "Men, Phones, and Plates"
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtMainBindingNavigator.ResumeLayout(False)
        Me.DtMainBindingNavigator.PerformLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnExportSyakenMenkyo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents phonenum As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents branch_name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents staff_name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents carnum1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents musen As DataGridViewTextBoxColumn
    Friend WithEvents ton As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents car_branch As DataGridViewTextBoxColumn
    Friend WithEvents max_load As DataGridViewTextBoxColumn
    Friend WithEvents limit_syaken As DataGridViewTextBoxColumn
    Friend WithEvents limit_menkyo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewCheckBoxColumn
    Friend WithEvents car_length As DataGridViewTextBoxColumn
    Friend WithEvents car_width As DataGridViewTextBoxColumn
    Friend WithEvents car_height As DataGridViewTextBoxColumn
    Friend WithEvents bed_length As DataGridViewTextBoxColumn
    Friend WithEvents bed_width As DataGridViewTextBoxColumn
    Friend WithEvents bed_height As DataGridViewTextBoxColumn
    Friend WithEvents btnEmergency As Button
End Class
