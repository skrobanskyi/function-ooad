using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.UnaryClass;

namespace Function.Func.OtherClass
{
    class Argum:Function
    {
        public Argum() => calculateCalculate = x => x;

        public override string ToString() => "x";

        public override Function Diff() => new ConstFunc(1);

        public override string ToXML(int tabs)
        {
            string str = "";
            for (int i = 0; i < tabs; i++)
                str += "\t";
            str += "<Argum>\r\n\t" + str + "x\r\n" + str + "</Argum>";
            return str;
        }

        public override void GetEqRoots() => throw new NotImplementedException();
    }
}
