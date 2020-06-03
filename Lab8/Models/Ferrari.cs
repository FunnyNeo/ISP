using System.Collections.Generic;

namespace Cars.Models
{
    public class Ferrari : Car
    {
        public Ferrari(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Ferrari, colors, horsePower, carType, cost)
        {
        }
    }
}