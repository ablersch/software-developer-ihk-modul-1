# Enumeration (Aufzählungen)

Enumerationtypen

---

<!-- .slide: class="left" -->
## Was sind Enumerations

Eine [Enumeration](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/enumeration-types) (Aufzählung) ist ein Datentyp, der eine Sammlung von benannten Ganzzahlen (Integer-Werten) definiert. 

Mit Enumerations können Sie Werte definieren, die in einem bestimmten Kontext sinnvoll sind und einen eindeutigen Namen haben, was den Code lesbarer und leichter verständlich macht.

---

<!-- .slide: class="left" -->
## Enumeration Definieren

```csharp
public enum Status 
{ 
    NotStarted,     // default Wert: 0
    InProgress,     // default Wert: 1
    OnHold, 
    Completed
}
```

```csharp
// Internen Wert anpassen
public enum Status 
{ 
    NotStarted = 100,
    InProgress = 200,
    OnHold = 300, 
    Completed = 400
}
```

---

<!-- .slide: class="left" -->
## Warum Enumerations verwenden

* Verbesserung der Lesbarkeit: Statt eine Zahl zu verwenden, geben Enums benannte Werte zurück, die den Code lesbarer machen.

* Vermeidung von Fehlern: Wenn Sie eine Liste von zulässigen Werten haben, stellen Enumerations sicher, dass nur gültige Werte verwendet werden.

Note: Sie sind besonders nützlich, wenn Sie mit festen Werten arbeiten, die nicht geändert werden sollen.

---

<!-- .slide: class="left" -->
## Beispiel

<!--.element: class="stretch" -->
```csharp []
class Program
{
    public enum WeekDays 
    { 
        Monday,     // default Wert: 0
        Tuesday,    // default Wert: 1
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday, 
        Sunday      // default Wert: 6
    }

    static void Main()
    {
        // Verwendung der Enumeration
        WeekDays heute = WeekDays.Monday;

        // Umwandeln von einem Integer-Wert zu einer Enumeration
        heute = (WeekDays)6;

        // Ausgabe des heutigen Tages. Name des Enums + den integer Wert
        Console.WriteLine("Heute ist: " + heute + "und hat den Wert " + (int)heute);

        if (heute == WeekDays.Saturday || heute == WeekDays.Sunday) 
        {
            Console.WriteLine("Wochenende");
        }
    }
}
```

---

<!-- .slide: class="left" -->
## statische Methoden

* Prüfen ob ein bestimmer Wert in der Enumeration definiert ist
  
```csharp
int input = 7;
bool inputValueExist = Enum.IsDefined(typeof(WeekDays), input)
```

* Alle Enumeration-Werte (als `String`) abrufen

```csharp
var enumValues = Enum.GetValues(typeof(WeekDays));
```

Note: 
* `typeof(WeekDays)` gibt den Type der Enumeration WeekDays zurück. Es wird verwendet, um den spezifischen Enum-Typ an die Methode zu übergeben. Der Typ wird also zur Laufzeit an die Methode übermittelt.
* `Enum.GetValuesAsUnderlyingType(typeof(WeekDays));` alle Int-Werte abrufen
* **VS** Enum demonstrieren
* **Übung** Enum