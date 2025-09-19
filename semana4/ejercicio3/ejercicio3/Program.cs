using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (EsPar(numero))
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
