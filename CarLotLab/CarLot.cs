using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarLot()
        {
            Cars.Add(new Car("Ford", "Fusion", 2021, 24000));
            Cars.Add(new Car("Chevy", "Cruise", 2021, 25000));
            Cars.Add(new Car("GM", "Hummer", 2021, 110000));

            Cars.Add(new UsedCar("Ford", "Tauras", 2005, 4000, 148000));
            Cars.Add(new UsedCar("Chevy", "Impala", 2001, 2000, 200000));
            Cars.Add(new UsedCar("Honda", "Civic", 2000, 1000, 300000));
        }
        public void AddNewCar(string Make, string Model, int Year, decimal Price)
        {
            Cars.Add(new Car(Make, Model, Year, Price));
        }
        public void AddUsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
        {
            Cars.Add(new UsedCar(Make, Model, Year, Price, Mileage));
        }
        public void PrintCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i+1}" + Cars[i]);
            }
        }
        public void RemoveCar(string Make, string Model, int Year)
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                if(Cars[i].Make == Make && Cars[i].Model == Model && Cars[i].Year == Year)
                {
                    Cars.RemoveAt(i);
                    break;
                }
            }
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public int GetInputInt(string prompt)
        {
            string response;
            int numResponse;
            while (true)
            {
                try
                {
                    response = GetInput(prompt);
                    numResponse = int.Parse(response);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer!");
                    continue;
                }
                
            }
            return numResponse;
        }
        public void UserMenu()
        {
            Console.WriteLine("Welcome to the car lot");
            while (true)
            {

                PrintCars();
                Console.WriteLine($"{Cars.Count + 1}. Add a car");
                Console.WriteLine($"{Cars.Count + 2}. Add a used car");
                Console.WriteLine($"{Cars.Count + 3}. Quit");
                int choice = GetInputInt("Which car would you like?");
                if (choice > 0 && choice <= Cars.Count)
                {
                    Console.WriteLine(Cars[choice - 1]);
                    var currentCar = Cars[choice - 1];
                    string response = GetInput("Would you like to buy this car?").ToLower();
                    if (response == "y")
                    {
                        Console.WriteLine("Excellent! Our finance department will be in touch shortly!");
                        RemoveCar(currentCar.Make, currentCar.Model, currentCar.Year);
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Please enter only a y or an n");
                    }
                }
                else if (choice == Cars.Count + 1)
                {
                    Console.WriteLine("Please enter information needed for the car: ");
                    string make = GetInput("Make:");
                    string model = GetInput("Model:");
                    int year = GetInputInt("Year: ");
                    int price = GetInputInt("Price: ");
                    AddNewCar(make, model, year, price);
                }
                else if (choice == Cars.Count + 2)
                {
                    Console.WriteLine("Please enter information needed for the car: ");
                    string make = GetInput("Make:");
                    string model = GetInput("Model:");
                    int year = GetInputInt("Year: ");
                    int price = GetInputInt("Price: ");
                    double mileage = GetInputInt("Mileage: ");
                    AddUsedCar(make, model, year, price, mileage);
                }
                else if (choice == Cars.Count + 3)
                {
                    break;
                }
            }
        }
    }



    
}
