# Übung - verschachtelte Schleife

Schreiben Sie ein Programm, das eine ganze Zahl n nimmt und ein Dreieck aus Dollars der Größe n druckt.

|Eingabe|Ausgabe|Eingabe|Ausgabe|Eingabe|Ausgabe
|---|---|---|---|---|---|
|3|<code>$</code><br><code>$ $</code><br><code>$ $ $</code>|4|<code>$</code><br><code>$ $</code><br><code>$ $ $</code><br><code>$ $ $ $</code>|5|<code>$</code><br><code>$ $</code><br><code>$ $ $</code><br><code>$ $ $ $</code><br><code>$ $ $ $ $</code>|

## Hints and Guidelines

Das Problem ist **ähnlich** wie beim Zeichnen von **Rechteck** und **Quadrat**. Auch hier werden wir **geschachtelte Schleifen** verwenden, aber hier gibt es **einen Haken**. Der Unterschied ist, dass **die Anzahl der Spalten**, die wir drucken müssen, von **der Zeile** abhängt, auf der wir uns befinden, und nicht von der Eingabezahl **`n`**. Aus dem Beispiel der Ein- und Ausgabedaten sehen wir, dass **die Anzahl der Dollar davon abhängt, auf welcher **Zeile** wir uns zum Zeitpunkt des Drucks befinden, d.h. 1 Dollar bedeutet erste Zeile, 3 Dollar dritte Zeile und so weiter. Sehen wir uns das folgende Beispiel im Detail an. Wir sehen, dass **die Variable** der **geschachtelten** Schleife mit der Variablen der **äußeren** Schleife verbunden ist. Auf diese Weise druckt unser Programm das gewünschte Dreieck.