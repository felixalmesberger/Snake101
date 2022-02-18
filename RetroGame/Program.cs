using System.Xml.XPath;
using Microsoft.Win32.SafeHandles;

namespace RetroGame
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //  // To customize application configuration such as set high DPI settings or default font,
      //  // see https://aka.ms/applicationconfiguration.
      //  ApplicationConfiguration.Initialize();
      //  Application.Run(new Form1());
      //}

      var screen = new Screen();

      var game = new SnakeGame(screen);

      Application.Run(screen);
    }
  }
}