using System;

class Factoriar
{
    static void Main()
    {
        Console.WriteLine("___Este es un programa que calcula el factorial de un numero__ ");
        Console.Write("Introduce tu numero: ");
        int Numero1 = Convert.ToInt32(Console.ReadLine());
        int Multiplicador = 1;

        for (int i = 1; i <= Numero1; i = i + 1)
        {
            Multiplicador = Multiplicador * i;
             if (i == Numero1)
            {
                Console.WriteLine($"{Multiplicador} Este es el factorial del numero {Numero1}");
            }
        
        }
        
        
    }
}
