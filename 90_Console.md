# Konsole

Arbeiten mit der Konsole.

---

<!-- .slide: class="left" -->
## Konsole anpassen

Die Klasse `Console` kann nicht nur Daten lesen und schreiben sondern auch:

```csharp []
Console.BackgroundColor = ConsoleColor.DarkRed; //Hintergrundfarbe setzen
Console.ForegroundColor = ConsoleColor.White: //Vordergrundfarbe setzen
Console.Title = "IHK Ulm"; // Setzt den Titel im Konsolenfenster
Console.WindowHeight = 50; // Setzt die Fenster Höhe
Console.WindowWidth = 150; // Setzt die Fenster Breite
```

---

<!-- .slide: class="left" -->
### Konsole Taste

Mit `ReadKey()` kann die vom Benutzer gedrückte Taste abgerufen werden. Die Methode liefert ein `ConsoleKeyInfo` Objekt zurück. Damit kann auf die Eingabe zugegriffen werden mit folgenden Eigenschaften:

* `Key`: Es kann auf bestimmte Tasten über die Enumeration `ConsoleKey` geprüft werden.
* `KeyChar`: Ruft das Unicode Zeichen ab (also das gedrückte Zeichen).
* Modifiers: Es kann auf bestimmte Tasten (z.b. SHIFT, ALT, CONTROL) über die Enumeration `ConsoleModifiers` geprüft werden.

```csharp []
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

Note: 
* Daten von der Console lesen. 
* ConsoleKeyInfo zeigen.
* **ÜBUNG** Passwort
