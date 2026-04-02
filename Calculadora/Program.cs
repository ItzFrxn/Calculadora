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
            bool uso = true;
            do
            {
                Console.Title = "Calculadora";
                // Menu principal
                Inicio(" 1) Suma\n 2) Resta\n 3) Multiplicacion\n 4) Division\n 0) Salir");
                Console.Write(" Opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Operaciones
                Titulo();
                switch (opcion)
                {
                    case 1:
                        Console.Write(" Suma: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.Write($" Suma: {a} + ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.WriteLine($" Suma: {a} + {b} = {Suma(a, b)} ");
                        break;
                    case 2:
                        Console.Write(" Resta: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.Write($" Resta: {c} - ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.WriteLine($" Resta: {c} - {d} = {Resta(c, d)} ");
                        break;
                    case 3:
                        Console.Write(" Multiplicacion: ");
                        double e = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.Write($" Multiplicacion: {e} * ");
                        double f = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.WriteLine($" Multiplicacion: {e} * {f} = {Multiplicacion(e, f)} ");
                        break;
                    case 4:
                        Console.Write(" Division: ");
                        double g = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.Write($" Division: {g} / ");
                        double h = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Titulo();
                        Console.WriteLine($" Division: {g} / {h} = {Division(g, h)} ");
                        break;
                    case 0:
                        Console.Clear();
                        Salir();
                        return;
                    default:
                        Console.WriteLine(" Opcion no valida.");
                        break;
                }
                if (uso == true)
                {
                    Console.WriteLine(" Presione cualquier tecla para continuar o 'x' para salir.");
                    char key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    if (key == 'x' || key == 'X')
                    {
                        Salir();
                        uso = false;
                    }
                    ;
                }
            } while (uso);
        }
    }
}
