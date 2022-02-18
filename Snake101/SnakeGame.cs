using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetroGame;

namespace Snake101
{
  public class SnakeGame : Game
  {
    public SnakeGame(RetroGame.Screen screen)
      : base(screen)
    {
    }

    protected override void Start()
    {
      // wird aufgerufen wenn das spiel gestartet wird
    }

    protected override void Update()
    {
      // wird in einer endlosschleife im abstand von 100 millisekunden aufgerufen.
      // hier muss das spiel neu gezeichnet werden
      // und der spielstand verändert werden

      // Zeichne Wände
      // Zeichne Schlange
      // Zeichne Happen

      // Aktualisiere Schlangenposition
      // Überprüfe ob Schlange mit Wand kollidiert
      // Überprüfe ob Schlange mit sich selbst kollidiert
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
}
