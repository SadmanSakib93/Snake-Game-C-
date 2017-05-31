using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SNAKE_GAME
{
    public partial class NewGame : Form
    {
        Thread backToMenu;
        Thread LevelForm;
        public static int level;
        public NewGame()
        {
            InitializeComponent();
        }

        private void classicButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelForm = new Thread(openClassicLevel);
            LevelForm.SetApartmentState(ApartmentState.STA);
            LevelForm.Start();
            level = 1;
        }
        private void openClassicLevel()
        {
            Application.Run(new Game());
        }

        private void advanceButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelForm = new Thread(openAdvanceLevel);
            LevelForm.SetApartmentState(ApartmentState.STA);
            LevelForm.Start();
            level = 2;
        }
        private void openAdvanceLevel()
        {
            Application.Run(new Game());
        }





        private void back_Click_1(object sender, EventArgs e)
        {

            this.Close();
            backToMenu = new Thread(backToMenuFunc);
            backToMenu.SetApartmentState(ApartmentState.STA);
            backToMenu.Start();
        }
        private void backToMenuFunc()
        {
            Application.Run(new Menu());
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelForm = new Thread(openSpecialLevel);
            LevelForm.SetApartmentState(ApartmentState.STA);
            LevelForm.Start();
            level = 3;
        }
        private void openSpecialLevel()
        {
            Application.Run(new Game());
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.BackColor = Color.Black;
            back.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            back.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackColor = Color.Transparent;
            back.ForeColor = System.Drawing.SystemColors.ControlText;
            back.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void classicButton_MouseHover(object sender, EventArgs e)
        {
            classicButton.BackColor = Color.Black;
            classicButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            classicButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void classicButton_MouseLeave(object sender, EventArgs e)
        {
            classicButton.BackColor = Color.Transparent;
            classicButton.ForeColor = System.Drawing.SystemColors.ControlText;
            classicButton.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void advanceButton_MouseHover(object sender, EventArgs e)
        {
            advanceButton.BackColor = Color.Black;
            advanceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            advanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void advanceButton_MouseLeave(object sender, EventArgs e)
        {
            advanceButton.BackColor = Color.Transparent;
            advanceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            advanceButton.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void specialButton_MouseHover(object sender, EventArgs e)
        {
            specialButton.BackColor = Color.Black;
            specialButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            specialButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void specialButton_MouseLeave(object sender, EventArgs e)
        {
            specialButton.BackColor = Color.Transparent;
            specialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            specialButton.Cursor = System.Windows.Forms.Cursors.Default;
        }

    }
}
