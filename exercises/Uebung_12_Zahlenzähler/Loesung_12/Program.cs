namespace Zahlenzaehler;

internal class Program
{
    private static void Main(string[] args)
    {
        int zahl = 0;

        Console.WriteLine($"Aktuelle Zahl: {zahl}");
        Console.WriteLine("Drücken Sie ↑ zum Erhöhen, ↓ zum Verringern, Leertaste zum Anzeigen, Esc zum Beenden.");

        while (true)
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow) // Pfeil nach oben
            {
                zahl++;
            }
            else if (key == ConsoleKey.DownArrow) // Pfeil nach unten
            {
                zahl--;
            }
            else if (key == ConsoleKey.Spacebar) // Leertaste
            {
                Console.WriteLine("\nDie aktuelle Zahl ist: " + zahl);
            }
            else if (key == ConsoleKey.Escape) // Escape-Taste
            {
                Console.WriteLine("\nProgramm beendet.");
                break;
            }

            Console.WriteLine($"\nAktuelle Zahl: {zahl}");
            Console.WriteLine("Drücken Sie ↑ zum Erhöhen, ↓ zum Verringern, Leertaste zum Anzeigen, Esc zum Beenden.");
        }
    }
}