using System;
using SpaceFed.Core;
using SpaceFed.Core.Grid.Tiles;

namespace SpaceFed
{ 
    public static class Program
    {
       
        [STAThread]
        static void Main()
        {
            SpaceFedGame game = new SpaceFedGame();
            game.Run();

            ITile tile = new EmptyTile();
        }
    }
}
