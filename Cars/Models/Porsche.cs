using System.Collections.Generic;

namespace Cars.Models
{
    public class Porsche : Car
    {
        public Porsche(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Porsche, colors, horsePower, carType, cost)
        {
        }
    }
}