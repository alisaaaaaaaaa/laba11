using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class RationalNumbers
    {
        public int Numerator;
        public int Denominator;
        public RationalNumbers(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        public override bool Equals(object o)
        {
            RationalNumbers num;
            if (o != null && (num = o as RationalNumbers) != null && num.Denominator == Denominator && num.Numerator == Numerator)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string output = Numerator + "/" + Denominator;
            return output;
        }
        public static bool operator ==(RationalNumbers num1, RationalNumbers num2)
        {
            if (num1.Equals(num2) && num2.Equals(num1))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumbers num1, RationalNumbers num2)
        {
            if (num1.Equals(num2) && num2.Equals(num1))
            {
                return false;
            }
            return true;
        }

        public static bool operator <(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator < num2.Numerator * num1.Denominator;
        }
        public static bool operator >(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator > num2.Numerator * num1.Denominator;

        }
        public static bool operator <=(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator <= num2.Numerator * num1.Denominator;
        }
        public static bool operator >=(RationalNumbers num1, RationalNumbers num2)
        {
            return num1.Numerator * num2.Denominator >= num2.Numerator * num1.Denominator;
        }
        public static RationalNumbers operator +(RationalNumbers num1, RationalNumbers num2)
        {
            return new RationalNumbers(num1.Numerator * num2.Denominator + num2.Numerator * num1.Denominator, num2.Denominator * num1.Denominator);
        }
        public static RationalNumbers operator -(RationalNumbers num1, RationalNumbers num2)
        {
            return new RationalNumbers(num1.Numerator * num2.Denominator - num2.Numerator * num1.Denominator, num2.Denominator * num1.Denominator);
        }
        public static RationalNumbers operator --(RationalNumbers num)
        {
            return new RationalNumbers(num.Numerator - num.Denominator, num.Denominator);
        }
        public static RationalNumbers operator ++(RationalNumbers num)
        {
            return new RationalNumbers(num.Numerator + num.Denominator, num.Denominator);
        }
    }
}
