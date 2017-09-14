using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE1_E3_Boxing_Unboxing
{
    public class SingletonPattern
    {

        private SingletonPattern()
        {
        }
    
        public void PrintValue()
        {
            Console.WriteLine("Chamando o método PrintValue");
        }

        public static SingletonPattern NewInstance()
        {
            return new SingletonPattern();
        }

    }
}
