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

        private void btnUpdateRes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                MessageBox.Show("Please provide order ID", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    txtTotal.Text = ((Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString());
                   // int serviceCharge;
                    int total = Convert.ToInt32(txtTotal.Text);
                   

                    string insertQuery = "update rmsdatabase.orderdetails set  Order_ID ='" + this.txtOrderId.Text + "',Item_Name ='" + this.txtName.Text + "',Quantity = '" + this.txtQuantity.Text + "',Price ='" + this.txtPrice.Text + "',Total_price ='" + total + "'where Order_ID ='" + this.txtOrderId.Text + "'  ;";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 5)
                    {
                        MessageBox.Show("Data input Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Data input Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    connection.Close();
                    txtOrderId.Text = "";
                    txtName.Text = "";
                    txtQuantity.Text = "";
                    txtPrice.Text = "";
                    txtTotal.Text = "";

                    UploadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter valid inputs ", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                MessageBox.Show("Please provide order ID", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string insertQuery = "delete  from rmsdatabase.orderdetails where Order_ID ='" + this.txtOrderId.Text + "' ;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data input Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Data input Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                connection.Close();
                txtOrderId.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                txtTotal.Text = "";

                UploadData();
            }
        }
    }
}
