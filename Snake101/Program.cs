using System;
using System.Windows.Forms;

namespace Snake101
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      var screen = new Screen();
      var game = new SnakeGameFinished(screen);

      Application.Run(screen);
    }
  }
}