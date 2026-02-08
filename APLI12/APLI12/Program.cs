using System;

class Perfecto
{
    static void Main()
    { 
        Console.WriteLine("______este es un programa que te dice si un programa es perfecto o no____");
        Console.WriteLine(" ");
        Console.WriteLine("introduce el numero que quieres verificar: ");
        int Numero = Convert.ToInt32(Console.ReadLine());
        int DivisoresSumados = 0;
        Console.WriteLine(" ");

        for (int i = 1; i <= Numero / 2; i = i + 1)
        {
            if (Numero % i == 0)
            {
                DivisoresSumados = DivisoresSumados + i;
            }
        }
        if (DivisoresSumados == Numero)
        {
            Console.WriteLine($"el numero {Numero} es un numero perfecto");

        }
        else
        {
            Console.WriteLine($"El numero {Numero} no es un numero perfecto");
        }
    }
}
