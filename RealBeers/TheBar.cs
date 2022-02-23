using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBeers
{
    public partial class TheBar : Form
    {
        public TheBar()
        {
            InitializeComponent();
        }

        private void beer1_Click(object sender, EventArgs e)
        {
            Beer1 beer1 = new Beer1();
            beer1.Show();
            this.Hide();
        }

        private void beer2_Click(object sender, EventArgs e)
        {
            Beer2 beer2 = new Beer2();
            beer2.Show();
            this.Hide();
        }

        private void beer3_Click(object sender, EventArgs e)
        {
            Beer3 beer3 = new Beer3();
            beer3.Show();
            this.Hide();
        }

        private void beer4_Click(object sender, EventArgs e)
        {
            Beer4 beer4 = new Beer4();
            beer4.Show();
            this.Hide();
        }

        private void beer5_Click(object sender, EventArgs e)
        {
            Beer5 beer5 = new Beer5();
            beer5.Show();
            this.Hide();
        }

        private void beer6_Click(object sender, EventArgs e)
        {
            Beer6 beer6 = new Beer6();
            beer6.Show();
            this.Hide();
        }

        private void nodrink_Click(object sender, EventArgs e)
        {
            DontDrink dontDrink = new DontDrink();
            dontDrink.Show();
            this.Hide();
        }

        private void AppClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
