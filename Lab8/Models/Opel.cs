using System.Collections.Generic;

namespace Cars.Models
{
    public class Opel : Car
    {
        public Opel(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Opel, colors, horsePower, carType, cost)
        {
        }
    }
}