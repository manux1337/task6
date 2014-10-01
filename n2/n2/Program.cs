using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace n2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream s = new MemoryStream();
            for (int i = 0; i < 100; i++)
            {   
                s.WriteByte((byte)i);
            }
            s.Position = 0;

            // Now read s into a byte buffer.
            byte[] bytes = new byte[s.Length];
            int numBytesToRead = (int)s.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                // Read may return anything from 0 to 10.
                int n = s.Read(bytes, numBytesRead, 10);
               
                // The end of the file is reached.
                if (n == 0)
                {
                    break;
                }
                Console.WriteLine();
                numBytesRead += n;
                numBytesToRead -= n;
            }
            s.Close();
            // numBytesToRead should be 0 now, and numBytesRead should
            // equal 100.
            Console.WriteLine("number of bytes read: {0}", numBytesRead);
            Console.ReadKey();
        }
    }
}
