using System;

namespace Medienverwaltung_Aufgabe_1;

internal class Program
{
    private static int seitenzahl;
    private static int signatur;
    private static Leihstatus status;
    private static string titel;

    private enum Leihstatus
    {
        präsent,
        entliehen
    };

    /// <summary>
    /// Legt ein neues Buch an
    /// </summary>
    public static void Anlegen()
    {
        signatur = NummerEingabe(nameof(signatur));

        Console.WriteLine("Titel eingeben:");
        titel = Console.ReadLine();

        seitenzahl = NummerEingabe(nameof(seitenzahl));

        status = Leihstatus.präsent;
        Console.WriteLine("Buch erfolgreich angelegt!");
    }

    /// <summary>
    /// Ausgabe der Buchdaten
    /// </summary>
    public static void Ausgabe()
    {
        Console.WriteLine("Ausgabe");
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Signatur", "Titel", "Leihstatus", "Seitenzahl");
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", signatur, titel, status, seitenzahl);

        // Optional mit dynamischer Titellänge
        // Länge des Titelfeldes berechnen. Titel muss mindestens so lange sein wie die Spaltenbezeichnung "Titel".
        // Wert negieren.
        //var titleLaenge = titel.Length < nameof(titel).Length ? (nameof(titel).Length) * -1 : (titel.Length) * -1;
        //// vom Start des Wertes nach rechts 15 Stellen frei. Titelspaltengröße wird berechnet.
        //Console.WriteLine("{0,-15} {1," + titleLaenge + " } {2,-15} {3,-15}", "Signatur", "Titel", "Leihstatus", "Seitenzahl");
        //Console.WriteLine("{0,-15} {1," + titleLaenge + " } {2,-15} {3,-15}", signatur, titel, status, seitenzahl);
    }

    /// <summary>
    /// Entleiht ein Buch wenn es nicht entliehen ist
    /// </summary>
    public static void Entleihen()
    {
        if (status == Leihstatus.präsent)
        {
            status = Leihstatus.entliehen;
            Console.WriteLine($"{titel} erfolgreich ausgeliehen.");
        }
        else
        {
            Console.WriteLine($"{titel} ist bereits entliehen.");
        }
    }

    /// <summary>
    /// Gibt ein Buch zurück wenn es entliehen ist
    /// </summary>
    public static void Rueckgabe()
    {
        if (status == Leihstatus.entliehen)
        {
            status = Leihstatus.präsent;
            Console.WriteLine($"{titel} erfolgreich zurueckgegeben.");
        }
        else
        {
            Console.WriteLine($"Rueckgabe von {titel} nicht möglich da das Buch nicht entliehen ist.");
        }
    }

    private static void Main()
    {
        var auswahl = string.Empty;

        Console.WriteLine("Medienverwaltung");

        // Menü, wird immer wiederholt in einer Schleife angezeigt bis es mit 'q' beendet wird.
        while (auswahl != "q")
        {
            Console.WriteLine("\n#### Menue ####");
            Console.WriteLine("Anlegen eines neuen Buch 'b'");
            Console.WriteLine("Ausgabe des vorhandenen Buch 'a'");
            Console.WriteLine("Entleihen des angelegten Buch 'e'");
            Console.WriteLine("Rueckgabe des Buch 'r'");
            Console.WriteLine("Programm beenden 'q'\n");

            auswahl = Console.ReadLine();

            Console.WriteLine();

            switch (auswahl)
            {
                case "b":
                    Anlegen();
                    break;

                case "a":
                    Ausgabe();
                    break;

                case "e":
                    Entleihen();
                    break;

                case "r":
                    Rueckgabe();
                    break;

                case "q":
                    // "durchrutschen"
                    break;

                default:
                    Console.WriteLine("\nFalsche Eingabe\n");
                    break;
            }
        }
    }

    private static int NummerEingabe(string name)
    {
        int nummer = 0;
        Console.WriteLine($"{name} eingeben: ");

        // Es wird solange überprüft bis ein gültiger Zahlenwert eingegeben wurde
        while (!int.TryParse(Console.ReadLine(), out nummer))
        {
            Console.WriteLine("Es wurde keine gültige Zahl eingegeben. Erneut versuchen: ");
        }

        return nummer;
    }
}