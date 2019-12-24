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
            Console.WriteLine("How much to withdraw?");
            int cash = Convert.ToInt32(Console.ReadLine());

            int bill_200 = cash / 200;
            cash = cash % 200;
            int bill_100 = cash / 100;
            cash = cash % 100;
            int bill_50 = cash / 50;
            cash = cash % 50;
            int bill_20 = cash / 20;
            cash = cash % 20;
            int coin_5 = cash / 5;
            cash = cash % 5;
            int charity = cash;

            Console.WriteLine($"200 X {bill_200}\n100 X {bill_100}\n50 X {bill_50}\n20 X {bill_20}\n5-Coins X {coin_5}\nCharity {charity}");
            Console.WriteLine();

        }
    }
}
