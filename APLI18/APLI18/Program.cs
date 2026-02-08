using System;

class Sumadedigitos

{
    static void Main()
    {
        Console.WriteLine("___Este es un programa que suma los digitos de un numero que introduzcas___");
        Console.WriteLine(" "); Console.Write("Introduce tu numero: ");
        int Numero = Convert.ToInt32(Console.ReadLine()); 
        int aux = Math.Abs(Numero);
        int Suma = 0;

        while (aux > 0)
        {
            Suma = Suma + (aux % 10);
            aux = aux / 10;
        }
        Console.WriteLine($"La suma de los digitos del Numero {Numero} es igual a: {Suma} ");
    }
}
