using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fitnessTracker
{
    public partial class txt : Form
    {
        SqlConnection conn;
        String key = "b14ca5898a4e4133bbce2ea2315a1916";
        private int currentPg = 1;
        private int recordsSize = 10;
        private int totalPg = 0;
        private int totalRecords = 0;
        

        staffDataTableAdapters.staffInfoTableAdapter staffTA=new staffDataTableAdapters.staffInfoTableAdapter();
        DataTable staffData = new DataTable();
        DataTable staffData2 = new DataTable();

        short sValue,gValue,delete=0;
        int index;
        String gText,imageFilePath;
        public txt()
        {
            InitializeComponent();
            
        }

        private DataTable loadRecordsPerpage(int page)
        {
            DataTable dtPage = new DataTable();
            int PreviousPageOffSet = (page - 1) * recordsSize;

            string query = "Select * from staffInfo ORDER BY ID OFFSET " + PreviousPageOffSet + " ROWS FETCH NEXT " + recordsSize + " ROWS ONLY";

            using (SqlConnection con = new SqlConnection("your connection string"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtPage);
            }

            return dtPage;
        }
        private void calTotalPg()
        {
            int rowCount = staffData.Rows.Count;
            totalPg = rowCount/recordsSize;
            if (rowCount % recordsSize > 0)
            {
                totalPg += 1;
            }
        }

        public void GetNextStaffId()
        {
            staffData2 = staffTA.GetData();
            int nextId = 1;

            if (staffData2.Rows.Count > 0)
            {
                int size = staffData2.Rows.Count + 1;
                nextId = size;
            }

            txtID.Text = nextId.ToString();
        }
        public void staffAutoNo()
        {
            staffData2 = staffTA.GetData();

            if (staffData2.Rows.Count == 0)
            {
                txtstaffNo.Text = "S-001";
            }
            else
            {
                int size = staffData2.Rows.Count - 1;
                string oldid = staffData2.Rows[size][1].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtstaffNo.Text = "S-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {

                    txtstaffNo.Text = "S-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {

                    txtstaffNo.Text = "S-" + (newid + 1);

                }
            }
        }
        public void clearAll()
        {
            txtstaffName.Text = " ";
            cbstaffType.Text = " ";
            dpDOB.CustomFormat = " ";
            dpJoin.CustomFormat = " ";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            txtphoneNo1.Text = " ";
            txtphoneNo2.Text = " ";
            txtAddress.Text = "  ";
            txtNRC.Text = "  ";
            pbStaff.Image = null;
        }
        
        
        private void cbstaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstaffType.SelectedIndex == 0)
            {
                sValue = 1;
            }
            else if (cbstaffType.SelectedIndex == 1)
            {
                sValue = 2;
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            staffAutoNo();
            GetNextStaffId();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String phone1 = txtphoneNo1.Text, phone2 = txtphoneNo2.Text;
            String password=txtPwd.Text;
            if (btnAddUpdate.Text == "Add")
            {
                
                try
                {

                    if (String.IsNullOrWhiteSpace(txtstaffName.Text))
                    {
                        MessageBox.Show("!EMPTY Staff Name!");
                        txtstaffName.Focus();
                    }
                    else if (String.IsNullOrWhiteSpace(cbstaffType.Text))
                    {
                        MessageBox.Show("!EMPTY Staff Type!");
                        cbstaffType.Focus();
                    }
                    else if (String.IsNullOrWhiteSpace(txtNRC.Text))
                    {
                        MessageBox.Show("!EMPTY NRC number!");
                    }
                    else if (txtNRC.Text.Length < 13)
                    {
                        MessageBox.Show("Valid NRC Should be 13 digit Eg. 12/WWE(N)234789");
                    }
                    else if (dpDOB.Value == null)
                    {
                        MessageBox.Show("EMPTY Date Of Birth");
                    }
                    else if (dpJoin.Value == null)
                    {
                        MessageBox.Show("EMPTY Join Date!");
                    }
                    else if (phone1.Any(char.IsLetter) || phone2.Any(char.IsLetter))
                    {
                        MessageBox.Show("Phone Number Should only be Numbers!");
                    }
                    else if (String.IsNullOrWhiteSpace(txtphoneNo1.Text))
                    {
                        MessageBox.Show("!EMPTY PhoneNumber");
                        txtphoneNo1.Focus();
                    }
                    else if (String.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        MessageBox.Show("EMPTY Address!");
                        txtAddress.Focus();
                    }
                    else if (String.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Fill The Password!");
                    }
                    else if (!password.Any(Char.IsLetter)&&!password.Any(Char.IsDigit))
                    {
                        MessageBox.Show("Password Should Contain Both Digit and Letter!");
                    }
                    else if (password != txtCFPwd.Text)
                    {
                        MessageBox.Show("Password isn't matching!");
                    }
                    else
                    {
                        String encryptedPass = aesOp.EncryptString(key,password);
                        StaffClass staff = new StaffClass();
                        staff.SID = int.Parse(txtID.Text);
                        staff.StaffNO = txtstaffNo.Text;
                        staff.StaffName = txtstaffName.Text;
                        staff.StaffDob = dpDOB.Value;
                        staff.StaffJoin = dpJoin.Value;
                        staff.StaffType = sValue;
                        staff.Nrc = txtNRC.Text;
                        staff.StaffGender = gValue;
                        staff.StaffPhone1 = txtphoneNo1.Text;
                        staff.StaffPhone2 = txtphoneNo2.Text;
                        staff.StaffAddress = txtAddress.Text;
                        staff.ImagePath = imageFilePath;
                        staff.IsDelete = delete;
                        staff.EncryptedPwd = encryptedPass;
                        staffData.Rows.Add(staff.SID, staff.StaffNO, pbStaff.Image, staff.StaffName, staff.StaffJoin, cbstaffType.Text, staff.Nrc, gText, staff.StaffPhone1, staff.StaffPhone2, staff.StaffAddress);
                        int data = staffTA.insertStaff(staff.SID, staff.StaffNO, staff.StaffName, staff.StaffDob, staff.StaffJoin, staff.StaffType, staff.Nrc, staff.StaffGender, staff.StaffPhone1, staff.StaffPhone2, staff.StaffAddress,staff.ImagePath,staff.IsDelete, staff.EncryptedPwd);
                        if (data > 0)
                        {
                            MessageBox.Show("Staff Added Successfully!");

                            dgvStaff.Refresh();
                            clearAll();
                            staffAutoNo();
                            GetNextStaffId();
                            dgvStaff.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else if(btnAddUpdate.Text == "Update")
            {
                DataGridViewRow newdata= dgvStaff.Rows[index];
                newdata.Cells[0].Value = txtID.Text;
                newdata.Cells[1].Value =txtstaffNo.Text;
                newdata.Cells[2].Value = pbStaff.Image;
                newdata.Cells[3].Value=txtstaffName.Text;
                newdata.Cells[4].Value = dpDOB.Value;
                newdata.Cells[5].Value = cbstaffType.Text;
                newdata.Cells[6].Value = txtNRC.Text;
                newdata.Cells[7].Value = gText;
                newdata.Cells[8].Value = txtphoneNo1.Text;
                newdata.Cells[9].Value = txtphoneNo2.Text;
                newdata.Cells[10].Value = txtAddress.Text;

                StaffClass staff= new StaffClass();
                staff.SID = int.Parse(txtID.Text);
                staff.StaffNO = txtstaffNo.Text;
                staff.ImagePath = imageFilePath;
                staff.StaffName = txtstaffName.Text;
                staff.StaffDob = dpDOB.Value;
                staff.StaffJoin = dpJoin.Value;
                staff.StaffType = sValue;
                staff.Nrc = txtNRC.Text;
                staff.StaffGender = gValue;
                staff.StaffPhone1 = txtphoneNo1.Text;
                staff.StaffPhone2 = txtphoneNo2.Text;
                staff.StaffAddress = txtAddress.Text;
                staff.ImagePath = imageFilePath;
                staff.IsDelete = delete;
                staffTA.updateStaffNo(staff.StaffNO,staff.SID);
                staffTA.updateStaffName(staff.StaffName,staff.SID);
                staffTA.updateImage(staff.ImagePath,staff.SID);
                staffTA.updatedob(staff.StaffDob,staff.SID);
                staffTA.updatedob(staff.StaffDob,staff.SID);
                staffTA.updateJoin(staff.StaffJoin,staff.SID);
                staffTA.updateType(staff.StaffType,staff.SID);
                staffTA.updateNRC(staff.Nrc,staff.SID);
                staffTA.updateGender(staff.StaffGender,staff.SID);
                staffTA.updatePhone1(staff.StaffPhone1,staff.SID);
                staffTA.updateAddress(staff.StaffAddress,staff.SID);
                btnAddUpdate.Text = "Add";


            }
            
        }

        private void adminRegister_Load(object sender, EventArgs e)
        {
            staffData.Columns.Add("ID", typeof(int));
            staffData.Columns.Add("Staff No", typeof(String));
            staffData.Columns.Add("Image",typeof(Image));
            staffData.Columns.Add("Staff Name", typeof(String));
            staffData.Columns.Add("Join From", typeof(DateTime));
            staffData.Columns.Add("Staff Type", typeof(String));
            staffData.Columns.Add("NRC", typeof(String));
            staffData.Columns.Add("Gender", typeof(String));
            staffData.Columns.Add("Phone No1", typeof(String));
            staffData.Columns.Add("Phone No2", typeof(String));
            staffData.Columns.Add("Address", typeof(String));
            this.staffInfoTableAdapter.Fill(this.staffData1.staffInfo);
            
            dgvStaff.DataSource = staffData;
            if (dgvStaff.Columns[2] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dgvStaff.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvStaff.RowTemplate.Height = 100;
            }
            staffAutoNo();
            GetNextStaffId();
        }
        

        

        

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gValue = 1;
            gText = rbMale.Text;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
           
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog()==DialogResult.OK)
                {
                    
                    pbStaff.Image = new Bitmap(fileDialog.FileName);
                    imageFilePath = fileDialog.FileName;
                }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddUpdate.Text = "Update";
            btnDelete.Visible= true;
            index = e.RowIndex;
            DataGridViewRow row = dgvStaff.Rows[index];

            txtID.Text = row.Cells[0].Value.ToString();
            txtstaffNo.Text = row.Cells[1].Value.ToString();
            string imagePath = row.Cells[2].Value.ToString();
            txtstaffName.Text = row.Cells[3].Value.ToString();
            dpDOB.Text = row.Cells[4].Value.ToString();
            cbstaffType.Text = row.Cells[5].Value.ToString();
            txtNRC.Text = row.Cells[6].Value.ToString();
            rbMale.Checked= row.Cells[7].Value.Equals(false);
            rbFemale.Checked= row.Cells[7].Value.Equals(false);
            txtphoneNo1.Text = row.Cells[8].Value.ToString();
            txtphoneNo2.Text = row.Cells[9].Value.ToString();
            txtAddress.Text = row.Cells[10].Value.ToString();
        }

        private void staffRegister_Click(object sender, EventArgs e)
        {
            btnAddUpdate.Text = "Add";
            btnDelete.Visible= false;
            staffAutoNo();
            GetNextStaffId();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staffLogin stafflogin = new staffLogin();
            this.Hide();
            stafflogin.ShowDialog();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPg = 1;
            dgvStaff.DataSource = loadRecordsPerpage(currentPg);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPg--;
            dgvStaff.DataSource=loadRecordsPerpage(currentPg);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPg++;
            dgvStaff.DataSource=loadRecordsPerpage(currentPg);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPg = totalPg;
            dgvStaff.DataSource=loadRecordsPerpage(currentPg);
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

            private void btnDelete_Click(object sender, EventArgs e)
        {
            StaffClass staff=new StaffClass();
            index = dgvStaff.CurrentCell.RowIndex;
            dgvStaff.Rows.RemoveAt(index);
            btnDelete.Visible= false;
            staffTA.updateDelete(staff.SID);
            clearAll();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gValue = 2;
            gText = rbFemale.Text;
        }
    }
}
