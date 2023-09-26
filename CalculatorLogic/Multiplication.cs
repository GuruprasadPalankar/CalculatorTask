using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class Multiplication : IOperation
    {
        public string OperationName()
        {
            return "Multiply";
        }

        public double Operation(double number1, double number2)
        {
            double temp = number1 * number2;
            return temp;
        }
    }
}
