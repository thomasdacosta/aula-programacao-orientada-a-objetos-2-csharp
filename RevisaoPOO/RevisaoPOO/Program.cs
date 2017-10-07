using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesObjetos;
using GetterSetter;
using Heranca;
using ClassesAbstratas;

namespace RevisaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                if (args[0].Equals("ClassesObjetos"))
                    ClassesObjetos();

                if (args[0].Equals("GetterSetter"))
                    GetterSetter();

                if (args[0].Equals("Heranca"))
                    Heranca();

                if (args[0].Equals("ClassesAbstratas"))
                    ClassesAbstratas();
            }
        }

        static void ClassesObjetos()
        {
            ClassesObjetos.ContaCorrente contaCorrente = new ClassesObjetos.ContaCorrente();
            contaCorrente.saldo = 10500.00;

            System.Console.Write("### Digite o valor a ser debitado ou creditado:");

            double debitoCredito = Convert.ToDouble(Console.ReadLine());
            double novoSaldo = contaCorrente.calcularSaldo(debitoCredito);

            Console.WriteLine("### Saldo Atual:" + novoSaldo);
            Console.WriteLine("### Pressione uma tecla para SAIR:");
            Console.ReadLine();
        }

        static void GetterSetter()
        {
            GetterSetter.ContaPoupanca contaPoupanca = new GetterSetter.ContaPoupanca();
            contaPoupanca.Saldo = 1000.00;
            contaPoupanca.Correntista = "Bruce Wayne";
            contaPoupanca.RendimentoAtual = 0.06;

            contaPoupanca.Saldo = (contaPoupanca.Saldo * contaPoupanca.RendimentoAtual) + contaPoupanca.Saldo;
            Console.WriteLine("### Novo rendimento da poupança:" + contaPoupanca.Saldo);
            Console.ReadLine();
        }

        static void Heranca()
        {
            Console.WriteLine("###### Heranca");

            Heranca.Conta conta = new Heranca.Conta();
            Console.WriteLine("### Número da Conta:" + conta.NumeroConta());

            Heranca.Conta contaCorrente = new Heranca.ContaCorrente();
            Console.WriteLine("### Número da Conta Corrente:" + contaCorrente.NumeroConta());

            Heranca.Conta contaPoupanca = new Heranca.ContaPoupanca();
            Console.WriteLine("### Número da Conta Poupança:" + contaPoupanca.NumeroConta());
            Console.ReadLine();
        }

        static void ClassesAbstratas()
        {
            Console.WriteLine("###### ClassesAbstratas");

            ClassesAbstratas.Conta contaCorrente = new ClassesAbstratas.ContaCorrente();
            Console.WriteLine("### Número da Conta Corrente:" + contaCorrente.NumeroConta());

            ClassesAbstratas.Conta contaPoupanca = new ClassesAbstratas.ContaPoupanca();
            Console.WriteLine("### Número da Conta Poupança:" + contaPoupanca.NumeroConta());
            Console.ReadLine();
        }
    }
}
