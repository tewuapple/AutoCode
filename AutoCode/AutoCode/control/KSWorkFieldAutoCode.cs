using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class KSWorkFieldAutoCode : IAutoCode
    {
        private AutoCodeParams _acp;

        public AutoCodeParams ACP
        {
            get { return _acp; }
            set { _acp = value; }
        }

        public KSWorkFieldAutoCode(AutoCodeParams acp)
        {
            _acp = acp;
        }

        #region IAutoCode 成员

        private void InitMonitorField(string monitorfield, ref string code)
        {
            if (!code.Contains("motitor_" + _acp.CPreTag + monitorfield))
            {
                code += InitMonitorField(monitorfield) + Environment.NewLine;
            }
        }

        private string InitMonitorField(string name)
        {
            return string.Format(_acp.CXML.GetValue(_acp.CSection, "InitMonitorField").ToString(), _acp.CPreTag + name);
        }

        public void Init(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitKSWorkField").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            if (!string.IsNullOrEmpty(_acp.CP.CDictCode))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitWFDict").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(_acp.CP.CMonitorField))
            {
                if (_acp.CP.CMonitorField.Contains(","))
                {
                    string[] CMonitorFields = _acp.CP.CMonitorField.Split(',');

                    foreach (string cmonitor in CMonitorFields)
                    {
                        if (_acp.CIsOneMonitorField)
                        {
                            string[] cmonitors = cmonitor.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            InitMonitorField(cmonitors[0],ref code);
                        }
                        else
                        {
                            InitMonitorField(cmonitor, ref code);
                        }
                    }
                }
                else
                {
                    if (_acp.CIsOneMonitorField)
                    {
                        string[] cmonitors = _acp.CP.CMonitorField.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        InitMonitorField(cmonitors[0], ref code);
                    }
                    else
                    {
                        InitMonitorField(_acp.CP.CMonitorField, ref code);
                    }
                }
            }
            if (_acp.CP.CIsQuery == "1" || _acp.CP.CIOIsAdd == "1" || _acp.CP.CIOIsUpdate == "1" || _acp.CP.CIOIsDelete == "1")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitFieldParamBinding").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
        }

        public void ModDef(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModDefKSWorkField").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        public void ControlAutoCode(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "KSWorkField").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CP.CObjectDataType, _acp.CP.CGroupIndex) + Environment.NewLine;
            //如果有数据字典选项
            if (!string.IsNullOrEmpty(_acp.CP.CDictCode))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "WFDict").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CP.CDictCode) + Environment.NewLine;
            }
            //如果有Domain选项
            if (!string.IsNullOrEmpty(_acp.CP.CDomain))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitDomain").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CP.CDomain) + Environment.NewLine;
            }
            //如果有实时同步选项
            if (_acp.CP.CIsRealtimeSynchronous == "1")
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitIsRealtimeSynchronous").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
            }
            //如果有默认值选项
            if (!string.IsNullOrEmpty(_acp.CP.CDefaultValue))
            {
                code += string.Format(_acp.CXML.GetValue(_acp.CSection, "InitDefaultValue").ToString(), _acp.CPreTag + _acp.CP.CName, _acp.CP.CDefaultValue) + Environment.NewLine;
            }
            //如果有关联字段选项
            if (!string.IsNullOrEmpty(_acp.CP.CMonitorField))
            {
                if (_acp.CP.CMonitorField.Contains(","))
                {
                    string[] CMonitorFields = _acp.CP.CMonitorField.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string cmonitor in CMonitorFields)
                    {
                        if (_acp.CIsOneMonitorField)
                        {
                            string[] cmonitors = cmonitor.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModeDefMonitorFields").ToString(), _acp.CPreTag + cmonitors[0], _acp.CPreTag + _acp.CP.CName, cmonitors[1]) + Environment.NewLine;
                        }
                        else
                            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModeDefMonitorFields").ToString(), _acp.CPreTag + cmonitor, _acp.CPreTag + _acp.CP.CName, string.IsNullOrEmpty(_acp.CP.CFieldName) ? _acp.CPreTag + cmonitor : _acp.CP.CFieldName) + Environment.NewLine;
                    }
                }
                else
                {
                    if (_acp.CIsOneMonitorField)
                    {
                        string[] cmonitors = _acp.CP.CMonitorField.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModeDefMonitorFields").ToString(), _acp.CPreTag + cmonitors[0], _acp.CPreTag + _acp.CP.CName, cmonitors[1]) + Environment.NewLine;
                    }
                    else
                        code += string.Format(_acp.CXML.GetValue(_acp.CSection, "ModeDefMonitorFields").ToString(), _acp.CPreTag + _acp.CP.CMonitorField, _acp.CPreTag + _acp.CP.CName, string.IsNullOrEmpty(_acp.CP.CFieldName) ? _acp.CPreTag + _acp.CP.CMonitorField : _acp.CP.CFieldName) + Environment.NewLine;
                }
            }
        }

        public void Declear(ref string code)
        {
            code += string.Format(_acp.CXML.GetValue(_acp.CSection, "DeclearKSWorkField").ToString(), _acp.CPreTag + _acp.CP.CName) + Environment.NewLine;
        }

        #endregion
    }
}
