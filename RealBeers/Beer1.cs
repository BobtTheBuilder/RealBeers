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
    public partial class Beer1 : Form
    {
        public Beer1()
        {
            InitializeComponent();
        }

        private void AppClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheBar theBar = new TheBar();
            theBar.Show();
            this.Hide();
        }
    }
}
