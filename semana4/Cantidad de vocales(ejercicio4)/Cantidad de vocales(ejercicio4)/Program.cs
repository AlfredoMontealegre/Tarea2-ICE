using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantidad_de_vocales_ejercicio4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena de texto:");
            string texto = Console.ReadLine();

            int cantidadVocales = ContarVocales(texto);

            Console.WriteLine($"La cantidad de vocales en el texto es: {cantidadVocales}");
        }

        static int ContarVocales(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOU";

            foreach (char c in texto)
            {
                if (vocales.Contains(c))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}