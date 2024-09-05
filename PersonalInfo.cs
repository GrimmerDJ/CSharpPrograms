using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your birthdate (e.g., January 1, 1990): ");
        string birthDate = Console.ReadLine();

        Console.Write("Enter your work phone number: ");
        string workPhone = Console.ReadLine();

        Console.Write("Enter your cell phone number: ");
        string cellPhone = Console.ReadLine();

        Console.WriteLine("\nPersonal Information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Birthdate: " + birthDate);
        Console.WriteLine("Work Phone: " + workPhone);
        Console.WriteLine("Cell Phone: " + cellPhone);
    }
}