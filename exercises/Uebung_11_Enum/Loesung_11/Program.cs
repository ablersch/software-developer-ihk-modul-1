namespace EnumAufgabe;

internal class Program
{
    private enum Level
    {
        Beginner = 1,
        Advanced = 2,
        Master = 3
    };

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcher Level besitzt der Spieler (1-3)?");
        var input = Console.ReadLine();

        bool result = int.TryParse(input, out var inputZahl);
        if (!result)
        {
            Console.WriteLine("Es wurde keine Zahl eingegeben.");
            return;
        }

        if (!Enum.IsDefined(typeof(Level), inputZahl))
        {
            Console.WriteLine("Es wurde kein gültiger Level eingegeben.");
            return;
        }

        Level spielerLevel = (Level)inputZahl;

        Console.WriteLine($"Der Spieler hat den Level: \"{spielerLevel}\"");
    }
}