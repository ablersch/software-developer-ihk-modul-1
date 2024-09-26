# Strings und Chars

Zeichenketten und Zeichen in C#

---

<!-- .slide: class="left" -->
## Was sind Strings

Eine [string](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/string) Variable enthält eine Sammlung von Zeichen, die von doppelten Anführungszeichen umgeben sind.

```csharp []
string zeichenkette;

zeichenkette = "Hallo C#";
Console.Write(zeichenkette); // Ausgabe: Hallo C#

zeichenkette = zeichenkette + " - Fans\n";
Console.Write(zeichenkette); // Hallo C# - Fans
```

---

<!-- .slide: class="left" -->
## String Zugriff über Index

* Ein Zeichen (`char`) über Index abrufen

```csharp []
string text = "Hello";
Console.WriteLine(text[0]);  // Ausgabe: H
```

* Index abrufen

```csharp []
Console.WriteLine(text.IndexOf("l"));  // Ausgabe 2
```

---

<!-- .slide: class="left" -->
## String Methoden

* String Vergleich

```csharp []
string text = "IHK Ulm";
if (text == "IHK Ulm")       // => true
if (text.Equals("IHK Ulm"))  // => true
if (text.Equals("ihk ulm", StringComparison.OrdinalIgnoreCase))  // => true
```

* Prüfen ob der String ein Zeichen beinhaltet
  
```csharp []
if (text.Contains("U")) // => true
```

* Länge eines Strings ermitteln

```csharp []
int i = text.Length;
```

---

<!-- .slide: class="left" -->
## String Methoden

* Umwandeln in String

```csharp []
text = text + i;     //.ToString()
// Alternativ: text += i;
```

* Teilstring von Index 0 bis Index 2

```csharp []
text = text.Substring(0, text.IndexOf("K") + 1); // Array Index beginnt bei 0
```

* Teile eines Strings ersetzen

```csharp []
text = text.Replace("H", "A");
```

Note: 
weitere Methoden zeigen in **VS**. z.B.: 
* string.IsNullOrEmpty
* Trim 
* Remove
* ToUpper 
* ...

**ÜBUNG** Email

---

<!-- .slide: class="left" -->
## Stringkonvertierung

* Konvertierung eines Strings in `int` mit der Klasse `Convert`

```csharp []
string text = "580";
int zahl = Convert.ToInt32(text);
```

* Konvertierung mit `Parse`

```csharp []
zahl = int.Parse(text);
```

* Prüfen ob Konvertierung möglich ist mit `TryParse`

```csharp []
bool result = Int32.TryParse(text, out var zahl);  
if (!result) 
{
    Console.WriteLine("Umwandlung fehlgeschlagen");
}
```

* Konvertierung von `double` nach `int`

```csharp []
double zahl = 12.66789;
int intZahl = Convert.ToInt32(zahl);  // gerundet 13
```

Mehr zum Thema [String Konvertierung](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)

Note: Bei Convert und Parse Fehler abfangen.

---

<!-- .slide: class="left" -->
## Stringverkettung

* Verkettung mit "+"-Operator

```csharp
Console.WriteLine("Die Summe von "+ a + " plus " + b + " ist " + (a+b)));
```

* Interpolation

```csharp
Console.WriteLine($"Die Summe von {a} plus {b} ist {a+b}");
```

* StringBuilder

```csharp []
StringBuilder sb = new StringBuilder();
sb.Append("Die Summe von ");
sb.Append(a);
sb.Append(" plus ");
sb.Append(b);
sb.Append(" ist ");
sb.Append(a+b);
```

Mehr zum Thema [String Verkettung](https://docs.microsoft.com/de-de/dotnet/csharp/how-to/concatenate-multiple-strings)

---

<!-- .slide: class="left" -->
## Stringformatierung

* Abstände bei der Ausgabe (vor bzw nach dem Wert 10 Stellen frei)
```csharp
Console.WriteLine($"Die Summe von {a,-10:D} plus {b,-10:D} ist {a + b,10:D}."); 
// Die Summe von 1     plus 2          ist           3.
```

* Feste Angabe der Nachkommastellen
```csharp
Console.WriteLine($"Wert {1:F1} und Wert {2:F2}");
// Wert 1,0 und Wert 2,00
```

* Ausgabe muss mindestens 8 Dezimalstellen haben.
```csharp
int value = 12345;
Console.WriteLine($"{value:D8}"); 
// Alternativen:
Console.WriteLine(value.ToString("D8")); 
Console.WriteLine(string.Format("{0:D8}", value));
// 00001234
```

---

<!-- .slide: class="left" -->
## Stringformatierung

* Währungsformatierung
```csharp
// UTF 8 Kodierung nutzen wegen Darstellung Eurozeichen
Console.OutputEncoding = System.Text.Encoding.UTF8; 
Console.WriteLine($"Kontostand: {value:C}.");
// Kontostand:  12.345,00 €.
```

* Eigene Formate (Telefonnummern, Postleitzahlen, ....)
```csharp
Console.WriteLine(value.ToString("[##-##-##]")); 
// [1-23-45]
Console.WriteLine($"{value:D-#######}"); 
// D-12345
```

* Datumsformatierung
```csharp
Console.WriteLine($"Es ist jetzt {DateTime.Now:HH:mm}"); 
// Es ist jetzt 14:25
Console.WriteLine($"Es ist das Jahr {DateTime.Now:yyyy}");
// Es ist das Jahr 2024
```

Mehr zum Thema [Stringformatierung 1](https://docs.microsoft.com/de-de/dotnet/standard/base-types/formatting-types),  
[Stringformatierung 2](https://freeasphosting.net/format-string-in-csharp-string-interpolation.html) und [Datumsformatierung](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings)

Note: Platzhalter können mehrfach verwendet werden.
{0,-20:D} rechts der Zahl 20 Stellen frei

---

<!-- .slide: class="left" -->
## Escape-Sequenzen

[Escape-Sequenzen](https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170) werden normalerweise verwendet, um Aktionen wie Wagenrücklauf und Tabulatorbewegungen an Terminals und Druckern auszuführen.

| Zeichen      | Beschreibung
| -------------|-------------|
| `\b`         | Backspace
| `\n`         | Neue Zeile
| `\r`         | Zeilenumbruch
| `\t`         | Tabs
| `\\`         | Sonderzeichen z.B. \

```csharp
Console.Write("You pressed \n");
```

---

<!-- .slide: class="left" -->
## Char

Das Schlüsselwort `char` (Character) repräsentiert ein einzelnes Zeichen.

Verwendet das [Unicode-Zeichensystem (UTF-16 )](https://www.unicode.org/charts/PDF/U0000.pdf) Dadurch können Zeichen aus nahezu allen Schriftsprachen der Welt dargestellt werden, einschließlich Sonderzeichen, Symbole und Emojis.

```csharp
char a = 'A';
char a = '\u0041'; // Unicode für A (Hexadezimal)
char a = (char)65; // Unicode für A (Dezimal)
char heart = '\u2665'; // Unicode für das Herzsymbol

char[] ch = new char[2];
ch[0] = 'A';        // Character literal
ch[1] = 'B';        // Character literal
```

Note: `(char)65` bezieht sich sowohl auf einen ASCII- als auch auf einen Unicode-Wert. In ASCII steht 65 für das Zeichen „A“. 

Unicode ist als Obermenge von ASCII konzipiert, so dass das Zeichen „A“ in Unicode ebenfalls den Codepunkt 65 in Dezimalschrift hat. 

Somit ist (char)65 sowohl in ASCII als auch in Unicode gültig, da Unicode den ursprünglichen ASCII-Satz in seinen ersten 128 Werten umfasst.

Hex wird in der Regel in Unicode-Notation verwendet, geschrieben als „U+0041“. https://www.asciitable.com/

---

<!-- .slide: class="left" -->
## Konvertierung in numerische Werte

Ein `char` kann in seinen entsprechenden numerischen Wert (den Unicode-Codepunkt) konvertiert werden, da er intern als Ganzzahl gespeichert wird:

```csharp
char letter = 'A';
int unicodeValue = (int)letter;
Console.WriteLine(unicodeValue); // Ausgabe: 65
```

Umgekehrt kann eine Zahl auch in ein Zeichen konvertiert werden:

```csharp
int code = 65;
char letter = (char)code;
Console.WriteLine(letter); // Ausgabe: 'A'
```

---

<!-- .slide: class="left" -->
## Char Methoden

* String in `char` konvertieren
```csharp
char sign = char.Parse("A");
```

* Prüfen ob ein `char` ein Buchstabe ist
```csharp
Char.IsLetter('B')
```

* Prüfen ob ein `char` eine Zahl ist
```csharp
Char.IsDigit('1')
```

* Zeichen in Groß - Kleinbuchstaben wandeln
```csharp
Char.ToUpper('a')
Char.ToLower('A')
```

Note: 
* Mit einer Schleife einen String als char weiterverarbeiten.
`foreach (char c in input){}`
* **ÜBUNG** Pangramm