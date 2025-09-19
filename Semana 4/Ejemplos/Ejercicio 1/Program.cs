using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        //Ejercicio 1: Calcular el área de un triángulo//
        static double CalcularAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
            Console.WriteLine($"El área del triangulo es con base {baseT} y una altura de {altura} es {(baseT * altura) / 2}");
        }

        static void Main(String[] args)
        {
            Console.WriteLine(CalcularAreaTriangulo(9.2, 3));
        }
    }
}
