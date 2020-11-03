using System;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // dot notation 
            Car myCar = new Car();
            myCar.Make = "Acura";
            myCar.Model = "RDX";
            myCar.Year = 2014;
            Console.WriteLine($"{myCar.Make}, {myCar.Model}, {myCar.Year}");

            //object initializer
            //var honda = new Car()
            //
            //    Make = "Honda",
            //    Model = "Civic",
            //    Year = 2010
            //};

            //Constructors
            //var ford = Car("Ford", "Explorer", 2003);
        }
    }
}
