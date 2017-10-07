using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE1_E3_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern singletonPattern = TestSingletonFactory.GetSingletonPattern();
            Console.WriteLine(singletonPattern);
            singletonPattern.PrintValue();
            Console.ReadLine();

            GenericList genericList = new GenericList();
            genericList.TestList();
            Console.ReadLine();
        }
    }
}
