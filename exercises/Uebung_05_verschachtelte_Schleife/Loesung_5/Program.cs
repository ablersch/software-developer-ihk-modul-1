using System;

Console.WriteLine("Wert eingeben:");
var consoleInput = int.Parse(Console.ReadLine());

// Äußere Schleife
for (int row = 1; row <= consoleInput; row++)
{
    // Innere Schleife (Schreibt den Inhalt in die Zeile)
    for (int col = 1; col <= row; col++)
    {
        Console.Write("$");
    }
    // Erzeugt eine neue Zeile
    Console.WriteLine();
}