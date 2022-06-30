using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace z2
{
    class Model
    {
        public double number1, number2;
        public string label1;

        public string Equal(double a, double b)
        {
            number1 = a;
            number2 = b;
            switch (label1)
            {
                case "+":
                    return Convert.ToString(number1 + number2);
                case "-":
                    return Convert.ToString(number1 - number2);
                case "*":
                    return Convert.ToString(number1 * number2);
                case "/":
                    return number2 != 0 ? Convert.ToString(number1 / number2) : "Нельзя делить на 0";
                default:
                    return "Недопустимое значение";
            }
        }
    }
}
