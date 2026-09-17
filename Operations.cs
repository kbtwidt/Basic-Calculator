using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Week4Assignment4._1._2
{
    
    interface IOperations
    {
        public double Addition(double a, double b);
        public double Subtraction(double a, double b);
        public double Multiplication(double a, double b);
        public double Division(double a, double b);
        public double Calculate(double a, double b, string operation);
    }
    internal sealed class Operations : IOperations
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Addition(a, b);
                case "-":
                    return Subtraction(a, b);
                case "*":
                    return Multiplication(a, b);
                case "/":
                    return Division(a, b);
                default:
                    return b;
            }
        }

    }
}
