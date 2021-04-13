using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace TetrisModel
{
    public class Game
    {
        private Board Playground { get; set; }
        private List<Block> Blocks { get; set; }
        private Rules Mind { get; set; }

        public Game()
        {
            Initialization();
        }

        private void Initialization()
        {
            Playground = new Board(new Size(10, 22));

            Blocks = new List<Block>();
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 1 },
                    { 0, 1, 0 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 1, 0 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 0 },
                    { 0, 1, 0 },
                }, new Point(-1, 0))
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                    { 1, 0, 0, 0 },
                }, new Point(0, 0)),
                new Rotation(new int[,]
                {
                    { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                }, new Point(0, 0)),
            }));

            Mind = new Rules();
        }

        public void Start()
        {
            Playground.InsertBlock(Mind.GetRandomBlock(Blocks).SetRandomRotation());
            do
            {
                Playground.DrawStack();

                while (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (Mind.CanMoveLeft(Playground)) Playground.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            if (Mind.CanMoveRight(Playground)) Playground.MoveRight();
                            break;
                        case ConsoleKey.UpArrow:
                            //if (true) Playground.RotateBlock();
                            if (Mind.CanRotate(Playground)) Playground.RotateBlock();
                            break;
                        default:
                            break;
                    }
                }
                
                if (Mind.CanMoveDown(Playground)) Playground.MoveDown();
                else
                {
                    Playground.FreezBlock();
                    
                    var f = Mind.FindFullRow(Playground);
                    while (f.isFullRow)
                    {
                        Playground.RemoveRow(f.index);
                        f = Mind.FindFullRow(Playground);
                    }
                    Playground.InsertBlock(Mind.GetRandomBlock(Blocks).SetRandomRotation());
                }
                Thread.Sleep(200);
            } while (true);
        }
    }
}
