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
    public partial class GameOverHighScoreForm : Form
    {
        Thread menuForm;
        public GameOverHighScoreForm()
        {
            InitializeComponent();
        }

        private void nameSubmit_Click(object sender, EventArgs e)
        {
            String name=highScorerName.Text;
            StreamWriter highScoreWrite = new StreamWriter("High Scorer Name.txt");
            highScoreWrite.Write(name);
            highScoreWrite.Close();
            this.Close();
            menuForm = new Thread(openMenu);
            menuForm.SetApartmentState(ApartmentState.STA);
            menuForm.Start();
        }
        private void openMenu()
        {
            Application.Run(new Menu());
        }



    }
}
