using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Binary
{
    public abstract class BinFunc: Function
    {
        public Function LP;
        public Function RP;
        private new Function argumentFunction;

        
        public override string ToString() => LP.ToString() + Operation() + RP.ToString();
        protected abstract string Operation();
        public override string ToXML(int tabs)
        {
            string str = "";
            for (int i = 0; i < tabs; i++)
                str += "\t";
            return str + "<" + OperationName() + ">" + "\r\n\t" + str + "<LeftOperand>" + "\r\n" + LP.ToXML(tabs + 2) +
                   "\r\n\t" + str + "</LeftOperand>" + "\r\n\t" + str + "<RightOpearnd>" + "\r\n" + RP.ToXML(tabs + 2) +
                   "\r\n\t" + str + "</RightOperand>" + "\r\n" + str + "</" + OperationName() + ">";

        }
    }
}
