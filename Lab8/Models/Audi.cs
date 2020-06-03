using System.Collections.Generic;

namespace Cars.Models
{
    public class Audi : Car
    {
        public Audi(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Audi, colors, horsePower, carType, cost)
        {
        }
    }
}