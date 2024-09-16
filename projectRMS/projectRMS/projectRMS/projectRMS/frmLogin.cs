using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //=========================================================================
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // ==============================Log in access===============================
            string user, password;
            user = txtUsername.Text;
            password = txtPassword.Text;
            if (user == "user" && password == "user@pass") //Password and username
            {
                frmDashboard frmDashboard = new frmDashboard();
                frmDashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or password entered is invalid!", "Error code 401",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the data administrator", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
