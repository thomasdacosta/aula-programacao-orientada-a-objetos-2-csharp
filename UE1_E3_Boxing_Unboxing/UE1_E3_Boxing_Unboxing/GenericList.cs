using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE1_E3_Boxing_Unboxing
{
    public class GenericList
    {
        public void TestList()
        {
            List<string> lista = new List<string>();

            lista.Add("1º");
            lista.Add("2º");
            lista.Add("3º");
            lista.Add("4º");
            lista.Add("5º");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Tamanho: " + lista.Count());
            Console.ReadLine();
        }

    }
}
