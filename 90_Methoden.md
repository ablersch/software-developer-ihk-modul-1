# Methoden

## Methodendefinition

* Methoden können definierte Parameter entgegennehmen.
* Eine Methode kann nur einen oder auch keinen (void) Wert zurückgeben.
* Methoden werden innerhalb der Klasse ausformuliert.
* Methoden gehören immer zu einer Klasse.
* Eine Klasse kann mehrere Methoden enthalten, wobei die Methoden in beliebiger Reihenfolge deklariert werden können.
* Mit Methoden wird eine Aktion ausgeführt, Daten verändert oder ausgegeben.
* Mehr zum Thema [Methoden](https://docs.microsoft.com/de-de/dotnet/csharp/methods)

Note: In C# wird nur von Methoden gesprochen. Keine Unterscheidung wie in C von Funktion (mit Rückgabewert) oder Prozedur (void)


<!-- .slide: class="left" -->
## Syntax der Methodendefinition

Methoden werden innerhalb einer Klasse oder Struktur definiert. Mit:

**Zugriffsebene, Rückgabewert, Name und Parameter**

```csharp
using System;

namespace Programmaufbau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ergebnis: " + Addition(12, 10));

            int result = Addition(10, 10);

            Console.WriteLine("Taste drücken um zu beenden...");
            Console.ReadKey();
        }

        private static int Addition(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
    }
}
```


<!-- .slide: class="left" -->
## Überladen (Overloading)

Von **Überladen** spricht man, wenn mehrere Methoden den gleichen Namen
aber eine unterschiedliche Anzahl an Parametern oder unterschiedliche
Parametertypen haben.

```csharp
void Multiplikation(double) {}
void Multiplikation(int) {}
void Multiplikation(int, int) {}
void Multiplikation(float, float, int) {}
int Multiplikation(float, float, int) {} // --> Fehler, nicht möglich
```

Note: **ÜBUNG** Palindrom und Medienverwaltung 1

<!-- .slide: class="left" -->
## Ref Parameter

Es gibt zwei Möglichkeiten um Parameter an eine Methode zu übergeben:

* Parameterübergabe als Wert (**call by value**)
* Parameterübergabe als Verweis (**call by reference**)

Normalerweise wird **call by value** verwendet. Der Wert wird als **Kopie
übergeben** und kann bearbeitet werden. Der ursprünglich übergebene Wert
wird dabei nicht verändert.

Damit der ursprüngliche Wert ebenfalls
geändert werden kann, kann der Wert als **Verweis** (Reference) übergeben
werden. Dazu wird das Schlüsselwort [ref](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/ref) verwendet.

```csharp
int zahl = 2;
Addiere(ref zahl);
...
Addiere(ref int zahlTemp) {
    // die Variable Zahl wird überschrieben
    zahlTemp = zahlTemp + 5;
}
```


<!-- .slide: class="left" -->
## Out Parameter (Ausgabeparameter)

Ausgabeparameter ([out](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/out-parameter-modifier)) verhalten sich genau wie ref-Parameter, nur dass diesen nicht initialisierte Variablen übergeben werden können.

Dieser Parameter wurden spezielle für den Fall entwickelt das eine
Methode mehrere Werte zurückgeben soll. Dieser Parameter übergibt der
Methode keinen Wert, sondern teilt ihr mit, in welcher Variable sie
einen bestimmten Wert speichern soll z.B. wird dies bei TryParse verwendet.

```csharp
Addiere(10, 5, out int result);

bool Addiere(int zahl1, int zahl2, out int result) {
    result = zahl1 + zahl2;

    if (result > 10){
         return true;
    } else {
        return false;
    }
}
```

Note: **VS** Sichtbarkeit und Methoden

