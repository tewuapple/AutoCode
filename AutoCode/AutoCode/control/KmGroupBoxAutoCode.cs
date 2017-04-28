using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KmGroupBoxAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmGroupBoxAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode ≥…‘±

        public void Init(ref string code)
        {
            code += string.Format(@"            this.{0} = new KmNGTF.Controls.KmGroupBox();
                        this.{0}.SuspendLayout();", _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetModDef").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CModDef) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            if (_acp.CP.CEnable == "0")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetEnabled").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
            code += string.Format(@"            // 
            // {0}
            // 
            this.{0}.Field = null;
            this.{0}.Location = new System.Drawing.Point({1}, {2});
            this.{0}.Name = ""{0}"";
            this.{0}.RightBit = null;
            this.{0}.Size = new System.Drawing.Size(257, 48);
            this.{0}.TabIndex = {3};
            this.{0}.TabStop = false;
            this.{0}.Text = ""{4}"";
            this.{0}.ResumeLayout(false);
            this.{0}.PerformLayout();",
                                         _acp.CPreTag + _acp.CP.CName,
                                         90 + _acp.CP.CColumn * 190,
                                         12 + _acp.CP.CRow * 30,
                                         2 * _acp.CP.CIndex + 1,
                                         _acp.CP.CText) + Environment.NewLine;
        }

        public void Declear(ref string code)
        {
            code += string.Format("        private KmNGTF.Controls.KmGroupBox {0};", _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
