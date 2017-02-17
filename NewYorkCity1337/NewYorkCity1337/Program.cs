using System;
using NewYorkCity1337.Engine;
using NewYorkCity1337.View;

namespace NewYorkCity1337
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MainGame(new MapView()))
                game.Run();
        }
    }
#endif
}
