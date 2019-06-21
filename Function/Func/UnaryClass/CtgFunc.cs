using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;

namespace Function.Func.UnaryClass
{
    class CtgFunc : UnFunc
    {
        public CtgFunc() => calculateCalculate = x => 1.0 / Math.Tan(argumentFunction.CalculateCalc(x));

        public CtgFunc(Function fFunction) => argumentFunction = fFunction;
        public override Function Diff() => new DivOper(new ConstFunc(-1), new PowFunc(new SinFunc(argumentFunction), 2));

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
