using System;

class PromedioLista
{
    static void Main()
    {
        Console.Write("¿Cuántos números deseas ingresar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

       
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor a cero.");
        }
        else
        {
            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Introduce el número {i}: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                suma += numero;
            }

            double promedio = suma / cantidad;
            Console.WriteLine(" ");
            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
