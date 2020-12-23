using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Big_Data
{
    public class Interval
    {
        #region private fielts
            private readonly double num;
            private readonly double den;
        #endregion

        #region Constructor
        public Interval(double numerator, double denominator)
            {
                if (denominator == 0 || numerator == 0)
                {
                    // Nol 
                    throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
                }
                num = numerator;
                den = denominator;
            }
        #endregion

        #region Public method
            public static Interval operator +(Interval a, Interval b)
                => new Interval
                (
                    Math.Min(
                             Math.Min(a.num + b.num, a.num + b.den),
                             Math.Min(a.den + b.den, a.den + b.num)),
                    Math.Max(
                             Math.Max(a.num + b.num, a.num + b.den),
                             Math.Max(a.den + b.den, a.den + b.num))
                    );

            public static Interval operator -(Interval a, Interval b)
                => new Interval
                (
                    Math.Min(
                             Math.Min(a.num - b.num, a.num - b.den),
                             Math.Min(a.den - b.den, a.den - b.num)),
                    Math.Max(
                             Math.Max(a.num - b.num, a.num - b.den),
                             Math.Max(a.den - b.den, a.den - a.num))
                );

            public static Interval operator *(Interval a, Interval b)
                => new Interval
                (
                   Math.Min(
                             Math.Min(a.num * b.num, a.num * b.den),
                             Math.Min(a.den * b.den, a.den * b.num)),
                    Math.Max(
                             Math.Max(a.num * b.num, a.num * b.den),
                             Math.Max(a.den * b.den, a.den * a.num))
                );

            public static Interval operator /(Interval a, Interval b)
            {
                if (b.num == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Interval
                    (
                    Math.Min(
                             Math.Min(a.num / b.num, a.num / b.den),
                             Math.Min(a.den / b.den, a.den / b.num)),
                    Math.Max(
                             Math.Max(a.num / b.num, a.num / b.den),
                             Math.Max(a.den / b.den, a.den / b.num))
                    );
            }

            public override string ToString() => $"{num} : {den}";

        #endregion
    }
}
