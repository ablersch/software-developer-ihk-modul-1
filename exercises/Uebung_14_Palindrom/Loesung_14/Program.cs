using System;

namespace Palindrom;

internal class Program
{
    /// <summary>
    /// Prüfen ob der Input ein Palindrom ist.
    /// </summary>
    /// <param name="checkForPalindrom">Zu prüfender Wert.</param>
    /// <returns>true = ist ein Palindrom; false = kein Palindrom</returns>
    private static bool IsPalindrom(string checkForPalindrom)
    {
        string wortReverse = string.Empty;

        // Entferne alle Leerzeichen
        checkForPalindrom = checkForPalindrom.Replace(" ", "");

        // Alles in Kleinbuchstaben
        checkForPalindrom = checkForPalindrom.ToLower();

        // String spiegeln mit einer Schleife (von vorne)
        for (int i = 0; i < checkForPalindrom.Length; i++)
        {
            wortReverse += checkForPalindrom[checkForPalindrom.Length - i - 1];
        }

        // Alternative 1
        //wortReverse = ReverseString(checkForPalindrom);

        // Alternative 2
        // String in ein Array wandeln, dieses Array spiegeln
        // wieder in ein Array wandeln und über String Konstruktor neuen String erstellen
        //wortReverse = new string(checkForPalindrom.ToCharArray().Reverse().ToArray());

        // Kurzes If
        return (checkForPalindrom == wortReverse) ? true : false;
    }

    private static bool IsPalindromVersion2(string checkForPalindrom)
    {
        // Entferne alle Leerzeichen
        checkForPalindrom = checkForPalindrom.Replace(" ", "");

        // Alles in Kleinbuchstaben
        checkForPalindrom = checkForPalindrom.ToLower();

        // Einzelne Zeichen vom Anfang und vom Ende beginnend vergleichen
        int leftIndex = 0;
        int rightIndex = checkForPalindrom.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (checkForPalindrom[leftIndex] != checkForPalindrom[rightIndex])
            {
                return false; // kein Palindorm
            }
            leftIndex++;
            rightIndex--;
        }

        return true;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Palindrom-Test");
        Console.WriteLine("Geben sie bitte das zu pruefende Wort ein: ");

        var wort = Console.ReadLine();

        var isPalindrom = IsPalindrom(wort);

        if (isPalindrom)
        {
            Console.WriteLine($"Das Wort {wort} ist ein Palindrom\n");
        }
        else
        {
            Console.WriteLine($"Das Wort {wort} ist kein Palindrom\n");
        }

        Console.ReadLine();
    }

    /// <summary>
    /// String umdrehen mit Array
    /// </summary>
    /// <param name="s">String der umgedreht werden soll</param>
    /// <returns>Gibt umgedrehten String zurück</returns>
    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}