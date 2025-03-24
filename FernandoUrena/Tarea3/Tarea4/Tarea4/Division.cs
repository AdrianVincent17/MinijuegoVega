using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
  public class Division
    {
        public static double Dividir(double a, double b)
        {
            double resultado = 0;

            if (b != 0)
            {
                resultado = a / b;
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }

            return resultado;
        }
    }
}
