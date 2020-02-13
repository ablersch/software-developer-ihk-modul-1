# Kontrollstrukturen

Durch [Kontrollstrukturen](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/selection-statements) sind wir in der Lage, Programme nicht nur sequentiell, also Zeile für Zeile, ablaufen zu lassen. Wir haben die
Möglichkeit Programme sinnvoll zu strukturieren und zu steuern.


<!-- .slide: class="left" -->
## IF-ELSE - Anweisung

```csharp
int testValue = 1;
string text;

if (testValue == 0)
{
    text = "Bedingung erfüllt";
}
else  
{
    text = "Bedingung nicht erfüllt"
}
```

[Bedingungsoperator (Frageoperator)](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/conditional-operator) liefert immer einen Ausdruck bzw. eine Wertzuweisung: **?:**

```csharp
string text = (testValue == 0) ? "erfüllt" : "nicht erfüllt";
```

Mehr zum Thema [IF-ELSE](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/if-else)

Note: if(else) + tab + tab


<!-- .slide: class="left" -->
## SWITCH-CASE - Anweisung

Bei der SWITCH-Anweisung wird der Ausdruck in der Anweisung ausgewertet
und in Abhängigkeit des ganzzahligen Ausdrucks zum entsprechenden CASE
gesprungen.

```csharp
int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
```

Note: switch + tab + tab


<!-- .slide: class="left" -->
**NEU:** C\# erlaubt auch **Strings** als Switch-Variable:

```csharp
string str = "Stuttgart";
switch (str)
{
   case "Ulm":
        Console.WriteLine("Case 1");
        break;
    case "Stuttgart":
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
```

Mehr zum Thema [SWITCH-CASE](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/switch)


<!-- .slide: class="left" -->
# Schleifen (Iterationen)
## For-Schleife

```csharp
for( int i=0; i < 10; i++ )
{
    Console.WriteLine("i hat den Wert: " + i);
}
```

Mehr zum Thema [For-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/for)

Note: for (aufsteigender Counter) fore (absteigender Counter) + tab + tab


<!-- .slide: class="left" -->
## While-Schleife

```csharp
int i = 0;
while( i < 99 )
{
    Console.WriteLine("i hat den Wert: " + i);
    i++;
}
```
Mehr zum Thema [While-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/while)


<!-- .slide: class="left" -->
## Foreach-Anweisung

Die [foreach-Anweisung](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/foreach-in) kann auf Arrays und für jede Klasse eingesetzt
werden, die die Schnittstelle IEnumerable implementiert. Fehler mit
falscher Indexierung sind nicht mehr möglich.

**For Schleife:**

```csharp
double [] meinArray = new double [] { 1.1, 1.2, 1.3, 1.4, 1.5 };
for(int i=0; i < meinArray.Length; i++)
{
    Console.WriteLine($"{meinArray[i]}\n");
}
```

**Foreach:**

```csharp
foreach (double meinWert in meinArray)
{
    Console.WriteLine($"{meinWert}\n");
}
```

**Achtung:** Der foreach-Bezeichner "meinWert" ist schreibgeschützt. Er
kann also nicht zur Zuweisung von Arraywerten verwendet werden!

Note: Sinnvoll wenn alle Werte durchlaufen werden sollen aber kein Index benötigt wird.

GetEnumerator() Index abgerufen und bearbeitet werden

foreach + tab + tab


<!-- .slide: class="left" -->
# Sprunganweisungen

## Break und Continue

```csharp
// Schleife komplett beenden, Execute nie ausführen
for (int i = 0; i < 10; i++) {
    if (i == 0) break;
    Execute("DoSomething");
}
```

```csharp
// Execute nur beim ersten Durchlauf nicht ausführen.
// Continue beginnt nächste Iteration
for (int i = 0; i < 10; i++) {
    if (i == 0) continue;
    Execute("DoSomething");
}
```

Mehr zum Thema [Sprunganweisungen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/jump-statements)


<!-- .slide: class="left" -->
## Gültigkeitsbereich von Variablen

**Eine Variable steht immer nur innerhalb ihres Geltungsbereichs zur Verfügung.**

* keine globalen Variablen
* innerhalb einer Klasse
* innerhalb einer Methode. z.B. die übergebenen Argumente, aber auch für andere Zwischenwerte, die nur in dieser Methode benötigt werden.
* innerhalb eines Blocks. z.B. Laufvariablen in for- und foreach-Schleifen oder auch eine Variable innerhalb eines if-Zweigs.

Außerhalb dieses Bereichs steht eine Variable nicht zur Verfügung: Sie ist dort unbekannt (Ihr Wert kann nicht genutzt werden).


<!-- .slide: class="left" -->
### Deklaration von Variablen

Das führt zur Frage, wo eine Variable deklariert werden sollte. Dafür gilt vorrangig die Frage der Lesbarkeit:

* Eine Variable, die nur innerhalb eines winzigen Code-Teils benötigt wird, sollte dort deklariert werden.

* Eine Variable, die als **var** deklariert wird, kann erst dort deklariert werden, wo sie (erstmals) einen Wert zugewiesen bekommt.

* Andere lokale Variable sollten möglichst zusammenhängend am Anfang eines Code-Teils deklariert werden.

* Auch Klassenvariable sollten innerhalb der Klasse an einer sinnvollen Stelle stehen.

Note: **VS** Sichtbarkeit von Variablen zeigen (Klasse, Methode, If, ...).
ÜBUNG Fakultät, Palindrom (wdh von C), Passwort und Medienverwaltung 1
