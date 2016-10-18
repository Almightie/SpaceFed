using System;
using SpaceFed.Core;

namespace SpaceFed
{ 
    public static class Program
    {
       
        [STAThread]
        static void Main()
        {
            SpaceFedGame game = new SpaceFedGame();
            game.Run();
        }
    }
}
