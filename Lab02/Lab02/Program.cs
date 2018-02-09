using System;

   class Addition
{
       static void Main()
       {
        int number2;
        int sum;

        Console.Write("enter first integer: ");
        //addition-question2
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer:  ");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"Sum is {sum}");

        //question 3
        Console.WriteLine("Solution to the expression (x+y)*(z+10) as x=1, y=2, and z=5");
        int x = 1;
        int y = 2;
        int z = 5;
        int solution;
        solution = ((x + y) * (z + 10));

        Console.WriteLine((x + y) * (z + 10));




        //question 4
        Console.WriteLine("Hello\tWorld");
        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("\"Hello World\"");
        Console.WriteLine("Hello\\World");
        }
}


