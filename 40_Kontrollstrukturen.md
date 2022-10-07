# Kontrollstrukturen

Durch [Kontrollstrukturen](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/selection-statements) sind wir in der Lage, Programme nicht nur sequentiell, also Zeile für Zeile, ablaufen zu lassen sondern wir haben die
Möglichkeit Programme sinnvoll zu strukturieren und zu steuern.

---

<!-- .slide: class="left" -->
## IF-ELSE - Anweisung

```csharp []
var testValue = 50;
string text;

if (testValue == 50)
{
    text = "Bedingung erfüllt";
}
else  
{
    text = "Bedingung nicht erfüllt"
}
```

[Bedingungsoperator (Frageoperator)](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/conditional-operator) liefert immer einen Ausdruck bzw. eine Wertzuweisung: **?:**

```csharp []
var text = (testValue == 50) ? "erfüllt" : "nicht erfüllt";
```

Mehr zum Thema [IF](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/selection-statements#the-if-statemente)

Note: 
* if(else) + tab + tab. 
* If ist natürlich auch mit mehreren IF Zweigen erweiter- oder/und verschachtelbar.

---

<!-- .slide: class="left" -->
## SWITCH-CASE - Anweisung

Bei der SWITCH-Anweisung wird der Ausdruck in der Anweisung ausgewertet und in Abhängigkeit des ganzzahligen Ausdrucks zum entsprechenden CASE gesprungen.

```csharp []
int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break; // Beendet die Switch Ausführung
    case 2:
        Console.WriteLine("Case 2");
        break;
    default: // Optional, wird ausgeführt wenn kein Case Fall zutrifft
        Console.WriteLine("Default case");
        break;
}
```

Note: switch + tab + tab

---

<!-- .slide: class="left" -->
C\# erlaubt auch **Strings** als Switch-Variable:

```csharp []
var stadt = "Stuttgart";
switch (stadt)
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

Mehr zum Thema [SWITCH-CASE](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)

---

<!-- .slide: class="left" -->
## Schleifen (Iterationen)

Bei der Programmierung ist es oft erforderlich, einen Block von Befehlen mehrfach auszuführen.

Schleifen sind praktisch, weil sie Zeit sparen, Fehler reduzieren und den Code besser lesbar machen.

---

<!-- .slide: class="left" -->
### While-Schleife

While-Schleifen können einen Codeblock so lange ausführen, bis eine bestimmte Bedingung ```true``` ist.

```csharp []
int i = 0;
while (i < 99 )
{
    Console.WriteLine("i hat den Wert: " + i);
    i++;
}
```

Mehr zum Thema [While-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement)

---

<!-- .slide: class="left" -->
### Do-While-Schleife

Die do/while-Schleife ist eine Variante der while-Schleife. Diese Schleife führt den Codeblock einmal aus, bevor sie prüft, ob die Bedingung wahr ist, und wiederholt dann die Schleife, solange die Bedingung wahr ist.

```csharp []
int i = 0;
do
{
    Console.WriteLine("i hat den Wert: " + i);
    i++;
}
while (i < 99 )
```

Mehr zum Thema [Do-While-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement)

---

<!-- .slide: class="left" -->
### For-Schleife

Wenn Sie genau wissen, wie oft Sie einen Codeblock in einer Schleife durchlaufen wollen, verwenden Sie die for-Schleife anstelle einer while-Schleife.

![For-Schleife](images/for-loop.png)

---

<!-- .slide: class="left" -->
```csharp []
// i setzen bevor die Schleife beginnt
// Kondition die geprüft wird. i muss kleiner 10 sein
// Erhöht den Schleifenzähler nach jedem Schleifendurchlauf
for (int i = 0; i < 10; i++ )
{
    // Start bei 0 - 9 (10 Iterationen)
    Console.WriteLine("i hat den Wert: " + i);
}
```

Mehr zum Thema [For-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement)

Note: 
* for (aufsteigender Counter) + tab + tab 
* fore (absteigender Counter) + tab + tab
* int n = int.Parse(Console.ReadLine());

---

<!-- .slide: class="left" -->
## Übung

Erstelle ein weiteres .Net Konsolen Projekt. Dieses fragt einen Zahlenwerte (int) in der Konsole ab.
Nun soll in einer Schleife solange von 1 beginnend immer die nächste Zahl bis zum eingegeben Wert ausgegeben werden.
Was muss getan werden um vom eingegebenen Zahlenwert bis zur 1 zu kommen?

Beispiel

```csharp []
Bitte eine Zahl eingeben:
'5'
1
2
3
4
5
```

---

<!-- .slide: class="left" -->
### verschachtelte Schleifen

Eine Schleife kann beliebig verschachtelt werden, d.h. in einer Schleife können wir eine weitere Schleife ausführen.

Ein Quadrat mit n-Zeilen zeichnen, die jeweils n-mal das Zeichen **=-** enthalten:

```csharp []
// Wieviel Schleifendruchläufe
int n = int.Parse(Console.ReadLine());
// Äußere Schleife (erzeugt neue Zeile)
for (int row = 1; row <= n; row++)
{
    // Innere Schleife (Schreibt den Inhalt in die Zeile)
    for (int col = 1; col <= n; col++)
    {
        Console.Write("=-");
    }
    // Erzeugt eine neue Zeile
    Console.WriteLine();
}
```

Note: **Übung 3** verschachtelte Schleife

---

<!-- .slide: class="left" -->
### Foreach-Anweisung

Die [foreach-Anweisung](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statementn) kann auf Arrays und für jede Klasse eingesetzt
werden, welche die Schnittstelle IEnumerable implementiert. Fehler mit falscher Indexierung sind nicht mehr möglich.

**For Schleife:**

```csharp []
double [] meinArray = new double [] { 1.1, 1.2, 1.3, 1.4, 1.5 };
for(int i=0; i < meinArray.Length; i++)
{
    Console.WriteLine($"{meinArray[i]}\n");
}
```

**Foreach:**

```csharp []
foreach (var meinWert in meinArray)
{
    Console.WriteLine($"{meinWert}\n");
}
```

**Achtung:** Der foreach-Bezeichner "meinWert" ist schreibgeschützt. Er
kann also nicht zur Zuweisung von Array Werten verwendet werden!

Note: Sinnvoll wenn alle Werte durchlaufen werden sollen aber kein Index benötigt wird.

Mit GetEnumerator() kann Index abgerufen und bearbeitet werden.

foreach + tab + tab

---

<!-- .slide: class="left" -->
## Sprunganweisungen

### Break und Continue

```csharp []
// Schleife komplett beenden, Execute nie ausführen
for (int i = 0; i < 10; i++) {
    if (i == 0) break;
    Execute("DoSomething");
}
```

```csharp []
// Execute nur beim ersten Durchlauf nicht ausführen.
// Continue beginnt nächste Iteration
for (int i = 0; i < 10; i++) {
    if (i == 0) continue;
    Execute("DoSomething");
}
```

Mehr zum Thema [Sprunganweisungen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/jump-statements)

---

<!-- .slide: class="left" -->
## Gültigkeitsbereich von Variablen

**Eine Variable steht immer nur innerhalb ihres Geltungsbereichs zur Verfügung.**

* keine globalen Variablen
* innerhalb einer Klasse
* innerhalb einer Methode. z.B. die übergebenen Argumente, aber auch für andere Zwischenwerte, die nur in dieser Methode benötigt werden.
* innerhalb eines Blocks. z.B. Laufvariablen in for- und foreach-Schleifen oder auch eine Variable innerhalb eines if-Zweigs.

Außerhalb dieses Bereichs steht eine Variable nicht zur Verfügung: Sie ist dort unbekannt (ihr Wert kann nicht genutzt werden).

---

<!-- .slide: class="left" -->
### Deklaration von Variablen

Das führt zur Frage, wo eine Variable deklariert werden sollte. Dafür gilt vorrangig die Frage der Lesbarkeit:

* Eine Variable, die nur innerhalb eines winzigen Code-Teils benötigt wird, sollte dort deklariert werden.

* Eine Variable, die als [var](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/var) deklariert wird, kann erst dort deklariert werden, wo sie (erstmals) einen Wert zugewiesen bekommt.

* Andere lokale Variablen sollten möglichst zusammenhängend am Anfang eines Code-Teils deklariert werden.

* Auch Klassen Variablen sollten innerhalb der Klasse an einer sinnvollen Stelle stehen.

Note: **VS** Sichtbarkeit von Variablen zeigen (Klasse, Methode, If, ...).
Var
**ÜBUNG 4** Fakultät
