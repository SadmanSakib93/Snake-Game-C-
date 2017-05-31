namespace SNAKE_GAME
{
    partial class GameOverHighScoreForm
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
            this.highScorerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScorerName
            // 
            this.highScorerName.BackColor = System.Drawing.SystemColors.Window;
            this.highScorerName.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScorerName.Location = new System.Drawing.Point(164, 334);
            this.highScorerName.Name = "highScorerName";
            this.highScorerName.Size = new System.Drawing.Size(264, 33);
            this.highScorerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Name";
            // 
            // nameSubmit
            // 
            this.nameSubmit.Font = new System.Drawing.Font("OCR A Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSubmit.Location = new System.Drawing.Point(259, 373);
            this.nameSubmit.Name = "nameSubmit";
            this.nameSubmit.Size = new System.Drawing.Size(75, 23);
            this.nameSubmit.TabIndex = 2;
            this.nameSubmit.Text = "Submit";
            this.nameSubmit.UseVisualStyleBackColor = true;
            this.nameSubmit.Click += new System.EventHandler(this.nameSubmit_Click);
            // 
            // GameOverHighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SNAKE_GAME.Properties.Resources.hs1;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.nameSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highScorerName);
            this.Name = "GameOverHighScoreForm";
            this.Text = "New High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox highScorerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nameSubmit;
    }
}