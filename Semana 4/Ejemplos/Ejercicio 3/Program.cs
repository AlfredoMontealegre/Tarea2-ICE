using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {

        //Ejercicio 3: Validar si un número es par o impar//

        static bool EsPar(int número)
        {
            // El código después de 'return' es inaccesible, así que se elimina.
            if (número % 2 == 0)
            {
                Console.WriteLine($"El número {número} es par");
                return true;
            }
            else
            {
                Console.WriteLine($"El número {número} es impar");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero: ");
            int número = int.Parse(Console.ReadLine());
            /*El método .Parse convierte la cadena de texto ingresada por el usuario en un número válido, de otra manera el código lanzará una excepción.*/
            Console.WriteLine(EsPar(número));
            
        }
    }
}
