using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLab
{
    class ComplexNumber
    {
        private int real, imaginary;

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public override string ToString()
        {
            return this.real+"+"+this.imaginary+"i";
        }
    }
}
