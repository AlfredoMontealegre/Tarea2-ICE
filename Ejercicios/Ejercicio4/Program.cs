// Ejercicios - Ejercicio 4
// Calcular el IVA del 15% y el total a pagar en base a la cantidad del
// precio unitario de un producto.

static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
{
    decimal subtotal = cantidad * precioUnitario;
    decimal iva = subtotal * 0.15m;
    decimal total = subtotal + iva;
    Console.WriteLine($"Cantidad: {cantidad}");
    Console.WriteLine($"Precio Unitario: ${precioUnitario:F2}");
    Console.WriteLine($"Subtotal: ${subtotal:F2}");
}
