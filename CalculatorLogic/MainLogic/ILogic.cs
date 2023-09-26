using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public interface ILogic
    {
        double SolutionPart(double num1, double num2, string operation);
    }
}
