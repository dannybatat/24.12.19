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
            Random seed = new Random(); // black-box

            /*
            int num = seed.Next(1, 4); // bring a random number between 1-3
            if (num == 1)
            {
                Console.WriteLine("One");
            }
            else if (num == 2)
            {
                Console.WriteLine("Two");
            }
            else if (num == 3)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                // in case no option was matched
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }
            */
            /*
            // DO NOT 
            // Random seed2 = new Random(); // black-box

            int num2 = seed.Next(1, 15); // bring a random number between 1-14
            Console.WriteLine(num2);
            */
            int my_score = 0;
            int computer_score = 0;
            int round = 1;

            do
            {
                //Console.Clear();
                Console.WriteLine($"===================== ROUND #{round} ===================");
                int my_card = seed.Next(2, 15); // bring a random number between 1-14
                Console.WriteLine("My card: ");
                switch (my_card)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine(my_card);
                        break;
                    case 11:
                        Console.WriteLine("J");
                        break;
                    case 12:
                        Console.WriteLine("Q");
                        break;
                    case 13:
                        Console.WriteLine("K");
                        break;
                    case 14:
                        Console.WriteLine("A");
                        break;
                    // in case no option was matched
                    default:
                        Console.WriteLine("Something went wrong...");
                        break;
                }

                int computer_card = seed.Next(2, 15); // bring a random number between 1-14
                Console.WriteLine("Computer card: ");
                switch (computer_card)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine(computer_card);
                        break;
                    case 11:
                        Console.WriteLine("J");
                        break;
                    case 12:
                        Console.WriteLine("Q");
                        break;
                    case 13:
                        Console.WriteLine("K");
                        break;
                    case 14:
                        Console.WriteLine("A");
                        break;
                    // in case no option was matched
                    default:
                        Console.WriteLine("Something went wrong...");
                        break;
                }

                // who won?
                if (my_card > computer_card)
                {
                    // i won
                    my_score++;
                    Console.WriteLine("*** Player won!! ***");
                }
                else if (my_card == computer_card)
                {
                    Console.WriteLine("*** DRAW ***");
                }
                else
                {
                    // computer won
                    computer_score++;
                    Console.WriteLine("*** Computer won!! ***");
                }
                Console.WriteLine($"-- Player score: {my_score}");
                Console.WriteLine($"-- Computer score: {computer_score}");
                round++;

                Console.WriteLine("Press any key for next round . . .");
                Console.ReadLine();
            }
            while (my_score < 5 && computer_score < 5);

            if (my_score > computer_score)
            {
                Console.WriteLine("*********** Player won !!!");
            }
            else
            {
                Console.WriteLine("*********** Computer won !!!");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
