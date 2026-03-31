using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	public class operaciones
	{
		public static double Suma(double a, double b)
		{
			return a + b;
		}
		public static double Resta(double a, double b)
		{
			return a - b;
		}
		public static double Multiplicacion(double a, double b)
		{
			return a * b;
		}
		public static double Division(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("No se puede dividir por cero.");
			}
			return a / b;
		}
	}
}
