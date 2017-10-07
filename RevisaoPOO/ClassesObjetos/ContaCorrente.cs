using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class ContaCorrente
    {
        public double saldo;

        public ContaCorrente()
        {
            System.Console.WriteLine("### Instanciando a Classe ContaCorrente.");
        }

        public double calcularSaldo(double saldo)
        {
            return this.saldo + saldo;
        }
    }
}
