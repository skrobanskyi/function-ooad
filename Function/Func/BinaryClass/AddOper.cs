using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Binary;

namespace Function.Func.BinaryClass
{
    class AddOper:BinFunc
    {
        public AddOper() => calculateCalculate = x => LP.CalculateCalc(x) + RP.CalculateCalc(x);

        public AddOper(Function lFunction, Function rFunction)
        {
            LP = lFunction;
            RP = rFunction;
        }

        public override Function Diff() => new AddOper(LP.Diff(),RP.Diff());

        public override void GetEqRoots() => throw new NotImplementedException();

        protected override string Operation() => "+";
    }
}
