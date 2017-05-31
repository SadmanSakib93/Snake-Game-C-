using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SNAKE_GAME
{
    public partial class ShowHighScore : Form
    {
        Thread backToMenu;
        public ShowHighScore()
        {
            InitializeComponent();
            StreamReader highScoreRead = new StreamReader("High Score.txt");
            string currentHighScore = highScoreRead.ReadLine();
            highScoreRead.Close();
            StreamReader highScorerNameRead = new StreamReader("High Scorer Name.txt");
            string highScorerName = highScorerNameRead.ReadLine();
            highScorerNameRead.Close();
            name.Text = highScorerName+" : "+currentHighScore;

        }

        private void back_Click(object sender, EventArgs e)
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
        



    }
}
