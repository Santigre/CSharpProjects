using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodInt
{
    class intMath
    {
        public int firstMath(int x)
        {
            int multiply = x * 3;
            return multiply;
        }
        public decimal firstMath(decimal x)
        {
            decimal divide = x / 3;
            int divideInt = Convert.ToInt32(divide);
            return divide;
        }
        public int firstMath(string x)
        {
            int noodle = Convert.ToInt32(x);
            int add = noodle + 32;
            return add;

        }
    }
}
