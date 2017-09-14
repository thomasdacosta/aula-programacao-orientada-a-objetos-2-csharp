using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Excecoes excecoes = new Excecoes();
            try
            {
                double x;
                double y; 

                Console.WriteLine("Digite o valor de X:");
                Double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("Digite o valor de Y:");
                Double.TryParse(Console.ReadLine(), out y);

                Console.WriteLine("Resultado:" + excecoes.testExceptionDivision(x, y));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Sempre é executado");
            }

            Strings strings = new Strings();
            strings.testString();
            strings.testSequence();
            strings.testImutable();
            strings.testFormatString();
        }
    }
}
