using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    interface ICodeChecker
    {
        bool CodeCheckSyntax(string _code, Syntax _syntax);
    }
}
