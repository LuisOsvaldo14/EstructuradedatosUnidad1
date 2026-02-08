using System;

class Invertirtext
{
    static void Main()
    {
        Console.WriteLine("__Esto es un programa que invierte una cadena de texto que introduzcas___");
        Console.WriteLine(" "); Console.Write("Introduce tu texto: ");
        string Texto = Console.ReadLine();
        string Textoinvertido = "";

        for (int i = Texto.Length - 1; i >= 0; i--)
        {
            Textoinvertido += Texto[i];
        }

        Console.WriteLine($"Texto invertido: {Textoinvertido}");



    }
}