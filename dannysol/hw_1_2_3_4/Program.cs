using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171219
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            Console.WriteLine("Result is: " + x + " + " + y + " = " + (x + y));
            Console.WriteLine($"Result is: {x} + {y} = {x + y}");

            // ============================ 1
            for (int i = 1; i <= 2000; i = i + 1)
            {
                // 1
                //Console.Write(i + " ");
                // 2
                Console.Write($"{i} ");
            }


            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.Write($"{i} ");
            }

            // ============================ 2
            for (int i = 100; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }

            // ============================ 3
            for (int i = 100; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }

            string input = Console.ReadLine(); // input string from keyboard
            int number1 = Convert.ToInt32(input);

            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 10 && number <= 99)
            {
                int asarot = number / 10;
                Console.WriteLine($"SIFRAT ASAROT: {asarot}");

                int ahadot = number % 10;
                Console.WriteLine($"SIFRAT AHADOT: {ahadot}");

                if (asarot > ahadot)
                {
                    Console.WriteLine("ASAROT is Bigger");
                }
                else
                {
                    Console.WriteLine("AHADOT is Bigger");
                }

                Console.WriteLine(asarot > ahadot ? $"{asarot}" : "AHADOT is Bigger");

                int z;
                if (number > 10)
                {
                    z = number;
                }
                else
                {
                    z = -5;
                }
                z = number > 10 ? number : -5;
            }

            // ============================ 4
            //int my_number = Convert.ToInt32(Console.ReadLine());

            for (int my_number = 2; my_number <= 100; my_number++)
            {
                int m = 2;
                while (m < my_number && my_number % m != 0)
                {
                    m++;
                }
                // 1 - first way
                if (m < my_number)
                {
                    continue;
                }
                Console.WriteLine($"{my_number} RISHONI");

                // 2 - second way
                //if (m >= my_number)
                //{
                //Console.WriteLine($"{my_number} RISHONI");
                //}

                //Console.WriteLine(m < my_number ? $"{my_number} LO RISHONI" : $"{my_number} RISHONI");
            }

        }
    }
}
