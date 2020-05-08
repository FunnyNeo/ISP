using System;
using System.Collections.Generic;
using Cars.Models;

namespace Cars
{
    public abstract class Car
    {
        public readonly string Name;
        public readonly Model CarModel;
        public readonly List<string> Colors;
        public readonly int HorsePower;
        public readonly string CarType;
        public readonly int Cost;

        protected List<string> ModelNames = new List<string>(
            new string[]
            {
                "Bmw",
                "Ford",
                "Ferrari",
                "Volkswagen",
                "Audi",
                "Opel",
                "Porsche"
            }
        );

        protected Car(string name, Model carModel, List<string> colors, int horsePower, string carType, int cost)
        {
            Name = name;
            CarModel = carModel;
            Colors = colors;
            HorsePower = horsePower;
            CarType = carType;
            Cost = cost;
        }

        public virtual void SlapRoof()
        {
            Console.WriteLine("This baby can hold so much horse power");
        }

        public override string ToString() =>
            $"Name: {Name}\nModel: {ModelNames[(int) CarModel]}\nColors: {String.Join(" ", Colors)}\nHorse Powers: {HorsePower}\nCar Type: {CarType}\nCost: {Cost}";
    }
}