using System;

namespace Lesson_18_12
{
    [DeveloperInfo("Shigina Arina", Date = "Today")]
    class Rational_numbers
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("К сожалению, на ноль делить нельзя");
                }
                else
                {
                    denominator = value;
                }
            }
        }
        public Rational_numbers(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Rational_numbers()
        {

        }
        public static bool operator ==(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator == (double)r2.Numerator / r2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator == (double)r2.Numerator / r2.Denominator)
            {
                return false;
            }
            return true;
        }
        public static bool operator >(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator > (double)r2.Numerator / r2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator < (double)r2.Numerator / r2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator >= (double)r2.Numerator / r2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Rational_numbers r1, Rational_numbers r2)
        {
            if ((double)r1.Numerator / r1.Denominator <= (double)r2.Numerator / r2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static Rational_numbers operator +(Rational_numbers r1, Rational_numbers r2)
        {
            Rational_numbers r3 = new Rational_numbers();
            r3.Numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            r3.Denominator = r1.Denominator * r2.Denominator;
            return r3;
        }
        public static Rational_numbers operator -(Rational_numbers r1, Rational_numbers r2)
        {
            Rational_numbers r3 = new Rational_numbers();
            r3.Numerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            r3.Denominator = r1.Denominator * r2.Denominator;
            return r3;
        }
        public static Rational_numbers operator *(Rational_numbers r1, Rational_numbers r2)
        {
            return new Rational_numbers(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }
        public static Rational_numbers operator /(Rational_numbers r1, Rational_numbers r2)
        {
            return new Rational_numbers(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }
        public static Rational_numbers operator %(Rational_numbers r1, Rational_numbers r2)
        {
            Rational_numbers r3 = new Rational_numbers();
            r3.Numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            r3.Denominator = r1.Denominator * r2.Denominator;
            return r3;
        }
        public static Rational_numbers operator ++(Rational_numbers r1)
        {
            return new Rational_numbers(r1.Numerator + r1.Denominator, r1.Denominator);
        }
        public static Rational_numbers operator --(Rational_numbers r1)
        {
            return new Rational_numbers(r1.Numerator - r1.Denominator, r1.Denominator);
        }
        public static implicit operator Rational_numbers(int x)
        {
            return new Rational_numbers(x, 1);
        }
        public static explicit operator int(Rational_numbers r)
        {
            return r.Numerator / r.Denominator;
        }
        public static explicit operator double(Rational_numbers r)
        {
            return (double)r.Numerator / r.Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Rational_numbers r1)
            {
                return r1 == this;
            }
            return base.Equals(obj);
        }
    }
}
