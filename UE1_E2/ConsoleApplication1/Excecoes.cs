using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Excecoes
    {
        public double testExceptionDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();

            return x / y;
        }
    }
}
