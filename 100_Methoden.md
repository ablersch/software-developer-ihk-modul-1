# Methoden

Was sind Methoden? Warum soll man Methoden benutzen?

---

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

---

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
* Pascal-Schreibweise (jeden Anfangsbuchstaben eines Wortes groß)

---

<!-- .slide: class="left" -->
## Methode aufrufen

Eine Methode kann mehrfach aufgerufen werden.

```csharp []
static void Main(string[] args)
{
    MyMethod();
}
```

---

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

---

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

---

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

---

<!-- .slide: class="left" -->
## Methodensignatur

![Methodensignatur](images/Methodensignatur.png)

Note: **ÜBUNG** BMI
---

<!-- .slide: class="left" -->
## Überladen (Overloading)

Von **Überladen** spricht man, wenn mehrere Methoden den gleichen Namen
aber eine unterschiedliche Anzahl an Parametern oder unterschiedliche
Parametertypen haben.

```csharp []
void Multiplikation(double value)
void Multiplikation(int value)
void Multiplikation(int value, int result)
void Multiplikation(float valueA, float valueB, int result)
int Multiplikation(float valueA, float valueB, int result) // --> Fehler, nicht möglich
```

---

<!-- .slide: class="left" -->
## Optionale Parameter

Ein optionaler Parameter hat einen Standardwert. Die Methode, die optionale Parameter hat, kann ohne diese Argumente aufgerufen werden. Sie können aber auch angegeben werden. Dann werden die Standardwerte überschrieben.

```csharp []
public static void MethodWithOptParams(int first, int second = 10)
{
    Console.WriteLine(first + second);
}
MethodWithOptParams(20); // Ergebnis ist 30
MethodWithOptParams(20, 35); // Ergebnis ist 55
```

Note: 
**VS** Methoden
**ÜBUNG** Palindrom