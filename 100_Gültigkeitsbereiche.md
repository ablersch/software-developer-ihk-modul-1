# Gültigkeitsbereich von Variablen

Wo ist eine Variable gültig?

---

<!-- .slide: class="left" -->
## Gültigkeitsbereich von Variablen

**Eine Variable steht immer nur innerhalb ihres Geltungsbereichs zur Verfügung.**

Außerhalb dieses Bereichs steht eine Variable nicht zur Verfügung: Sie ist dort unbekannt (ihr Wert kann nicht genutzt werden).

```csharp
internal class Program
{
    private static int globalNumber = 0; // innerhalb der Klasse (globale Variable)

    private static void Main()
    {
        int loops = int.Parse(Console.ReadLine()); // lokale Variable innerhalb der Methode.

        for (int i = 0; i < loops; i++) // Variable i ist nur im for Block gültig
        {
            Output(i.ToString());
        }
    }

    private static void Output(string output) // innerhalb der Methode
    {
        globalNumber++;
        Console.WriteLine($"{output} Nr: {globalNumber}");
    }
}
```

---

<!-- .slide: class="left" -->
### Deklaration von Variablen

Das führt zur Frage, wo eine Variable deklariert werden sollte. Dafür gilt vorrangig die Frage der Lesbarkeit:

* Eine Variable, die nur innerhalb eines winzigen Code-Teils benötigt wird, sollte dort deklariert werden.

* Eine Variable, die als [var](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/var) deklariert wird, kann erst dort deklariert werden, wo sie (erstmals) einen Wert zugewiesen bekommt.

* Andere lokale Variablen sollten möglichst zusammenhängend am Anfang eines Code-Teils deklariert werden.

* Auch Klassen Variablen sollten innerhalb der Klasse an einer sinnvollen Stelle stehen.

Note:
* **VS** Sichtbarkeit von Variablen zeigen (Klasse, Methode, If, ...).