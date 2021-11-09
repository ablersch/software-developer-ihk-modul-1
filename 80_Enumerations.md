# Enumeration

[Enumerations](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/enumeration-types) helfen Programme leichter lesbar zu gestalten. Meist werden
Konstanten oder Optionen damit abgebildet.

```csharp
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
        ErrorStatus eStatus = ErrorStatus.Critical;

        if (eStatus == ErrorStatus.Trivial)
        {
            Console.WriteLine("Not true");
        }
        else if (eStatus == ErrorStatus.Critical)
        {
            Console.WriteLine("True");
        }
        Console.WriteLine($"Der Status Code ist {eStatus} mit dem Wert {(int)eStatus}");
        }
    }
}
```

Note: **VS** Enum


<!-- .slide: class="left" -->
## Enum Übung

Erstellen Sie ein kleines Konsolenprogramm wo ein Level (Werte 1-3) für eine Person abgefragt wird. Dieser Wert soll in einer Enum Variable gespeichert werden. Danach die Bezeichnung des zugehörigen Enum Wertes ausgeben.

Enum Werte:

* 1 = Beginner
* 2 = Advanced
* 3 = Master
