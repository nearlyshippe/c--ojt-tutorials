using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fitnessTracker
{
    
    public partial class staffLogin : Form
    {
        public static string sname, sno, sImagePath,staffNo;
        public static DateTime dob;

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtStaffNo.Text = string.Empty;
            txtPwd.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == '*')
            {
                txtPwd.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtPwd.PasswordChar = '*';
                btnShow.Text = "Show";

            }
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
                        staffNo = staffData.Rows[0][1].ToString();
                        string staffNoCk = txtStaffNo.Text;
                        if (staffData.Rows.Count>0)
                        {
                            MessageBox.Show("Login Successful!");
                            sno = staffData.Rows[0][1].ToString();
                            sname = staffData.Rows[0][2].ToString();
                            dob = DateTime.Parse(staffData.Rows[0][3].ToString());
                            sImagePath = staffData.Rows[0][11].ToString();
                            staffInfomation stfinfo = new staffInfomation();
                            this.Hide();
                            stfinfo.ShowDialog();
                        }
                    }
                }
            }
            catch
            {

            }
            
            
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staffList list = new staffList();
            this.Hide();
            list.ShowDialog();
        }
    }
}
