using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class Logic : ILogic
    {
        private readonly IList<IOperation> _oper;

        public Logic(IList<IOperation> oper)
        {
            this._oper = oper;
        }

        public double SolutionPart(double num1, double num2, string operationName)
        {
            var reqInterface = this._oper.FirstOrDefault(x => x.OperationName() == operationName);
            return reqInterface.Operation(num1, num2);
        }
    }
}
