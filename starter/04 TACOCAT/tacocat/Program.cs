// como desarrollador necesito escribir un programa de consola en .net core que me permita a traves de una funcion validar si una palabra es un palindromo. Por ejemplo arañara = palindromo
using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese una palabra
        Console.Write("Por favor, ingresa una palabra: ");
        string palabra = Console.ReadLine();

        // Verificar si la palabra es un palíndromo
        bool esPalindromo = VerificarPalindromo(palabra);

        // Imprimir si la palabra es un palíndromo o no
        if (esPalindromo)
        {
            Console.WriteLine(palabra + " es un palíndromo.");
        }
        else
        {
            Console.WriteLine(palabra + " no es un palíndromo.");
        }
    }

    // Función para verificar si una palabra es un palíndromo
    static bool VerificarPalindromo(string palabra)
    {
        string palabraReversa = String.Empty;
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraReversa += palabra[i];
        }

        return palabra.Equals(palabraReversa, StringComparison.OrdinalIgnoreCase);
    }
}
