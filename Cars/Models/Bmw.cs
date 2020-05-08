using System;
using System.Collections.Generic;

namespace Cars.Models
{
    public class Bmw : Car
    {
        public Bmw(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Bmw, colors, horsePower, carType, cost)
        {
        }

        public override void SlapRoof()
        {
            Console.WriteLine($"This baby comes in {Colors.Count} colors");
        }
    }
}