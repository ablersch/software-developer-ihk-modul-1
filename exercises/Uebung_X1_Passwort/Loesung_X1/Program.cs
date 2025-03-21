using System;

namespace Passwort;

internal class Program
{
    private const int MinPasswordLength = 8;

    private static void Main()
    {
        ConsoleKeyInfo keyInfo;
        string password = string.Empty;

        Console.WriteLine("Passwort eingeben: ");

        do
        {
            // Taste soll im Konsolenfenster nicht angezeigt werden.
            keyInfo = Console.ReadKey(true);

            // Möglichkeit bieten falsche Eingabe zu korrigieren.
            if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
            {
                // Den gedrückten Buchstaben dem Password string hinzufügen.
                password += keyInfo.KeyChar;

                // Darstellung des Platzhalters mit *.
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
                // Schleife früher beenden wenn mind. eine Zahl
                // und mind. ein Buchstabe enthalten ist.
                break;
            }

            if (char.IsDigit(c))
            {
                containsNumber = true;
            }
            else if (char.IsLetter(c))
            {
                containsChar = true;
            }
        }

        if (!containsNumber || !containsChar)
        {
            Console.WriteLine("Das eingegebene Passwort muss aus Zahlen und Buchstaben bestehen.");
            return;
        }

        Console.WriteLine($"Passwort erfolgreich gesetzt: {password}");
        Console.ReadLine();
    }
}