using System;
using System.Windows.Forms;
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
      Application.EnableVisualStyles();
      var screen = new Screen();
      var game = new SnakeGameFinished(screen);

      Application.Run(screen);
    }
  }
}