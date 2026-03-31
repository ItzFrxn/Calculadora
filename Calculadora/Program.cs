using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculadora.operaciones;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(5, 3));
            Console.WriteLine(Resta(5, 3));
            Console.WriteLine(Multiplicacion(5, 3));
            Console.WriteLine(Division(5, 3));
        }
    }
}
