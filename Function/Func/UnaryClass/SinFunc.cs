using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Func.UnaryClass
{
    class SinFunc : UnFunc
    {
        public SinFunc() => calculateCalculate = x => Math.Sin(argumentFunction.CalculateCalc(x));

        public SinFunc(Function fFunction) => argumentFunction = fFunction;

        public override Function Diff() => new CosFunc(argumentFunction);

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
