namespace SNAKE_GAME
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.newGame = new System.Windows.Forms.Button();
            this.highScore = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newGame.Location = new System.Drawing.Point(31, 143);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(100, 50);
            this.newGame.TabIndex = 1;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            this.newGame.MouseLeave += new System.EventHandler(this.newGame_MouseLeave);
            this.newGame.MouseHover += new System.EventHandler(this.newGame_MouseHover);
            // 
            // highScore
            // 
            this.highScore.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(31, 322);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(100, 50);
            this.highScore.TabIndex = 3;
            this.highScore.Text = "High Score";
            this.highScore.UseVisualStyleBackColor = true;
            this.highScore.Click += new System.EventHandler(this.highScore_Click);
            this.highScore.MouseLeave += new System.EventHandler(this.highScore_MouseLeave);
            this.highScore.MouseHover += new System.EventHandler(this.highScore_MouseHover);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(31, 411);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(31, 234);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(100, 50);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click_1);
            this.About.MouseLeave += new System.EventHandler(this.About_MouseLeave);
            this.About.MouseHover += new System.EventHandler(this.About_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.About);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "MAIN MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button highScore;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button About;
    }
}

