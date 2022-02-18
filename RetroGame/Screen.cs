namespace RetroGame;

public class Screen : Form
{
  public const int ResolutionX = 32;
  public const int ResolutionY = 32;

  private const int PixelSize = 8;
  private const int PixelBorder = 1;


  private readonly bool[,] pixels = new bool[ResolutionX, ResolutionY];

  public Screen()
  {
    this.BackColor = Color.White;
    this.Width = ResolutionX * PixelSize + 20;
    this.Height = ResolutionY * PixelSize + 40;
  }

  public void ClearPixels()
  {
    for (var x = 0; x < ResolutionX; x++)
    for (var y = 0; y < ResolutionY; y++)
      this.pixels[x, y] = false;
  }

  public void SetPixel(int x, int y)
  {
    if (x >= ResolutionX || y >= ResolutionY)
      throw new ArgumentOutOfRangeException();

    if (x < 0 || y < 0)
      throw new ArgumentOutOfRangeException();

    this.pixels[x, y] = true;
  }

  public void RefreshScreen()
  {
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);

    for (var x = 0; x < ResolutionX; x++)
    {
      for (var y = 0; y < ResolutionY; y++)
      {
        if (!this.pixels[x, y])
          continue;

        var pixelX = x * PixelSize + PixelBorder;
        var pixelY = y * PixelSize + PixelBorder;

        var drawablePixelSize = PixelSize - 2 * PixelBorder;

        e.Graphics.FillRectangle(Brushes.Black, pixelX, pixelY, drawablePixelSize, drawablePixelSize);
      }
    }
  }
}