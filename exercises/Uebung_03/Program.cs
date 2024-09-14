namespace Uebung_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zahl im Bereich von 1-7 eingeben:");
        var input = int.Parse(Console.ReadLine());
        string output;

        switch (input)
        {
            case 1:
                output = "Montag";
                break;

            case 2:
                output = "Dienstag";
                break;

            case 3:
                output = "Mittwoch";
                break;

            case 4:
                output = "Donnerstag";
                break;

            case 5:
                output = "Freitag";
                break;

            case 6:
                output = "Samstag";
                Console.WriteLine("Wochenende");
                break;

            case 7:
                output = "Sonntag";
                Console.WriteLine("Wochenende");
                break;

            default:
                output = "Kein gültiger Wochentag eingegeben.";
                break;
        }

        // Alternative
        //if (input == 6 || input == 7)
        //{
        //    Console.WriteLine("Wochenende");
        //}

        Console.WriteLine(output);
    }
}