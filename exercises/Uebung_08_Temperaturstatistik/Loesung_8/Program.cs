namespace Temperaturstatistik;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie Temperaturwerte für eine Woche, getrennt durch ',', ein.");

        string input = Console.ReadLine();
        string[] inputs = input.Split(',');

        // Neues Array erstellen um die Integer Werte aufzunehmen.
        int[] temperatures = new int[inputs.Length];

        // Konvertiere jeden String in ein Integer.
        for (int i = 0; i < inputs.Length; i++)
        {
            temperatures[i] = int.Parse(inputs[i]);
        }

        int averageTemperature = 0;

        // Variablen mit dem ersten Array Wert befüllen.
        int minimumTemperature = temperatures[0];
        int maximumTemperature = temperatures[0];

        foreach (var temperature in temperatures)
        {
            averageTemperature += temperature;

            // Neuer Wert zuweisen wenn die Temperatur niedriger ist.
            if (temperature < minimumTemperature)
            {
                minimumTemperature = temperature;
            }
            // Neuer Wert zuweisen wenn die Temperatur höher ist.
            if (temperature > maximumTemperature)
            {
                maximumTemperature = temperature;
            }
        }

        Console.Write("Durchschnitt: ");
        Console.Write(averageTemperature / temperatures.Length);
        Console.WriteLine(" °C");

        Console.Write("Maximum: ");
        Console.Write(maximumTemperature);
        Console.WriteLine(" °C");

        Console.Write("Minimum: ");
        Console.Write(minimumTemperature);
        Console.WriteLine(" °C");
    }
}