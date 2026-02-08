using System; 

class CuentaDigitos
{
    static void Main()
    {
        Console.WriteLine("______Este es un programa que cuenta los digitos de un numero que intruduzcas______ ");
        Console.WriteLine(" "); Console.Write("Introduce tu numero: ");
        int Numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        int contador = 0;
        int aux = Math.Abs(Numero);

        if (aux == 0)
        {
            Console.WriteLine("Tiene un digito");
        }
        else
        {
            while (aux > 0)
            {
                aux = aux / 10;
                contador = contador + 1;
            }
            Console.WriteLine($"El numero tiene {contador} digitos");
        }
        

    }
}
