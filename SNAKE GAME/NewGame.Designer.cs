namespace SNAKE_GAME
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.classicButton = new System.Windows.Forms.Button();
            this.advanceButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classicButton
            // 
            this.classicButton.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicButton.Location = new System.Drawing.Point(63, 150);
            this.classicButton.Name = "classicButton";
            this.classicButton.Size = new System.Drawing.Size(100, 50);
            this.classicButton.TabIndex = 0;
            this.classicButton.Text = "CLASSIC";
            this.classicButton.UseVisualStyleBackColor = true;
            this.classicButton.Click += new System.EventHandler(this.classicButton_Click);
            this.classicButton.MouseLeave += new System.EventHandler(this.classicButton_MouseLeave);
            this.classicButton.MouseHover += new System.EventHandler(this.classicButton_MouseHover);
            // 
            // advanceButton
            // 
            this.advanceButton.Font = new System.Drawing.Font("Poplar Std", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceButton.Location = new System.Drawing.Point(63, 244);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(100, 50);
            this.advanceButton.TabIndex = 1;
            this.advanceButton.Text = "ADVANCED";
            this.advanceButton.UseVisualStyleBackColor = true;
            this.advanceButton.Click += new System.EventHandler(this.advanceButton_Click);
            this.advanceButton.MouseLeave += new System.EventHandler(this.advanceButton_MouseLeave);
            this.advanceButton.MouseHover += new System.EventHandler(this.advanceButton_MouseHover);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(466, 516);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 33);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            this.back.MouseHover += new System.EventHandler(this.back_MouseHover);
            // 
            // specialButton
            // 
            this.specialButton.Font = new System.Drawing.Font("Poplar Std", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialButton.Location = new System.Drawing.Point(63, 341);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(100, 50);
            this.specialButton.TabIndex = 1;
            this.specialButton.Text = "SPECIAL";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
            this.specialButton.MouseLeave += new System.EventHandler(this.specialButton_MouseLeave);
            this.specialButton.MouseHover += new System.EventHandler(this.specialButton_MouseHover);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.advanceButton);
            this.Controls.Add(this.classicButton);
            this.Name = "NewGame";
            this.Text = "Snake Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button classicButton;
        private System.Windows.Forms.Button advanceButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button specialButton;
    }
}