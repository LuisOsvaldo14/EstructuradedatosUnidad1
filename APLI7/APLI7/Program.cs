using System;


class NumeroImpar
{


    static void Main()
    {
        Console.WriteLine("Este  es un programa que mueestra los numeros impares 1 al 100");

        int contador = 1;

        while (contador < 100)
        {
            Console.WriteLine(contador);
            contador = contador + 2;
        }
    }
}        

