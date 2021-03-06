﻿using System;

namespace OOP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Question 7
            int car1Speed = 20;
            int car2Speed = 0;
            Car car1 = new Car("Ford", "Focus", 2010, car1Speed);
            Car car2 = new Car("Chevy", "Cruze", 2018, car2Speed);

            for (int i = 0; i < 60; i++)
            {
                if (i % 2 == 0)
                {
                    car2Speed = car2.SpeedUp();
                }
                if (i % 3 == 0)
                {
                    car1Speed = car1.SpeedUp();
                }
                if (i % 5 == 0)
                {
                    car1Speed = car1.SlowDown();
                    car2Speed = car2.SlowDown();
                }
            }
            car1.Display();
            car2.Display();

        }

    }
     class Car      //Question 2
    {
        //Question 3
        private int Speed;
        private string Make;
        private string Model;
        private int Year;

        //Question 4
        public Car (string make, string model, int year, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = speed;
        }

        public Car (string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Speed = 0;
        }

                //Question 5
        public int SpeedUp()
        {
            Speed++;
            return Speed;
        }

        public int SlowDown()
        {

            if (Speed > 0)
             {
                Speed--;
             }
            return Speed;
        }

                      
                //Question6
        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }

            
    }
}
