using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Func.UnaryClass
{
    class ConstFunc:UnFunc
    {
        private double value;

        public ConstFunc()
        {
            value = 0;
            calculateCalculate = x => value;
        }

        public ConstFunc(double value) => this.value = value;

        public override string ToString() => value.ToString();

        public override string ToXML(int tabs)
        {
            string str = "";
            for (int i = 0; i < tabs; i++)
                str += "\t";
            return str + "<" + OperationName() + ">\r\n\t" + str + value.ToString() +"\r\n" + str + "</" + OperationName() + ">";
        }
        public override Function Diff() => new ConstFunc(0);

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
