using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
    public class Car
    {
        //Constructors
        //Default Constructor
        public Car() //- a speacial member method that has the same name as
        {

        }

        //public Car(string make, string model, int year)
        //{
        //    Make = make;
        //    Model = model;
        //    Year = year;
        //}

        //Fields
        //Properties
        //Methods

            //Create a Make property of type string that is public
        public string Make { get; set; } //get = read and set = write
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
