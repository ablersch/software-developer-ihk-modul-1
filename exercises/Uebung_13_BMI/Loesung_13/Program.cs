namespace BMI;

internal class Program
{
    private static double CalculateBMI(double gewicht, double groesse)
    {
        return gewicht / (groesse * groesse);
    }

    /// <summary>
    /// Get BMI group for a calculated BMI.
    /// </summary>
    /// <param name="bmi">Calculated BMI value.</param>
    /// <returns>The BMI group.</returns>
    private static string GetBMIGroup(double bmi)
    {
        string bmiGroup = "";

        if (bmi < 18.5)
        {
            bmiGroup = "Untergewicht";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            bmiGroup = "Normalgewicht";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            bmiGroup = "Übergewicht";
        }
        else if (bmi >= 30 && bmi <= 34.9)
        {
            bmiGroup = "Adipositas (Grad 1)";
        }
        else if (bmi >= 35 && bmi <= 39.9)
        {
            bmiGroup = "Adipositas (Grad 2)";
        }
        else if (bmi >= 40)
        {
            bmiGroup = "Adipositas (Grad 3)";
        }
        return bmiGroup;
    }

    private static void Main(string[] args)
    {
        OutputToConsole("Body-Mass-Index berechnen");

        OutputToConsole("Körpergewicht (kg):");
        if (!double.TryParse(Console.ReadLine(), out double gewicht))
        {
            OutputToConsole("Eingabe des Körpergewichtes ungültig.");
            return;
        }

        OutputToConsole("Größe (m):");
        if (!double.TryParse(Console.ReadLine(), out double groesse))
        {
            OutputToConsole("Eingabe der Größe ungültig.");
            return;
        }

        var bmi = CalculateBMI(gewicht, groesse);

        OutputToConsole("Der BMI ist: " + bmi);
        OutputToConsole("Sie haben/sind: " + GetBMIGroup(bmi));

        Console.ReadKey();
    }

    private static void OutputToConsole(string output)
    {
        Console.WriteLine(output);
    }
}