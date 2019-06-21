using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;
using Function.Func.UnaryClass;

namespace Function.Func.OtherClass
{
    class Polynom:Function
    {
        public Dictionary<int, double> Coefficients = new Dictionary<int, double>();

        public Polynom() =>
            calculateCalculate = x =>
            {
                double val = 0;
                foreach (var coef in Coefficients)
                {
                    val += coef.Value * Math.Pow(argumentFunction.CalculateCalc(x), coef.Key);
                }
                return val;
            };

        public Polynom(Function f, Dictionary<int, double> coefs)
        {
            argumentFunction = f;
            Coefficients = coefs;
        }

        public override string ToString()
        {
            string val = "";
            foreach (var coef in Coefficients)
            {
                val += new MultOper(new ConstFunc(coef.Value), new PowFunc(argumentFunction, coef.Key)).ToString() + "+";
            }
            return val.Remove(val.Length - 1);
        }

        public override string ToXML(int tabs)
        {
            string str = "";
            for (int i = 0; i < tabs; i++)
                str += "\t";
            string val = str + "<Polynom>";
            foreach (var coef in Coefficients)
            {
                val += "\r\n\t" + str + "<PolynomPart>";
                val += "\r\n" + new MultOper(new ConstFunc(coef.Value), new PowFunc(argumentFunction, coef.Key)).ToXML(tabs + 2);
                val += "\r\n\t" + str + "</PolynomPart>";
            }
            val += "\r\n" + str + "</Polynom>";
            return val;
        }

        public override Function Diff()
        {
            Dictionary<int, double> newCoefs = new Dictionary<int, double>();

            foreach (var coef in Coefficients)
            {
                if (coef.Key >= 0)
                    newCoefs.Add(coef.Key - 1, coef.Value * coef.Key);
            }

            return new Polynom(argumentFunction, newCoefs);
        }

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
