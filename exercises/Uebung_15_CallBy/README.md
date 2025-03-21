# Übung - Call By

## Aufgabe - Teil 1

Erstellen Sie eine Methode `UpdateScore`, die den Punktestand eines Spielers (`int score`) übergeben bekommt und diesen mit einem neuen Wert aktualisiert. Verwenden Sie "Call by Reference".
In der Methode soll dem Punktestand ein Wert addiert werden z.B. 10.

Zeigen Sie im Hauptprogramm, dass sich der Punktestand auch außerhalb der Methode verändert hat.

## Aufgabe - Teil 2

Erstellen Sie eine Methode `UpdateScore2`, die den Punktestand eines Spielers (`int score`) übergeben bekommt und diesen mit einem neuen Wert aktualisiert. Verwenden Sie "Call by Value".
In der Methode soll dem Punktestand ein Wert addiert werden z.B. 10.

* Wird der Wert an die `Main`-Methode übergeben?
* Wie muss die Methode `UpdateScore2` angepasst werden damit der geänderte Wert von der Methode zurück an die `Main` Methode kommt ohne "Call by Reference" zu verwenden.

## Aufgabe - Teil 3

Erstellen Sie eine Methode `TryUpdateScore`, die den Punktestand eines Spielers (`int score`) übergeben bekommt und diesen mit einem neuen Wert aktualisiert. Verwenden Sie dabei den "Out"-Parameter.
In der Methode soll dem Punktestand ein Wert addiert werden z.B. 10.