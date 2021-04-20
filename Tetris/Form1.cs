using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisModel;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        Size blockElementSize = new Size(10, 10);
        SolidBrush activeBlockColor = new SolidBrush(Color.Red);
        SolidBrush freezedBlockColor = new SolidBrush(Color.Blue);

        public Form1()
        {
            InitializeComponent();
        }

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            var board = game.GetBoard();
            var boardSize = new Size(board.GetLength(1), board.GetLength(0));
            var boardCharacter = game.GetBoardCharacter();
            var boardFreezedCharacter = game.GetBoardFreezedCharacter();

            for (int y = 0; y < boardSize.Height; y++)
            {
                for (int x = 0; x < boardSize.Width; x++)
                {
                    if (board[y, x] == boardCharacter) continue;
                    var location = new Point(x * 10, y * 10);
                    var blockElement = new Rectangle(location, blockElementSize);
                    if (board[y,x] == boardFreezedCharacter) e.Graphics.FillRectangle(freezedBlockColor, blockElement);
                    else e.Graphics.FillRectangle(activeBlockColor, blockElement);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (game.isRuning) return;
            game.Start();
            timGame.Start();
            timGame.Tick += new EventHandler(timGame_Tick);
        }

        private void timGame_Tick(object Sender, EventArgs e)
        {
            game.Tick();
            picBoard.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!game.isRuning) return;
            switch (e.KeyCode)
            {
                case Keys.A:
                    game.MoveLeft();
                    picBoard.Refresh();
                    break;
                case Keys.D:
                    game.MoveRight();
                    picBoard.Refresh();
                    break;
                case Keys.W:
                    game.Rotate();
                    picBoard.Refresh();
                    break;
                case Keys.S:
                    game.MoveDown();
                    picBoard.Refresh();
                    break;
                default:
                    break;
            }
        }
    }
}
