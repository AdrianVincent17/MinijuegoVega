using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class calculos
    {
        public static int numeritos(int a, int b)
        {
            int result = 0;
            if (a >= b)
            {
                result = a + b;
                return result;
                /*
                Console.WriteLine("La suma es: " + result);
                */
            }
            else
            {
                Console.WriteLine("Error");
                return result;
            }
        }
    }
}
