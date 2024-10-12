namespace CallBy;

internal class Program
{
    private static void Main(string[] args)
    {
        int score = 10;

        UpdateScore(ref score);
        Console.WriteLine(score);

        // Wert welcher zurückgegeben wurde der Variable neu zuweisen.
        score = UpdateScore2(score);
        Console.WriteLine(score);
    }

    // Teil 1
    private static void UpdateScore(ref int score)
    {
        score += 10;
    }

    // Teil 2
    private static int UpdateScore2(int score)
    {
        // Wert zurückgeben
        return score += 10;
    }
}