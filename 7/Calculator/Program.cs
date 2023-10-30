using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public class Calculator
        {
            public static double Add(double number1, double number2)
            {
                return number1 + number2;
            }
            public static double Sub(double number1, double number2)
            {
                return number1 - number2;
            }
            public static double Mult(double number1, double number2)
            {
                return number1 * number2;
            }
            public static double Div(double number1, double number2)
            {
                return number1 / number2;
            }
            
            public static double Pow(double baseNumber, int exponent)
            {
                if (exponent == 0)
                {
                    return 1.0;
                }

                double result = 1.0;
                for (int i = 0; i < Math.Abs(exponent); i++)
                {
                    result *= baseNumber;
                }

                if (exponent < 0)
                {
                    result = 1.0 / result;
                }

                return result;
            }

            public static double FindSquareRoot(double number, double epsilon = 0.00001)
            {
                if (number == 0)
                {
                    return 0;
                }

                double guess = number / 2.0;
                double previousGuess = 0.0;

                while (Math.Abs(guess - previousGuess) > epsilon)
                {
                    previousGuess = guess;
                    guess = 0.5 * (guess + number / guess);
                }

                return guess;
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
