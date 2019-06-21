using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Binary;

namespace Function.Func.BinaryClass
{
    class MultOper:BinFunc
    {
        public MultOper() => calculateCalculate = x => LP.CalculateCalc(x) * RP.CalculateCalc(x);

        public MultOper(Function lFunction, Function rFunction)
        {
            LP = lFunction;
            RP = rFunction;
        }

        public override Function Diff() => new AddOper(new MultOper(LP.Diff(), RP), new MultOper(LP, RP.Diff()));

        public override void GetEqRoots() => throw new NotImplementedException();

        protected override string Operation() => "*";
    }
}
