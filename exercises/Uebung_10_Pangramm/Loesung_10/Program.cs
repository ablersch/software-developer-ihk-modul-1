namespace Pangramm;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pangramm-Prüfer");
        Console.WriteLine("Text der überprüft werden soll eingeben:");

        var input = Console.ReadLine();
        input = input.ToUpper();

        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            if (!input.Contains(letter))
            {
                Console.WriteLine("Die Eingabe ist kein Pangramm.");
                return;
            }
        }
        Console.WriteLine("Die Eingabe ist ein Pangramm.");

        // Alternative 1
        char[] allLetterArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        foreach (var item in allLetterArray)
        {
            if (!input.Contains(item))
            {
                Console.WriteLine("Die Eingabe ist kein Pangramm.");
                return;
            }
        }

        // Alternative 2
        string allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        foreach (var item in allLetters)
        {
            if (!input.Contains(item))
            {
                Console.WriteLine("Die Eingabe ist kein Pangramm.");
                return;
            }
        }
    }
}