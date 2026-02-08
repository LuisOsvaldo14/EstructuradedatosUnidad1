using System;

class Tabladel10
{
    static void Main()
    {
        Console.WriteLine("este es un programa que te da la tabla del 10 del numero que introduzcas ");
        Console.WriteLine(" "); Console.Write("Introduce tu numero: ");
        int Numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine($"La tabla del numero {Numero} es: ");
        Console.WriteLine($" {Numero} * 1 = {Numero * 1} | {Numero} * 2 = {Numero * 2} | {Numero} * 3 = {Numero * 3} | {Numero} * 4 = {Numero * 4} | {Numero} * 5 = {Numero * 5}|");
        Console.WriteLine($" {Numero} * 6 = {Numero * 6} | {Numero} * 7 = {Numero * 7} | {Numero} * 8 = {Numero * 8} | {Numero} * 9 = {Numero * 9} | {Numero} * 10 = {Numero * 10}|");
    }
}
