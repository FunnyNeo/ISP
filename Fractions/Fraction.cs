using System;
using System.Linq;

namespace Fractions
{
    public class Fraction : IComparable
    {
        // Numerator
        public readonly int Num;
        // Denominator
        public readonly int Den;

        public Fraction(int num, int den)
        {
            if (den == 0)
                throw new DivideByZeroException();

            Num = num;
            Den = den;
        }

        public Fraction(string s)
        {
            /*
             * Regex re = new Regex(@"(?<Num>\d+)\/(?<Den>\d+)");
             * if (!re.IsMatch(s))
             *     throw new ArithmeticException();
             * Match = re.Match(s);
             * ...
             */
            if (!s.Contains('/') || s.Count(c => c == '/') != 1)
                throw new ArithmeticException("Not a rational number");
            string[] result = s.Split('/');
            foreach (var v in result)
            {
                if (!v.All(char.IsDigit))
                    throw new ArithmeticException("Not a rational number");
            }

            Num = int.Parse(result[0]);
            Den = int.Parse(result[1]);
        }

        public static explicit operator int(Fraction a) => a.AsInt;
        public static explicit operator float(Fraction a) => a.AsFloat;
        public static explicit operator decimal(Fraction a) => a.AsDecimal;

        public float AsFloat
        {
            get => (float)Num / Den;
        }
        public decimal AsDecimal
        {
            get => (decimal)Num / Den;
        }

        public int AsInt
        {
            get => Num / Den;
        }

        public override string ToString() => $"{Num}/{Den}";
        
        protected bool Equals(Fraction other)
        {
            return Num == other.Num && Den == other.Den;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Fraction) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Num, Den);
        }
        
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            Fraction otherFraction = obj as Fraction;
            if (otherFraction != null)
                return this.AsDecimal.CompareTo(otherFraction.AsDecimal);
            else
                throw new ArgumentException();
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Num, a.Den);

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);

        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.Num * b.Num, a.Den * b.Den);
        public static Fraction operator *(Fraction a, int b) => new Fraction(a.Num * b, a.Den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Num == 0)
                throw new DivideByZeroException();

            return new Fraction(a.Num * b.Den, a.Den * b.Num);
        }
        public static Fraction operator /(Fraction a, int b) => new Fraction(a.Num, a.Den * b);

        public static bool operator !=(Fraction a, Fraction b) => a.AsDecimal != b.AsDecimal;
        public static bool operator ==(Fraction a, Fraction b) => !(a != b);
        public static bool operator <(Fraction a, Fraction b) => a.AsDecimal < b.AsDecimal;
        public static bool operator >(Fraction a, Fraction b) => !(a < b);
        public static bool operator <=(Fraction a, Fraction b) => a.AsDecimal <= b.AsDecimal;
        public static bool operator >=(Fraction a, Fraction b) => !(a <= b);
    }
}