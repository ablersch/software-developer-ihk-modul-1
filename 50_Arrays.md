# Arrays

Was sind Arrays? Wozu werden diese benötigt? Wie werden sie genutzt?


<!-- .slide: class="left" -->
## Was ist ein Array?

Ein [Array](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/arrays/) ist ein Datencontainer welcher mehrere Elemente vom gleichen Datentyp aufnehmen kann und dies in einer Variable speichert.


<!-- .slide: class="left" -->
## Deklaration und Initialisierung

Arrays werden definiert in dem nach dem Datentyp eckige Klammern folgen.

```string[] cars```

Dieses Array nimmt Elemente vom Datentyp string auf.
Werte können direkt beim anlegen dem Array hinzugefügt werden.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] numbers = {10, 20, 30, 40};
```


<!-- .slide: class="left" -->
## Deklaration und Initialisierung

Ein Array besitzt immer eine definierte Länge die beim erstellen angegeben wird. Nach dem erstellen kann die Länge nicht mehr geändert werden.

1. ```int[] numbers = {10, 20, 30, 40}; // Array nimmt 4 Elemente auf```
2. ```int[] array = new int[5]; // Array nimmt 5 Elemente auf```


<!-- .slide: class="left" -->
## Zugriff auf die Array Daten

Elemente im Array werden immer mit einem Index identifiziert. Dieser beginnt immer bei 0!

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]); // Outputs Volvo

cars[1] = "Audi"; // 2. Wert ändern

Console.WriteLine(cars.Length) // Länge des Arrays
```


<!-- .slide: class="left" -->
## Zugriff auf alle Array Daten

Dazu muss jedes Element in einer Schleife abgerufen werden.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
```

<!-- .slide: class="left" -->
## Übung 3

TODO einfaches Array

<!-- .slide: class="left" -->
## Mehrdimensionale Arrays

Bsp

https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

