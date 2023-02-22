using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class GuessNumber
    {
        public void Solution()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine(correctNumber);
            Console.WriteLine("Please input a guess number:");
            int guessNumber = int.Parse(Console.ReadLine());

            if (correctNumber < guessNumber)
            {
                Console.WriteLine("You guess high");
                Console.WriteLine($"Hint: {correctNumber}");
            }
            else if (correctNumber > guessNumber)
            {
                Console.WriteLine("You guess low");
                Console.WriteLine($"Hint: {correctNumber}");
            }
            else if (guessNumber < 1 && guessNumber > 3)
            {
                Console.WriteLine("You guess out of the range. The correct number is between 1 and 3.");
            }


            while (correctNumber != guessNumber)
            {
                Console.WriteLine("Please input a guess number:");
                guessNumber = int.Parse(Console.ReadLine());
                if (correctNumber < guessNumber)
                {
                    Console.WriteLine("You guess high");
                    Console.WriteLine($"Hint: {correctNumber}");
                }
                else if (correctNumber > guessNumber)
                {
                    Console.WriteLine("You guess low");
                    Console.WriteLine($"Hint: {correctNumber}");
                }
                else if (guessNumber < 1 && guessNumber > 3)
                {
                    Console.WriteLine("You guess out of the range. The correct number is between 1 and 3.");
                }
            }

            Console.WriteLine("You guess the correct number!");

        }
    }
}
