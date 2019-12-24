using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //start 1-100
            for (int a = 1; a < 100; a++)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("targil aba");
            Console.WriteLine();

            //קפיצות של 2
            for (int i = 2; i <= 100; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("targil aba");
            Console.WriteLine();

            // 100-1
            for (int d = 100; d > 0; d = d-1)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("targil aba");
            Console.WriteLine();

            //תרגיל 3
            Console.WriteLine("eneter number");

            int h = Convert.ToInt32(Console.ReadLine());


            if (h <= 9)
            {
                Console.WriteLine("mespar hadsifrati");
            }
            else
            {
                Console.WriteLine("asharot=" + h / 10);
                Console.WriteLine("ahadot=" + h % 10);
            }
            if (h % 10 > h / 10)
            {
                Console.WriteLine("ahdot gdol yoter");
            }
            else
            {
                Console.WriteLine("ashrot gadol yoter");
            }

            //end



        }
    }
}
