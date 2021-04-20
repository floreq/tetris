using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace TetrisModel
{
    public class Game
    {
        public Board Playground { get; private set; }
        private List<Block> Blocks { get; set; }
        private Rules Mind { get; set; }
        public int Score { get; private set; } = 0;
        public bool isRuning { get; private set; } = false;
        public event Action gameEnded;

        public Game()
        {
            Initialization();
        }

        private void Initialization()
        {
            Playground = new Board(new Size(10, 22));

            // Rotations from https://i.stack.imgur.com/q0WyH.png
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
                    { 0, 0, 0, 0 },
                    { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                }, new Point(-2, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 },
                }, new Point(0, -2)),
                                new Rotation(new int[,]
                {
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 0, 0 },
                }, new Point(-1, 0)),
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 1, 1 },
                    { 1, 1 }     
                }, new Point(0, 0))
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 0 },
                    { 0, 1, 1 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 0, 0, 1 },
                    { 0, 1, 1 },
                    { 0, 1, 0 },
                }, new Point(-2, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 0 },
                    { 0, 1, 1 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 0 },
                    { 1, 0, 0 },
                }, new Point(-1, 0))
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 0, 1, 1 },
                    { 1, 1, 0 },
                    { 0, 0, 0 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 1 },
                    { 0, 0, 1 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 0, 1, 1 },
                    { 1, 1, 0 },
                }, new Point(-1, -1)),
                new Rotation(new int[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 0 },
                    { 0, 1, 0 },
                }, new Point(0, 0))
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                }, new Point(0, 0)),
                new Rotation(new int[,]
                {
                    { 0, 1, 1 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 1 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 1, 0 },
                }, new Point(-1, 0))
            }));
            Blocks.Add(new Block(new List<Rotation>
            {
                new Rotation(new int[,]
                {
                    { 0, 0, 1 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                }, new Point(-2, 0)),
                new Rotation(new int[,]
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 1 },
                }, new Point(-1, 0)),
                new Rotation(new int[,]
                {
                    { 0, 0, 0 },
                    { 1, 1, 1 },
                    { 1, 0, 0 },
                }, new Point(0, -1)),
                new Rotation(new int[,]
                {
                    { 1, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                }, new Point(0, 0))
            }));

            Mind = new Rules();
        }
        private void EndGame()
        {
            isRuning = false;
            gameEnded?.Invoke();
        }
        public void InsertBlock()
        {
            Playground.InsertBlock(Mind.GetRandomBlock(Blocks).SetRandomRotation());
        }
        public int[,] GetBoard()
        {
            return Playground.Stack;
        }
        public int GetBoardFreezedCharacter()
        {
            return Playground.freezCharacter;
        }
        public int GetBoardCharacter()
        {
            return Playground.stackCharacter;
        }
        public void Tick()
        {
            if (Mind.IsGameOver(Playground))
            {
                EndGame();
                return;
            }
            if (Mind.CanMoveDown(Playground)) Playground.MoveDown();
            else
            {
                Playground.FreezBlock();

                var f = Mind.FindFullRow(Playground);
                while (f.isFullRow)
                {
                    Playground.RemoveRow(f.index);
                    Score++;
                    f = Mind.FindFullRow(Playground);
                }
                Playground.InsertBlock(Mind.GetRandomBlock(Blocks).SetRandomRotation());
            }
        }
        public void Start()
        {
            Playground.InsertBlock(Mind.GetRandomBlock(Blocks).SetRandomRotation());
            isRuning = true;
        }
        public void MoveLeft()
        {
            if (Mind.CanMoveLeft(Playground)) Playground.MoveLeft();
        }
        public void MoveRight()
        {
            if (Mind.CanMoveRight(Playground)) Playground.MoveRight();
        }
        public void Rotate()
        {
            if (Mind.CanRotate(Playground)) Playground.RotateBlock();
        }
        public void MoveDown()
        {
            if (Mind.CanMoveDown(Playground)) Playground.MoveDown();
        }

    }
}
