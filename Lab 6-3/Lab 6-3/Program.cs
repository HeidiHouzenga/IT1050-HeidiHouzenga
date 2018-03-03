using System;

namespace Lab_6_3
{
    class Program
    {
        static void Main()
        {
            string item;
            string allItems = "";
            decimal cost;
            decimal totalCost = 0;
            string input;
                      

            Console.Write("Please enter the next item: ");
            item =Console.ReadLine();

            Console.Write("Please enter the item cost: ");
            cost = decimal.Parse(Console.ReadLine());


            Console.Write("Press <enter> to continue, E to end: ");
            input = Console.ReadLine();

        while (input != "E")
        {
                allItems += item + "\n";
                totalCost += cost;
                Console.Write("Please enter the next item: ");
                item = Console.ReadLine();

                Console.Write("Please enter the item cost: ");
                cost = decimal.Parse(Console.ReadLine());


                Console.Write("Press <enter> to continue, E to end: ");
                input = Console.ReadLine();

            }

            allItems += item + "\n";
            totalCost += cost;

            Console.WriteLine("\n"  + "Grocery Items: ");
            Console.WriteLine(allItems + "\n");

            Console.WriteLine("Total Costs: " + totalCost);

        }
     }
}
