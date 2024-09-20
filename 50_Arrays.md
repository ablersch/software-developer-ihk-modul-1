# Arrays

Was sind Arrays? Wozu werden diese benötigt? Wie werden sie genutzt?

---

<!-- .slide: class="left" -->
## Was ist ein Array?

Ein [Array](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/arrays/) ist ein Datencontainer welcher mehrere Elemente vom gleichen Datentyp aufnehmen kann und dies in einer Variable speichert.

Arrays werden definiert in dem nach dem Datentyp eckige Klammern folgen.

```csharp
string[] cars
```

Dieses Array nimmt Elemente vom Datentyp `string` auf.

---

<!-- .slide: class="left" -->
## Array Länge

Ein Array besitzt immer eine definierte Länge die beim erstellen angegeben wird. Nach dem erstellen kann die Länge nicht mehr geändert werden.

```csharp
// Array kann 5 Elemente aufnehmen. Beinhaltet Elemente mit ihrem Default Wert z.B. 0 bei int
int[] array = new int[5]
```

Werte können direkt beim initialisieren dem Array hinzugefügt werden.

```csharp []
// Arrays beinhaltet 4 Elemente
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] numbers = {10, 20, 30, 40};
```

Note: Collection Expression seid C# 12 `string[] names = ["Julia", "Anna", "Thomas"];`

---

<!-- .slide: class="left" -->
## Zugriff auf die Elemente im Array

Elemente in einem Array werden mit einem Index angesprochen und verändert. Dieser beginnt immer bei 0! D.h. das erste Element des Arrays ist auf dem Index 0. Das dritte Element den Index 2.

```csharp []
string[] animals = new string[3];

animals[0] = "Affe"; // 1. Elemente
animals[1] = "Tiger";
animals[2] = "Elefant"; // 3. Elemente

string item = animals[1]; // Das zweite Elemente in einer Variable speichern

Console.WriteLine(animals[1]); 
```

Länge des Arrays ermitteln:

```csharp []
Console.WriteLine(animals.Length);
```

---

<!-- .slide: class="left" -->
## Zugriff auf die Elemente im Array

Dazu das Array in einer Schleife Element für Elemente durchlaufen.

```csharp []
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// 1. Möglichkeit 
for (int i = 0; i < cars.Length; i++)
{
    // Zugriff auf den Wert an Stelle i
    Console.WriteLine(cars[i]);
}

// 2. Möglichkeit 
foreach (var car in cars) 
{
    Console.WriteLine(car);
}
```

Note: **ÜBUNG 7** Arrays

---

<!-- .slide: class="left" -->
## Index-out-of-range Fehler

Ist der Index größer als die Länge des Arrays kommt es zu einem `IndexOutOfRangeException` Fehler.

Hat das Array die Länge 4 und man möchte das Element auf dem Index 4 ansprechen kommt dieser Fehler da Index 4 das 5. Elemente wäre.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[4] = "Opel" // Fehler!
```

---

<!-- .slide: class="left" -->
## String zu Array konvertieren

Ein `string` kann sehr leicht in ein Array konvertiert werden:

```csharp
string names = "Anna;Tom;Kate;Tobias";
string[] namesArray = input.Split(';');
```

Note: **ÜBUNG 8** Temperaturstatistik 
