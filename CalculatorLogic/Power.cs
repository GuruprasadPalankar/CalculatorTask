using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class Power : IOperation
    {
        public string OperationName()
        {
            return "Power";
        }

        public double Operation(double number1, double number2)
        {
            double temp = Math.Pow(number1, number2);
            return temp;
        }
    }
}
