using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    class ProgramHelper:ProgramConverter,ICodeChecker
    {
        public bool CodeCheckSyntax(string _code,Syntax _syntax)
        {
            Console.WriteLine(_syntax);
            return false;
        }

    }
}
