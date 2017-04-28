using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KmLabelAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmLabelAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode ≥…‘±

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKmLabel").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModDefKmLabel").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CModDef) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KmLabel").ToString(), _acp.CPreTag + _acp.CP.CName,
                _acp.CP.CLabelName,
                40 + _acp.CP.CColumn * 190,
                15 + _acp.CP.CRow * 30,
                2 * _acp.CP.CIndex) + Environment.NewLine;
        }

        public void Declear(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKmLabel").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
