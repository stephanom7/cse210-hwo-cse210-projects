using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir el porcentaje
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Variable para la letra
        string letter = "";

        // Determinar la letra según el porcentaje
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Mostrar la letra
        Console.WriteLine($"Your grade is: {letter}");

        // Mensaje de aprobación
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep trying next time!");
        }
    }
}
