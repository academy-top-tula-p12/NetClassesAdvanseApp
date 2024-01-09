using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    class Fraction
    {
        public int Numerator { set; get; }
        
        int denominator;
        public int Denominator
        {
            set
            {
                if (value != 0)
                    denominator = value;
                else 
                    throw new DivideByZeroException();
            }
            get => denominator;
        }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            if (denominator != 0)
                this.denominator = denominator;
            else
                throw new DivideByZeroException();
        }

        public Fraction Add(Fraction other)
        {
            this.Numerator = this.Numerator * other.denominator 
                            + this.denominator * other.Numerator;
            this.denominator *= other.denominator;
            return this;
        }

        public Fraction Plus(Fraction other)
        {
            Fraction f = new(this.Numerator, this.Denominator);
            return f.Add(other);
        }

        public static Fraction operator+(Fraction a, Fraction b)
        {
            return a.Plus(b);
        }

        public static Fraction operator+(Fraction a, int b)
        {
            return new(a.Numerator + a.Denominator * b, a.Denominator);
        }

        public static Fraction operator-(Fraction a)
        {
            return new(-a.Numerator, a.Denominator);
        }

        public static Fraction operator-(Fraction a, Fraction b)
        {
            return a.Plus(-b);
        }

        public static Fraction operator++(Fraction a)
        {
            return new(a.Numerator + a.Denominator, a.Denominator);
        }

        public static bool operator true(Fraction a) => a.Numerator != 0;
        public static bool operator false(Fraction a) => a.Numerator == 0;

        public static bool operator<(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < a.Denominator * b.Numerator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > a.Denominator * b.Numerator;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator <= a.Denominator * b.Numerator;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator >= a.Denominator * b.Numerator;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator == a.Denominator * b.Numerator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator != a.Denominator * b.Numerator;
        }

        public static bool operator!(Fraction a)
        {
            return a.Numerator == 0;
        }

        public static explicit operator Money(Fraction a)
        {
            int rub = a.Numerator / a.Denominator;
            return new(rub,
                       (int)(100 * ((float)a.Numerator / a.Denominator - rub)));
        }

        public static implicit operator float(Fraction a)
        {
            return (float)a.Numerator / a.Denominator;
        }

        public override string ToString()
        {
            return $"[{Numerator}/{denominator}]";
        }


    }
}
