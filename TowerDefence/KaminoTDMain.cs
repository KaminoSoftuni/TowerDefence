using System;

namespace KaminoTD
{
    public static class KaminoTDMain
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}
