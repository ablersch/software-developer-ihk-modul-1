# C# Grundlagen

Grundlagen, Programmaufbau, Codekonventionen, Kommentare, Strings, Methoden, Operatoren, Iterationen


<!-- .slide: class="left" -->
## C Sharp

* C\# (gesprochen "C Sharp") wurde bei Microsoft von Anders Hejlsberg 2001 entwickelt.

* Die aktuelle Version C\# 8 wurde 2019 mit dem Microsoft .NET Framework 4.8 bzw .NET Core veröffentlicht.

* Die Programmiersprache ist voll objektorientiert und beinhaltet verschiedene Elemente aus den Sprachen C, C++, Java, Pascal und Basic.

* C\# wurde wie Java auf Hardwareunabhängigkeit entwickelt (.NET Framework und .NET Core).

* [TOP 20 Programmiersprachen](https://fossbytes.com/most-popular-programming-languages/)


<!-- .slide: class="left" -->
## Entwicklungsumgebungen

Zur Erstellung eines C\# Programms wird eine Entwicklungsumgebung (IDE - Integrated Development Environment) benötigt.

* [Visual Studio](https://visualstudio.microsoft.com/de/)
* JetBrains Raider
* Visual Studio Code
* Mono Develop

<!-- .slide: class="left" -->
### Visual Studio

Bild

Note: 
* Visual Studio Aufbau
* Einstellungen


<!-- .slide: class="left" -->
## Programmaufbau

```csharp
using System; // Assemblies einbinden (Klassen aus dem System Namespace nutzen)

namespace Programmaufbau //Projektteile werden in Namensräumen (Container) zusammengefasst
{ // markiert den Beginn eines Codeblocks
    class Program // Bauplan für Abbildung von realen Objekten. ALles muss in einer Klasse laufen
    {
        static void Main(string[] args) // Einstiegspunkt mit Parameter Array
        {
            Console.WriteLine("IHK"); // Den Wert in der Console ausgeben
        }
    }
} // markiert das Ende eines Codeblocks
```

Note: Static kann ausgeführt werden ohne Instanz einer Klasse. Daraus können selbst nur statische Methoden aufgerufen werden.
Alle Zeilen werden mit Strichpunkt abgeschlossen

Zeigen in **VS**, Projekt erstellen


<!-- .slide: class="left" -->
## Namensräume

* Klassen und Methoden können in sogenannten Namensräumen (engl. Namespaces) hierarchisch geordnet werden.

* Damit auf Klassen eines [Namensraums](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/namespaces/using-namespaces) zugegriffen werden kann, muss ein Verweis auf den Namensraum bestehen (siehe Projektmappenexplorer).

* Ein Namespace wird mit `using` eingebunden

![Namespace](images/Namespace.png)


<!-- .slide: class="left" -->
## Codekonventionen

* Generell sind nur Buchstaben erlaubt, keine Zahlen oder Sonderzeichen.
* Pascal-Schreibweise (jeden Anfangsbuchstaben eines Wortes groß)
    * bei Klassen- und Methodennamen
    * **WriteToErrorLog()**
* Camel-Schreibweise (jeden Anfangsbuchstaben eines Wortes groß, außer beim ersten Wort)
    * bei Variablen
    * **string exportFilePath**
* Großbuchstaben
    * bei Konstanten
    * **APPLICATIONPATH = "xxxx"**
* aussagekräftige Namen verwenden
* Mehr zum Thema [Namenskonvention](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/naming-guidelines)


<!-- .slide: class="left" -->
## Codekonventionen

* Einrückungen immer nur per Tab (4 Zeichen) nicht mit Leerzeichen
* ein Namespace und eine Klasse pro Datei
* nur eine Variable auf einmal deklarieren
* nicht selbsterklärende Stellen im Code kommentieren
* zum Kommentieren innerhalb eines Codeblocks nicht /\* \...\*/ benutzen sondern // oder ///


<!-- .slide: class="left" -->
## XML-Kommentare

* Durch die Verwendung von XML Tags kann der Code kommentiert und diese Kommentare auch mit Intelli-Sense angezeigt werden.
* Ein Export zu Dokumentationszwecken ist möglich.
* Das Grundgerüst wird automatisch generiert.
* Mehr zum Thema [XML-Kommentare](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)

```csharp
/// <summary>
/// Beschreibung der Methode
/// </summary>
/// <param name="args">Parameter beschreiben</param>
/// <returns>Return Wert beschreiben</returns>
```

Note: In VS zeigen

* VS Layout umstellen
* Projekt anlegen
* Methoden autom erstellen
* Codevervollständigung
* Intelli Sense


<!-- .slide: class="left" -->
## Datentypen in C#

| Datentyp  | Größe        | Beschreibung  |
| ------------- |-------------| -----|
| bool      | 1 Bit             | true (1) oder false (0) |
| byte      | 8 Bit    | Zahlen von 0 bis 255  |
| sbyte     | 8 Bit     | Zahlen mit Vorzeichen von -128 - 127    |
| char      | 16 Bit           | Speichert ein einzelnes Zeichen/Buchstabe |
| decimal   | 128 Bit  | Zahl mit Dezimalstellen     |
| double    | 64 bit  | Speichert Kommazahlen. Ausreichend für die Speicherung von 15 Dezimalziffern    |
| float     | 32 Bit  | Speichert Kommazahlen. Ausreichend für die Speicherung von 6 bis 7 Dezimalziffern    |
| int       | 32 Bit  | Ganze Zahlen von -2 147 483 648 bis 2 147 483 647    |
| long      | 64 Bit  | Ganze Zahlen von -9,223,372,036,854,775,808 bis 9,223,372,036,854,775,807    |
| ulong     | 64 Bit  | 0 bis 18.446.744.073.709.551.615    |
| object    |   |     |
| short     | 16 Bit  | Ganzzahlen mit Vorzeicvhen von –32.768 bis 32.767    |
| ushort    | 16 Bit  | Ganzzahlen ohne Vorzeichen von 0 bis 65.535    |
| string    | 16 Bit | Speichert eine Zeichenfolge   |


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


## Beispiel

```csharp
Console.Write("I");
Console.Write("H");
Console.Write("K");
// Ausgabe: IHK

Console.WriteLine("IHK")
``` 

Note: Übung 1 (Projekt erstellen und etwas in der Console ausgeben)
