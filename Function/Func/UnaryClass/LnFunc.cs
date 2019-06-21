using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;

namespace Function.Func.UnaryClass
{
    class LnFunc : UnFunc
    {
        public LnFunc() => calculateCalculate = x => Math.Log(argumentFunction.CalculateCalc(x));

        public LnFunc(Function fFunction) => argumentFunction = fFunction;

        public override Function Diff() => new DivOper(new ConstFunc(1),argumentFunction );

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
