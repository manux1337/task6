using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    class ProgramConverter:IConvertible
    {
        public string ConvertToSharp(string _code)
        {
            return "Encoded to C#";
        }

        public string ConvertToVB(string _code)
        {
            return "Encoded to VB";
        }
    }
}
