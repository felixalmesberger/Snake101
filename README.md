# Snake101

![](demo.gif)

Wir programmieren Snake

Snake ist ein 2D Spieleklassiker, dabei wird eine Schlange mit den Pfeiltasten der Computertastatur über ein Spielfeld gelenkt.
Die Schlange darf weder sich selbst, noch die Wände des Spielfelds berühren. Ziel ist es sogenannte Happen (Item) zu essen, die die Schlange verlängern und einen Punkt dazuverdienen.

## Die Elemente

![](overview.png)

## Das Gerüst

### SnakeGame

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
}
```


# Aufgaben

##