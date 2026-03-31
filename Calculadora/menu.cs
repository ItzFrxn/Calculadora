using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class menu
    {
        public static void Titulo()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("   Calculadora Basica");
            Console.WriteLine("=========================");
        }
        public static void Inicio(string text)
        {
            Titulo();
            Console.WriteLine(text);
            Console.WriteLine("=========================");
        }
        public static int Opcion()
        {
            Console.Write("Opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcion;
        }
    }
}
