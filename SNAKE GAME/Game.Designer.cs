namespace SNAKE_GAME
{
    partial class Game
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
            this.gameBox = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.animationLabel = new System.Windows.Forms.Label();
            this.animLabel = new System.Windows.Forms.Label();
            this.pauseResume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameBox.Location = new System.Drawing.Point(0, 50);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(583, 450);
            this.gameBox.TabIndex = 0;
            this.gameBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(444, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(91, 24);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score :";
            // 
            // animationLabel
            // 
            this.animationLabel.AutoSize = true;
            this.animationLabel.Location = new System.Drawing.Point(255, 520);
            this.animationLabel.Name = "animationLabel";
            this.animationLabel.Size = new System.Drawing.Size(0, 13);
            this.animationLabel.TabIndex = 2;
            // 
            // animLabel
            // 
            this.animLabel.AutoSize = true;
            this.animLabel.BackColor = System.Drawing.Color.Black;
            this.animLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.animLabel.Location = new System.Drawing.Point(200, 517);
            this.animLabel.Name = "animLabel";
            this.animLabel.Size = new System.Drawing.Size(0, 35);
            this.animLabel.TabIndex = 5;
            // 
            // pauseResume
            // 
            this.pauseResume.AutoSize = true;
            this.pauseResume.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pauseResume.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseResume.ForeColor = System.Drawing.SystemColors.Window;
            this.pauseResume.Location = new System.Drawing.Point(93, 9);
            this.pauseResume.Name = "pauseResume";
            this.pauseResume.Size = new System.Drawing.Size(246, 35);
            this.pauseResume.TabIndex = 6;
            this.pauseResume.Text = "Press P to PAUSE";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pauseResume);
            this.Controls.Add(this.animLabel);
            this.Controls.Add(this.animationLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label animationLabel;
        private System.Windows.Forms.Label animLabel;
        private System.Windows.Forms.Label pauseResume;
    }
}