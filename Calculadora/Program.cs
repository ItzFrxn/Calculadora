using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculadora.operaciones;
using static Calculadora.menu;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            // Menu principal
            Menu();
            Console.WriteLine(" 1) Suma\n 2) Resta\n 3) Multiplicacion\n 4) Division\n 0) Salir");
            Console.WriteLine("=========================");
            Console.Write("Opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // Operaciones
            Menu();
            switch (opcion)
            {
                case 1:
                    Console.Write(" Suma: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Suma: {a} + ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Suma: {a} + {b} = {Suma(a, b)} ");
                    break;
                case 2:
                    Console.Write(" Resta: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Resta: {c} - ");
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Resta: {c} - {d} = {Resta(c, d)} ");
                    break;
                case 3:
                    Console.Write(" Multiplicacion: ");
                    double e = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Multiplicacion: {e} * ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Multiplicacion: {e} * {f} = {Multiplicacion(e, f)} ");
                    break;
                case 4:
                    Console.Write(" Division: ");
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Division: {g} / ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Menu();
                    Console.Write($" Division: {g} / {h} = {Division(g, h)} ");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}
