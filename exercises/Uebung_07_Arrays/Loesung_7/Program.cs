using System;

namespace Arrays;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] zeile = new int[] { 0, 1, 2, 3 };
        int[] spalte = new int[] { 5, 6, 7, 8, 9 };

        for (int i = 0; i < zeile.Length; i++)
        {
            // Ausgabe Zeilennummer
            Console.Write("Zeile [");
            Console.Write(i);
            Console.Write("]: ");

            for (int j = 0; j < spalte.Length; j++)
            {
                // Wert berechnen
                Console.Write(zeile[i] * spalte[j]);
                // Leerzeichen zwischen den Werten
                Console.Write(" ");
            }
            // neue Zeile
            Console.WriteLine();
        }
        Console.WriteLine("\nTaste drücken um zu beenden");
        Console.ReadKey();
    }
}