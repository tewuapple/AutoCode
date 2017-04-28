using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public class AutoCodeParams
    {
        private ControlParams _cp;

        public ControlParams CP
        {
            get { return _cp; }
            set { _cp = value; }
        }

        private Xml _xml;

        public Xml CXML
        {
            get { return _xml; }
            set { _xml = value; }
        }

        private string _section;

        public string CSection
        {
            get { return _section; }
            set { _section = value; }
        }

        private string _pretag;

        public string CPreTag
        {
            get { return _pretag; }
            set { _pretag = value; }
        }

        private string _moddef;

        public string CModDef
        {
            get { return _moddef; }
            set { _moddef = value; }
        }

        private bool _isonemonitorfield;

        public bool CIsOneMonitorField
        {
            get { return _isonemonitorfield; }
            set { _isonemonitorfield = value; }
        }

    }
}
