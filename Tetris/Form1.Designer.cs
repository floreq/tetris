
namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRotate = new System.Windows.Forms.Label();
            this.lblMoveLeft = new System.Windows.Forms.Label();
            this.lblActualScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMoveDown = new System.Windows.Forms.Label();
            this.lblMoveRight = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timGame
            // 
            this.timGame.Interval = 500;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.scoreboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.ShortcutKeyDisplayString = "";
            this.tsmiNewGame.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiNewGame.Size = new System.Drawing.Size(151, 22);
            this.tsmiNewGame.Text = "New Game";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // scoreboardToolStripMenuItem
            // 
            this.scoreboardToolStripMenuItem.Name = "scoreboardToolStripMenuItem";
            this.scoreboardToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.scoreboardToolStripMenuItem.Text = "Scoreboard";
            // 
            // picBoard
            // 
            this.picBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoard.BackColor = System.Drawing.Color.Black;
            this.picBoard.Location = new System.Drawing.Point(33, 52);
            this.picBoard.Margin = new System.Windows.Forms.Padding(2);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(100, 219);
            this.picBoard.TabIndex = 25;
            this.picBoard.TabStop = false;
            this.picBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoard_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(159, 217);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(156, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 15);
            this.lblScore.TabIndex = 30;
            this.lblScore.Text = "Score:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(159, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // lblRotate
            // 
            this.lblRotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(189, 247);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(41, 15);
            this.lblRotate.TabIndex = 29;
            this.lblRotate.Text = "Rotate";
            // 
            // lblMoveLeft
            // 
            this.lblMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoveLeft.AutoSize = true;
            this.lblMoveLeft.Location = new System.Drawing.Point(189, 157);
            this.lblMoveLeft.Name = "lblMoveLeft";
            this.lblMoveLeft.Size = new System.Drawing.Size(59, 15);
            this.lblMoveLeft.TabIndex = 26;
            this.lblMoveLeft.Text = "Move Left";
            // 
            // lblActualScore
            // 
            this.lblActualScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActualScore.AutoSize = true;
            this.lblActualScore.Location = new System.Drawing.Point(191, 52);
            this.lblActualScore.Name = "lblActualScore";
            this.lblActualScore.Size = new System.Drawing.Size(13, 15);
            this.lblActualScore.TabIndex = 31;
            this.lblActualScore.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(159, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // lblMoveDown
            // 
            this.lblMoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoveDown.AutoSize = true;
            this.lblMoveDown.Location = new System.Drawing.Point(189, 217);
            this.lblMoveDown.Name = "lblMoveDown";
            this.lblMoveDown.Size = new System.Drawing.Size(70, 15);
            this.lblMoveDown.TabIndex = 28;
            this.lblMoveDown.Text = "Move Down";
            // 
            // lblMoveRight
            // 
            this.lblMoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoveRight.AutoSize = true;
            this.lblMoveRight.Location = new System.Drawing.Point(189, 187);
            this.lblMoveRight.Name = "lblMoveRight";
            this.lblMoveRight.Size = new System.Drawing.Size(66, 15);
            this.lblMoveRight.TabIndex = 27;
            this.lblMoveRight.Text = "Move Right";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(159, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 295);
            this.Controls.Add(this.picBoard);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblRotate);
            this.Controls.Add(this.lblMoveLeft);
            this.Controls.Add(this.lblActualScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMoveDown);
            this.Controls.Add(this.lblMoveRight);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(306, 334);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripMenuItem scoreboardToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.Label lblMoveLeft;
        private System.Windows.Forms.Label lblActualScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMoveDown;
        private System.Windows.Forms.Label lblMoveRight;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

