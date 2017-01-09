using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyVKonzoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej znak: ");
            Console.WriteLine($"Ascii kód zadaného znaku je: {(int)Char.Parse(Console.ReadLine())}");
            Console.Write("Zadej číslo: ");
            Console.WriteLine($"Zadanému ASCII kódu přísluší znak: {(char)int.Parse(Console.ReadLine())}");
            Console.ReadKey();
        }
    }
}
