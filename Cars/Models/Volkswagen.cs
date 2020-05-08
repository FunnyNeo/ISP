using System.Collections.Generic;

namespace Cars.Models
{
    public class Volkswagen : Car
    {
        public Volkswagen(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Volkswagen, colors, horsePower, carType, cost)
        {
        }
    }
}