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
    public partial class staffInfomation : Form
    {
        public staffInfomation()
        {
            InitializeComponent();
        }

        private void staffInfomation_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome "+staffLogin.sname+",";
            lblNo.Text = staffLogin.sno;
            string imagepath = staffLogin.sImagePath;
            if (!string.IsNullOrEmpty(imagepath))
            {
                pbStaff.BackgroundImage = Image.FromFile(imagepath);
            }
            
            DateTime age=staffLogin.dob;
            DateTime currentYear= DateTime.Now;
            lblAge.Text ="Age ="+(currentYear.Year - age.Year).ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            staffLogin login=new staffLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
