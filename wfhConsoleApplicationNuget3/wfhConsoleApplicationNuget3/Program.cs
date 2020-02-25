using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfhConsoleApplicationNuget3
{
    public class ProgramText
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(add(2, 3));
        }
        public static int add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}

