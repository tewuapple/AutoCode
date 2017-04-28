using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Data.OracleClient;
using System.Configuration;

namespace AutoCode
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> objectDataType = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AutoCode_Click(object sender, EventArgs e)
        {
            Xml xml = new Xml(Path.Combine(Application.StartupPath, "template\\Control.xml"));
            string section = "Control";
            string init = string.Empty;
            string moddef = string.Empty;
            string control = string.Empty;
            string declear = string.Empty;
            string fieldParamBinding = string.Empty;
            string dgvdict = string.Empty;
            foreach (DataGridViewRow dgr in dgv_que.Rows)
            {
                if (dgr.Cells["CName"].Value != null)
                {
                    ControlParams cp = new ControlParams();
                    cp.CName = dgr.Cells["CName"].Value + "";
                    cp.CLabelName = dgr.Cells["CLabelName"].Value + "";
                    cp.CType = dgr.Cells["CType"].Value + "";
                    cp.CDigit = dgr.Cells["CDigit"].Value + "";
                    cp.CDictCode = dgr.Cells["CDictCode"].Value + "";
                    cp.CDomain = dgr.Cells["CDomain"].Value + "";
                    cp.CIsRealtimeSynchronous = dgr.Cells["CIsRealtimeSynchronous"].Value + "";
                    cp.CMonitorField = dgr.Cells["CMonitorField"].Value + "";
                    cp.CDefaultValue = dgr.Cells["CDefaultValue"].Value + "";
                    cp.CIsQuery = dgr.Cells["CIsQuery"].Value + "";
                    cp.CIsInQue = "1";
                    cp.CParamName = dgr.Cells["CParamName"].Value + "";
                    cp.CReadOnly = dgr.Cells["CReadOnly"].Value + "";
                    int crow, ccolumn, cindex;
                    int.TryParse(dgr.Cells["CRow"].Value + "", out crow);
                    int.TryParse(dgr.Cells["CColumn"].Value + "", out ccolumn);
                    int.TryParse(dgr.Cells["CIndex"].Value + "", out cindex);
                    cp.CRow = crow;
                    cp.CColumn = ccolumn;
                    cp.CIndex = cindex;
                    cp.CGroupIndex = "0";
                    AutoCodeParams acp = new AutoCodeParams();
                    acp.CXML = xml;
                    acp.CP = cp;
                    acp.CModDef = "panel_Main_Top";
                    acp.CPreTag = "que_";
                    acp.CSection = section;
                    string objectdatatye = dgr.Cells["CObjectDataType"].Value + "";
                    AutoCodeControl(dgr, cp, acp, objectdatatye, ref init, ref moddef, ref control, ref declear);
                    if (cp.CIsQuery == "1")
                    {
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, "ksWorkViewCRequest_Que", string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txt_que_dgvdict.Text))
            {
                string[] dgvdicts = txt_que_dgvdict.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string dgvcode in dgvdicts)
                {
                    string[] codes = dgvcode.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    init += string.Format(xml.GetValue(section, "InitDict").ToString(), codes[0]) + Environment.NewLine;
                    dgvdict += string.Format(xml.GetValue(section, "DgvDict").ToString(), codes[0], codes[1]) + Environment.NewLine;
                }
            }
            string InitEnvironment = string.Empty;
            if (!string.IsNullOrEmpty(txt_que_InitEnvironment.Text))
            {
                string[] initenvironments = txt_que_InitEnvironment.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string inits in initenvironments)
                {
                    string[] codes = inits.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    InitEnvironment += string.Format(xml.GetValue(section, "InitEnvironment").ToString(), codes[0], codes[1]) + Environment.NewLine;
                }
            }
            tec_QueCode.Text = string.Format(xml.GetValue(section, "QueCode").ToString(), txt_que_NameSpace.Text.Trim(), txt_que_FormName.Text.Trim(), InitEnvironment);
            tec_QueDesigner.Text = String.Format(xml.GetValue(section, "QueDesigner").ToString(), txt_que_NameSpace.Text, txt_que_FormName.Text, init, moddef, control, declear, txt_que_RequestType.Text, fieldParamBinding, dgvdict);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tec_QueCode.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            tec_QueDesigner.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            tec_IOCode.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            tec_IODesigner.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            tec_ControlCode.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            InitControlsCombobox();
            dgv_que.AutoGenerateColumns = false;
            dgv_io.AutoGenerateColumns = false;
            dgv_control.AutoGenerateColumns = false;
            this.tab_Main.SelectedTab = tab_Control;
        }

        /// <summary>
        /// 初始化控件类型下拉框
        /// </summary>
        private void InitControlsCombobox()
        {
            string controltype = ConfigAppSettings.GetValue("ControlType");
            string[] controls = controltype.Split('|');
            DataTable dt = new DataTable();
            dt.Columns.Add("key", typeof(string));
            dt.Columns.Add("value", typeof(string));
            for (int i = 0; i < controls.Length; i++)
            {
                dt.Rows.Add(i, controls[i]);
            }
            SetDGVComboBoxDataTable(CType, dt);
            SetDGVComboBoxDataTable(CIOType, dt);
            SetDGVComboBoxDataTable(CCIOType, dt);
            DataTable dt1 = dt.Clone();
            dt1.Rows.Add("0", "false");
            dt1.Rows.Add("1", "true");
            SetDGVComboBoxDataTable(CIsRealtimeSynchronous, dt1);
            SetDGVComboBoxDataTable(CIOIsRealtimeSynchronous, dt1);
            SetDGVComboBoxDataTable(CIsQuery, dt1);
            SetDGVComboBoxDataTable(CIOIsQuery, dt1);
            SetDGVComboBoxDataTable(CIOIsAdd, dt1);
            SetDGVComboBoxDataTable(CIOIsUpdate, dt1);
            SetDGVComboBoxDataTable(CIOIsDelete, dt1);
            SetDGVComboBoxDataTable(CIsInQue, dt1);
            SetDGVComboBoxDataTable(CIsInIO, dt1);
            SetDGVComboBoxDataTable(CCIOIsRealtimeSynchronous, dt1);
            SetDGVComboBoxDataTable(CReadOnly, dt1);
            SetDGVComboBoxDataTable(CIOReadOnly, dt1);
            SetDGVComboBoxDataTable(CCReadOnly, dt1);
            SetDGVComboBoxDataTable(CCEnable, dt1);
            string objectType = ConfigAppSettings.GetValue("ObjectType");
            string[] objectTypes = objectType.Split('|');
            DataTable dt2 = dt.Clone();
            for (int i = 0; i < objectTypes.Length; i++)
            {
                dt2.Rows.Add(i, objectTypes[i]);
                objectDataType.Add(i.ToString(), objectTypes[i]);
            }
            SetDGVComboBoxDataTable(CObjectDataType, dt2);
            SetDGVComboBoxDataTable(CIObjectDataType, dt2);
            SetDGVComboBoxDataTable(CCIObjectDataType, dt2);
        }

        private void SetDGVComboBoxDataTable(DataGridViewComboBoxColumn dgvc, DataTable dt)
        {
            dgvc.DataSource = dt;
            dgvc.ValueMember = "key";
            dgvc.DisplayMember = "value";
        }

        private void tsmi_SaveQueConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_Que;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                Xml xl = new Xml(sfd.FileName);
                string section = "Que";
                foreach (Control ctl in splitContainer2.Panel1.Controls)
                {
                    if (ctl is TextBox)
                    {
                        xl.SetValue(section, ctl.Name, ctl.Text);
                    }
                }

                DataTable dt = GetDgvToTable(dgv_que);
                StringWriter writer = new StringWriter();
                dt.WriteXml(writer);
                xl.SetValue(section, "DataTable", writer.ToString());
            }
        }

        /// <summary>
        /// 方法实现把dgv里的数据完整的复制到一张内存表
        /// </summary>
        /// <param name="dgv">dgv控件作为参数</param>
        /// <returns>返回临时内存表</returns>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable("DataTable");
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count - 1; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = dgv.Rows[count].Cells[countsub].Value + "";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void tsmi_LoadQueConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_Que;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                Xml xl = new Xml(ofd.FileName);
                string section = "Que";
                foreach (Control ctl in splitContainer2.Panel1.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = xl.GetValue(section, ctl.Name) + "";
                    }
                }
                string dt = xl.GetValue(section, "DataTable") + "";
                if (!string.IsNullOrEmpty(dt))
                {
                    StringReader reader = new StringReader(dt);
                    DataTable table = GetDgvToTable(dgv_que);
                    table.Rows.Clear();
                    table.ReadXml(reader);
                    CopyDataTableInDataGridView(table, dgv_que);
                }
            }
        }

         private void CopyDataTableInDataGridView(DataTable table, DataGridView dgv)
         {
             dgv.Rows.Clear();
             foreach (DataRow dr in table.Rows)
             {
                 dgv.Rows.Add(dr.ItemArray);
             }
         }

        private void tsmi_LoadIOConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_IO;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                Xml xl = new Xml(ofd.FileName);
                string section = "IO";
                foreach (Control ctl in splitContainer6.Panel1.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = xl.GetValue(section, ctl.Name) + "";
                    }
                }
                string dt = xl.GetValue(section, "DataTable") + "";
                if (!string.IsNullOrEmpty(dt))
                {
                    StringReader reader = new StringReader(dt);
                    DataTable table = GetDgvToTable(dgv_io);
                    table.Rows.Clear();
                    table.ReadXml(reader);
                    CopyDataTableInDataGridView(table, dgv_io);
                }
            }
        }

        private void tsmi_SaveIOConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_IO;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                Xml xl = new Xml(sfd.FileName);
                string section = "IO";
                foreach (Control ctl in splitContainer6.Panel1.Controls)
                {
                    if (ctl is TextBox)
                    {
                        xl.SetValue(section, ctl.Name, ctl.Text);
                    }
                }

                DataTable dt = GetDgvToTable(dgv_io);
                StringWriter writer = new StringWriter();
                dt.WriteXml(writer);
                xl.SetValue(section, "DataTable", writer.ToString());
            }
        }

        private void AutoCodeControl(DataGridViewRow dgr, ControlParams cp, AutoCodeParams acp,string objectdatatype, ref string init, ref string moddef, ref string control, ref string declear)
        {
            if (string.IsNullOrEmpty(cp.CFieldName) && objectDataType.ContainsKey(objectdatatype))
            {
                cp.CObjectDataType = objectDataType[objectdatatype];
                KSWorkFieldAutoCode kswf = new KSWorkFieldAutoCode(acp);
                kswf.Init(ref init);
                kswf.ModDef(ref moddef);
                kswf.ControlAutoCode(ref control);
                kswf.Declear(ref declear);
            }
            if (!string.IsNullOrEmpty(cp.CLabelName))
            {
                KmLabelAutoCode kml = new KmLabelAutoCode(acp);
                kml.Init(ref init);
                kml.ModDef(ref moddef);
                kml.ControlAutoCode(ref control);
                kml.Declear(ref declear);
            }
            if (!string.IsNullOrEmpty(cp.CType))
            {
                IAutoCode kac = null;
                switch (cp.CType)
                {
                    case "0":
                        kac = new KmCustomerTypeAutoCode(acp);
                        break;
                    case "1":
                        kac = new KmCustomerIDAutoCode(acp);
                        break;
                    case "2":
                        kac = new KmComboBoxAutoCode(acp);
                        break;
                    case "3":
                        kac = new KmCheckedListBoxAutoCode(acp);
                        break;
                    case "4":
                        kac = new KmTextBoxAutoCode(acp);
                        break;
                    case "5":
                        kac = new KmDateTextBoxAutoCode(acp);
                        break;
                    case "6":
                        kac = new KmNumericBoxAutoCode(acp);
                        break;
                    case "7":
                        kac = new KmGroupBoxAutoCode(acp);
                        break;
                    case "8":
                        kac = new KmCheckBoxAutoCode(acp);
                        break;
                    case "9":
                        kac = new KmButtonAutoCode(acp);
                        break;
                    case "10":
                        kac = new KmProgressBarAutoCode(acp);
                        break;
                }
                kac.Init(ref init);
                kac.ModDef(ref moddef);
                kac.ControlAutoCode(ref control);
                kac.Declear(ref declear);
            }
        }

        private void btn_io_AutoCode_Click(object sender, EventArgs e)
        {
            Xml xml = new Xml(Path.Combine(Application.StartupPath, "template\\Control.xml"));
            string section = "Control";
            string init = string.Empty;
            string moddef = string.Empty;
            string control = string.Empty;
            string declear = string.Empty;
            string fieldParamBinding = string.Empty;
            string KpControlsEnabledItem = string.Empty;
            string dgvdict = string.Empty;
            foreach (DataGridViewRow dgr in dgv_io.Rows)
            {
                if (dgr.Cells["CIOName"].Value != null)
                {
                    ControlParams cp = new ControlParams();
                    cp.CName = dgr.Cells["CIOName"].Value + "";
                    cp.CLabelName = dgr.Cells["CIOLabelName"].Value + "";
                    cp.CType = dgr.Cells["CIOType"].Value + "";
                    cp.CDigit = dgr.Cells["CIODigit"].Value + "";
                    cp.CDictCode = dgr.Cells["CIODictCode"].Value + "";
                    cp.CDomain = dgr.Cells["CIODomain"].Value + "";
                    cp.CIsRealtimeSynchronous = dgr.Cells["CIOIsRealtimeSynchronous"].Value + "";
                    cp.CMonitorField = dgr.Cells["CIOMonitorField"].Value + "";
                    cp.CDefaultValue = dgr.Cells["CIODefaultValue"].Value + "";
                    cp.CIsQuery = dgr.Cells["CIOIsQuery"].Value + "";
                    cp.CIOIsAdd = dgr.Cells["CIOIsAdd"].Value + "";
                    cp.CIOIsUpdate = dgr.Cells["CIOIsUpdate"].Value + "";
                    cp.CIOIsDelete = dgr.Cells["CIOIsDelete"].Value + "";
                    cp.CParamName = dgr.Cells["CIOParamName"].Value + "";
                    cp.CIsInQue = dgr.Cells["CIsInQue"].Value + "";
                    cp.CIsInIO = dgr.Cells["CIsInIO"].Value + "";
                    cp.CReadOnly = dgr.Cells["CIOReadOnly"].Value + "";
                    int cquerow, cquecolumn, cqueindex;
                    int.TryParse(dgr.Cells["CQueRow"].Value + "", out cquerow);
                    int.TryParse(dgr.Cells["CQueColumn"].Value + "", out cquecolumn);
                    int.TryParse(dgr.Cells["CQueIndex"].Value + "", out cqueindex);
                    cp.CRow = cquerow;
                    cp.CColumn = cquecolumn;
                    cp.CIndex = cqueindex;
                    AutoCodeParams acp = new AutoCodeParams();
                    acp.CXML = xml;
                    acp.CP = cp;
                    acp.CSection = section;
                    acp.CModDef = "tpMain_1_Top";
                    acp.CPreTag = "que_";
                    if (cp.CIsInQue == "1")
                    {
                        string objectdatatye = dgr.Cells["CIObjectDataType"].Value + "";
                        acp.CP.CGroupIndex = "0";
                        AutoCodeControl(dgr, cp, acp, objectdatatye, ref init, ref moddef, ref control, ref declear);
                    }
                    if (cp.CIsQuery == "1")
                    {
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, "ksWorkViewCRequest_Que", string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                    acp.CModDef = "tpMain_2_Fill";
                    acp.CPreTag = "io_";
                    int ciorow, ciocolumn, cioindex;
                    int.TryParse(dgr.Cells["CIORow"].Value + "", out ciorow);
                    int.TryParse(dgr.Cells["CIOColumn"].Value + "", out ciocolumn);
                    int.TryParse(dgr.Cells["CIOIndex"].Value + "", out cioindex);
                    cp.CRow = ciorow;
                    cp.CColumn = ciocolumn;
                    cp.CIndex = cioindex;
                    if (cp.CIsInIO == "1")
                    {
                        string objectdatatye = dgr.Cells["CIObjectDataType"].Value + "";
                        acp.CP.CGroupIndex = "2";
                        AutoCodeControl(dgr, cp, acp, objectdatatye, ref init, ref moddef, ref control, ref declear);
                    }
                    if (cp.CIOIsAdd == "1")
                    {
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, "ksWorkViewCRequest_Add", string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                    if (cp.CIOIsUpdate == "1")
                    {
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, "ksWorkViewCRequest_Upd", string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                    if (cp.CIOIsDelete == "1")
                    {
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, "ksWorkViewCRequest_Del", string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                    if (!string.IsNullOrEmpty(cp.CType) && cp.CIsInIO == "1" && cp.CIOIsUpdate != "1")
                    {
                        KpControlsEnabledItem += string.Format(xml.GetValue(section, "ModDefKpControlsEnabledItem").ToString(), acp.CPreTag + acp.CP.CName) + Environment.NewLine;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txt_io_dgvdict.Text))
            {
                string[] dgvdicts = txt_io_dgvdict.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string dgvcode in dgvdicts)
                {
                    string[] codes = dgvcode.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    init += string.Format(xml.GetValue(section, "InitDict").ToString(), codes[0]) + Environment.NewLine;
                    dgvdict += string.Format(xml.GetValue(section, "DgvDict").ToString(), codes[0], codes[1]) + Environment.NewLine;
                }
            }
            string reFillWorkFiled = string.Empty;
            if (!string.IsNullOrEmpty(txt_io_ReFillWorkFiled.Text))
            {
                string[] wfs = txt_io_ReFillWorkFiled.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string wf in wfs)
                {
                    reFillWorkFiled += string.Format(xml.GetValue(section, "ReFillWorkFiled").ToString(), wf) + Environment.NewLine;
                }
            }
            string InitEnvironment = string.Empty;
            if (!string.IsNullOrEmpty(txt_io_InitEnvironment.Text))
            {
                string[] initenvironments = txt_io_InitEnvironment.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string inits in initenvironments)
                {
                    string[] codes = inits.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    InitEnvironment += string.Format(xml.GetValue(section, "InitEnvironment").ToString(), codes[0], codes[1]) + Environment.NewLine;
                }
            }
            tec_IOCode.Text = string.Format(xml.GetValue(section, "InitControlCode").ToString(), txt_io_NameSpace.Text, txt_io_FormName.Text, reFillWorkFiled, InitEnvironment);
            tec_IODesigner.Text = string.Format(xml.GetValue(section, "InitControlDesigner").ToString(), txt_io_NameSpace.Text, txt_io_FormName.Text, init, moddef, control, declear, dgvdict, fieldParamBinding,
   txt_io_QueRequestType.Text,
   txt_io_AddRequestType.Text,
   txt_io_UpdRequestType.Text,
   txt_io_DelRequestType.Text,
   txt_io_QueRightBit.Text,
   txt_io_AddRightBit.Text,
   txt_io_UpdRightBit.Text,
   txt_io_DelRightBit.Text, KpControlsEnabledItem);
        }

        private void btn_control_AutoCode_Click(object sender, EventArgs e)
        {
            Xml xml = new Xml(Path.Combine(Application.StartupPath, "template\\Control.xml"));
            string section = "Control";
            string init = string.Empty;
            string moddef = string.Empty;
            string control = string.Empty;
            string declear = string.Empty;
            string fieldParamBinding = string.Empty;
            string reFillWorkFiled=string.Empty;
            string KpControlsEnabledItem = string.Empty;
            foreach (DataGridViewRow dgr in dgv_control.Rows)
            {
                if (dgr.Cells["CCIOName"].Value != null)
                {
                    ControlParams cp = new ControlParams();
                    cp.CName = dgr.Cells["CCIOName"].Value + "";
                    cp.CText = dgr.Cells["CCText"].Value + "";
                    cp.CLabelName = dgr.Cells["CCIOLabelName"].Value + "";
                    cp.CType = dgr.Cells["CCIOType"].Value + "";
                    cp.CDigit = dgr.Cells["CCIODigit"].Value + "";
                    cp.CDictCode = dgr.Cells["CCIODictCode"].Value + "";
                    cp.CDomain = dgr.Cells["CCIODomain"].Value + "";
                    cp.CIsRealtimeSynchronous = dgr.Cells["CCIOIsRealtimeSynchronous"].Value + "";
                    cp.CMonitorField = dgr.Cells["CCIOMonitorField"].Value + "";
                    cp.CDefaultValue = dgr.Cells["CCIODefaultValue"].Value + "";
                    cp.CParamName = dgr.Cells["CCIOParamName"].Value + "";
                    cp.CReadOnly = dgr.Cells["CCReadOnly"].Value + "";
                    cp.CEnable = dgr.Cells["CCEnable"].Value + "";
                    cp.CKSWorkViewCommandRequest = dgr.Cells["CKSWorkViewCommandRequest"].Value + "";
                    cp.CFieldName = dgr.Cells["CFieldName"].Value + "";
                    int cquerow, cquecolumn, cqueindex;
                    int.TryParse(dgr.Cells["CCRow"].Value + "", out cquerow);
                    int.TryParse(dgr.Cells["CCColumn"].Value + "", out cquecolumn);
                    int.TryParse(dgr.Cells["CCIndex"].Value + "", out cqueindex);
                    cp.CRow = cquerow;
                    cp.CColumn = cquecolumn;
                    cp.CIndex = cqueindex;
                    AutoCodeParams acp = new AutoCodeParams();
                    acp.CXML = xml;
                    acp.CP = cp;
                    acp.CP.CGroupIndex = "2";
                    acp.CIsOneMonitorField = chb_CIsOneMonitorField.Checked;
                    acp.CModDef = dgr.Cells["CControl"].Value + "";
                    acp.CPreTag = dgr.Cells["CPreTag"].Value + "";
                    acp.CSection = section;
                    string objectdatatye = dgr.Cells["CCIObjectDataType"].Value + "";
                    AutoCodeControl(dgr, cp, acp, objectdatatye, ref init, ref moddef, ref control, ref declear);
                    if (!string.IsNullOrEmpty(cp.CKSWorkViewCommandRequest))
                    {
                        fieldParamBinding += string.Format(acp.CXML.GetValue(acp.CSection, "InitFieldParamBinding").ToString(), acp.CPreTag + acp.CP.CName) + Environment.NewLine;
                        fieldParamBinding += string.Format(xml.GetValue(section, "fieldParamBinding").ToString(), acp.CPreTag + cp.CName, string.IsNullOrEmpty(cp.CParamName) ? cp.CName : cp.CParamName, cp.CKSWorkViewCommandRequest, string.IsNullOrEmpty(acp.CP.CFieldName) ? acp.CPreTag + acp.CP.CName : acp.CP.CFieldName) + Environment.NewLine;
                    }
                    reFillWorkFiled += string.Format(acp.CXML.GetValue(acp.CSection, "ReFillWorkFiled").ToString(), acp.CP.CName) + Environment.NewLine;
                }
            }
            tec_ControlCode.Text = string.Format(@"
            //init
{0}

            //moddef
{1}

            //control
{2}

            //fieldParamBinding
{3}

            //KpControlsEnabledItem
{4}

        //declear
{5}
        //ReFillWorkFiled
{6}
", init, moddef, control, fieldParamBinding, KpControlsEnabledItem, declear, reFillWorkFiled);
        }

        private void tsmi_LoadControlConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_Control;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                Xml xl = new Xml(ofd.FileName);
                string section = "Control";

                string dt = xl.GetValue(section, "DataTable") + "";
                if (!string.IsNullOrEmpty(dt))
                {
                    StringReader reader = new StringReader(dt);
                    DataTable table = GetDgvToTable(dgv_control);
                    table.Rows.Clear();
                    table.ReadXml(reader);
                    CopyDataTableInDataGridView(table, dgv_control);
                }
            }
        }

        private void tsmi_SaveControlConfig_Click(object sender, EventArgs e)
        {
            this.tab_Main.SelectedTab = tab_Control;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML文件|*.xml";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                Xml xl = new Xml(sfd.FileName);
                string section = "Control";

                DataTable dt = GetDgvToTable(dgv_control);
                StringWriter writer = new StringWriter();
                dt.WriteXml(writer);
                xl.SetValue(section, "DataTable", writer.ToString());
            }
        }

        private void tsmi_Insert_Click(object sender, EventArgs e)
        {
            switch(this.tab_Main.SelectedIndex)
            {
                case 0:
                    InsertDataGridViewRow(dgv_que);
                    break;
                case 1:
                    InsertDataGridViewRow(dgv_io);
                    break;
                case 2:
                    InsertDataGridViewRow(dgv_control);
                    break;
            }
        }

        private void InsertDataGridViewRow(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                dgv.Rows.Insert(dgv.CurrentRow.Index, 1);
            }
            else
            {
                MessageBox.Show("请选择要插入数据的行");
            }
        }

        private void AutoFill(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count == 0)
                return;
            string stemp = dgv.SelectedCells[0].Value.ToString();
            foreach (DataGridViewRow dgr in dgv.Rows)
            {
                dgr.Cells[dgv.SelectedCells[0].OwningColumn.Name].Value = stemp;
            }
        }

        private void tsmi_AutoFill_Click(object sender, EventArgs e)
        {
            switch (this.tab_Main.SelectedIndex)
            {
                case 0:
                    AutoFill(dgv_que);
                    break;
                case 1:
                    AutoFill(dgv_io);
                    break;
                case 2:
                    AutoFill(dgv_control);
                    break;
            }
        }

        private void AutoSort(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count == 0)
                return;
            foreach (DataGridViewRow dgr in dgv.Rows)
            {
                dgr.Cells[dgv.SelectedCells[0].OwningColumn.Name].Value = dgr.Index;
            }
        }

        private void tsmi_AutoSort_Click(object sender, EventArgs e)
        {
            switch (this.tab_Main.SelectedIndex)
            {
                case 0:
                    AutoSort(dgv_que);
                    break;
                case 1:
                    AutoSort(dgv_io);
                    break;
                case 2:
                    AutoSort(dgv_control);
                    break;
            }
        }

        private void btn_grid_auto_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connstr = string.Format("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
                config.AppSettings.Settings["HOST"].Value,
                config.AppSettings.Settings["PORT"].Value,
                config.AppSettings.Settings["SERVICE_NAME"].Value,
                config.AppSettings.Settings["ID"].Value,
                config.AppSettings.Settings["PASSWORD"].Value);
            using (OracleConnection conn = new OracleConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                string sql = string.Format(@"select a.column_name,
    case a.data_type 
    when 'VARCHAR2' then 
    'v' 
    when 'CHAR' then 
    'v' 
    when 'RAW' then 
    'v' 
    when 'NUMBER' then 
    'd' 
    end data_type,
    a.data_length,
    a.data_precision,
    a.data_scale,
    a.nullable,
    b.comments
    from all_tab_columns a left join all_col_comments b
    on a.owner=b.owner and a.table_name=b.table_name and a.column_name=b.column_name
    where a.owner = 'V8USER' and a.TABLE_NAME='{0}' order by a.column_id", txt_datatable.Text.Trim().ToUpper());
                DataTable dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                     }
                }
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_io.Rows.Add(dr["column_name"].ToString(), dr["comments"].ToString());
                    dgv_io.Rows.Add(dr["column_name"].ToString(), dr["comments"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintDialog myPrintDialog = new PrintDialog();
            myPrintDialog.AllowCurrentPage = false;
            myPrintDialog.AllowPrintToFile = false;
            myPrintDialog.AllowSelection = false;
            myPrintDialog.AllowSomePages = false;
            myPrintDialog.PrintToFile = false;
            myPrintDialog.ShowHelp = false;
            myPrintDialog.ShowNetwork = false;
            myPrintDialog.UseEXDialog = true;

            if (myPrintDialog.ShowDialog() != DialogResult.OK)
                return ;
        }

    }
}