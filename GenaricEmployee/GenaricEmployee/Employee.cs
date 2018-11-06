using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaricEmployee
{
    public class Employee <T>
    {
        public List<T> Things = new List<T> {};

    }
}
