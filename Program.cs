using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0100_area_do_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculo da área do triangulo ---> A = ( b * h ) / 2");

            Console.WriteLine();

            Console.Write("Insira valor da Base   : ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Insira valor da altura : ");
            float h = float.Parse(Console.ReadLine());

            if (b <= 0 || h <= 0)
            {

                Console.WriteLine("Execute novamente e insira valor diferente de 0");

            }
            else
            {

                Console.Write("A área do triangulo é  : ");
                float s = (b * h) / 2.0f;
                Console.WriteLine(s);

            }

            Console.ReadLine();

        }
    }
}
