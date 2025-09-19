using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;

            Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");

            intercambiar(ref a, ref b);

            Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
        }

        static void intercambiar(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
