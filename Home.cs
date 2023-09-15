using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.Forms.Fields;
using iText.Forms;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Linq.Expressions;

namespace EmployeesApplication
{
    public partial class Home : Form
    {
        //For sliding datagrid
        private bool isDragging = false;
        private int initialMouseY;
        private int initialScrollValue;
        /*---------------------*/


        public string EmpName;

        public string Designation;
        public DateTime DateOfJoining;
        public string EmpCode;
        public string Pan;
        public string EmpAddress;
        public string EmpBasic;
        public string EmpHra;
        public string EmpTA;
        public string OtherAllowance;
        public string MedicalAllowance;
        public string RemoteWorkAllowance;
        public string TotalCTC;
        public string Bonus;
        public string PF;
        public string ESIC;
        public string Loan;
        public string Advance;
        public string Other;
        public string TDS;
        public string TotalEarnings;
        public string TotalDeductions;
        public string NetPayable;
        //string Path2 = "Data Source=Devanshu\\MSSQLSERVER01;Initial Catalog=Emp_Data;User ID=user;Password=7935";
        public string EmployeeName;
        public static string s;
        string path = System.Configuration.ConfigurationManager.
    ConnectionStrings["mydb"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;

        public Home()
        {
            InitializeComponent();
            conn = new SqlConnection(path);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form1 form = new Form1();
            form.Show();
            /* Form1 form1 = new Form1();
              form1*/
            Home home = new Home();
            home.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //display();
        }

        public void display()
        {

            try
            {
                string name = txtname.Text;
                dt = new System.Data.DataTable();
                conn.Open();
                adpt = new SqlDataAdapter("exec LoadEmp_DB '" + name + "'", conn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {



            AllDisplay();

            dataGridView1.Columns[0].Width = 320;
            dataGridView1.Columns[1].Width = 320;
            dataGridView1.Columns[2].Width = 320;
            dataGridView1.Columns[3].Width = 320;
            //dataGridView1.Columns[4].Width = 300;
            dataGridView1.Columns[5].Width = 320;
            dataGridView1.Columns[6].Width = 320;



        }
        public void AllDisplay()
        {
            try
            {

                dt = new System.Data.DataTable();
                conn.Open();
                adpt = new SqlDataAdapter("exec LoadAllEmp", conn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                /*
                 Hiding Some columns of datagrid
                */
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[23].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {



        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }*/

        private void rightMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Determine the row that was right-clicked
                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    // Clear any existing selections
                    dataGridView1.ClearSelection();

                    // Select the clicked row
                    dataGridView1.Rows[e.RowIndex].Selected = true;

                    // Get the position for showing the context menu
                    Point mousePos = dataGridView1.PointToClient(Cursor.Position);

                    // Show the context menu at the clicked position
                    contextMenuStrip1.Show(dataGridView1, mousePos);
                }
                //contextMenuStrip1.Show(btnget, 0, btnget.Height);
                EmpName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                EmpCode = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Designation = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateOfJoining = (DateTime)(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                Pan = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                EmpAddress = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                TotalCTC = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                EmpBasic = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                EmpHra = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                EmpTA = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                OtherAllowance = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                MedicalAllowance = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                RemoteWorkAllowance = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                Bonus = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                PF = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                ESIC = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                Loan = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                Advance = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                Other = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                TDS = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();

                TotalEarnings = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
                TotalDeductions = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
                NetPayable = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();


                contextMenuStrip1.ItemClicked -= contextMenuStrip1_ItemClicked;
                contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
                /*  OtherDetails o = new OtherDetails();
                  o.ShowDialog();*/
            }

        }


        public void RefreshDataGridView()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adpt = new SqlDataAdapter("exec LoadAllEmp", conn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                adpt = new SqlDataAdapter("exec Search_DB '" + btnsearch2.Text + "'", conn);

                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 320;
                dataGridView1.Columns[1].Width = 320;
                dataGridView1.Columns[2].Width = 320;
                dataGridView1.Columns[3].Width = 320;
                dataGridView1.Columns[4].Width = 320;
                dataGridView1.Columns[5].Width = 320;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Grid Double Click Event
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            /* Form1 form1 = new Form1();
              form1*/
            Home home = new Home();
            home.Close();
        }

        private void pdfstriptool_Click(object sender, EventArgs e)
        {
            /* OtherDetails otherDetails = new OtherDetails();
             otherDetails.Show();*/
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Determine the location to display the secondary form (next to the context menu)
            /*Point contextMenuLocation = this.PointToScreen(contextMenuStrip1.Location);
            int x = contextMenuLocation.X + contextMenuStrip1.Width;
            int y = contextMenuLocation.Y;*/
            if (e.ClickedItem.Text == "Generate Salary Slip")
            {
                OtherDetails o = new OtherDetails();
                /*o.StartPosition = FormStartPosition.Manual;
                o.Location = new Point(x, y);*/
                o.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }



        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }*/

        /*  private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {

          }*/
    }
}

