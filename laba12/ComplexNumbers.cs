using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class ComplexNumbers
    {
        private int real;
        private int imaginary;

        public ComplexNumbers(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public int Real => real;
        public int Imaginary => imaginary;

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            ComplexNumbers num;
            if ((num = obj as ComplexNumbers) != null && (num.Real == real) && (num.Imaginary == imaginary))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string output = real.ToString() + "+" + imaginary.ToString() + "i";
            return output;
        }
        public static bool operator ==(ComplexNumbers num1, ComplexNumbers num2)
        {
            if (num1.Equals(num2) && num2.Equals(num1))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(ComplexNumbers num1, ComplexNumbers num2)
        {
            if (num1.Equals(num2) && num2.Equals(num1))
            {
                return false;
            }
            return true;
        }
        public static ComplexNumbers operator +(ComplexNumbers num1, ComplexNumbers num2)
        {
            return new ComplexNumbers(num1.real + num2.real, num1.imaginary + num2.imaginary);
        }
        public static ComplexNumbers operator -(ComplexNumbers num1, ComplexNumbers num2)
        {
            return new ComplexNumbers(num1.real - num2.real, num1.imaginary - num2.imaginary);
        }
        public static ComplexNumbers operator *(ComplexNumbers num1, ComplexNumbers num2)
        {
            return new ComplexNumbers(num1.real * num2.real - (num2.imaginary * num1.imaginary), num1.imaginary * num2.real + num2.imaginary * num1.real);
        }
        public static ComplexNumbers operator /(ComplexNumbers num1, ComplexNumbers num2)
        {
            return new ComplexNumbers((num1.real * num2.real + num1.imaginary * num2.imaginary) / (num2.real * num2.real + num2.imaginary * num2.imaginary),
                                  (num1.imaginary * num2.real - num1.real * num2.imaginary) / (num2.real * num2.real + num2.imaginary * num2.imaginary));
        }

    }
}
