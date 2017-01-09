using System;

namespace datoveTypyAKonverze
{
    class Program
    {
        static void Main(string[] args)
        {
            #region writeToConsole
            /*
            int num = 10;
            int num2 = num;
            Console.WriteLine("Hodnota num={0}; Hodnota num2={1}", num, num2);
            Console.WriteLine($"Hodnota num={num}; Hodnota num2={num2}");
            */
            #endregion


            int x = 10;
            int y = 10;
            object z = x*y;
            Console.WriteLine(typeof(z));
        }
    }
}
