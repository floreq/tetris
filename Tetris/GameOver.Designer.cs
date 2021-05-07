
namespace Tetris
{
    partial class GameOver
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
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.txtScoreValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.Location = new System.Drawing.Point(97, 33);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(129, 28);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "Game Over";
            // 
            // lblScoreText
            // 
            this.lblScoreText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Location = new System.Drawing.Point(129, 70);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(65, 15);
            this.lblScoreText.TabIndex = 1;
            this.lblScoreText.Text = "Your Score:";
            // 
            // txtScoreValue
            // 
            this.txtScoreValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtScoreValue.BackColor = System.Drawing.SystemColors.Control;
            this.txtScoreValue.Location = new System.Drawing.Point(71, 97);
            this.txtScoreValue.Name = "txtScoreValue";
            this.txtScoreValue.ReadOnly = true;
            this.txtScoreValue.Size = new System.Drawing.Size(181, 22);
            this.txtScoreValue.TabIndex = 3;
            this.txtScoreValue.Text = "0";
            this.txtScoreValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 159);
            this.Controls.Add(this.txtScoreValue);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblGameOver);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameOver";
            this.Text = "v";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.TextBox txtScoreValue;
    }
}