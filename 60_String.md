# Strings

Bei [**string**](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/string) handelt es sich um eine Klasse mit Methoden. Damit kann mit Zeichenketten gearbeitet werden.

```csharp
string zeichenKette;

zeichenKette = "Hallo C#";
Console.Write(zeichenKette);

zeichenKette = zeichenKette + " - Fans\n";
Console.Write(zeichenKette);

Ausgabe:
========
Hallo C#
Hallo C# - Fans
```


<!-- .slide: class="left" -->
### String Methoden

* String Vergleich

```csharp
string text = "IHK Ulm";
if (text == "IHK Ulm")       // => true
if (text.Equals("IHK Ulm"))  // => true
if (text.Equals("ihk ulm", StringComparison.OrdinalIgnoreCase))  // => true
```

* Länge eines Strings ermitteln

```csharp
int i = text.Length;
```

* Umwandeln in String

```csharp
text = text + i;     //.ToString()
text += i;
```

* Teilstring von Index 0 bis Index 2

```csharp
text = text.Substring(0, text.IndexOf("K") +1); // Array Index beginnt bei 0
```

* Teile eines Strings ersetzen

```csharp
text = text.Replace("H", "A");
 ```

Note: weitere Methoden zeigen in **VS**. z.B. string.IsNullOrEmpty, Trim, Remove, ...


<!-- .slide: class="left" -->
### String Formatierung

```csharp
// 00001234
int value = 12345;
Console.WriteLine(value.ToString("D8"));

// [1-23-45]
Console.WriteLine(value.ToString("[##-##-##]"));
 ```

Mehr zum Thema [String Formatierung](https://docs.microsoft.com/de-de/dotnet/standard/base-types/formatting-types)


<!-- .slide: class="left" -->
### String Konvertierung

* Konvertierung eines Strings in int mit der Klasse **Convert**

```csharp
string text = "580";
int zahl = Convert.ToInt32(text);
```

* Konvertierung mit **Parse**

```csharp
zahl = Int32.Parse(text);
```

* Prüfen ob Konvertierung möglich ist mit **TryParse**

```csharp
//Ref Parameter
bool result = Int32.TryParse(text, out var zahlVariable);  
if (!result) {
    Console.WriteLine("Umwandlung fehlgeschlagen");
}
```

* Konvertierung von **double** nach int

```csharp
double zahl = 12.66789;
int intZahl = Convert.ToInt32(zahl);  // gerundet 13
```

Mehr zum Thema [String Konvertierung](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)

Note: Bei Convert und Parse Fehler abfangen


<!-- .slide: class="left" -->
## Ein- und Ausgabe

Einige wichtige Methoden zur Ein- und Ausgabe gehören zur Klasse [Console](https://docs.microsoft.com/de-de/dotnet/api/system.console?view=netframework-4.7.2) im
Namespace System. Sie lauten:

| Methode      | Beschreibung
| -------------|-------------|
| `Clear()`     | Konsolenfenster leeren
| `ReadLine()` | Liest eine Zeile als **string** von der Konsole.
| `Write()`    | Gibt einen String auf der Konsole ohne Zeilenumbruch aus.
| `WriteLine()`| Entspricht Write() nur mit Zeilenumbruch.
| `ReadKey()`  | Liest ein eingegebenes Zeichen als `ConsoleKeyInfo`.

Es gibt mehrere Möglichkeiten, um eine bestimmte Ausgabe zu erzeugen.

**Beispiel:** Es soll die Ausgabe *"Die Summe von 1500 plus 500 ist
2000"* erzeugt werden.

Note: cw (if, for, ...) + tab + Tab in **VS** zeigen Daten von Console lesen. ConsoleKeyInfo zeigen.


<!-- .slide: class="left" -->
### Lösung (String Verkettung)

* Verkettung mit "+"-Operator

```csharp
Console.WriteLine("Die Summe von "+ a + " plus " + b + " ist " + sum);
```

* Einsatz von Platzhaltern

```csharp
Console.WriteLine("Die Summe von {0} plus {1} ist {2}", a, b, sum);
Console.WriteLine($"Die Summe von {a} plus {b} ist {sum}");
```

* Einsatz von Platzhaltern (erweiterte Formatierung)

```csharp
// Festkomma ,0 ,00 ,000
Console.WriteLine("Die Summe von {0:F1} plus {1:F2} ist {2:F3}", a, b, sum); 
```

* Einsatz von Platzhaltern (erweiterte Formatierung)

```csharp
Console.WriteLine("Die Summe von {a,-20:D} plus {b,-20:D} ist {sum,-20:D}");
```

Mehr zum Thema [String Verkettung](https://docs.microsoft.com/de-de/dotnet/csharp/how-to/concatenate-multiple-strings)

Note: Platzhalter können mehrfach verwendet werden.

{0,-20:D}  rechts der Zahl 20 Stellen frei

**ÜBUNG** Array