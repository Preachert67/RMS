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
    public partial class frmReservation : Form
    {

        private void UploadData()
        {
            string selectQuery = "SELECT * FROM resdetails";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridViewRes.DataSource = table;
        }


        public frmReservation()
        {
            InitializeComponent();
            UploadData();

        }
        MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;


        //====================================================================================================

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            
                try
                {

                string theDate = dateTimePicker.Value.ToShortDateString();//used a string to pass date
                string insertQuery = "INSERT INTO rmsdatabase.resdetails" +
                                           "(CustomerName,Date,NoOfPeople,NoOfTables)" +
                                           "VALUES ('" + this.txtCusName.Text + "','" + theDate + "','" + this.txtNumPeople.Text + "','" + this.txtNumOfTables.Text + "') ;";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data input Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data input Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                    txtCusName.Text = "";
                    txtNumOfTables.Text = "";
                    dateTimePicker.Text = "";
                    txtNumPeople.Text = "";
                    UploadData();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            
        }

        //=========================================Update res===================================================
        private void btnUpdateRes_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtResID.Text))
                {
                    MessageBox.Show("Please provide order ID", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string theDate = dateTimePicker.Value.ToShortDateString();//used a string to pass date
                    string insertQuery = "update rmsdatabase.resdetails set Res_ID ='" + this.txtResID.Text + "',CustomerName ='" + this.txtCusName.Text + "',Date = '" + theDate + "',NoOfPeople ='" + this.txtNumPeople.Text + "',NoOfTables ='" + txtNumOfTables + "'where Res_ID ='" + this.txtResID.Text + "'  ;";
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
                    txtResID.Text = "";
                    txtCusName.Text = "";
                    txtNumOfTables.Text = "";
                    txtNumPeople.Text = "";

                    UploadData();

            }   }
            catch (Exception ex)
            {
                MessageBox.Show("Enter valid inputs ", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }
        //=======================================================Delete res=========================================================
        
        private void btnDeleteRes_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtResID.Text))
            {
                MessageBox.Show("Please provide order ID", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string insertQuery = "delete  from rmsdatabase.resdetails where Res_ID ='" + this.txtResID.Text + "' ;";
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
                txtResID.Text = "";
                txtCusName.Text = "";
                txtNumPeople.Text = "";
                txtNumOfTables.Text = "";
                

                UploadData();
            }

        }


        //============================================Exit==========================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //============================================Back=========================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard back = new frmDashboard();
            back.ShowDialog();
        }
        //===========================================Calling the main upload data method when loading the form===================================================
        private void frmReservation_Load(object sender, EventArgs e)
        {
            UploadData();
        }
}   }

