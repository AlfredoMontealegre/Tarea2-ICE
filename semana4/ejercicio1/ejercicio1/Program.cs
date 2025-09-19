using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir datos al usuario
            Console.Write("Ingrese la base del triángulo: ");
            double baseT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcular área
            double area = CalcularAreaTriangulo(baseT, altura);

            // Mostrar resultado
            Console.WriteLine("El área del triángulo es: " + area);
        }

        // Método para calcular el área
        static double CalcularAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
        }
    }
}