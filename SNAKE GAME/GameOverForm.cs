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
    public partial class GameOverForm : Form
    {
        Bitmap gameOver1 = SNAKE_GAME.Properties.Resources.gameover1;
        Bitmap gameOver = SNAKE_GAME.Properties.Resources.gameover;
        static bool i ;
        Thread menuForm;
        public GameOverForm()
        {
            InitializeComponent();

            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(changeBackGround);
            tm.Start();
        }
        public void changeBackGround(object sender, EventArgs e)
        {

            if (i)
            {
                gameOverPicBox.Image = gameOver;
                i = false;
            }
            else if (!i)
            {
                
                gameOverPicBox.Image = gameOver1;
                i = true;
            }

            

        }

        private void GameOverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            this.Close();
            menuForm = new Thread(openMenu);
            menuForm.SetApartmentState(ApartmentState.STA);
            menuForm.Start();

           }
        }
        private void openMenu()
        {
            Application.Run(new Menu());
        }
            
        }

    
}
