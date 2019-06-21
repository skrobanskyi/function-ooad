using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function.Func.BinaryClass;
using Function.Func.OtherClass;
using Function.Func.UnaryClass;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Function f1 = new SinFunc();
            f1.argumentFunction = new Argum();
            Function f2 = new CosFunc();
            f2.argumentFunction = new ExpFunc();
            f2.argumentFunction.argumentFunction = new Argum();
            Function f3 = new AddOper(f1, f2);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());
            Console.WriteLine("===========================");
            Console.WriteLine("Diff " + f2.ToString() + " = " + f2.Diff().ToString() + "\n");
            Console.WriteLine("===========================");
            Console.WriteLine("Value "+ f2.ToString()+"="+f2.Diff().ToString()+"\n");
            Console.WriteLine("===========================");
            string Path = "XMLoutput.xml";
            using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(f2.ToXML());
            }
            Dictionary<int, double> Coefficients = new Dictionary<int, double>();
            Coefficients.Add(0, 2);
            Coefficients.Add(1, 7);
            Function f4 = new Polynom(f2, Coefficients);
            Console.WriteLine(f4.ToString());
            Console.WriteLine("===========================");
            double val = f2.CalculateCalc(5);
            Console.WriteLine(f2.ToString() + "=" + val);

            string Path1 = "XMLoutput1.xml";
            using (StreamWriter sw = new StreamWriter(Path1, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(f4.ToXML());
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
