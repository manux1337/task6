using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    interface IConvertible
    {
        string ConvertToSharp(string _code);
        string ConvertToVB(string _code);
    }
}
