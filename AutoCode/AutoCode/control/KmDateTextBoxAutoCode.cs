using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KmDateTextBoxAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmDateTextBoxAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode ≥…‘±

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKmDateTextBox").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            if (_acp.CP.CIsInIO == "1" && _acp.CP.CIOIsUpdate != "1")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKpControlsEnabledItem").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetModDef").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CModDef) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KmDateTextBox").ToString(), _acp.CPreTag + _acp.CP.CName,
                90 + _acp.CP.CColumn * 190,
                12 + _acp.CP.CRow * 30,
                2 * _acp.CP.CIndex + 1) + Environment.NewLine;
            if (_acp.CP.CReadOnly == "1")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetReadOnly").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
            if (_acp.CP.CEnable == "0")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetEnabled").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(_acp.CP.CFieldName) || !string.IsNullOrEmpty(_acp.CP.CObjectDataType))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "SetField").ToString(), _acp.CPreTag + _acp.CP.CName, string.IsNullOrEmpty(_acp.CP.CFieldName) ? _acp.CPreTag + _acp.CP.CName : _acp.CP.CFieldName) + Environment.NewLine;
            }
        }

        public void Declear(ref string code)
        {

            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKmDateTextBox").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
