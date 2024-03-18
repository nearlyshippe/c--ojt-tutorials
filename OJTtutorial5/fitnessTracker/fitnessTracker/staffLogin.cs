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
        String key = "b14ca5898a4e4133bbce2ea2315a1916";
        staffDataTableAdapters.staffInfoTableAdapter staffTA=new staffDataTableAdapters.staffInfoTableAdapter();
        DataTable staffData=new DataTable();
        int loginCount = 0;
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
            try
            {
                if (loginCount == 3)
                {
                    MessageBox.Show("Fail Login! Try Again Later!");
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(txtStaffNo.Text))
                    {
                        MessageBox.Show("Enter Staff No :");
                    }
                    else if (String.IsNullOrWhiteSpace(txtPwd.Text))
                    {
                        MessageBox.Show("Enter Valid Password:");
                    }
                    else
                    {
                        StaffClass staff = new StaffClass();
                        staff.StaffNO = txtStaffNo.Text;
                        staff.EncryptedPwd = aesOp.EncryptString(key, txtPwd.Text);
                        staffData = staffTA.staffLogin(staff.StaffNO, staff.EncryptedPwd);
                        if (staffData.Rows.Count>0)
                        {
                            MessageBox.Show("Login Successful!");
                        }
                    }
                }
            }
            catch
            {

            }
            
            
        }
    }
}
