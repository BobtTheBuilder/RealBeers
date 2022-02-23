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
    public partial class Beer2 : Form
    {
        public Beer2()
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
