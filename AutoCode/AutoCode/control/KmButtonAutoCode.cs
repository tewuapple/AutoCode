using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KmButtonAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmButtonAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode ≥…‘±

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKmButton").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetModDef").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CModDef) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KmButton").ToString(), _acp.CPreTag + _acp.CP.CName,
                90 + _acp.CP.CColumn * 190,
                12 + _acp.CP.CRow * 30,
                2 * _acp.CP.CIndex + 1, _acp.CP.CText) + Environment.NewLine;
            if (_acp.CP.CEnable == "0")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetEnabled").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
        }

        public void Declear(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKmButton").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
