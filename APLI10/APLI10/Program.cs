using System;

class PositivoNegativo
{
    static void Main()
    {
        Console.WriteLine("___Este es un programa que muestra si un numero es negativo o positivo____");

        int Numero;

        Console.WriteLine("Introduce el numero que quieres verificar: ");
        Numero = Convert.ToInt32(Console.ReadLine());

        if (Numero > 0)
        {
            Console.WriteLine("Este numero es positivo");
        }
        else if (Numero < 0)
        {
            Console.WriteLine("Este numero es Negativo");
        }
        else
        {
            Console.WriteLine("Este numero es neutro");
        }
    }
}