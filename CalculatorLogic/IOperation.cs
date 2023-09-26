using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public interface IOperation
    {
        string OperationName();
        double Operation(double number1, double number2);
    }
}
