using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OJTtuutorial3
{
    public partial class Form1 : Form
    {
        public String gender = null;
        DataTable dataTable = new DataTable();
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            txtStaffNo.Text = "";
            txtStaffName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            cbType.SelectedIndex = 0;
            txtNRC.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            txtPh1.Text = "";
            txtPh2.Text = "";
            pbStaff.Image = null;
            dpJoin.CustomFormat = null;
            dpDOB.CustomFormat = null;

        }
        public void GetNextStaffId()
        {
            int nextId = 1;

            if (dataTable.Rows.Count > 0)
            {
                nextId = Convert.ToInt32(dgvStaff.Rows[dataTable.Rows.Count - 1].Cells[0].Value) + 1;
            }

            txtStaffNo.Text = nextId.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Staff No");
            dataTable.Columns.Add("Image");
            dataTable.Columns.Add("Staff Name");
            dataTable.Columns.Add("Join From");
            dataTable.Columns.Add("Staff Type");
            dataTable.Columns.Add("NRC");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Phone No1");
            dataTable.Columns.Add("Phone No2");
            dataTable.Columns.Add("Address");
            GetNextStaffId();
            dgvStaff.DataSource = dataTable;


        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = rbMale.Text;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = rbFemale.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtStaffNo.Text) ||
        String.IsNullOrWhiteSpace(txtStaffName.Text) ||
        String.IsNullOrWhiteSpace(txtAge.Text) ||
        String.IsNullOrWhiteSpace(txtAddress.Text) ||
        String.IsNullOrWhiteSpace(txtNRC.Text) ||
        String.IsNullOrWhiteSpace(txtPh1.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            else if (!long.TryParse(txtPh1.Text, out _) || !long.TryParse(txtPh2.Text, out _) || !int.TryParse(txtAge.Text, out int ageInt))
            {
                MessageBox.Show("Age and Phone Numbers must be numeric.");
                return;
            }
            else if (txtNRC.Text.Length < 13)
            {
                MessageBox.Show("Valid NRC Should be 13 digit Eg. 12/WWE(N)234789");
            }
            else
            {
                DateTime dob = dpDOB.Value;
                DateTime Join = dpJoin.Value;
                dataTable.Rows.Add(txtStaffNo.Text, pbStaff.BackgroundImage, txtStaffName, Join, cbType.Text, txtNRC.Text, gender, txtAge.Text, txtPh1.Text, txtPh2.Text, txtAddress.Text);
            }

            GetNextStaffId();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbStaff.BackgroundImage = new Bitmap(fileDialog.FileName);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dpJoin.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            dpDOB.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dpJoin.CustomFormat = " ";
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dpDOB.CustomFormat = " ";
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
            btnAdd.Visible = false;

            index = e.RowIndex;
            DataGridViewRow row = dgvStaff.Rows[index];
            txtStaffNo.Text = row.Cells[0].Value.ToString();
            txtStaffName.Text = row.Cells[2].Value.ToString();
            cbType.Text = row.Cells[4].Value.ToString();
            txtNRC.Text = row.Cells[5].Value.ToString();
            gender = (string)row.Cells[6].Value;
            txtAge.Text = row.Cells[7].Value.ToString();
            txtPh1.Text = row.Cells[8].Value.ToString();
            txtPh2.Text = row.Cells[9].Value.ToString();
            txtAddress.Text = row.Cells[10].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            btnAdd.Visible = true;
            GetNextStaffId();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dgvStaff.Rows[index];
            newdata.Cells[0].Value = txtStaffNo.Text;
            newdata.Cells[2].Value = txtStaffName.Text;
            newdata.Cells[4].Value = cbType.Text;
            newdata.Cells[5].Value = txtNRC.Text;
            newdata.Cells[6].Value = gender;
            newdata.Cells[7].Value = txtAge.Text;
            newdata.Cells[8].Value = txtPh1.Text;
            newdata.Cells[9].Value = txtPh2.Text;
            newdata.Cells[10].Value = txtAddress.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = dgvStaff.CurrentCell.RowIndex;
            dgvStaff.Rows.RemoveAt(index);
        }
    }
}
