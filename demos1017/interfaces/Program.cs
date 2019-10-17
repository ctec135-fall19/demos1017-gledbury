using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.I1Method();
            Console.WriteLine();

            ChildClass cc = new ChildClass();
            cc.I1Method();
            Console.WriteLine(cc.I2Method(123));
        }
    }
}
