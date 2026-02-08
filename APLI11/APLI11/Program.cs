using System;

class Primo
{
    static void Main()
    {

        Console.WriteLine("____Este es un programa que te dice si un numero es primo o no____");
        int Numero;
        bool Esprimo = true;
        Console.WriteLine("Introduce el numero que quieres verificar ");
        Numero = Convert.ToInt32(Console.ReadLine());
        
        if (Numero <= 1)
        {
            Esprimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(Numero); i = i + 1)
            {
                if (Numero % i == 0)
                {
                    Esprimo = false;
                    break;
                }
                
            }
        }
        if (Esprimo == true)
        {
            Console.WriteLine($"El numero {Numero} es primo");

        }
        else
        {
            Console.WriteLine($"el numero {Numero} no es primo");
        }
        

    }
}
