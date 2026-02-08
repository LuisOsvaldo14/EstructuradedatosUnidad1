using System;

class ParImpar
{
    static void Main()
    {
        Console.WriteLine("_______Este es un programa que te dice si el numero que introduciste es par o impar_______");
        int Numero;

        Console.WriteLine("Introduce el numero: ");
        Numero = Convert.ToInt32(Console.ReadLine());

        if (Numero % 2 == 0)
        {
            Console.WriteLine("Este numero es par");
        }
        else
        {
            Console.WriteLine("Este numero es impar");
        }
    }
}
