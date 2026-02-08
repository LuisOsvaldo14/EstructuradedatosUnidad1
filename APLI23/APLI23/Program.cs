using System;

class Viciesto
{
    static void Main()
    {
        Console.WriteLine("___Este es un programa que te dice si el año que introdujiste es viciesto o no___");
        Console.WriteLine(" "); Console.WriteLine("Introduce el año que quieres verificar");
        int Año = Convert.ToInt32(Console.ReadLine());

        if ((Año % 4 == 0 && Año % 100 != 0) || (Año % 400 == 0))
        {
            Console.WriteLine($"El año {Año} es bisiesto.");
        }
        else
        {
            Console.WriteLine($"El año {Año} no es bisiesto.");
        }
    }
}
