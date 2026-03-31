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
            Console.Title = "Calculadora";
            Console.WriteLine("=========================");
            Console.WriteLine("   Calculadora Basica");
            Console.WriteLine("=========================");
            Console.WriteLine(" 1) Suma\n 2) Resta\n 3) Multiplicacion\n 4) Division\n 5) Opciones avanzadas\n x) Salir");
            Console.WriteLine("=========================");
        }
    }
}
