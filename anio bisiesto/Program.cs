using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anio_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("ingrese el año que desea consultar");
            año = int.Parse(Console.ReadLine());

            if ( año % 4 == 0 && año % 100 != 0)
            {
                Console.WriteLine("{0}, es un año bisiesto", año);
            }
            else if (año % 400 == 0 )
            {
                Console.WriteLine("{0}, es un año bisiesto", año);
            }
            else
            {
                Console.WriteLine("{0}. no es un año bisiesto", año);
            }
            Console.ReadLine(); 
        }
    }
}
