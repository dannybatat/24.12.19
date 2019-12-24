using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dannyproj
{
    class Program
    {
        static void Main(string[] args)
        {
            //start

            Console.WriteLine("enter 2 numberes pls");
            Console.WriteLine("eneter the first number:");
            int a;
            int b;
            string asab = Console.ReadLine();
            a = Convert.ToInt32(asab);
        
            Console.WriteLine("enter the secend number:");
            string basb = Console.ReadLine();
            b = Convert.ToInt32(basb);

            if (a % b == 0)  Console.WriteLine("a meyhalek em b");
            else  Console.WriteLine("a lo methalek be b");

           

            //end
        }
    }
}
