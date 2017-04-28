using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCode
{
    public interface IAutoCode
    {
        void Init(ref string code);
        void ModDef(ref string code);
        void ControlAutoCode(ref string code);
        void Declear(ref string code);
    }
}
