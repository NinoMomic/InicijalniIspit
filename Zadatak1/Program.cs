using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;

            int x = a / b;
            int y = a % b;

            Console.WriteLine("a djeljeno sa b je: " + x + " a, ostatak je: " + y );
            Console.ReadKey();
        }
    }
}
