using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(13, 15);
            Fraction d = new Fraction("25/37");
            Fraction g = new Fraction(144, 13);
            Console.WriteLine($"{f} {f.AsFloat} {f.AsInt}");
            Console.WriteLine($"{d} {d.AsFloat} {d.AsInt}");
            Console.WriteLine($"{g} {g.AsFloat} {g.AsInt}");
            Console.WriteLine(f.Equals(d));
            Console.WriteLine(f.Equals(f));
            Console.WriteLine(f + d);
            Console.WriteLine(f - d);
            Console.WriteLine(f * d);
            Console.WriteLine(f / d);
            Console.WriteLine(f == d);
            Console.WriteLine(f != d);
            Console.WriteLine(f > d);
            Console.WriteLine(f < d);
            Console.ReadKey();
        }
    }
}