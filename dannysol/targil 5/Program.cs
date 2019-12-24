using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //start
            int secrate;
            int guess;
            int counte;
            counte = 0;

            Console.WriteLine("enter the secrat number:");
            string stringsecrat = Console.ReadLine();
            secrate = Convert.ToInt32(stringsecrat);

            Console.WriteLine("eneter the guess number:");
            string sttringguess = Console.ReadLine();
            guess = Convert.ToInt32(sttringguess);

            while (secrate != guess)
            {
                if (guess > secrate)
                {
                    Console.WriteLine("to big");
                    Console.WriteLine("guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("to small");
                    Console.WriteLine("guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                counte++;

            }
            Console.WriteLine("bingo!!");
            Console.Write("no of guesses:");
            Console.Write(counte);



     


              

            //end
        }
    }
}
