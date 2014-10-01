using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    enum Syntax { VB, CSC };
    class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] _con = {
                                      new ProgramConverter(),
                                      new ProgramHelper(),
                                      new ProgramHelper()
                                      };
            foreach(object s in _con)
            {
                Console.WriteLine("{0} = {1}",s.GetType(),((IConvertible)s).ConvertToSharp(""));
                Console.WriteLine("{0} = {1}", s.GetType(), ((IConvertible)s).ConvertToVB(""));
                Console.WriteLine("{0} = {1}", s.GetType(),(s is ICodeChecker)? "ICodeChecker":"null");
            }
            Console.ReadKey();
        }

    }
}
