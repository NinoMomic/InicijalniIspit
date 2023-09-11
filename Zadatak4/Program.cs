using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            Console.WriteLine("Unesi prvu stranicu trokuta");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesi drugu stranicu trokuta");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesi trecu stranicu trokuta");
            z = Convert.ToInt32(Console.ReadLine());

            if(x+y>z & x+z>y & z+y>x)
                if(x>0 & y>0 & z>0)
                {
                    Console.WriteLine("Navedene vrijednosti jesu stranice trokuta");
                }
                else
                {
                    Console.WriteLine("Navedene vrijednosti nisu stranice trokuta");
                }
            Console.ReadKey();
        }
    }
}
