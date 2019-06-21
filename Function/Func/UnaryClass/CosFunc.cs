using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;

namespace Function.Func.UnaryClass
{
    class CosFunc : UnFunc
    {
        public CosFunc() => calculateCalculate = x => Math.Cos(argumentFunction.CalculateCalc(x));

        public CosFunc(Function fFunction) => argumentFunction = fFunction;
        public override Function Diff() => new MultOper(new ConstFunc(-1), new SinFunc(argumentFunction));

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
