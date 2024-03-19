using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace fitnessTracker
{
    
    
    public partial class staffList : Form
    {
        private int recordsSize = 10;
        private int currentPageIndex = 1;
        private int totalPage = 0;
        private SqlCommand cmd3;
        private SqlDataAdapter adapter;
        private DataTable staffData;
        SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-HUT694Q;Initial Catalog=staffTest;Integrated Security=True;");
        String imagePath;
        public staffList()
        {
            InitializeComponent();
        }
        private void CalculateTotalPages()
        {
            int rowCount = staffData.Rows.Count;
            totalPage = rowCount / recordsSize;
            if (rowCount % recordsSize > 0)
                totalPage += 1;
        }

        private void staffList_Load(object sender, EventArgs e)
        {
            loadStaffData();
        }

        private void loadStaffData()
        {            
                    staffData = new DataTable();
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select ID,staffNo as [Staff No],staffName,staffJoin as [Join From], CASE WHEN staffType=1 THEN 'Full-Time' ELSE 'Part-Time' END as [Staff Type],staffNRC as NRC, CASE WHEN staffGender = 1 THEN 'Male' ELSE 'Female' END AS Gender,staffPhone1 as [Phone No.],staffPhone2 as [Phone No.],staffAddress as Address from staffInfo ", conn);
                    //SqlCommand cmd2 = new SqlCommand("Select photo as [Image Path] from staffInfo", conn);
                    adapter = new SqlDataAdapter(cmd1);
                    //imagePath = cmd2.ExecuteScalar()?.ToString();
                    adapter.Fill(staffData);
                    this.CalculateTotalPages();
                    this.dgvList.ReadOnly = true;
                    dgvList.DataSource = staffData;
                    conn.Close();    
        }

        public void textFilter()
        {
                staffData = new DataTable();
                conn.Open();
                string query = "Select ID,staffNo as [Staff No],staffName,staffJoin as [Join From], CASE WHEN staffType=1 THEN 'Full-Time' ELSE 'Part-Time' END as [Staff Type],staffNRC as NRC, CASE WHEN staffGender = 1 THEN 'Male' ELSE 'Female' END AS Gender,staffPhone1 as [Phone No.],staffPhone2 as [Phone No.],staffAddress as Address from staffInfo WHERE staffName = '" + txtSearch.Text + "'";
                SqlCommand cmd4 = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd4);
                adapter.Fill(staffData);
                dgvList.DataSource = staffData;
                conn.Close();
            
        }
        private object getCurrentRecords(int page, SqlConnection con)
        {
            if (page == 1)
            {
                cmd3 = new SqlCommand("Select TOP " + recordsSize +
                " * from staffInfo ORDER BY ID", con);
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * recordsSize;

                cmd3 = new SqlCommand("Select TOP " + recordsSize +
                    " * from staffInfo WHERE ID NOT IN " +
                    "(Select TOP " + PreviousPageOffSet +
            " ID from staffInfo ORDER BY ID) ", con);
            }
            try
            {
                //con.Open();
                this.adapter.SelectCommand = cmd3;
                this.adapter.Fill(staffData);
            }
            finally
            {
                con.Close();
            }
            return staffData;
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowDialog(this);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = 1;
            this.dgvList.DataSource = getCurrentRecords(this.currentPageIndex, conn);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                this.dgvList.DataSource = getCurrentRecords(this.currentPageIndex, conn);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < this.totalPage)
            {
                this.currentPageIndex++;
                this.dgvList.DataSource =getCurrentRecords(this.currentPageIndex, conn);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = totalPage;
            this.dgvList.DataSource = getCurrentRecords(this.currentPageIndex, conn);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textFilter();
        }

    }
}
