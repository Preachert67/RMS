using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace projectRMS
{
    public partial class frmSales : Form
    {
        private void UploadData()
        {
            string selectQuery = "SELECT * FROM orderdetails";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;
        }
        MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=");
        MySqlCommand command;


        public frmSales()
        {
            InitializeComponent();
           // lblOrders.Text = frmOrders.dataGridViewOrders.Rows.Count.ToString()
        }

      

       



        private void frmSales_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmDashboard back = new frmDashboard();
            back.ShowDialog();
        }
    }
}
