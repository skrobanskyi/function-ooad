using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Func.UnaryClass
{
    class ExpFunc : UnFunc
    {
        public ExpFunc() => calculateCalculate = x => Math.Exp(argumentFunction.CalculateCalc(x));

        public ExpFunc(Function fFunction) => argumentFunction = fFunction;
        public override Function Diff() => this;

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
