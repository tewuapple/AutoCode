namespace AutoCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_que_FormName = new System.Windows.Forms.Label();
            this.txt_que_FormName = new System.Windows.Forms.TextBox();
            this.lb_que_NameSpace = new System.Windows.Forms.Label();
            this.txt_que_NameSpace = new System.Windows.Forms.TextBox();
            this.btn_AutoCode = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tec_QueCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.tec_QueDesigner = new ICSharpCode.TextEditor.TextEditorControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_que_dgvdict = new System.Windows.Forms.TextBox();
            this.lb_que_dgvdict = new System.Windows.Forms.Label();
            this.lb_que_RequestType = new System.Windows.Forms.Label();
            this.txt_que_RequestType = new System.Windows.Forms.TextBox();
            this.dgv_que = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CReadOnly = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIsRealtimeSynchronous = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CObjectDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMonitorField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIsQuery = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AutoFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AutoSort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_SaveQueConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LoadQueConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LoadIOConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SaveIOConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SaveControlConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LoadControlConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tab_Que = new System.Windows.Forms.TabPage();
            this.tab_IO = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.tec_IOCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.tec_IODesigner = new ICSharpCode.TextEditor.TextEditorControl();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.txt_datatable = new System.Windows.Forms.TextBox();
            this.btn_grid_auto = new System.Windows.Forms.Button();
            this.txt_io_InitEnvironment = new System.Windows.Forms.TextBox();
            this.lb_io_InitEnvironment = new System.Windows.Forms.Label();
            this.txt_io_ReFillWorkFiled = new System.Windows.Forms.TextBox();
            this.lb_io_ReFillWorkFiled = new System.Windows.Forms.Label();
            this.txt_io_dgvdict = new System.Windows.Forms.TextBox();
            this.lb_io_dgvdict = new System.Windows.Forms.Label();
            this.lb_io_DelRightBit = new System.Windows.Forms.Label();
            this.lb_io_DelRequestType = new System.Windows.Forms.Label();
            this.lb_io_UpdRightBit = new System.Windows.Forms.Label();
            this.lb_io_UpdRequestType = new System.Windows.Forms.Label();
            this.lb_io_AddRightBit = new System.Windows.Forms.Label();
            this.lb_io_AddRequestType = new System.Windows.Forms.Label();
            this.lb_io_QueRightBit = new System.Windows.Forms.Label();
            this.lb_io_QueRequestType = new System.Windows.Forms.Label();
            this.txt_io_DelRightBit = new System.Windows.Forms.TextBox();
            this.txt_io_DelRequestType = new System.Windows.Forms.TextBox();
            this.txt_io_UpdRightBit = new System.Windows.Forms.TextBox();
            this.txt_io_UpdRequestType = new System.Windows.Forms.TextBox();
            this.txt_io_AddRightBit = new System.Windows.Forms.TextBox();
            this.txt_io_AddRequestType = new System.Windows.Forms.TextBox();
            this.txt_io_QueRightBit = new System.Windows.Forms.TextBox();
            this.txt_io_QueRequestType = new System.Windows.Forms.TextBox();
            this.btn_io_AutoCode = new System.Windows.Forms.Button();
            this.lb_io_FormName = new System.Windows.Forms.Label();
            this.lb_io_NameSpace = new System.Windows.Forms.Label();
            this.txt_io_NameSpace = new System.Windows.Forms.TextBox();
            this.txt_io_FormName = new System.Windows.Forms.TextBox();
            this.dgv_io = new System.Windows.Forms.DataGridView();
            this.CIOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIODigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIODictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIODomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOReadOnly = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOIsRealtimeSynchronous = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIObjectDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIsInQue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CQueRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQueIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIsInIO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIORow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOMonitorField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIODefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIOIsQuery = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOIsAdd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOIsUpdate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOIsDelete = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CIOParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Control = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.tec_ControlCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dgvfield = new System.Windows.Forms.TextBox();
            this.lb_dgvfield = new System.Windows.Forms.Label();
            this.chb_CIsOneMonitorField = new System.Windows.Forms.CheckBox();
            this.btn_control_AutoCode = new System.Windows.Forms.Button();
            this.dgv_control = new System.Windows.Forms.DataGridView();
            this.CCIOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIOLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIODigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIODictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIODomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCReadOnly = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CCEnable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CCIOType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CCIOIsRealtimeSynchronous = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CCIObjectDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CPreTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIOMonitorField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIODefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCIOParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKSWorkViewCommandRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_que_InitEnvironment = new System.Windows.Forms.TextBox();
            this.lb_que_InitEnvironment = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_que)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.tab_Que.SuspendLayout();
            this.tab_IO.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_io)).BeginInit();
            this.tab_Control.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_que_FormName
            // 
            this.lb_que_FormName.AutoSize = true;
            this.lb_que_FormName.Location = new System.Drawing.Point(64, 18);
            this.lb_que_FormName.Name = "lb_que_FormName";
            this.lb_que_FormName.Size = new System.Drawing.Size(41, 12);
            this.lb_que_FormName.TabIndex = 0;
            this.lb_que_FormName.Text = "窗体名";
            // 
            // txt_que_FormName
            // 
            this.txt_que_FormName.Location = new System.Drawing.Point(111, 15);
            this.txt_que_FormName.Name = "txt_que_FormName";
            this.txt_que_FormName.Size = new System.Drawing.Size(100, 21);
            this.txt_que_FormName.TabIndex = 1;
            // 
            // lb_que_NameSpace
            // 
            this.lb_que_NameSpace.AutoSize = true;
            this.lb_que_NameSpace.Location = new System.Drawing.Point(217, 18);
            this.lb_que_NameSpace.Name = "lb_que_NameSpace";
            this.lb_que_NameSpace.Size = new System.Drawing.Size(53, 12);
            this.lb_que_NameSpace.TabIndex = 2;
            this.lb_que_NameSpace.Text = "命名空间";
            // 
            // txt_que_NameSpace
            // 
            this.txt_que_NameSpace.Location = new System.Drawing.Point(279, 15);
            this.txt_que_NameSpace.Name = "txt_que_NameSpace";
            this.txt_que_NameSpace.Size = new System.Drawing.Size(100, 21);
            this.txt_que_NameSpace.TabIndex = 3;
            // 
            // btn_AutoCode
            // 
            this.btn_AutoCode.Location = new System.Drawing.Point(887, 49);
            this.btn_AutoCode.Name = "btn_AutoCode";
            this.btn_AutoCode.Size = new System.Drawing.Size(75, 24);
            this.btn_AutoCode.TabIndex = 8;
            this.btn_AutoCode.Text = "代码生成";
            this.btn_AutoCode.UseVisualStyleBackColor = true;
            this.btn_AutoCode.Click += new System.EventHandler(this.btn_AutoCode_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1222, 488);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tec_QueCode);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tec_QueDesigner);
            this.splitContainer3.Size = new System.Drawing.Size(181, 488);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 0;
            // 
            // tec_QueCode
            // 
            this.tec_QueCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tec_QueCode.IsReadOnly = false;
            this.tec_QueCode.Location = new System.Drawing.Point(0, 0);
            this.tec_QueCode.Name = "tec_QueCode";
            this.tec_QueCode.Size = new System.Drawing.Size(181, 241);
            this.tec_QueCode.TabIndex = 0;
            // 
            // tec_QueDesigner
            // 
            this.tec_QueDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tec_QueDesigner.IsReadOnly = false;
            this.tec_QueDesigner.Location = new System.Drawing.Point(0, 0);
            this.tec_QueDesigner.Name = "tec_QueDesigner";
            this.tec_QueDesigner.Size = new System.Drawing.Size(181, 243);
            this.tec_QueDesigner.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_que_InitEnvironment);
            this.splitContainer2.Panel1.Controls.Add(this.lb_que_InitEnvironment);
            this.splitContainer2.Panel1.Controls.Add(this.txt_que_dgvdict);
            this.splitContainer2.Panel1.Controls.Add(this.lb_que_dgvdict);
            this.splitContainer2.Panel1.Controls.Add(this.lb_que_RequestType);
            this.splitContainer2.Panel1.Controls.Add(this.lb_que_FormName);
            this.splitContainer2.Panel1.Controls.Add(this.btn_AutoCode);
            this.splitContainer2.Panel1.Controls.Add(this.lb_que_NameSpace);
            this.splitContainer2.Panel1.Controls.Add(this.txt_que_RequestType);
            this.splitContainer2.Panel1.Controls.Add(this.txt_que_NameSpace);
            this.splitContainer2.Panel1.Controls.Add(this.txt_que_FormName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_que);
            this.splitContainer2.Size = new System.Drawing.Size(1037, 488);
            this.splitContainer2.SplitterDistance = 97;
            this.splitContainer2.TabIndex = 0;
            // 
            // txt_que_dgvdict
            // 
            this.txt_que_dgvdict.Location = new System.Drawing.Point(663, 15);
            this.txt_que_dgvdict.Name = "txt_que_dgvdict";
            this.txt_que_dgvdict.Size = new System.Drawing.Size(299, 21);
            this.txt_que_dgvdict.TabIndex = 7;
            // 
            // lb_que_dgvdict
            // 
            this.lb_que_dgvdict.AutoSize = true;
            this.lb_que_dgvdict.Location = new System.Drawing.Point(577, 18);
            this.lb_que_dgvdict.Name = "lb_que_dgvdict";
            this.lb_que_dgvdict.Size = new System.Drawing.Size(77, 12);
            this.lb_que_dgvdict.TabIndex = 6;
            this.lb_que_dgvdict.Text = "表格数据字典";
            // 
            // lb_que_RequestType
            // 
            this.lb_que_RequestType.AutoSize = true;
            this.lb_que_RequestType.Location = new System.Drawing.Point(388, 18);
            this.lb_que_RequestType.Name = "lb_que_RequestType";
            this.lb_que_RequestType.Size = new System.Drawing.Size(71, 12);
            this.lb_que_RequestType.TabIndex = 4;
            this.lb_que_RequestType.Text = "RequestType";
            // 
            // txt_que_RequestType
            // 
            this.txt_que_RequestType.Location = new System.Drawing.Point(468, 15);
            this.txt_que_RequestType.Name = "txt_que_RequestType";
            this.txt_que_RequestType.Size = new System.Drawing.Size(100, 21);
            this.txt_que_RequestType.TabIndex = 5;
            // 
            // dgv_que
            // 
            this.dgv_que.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_que.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CLabelName,
            this.CDigit,
            this.CDictCode,
            this.CDomain,
            this.CReadOnly,
            this.CType,
            this.CIsRealtimeSynchronous,
            this.CObjectDataType,
            this.CRow,
            this.CColumn,
            this.CIndex,
            this.CMonitorField,
            this.CDefaultValue,
            this.CIsQuery,
            this.CParamName});
            this.dgv_que.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_que.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_que.Location = new System.Drawing.Point(0, 0);
            this.dgv_que.Name = "dgv_que";
            this.dgv_que.RowTemplate.Height = 23;
            this.dgv_que.Size = new System.Drawing.Size(1037, 387);
            this.dgv_que.TabIndex = 0;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "控件名称";
            this.CName.Name = "CName";
            // 
            // CLabelName
            // 
            this.CLabelName.DataPropertyName = "CLabelName";
            this.CLabelName.HeaderText = "Label名称";
            this.CLabelName.Name = "CLabelName";
            // 
            // CDigit
            // 
            this.CDigit.DataPropertyName = "CDigit";
            this.CDigit.HeaderText = "小数位数";
            this.CDigit.Name = "CDigit";
            this.CDigit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDigit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CDictCode
            // 
            this.CDictCode.DataPropertyName = "CDictCode";
            this.CDictCode.HeaderText = "数据字典";
            this.CDictCode.Name = "CDictCode";
            // 
            // CDomain
            // 
            this.CDomain.DataPropertyName = "CDomain";
            this.CDomain.HeaderText = "Domain";
            this.CDomain.Name = "CDomain";
            // 
            // CReadOnly
            // 
            this.CReadOnly.DataPropertyName = "CReadOnly";
            this.CReadOnly.HeaderText = "ReadOnly";
            this.CReadOnly.Name = "CReadOnly";
            // 
            // CType
            // 
            this.CType.DataPropertyName = "CType";
            this.CType.HeaderText = "控件类型";
            this.CType.Name = "CType";
            // 
            // CIsRealtimeSynchronous
            // 
            this.CIsRealtimeSynchronous.DataPropertyName = "CIsRealtimeSynchronous";
            this.CIsRealtimeSynchronous.HeaderText = "是否实时同步";
            this.CIsRealtimeSynchronous.Name = "CIsRealtimeSynchronous";
            this.CIsRealtimeSynchronous.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CIsRealtimeSynchronous.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CObjectDataType
            // 
            this.CObjectDataType.DataPropertyName = "CObjectDataType";
            this.CObjectDataType.HeaderText = "WorkField数据类型";
            this.CObjectDataType.Name = "CObjectDataType";
            // 
            // CRow
            // 
            this.CRow.DataPropertyName = "CRow";
            this.CRow.HeaderText = "行";
            this.CRow.Name = "CRow";
            // 
            // CColumn
            // 
            this.CColumn.DataPropertyName = "CColumn";
            this.CColumn.HeaderText = "列";
            this.CColumn.Name = "CColumn";
            // 
            // CIndex
            // 
            this.CIndex.DataPropertyName = "CIndex";
            this.CIndex.HeaderText = "Tab键顺序";
            this.CIndex.Name = "CIndex";
            // 
            // CMonitorField
            // 
            this.CMonitorField.DataPropertyName = "CMonitorField";
            this.CMonitorField.HeaderText = "关联字段";
            this.CMonitorField.Name = "CMonitorField";
            // 
            // CDefaultValue
            // 
            this.CDefaultValue.DataPropertyName = "CDefaultValue";
            this.CDefaultValue.HeaderText = "默认值";
            this.CDefaultValue.Name = "CDefaultValue";
            // 
            // CIsQuery
            // 
            this.CIsQuery.DataPropertyName = "CIsQuery";
            this.CIsQuery.HeaderText = "是否查询";
            this.CIsQuery.Name = "CIsQuery";
            this.CIsQuery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CIsQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CParamName
            // 
            this.CParamName.DataPropertyName = "CParamName";
            this.CParamName.HeaderText = "参数名";
            this.CParamName.Name = "CParamName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Insert,
            this.tsmi_AutoFill,
            this.tsmi_AutoSort});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // tsmi_Insert
            // 
            this.tsmi_Insert.Name = "tsmi_Insert";
            this.tsmi_Insert.Size = new System.Drawing.Size(122, 22);
            this.tsmi_Insert.Text = "插入";
            this.tsmi_Insert.Click += new System.EventHandler(this.tsmi_Insert_Click);
            // 
            // tsmi_AutoFill
            // 
            this.tsmi_AutoFill.Name = "tsmi_AutoFill";
            this.tsmi_AutoFill.Size = new System.Drawing.Size(122, 22);
            this.tsmi_AutoFill.Text = "填充";
            this.tsmi_AutoFill.Click += new System.EventHandler(this.tsmi_AutoFill_Click);
            // 
            // tsmi_AutoSort
            // 
            this.tsmi_AutoSort.Name = "tsmi_AutoSort";
            this.tsmi_AutoSort.Size = new System.Drawing.Size(122, 22);
            this.tsmi_AutoSort.Text = "顺序填充";
            this.tsmi_AutoSort.Click += new System.EventHandler(this.tsmi_AutoSort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_SaveQueConfig,
            this.tsmi_LoadQueConfig,
            this.tsmi_LoadIOConfig,
            this.tsmi_SaveIOConfig,
            this.tsmi_SaveControlConfig,
            this.tsmi_LoadControlConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_SaveQueConfig
            // 
            this.tsmi_SaveQueConfig.Name = "tsmi_SaveQueConfig";
            this.tsmi_SaveQueConfig.Size = new System.Drawing.Size(129, 20);
            this.tsmi_SaveQueConfig.Text = "保存查询界面配置(&S)";
            this.tsmi_SaveQueConfig.Click += new System.EventHandler(this.tsmi_SaveQueConfig_Click);
            // 
            // tsmi_LoadQueConfig
            // 
            this.tsmi_LoadQueConfig.Name = "tsmi_LoadQueConfig";
            this.tsmi_LoadQueConfig.Size = new System.Drawing.Size(129, 20);
            this.tsmi_LoadQueConfig.Text = "加载查询界面配置(&L)";
            this.tsmi_LoadQueConfig.Click += new System.EventHandler(this.tsmi_LoadQueConfig_Click);
            // 
            // tsmi_LoadIOConfig
            // 
            this.tsmi_LoadIOConfig.Name = "tsmi_LoadIOConfig";
            this.tsmi_LoadIOConfig.Size = new System.Drawing.Size(168, 20);
            this.tsmi_LoadIOConfig.Text = "加载增删修改查界面配置(&O)";
            this.tsmi_LoadIOConfig.Click += new System.EventHandler(this.tsmi_LoadIOConfig_Click);
            // 
            // tsmi_SaveIOConfig
            // 
            this.tsmi_SaveIOConfig.Name = "tsmi_SaveIOConfig";
            this.tsmi_SaveIOConfig.Size = new System.Drawing.Size(162, 20);
            this.tsmi_SaveIOConfig.Text = "保存增删修改查界面配置(&I)";
            this.tsmi_SaveIOConfig.Click += new System.EventHandler(this.tsmi_SaveIOConfig_Click);
            // 
            // tsmi_SaveControlConfig
            // 
            this.tsmi_SaveControlConfig.Name = "tsmi_SaveControlConfig";
            this.tsmi_SaveControlConfig.Size = new System.Drawing.Size(107, 20);
            this.tsmi_SaveControlConfig.Text = "保存控件配置(&A)";
            this.tsmi_SaveControlConfig.Click += new System.EventHandler(this.tsmi_SaveControlConfig_Click);
            // 
            // tsmi_LoadControlConfig
            // 
            this.tsmi_LoadControlConfig.Name = "tsmi_LoadControlConfig";
            this.tsmi_LoadControlConfig.Size = new System.Drawing.Size(106, 20);
            this.tsmi_LoadControlConfig.Text = "加载控件配置(&B)";
            this.tsmi_LoadControlConfig.Click += new System.EventHandler(this.tsmi_LoadControlConfig_Click);
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tab_Que);
            this.tab_Main.Controls.Add(this.tab_IO);
            this.tab_Main.Controls.Add(this.tab_Control);
            this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Main.Location = new System.Drawing.Point(0, 24);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(1236, 520);
            this.tab_Main.TabIndex = 1;
            // 
            // tab_Que
            // 
            this.tab_Que.Controls.Add(this.splitContainer1);
            this.tab_Que.Location = new System.Drawing.Point(4, 22);
            this.tab_Que.Name = "tab_Que";
            this.tab_Que.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Que.Size = new System.Drawing.Size(1228, 494);
            this.tab_Que.TabIndex = 0;
            this.tab_Que.Text = "生成查询界面";
            this.tab_Que.UseVisualStyleBackColor = true;
            // 
            // tab_IO
            // 
            this.tab_IO.Controls.Add(this.splitContainer4);
            this.tab_IO.Location = new System.Drawing.Point(4, 22);
            this.tab_IO.Name = "tab_IO";
            this.tab_IO.Padding = new System.Windows.Forms.Padding(3);
            this.tab_IO.Size = new System.Drawing.Size(1228, 494);
            this.tab_IO.TabIndex = 1;
            this.tab_IO.Text = "生成增删修改查界面";
            this.tab_IO.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Size = new System.Drawing.Size(1222, 488);
            this.splitContainer4.SplitterDistance = 168;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.tec_IOCode);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tec_IODesigner);
            this.splitContainer5.Size = new System.Drawing.Size(168, 488);
            this.splitContainer5.SplitterDistance = 244;
            this.splitContainer5.TabIndex = 0;
            // 
            // tec_IOCode
            // 
            this.tec_IOCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tec_IOCode.IsReadOnly = false;
            this.tec_IOCode.Location = new System.Drawing.Point(0, 0);
            this.tec_IOCode.Name = "tec_IOCode";
            this.tec_IOCode.Size = new System.Drawing.Size(168, 244);
            this.tec_IOCode.TabIndex = 0;
            // 
            // tec_IODesigner
            // 
            this.tec_IODesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tec_IODesigner.IsReadOnly = false;
            this.tec_IODesigner.Location = new System.Drawing.Point(0, 0);
            this.tec_IODesigner.Name = "tec_IODesigner";
            this.tec_IODesigner.Size = new System.Drawing.Size(168, 240);
            this.tec_IODesigner.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.txt_datatable);
            this.splitContainer6.Panel1.Controls.Add(this.btn_grid_auto);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_InitEnvironment);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_InitEnvironment);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_ReFillWorkFiled);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_ReFillWorkFiled);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_dgvdict);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_dgvdict);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_DelRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_DelRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_UpdRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_UpdRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_AddRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_AddRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_QueRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_QueRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_DelRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_DelRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_UpdRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_UpdRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_AddRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_AddRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_QueRightBit);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_QueRequestType);
            this.splitContainer6.Panel1.Controls.Add(this.btn_io_AutoCode);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_FormName);
            this.splitContainer6.Panel1.Controls.Add(this.lb_io_NameSpace);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_NameSpace);
            this.splitContainer6.Panel1.Controls.Add(this.txt_io_FormName);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dgv_io);
            this.splitContainer6.Size = new System.Drawing.Size(1050, 488);
            this.splitContainer6.SplitterDistance = 135;
            this.splitContainer6.TabIndex = 0;
            // 
            // txt_datatable
            // 
            this.txt_datatable.Location = new System.Drawing.Point(896, 50);
            this.txt_datatable.Name = "txt_datatable";
            this.txt_datatable.Size = new System.Drawing.Size(139, 21);
            this.txt_datatable.TabIndex = 26;
            // 
            // btn_grid_auto
            // 
            this.btn_grid_auto.Location = new System.Drawing.Point(960, 75);
            this.btn_grid_auto.Name = "btn_grid_auto";
            this.btn_grid_auto.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_auto.TabIndex = 25;
            this.btn_grid_auto.Text = "表格生成";
            this.btn_grid_auto.UseVisualStyleBackColor = true;
            this.btn_grid_auto.Click += new System.EventHandler(this.btn_grid_auto_Click);
            // 
            // txt_io_InitEnvironment
            // 
            this.txt_io_InitEnvironment.Location = new System.Drawing.Point(554, 104);
            this.txt_io_InitEnvironment.Name = "txt_io_InitEnvironment";
            this.txt_io_InitEnvironment.Size = new System.Drawing.Size(324, 21);
            this.txt_io_InitEnvironment.TabIndex = 24;
            // 
            // lb_io_InitEnvironment
            // 
            this.lb_io_InitEnvironment.AutoSize = true;
            this.lb_io_InitEnvironment.Location = new System.Drawing.Point(452, 107);
            this.lb_io_InitEnvironment.Name = "lb_io_InitEnvironment";
            this.lb_io_InitEnvironment.Size = new System.Drawing.Size(95, 12);
            this.lb_io_InitEnvironment.TabIndex = 23;
            this.lb_io_InitEnvironment.Text = "InitEnvironment";
            // 
            // txt_io_ReFillWorkFiled
            // 
            this.txt_io_ReFillWorkFiled.Location = new System.Drawing.Point(114, 104);
            this.txt_io_ReFillWorkFiled.Name = "txt_io_ReFillWorkFiled";
            this.txt_io_ReFillWorkFiled.Size = new System.Drawing.Size(315, 21);
            this.txt_io_ReFillWorkFiled.TabIndex = 24;
            // 
            // lb_io_ReFillWorkFiled
            // 
            this.lb_io_ReFillWorkFiled.AutoSize = true;
            this.lb_io_ReFillWorkFiled.Location = new System.Drawing.Point(12, 107);
            this.lb_io_ReFillWorkFiled.Name = "lb_io_ReFillWorkFiled";
            this.lb_io_ReFillWorkFiled.Size = new System.Drawing.Size(95, 12);
            this.lb_io_ReFillWorkFiled.TabIndex = 23;
            this.lb_io_ReFillWorkFiled.Text = "ReFillWorkFiled";
            // 
            // txt_io_dgvdict
            // 
            this.txt_io_dgvdict.Location = new System.Drawing.Point(554, 20);
            this.txt_io_dgvdict.Name = "txt_io_dgvdict";
            this.txt_io_dgvdict.Size = new System.Drawing.Size(481, 21);
            this.txt_io_dgvdict.TabIndex = 5;
            // 
            // lb_io_dgvdict
            // 
            this.lb_io_dgvdict.AutoSize = true;
            this.lb_io_dgvdict.Location = new System.Drawing.Point(470, 23);
            this.lb_io_dgvdict.Name = "lb_io_dgvdict";
            this.lb_io_dgvdict.Size = new System.Drawing.Size(77, 12);
            this.lb_io_dgvdict.TabIndex = 4;
            this.lb_io_dgvdict.Text = "表格数据字典";
            // 
            // lb_io_DelRightBit
            // 
            this.lb_io_DelRightBit.AutoSize = true;
            this.lb_io_DelRightBit.Location = new System.Drawing.Point(700, 80);
            this.lb_io_DelRightBit.Name = "lb_io_DelRightBit";
            this.lb_io_DelRightBit.Size = new System.Drawing.Size(71, 12);
            this.lb_io_DelRightBit.TabIndex = 20;
            this.lb_io_DelRightBit.Text = "DelRightBit";
            // 
            // lb_io_DelRequestType
            // 
            this.lb_io_DelRequestType.AutoSize = true;
            this.lb_io_DelRequestType.Location = new System.Drawing.Point(682, 53);
            this.lb_io_DelRequestType.Name = "lb_io_DelRequestType";
            this.lb_io_DelRequestType.Size = new System.Drawing.Size(89, 12);
            this.lb_io_DelRequestType.TabIndex = 12;
            this.lb_io_DelRequestType.Text = "DelRequestType";
            // 
            // lb_io_UpdRightBit
            // 
            this.lb_io_UpdRightBit.AutoSize = true;
            this.lb_io_UpdRightBit.Location = new System.Drawing.Point(476, 80);
            this.lb_io_UpdRightBit.Name = "lb_io_UpdRightBit";
            this.lb_io_UpdRightBit.Size = new System.Drawing.Size(71, 12);
            this.lb_io_UpdRightBit.TabIndex = 18;
            this.lb_io_UpdRightBit.Text = "UpdRightBit";
            // 
            // lb_io_UpdRequestType
            // 
            this.lb_io_UpdRequestType.AutoSize = true;
            this.lb_io_UpdRequestType.Location = new System.Drawing.Point(458, 53);
            this.lb_io_UpdRequestType.Name = "lb_io_UpdRequestType";
            this.lb_io_UpdRequestType.Size = new System.Drawing.Size(89, 12);
            this.lb_io_UpdRequestType.TabIndex = 10;
            this.lb_io_UpdRequestType.Text = "UpdRequestType";
            // 
            // lb_io_AddRightBit
            // 
            this.lb_io_AddRightBit.AutoSize = true;
            this.lb_io_AddRightBit.Location = new System.Drawing.Point(251, 80);
            this.lb_io_AddRightBit.Name = "lb_io_AddRightBit";
            this.lb_io_AddRightBit.Size = new System.Drawing.Size(71, 12);
            this.lb_io_AddRightBit.TabIndex = 16;
            this.lb_io_AddRightBit.Text = "AddRightBit";
            // 
            // lb_io_AddRequestType
            // 
            this.lb_io_AddRequestType.AutoSize = true;
            this.lb_io_AddRequestType.Location = new System.Drawing.Point(233, 53);
            this.lb_io_AddRequestType.Name = "lb_io_AddRequestType";
            this.lb_io_AddRequestType.Size = new System.Drawing.Size(89, 12);
            this.lb_io_AddRequestType.TabIndex = 8;
            this.lb_io_AddRequestType.Text = "AddRequestType";
            // 
            // lb_io_QueRightBit
            // 
            this.lb_io_QueRightBit.AutoSize = true;
            this.lb_io_QueRightBit.Location = new System.Drawing.Point(36, 80);
            this.lb_io_QueRightBit.Name = "lb_io_QueRightBit";
            this.lb_io_QueRightBit.Size = new System.Drawing.Size(71, 12);
            this.lb_io_QueRightBit.TabIndex = 14;
            this.lb_io_QueRightBit.Text = "QueRightBit";
            // 
            // lb_io_QueRequestType
            // 
            this.lb_io_QueRequestType.AutoSize = true;
            this.lb_io_QueRequestType.Location = new System.Drawing.Point(18, 50);
            this.lb_io_QueRequestType.Name = "lb_io_QueRequestType";
            this.lb_io_QueRequestType.Size = new System.Drawing.Size(89, 12);
            this.lb_io_QueRequestType.TabIndex = 6;
            this.lb_io_QueRequestType.Text = "QueRequestType";
            // 
            // txt_io_DelRightBit
            // 
            this.txt_io_DelRightBit.Location = new System.Drawing.Point(778, 77);
            this.txt_io_DelRightBit.Name = "txt_io_DelRightBit";
            this.txt_io_DelRightBit.Size = new System.Drawing.Size(100, 21);
            this.txt_io_DelRightBit.TabIndex = 21;
            // 
            // txt_io_DelRequestType
            // 
            this.txt_io_DelRequestType.Location = new System.Drawing.Point(778, 50);
            this.txt_io_DelRequestType.Name = "txt_io_DelRequestType";
            this.txt_io_DelRequestType.Size = new System.Drawing.Size(100, 21);
            this.txt_io_DelRequestType.TabIndex = 13;
            // 
            // txt_io_UpdRightBit
            // 
            this.txt_io_UpdRightBit.Location = new System.Drawing.Point(554, 77);
            this.txt_io_UpdRightBit.Name = "txt_io_UpdRightBit";
            this.txt_io_UpdRightBit.Size = new System.Drawing.Size(100, 21);
            this.txt_io_UpdRightBit.TabIndex = 19;
            // 
            // txt_io_UpdRequestType
            // 
            this.txt_io_UpdRequestType.Location = new System.Drawing.Point(554, 50);
            this.txt_io_UpdRequestType.Name = "txt_io_UpdRequestType";
            this.txt_io_UpdRequestType.Size = new System.Drawing.Size(100, 21);
            this.txt_io_UpdRequestType.TabIndex = 11;
            // 
            // txt_io_AddRightBit
            // 
            this.txt_io_AddRightBit.Location = new System.Drawing.Point(329, 77);
            this.txt_io_AddRightBit.Name = "txt_io_AddRightBit";
            this.txt_io_AddRightBit.Size = new System.Drawing.Size(100, 21);
            this.txt_io_AddRightBit.TabIndex = 17;
            // 
            // txt_io_AddRequestType
            // 
            this.txt_io_AddRequestType.Location = new System.Drawing.Point(329, 50);
            this.txt_io_AddRequestType.Name = "txt_io_AddRequestType";
            this.txt_io_AddRequestType.Size = new System.Drawing.Size(100, 21);
            this.txt_io_AddRequestType.TabIndex = 9;
            // 
            // txt_io_QueRightBit
            // 
            this.txt_io_QueRightBit.Location = new System.Drawing.Point(114, 77);
            this.txt_io_QueRightBit.Name = "txt_io_QueRightBit";
            this.txt_io_QueRightBit.Size = new System.Drawing.Size(100, 21);
            this.txt_io_QueRightBit.TabIndex = 15;
            // 
            // txt_io_QueRequestType
            // 
            this.txt_io_QueRequestType.Location = new System.Drawing.Point(114, 47);
            this.txt_io_QueRequestType.Name = "txt_io_QueRequestType";
            this.txt_io_QueRequestType.Size = new System.Drawing.Size(100, 21);
            this.txt_io_QueRequestType.TabIndex = 7;
            // 
            // btn_io_AutoCode
            // 
            this.btn_io_AutoCode.Location = new System.Drawing.Point(960, 101);
            this.btn_io_AutoCode.Name = "btn_io_AutoCode";
            this.btn_io_AutoCode.Size = new System.Drawing.Size(75, 24);
            this.btn_io_AutoCode.TabIndex = 22;
            this.btn_io_AutoCode.Text = "代码生成";
            this.btn_io_AutoCode.UseVisualStyleBackColor = true;
            this.btn_io_AutoCode.Click += new System.EventHandler(this.btn_io_AutoCode_Click);
            // 
            // lb_io_FormName
            // 
            this.lb_io_FormName.AutoSize = true;
            this.lb_io_FormName.Location = new System.Drawing.Point(66, 23);
            this.lb_io_FormName.Name = "lb_io_FormName";
            this.lb_io_FormName.Size = new System.Drawing.Size(41, 12);
            this.lb_io_FormName.TabIndex = 0;
            this.lb_io_FormName.Text = "窗体名";
            // 
            // lb_io_NameSpace
            // 
            this.lb_io_NameSpace.AutoSize = true;
            this.lb_io_NameSpace.Location = new System.Drawing.Point(269, 23);
            this.lb_io_NameSpace.Name = "lb_io_NameSpace";
            this.lb_io_NameSpace.Size = new System.Drawing.Size(53, 12);
            this.lb_io_NameSpace.TabIndex = 2;
            this.lb_io_NameSpace.Text = "命名空间";
            // 
            // txt_io_NameSpace
            // 
            this.txt_io_NameSpace.Location = new System.Drawing.Point(329, 20);
            this.txt_io_NameSpace.Name = "txt_io_NameSpace";
            this.txt_io_NameSpace.Size = new System.Drawing.Size(100, 21);
            this.txt_io_NameSpace.TabIndex = 3;
            // 
            // txt_io_FormName
            // 
            this.txt_io_FormName.Location = new System.Drawing.Point(114, 20);
            this.txt_io_FormName.Name = "txt_io_FormName";
            this.txt_io_FormName.Size = new System.Drawing.Size(100, 21);
            this.txt_io_FormName.TabIndex = 1;
            // 
            // dgv_io
            // 
            this.dgv_io.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_io.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIOName,
            this.CIOLabelName,
            this.CIODigit,
            this.CIODictCode,
            this.CIODomain,
            this.CIOReadOnly,
            this.CIOType,
            this.CIOIsRealtimeSynchronous,
            this.CIObjectDataType,
            this.CIsInQue,
            this.CQueRow,
            this.CQueColumn,
            this.CQueIndex,
            this.CIsInIO,
            this.CIORow,
            this.CIOColumn,
            this.CIOIndex,
            this.CIOMonitorField,
            this.CIODefaultValue,
            this.CIOIsQuery,
            this.CIOIsAdd,
            this.CIOIsUpdate,
            this.CIOIsDelete,
            this.CIOParamName});
            this.dgv_io.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_io.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_io.Location = new System.Drawing.Point(0, 0);
            this.dgv_io.Name = "dgv_io";
            this.dgv_io.RowTemplate.Height = 23;
            this.dgv_io.Size = new System.Drawing.Size(1050, 349);
            this.dgv_io.TabIndex = 0;
            // 
            // CIOName
            // 
            this.CIOName.DataPropertyName = "CIOName";
            this.CIOName.HeaderText = "控件名称";
            this.CIOName.Name = "CIOName";
            // 
            // CIOLabelName
            // 
            this.CIOLabelName.DataPropertyName = "CIOLabelName";
            this.CIOLabelName.HeaderText = "Label名称";
            this.CIOLabelName.Name = "CIOLabelName";
            // 
            // CIODigit
            // 
            this.CIODigit.DataPropertyName = "CIODigit";
            this.CIODigit.HeaderText = "小数位数";
            this.CIODigit.Name = "CIODigit";
            this.CIODigit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CIODigit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CIODictCode
            // 
            this.CIODictCode.DataPropertyName = "CIODictCode";
            this.CIODictCode.HeaderText = "数据字典";
            this.CIODictCode.Name = "CIODictCode";
            // 
            // CIODomain
            // 
            this.CIODomain.DataPropertyName = "CIODomain";
            this.CIODomain.HeaderText = "Domain";
            this.CIODomain.Name = "CIODomain";
            // 
            // CIOReadOnly
            // 
            this.CIOReadOnly.DataPropertyName = "CIOReadOnly";
            this.CIOReadOnly.HeaderText = "ReadOnly";
            this.CIOReadOnly.Name = "CIOReadOnly";
            // 
            // CIOType
            // 
            this.CIOType.DataPropertyName = "CIOType";
            this.CIOType.HeaderText = "控件类型";
            this.CIOType.Name = "CIOType";
            // 
            // CIOIsRealtimeSynchronous
            // 
            this.CIOIsRealtimeSynchronous.DataPropertyName = "CIOIsRealtimeSynchronous";
            this.CIOIsRealtimeSynchronous.HeaderText = "是否实时同步";
            this.CIOIsRealtimeSynchronous.Name = "CIOIsRealtimeSynchronous";
            this.CIOIsRealtimeSynchronous.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CIOIsRealtimeSynchronous.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CIObjectDataType
            // 
            this.CIObjectDataType.DataPropertyName = "CIObjectDataType";
            this.CIObjectDataType.HeaderText = "WorkField数据类型";
            this.CIObjectDataType.Name = "CIObjectDataType";
            // 
            // CIsInQue
            // 
            this.CIsInQue.DataPropertyName = "CIsInQue";
            this.CIsInQue.HeaderText = "是否显示在Que界面";
            this.CIsInQue.Name = "CIsInQue";
            // 
            // CQueRow
            // 
            this.CQueRow.DataPropertyName = "CQueRow";
            this.CQueRow.HeaderText = "Que界面行";
            this.CQueRow.Name = "CQueRow";
            // 
            // CQueColumn
            // 
            this.CQueColumn.DataPropertyName = "CQueColumn";
            this.CQueColumn.HeaderText = "Que界面列";
            this.CQueColumn.Name = "CQueColumn";
            // 
            // CQueIndex
            // 
            this.CQueIndex.DataPropertyName = "CQueIndex";
            this.CQueIndex.HeaderText = "Tab键顺序(Que)";
            this.CQueIndex.Name = "CQueIndex";
            // 
            // CIsInIO
            // 
            this.CIsInIO.DataPropertyName = "CIsInIO";
            this.CIsInIO.HeaderText = "是否显示在IO界面";
            this.CIsInIO.Name = "CIsInIO";
            // 
            // CIORow
            // 
            this.CIORow.DataPropertyName = "CIORow";
            this.CIORow.HeaderText = "IO界面行";
            this.CIORow.Name = "CIORow";
            // 
            // CIOColumn
            // 
            this.CIOColumn.DataPropertyName = "CIOColumn";
            this.CIOColumn.HeaderText = "IO界面列";
            this.CIOColumn.Name = "CIOColumn";
            // 
            // CIOIndex
            // 
            this.CIOIndex.DataPropertyName = "CIOIndex";
            this.CIOIndex.HeaderText = "Tab键顺序(IO)";
            this.CIOIndex.Name = "CIOIndex";
            // 
            // CIOMonitorField
            // 
            this.CIOMonitorField.DataPropertyName = "CIOMonitorField";
            this.CIOMonitorField.HeaderText = "关联字段";
            this.CIOMonitorField.Name = "CIOMonitorField";
            // 
            // CIODefaultValue
            // 
            this.CIODefaultValue.DataPropertyName = "CIODefaultValue";
            this.CIODefaultValue.HeaderText = "默认值";
            this.CIODefaultValue.Name = "CIODefaultValue";
            // 
            // CIOIsQuery
            // 
            this.CIOIsQuery.DataPropertyName = "CIOIsQuery";
            this.CIOIsQuery.HeaderText = "是否查询";
            this.CIOIsQuery.Name = "CIOIsQuery";
            this.CIOIsQuery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CIOIsQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CIOIsAdd
            // 
            this.CIOIsAdd.DataPropertyName = "CIOIsAdd";
            this.CIOIsAdd.HeaderText = "是否增加";
            this.CIOIsAdd.Name = "CIOIsAdd";
            // 
            // CIOIsUpdate
            // 
            this.CIOIsUpdate.DataPropertyName = "CIOIsUpdate";
            this.CIOIsUpdate.HeaderText = "是否更新";
            this.CIOIsUpdate.Name = "CIOIsUpdate";
            // 
            // CIOIsDelete
            // 
            this.CIOIsDelete.DataPropertyName = "CIOIsDelete";
            this.CIOIsDelete.HeaderText = "是否删除";
            this.CIOIsDelete.Name = "CIOIsDelete";
            // 
            // CIOParamName
            // 
            this.CIOParamName.DataPropertyName = "CIOParamName";
            this.CIOParamName.HeaderText = "参数名";
            this.CIOParamName.Name = "CIOParamName";
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.splitContainer7);
            this.tab_Control.Location = new System.Drawing.Point(4, 22);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Control.Size = new System.Drawing.Size(1228, 494);
            this.tab_Control.TabIndex = 2;
            this.tab_Control.Text = "生成控件代码";
            this.tab_Control.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.tec_ControlCode);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer7.Size = new System.Drawing.Size(1222, 488);
            this.splitContainer7.SplitterDistance = 168;
            this.splitContainer7.TabIndex = 1;
            // 
            // tec_ControlCode
            // 
            this.tec_ControlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tec_ControlCode.IsReadOnly = false;
            this.tec_ControlCode.Location = new System.Drawing.Point(0, 0);
            this.tec_ControlCode.Name = "tec_ControlCode";
            this.tec_ControlCode.Size = new System.Drawing.Size(168, 488);
            this.tec_ControlCode.TabIndex = 0;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.button1);
            this.splitContainer9.Panel1.Controls.Add(this.txt_dgvfield);
            this.splitContainer9.Panel1.Controls.Add(this.lb_dgvfield);
            this.splitContainer9.Panel1.Controls.Add(this.chb_CIsOneMonitorField);
            this.splitContainer9.Panel1.Controls.Add(this.btn_control_AutoCode);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.dgv_control);
            this.splitContainer9.Size = new System.Drawing.Size(1050, 488);
            this.splitContainer9.SplitterDistance = 48;
            this.splitContainer9.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_dgvfield
            // 
            this.txt_dgvfield.Location = new System.Drawing.Point(244, 14);
            this.txt_dgvfield.Name = "txt_dgvfield";
            this.txt_dgvfield.Size = new System.Drawing.Size(247, 21);
            this.txt_dgvfield.TabIndex = 2;
            // 
            // lb_dgvfield
            // 
            this.lb_dgvfield.AutoSize = true;
            this.lb_dgvfield.Location = new System.Drawing.Point(179, 17);
            this.lb_dgvfield.Name = "lb_dgvfield";
            this.lb_dgvfield.Size = new System.Drawing.Size(59, 12);
            this.lb_dgvfield.TabIndex = 1;
            this.lb_dgvfield.Text = "表格Field";
            // 
            // chb_CIsOneMonitorField
            // 
            this.chb_CIsOneMonitorField.AutoSize = true;
            this.chb_CIsOneMonitorField.Checked = true;
            this.chb_CIsOneMonitorField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_CIsOneMonitorField.Location = new System.Drawing.Point(16, 16);
            this.chb_CIsOneMonitorField.Name = "chb_CIsOneMonitorField";
            this.chb_CIsOneMonitorField.Size = new System.Drawing.Size(126, 16);
            this.chb_CIsOneMonitorField.TabIndex = 0;
            this.chb_CIsOneMonitorField.Text = "IsOneMonitorField";
            this.chb_CIsOneMonitorField.UseVisualStyleBackColor = true;
            // 
            // btn_control_AutoCode
            // 
            this.btn_control_AutoCode.Location = new System.Drawing.Point(506, 11);
            this.btn_control_AutoCode.Name = "btn_control_AutoCode";
            this.btn_control_AutoCode.Size = new System.Drawing.Size(75, 24);
            this.btn_control_AutoCode.TabIndex = 3;
            this.btn_control_AutoCode.Text = "代码生成";
            this.btn_control_AutoCode.UseVisualStyleBackColor = true;
            this.btn_control_AutoCode.Click += new System.EventHandler(this.btn_control_AutoCode_Click);
            // 
            // dgv_control
            // 
            this.dgv_control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCIOName,
            this.CCIOLabelName,
            this.CCText,
            this.CCIODigit,
            this.CCIODictCode,
            this.CCIODomain,
            this.CCReadOnly,
            this.CCEnable,
            this.CCIOType,
            this.CCIOIsRealtimeSynchronous,
            this.CCIObjectDataType,
            this.CPreTag,
            this.CCRow,
            this.CCColumn,
            this.CCIndex,
            this.CCIOMonitorField,
            this.CCIODefaultValue,
            this.CCIOParamName,
            this.CControl,
            this.CKSWorkViewCommandRequest,
            this.CFieldName});
            this.dgv_control.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_control.Location = new System.Drawing.Point(0, 0);
            this.dgv_control.Name = "dgv_control";
            this.dgv_control.RowTemplate.Height = 23;
            this.dgv_control.Size = new System.Drawing.Size(1050, 436);
            this.dgv_control.TabIndex = 0;
            // 
            // CCIOName
            // 
            this.CCIOName.HeaderText = "控件名称";
            this.CCIOName.Name = "CCIOName";
            // 
            // CCIOLabelName
            // 
            this.CCIOLabelName.HeaderText = "Label名称";
            this.CCIOLabelName.Name = "CCIOLabelName";
            // 
            // CCText
            // 
            this.CCText.HeaderText = "Text";
            this.CCText.Name = "CCText";
            // 
            // CCIODigit
            // 
            this.CCIODigit.HeaderText = "小数位数";
            this.CCIODigit.Name = "CCIODigit";
            this.CCIODigit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCIODigit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CCIODictCode
            // 
            this.CCIODictCode.HeaderText = "数据字典";
            this.CCIODictCode.Name = "CCIODictCode";
            // 
            // CCIODomain
            // 
            this.CCIODomain.HeaderText = "Domain";
            this.CCIODomain.Name = "CCIODomain";
            // 
            // CCReadOnly
            // 
            this.CCReadOnly.HeaderText = "ReadOnly";
            this.CCReadOnly.Name = "CCReadOnly";
            // 
            // CCEnable
            // 
            this.CCEnable.HeaderText = "Enable";
            this.CCEnable.Name = "CCEnable";
            // 
            // CCIOType
            // 
            this.CCIOType.HeaderText = "控件类型";
            this.CCIOType.Name = "CCIOType";
            // 
            // CCIOIsRealtimeSynchronous
            // 
            this.CCIOIsRealtimeSynchronous.HeaderText = "是否实时同步";
            this.CCIOIsRealtimeSynchronous.Name = "CCIOIsRealtimeSynchronous";
            this.CCIOIsRealtimeSynchronous.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCIOIsRealtimeSynchronous.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CCIObjectDataType
            // 
            this.CCIObjectDataType.HeaderText = "WorkField数据类型";
            this.CCIObjectDataType.Name = "CCIObjectDataType";
            // 
            // CPreTag
            // 
            this.CPreTag.HeaderText = "前缀";
            this.CPreTag.Name = "CPreTag";
            // 
            // CCRow
            // 
            this.CCRow.HeaderText = "行";
            this.CCRow.Name = "CCRow";
            // 
            // CCColumn
            // 
            this.CCColumn.HeaderText = "列";
            this.CCColumn.Name = "CCColumn";
            // 
            // CCIndex
            // 
            this.CCIndex.HeaderText = "Tab键顺序";
            this.CCIndex.Name = "CCIndex";
            // 
            // CCIOMonitorField
            // 
            this.CCIOMonitorField.HeaderText = "关联字段";
            this.CCIOMonitorField.Name = "CCIOMonitorField";
            // 
            // CCIODefaultValue
            // 
            this.CCIODefaultValue.HeaderText = "默认值";
            this.CCIODefaultValue.Name = "CCIODefaultValue";
            // 
            // CCIOParamName
            // 
            this.CCIOParamName.HeaderText = "参数名";
            this.CCIOParamName.Name = "CCIOParamName";
            // 
            // CControl
            // 
            this.CControl.HeaderText = "父控件名";
            this.CControl.Name = "CControl";
            // 
            // CKSWorkViewCommandRequest
            // 
            this.CKSWorkViewCommandRequest.HeaderText = "KSWorkViewCommandRequest";
            this.CKSWorkViewCommandRequest.Name = "CKSWorkViewCommandRequest";
            // 
            // CFieldName
            // 
            this.CFieldName.HeaderText = "FieldName";
            this.CFieldName.Name = "CFieldName";
            // 
            // txt_que_InitEnvironment
            // 
            this.txt_que_InitEnvironment.Location = new System.Drawing.Point(111, 52);
            this.txt_que_InitEnvironment.Name = "txt_que_InitEnvironment";
            this.txt_que_InitEnvironment.Size = new System.Drawing.Size(324, 21);
            this.txt_que_InitEnvironment.TabIndex = 26;
            // 
            // lb_que_InitEnvironment
            // 
            this.lb_que_InitEnvironment.AutoSize = true;
            this.lb_que_InitEnvironment.Location = new System.Drawing.Point(10, 55);
            this.lb_que_InitEnvironment.Name = "lb_que_InitEnvironment";
            this.lb_que_InitEnvironment.Size = new System.Drawing.Size(95, 12);
            this.lb_que_InitEnvironment.TabIndex = 25;
            this.lb_que_InitEnvironment.Text = "InitEnvironment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 544);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "代码自动生成器（亲，给好评哦！）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_que)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_Main.ResumeLayout(false);
            this.tab_Que.ResumeLayout(false);
            this.tab_IO.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_io)).EndInit();
            this.tab_Control.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_que_FormName;
        private System.Windows.Forms.TextBox txt_que_FormName;
        private System.Windows.Forms.Label lb_que_NameSpace;
        private System.Windows.Forms.TextBox txt_que_NameSpace;
        private System.Windows.Forms.Button btn_AutoCode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ICSharpCode.TextEditor.TextEditorControl tec_QueCode;
        private ICSharpCode.TextEditor.TextEditorControl tec_QueDesigner;
        private System.Windows.Forms.Label lb_que_RequestType;
        private System.Windows.Forms.TextBox txt_que_RequestType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveQueConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LoadQueConfig;
        private System.Windows.Forms.DataGridView dgv_que;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tab_Que;
        private System.Windows.Forms.TabPage tab_IO;
        private System.Windows.Forms.Label lb_que_dgvdict;
        private System.Windows.Forms.TextBox txt_que_dgvdict;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private ICSharpCode.TextEditor.TextEditorControl tec_IOCode;
        private ICSharpCode.TextEditor.TextEditorControl tec_IODesigner;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveIOConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LoadIOConfig;
        private System.Windows.Forms.Button btn_io_AutoCode;
        private System.Windows.Forms.Label lb_io_FormName;
        private System.Windows.Forms.Label lb_io_NameSpace;
        private System.Windows.Forms.TextBox txt_io_NameSpace;
        private System.Windows.Forms.TextBox txt_io_FormName;
        private System.Windows.Forms.DataGridView dgv_io;
        private System.Windows.Forms.TextBox txt_io_dgvdict;
        private System.Windows.Forms.Label lb_io_dgvdict;
        private System.Windows.Forms.Label lb_io_DelRequestType;
        private System.Windows.Forms.Label lb_io_UpdRequestType;
        private System.Windows.Forms.Label lb_io_AddRequestType;
        private System.Windows.Forms.Label lb_io_QueRequestType;
        private System.Windows.Forms.TextBox txt_io_DelRequestType;
        private System.Windows.Forms.TextBox txt_io_UpdRequestType;
        private System.Windows.Forms.TextBox txt_io_AddRequestType;
        private System.Windows.Forms.TextBox txt_io_QueRequestType;
        private System.Windows.Forms.Label lb_io_DelRightBit;
        private System.Windows.Forms.Label lb_io_UpdRightBit;
        private System.Windows.Forms.Label lb_io_AddRightBit;
        private System.Windows.Forms.Label lb_io_QueRightBit;
        private System.Windows.Forms.TextBox txt_io_DelRightBit;
        private System.Windows.Forms.TextBox txt_io_UpdRightBit;
        private System.Windows.Forms.TextBox txt_io_AddRightBit;
        private System.Windows.Forms.TextBox txt_io_QueRightBit;
        private System.Windows.Forms.TabPage tab_Control;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private ICSharpCode.TextEditor.TextEditorControl tec_ControlCode;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Button btn_control_AutoCode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveControlConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LoadControlConfig;
        private System.Windows.Forms.DataGridView dgv_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomain;
        private System.Windows.Forms.DataGridViewComboBoxColumn CReadOnly;
        private System.Windows.Forms.DataGridViewComboBoxColumn CType;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIsRealtimeSynchronous;
        private System.Windows.Forms.DataGridViewComboBoxColumn CObjectDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMonitorField;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDefaultValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIsQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CParamName;
        private System.Windows.Forms.CheckBox chb_CIsOneMonitorField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIOName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIOLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIODigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIODictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIODomain;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCReadOnly;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCEnable;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCIOType;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCIOIsRealtimeSynchronous;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCIObjectDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPreTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIOMonitorField;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIODefaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCIOParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKSWorkViewCommandRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFieldName;
        private System.Windows.Forms.TextBox txt_dgvfield;
        private System.Windows.Forms.Label lb_dgvfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIODigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIODictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIODomain;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOReadOnly;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOType;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOIsRealtimeSynchronous;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIObjectDataType;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIsInQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQueRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQueIndex;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIsInIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIORow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOMonitorField;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIODefaultValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOIsQuery;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOIsAdd;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOIsUpdate;
        private System.Windows.Forms.DataGridViewComboBoxColumn CIOIsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIOParamName;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AutoFill;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AutoSort;
        private System.Windows.Forms.TextBox txt_io_InitEnvironment;
        private System.Windows.Forms.Label lb_io_InitEnvironment;
        private System.Windows.Forms.TextBox txt_io_ReFillWorkFiled;
        private System.Windows.Forms.Label lb_io_ReFillWorkFiled;
        private System.Windows.Forms.TextBox txt_datatable;
        private System.Windows.Forms.Button btn_grid_auto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_que_InitEnvironment;
        private System.Windows.Forms.Label lb_que_InitEnvironment;
    }
}

