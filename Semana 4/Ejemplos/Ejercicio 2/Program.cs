using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        //Ejercicio 2: Intercambiar valores (Uso de ref)//
        static void Intercambiar(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
            Console.WriteLine($"El valor actual de X es: {X} y el de Y es: {Y}");
            Console.WriteLine($"El valor intercambiado es: {Y}, {X}");
        }
        static void Main(string[] args)
        {
            int X = 5, Y = 10;
            Intercambiar(ref X, ref Y);
        }
    }
}
