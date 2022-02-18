namespace RetroGame;

public struct Point2D
{
  public Point2D(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }
  public int X { get; set; }
  public int Y { get; set; }

  public override bool Equals(object? obj)
  {
    if (obj is not Point2D other)
      return false;

    return (this.X, this.Y) == (other.X, other.Y);
  }

  public override int GetHashCode()
  {
    return (this.X, this.Y).GetHashCode();
  }
}