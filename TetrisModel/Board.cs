using System;
using System.Drawing;

namespace TetrisModel
{
    public class Board
    {
        public int[,] Stack { get; set; }
        public Size StackSize { get; set; }
        public Block ActualBlock { get; set; }
        public readonly int stackCharacter = 0;
        public readonly int freezCharacter = 2;

        public Board(Size stackSize)
        {
            StackSize = stackSize;
            Stack = new int[stackSize.Height, stackSize.Width];
            FillStack();
        }

        private Size GetStackCenter()
        {
            return new Size(StackSize.Width / 2, StackSize.Height / 2);
        }

        public void InsertBlock(Block block)
        {
            ActualBlock = block;

            var rotation = ActualBlock.ActualRotation;
            var columnCenter = GetStackCenter().Width;
            for (int i = 0; i < rotation.GetBodySize().Height; i++)
            {
                for (int j = 0; j < rotation.GetBodySize().Width; j++)
                {
                    if (rotation.Body[i, j] != rotation.BodyCharacter) continue;
                    Stack[i, columnCenter + j] = rotation.Body[i, j];
                }
            }
        }
        public void MoveLeft()
        {
            var blockBodyCharacter = ActualBlock.ActualRotation.BodyCharacter;
            for (int i = 0; i < StackSize.Height; i++)
            {
                for (int j = 1; j < StackSize.Width; j++)
                {
                    if (Stack[i, j] != blockBodyCharacter) continue;
                    Stack[i, j - 1] = Stack[i, j];
                    Stack[i, j] = stackCharacter;
                }
            }
        }
        public void MoveRight()
        {
            var blockBodyCharacter = ActualBlock.ActualRotation.BodyCharacter;
            for (int i = StackSize.Height - 1; i >= 0; i--)
            {
                for (int j = StackSize.Width - 2; j >= 0; j--)
                {
                    if (Stack[i, j] != blockBodyCharacter) continue;
                    Stack[i, j + 1] = Stack[i, j];
                    Stack[i, j] = stackCharacter;
                }
            }
        }
        public void MoveDown()
        {
            var blockBodyCharacter = ActualBlock.ActualRotation.BodyCharacter;
            for (int i = StackSize.Height - 2; i >= 0; i--)
            {
                for (int j = StackSize.Width - 1; j >= 0; j--)
                {
                    if (Stack[i, j] != blockBodyCharacter) continue;
                    Stack[i + 1, j] = Stack[i, j];
                    Stack[i, j] = stackCharacter;
                }
            }
        }
        public void FreezBlock()
        {
            var blockBodyCharacter = ActualBlock.ActualRotation.BodyCharacter;
            for (int i = 0; i < StackSize.Height; i++)
            {
                for (int j = 0; j < StackSize.Width; j++)
                {
                    if (Stack[i, j] != blockBodyCharacter) continue;
                    Stack[i, j] = freezCharacter;
                }
            }
        }
        public Point FindBlock()
        {
            var blockBodyCharacter = ActualBlock.ActualRotation.BodyCharacter;
            for (int i = 0; i < StackSize.Height; i++)
            {
                for (int j = 0; j < StackSize.Width; j++)
                {
                    if (Stack[i, j] == blockBodyCharacter) return new Point(j, i);
                }
            }
            return new Point(-1, -1);
        }
        public void RotateBlock()
        {
            var blockLocation = ActualBlock.ActualRotation.CalculateCornerDiffrence(FindBlock());
            
            ActualBlock = ActualBlock.SetNextRotation();

            var rotation = ActualBlock.ActualRotation;
            var bodySize = rotation.GetBodySize();

            for (int i = 0; i < bodySize.Height; i++)
            {
                for (int j = 0; j < bodySize.Width; j++)
                {
                    var stackCell = Stack[blockLocation.Y + i, blockLocation.X + j];
                    if (!(stackCell == rotation.BodyCharacter || stackCell == stackCharacter)) continue;
                    Stack[blockLocation.Y + i, blockLocation.X + j] = rotation.Body[i, j];
                }
            }
        }
        public void RemoveRow(int index)
        {
            for (int i = index; i >= 1; i--)
            {
                for (int j = StackSize.Width - 1; j >= 0; j--)
                {
                    Stack[i, j] = Stack[i - 1, j];
                }
            }
        }
        public void FillStack()
        {
            for (int i = 0; i < StackSize.Height; i++)
            {
                for (int j = 0; j < StackSize.Width; j++)
                {
                    Stack[i, j] = 0;
                }
            }
        }
        public void DrawStack()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < StackSize.Height; i++)
            {
                for (int j = 0; j < StackSize.Width; j++)
                {
                    Console.Write(Stack[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
