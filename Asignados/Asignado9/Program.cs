// Ejercicio 9
// Desarrolla una función en C# que reciba como parámetro una cadena de
//texto representando una contraseña, y devuelva un valor booleano (true o
// false) dependiendo de si la contraseña cumple con los siguientes requisitos
// de seguridad:
// -Tiene al menos 8 caracteres.
// - Contiene al menos una letra mayúscula.
// - Contiene al menos un número.
// La función debe realizar las validaciones una por una y retornar true solo si se
// cumplen las tres condiciones. En caso contrario, debe devolver false.


using System;

class Program
{
    static void Main()
    {
        // Ejemplo de prueba
        string password = "Password123";
        bool resultado = ValidarContrasena(password);
        Console.WriteLine($"¿La contraseña cumple los requisitos? {resultado}");
    }

    static bool ValidarContrasena(string contrasena)
    {
        // 1. Verificar longitud mínima 8 caracteres
        if (contrasena.Length < 8)
            return false;

        // 2. Verificar al menos una letra mayúscula
        bool tieneMayuscula = false;
        foreach (char c in contrasena)
        {
            if (char.IsUpper(c))
            {
                tieneMayuscula = true;
                break;
            }
        }
        if (!tieneMayuscula)
            return false;

        // 3. Verificar al menos un número
        bool tieneNumero = false;
        foreach (char c in contrasena)
        {
            if (char.IsDigit(c))
            {
                tieneNumero = true;
                break;
            }
        }
        if (!tieneNumero)
            return false;

        // Si llegó aquí, cumple los tres requisitos
        return true;
    }
}
