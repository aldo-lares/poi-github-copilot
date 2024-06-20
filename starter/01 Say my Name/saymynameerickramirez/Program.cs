//Como desarrollador necesito crear una aplicacion de consola que me permita saludar de forma creativa a un usuario usando .net core

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Crear una lista de saludos creativos por ejemplo "¡Hola cachanilla, Erick!"
        List<string> saludos = new List<string> { "¡Hola cachanilla, ", "¡Qué gusto verte, se ve que andas de ocioso ", "¡Bienvenido al path of illumination, ", "¡Un placer conocerte, ", "¡Saludos camarada capitalista, " };

        // Seleccionar un saludo al azar de la lista
        Random rand = new Random();
        string saludo_seleccionado = saludos[rand.Next(saludos.Count)];

        // Imprimir el saludo seleccionado, seguido del nombre del usuario
        Console.WriteLine(saludo_seleccionado + nombre + "!");
    }
}