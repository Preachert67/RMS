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
    public partial class frmMenu : Form
    {
        private void UploadData()
        {
            string selectQuery = "SELECT * FROM menu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            DataGridMenu.DataSource = table;
        }
        public frmMenu()
        {
            InitializeComponent();
            UploadData();
        }
        MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=; Convert Zero Datetime=True");
        MySqlCommand command;

        private void BtnAddtoMenu_Click(object sender, EventArgs e)
        {
            try
            {

               
                string insertQuery = "INSERT INTO rmsdatabase.menu" +
                                           "(Menu_ID,MenuItem_Name,ItemPrice)" +
                                           "VALUES ('" + this.txtMenuID.Text + "','" + this.txtMenuItemName.Text + "','" + this.txtMenuPrice.Text + "') ;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New item Added", "Menu details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessful", "Menu details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                connection.Close();
                txtMenuID.Text = "";
                txtMenuItemName.Text = "";
                txtMenuPrice.Text = "";
                UploadData();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Enter valid data", "Menu details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard back = new frmDashboard();
            back.ShowDialog();

        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMenuItemName.Text))
                {
                    MessageBox.Show("Please provide menu ID", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                    string insertQuery = "update rmsdatabase.menu set Menu_ID ='" + this.txtMenuID.Text + "',MenuItem_Name ='" + this.txtMenuItemName.Text + "',ItemPrice = '" + this.txtMenuPrice.Text + "'where Menu_ID ='" + this.txtMenuID.Text + "'  ;";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Updated Successfully", "Menu details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Update error", "Menu details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    connection.Close();
                    txtMenuID.Text = "";
                    txtMenuItemName.Text = "";
                    txtMenuPrice.Text = "";
                  

                    UploadData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter valid inputs ", "Menu Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMenuID.Text))
            {
                MessageBox.Show("Please provide Menu ID", "Menu Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string insertQuery = "delete  from rmsdatabase.menu where Menu_ID ='" + this.txtMenuID.Text + "' ;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Deleted Successfully", "Menu Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Delete error", "Menu Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                connection.Close();
                txtMenuID.Text = "";
                txtMenuItemName.Text = "";
                txtMenuPrice.Text = "";
               


                UploadData();
            }
        }
    }
}
