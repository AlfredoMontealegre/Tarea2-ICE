// Ejercicios - Ejercicio 2
// Intercambiar valores (uso de ref)

static void Intercambiar(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}