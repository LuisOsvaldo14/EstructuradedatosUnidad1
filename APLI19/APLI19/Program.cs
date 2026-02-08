using System;

class Mayordetres
{
    static void Main()
    {
        Console.WriteLine("___Este es un programa que muestra cual es el mayor de tres numeros___");
        Console.WriteLine(" "); Console.WriteLine("Introduce tu primer numero: "); int Numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" "); Console.WriteLine("Introduce tu segundo numero: "); int Numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" "); Console.WriteLine("Introduce tu tercer numero: "); int Numero3 = Convert.ToInt32(Console.ReadLine());

        if (Numero1 > Numero2 && Numero1 > Numero3)
        {
            Console.WriteLine($"El numero {Numero1} es mayor que el numero {Numero2} y el numero {Numero3}");
        }
        else if (Numero2 > Numero1 && Numero2 > Numero3)
        {
            Console.WriteLine($"El numero {Numero2} es mayor que el numero {Numero1} y el numero {Numero3}");
        }
        else
        {
            Console.WriteLine($"El numero {Numero3} es mayor que el numero {Numero1} y el numero {Numero2}");
        }

    }
}
