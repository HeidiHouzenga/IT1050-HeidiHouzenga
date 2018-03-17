using System;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*question 2*/
            int m = 2;

            while (m<= 128)
            {
                Console.WriteLine(" [{0}]", m);
                m= m*2;
             }

            /*question 3*/
            
            for (int k= 49; k >= 1; k--)
             {
                    if (k <= 1)
                    {
                        Console.Write(k + "");
                    }
                    else 
                    {
                     Console.Write(k + ",");
                     }
                 
             }

            Console.WriteLine();
           

            /*question 4*/
            int p = 0;
            while (p <= 0)
            {
                for (p = 1; p <= 22; p++)
                {
                    if (p % 2 != 0)
                    {
                        Console.Write(p + "   ");
                    }
                }

                Console.WriteLine();
            }


            /*question 5*/
            int n = 8;
            int i = 10;
            while (i < n)
            {
                Console.WriteLine("*");
                ++i;
             }
            /*A do-while statement checks the condition after it runs.  In contrast, a while statement runs first
                    and then checks after*/
            

                  

            /*question 6*/
            bool icyRain = false;
            bool tornadoWarning =false;

            if ((!icyRain && !tornadoWarning) || (!icyRain && !tornadoWarning));
            {
                Console.WriteLine("Let's go outside");
            }

         


            
            /*Extra Credit*/
          
            for (int x = 5; x >= 0; x--)
            {

                for (int b = x; b <= 5; b++)
                    Console.Write(" ");
                for (int j = 1; j <= x; j++)
                    Console.Write(j);
               
                for (int h = x-1; h> 0; h--)
                    Console.Write(h);
                           
                    Console.WriteLine();

            }
            
            

            /*question 1 needed to be placed at the end becuase it is an infinite loop
                     and the remaining program would not run if not*/
           bool keepLooping = true;
          
           while (keepLooping)
           {
               
           }
            
        }

       
    }
}
