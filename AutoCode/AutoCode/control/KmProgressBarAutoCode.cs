using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KmProgressBarAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmProgressBarAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode ≥…‘±

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKmProgressBar").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetModDef").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CModDef) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KmProgressBar").ToString(),
                                         _acp.CPreTag + _acp.CP.CName,
                                         90 + _acp.CP.CColumn * 190,
                                         12 + _acp.CP.CRow * 30,
                                         2 * _acp.CP.CIndex + 1) + Environment.NewLine;
        }

        public void Declear(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKmProgressBar").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
