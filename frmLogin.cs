using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectRMS
{
    public partial class frmLogin : Form

    {
        

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        //====================================rounded corners=================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );
        public frmLogin()
         {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); //Rounded corners of frmLogin
       
         }

        public static string SetValueForText1 = "";


        //=========================================================================
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
    

            if ((String.IsNullOrEmpty(txtUsername.Text) || (String.IsNullOrEmpty(txtUsername.Text))))

            {

                MessageBox.Show("Please enter username and password! ", "Login",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM rmsdatabase.employee_info WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "';";
                    command = new MySqlCommand(selectQuery, connection);
                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {

                        SetValueForText1 = txtUsername.Text;            
                        this.Hide();
                        frmDashboard frmDashB = new frmDashboard();
                        frmDashB.ShowDialog();


                    }
                    else
                    {

                        MessageBox.Show("Incorrect Login Information! Try again.","Login",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Credentials are incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

      



        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the data administrator", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }





    }
}
