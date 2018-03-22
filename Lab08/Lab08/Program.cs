using System;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(names[1]);
            Console.WriteLine(names[4]);
            Console.WriteLine();

            //Question2
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August",
                                                "September", "October", "November", "December"};
        
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine((i + 1) + months[i]);
            }
            Console.WriteLine();

            //Question3

            string[] seasons = {"Winter", "Spring", "Summer", "Autumn" };
          
             foreach (string season in seasons)
              {
                     Console.WriteLine(season);
              }
            Console.WriteLine();

            //Question 4
            Random RandomNumber = new Random();
            int[] randomNumber = new int[1000];

            for ( int i = 0; i<1000; i++)
            {
                randomNumber[i] = RandomNumber.Next(0, 1000);
            }

            foreach (int j in randomNumber)
            {
                Console.WriteLine(j);
             }
             Console.WriteLine();

            //Question5- had to change names to nameS because names is used in question1
           string[] nameS = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

           
           for (int i = 0; i < nameS.Length; i++)
           {
               Console.WriteLine(nameS[i]);
           }
            Console.WriteLine();
        }

    }
}
