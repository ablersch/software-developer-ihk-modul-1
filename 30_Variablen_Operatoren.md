# Grundlagen Programmierung

Variablen und Operatoren

---

<!-- .slide: class="left" -->
## Variablen

In Variablen können Werte vom entsprechenden Datentypen gespeichert werden.
 
```csharp [1-2|4-5|6-7|8-9|10-11|12-13|14-15]
// Deklaration (Name und Datentyp wird bekanntgegeben)
int alter;

// mehrere Variablen deklarieren (nicht erwünscht)
int anzahl, summe;

// Variable initialisieren
alter = 30;

// Wert überschreiben
alter = 40;

// Deklarieren und initialisieren
decimal euro = 11.15;

// Wert benutzen/ausgeben
Console.Write(euro);

// Deklarieren und initialisieren über eine Consoleneingabe
string name = Console.ReadLine();
```

---

<!-- .slide: class="left" -->
## Variablen var

Variablen, die im Methodenbereich deklariert werden, können einen impliziten "Typ" `var` haben. Der Compiler bestimmt den Datentyp automatisch auf Basis des zugewiesenen Wertes.

Die folgenden zwei Deklarationen sind funktional äquivalent:

```csharp []
int i = 10; // explizit typisierte.
var i = 10; // implizit typisierte (es wird kein expliziter Datentyp angegeben).
```

mehr zum Thema [var](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var).

---

<!-- .slide: class="left" -->
## Konstanten

[Konstanten](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/constants) können nicht überschrieben werden. Der Wert ist also nur lesend zugreifbar. Der Wert muss beim deklarieren zugewiesen werden.
Sinnvoll wenn die Variable immer den gleichen Wert behalten soll z.B. (PI).

```csharp []
const double PI = 3.14159265359;
const int PAGE_SIZE = 50;
```

---

<!-- .slide: class="left" -->
## Operatoren

Ein [Operator](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/) ist ein Symbol, das mathematische oder logische Manipulationen ausführt.

---

<!-- .slide: class="left" -->
## arithmetische Operatoren

Erlauben mathematische Operationen auf Zahlen.
Eine Division durch 0 gibt ein Programmfehler

| Operator  | Name        | Beschreibung  |
| ----------|-------------| --------------|
| +         | Addition    |  |
| -         | Subtraktion    |  |
| *         | Multiplikation    |  |
| /         | Division    |  |
| %         | Modulo (Restoperator)      | Gibt den Teilungsrest zurück |
| ++        | Inkrement    | Wert um 1 erhöhen |
| --        | Dekrement    | Wert um 1 verringern |

```csharp []
int value = 5
int sum = 50 + value;
sum = sum++;
```

Note: 
* Punt vor Strich Regeln gelten.
    * Können durch Klammern umgangen werden.
    * Werte in der Klammer werden zuerst ausgeführt.
* Der Modulo-Operator wird als Restoperator bezeichnet, weil er den Rest einer ganzzahligen Division zurückgibt.

---

<!-- .slide: class="left" -->
## Postfix und Prefix

Das Prefix erhöht den Wert und fährt dann mit dem Ausdruck fort, während das Postfix den Ausdruck auswertet und dann die Inkrementierung durchführt.

* Prefix `++x`
* Postfix `x++`

```csharp []
int a = 50;
Console.WriteLine(++a);  // 51
Console.WriteLine(a);    // 51

a = 50;
Console.WriteLine(a++);  // 50
Console.WriteLine(a);    // 51
```

---

<!-- .slide: class="left" -->
## Zuweisungsoperatoren

Diese führen eine Aktion aus und weisen den Wert der Variable zu.

| Operator  | Beispiel    | Gleich wie  | Beschreibung |
| ----------|-------------| ------------| -------------|
| =         | `x = 5`     | `x = 5` |
| +=        | `x += 5`    | `x = x + 5` |
| -=        | `x -= 5`    | `x = x - 5` |
| *=        | `x *= 5`    | `x = x * 5` |
| /=        | `x /= 5`    | `x = x / 5` |
| %=        | `x %= 5`    | `x = x % 5` |
| &=        | `x &= 5`    | `x = x & 5` | logisches UND (bool und bit)
| \|=       | `x \|= 5`   | `x = x \| 5`| logisches ODER (bool und bit)

[Beispiele logische bit Operatoren](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators) und
[Bitweise und Verschiebungs-Operatoren](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators)

Note: & vergleicht immer beide Werte (Wobei && false liefert wenn bereits der erste Wert false ist).

---

<!-- .slide: class="left" -->
## Vergleichssoperatoren

| Operator  | Name        |
| ----------|-------------|
| ==        | Gleich      |
| !=        | Nicht gleich    |
| >         | Größer als   |
| <         | Kleiner als    |
| >=        | Größer als oder gleich   |
| <=        | Kleiner als oder gleich    |

---

<!-- .slide: class="left" -->
## logische Operatoren

| Operator  | Name             | Beschreibung
| ----------|------------------|-------------|
| &&        | logisches UND    | Gibt Wahr (true) zurück wenn beide Statements gleich sind
| \|\|        | logisches ODER   | Gibt Wahr (true) zurück wenn ein Statement Wahr ist
| !         | logisches NICHT  | Invertiert das Ergebnis. Gibt bei Wahr, Falsch (false) zurück

[Beispiele logische Operatoren](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-and-operator-)

---

<!-- .slide: class="left" -->
## Übung 2

1. Erstelle ein weiteres .Net Konsolen Projekt. Dieses fragt zwei Zahlenwerte (int) in der Konsole ab und gibt die Summe wieder aus.

2. Zusätzlich soll verglichen werden ob die beiden Zahlenwerte identisch sind. Wenn ja soll "true" ausgegeben werden, ansonsten "false".

3. Ändere dein Projekt damit es auch mit Kommazahlen arbeiten kann.
