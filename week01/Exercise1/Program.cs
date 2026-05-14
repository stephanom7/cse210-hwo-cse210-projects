using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir el primer nombre
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Pedir el apellido
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Mostrar el resultado en el formato solicitado
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
