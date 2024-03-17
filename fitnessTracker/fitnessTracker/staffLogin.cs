using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessTracker
{
    public partial class staffLogin : Form
    {
        public staffLogin()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt staffregister = new txt();
            this.Hide();
            staffregister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
