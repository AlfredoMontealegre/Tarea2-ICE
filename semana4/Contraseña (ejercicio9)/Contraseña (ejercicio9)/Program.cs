using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraseña__ejercicio9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una contraseña:");
            string password = Console.ReadLine();

            bool esSegura = ValidarPassword(password);

            if (esSegura)
                Console.WriteLine("La contraseña es válida ✅");
            else
                Console.WriteLine("La contraseña no cumple con los requisitos ❌");
        }

        static bool ValidarPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool tieneMayuscula = false;
            bool tieneNumero = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    tieneMayuscula = true;

                if (char.IsDigit(c))
                    tieneNumero = true;
            }

            return tieneMayuscula && tieneNumero;
        }
    }
}
