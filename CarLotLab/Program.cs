using System;

namespace CarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Used Car Lot!");
            CarLot cars = new CarLot();
            cars.UserMenu();
        }
    }
}
