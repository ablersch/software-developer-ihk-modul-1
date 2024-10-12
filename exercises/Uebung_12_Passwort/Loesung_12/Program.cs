using System;

namespace Passwort;

internal class Program
{
    private const int MinPasswordLength = 8;
    private static string password;

    private static void Main()
    {
        Console.WriteLine("Passwort eingeben: ");
        ConsoleKeyInfo keyInfo;

        do
        {
            // Taste soll im Konsolenfenster nicht angezeigt werden.
            keyInfo = Console.ReadKey(true);

            // Möglichkeit bieten falsche Eingabe zu korrigieren.
            if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
            {
                // Den gedrückten Buchstaben dem Password string hinzufügen.
                password += keyInfo.KeyChar;
                // Darstellung als Platzhalter mit *.
                Console.Write("*");
            }
            else if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                // letztes Zeichen entfernen.
                password = password.Substring(0, password.Length - 1);
                // 2 mal (Backspace Taste und das letzte Zeichen) zurück (Backspace).
                Console.Write("\b \b");
            }
        }
        // Wenn Enter gedrückt wurde die Passwort Abfrage beenden.
        while (keyInfo.Key != ConsoleKey.Enter);

        Console.WriteLine();

        // Passwortrichtlinien prüfen.
        if (password.Length < MinPasswordLength)
        {
            Console.WriteLine("Das eingegebene Passwort war zu kurz.");
        }

        bool containsNumber = false;
        bool containsChar = false;

        foreach (char c in password)
        {
            if (containsNumber && containsChar)
            {
                // Schleife früher beenden.
                break;
            }

            if (Char.IsDigit(c))
            {
                containsNumber = true;
            }
            else if (Char.IsLetter(c))
            {
                containsChar = true;
            }
        }

        // Alternative
        //bool containsNumber = password.Any(char.IsDigit);

        if (!containsNumber || !containsChar)
        {
            Console.WriteLine("Das eingegebene Passwort muss aus Zahlen und Buchstaben bestehen.");
        }

        Console.WriteLine("Passwort einfolgereich gesetzt.");
        Console.ReadLine();
    }
}