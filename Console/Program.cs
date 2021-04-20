using System;
using System.Collections.Generic;
using System.Drawing;
using TetrisModel;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Game();
            g.gameEnded += () => System.Console.WriteLine(g.Score);
            g.Start();
        }
    }
}
