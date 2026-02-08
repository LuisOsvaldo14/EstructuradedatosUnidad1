using System;

class MayorMenor

{
    static void Main()
    {

        Console.WriteLine("_____Este es un programa que toma el nombre de una persona y dice si es mayor o menor_______");
        string Nombre;
        int Edad;

        Console.WriteLine("Introduce el nombre de la persona: ");
        Nombre = Console.ReadLine()!;

        Console.WriteLine("Introduce la edad de la persona: ");
        Edad = Convert.ToInt32(Console.ReadLine());

        if (Edad >= 18)
        {
            Console.WriteLine($"{Nombre} es mayor");
        }
        else
        {
            Console.WriteLine($"{Nombre} es menor");

        }
    }
}