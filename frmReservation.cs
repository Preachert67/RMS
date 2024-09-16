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

        /*ID generator

        private static readonly Random Rng = new Random();

        public int NextNumber()
        {
            return Rng.Next(1000) + 1;
        }
        */

        public frmReservation()
        {
            InitializeComponent();
            UploadData();
           // dateTimePicker. = DateTime.Now;
        }
        MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;


        //==========================================Add reservation==========================================================


        private void btnReserve_Click_1(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtCusName.Text) || string.IsNullOrEmpty(NoOfTables.Text) ||
            string.IsNullOrEmpty(txtNumPeople.Text))
            {
                MessageBox.Show("One or more textfields are empty", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int seats;
                if (int.TryParse(NoOfTables.Text, out seats))
                {
                    if (seats <= 10)
                    {
                        try
                        {
                           
                            string theDate = dateTimePicker.Value.ToShortDateString();//used a string to pass date
                            string insertQuery = "INSERT INTO rmsdatabase.resdetails" +
                                                       "(CustomerName,Customer_tel,Date,NoOfPeople,NoOfTables)" +
                                                       "VALUES ('" + this.txtCusName.Text + "','" + this.txtCusTel.Text + "','" + theDate + "','" + this.txtNumPeople.Text + "','" + this.NoOfTables.Text + "') ;";
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(insertQuery, connection);

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Reserved successfully", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Unsuccessful", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            connection.Close();
                            txtCusName.Text = "";
                            txtCusTel.Text = "";
                            NoOfTables.Text = "";
                            dateTimePicker.Text = "";
                            txtNumPeople.Text = "";
                            UploadData();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Enter valid data", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cannot exceed 10 seats", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

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
                    string insertQuery = "update rmsdatabase.resdetails set Res_ID ='" + this.txtResID.Text + "',CustomerName ='" + this.txtCusName.Text + "',Customer_tel = '" + this.txtCusTel.Text + "',Date = '" + theDate + "',NoOfPeople ='" + this.txtNumPeople.Text + "',NoOfTables ='" + this.NoOfTables.Text + "'where Res_ID ='" + this.txtResID.Text + "'  ;";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Updated Successfully", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Update error", "Reservation details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    connection.Close();
                    txtResID.Text = "";
                    txtCusName.Text = "";
                    txtCusTel.Text = "";
                    NoOfTables.Text = "";
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
                    MessageBox.Show("Deleted Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Delete error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                connection.Close();
                txtResID.Text = "";
                txtCusName.Text = "";
                txtNumPeople.Text = "";
                NoOfTables.Text = "";
                

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

        


        private void txtResID_Enter(object sender, EventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(txtResID.Text))
            {
                txtResID.Text = NextNumber().ToString();

            }
           */
        }

        private void txtCusTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    } 
}

