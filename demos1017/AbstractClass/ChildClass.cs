using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class ChildClass : AbstractBaseClass
    {
        public override int AbstractMethod(int num)
        {
            //throw new NotImplementedException();
            return num;
        }
    }
}
