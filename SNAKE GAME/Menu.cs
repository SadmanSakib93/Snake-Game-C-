using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace SNAKE_GAME
{
    public partial class Menu : Form
        
    {
        Thread newGameForm;
        public static int currentHighScore;


        public Menu()
        {
            InitializeComponent();
            if (!File.Exists("High Score.txt"))
            {
                StreamWriter highScoreWrite = File.CreateText("High Score.txt");
                highScoreWrite.WriteLine("0");
                highScoreWrite.Close();
            }
            if (!File.Exists("High Scorer Name.txt"))
            {
                StreamWriter highScorerNameWrite = File.CreateText("High Scorer Name.txt");
                highScorerNameWrite.WriteLine("New Player");
                highScorerNameWrite.Close();
            }
            StreamReader highScoreRead = new StreamReader("High Score.txt");
            currentHighScore = Int16.Parse(highScoreRead.ReadLine());
            highScoreRead.Close();

 
       
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openNewGame);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();

        }
        private void openNewGame()
        {
            Application.Run(new NewGame());
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void highScore_Click(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openHighScore);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();

        }
        private void openHighScore()
        {
            Application.Run(new ShowHighScore());
        }

        private void About_Click_1(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openAbout);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();
        }
        private void openAbout()
        {
            Application.Run(new About());
        }

        private void newGame_MouseHover(object sender, EventArgs e)
        {
            newGame.BackColor = Color.Black;
            newGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;;
            newGame.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void newGame_MouseLeave(object sender, EventArgs e)
        {
            newGame.BackColor = Color.Transparent;
            newGame.ForeColor = System.Drawing.SystemColors.ControlText;
            newGame.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void About_MouseHover(object sender, EventArgs e)
        {
            About.BackColor = Color.Black;
            About.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            About.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void About_MouseLeave(object sender, EventArgs e)
        {
            About.BackColor = Color.Transparent;
            About.ForeColor = System.Drawing.SystemColors.ControlText;
            About.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void highScore_MouseHover(object sender, EventArgs e)
        {
            highScore.BackColor = Color.Black;
            highScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            highScore.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void highScore_MouseLeave(object sender, EventArgs e)
        {
            highScore.BackColor = Color.Transparent;
            highScore.ForeColor = System.Drawing.SystemColors.ControlText;
            highScore.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackColor = Color.Black;
            exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight; ;
            exit.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.Transparent;
            exit.ForeColor = System.Drawing.SystemColors.ControlText;
            exit.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
