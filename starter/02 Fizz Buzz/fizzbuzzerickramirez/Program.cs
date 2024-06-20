// como desarrollador necesito crear un programa de consola en .net core que imprima los numero del 1 al 100, pero cuando un numero sea multiplo de 3 lo reemplce con la palabra "Fizz" y los multiplos de 5 los remplace "Buzz". Por ejemplo : 1, 2, Fizz, 4, Buzz, Fizz, 7, ..
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
