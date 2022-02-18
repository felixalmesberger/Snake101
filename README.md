# Snake101

![](https://github.com/felixalmesberger/Snake101/blob/main/res/demo.gif?raw=true)

Wir programmieren Snake

Snake ist ein 2D Spieleklassiker, dabei wird eine Schlange mit den Pfeiltasten der Computertastatur über ein Spielfeld gelenkt.
Die Schlange darf weder sich selbst, noch die Wände des Spielfelds berühren. Ziel ist es sogenannte Happen (Item) zu essen, die die Schlange verlängern und einen Punkt dazuverdienen.

## Die Elemente

Das Spielfeld ist 32 x 32 Pixel groß. Dabei ist die äußerste Pixelreihe die Mauer des Spiels.
Am Anfang soll die Schlange eine Länge von fünf haben, in der Mitte des Spielfelds beginnen und nach rechts wandern.

![](https://github.com/felixalmesberger/Snake101/blob/main/res/overview.png?raw=true)

## Das Gerüst

Die SnakeGame Klasse beinhaltet das gesamte Grundgerüst um das Spiel zu programmieren:

```

  public class SnakeGame : Game
  {

    ...  

    protected override void Start()
    {
      // wird aufgerufen wenn das spiel gestartet wird
    }

    protected override void Update()
    {
      // wird in einer endlosschleife im abstand von 100 millisekunden aufgerufen.
      // hier muss das spiel neu gezeichnet werden
      // und der spielstand verändert werden
    }

    protected override void OnArrowDown()
    {
      // wird aufgerufen, wenn die Pfeiltaste nach unten gedrückt wurde
    }

    protected override void OnArrowUp()
    {
      // wird aufgerufen, wenn die Pfeiltaste nach oben gedrückt wurde
    }

    protected override void OnArrowLeft()
    {
      // wird aufgerufen, wenn die Pfeiltaste nach links gedrückt wurde
    }

    protected override void OnArrowRight()
    {
      // wird aufgerufen, wenn die Pfeiltaste nach rechts gedrückt wurde
    }

    protected override void OnEnter()
    {
      // wird aufgerufen, wenn die ENTER Taste gedrückt wurde
    }

    // Schreibt eine Nachricht (POINTS: xxx)
    protected void WriteMessage(string message);

    // Horizontale Auflösung des Spiels = 32
    protected int ResolutionX { get; }
    protected int ResolutionY { get; }

    // Liefert eine Zufällige Zahl zwischen min und max zurück
    protected int GetRandomNumber(int min, int max);


}
```

Achtung: Das Spiel muss bei jedem Aufruf der Update Methode neu gezeichnet werden



# Aufgaben

## 1. Wände malen

1.1 Schreibe eine Methode um die obere Wand zu malen (Y = 0)

1.2 Schreibe eine Methode um die untere Wand zu malen (Y = ResolutionY - 1)

1.3 Schreibe eine Methode um die linke Wand zu malen (X = 0)

1.4 Schreibe eine Methode um die rechte Wand zu malen (???)

## 2. Erzeuge ein Item

2.1 Erzeuge ein Item an einer zufälligen Position

2.2 Zeige das erzeugte Item an:
Dafür muss man sich die Position des erzeugten Items merken, da in jedem Update aufruf, das gleiche Item angezeigt werden soll.
Es muss also eine Variable erzeugt werden.
Schaue dir dafür den Typen *Point2D* an

## 3. Erzeuge eine Schlange

3.1 Schreibe eine Methode ErzeugeSchlange, die eine Schlange der Länge 5 erzeugt, deren Anfang in der Mitte des Spielfelds liegt und von da aus nach rechts geht. Eine Schlange sollt eine Liste von 2D Punkten sein. (**List< Point2D >**)

3.2 Zeige diese Schlange in der Update Methode an

## 4. Bewege die Schlange nach rechts

In jedem Update Aufruf muss die Schlange bewegt werden, bevor sie gezeichnet wird.
Die Position jedes Elements zu verschieben ist nicht genug.

Wie müssen die Koordinaten der Punkte verändert werden um diese um 1 nach Rechts zu verschieben

## 5. Bewege die Schlange nach unten / oben / links / und rechts

Nun probiere die anderen Richtungen aus

## 6. Ändere die Richtung der Schlange abhängig von den Tasten, die der Spieler drückt

In den OnArrow...() Methoden die gedrückte Richtung in eine Variable schreiben und merken.
Der Type SnakeDirection beinhaltet die Richtungen, die du benötigst.