 using System;

namespace Lab07
{
    class TestMyMath
    {
        static void Main()
        {
            MyMath nerd = new MyMath();

            Console.WriteLine("Enter First Operand");
            double op1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Operand");
            double op2 = Convert.ToDouble(Console.ReadLine());

            nerd.Multiply(op1, op2);
            Console.WriteLine("Multiply result: " + nerd.GetResult());

            nerd.Divide(op1, op2);
            Console.WriteLine("Divide result: " + nerd.GetResult());

            nerd.Subtract(op1, op2);
            Console.WriteLine("Subtract result: " + nerd.GetResult());

            nerd.Add(op1, op2);
            Console.WriteLine("Add result: " + nerd.GetResult());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }

    class MyMath
    {
        double result;
        double operand1;
        double operand2;


        public void Multiply(double o1, double o2)
        {
            operand1 = o1;
            operand2 = o2;
            result = operand1 * operand2;
        }

        public void Divide(double o1, double o2)
        {
            operand1 = o1;
            operand2 = o2;
            result = operand1 / operand2;
        }

        public void Subtract(double o1, double o2)
        {
            operand1 = o1;
            operand2 = o2;
            result = operand1 - operand2;
        }

        public void Add(double o1, double o2)
        {
            operand1 = o1;
            operand2 = o2;
            result = operand1 + operand2;
        }

        public double GetResult()
        {
            return result;
        }
    }


}
