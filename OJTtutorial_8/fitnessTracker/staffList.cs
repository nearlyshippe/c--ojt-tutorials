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
using System.Data.Common;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;


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
                    SqlCommand cmd1 = new SqlCommand("Select ID,staffNo as [Staff No],staffName,staffJoin as [Join From], CASE WHEN staffType=1 THEN 'Full-Time' ELSE 'Part-Time' END as [Staff Type],staffNRC as NRC, CASE WHEN staffGender = 1 THEN 'Male' ELSE 'Female' END AS Gender,staffPhone1 as [Phone No.],staffPhone2 as [Phone No.],staffAddress as Address, photo AS [Image Path] from staffInfo ", conn);
                    //SqlCommand cmd2 = new SqlCommand("Select photo as [Image Path] from staffInfo", conn);
                    adapter = new SqlDataAdapter(cmd1);
                    //imagePath = cmd2.ExecuteScalar()?.ToString();
                    adapter.Fill(staffData);
            if (staffData.Columns.Contains("Image Path"))
            {
                DataColumn imageColumn = new DataColumn("Image", typeof(System.Drawing.Image));
                staffData.Columns.Add(imageColumn);
                foreach (DataRow row in staffData.Rows)
                {
                    string imagePath = row["Image Path"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        row["Image"] = System.Drawing.Image.FromFile(imagePath);

                    }
                }
                staffData.Columns.Remove("Image Path");
                dgvList.RowTemplate.Height = 100;
            }

            this.CalculateTotalPages();
                    this.dgvList.ReadOnly = true;
                    dgvList.DataSource = staffData;
            if (dgvList.Columns[10] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dgvList.Columns[10]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
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
            this.ShowDialog();
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staffLogin login=new staffLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt register = new txt();
            this.Hide();
            register.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dgvList.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf)";
                save.FileName = lblStaffList.Text;
                bool error = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            error = true;
                            MessageBox.Show(ex.Message);
                        }

                    }
                    if (!error)
                    {
                        try
                        {
                            PdfPTable pdftb = new PdfPTable(dgvList.Columns.Count);
                            pdftb.DefaultCell.Padding = 2;
                            pdftb.WidthPercentage = 100;
                            pdftb.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvList.Columns)
                            {
                                PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                pdftb.AddCell(pcell);
                            }
                            foreach (DataGridViewRow row in dgvList.Rows)
                            {
                                foreach (DataGridViewCell datacell in row.Cells)
                                {
                                    pdftb.AddCell(datacell.Value.ToString());
                                }
                            }
                            using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4,8f,16f,16f,8f);
                                document.Open();
                                document.Add(pdftb);
                                document.Close();
                                fs.Close();
                            }
                            MessageBox.Show("Staff Infomation Data Export Success!", "Information");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error While Exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data in Grid View!");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name= "Staff Information";
            for(int i=1; i<dgvList.Columns.Count+1;i++)
            {
                worksheet.Cells[i, 1] = dgvList.Columns[i-1].HeaderText;
            }
            for(int i=0;i<dgvList.Rows.Count;i++)
            {
                for(int j=0;j<dgvList.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvList.Rows[i].Cells[j].Value.ToString();
                }
            }
            var savefile = new SaveFileDialog();
            savefile.FileName = "staffInfo";
            savefile.DefaultExt = ".xlsx";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(savefile.FileName,Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
        }
    }
}
