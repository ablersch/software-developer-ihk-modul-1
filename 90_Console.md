# Konsole

Arbeiten mit der Konsole.

---

<!-- .slide: class="left" -->
## Konsole anpassen

Die Klasse `Console` kann nicht nur Daten lesen und schreiben sondern auch:

```csharp []
Console.BackgroundColor = ConsoleColor.DarkRed; //Hintergrundfarbe setzen
Console.ForegroundColor = ConsoleColor.White;   //Vordergrundfarbe setzen
Console.Title = "IHK Ulm"; // Setzt den Titel im Konsolenfenster
Console.WindowHeight = 50; // Setzt die Fensterhöhe
Console.WindowWidth = 150; // Setzt die Fensterbreite
```

---

<!-- .slide: class="left" -->
### Konsole gedrückte Taste

Mit `ReadKey()` kann die vom Benutzer gedrückte Taste abgerufen werden. Die Methode liefert ein `ConsoleKeyInfo` Objekt zurück. Damit kann auf die Eingabe mit folgenden Eigenschaften zugegriffen werden:

* `Key`: Es kann auf bestimmte Tasten über die Enumeration `ConsoleKey` geprüft werden.
* `KeyChar`: Ruft das gedrückte Unicode Zeichen ab.
* `ConsoleModifiers`: Über dies Enumeration kann auf bestimmte Tasten (z.b. SHIFT, ALT, CONTROL) geprüft werden.

```csharp []
// ReadKey aufrufen und den Wert in einer lokalen Variable speichern.
// Danach prüfen ob die gedrückte Taste 'ESC' war.
ConsoleKeyInfo info = Console.ReadKey();
if (info.Key == ConsoleKey.Escape)
{
    Console.WriteLine("You pressed escape!");
}
// Prüfen auf den Buchstaben 'a'.
if (info.KeyChar == 'a')
{
    Console.WriteLine("You pressed a");
}

```

Note: 
* ConsoleKeyInfo zeigen.
* **ÜBUNG** Passwort
