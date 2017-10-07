using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    public class ContaCorrente : Conta
    {
        public override void CalcularRendimento()
        {
            throw new NotImplementedException();
        }

        public override int NumeroConta()
        {
            return 10101;
        }

    }
}
