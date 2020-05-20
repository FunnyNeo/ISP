using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        public class Car
        {
            public string name;
            public string[] colors;
            public string model;
            public string carType;
            public int power;

            public Car(string name, string[] colors, string carType, int power)
            {
                this.name = name;
                this.colors = colors;
                this.model = model;
                this.carType = carType;
                this.power = power;
            }

            public Car()
            {
            }

            public override string ToString() =>
                $"Car: {this.model} {this.name}\nType: {this.carType}\nAvailable colors: {String.Join(" ", this.colors)}\nHorse Powers: {this.power}";
        }

        public class Cars : Car
        {
            public List<Car> Vehicles { get; } = new List<Car>();

            public Cars()
            {
            }

            public Cars(string name, string[] colors, string carType, int power) : base(name, colors, carType, power)
            {
            }

            public Car this[int index]
            {
                get => Vehicles[index];
            }

            public void Add(Car item)
            {
                Vehicles.Add(item);
            }

            public int Len
            {
                get => this.Vehicles.Count;
            }
        }

        private class Bmw : Car
        {
            public Bmw(string name, string[] colors, string carType, int power) : base(name, colors,
                carType, power)
            {
                this.model = "Bmw";
            }
        }

        private class Honda : Car
        {
            public Honda(string name, string[] colors, string carType, int power) : base(name, colors,
                carType, power)
            {
                this.model = "Honda";
            }
        }

        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Bmw car1 = new Bmw("Car1", new string[] { "White", "Yellow", "Black" }, "City", 560);
            Honda car2 = new Honda("Car2", new string[] { "White", "Green", "Black" }, "City", 480);
            cars.Add(car1);
            cars.Add(car2);

            for (int i = 0; i < cars.Len; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}