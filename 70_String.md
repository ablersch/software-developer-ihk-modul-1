# Strings

Zeichenketten in C#


<!-- .slide: class="left" -->
## Was sind Strings
Eine [string](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/string) Variable enthält eine Sammlung von Zeichen, die von doppelten Anführungszeichen umgeben sind.

```csharp
string zeichenKette;

zeichenKette = "Hallo C#";
Console.Write(zeichenKette); // Ausgabe: Hallo C#

zeichenKette = zeichenKette + " - Fans\n";
Console.Write(zeichenKette); // Hallo C# - Fans
```


<!-- .slide: class="left" -->
## String Zugriff

* Über Index

```csharp
string text = "Hello";
Console.WriteLine(text[0]);  // Ausgabe: H
```

* Index abrufen

```csharp
Console.WriteLine(text.IndexOf("l"));  // Ausgabe 2
```


<!-- .slide: class="left" -->
## String Methoden

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

Note: weitere Methoden zeigen in **VS**. z.B. string.IsNullOrEmpty, Trim, Remove, ToUpper ...


<!-- .slide: class="left" -->
## String Konvertierung

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
## String Verkettung

* Verkettung mit "+"-Operator

```csharp
Console.WriteLine("Die Summe von "+ a + " plus " + b + " ist " + (a+b)));
```

* Interpolation

```csharp
Console.WriteLine($"Die Summe von {a} plus {b} ist {a+b}");
```

* StringBuilder

```csharp
StringBuilder sb = new StringBuilder();
sb.Append("Die Summe von ");
sb.Append(a);
sb.Append(" plus ");
sb.Append(b);
sb.Append(" ist ");
sb.Append(a+b);
```

Mehr zum Thema [String Verkettung](https://docs.microsoft.com/de-de/dotnet/csharp/how-to/concatenate-multiple-strings)


<!-- .slide: class="left" -->
## String Formatierung

```csharp
// Nach dem Wert 20 Stellen frei
Console.WriteLine($"Die Summe von {a,-20:D} plus {b,-20:D} ist {a + b,-20:D}");

// Festkomma ,0 ,00 ,000
Console.WriteLine($"Die Summe von {a:F1} plus {b:F2} ist {a + b:F3}");

// Vor dem Wert 20 Stellen frei lassen und die Zahl PI mit 3 Nachkommastellen ausgeben
Console.WriteLine($"{Math.PI,20:F3}");

int value = 12345;
Console.WriteLine(value.ToString("D8")); // 00001234
Console.WriteLine(value.ToString("[##-##-##]")); // [1-23-45]

Console.WriteLine($"Hallo es ist jetzt {DateTime.Now:HH:mm}"); // Hallo es ist jetzt 14:25
Console.WriteLine($"Hallo es ist jetzt {DateTime.Now:t}");// Hallo es ist jetzt 14:25
```

Mehr zum Thema [String Formatierung 1](https://docs.microsoft.com/de-de/dotnet/standard/base-types/formatting-types) und 
[String Formatierung 2](http://www.ne555.at/2014/index.php/pc-programmierung/einfuehrung-c/274-strings-formatieren-mit-c.html)

Note: Platzhalter können mehrfach verwendet werden.
{0,-20:D}  rechts der Zahl 20 Stellen frei


<!-- .slide: class="left" -->
## Escape-Sequenzen

[Escape-Sequenzen](https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019) werden normalerweise verwendet, um Aktionen wie Wagenrücklauf und Tabulatorbewegungen an Terminals und Druckern auszuführen.

| Zeichen      | Beschreibung
| -------------|-------------|
| `\b`         | Backspace
| `\n`         | Neue Zeile
| `\r`         | Zeilenumbruch
| `\t`         | Tabs
| `\\`         | Sonderzeichen wie ", ', \

```csharp
Console.Write("You pressed \n");
```


<!-- .slide: class="left" -->
## Konsole

Die Klasse `Console` kann nicht nur Daten lesen und schreiben sondern auch:

```csharp
Console.BackgroundColor = ConsoleColor.DarkRed; //Hintergrundfarbe setzen
Console.ForegroundColor = ConsoleColor.White: //Vordergrundfarbe setzen
Console.Title = "IHK Ulm"; // Setzt den Titel im Konsolenfenster
Console.WindowHeight = 50; // Setzt die Fenster Höhe
Console.WindowWidth = 150; // Setzt die Fenster Breite
```


<!-- .slide: class="left" -->
###  Konsole

Mit ```ReadKey()``` kann die vom Benutzer gedrückte Taste abgerufen werden. Die Methode liefert ein ```ConsoleKeyInfo``` Objekt zurück. Damit kann auf die Eingabe zugegriffen werden mit folgende Eigenschaften:

* Key: Es kann auf bestimmte Tasten über die Enumeration ```ConsoleKey``` geprüft werden.
* KeyChar: Ruft das Unicode Zeichen ab (also das gedrückte Zeichen).
* Modifiers: Es kann auf bestimmte Tasten (z.b. SHIFT, ALT, CONTROL) über die Enumeration ```ConsoleModifiers``` geprüft werden.

```csharp
// ReadKey aufrufen und den Wert in einer lokalen Variable speichern
// Dann prüfen ob die gedrückte Taste ESC war
ConsoleKeyInfo info = Console.ReadKey();
if (info.Key == ConsoleKey.Escape)
{
    Console.WriteLine("You pressed escape!");
}
// Prüfen auf den Buchstaben 'a'
if (info.KeyChar == 'a')
{
    Console.WriteLine("You pressed a");
}

```

Note: cw (if, for, ...) + tab + Tab in **VS** zeigen. Daten von Console lesen. ConsoleKeyInfo zeigen.**ÜBUNG 6** Passwort