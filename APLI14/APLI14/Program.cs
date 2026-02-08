using System;

class SumaRango
{
    static void Main()
    {
        Console.WriteLine("____Este es un programa que muestra la suma entre el rango de dos numeros que introduzcas____");
        Console.WriteLine("introduce el primer numero: ");
        int Numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introduce el segundo numero: ");
        int Numero2 = Convert.ToInt32(Console.ReadLine());
        int sumas = 0;
        for (int i = Numero1; i <= Numero2; i = i + 1)
        {
            sumas = sumas + i;
            if (i == Numero2)
            {
                Console.Write($" {i} = {sumas}");
            }
            else
            {
                Console.Write($" {i} +");
            }

        }

    }
}
