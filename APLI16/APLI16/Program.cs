using System;

class Capicua
{
    static void Main()
    {
        Console.WriteLine("____Este es un programa que te dice si el numero que introdugiste es capicua____");

        Console.WriteLine(" "); Console.Write("Introduce tu numero: ");
        int Numero = Convert.ToInt32(Console.ReadLine());

        int estractor = Numero;
        int inverso = 0;
        int sobrante;

        while (estractor > 0)
        {
            sobrante = estractor % 10;
            inverso = (inverso * 10) + sobrante;
            estractor = estractor / 10;
        }
        if (Numero == inverso)
        {
            Console.WriteLine("Este numero es capicua");
        }
        else
        {
            Console.WriteLine("Este numero no es capicua");
        }
    }
}
