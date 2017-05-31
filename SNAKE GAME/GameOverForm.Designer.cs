namespace SNAKE_GAME
{
    partial class GameOverForm
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
            this.gameOverPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverPicBox
            // 
            this.gameOverPicBox.BackgroundImage = global::SNAKE_GAME.Properties.Resources.gameover;
            this.gameOverPicBox.Location = new System.Drawing.Point(0, 0);
            this.gameOverPicBox.Name = "gameOverPicBox";
            this.gameOverPicBox.Size = new System.Drawing.Size(586, 600);
            this.gameOverPicBox.TabIndex = 0;
            this.gameOverPicBox.TabStop = false;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.gameOverPicBox);
            this.Name = "GameOverForm";
            this.Text = "Game Over";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOverForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameOverPicBox;

    }
}