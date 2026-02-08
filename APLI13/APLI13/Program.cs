using System;

class InicioFin
{
    static void Main()
    {
        Console.WriteLine("__Este es un programa que muestra el rango entre dos numeros que introduzcas____");
        Console.WriteLine(" ");
        Console.WriteLine("Introduzca su primer numero: ");
        int Numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduzca su segundo numero: ");
        int Numero2 = Convert.ToInt32(Console.ReadLine());

        for (int i = Numero1; i <= Numero2; i = i + 1 )
        {   
            Console.WriteLine(i);
        }
        
    }
}