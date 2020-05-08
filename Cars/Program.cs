using System;
using System.Collections.Generic;
using Cars.Models;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Bmw("Bmw Car", new List<string>(new []{"black", "white"}), 250, "Offroad", 2500));
            cars.Add(new Ford("Ford Car", new List<string>(new []{"black", "white"}), 400, "City", 4500));
            cars.Add(new Ferrari("Ferrari Car", new List<string>(new []{"black", "white"}), 600, "City", 9500));
            cars.Add(new Volkswagen("Volkswagen Car", new List<string>(new []{"black", "white"}), 320, "Offroad", 3500));
            cars.Add(new Audi("Audi Car", new List<string>(new []{"black", "white"}), 300, "Offroad", 1500));
            cars.Add(new Opel("Opel Car", new List<string>(new []{"black", "white"}), 250, "City", 1500));
            cars.Add(new Porsche("Porsche Car", new List<string>(new []{"black", "white"}), 150, "City", 5500));

            foreach (Car c in cars)
            {
                c.SlapRoof();
                Console.WriteLine($"{c}\n");
            }
            Console.ReadKey();
        }
    }
}