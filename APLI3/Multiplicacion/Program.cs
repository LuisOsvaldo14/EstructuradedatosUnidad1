using System;


class Multiplicacion 
{
    static void Main()
    {

        Console.WriteLine("_______Este es un Programa que Multiplica dos numeros________");
        Console.WriteLine(" ");

        int PrimerValor;
        int SegundoValor;
        int Resultado;

        Console.WriteLine("Introduce el primer valor: ");
        PrimerValor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce tu segundo valor: ");
        SegundoValor = Convert.ToInt32(Console.ReadLine());

        Resultado = PrimerValor * SegundoValor;

        Console.WriteLine($"La multiplicacion de {PrimerValor} * {SegundoValor} es {Resultado}");
    }
}
