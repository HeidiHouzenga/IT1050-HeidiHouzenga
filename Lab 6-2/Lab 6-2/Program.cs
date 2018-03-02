using System;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            bool run = false;
            int number = 22;
            int tries = 0;

            while (!run)
            {
                tries++;

                Console.WriteLine("Guess a number 1-100: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won!!!");
                    Console.WriteLine("Number of tries:  {0}", tries);
                    run = true;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too Large");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too Small");
                }
                
            }

           
        }
    }
}
