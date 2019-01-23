using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good
            //setup
            double miles = 0.0;
            double gallon = 0.0;
            double fuelEfficiency = 0.0;

            //input
            Console.WriteLine("Enter the miles travelled by car");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gallon of gas used.");
            gallon = double.Parse(Console.ReadLine());

            //process
            fuelEfficiency = miles / gallon;

            //output
            Console.WriteLine("Fuel effieciency for your car is " + fuelEfficiency + " mpg.");

            Console.ReadLine();
           
        }
    }
}
