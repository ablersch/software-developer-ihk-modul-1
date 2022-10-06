# Enumeration (Aufzählungen)

Enumerationtypen

---

<!-- .slide: class="left" -->
## Was sind Enumerations

[Enumerations](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/enumeration-types) helfen Programme leichter lesbar zu gestalten. Meist werden
Konstanten oder Optionen damit abgebildet. Alle Werte sind schreibgeschützt.

Alle Werte in einer Enumeration werden auf eine Zahl abgebildet. Wird kein Wert definiert wird bei 0 begonnen.

---

<!-- .slide: class="left" -->
## Enumeration Definieren

```csharp []
// Es werden intern Werte von 0 -6 vergeben
public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

// Internen Wert anpassen
public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

```

---

<!-- .slide: class="left" -->
## Beispiel

```csharp []
using System;

class Program
{
    enum ErrorStatus
    {
        None=100,  
        Trivial=200,  
        Important=300,  
        Critical=900
    };

    static void Main()
    {
        // Neue Variable erstellen und Enum Wert zuweisen
        ErrorStatus eStatus = ErrorStatus.Critical;

        if (eStatus == ErrorStatus.Trivial)
        {
            Console.WriteLine("Not true");
        }
        else if (eStatus == ErrorStatus.Critical)
        {
            Console.WriteLine("True");
        }
        // Name der Enum und den Wert ausgeben
        Console.WriteLine($"Der Status Code ist {eStatus} mit dem Wert {(int)eStatus}");
        }
    }
}
```

Note: **VS** Enum

---

<!-- .slide: class="left" -->
## Enum Übung

Erstellen Sie ein kleines Konsolen Programm wo ein Level (Werte 1-3) für eine Person abgefragt wird. Dieser Wert soll in einer Enum Variable gespeichert werden. Danach die Bezeichnung des zugehörigen Enum Wertes ausgeben.

Enum Werte:

* 1 = Beginner
* 2 = Advanced
* 3 = Master
