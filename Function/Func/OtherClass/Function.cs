using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public abstract class Function
    {
        public Function argumentFunction;
        protected delegate double Calculate(double x);
        protected Calculate calculateCalculate;
        public new abstract string ToString();
        public abstract string ToXML(int tabs = 0);
        public abstract Function Diff();
        public abstract void GetEqRoots();
        public virtual double CalculateCalc(double x) => calculateCalculate(x);

        public string OperationName() => this.GetType().Name;
    }
}
