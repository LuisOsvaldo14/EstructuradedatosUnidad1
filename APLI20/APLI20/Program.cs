using System;

class Fibonachi
{
    static void Main()
    {
        Console.WriteLine("__Este es un programa que calcula la serie de fibonachi dependiendo el numero que introduzcas___");
        Console.WriteLine(" "); Console.Write("Introduce tu numero ");
        int Numero = Convert.ToInt32(Console.ReadLine());
        int Primero = 1;
        int Viejo = 1;
        int segundo = 1;


        for (int i = 0; i <= Numero; i++)
        {
            Console.WriteLine(Viejo);
            Primero = Viejo;
            Viejo = segundo;
            segundo = Primero + segundo;
            

        }

    }
}

