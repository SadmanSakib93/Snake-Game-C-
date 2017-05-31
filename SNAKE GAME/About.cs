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
    public partial class About : Form
    {
        Thread backToMenu;
        public About()
        {
            InitializeComponent();
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

    }
}
