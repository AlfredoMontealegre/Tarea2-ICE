using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {

        //Calcular el factorial de un númemro entero El prograa se repetirá mientras el usuario lo decida//

        static int Factorial(int número)
        {
            int factorial = 1;
            for (int i = 1; i <= número; i++);
            {
                int i = 0;
                factorial = factorial * i;
            }
            return factorial;
            Console.WriteLine($"El factorial del {número} es {factorial}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero para calcular su factorial: ");
            int número = int.Parse(Console.ReadLine());
            Factorial(número);
            Console.WriteLine("¿Desea calcular otro factorial? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "s")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
            }

        }
    }
}
