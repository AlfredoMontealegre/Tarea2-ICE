using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 2;
            decimal precioUnitario = 100m;
            CalcularIVAyTotal(cantidad, precioUnitario);
        }

        static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
        {
            Console.WriteLine($"cantidad: {cantidad}");
            decimal subtotal = cantidad * precioUnitario;
            decimal iva = subtotal * 0.15m;
            decimal total = subtotal + iva;
            Console.WriteLine($"IVA (15%): ${iva:F2}");
            Console.WriteLine($"Total a pagar: ${total:F2}");
            Console.WriteLine($"precio unitario: ${precioUnitario:F2}");
        }
    }
}
