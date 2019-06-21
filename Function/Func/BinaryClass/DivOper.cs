using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Binary;
using Function.Func.UnaryClass;

namespace Function.Func.BinaryClass
{
    class DivOper:BinFunc
    {
        public DivOper() => calculateCalculate = x => LP.CalculateCalc(x) / RP.CalculateCalc(x);

        public DivOper(Function lFunction, Function rFunction)
        {
            LP = lFunction;
            RP = rFunction;
        }

        public override Function Diff() => new DivOper(new SubOper(new MultOper(LP.Diff(), RP), new MultOper(LP, RP.Diff())), new PowFunc(RP, 2));

        public override void GetEqRoots() => throw new NotImplementedException();

        protected override string Operation() => "/";
    }
}
