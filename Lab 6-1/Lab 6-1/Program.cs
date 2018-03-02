using System;

namespace Lab_6_1
{
    class Program
    {
        static void Main()
        {
            int counter = 1;
            int year = 2018;
           
            while (counter <= 20)
            {

                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    ++counter;
                    Console.WriteLine(year);
                }

                ++year;
             
             }
          
          
        }
    }
}
