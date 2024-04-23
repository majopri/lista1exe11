using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");

            Console.Write("Digite o valor de x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(x, y);

            Console.WriteLine($"{x} elevado a {y} é igual a {resultado}");
        }
    }
}
