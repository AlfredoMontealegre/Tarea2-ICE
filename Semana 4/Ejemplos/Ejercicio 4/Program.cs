using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {

        //Ejercicio 4: Calcular el IVA 15% y el total a pagar en base a la cantidad y el precio unitario de un produto//

        static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
        {
            decimal subtotal = cantidad * precioUnitario;
            decimal iva = subtotal * 0.15m;
            decimal total = subtotal + iva;
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Preio unitario: ${precioUnitario:F2}");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"IVA 15%: ${iva:F2}");
            Console.WriteLine($"Total a pagar: ${total:F2}");
        }
        static void Main(string[] args)
        {
            CalcularIVAyTotal(3, 245.669m);
        }
    }
}
