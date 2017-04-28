using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AutoCode
{
    public class KmNumericBoxAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KmNumericBoxAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode 成员

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKmNumericBox").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
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
            int digit = 0;
            if (int.TryParse(_acp.CP.CDigit, out digit))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KmNumericBox").ToString(), _acp.CPreTag + _acp.CP.CName,
                    _acp.CP.CDigit,
                    90 + _acp.CP.CColumn * 190,
                    12 + _acp.CP.CRow * 30,
                    2 * _acp.CP.CIndex + 1, string.Format("###,##0.{0}", "".PadLeft(digit,'0'))) + Environment.NewLine;
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
            else
            {
                MessageBox.Show("小数位数不是整型数据！");
            }
        }

        public void Declear(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKmNumericBox").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
