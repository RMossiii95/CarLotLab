using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }
        //public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
        //{
        //    this.Make = Make;
        //    this.Model = Model;
        //    this.Year = Year;
        //    this.Price = Price;
        //    this.Mileage = Mileage;
        //}
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += $"(Used) {Mileage} miles";
            return output;
        }



    


    }

}
