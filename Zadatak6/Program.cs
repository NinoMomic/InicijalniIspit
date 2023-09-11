using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            double a = 3;
            double suma = 0;
            Console.WriteLine("Unesi broj clanova reda: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                suma=(1/a*3);
            }
            Console.WriteLine("Konačna suma niza je: "+suma);
            Console.ReadKey();
        }
    }
}
