using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    class Program
    {
        static void Main(string[] args)
        {
            //start
            Console.WriteLine("How much money you want to withdraw:");
            int a = Convert.ToInt32(Console.ReadLine());
            int starot200 = 200;
            int starot100 = 100;
            int starot20 = 20;
            int starot5 = 5;
            int count200 = 0;
            int count100 = 0;
            int count20 = 0;
            int count5 = 0;

            if (a % 5 == 0)
            {
                while (a >= 200)

                {
                    a = (a - starot200);
                    count200++;
                }
                while (a < 200 && a >= 100)
                {
                    a = (a - starot100);
                    count100++;
                }
                while (a < 100 && a >= 20)
                {
                    a = (a - starot20);
                    count20++;
                }
                while (a < 20 && a >= 5)
                {
                    a = (a - starot5);
                    count5++;
                }
            }
            Console.WriteLine("stharot 200=" + count200);
            Console.WriteLine("stharot 100=" + count100);
            Console.WriteLine("stharot 20=" + count20);
            Console.WriteLine("stharot 5=" + count5);
        }

        //end
    }
}

