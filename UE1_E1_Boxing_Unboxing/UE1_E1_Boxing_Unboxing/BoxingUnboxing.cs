using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE1_E1_Boxing_Unboxing
{
    public class BoxingUnboxing
    {
        public void testBoxingUnboxingSample1()
        {
            // ############# Conversão Boxing
            int idade = 39;
            object obj_idade = "teste";

            Console.WriteLine(idade.GetType());
            Console.WriteLine(obj_idade.GetType());

            // ############# Conversão Unboxing
            int nova_idade = (int)obj_idade;
            Console.WriteLine(nova_idade);
            Console.ReadLine();
        }

        // #### Source-Code 
        // #### https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/boxing-and-unboxing
        public void testBoxingUnboxingSample2()
        {
            Console.WriteLine(String.Concat("Answer", 42, true));
            List<object> mixedList = new List<object>();

            mixedList.Add("First Group:");

            for (int j = 1; j < 5; j++)
            {
                mixedList.Add(j);
            }

            mixedList.Add("Second Group:");
            for (int j = 5; j < 10; j++)
            {
                mixedList.Add(j);
            }

            foreach (var item in mixedList)
            {
                Console.WriteLine(item);
            }

            var sum = 0;
            for (var j = 1; j < 5; j++)
            {
                sum += (int)mixedList[j] * (int)mixedList[j];
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }
    }
}
