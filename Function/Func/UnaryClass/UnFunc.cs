using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Func.UnaryClass
{
    abstract class UnFunc:Function
    {
        public override string ToString() => OperationName() + "(" + argumentFunction.ToString() + ")";

        public override string ToXML(int tabs)
        {
            string str = "";
            for (int i = 0; i < tabs; i++)
                str += "\t";
            return str + "<" + OperationName() + ">\r\n" + argumentFunction.ToXML(tabs + 1) + "\r\n" + str + "</" + OperationName() + ">";
        }
    }
}
