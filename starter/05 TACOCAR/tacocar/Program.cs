// como desarrollador necesito escribir un programa de consola en .net core que atraves de una funcion me indique cual es el siguiente numero que sea un palindromo de un odometro basado en un kilometraje
using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un número de kilometraje
        Console.Write("Por favor, ingresa un número de kilometraje: ");
        int kilometraje = int.Parse(Console.ReadLine());

        // Encontrar el siguiente número palíndromo
        int siguientePalindromo = EncontrarSiguientePalindromo(kilometraje);

        // Imprimir el siguiente número palíndromo
        Console.WriteLine("El siguiente número palíndromo es " + siguientePalindromo);
    }

    // Función para verificar si un número es un palíndromo
    static bool EsPalindromo(int numero)
    {
        
        string numeroStr = numero.ToString();
        string numeroReverso = String.Empty;
        for (int i = numeroStr.Length - 1; i >= 0; i--)
        {
            numeroReverso += numeroStr[i];
        }

        return numeroStr.Equals(numeroReverso);
    }

    // Función para encontrar el siguiente número palíndromo
    static int EncontrarSiguientePalindromo(int numero)
    {
        numero++;
        while (!EsPalindromo(numero))
        {
            numero++;
        }

        return numero;
    }
}
