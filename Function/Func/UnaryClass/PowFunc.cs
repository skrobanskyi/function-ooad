using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;

namespace Function.Func.UnaryClass
{
    class PowFunc : UnFunc
    {
        private double pPower;
        public PowFunc() => calculateCalculate = x => Math.Pow(argumentFunction.CalculateCalc(x), pPower);

        public PowFunc(Function fFunction, double power)
        {
            argumentFunction = fFunction;
            pPower = power;
        }

        public override string ToString()
        {
            if (pPower == 0)
                return "1";
            if (pPower == 1)
                return argumentFunction.ToString();

            return argumentFunction.ToString() + "^" +pPower.ToString();
        }

        public override Function Diff()
        {
            if (pPower >= 2)
                return new MultOper(new ConstFunc(pPower), new PowFunc(argumentFunction, pPower - 1));

            return new ConstFunc(0);
        }

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
