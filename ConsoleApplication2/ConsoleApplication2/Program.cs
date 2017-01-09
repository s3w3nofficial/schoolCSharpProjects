using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "100 +  100";
            string test2 = "";
            test2 = test.Replace(' ', char.Parse(""));
        }
    }
}
