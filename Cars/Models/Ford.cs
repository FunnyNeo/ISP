using System.Collections.Generic;

namespace Cars.Models
{
    public class Ford : Car
    {
        public Ford(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Ford, colors, horsePower, carType, cost)
        {
        }
    }
}