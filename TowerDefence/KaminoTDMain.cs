
namespace KaminoTD
{
    using System;

    using Core;
    using Interfaces;

    public static class KaminoTDMain
    {
        [STAThread]
        static void Main()
        {
            IEngine engine = new GameEngine();

            using (var game = new Game1(engine))
                game.Run();
        }
    }
}
