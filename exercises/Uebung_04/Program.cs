namespace Uebung_04;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Eine Zahl eingeben:");
        var input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");

        for (int i = input; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}