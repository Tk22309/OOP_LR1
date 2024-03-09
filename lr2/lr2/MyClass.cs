using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    public class Equation
    {
        private double x;
        private char sign;

        public Equation(double x, char sign)
        {
            this.x = x;
            this.sign = sign;
        }

        public string Solve()
        {
            // Формування рядка згідно зі знаком
            string result;
            if (sign == '+')
            {
                result = $"X + ({x} + {sign})";
            }
            else if (sign == '-')
            {
                result = $"X - ({x} + {sign})";
            }
            else
            {
                result = "Неправильний знак!";
            }
            return result;
        }
    }
}
