using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDLL3_TLB_
{
    public class Class1
    {
        private int a = 5, b = 3;

        public void setA(int num)
        {
            a = num;
        }
        public void setB(int num)
        {
            b = num;
        }
        public int multiplica()
        {
            return a * b;
        }

    }
}
