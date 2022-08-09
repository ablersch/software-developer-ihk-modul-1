# Methoden

Was sind Methoden? Warum soll man Methoden benutzen?


<!-- .slide: class="left" -->
## Methodendefinition

* Warum Methoden verwenden? Um Code wiederzuverwenden: Definieren Sie den Code einmal, und verwenden Sie ihn viele Male.
* Methoden können definierte Parameter entgegennehmen.
* Eine Methode kann nur einen oder auch keinen (void) Wert zurückgeben.
* Methoden werden innerhalb der Klasse ausformuliert.
* Methoden gehören immer zu einer Klasse.
* Eine Klasse kann mehrere Methoden enthalten, wobei die Methoden in beliebiger Reihenfolge deklariert werden können.
* Mit Methoden wird eine Aktion ausgeführt, Daten verändert oder ausgegeben.
* Der Codeblock einer Methode wird nur ausgeführt wenn die Methode aufgerufen wird.
* Mehr zum Thema [Methoden](https://docs.microsoft.com/de-de/dotnet/csharp/methods)

Note: In C# wird nur von Methoden gesprochen. Keine Unterscheidung wie in C von Funktion (mit Rückgabewert) oder Prozedur (void)


<!-- .slide: class="left" -->
## Syntax der Methodendefinition

Methoden werden innerhalb einer Klasse definiert. Mit:

**Zugriffsebene, Rückgabewert, Name und Parameter**

```csharp []
class Program
{
    static void MyMethod() 
    {
        // code to be executed
    }
}
```

Note: 
* MyMethod() Name der Methode
* static bedeutet, dass die Methode zur Klasse Program gehört und nicht zu einem Objekt der Klasse Program. 
* void Die Methode gibt keinen Wert zurück

Pascal-Schreibweise (jeden Anfangsbuchstaben eines Wortes groß)


<!-- .slide: class="left" -->
## Methode aufrufen

Name der Methode mit () und ;. 

Eine Methode kann mehrfach aufgerufen werden.

```csharp []
static void Main(string[] args)
{
    MyMethod();
}
```


<!-- .slide: class="left" -->
## Methodenparameter

Um an eine Methode Werte mitzugeben werden Parameter benötigt. Es können ein oder mehrere Parameter definiert werden.

Der Aufruf der Methode muss aber genau die gleiche Anzahl an Argumente haben wie die Methodendefinition Parameter.

```csharp []
static void MyMethod(string name) 
{
    Console.WriteLine($"Schüler: {name}");
}

static void Main(string[] args)
{
  MyMethod("Andreas");
  MyMethod("Lea");
  MyMethod("Ben");
}
```


<!-- .slide: class="left" -->
### Rückgabewerte

Das Schlüsselwort `void`, das in den obigen Beispielen verwendet wird, gibt an, dass die Methode keinen Wert zurückgeben soll. 

Wenn die Methode einen Wert zurückgeben soll, können Sie anstelle von void einen Datentyp (z. B. int oder double) verwenden und innerhalb der Methode das Schlüsselwort return verwenden:

```csharp []
static int MyMethod(int x) 
{
    return 5 + x;
}
```


<!-- .slide: class="left" -->
### Beispiel

```csharp []
using System;

namespace Programmaufbau;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ergebnis: " + Addition(12, 10));

        int result = Addition(10, 10);

        Console.WriteLine("Taste drücken um zu beenden...");
        Console.ReadKey();
    }

    // Neue Methode welche einen int Wert zurücklieferet und zwei int Werte als Parameter entgegen nimmt
    private static int Addition(int zahl1, int zahl2)
    {
        // Wert welcher zurück gegeben werden soll
        return zahl1 + zahl2;
    }
}
```


<!-- .slide: class="left" -->
## Überladen (Overloading)

Von **Überladen** spricht man, wenn mehrere Methoden den gleichen Namen
aber eine unterschiedliche Anzahl an Parametern oder unterschiedliche
Parametertypen haben.

```csharp []
void Multiplikation(double)
void Multiplikation(int)
void Multiplikation(int, int)
void Multiplikation(float, float, int)
int Multiplikation(float, float, int) // --> Fehler, nicht möglich
```

Note: 
**VS** Methoden
**ÜBUNG 7 und 8** Palindrom und Medienverwaltung 1


<!-- .slide: class="left" -->
## Ref Parameter

Es gibt zwei Möglichkeiten um Parameter an eine Methode zu übergeben:

* Parameterübergabe als Wert (**call by value**)
* Parameterübergabe als Verweis (**call by reference**)

Normalerweise wird **call by value** verwendet. Der Wert wird als **Kopie übergeben** und kann bearbeitet werden. Der ursprünglich übergebene Wert
wird dabei nicht verändert.

Damit der ursprüngliche Wert ebenfalls
geändert werden kann, kann der Wert als **Verweis** (Reference) übergeben
werden. Dazu wird das Schlüsselwort [ref](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/ref) verwendet.

```csharp []
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

```csharp []
Addiere(10, 5, out int result);

bool Addiere(int zahl1, int zahl2, out int result) {
    result = zahl1 + zahl2;

    if (result > 10){
         return true;
    } else {
        return false;
    }

    // return (result > 10)
}
```

Note: **VS** Ref und out zeigen