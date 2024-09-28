namespace Email;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Benutzer E-Mail Adresse eingeben:");
        var input = Console.ReadLine();

        // Prüfen ob der Eingabewert ein @ beinhaltet.
        if (!input.Contains('@'))
        {
            Console.WriteLine("Keine gültige E-Mail Adresse eingegeben.");

            // Programm beenden.
            return;
        }

        // Eingabewert aufteilen.
        var inputArray = input.Split('@');

        Console.Write("Benutzername: ");
        Console.WriteLine(inputArray[0]);

        Console.Write("Domain: ");
        Console.WriteLine(inputArray[1]);
    }
}