using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
        }
    }
}
