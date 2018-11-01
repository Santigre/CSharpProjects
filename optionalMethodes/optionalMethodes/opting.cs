using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalMethodes
{
    class opting
    {
        public int Choices(int x, int y = 1)
        {
            int firstChoice = (x + 22) * y;
            return firstChoice;
        }
    }
}
