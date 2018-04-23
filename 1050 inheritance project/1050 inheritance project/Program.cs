using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050_inheritance_project
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCredit = 0.0M;
            SavingsAccount save = new SavingsAccount(12345.67M, 0.1M);

            Console.WriteLine("Starting Balance:  {0:C}", save.Balance);
            totalCredit = save.CalculateInterest();

            Console.WriteLine("Interest: {0:C}", totalCredit);

            //add credit to balance
            save.Credit(totalCredit);
            Console.WriteLine("Ending Balance: {0:C}", save.Balance);

            Console.WriteLine();

            //checking account fee
            CheckingAccount check = new CheckingAccount(12345.67M, 1.75M);
            Console.WriteLine("Starting balance: {0:C}", check.Balance);
            check.Credit(123.45M);
            check.Debit(1234.56M);
            Console.WriteLine("Ending balance: {0:C}", check.Balance);

            Console.ReadLine();
        }
    }
}
