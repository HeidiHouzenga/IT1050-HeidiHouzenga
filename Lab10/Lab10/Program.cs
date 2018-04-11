using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };

            Console.Write("Fruits:");

            foreach (var element in fruits)
            {
                Console.WriteLine($" {element}");
            }



            //Question2
            var startsWithA =
                 from fruit in fruits
                 let uppercaseString = fruit.ToUpper()
                 where uppercaseString.StartsWith("A")
                 orderby uppercaseString
                 select uppercaseString;

            Console.Write("results of starts with A:");

            foreach (var item in startsWithA)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();



            //Question 3 
            var items = new List<string>();     //created list
            items.Add("July");
            items.Add("August");
            items.Add("September");
            items.Add("October");
            items.Add("November");
            items.Add("December");
            
                                            //Displayed count and capacity
            Console.WriteLine("Months:" + $"Count = {items.Count}; Capacity = {items.Capacity}");

            foreach (var item in items)
            {
               Console.WriteLine($" {item}");           //Displayed months
            }

            items.Insert(0, "January");             //insert first 6 months
            items.Insert(1, "February");
            items.Insert(2, "March");
            items.Insert(3, "April");
            items.Insert(4, "May");
            items.Insert(5, "June");

            Console.WriteLine("12 Months: ");   
                                                    //display all months
            foreach (var item in items)
            {
                Console.WriteLine($" {item}");
            }


            //Question4
            items.Remove("January");            //remove months
            items.Remove("February");
            items.Remove("March");
            items.Remove("April");
            items.Remove("May");
            items.Remove("June");
                                                //display count and capacity
            Console.WriteLine("Remove months: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

                                                //removing the first 6 months removes all months with ary
                                                //tested with n.Contains"er" to make sure code ran successfully
            var ending = items.Where (n => n.Contains ("ary"));

             foreach (var item in ending)
             {
                 Console.WriteLine($" {item}");
             }
        }
    }
}
