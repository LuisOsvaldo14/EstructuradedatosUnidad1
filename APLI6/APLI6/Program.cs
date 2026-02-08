using System;

class Contador
{
    static void Main()
    {

        Console.WriteLine("_____Este es un programa que muestra los numeros pares del 1 al 100");

        int Contador = 0;

        while (Contador < 100)
        {
           
            Contador = Contador + 2;
            Console.WriteLine(Contador);
        }
    }

}

