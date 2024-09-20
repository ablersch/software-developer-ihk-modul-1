using System;

namespace Fakultaet;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Fakultät berechnen");
        Console.Write("Bitte eine Zahl eingeben: ");

        ulong input = ulong.Parse(Console.ReadLine());

        // Sonderfall: 0!
        ulong result = 1;

        if (input > 1)
        {
            for (ulong i = 1; i <= input; i++)
            {
                result = result * i;
                // Alternativ: result *= i;
            }
        }

        Console.Write("Die Fakultät der Zahl ");
        Console.Write(input);
        Console.Write(" ist: ");
        Console.Write(result);

        Console.WriteLine("\nTaste drücken um zu beenden");
        Console.ReadKey();
    }
}