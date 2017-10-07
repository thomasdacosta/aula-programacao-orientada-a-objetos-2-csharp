using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    public class ContaPoupanca
    {
        private double saldo;
        private double rendimentoAtual;
        private string correntista;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public double RendimentoAtual
        {
            get
            {
                return this.rendimentoAtual;
            }
            set
            {
                this.rendimentoAtual = value;
            }
        }

        public string Correntista
        {
            get
            {
                return this.correntista;
            }
            set
            {
                this.correntista = value;
            }
        }

    }
}
