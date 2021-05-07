using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisModel
{
    class Rules
    {
        public Block GetRandomBlock(List<Block> blocks)
        {
            var random = new Random().Next(0, blocks.Count);
            return blocks[random];
        }
        public bool CanMoveDown(Board board)
        {
            var blockBodyCharacter = board.ActualBlock.ActualRotation.BodyCharacter;
            var stack = board.Stack;
            for (int i = 0; i < board.StackSize.Height; i++)
            {
                for (int j = 0; j < board.StackSize.Width; j++)
                {
                    if (stack[i, j] != blockBodyCharacter) continue;
                    if (i == board.StackSize.Height - 1 || (stack[i + 1, j] != board.stackCharacter && stack[i + 1, j] != blockBodyCharacter)) return false;
                }
            }
            return true;
        }
        public bool CanRotate(Board board)
        {
            var bodySize = board.ActualBlock.ActualRotation.GetBodySize();
            var blockLocation = board.ActualBlock.ActualRotation.CalculateCornerDiffrence(board.FindBlock());
            var nextBody = board.ActualBlock.GetNextRotation().Body;
            var nextBodyCharacter = board.ActualBlock.GetNextRotation().BodyCharacter;

            for (int i = 0; i < bodySize.Height; i++)
            {
                for (int j = 0; j < bodySize.Width; j++)
                {
                    if (nextBody[i, j] != nextBodyCharacter) continue;
                    if (blockLocation.Y + i >= board.StackSize.Height) return false;
                    if (blockLocation.X + j < 0 || blockLocation.X + j >= board.StackSize.Width) return false;
                    if (board.Stack[blockLocation.Y + i, blockLocation.X + j] == board.freezCharacter) return false;
                }
            }
            return true;
        }
        public bool CanMoveRight(Board board)
        {
            var blockBodyCharacter = board.ActualBlock.ActualRotation.BodyCharacter;
            var stack = board.Stack;
            for (int i = 0; i < board.StackSize.Height; i++)
            {
                for (int j = 0; j < board.StackSize.Width; j++)
                {
                    if (stack[i, j] != blockBodyCharacter) continue;
                    if (j == board.StackSize.Width - 1 || (stack[i, j + 1] != board.stackCharacter && stack[i, j + 1] != blockBodyCharacter)) return false;
                }
            }
            return true;
        }
        public bool CanMoveLeft(Board board)
        {
            var blockBodyCharacter = board.ActualBlock.ActualRotation.BodyCharacter;
            var stack = board.Stack;
            for (int i = 0; i < board.StackSize.Height; i++)
            {
                for (int j = 0; j < board.StackSize.Width; j++)
                {
                    if (stack[i, j] != blockBodyCharacter) continue;
                    if (j == 0 || (stack[i, j - 1] != board.stackCharacter && stack[i, j - 1] != blockBodyCharacter)) return false;
                }
            }
            return true;
        }
        public bool CanInsert(Board board, Block newBlock, int insertColumn)
        {
            var blockSize = newBlock.ActualRotation.GetBodySize();
            var stack = board.Stack;
            for (int i = 0; i < blockSize.Height; i++)
            {
                for (int j = insertColumn; j < insertColumn + blockSize.Width; j++)
                {
                    if (stack[i, j] != board.stackCharacter) return false;
                }
            }
            return true;
        }
        public (bool isFullRow, int index) FindFullRow(Board board)
        {
            var stack = board.Stack;
            for (int i = 0; i < board.StackSize.Height; i++)
            {
                for (int j = 0; j < board.StackSize.Width; j++)
                {
                    if (stack[i, j] == board.stackCharacter) break;
                    if (j == board.StackSize.Width - 1) return (true, i);
                }
            }
            return (false, -1);
        }
    }
}
