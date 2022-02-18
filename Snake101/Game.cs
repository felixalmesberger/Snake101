using Timer = System.Windows.Forms.Timer;

namespace RetroGame;

/// <summary>
/// Stellt das Gerüst eines 2D Spiels dar
/// </summary>
public abstract class Game
{
  private readonly Screen screen;
  private readonly Random random = new();

  private readonly Timer gameUpdateTimer = new()
  {
    Interval = 100
  };

  protected Game(Screen screen)
  {
    this.screen = screen ?? throw new ArgumentOutOfRangeException(nameof(screen));
    this.screen.KeyUp += this.ScreenKeyUp;
    this.gameUpdateTimer.Tick += this.UpdateGameTimerTick;

    this.screen.Load += (_, _) =>
    {
      this.Start();
      this.gameUpdateTimer.Start();
    };
  }

  private void UpdateGameTimerTick(object? sender, EventArgs e)
  {
    this.UpdateInternal();
  }

  private void ScreenKeyUp(object? sender, KeyEventArgs e)
  {
    switch (e.KeyCode)
    {
      case Keys.Down:
        this.OnArrowDown();
        break;
      case Keys.Up:
        this.OnArrowUp();
        break;
      case Keys.Left:
        this.OnArrowLeft();
        break;
      case Keys.Right:
        this.OnArrowRight();
        break;
      case Keys.Enter:
        this.OnEnter();
        break;
    }
  }

  
  protected void WriteMessage(string message)
  {
    this.screen.WriteMessage(message);
  }

  protected void SetPixel(int x, int y) => this.screen.SetPixel(x, y);
  protected void SetPixel(Point2D point) => this.SetPixel(point.X, point.Y);
  protected virtual void OnArrowUp()
  {
  }

  protected virtual void OnArrowDown()
  {
  }

  protected virtual void OnArrowLeft()
  {
  }
  protected virtual void OnArrowRight()
  {
  }

  protected virtual void OnEnter()
  {
  }

  protected int ResolutionX => Screen.ResolutionX;
  protected int ResolutionY => Screen.ResolutionY;

  protected int GetRandomNumber(int min, int max)
  {
    return this.random.Next(min, max);
  }

  protected virtual void Start()
  {
  }

  private void UpdateInternal()
  {
    this.screen.ClearPixels();

    this.Update();

    this.screen.RefreshScreen();
  }

  protected abstract void Update();
}