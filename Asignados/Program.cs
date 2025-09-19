// Ejercicio 4: Desarrolla una funcion en C# que reciba como
// parametro una cadena de texto ingresada por el usuario y
// devuelva la cantidad de vocales que contiene.

using System;

class Program
{
    // Función que cuenta las vocales en una cadena
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

    static void Main()
    {
        Console.Write("Ingresa una cadena de texto: ");
        string entrada = Console.ReadLine();

        int cantidadVocales = ContarVocales(entrada);

        Console.WriteLine($"La cantidad de vocales en el texto es: {cantidadVocales}");
    }
}