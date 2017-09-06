using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca;

namespace UE1_E1_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxingUnboxing boxingUnboxing = new BoxingUnboxing();
            boxingUnboxing.testBoxingUnboxingSample1();
            boxingUnboxing.testBoxingUnboxingSample2();

            Conta conta = new ContaCorrente();

            object obj_conta = conta;
            Conta conta1 = (Conta)obj_conta;
            Conta conta2 = (ContaCorrente)obj_conta;

            Console.WriteLine(conta1.GetType());
            Console.WriteLine(conta2.GetType());

            Console.ReadLine();
        }
    }
}
