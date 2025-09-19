using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {

        //Desarrolla una función en C# que reciba como parámetro una cadena de texto representando una contraseña, y devuelva un valor booleano(true o false) dependiendo de si la contraseña cumple con los siguientes requisitos de seguridad:
        //Tiene al menos 8 caracteres.
        //Contiene al menos una letra mayúscula.
        //Contiene al menos un número. 
        // Función que valida la contraseña
        static bool ValidarContraseña(string contraseña)
        {
            // Requisito 1: Al menos 8 caracteres
            if (contraseña.Length < 8)
                return false;

            bool tieneMayuscula = false;
            bool tieneNumero = false;

            // Recorremos cada carácter para verificar mayúsculas y números
            foreach (char c in contraseña)
            {
                if (char.IsUpper(c)) // Verifica mayúscula
                    tieneMayuscula = true;

                if (char.IsDigit(c)) // Verifica número
                    tieneNumero = true;
            }

            // Devuelve true solo si cumple ambos requisitos
            return tieneMayuscula && tieneNumero;
        }

        static void Main()
        {
            Console.Write("Ingresa una contraseña: ");
            string password = Console.ReadLine();

            bool esValida = ValidarContraseña(password);
        }
    }
}

