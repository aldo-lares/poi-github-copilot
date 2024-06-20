// Como desarrollador necesito crear un programa de consola en .net core que me perte calcular el factorial de numero entero positivo
using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un número entero positivo
        Console.Write("Por favor, ingresa un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        // Calcular el factorial del número
        long factorial = CalcularFactorial(numero);

        // Imprimir el resultado
        Console.WriteLine("El factorial de " + numero + " es " + factorial);
    }

    // Función para calcular el factorial de un número
    static long CalcularFactorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            return numero * CalcularFactorial(numero - 1);
        }
    }
}
