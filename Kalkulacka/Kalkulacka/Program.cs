using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double res;
            Console.Write("Zadejte první číslo: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            y = double.Parse(Console.ReadLine());
            res = x + y;
            Console.Clear();
            Console.WriteLine("_________________________________________");
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write("x");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write(x);
            Console.CursorLeft = Console.CursorLeft + 6;
            Console.Write("|");
            Console.WriteLine();
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write("y");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write(y);
            Console.CursorLeft = Console.CursorLeft + 6;
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("_________________________________________");
            Console.WriteLine();
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 5;
            Console.Write("Výsledek");
            Console.CursorLeft = Console.CursorLeft + 8;
            Console.Write("|");
            Console.CursorLeft = Console.CursorLeft + 10;
            Console.Write(res);
            Console.CursorLeft = Console.CursorLeft + 6;
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("_________________________________________");
            Console.WriteLine();
        }
    }
}
