namespace ConsoleApp2;

internal class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    private static void Main()
    {
        Console.WriteLine("Wert 1 eingeben:");
        var wert1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Wert 2 eingeben:");
        var wert2 = double.Parse(Console.ReadLine());

        var summe = wert1 + wert2;
        Console.WriteLine(summe);

        bool isEqual = wert1 == wert2;
        Console.WriteLine(isEqual);

        //Console.WriteLine(wert1 == wert2);  // kürzere Variante
    }
}