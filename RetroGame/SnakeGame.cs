namespace RetroGame;

public class SnakeGame : Game
{

  private SnakeDirection snakeDirection;
  private readonly List<Point2D> snake = new();
  private Point2D item;
  private bool enlargeSnake;
  private Point2D newSnakeItem;

  public SnakeGame(Screen screen)
    : base(screen)
  {
  }


  protected override void Start()
  {
    this.InitializeSnake();
    this.InitializeGem();
  }

  private void InitializeGem()
  {
    var x = this.GetRandomNumber(1, this.ResolutionX - 2);
    var y = this.GetRandomNumber(1, this.ResolutionY - 2);
    this.item = new Point2D(x, y);
  }


  private void SnakeGemHitTest()
  {
    var tail = this.snake.Last();

    if (tail.Equals(this.item))
    {
      this.enlargeSnake = true;
      this.newSnakeItem = tail;
    }
    else
    {
      this.enlargeSnake = false;
    }
  }

  protected override void OnArrowDown()
  {
    this.snakeDirection = SnakeDirection.Down;
  }

  protected override void OnArrowUp()
  {
    this.snakeDirection = SnakeDirection.Up;
  }

  protected override void OnArrowLeft()
  {
    this.snakeDirection = SnakeDirection.Left;
  }

  protected override void OnArrowRight()
  {
    this.snakeDirection = SnakeDirection.Right;
  }

  protected override void Update()
  {
    this.UpdateSnake();

    this.SnakeGemHitTest();
    
    this.DrawBorder();
    this.DrawSnake();
    this.DrawGem();
    
    if (this.enlargeSnake)
    {
      this.EnlargeSnake();
      this.InitializeGem();
    }
    if (this.SnakeHitBorder() || this.SnakeHitSnake())
    {
      this.Stop();
      MessageBox.Show("Failed");
      this.Restart();
    }
  }

  private void EnlargeSnake()
  {
    this.snake.Add(newSnakeItem);
  }

  private bool SnakeHitBorder()
  {
    var head = this.snake.First();

    if (head.X == 0 || head.Y == 0)
      return true;

    if (head.X == this.ResolutionX - 1 || head.Y == this.ResolutionY - 1)
      return true;

    return false;
  }

  private bool SnakeHitSnake()
  {
    for (var i = 0; i < this.snake.Count; i++)
    {
      for (var j = 0; j < this.snake.Count; j++)
      {
        if (i == j)
          continue;

        if (this.snake[i].Equals(this.snake[j]))
          return true;
      }
    }

    return false;
  }

  private void UpdateSnake()
  {

    for (var i = this.snake.Count - 1; i > 0; i--)
      this.snake[i] = this.snake[i - 1];

    switch (this.snakeDirection)
    {
      case SnakeDirection.Up:
        this.snake[0] = new Point2D(this.snake[0].X, this.snake[0].Y - 1);
        break;
      case SnakeDirection.Down:
        this.snake[0] = new Point2D(this.snake[0].X, this.snake[0].Y + 1);
        break;
      case SnakeDirection.Left:
        this.snake[0] = new Point2D(this.snake[0].X - 1, this.snake[0].Y);
        break;
      case SnakeDirection.Right:
        this.snake[0] = new Point2D(this.snake[0].X + 1, this.snake[0].Y);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private void DrawGem()
  {
    this.SetPixel(this.item);
  }

  private void DrawSnake()
  {
    foreach (var element in this.snake)
      this.SetPixel(element);
  }

  private void DrawBorder()
  {
    //oben 
    for (var x = 0; x < this.ResolutionX; x++)
      this.SetPixel(x, 0);

    //unten
    for (var x = 0; x < this.ResolutionX; x++)
      this.SetPixel(x, this.ResolutionY - 1);

    //links
    for (var y = 1; y < this.ResolutionY; y++)
      this.SetPixel(0, y);

    //rechts
    for (var y = 1; y < this.ResolutionY; y++)
      this.SetPixel(this.ResolutionX - 1, y);
  }

  private void InitializeSnake()
  {
    this.snake.Clear();
    this.snakeDirection = SnakeDirection.Right;
    var startX = this.ResolutionX / 2;
    var startY = this.ResolutionY / 2;

    for (var x = 5; x > 0; x--)
      this.snake.Add(new Point2D(startX + x, startY));
  }
}