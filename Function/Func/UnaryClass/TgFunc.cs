using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;

namespace Function.Func.UnaryClass
{
    class TgFunc : UnFunc
    {
        public TgFunc() => calculateCalculate = x => Math.Tan(argumentFunction.CalculateCalc(x));

        public TgFunc(Function fFunction) => argumentFunction = fFunction;

        public override Function Diff() => new DivOper(new ConstFunc(-1), new PowFunc(new CosFunc(argumentFunction), 2));

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
