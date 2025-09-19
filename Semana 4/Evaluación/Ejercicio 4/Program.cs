using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {

        //Desarrollla una función en C# que reciba como parametro una cadena de texto ingresada por el usuario y devuelva la cantidad de vocales que contiene//

        static int contadorDeVocales(string letras)
        {
            int vocales = 0;
            letras = letras.ToUpper();
            foreach (char v in letras)
            {
                if (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U')
                {
                    vocales++;
                }
            }
            Console.WriteLine($"La cantidad de vocales del texto anterior son: {vocales}");
            return vocales;
            

        }
        static void Main()
        {
            Console.WriteLine("Ingrese una palabra o frase: ");
            string texto = Console.ReadLine();

            int cantidadDeVocales = contadorDeVocales(texto);
        }
    }
}
