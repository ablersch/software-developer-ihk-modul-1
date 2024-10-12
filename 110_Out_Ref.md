# "Call by value" und "Call by reference"

Was ist der Unterschied? Wann was benutzen?

---

<!-- .slide: class="left" -->
## Parameterübergabe

Es gibt zwei Möglichkeiten um Parameter an eine Methode zu übergeben:

#### Call by Value
* Parameterübergabe als Kopie
* Änderungen an der Kopie haben keinen Einfluss auf die ursprüngliche Variable außerhalb der Methode.
* In C# ist dies der Standardübergabemechanismus
<br>

#### Call by Reference
* Parameterübergabe als Verweis (Referenz) auf die Originalvariable
* Änderungen an dieser Referenz beeinflussen die Originalvariable direkt.
* In C# wird dies erreicht durch das Verwenden des `ref`-Schlüsselworts.
* Dies ist nützlich wenn eine Methode mehrere Werte zurückgibt oder eine übergebene Variable verändern soll.


---

<!-- .slide: class="left" -->
## Beispiel: Call by Value

```csharp []
class Program
{
    public static void ChangeAndWrite(int number)
    {
        number = 10;
        Console.WriteLine($"Inside ChangeAndWrite: {number}");
    }
    
    static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine($"Value before ChangeAndWrite call: {number}");
        ChangeAndWrite(number);
        Console.WriteLine($"Value after ChangeAndWrite call: {number}");
        Console.ReadKey();
    }
}
```

```bash
Value before ChangeAndWrite call: 5
Inside ChangeAndWrite: 10
Value after ChangeAndWrite call: 5
```

---

<!-- .slide: class="left" -->
## Beispiel: Call by Reference

Damit der ursprüngliche Wert geändert wird kann der Wert als **Verweis** (Referenz) übergeben
werden. Dazu wird das Schlüsselwort [ref](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/ref) verwendet.

```csharp []
class Program
{
    public static void ChangeAndWrite(ref int number)
    {
        number = 10;
        Console.WriteLine($"Inside ChangeAndWrite: {number}");
    }
    
    static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine($"Value before ChangeAndWrite call: {number}");
        ChangeAndWrite(ref number);
        Console.WriteLine($"Value after ChangeAndWrite call: {number}");
        Console.ReadKey();
    }
}
```

```bash
Value before ChangeAndWrite call: 5
Inside ChangeAndWrite: 10
Value after ChangeAndWrite call: 10

```

---

<!-- .slide: class="left" -->
## Anwendungsfälle

### Call by Value

* Wird verwendet, wenn die Methode nur eine Berechnung durchführen soll, ohne die übergebenen Variablen zu verändern.

* Besonders geeignet für den Umgang mit primitiven Datentypen oder wenn es nicht erforderlich ist, den ursprünglichen Zustand zu ändern.

* Beispiel: Methoden, die einen Wert basierend auf Berechnungen zurückgeben (z. B. Berechnung von Flächen, Zinsen, Umrechnungen).

---

<!-- .slide: class="left" -->
## Anwendungsfälle

### Call by Reference

* Wird verwendet, wenn die Methode den Zustand einer übergebenen Variable oder eines Objekts verändern soll.

* Praktisch für Situationen, in denen mehrere Werte innerhalb einer Methode berechnet und an den Aufrufer zurückgegeben werden sollen.

* Beispiel: Methoden, die mehrere Berechnungen auf einem Objekt durchführen und es aktualisieren, wie z.B. Hinzufügen von Elementen zu einer Liste oder Ändern des Punktestands in einem Spiel.

Note: Im Allgemeinen sollte "Call by Value" bevorzugt werden, außer es gibt einen guten Grund, die Originalvariable zu verändern.

**Call by Value:** Überträgt eine Kopie des Wertes. Sicherer und ohne Seiteneffekte, aber weniger effizient für große Daten.

**Call by Reference:** Überträgt eine Referenz auf das Original. Effizienter und erlaubt Änderungen an der Originalvariable, birgt jedoch das Risiko unerwarteter Änderungen.

---

<!-- .slide: class="left" -->
## Out Parameter (Ausgabeparameter)

Ausgabeparameter ([out](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/out-parameter-modifier)) verhalten sich genau wie `ref`-Parameter, nur dass diesen nicht initialisierte Variablen übergeben werden können.

Dieser Parameter wurden spezielle für den Fall entwickelt das eine
Methode mehrere Werte zurückgeben soll. Dieser Parameter übergibt der
Methode keinen Wert, sondern teilt ihr mit, in welcher Variable sie
einen bestimmten Wert speichern soll z.B. wird dies bei `TryParse` verwendet.

```csharp []
Addiere(10, 5, out int result);

bool Addiere(int zahl1, int zahl2, out int result) 
{
    result = zahl1 + zahl2;

    if (result > 10)
    {
         return true;
    } 
    else 
    {
        return false;
    }

    // Alternativ: return (result > 10)
}
```

Note: 
* **VS** Ref und out Parameter zeigen.
* **ÜBUNG** Call by