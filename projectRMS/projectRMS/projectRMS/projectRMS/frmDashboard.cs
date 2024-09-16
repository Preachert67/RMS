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
    public partial class frmDashboard : Form
    {

        private Button currentButton;
        private Form activeForm;


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
        public frmDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //Rounded corners of frmLogin
            lblTime.Text = DateTime.Now.ToString();
        }

   
 

       //++++++++++++++++++++++++Dashboard connecting to template========================================= 

        private void btnOrders_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmOrders formOrder = new frmOrders();
            formOrder.TopLevel = false;
            PanelDesktop.Controls.Add(formOrder);
            formOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formOrder.Dock = DockStyle.Fill;
            formOrder.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
           frmFeedback formFeedback = new frmFeedback();
            formFeedback.TopLevel = false;
            PanelDesktop.Controls.Add(formFeedback);
            formFeedback.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formFeedback.Dock = DockStyle.Fill;
            formFeedback.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmReservation formReservation = new frmReservation();
            formReservation.TopLevel = false;
            PanelDesktop.Controls.Add(formReservation);
            formReservation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formReservation.Dock = DockStyle.Fill;
            formReservation.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmSales formSales = new frmSales();
            formSales.TopLevel = false;
            PanelDesktop.Controls.Add(formSales);
            formSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formSales.Dock = DockStyle.Fill;
            formSales.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnTileOrders_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmOrders formOrder = new frmOrders();
            formOrder.TopLevel = false;
            PanelDesktop.Controls.Add(formOrder);
            formOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formOrder.Dock = DockStyle.Fill;
            formOrder.Show();
        }

        private void btnTileMenu_Click(object sender, EventArgs e)
        {
            //wait
        }

        private void btnTileReservation_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmReservation formReservation = new frmReservation();
            formReservation.TopLevel = false;
            PanelDesktop.Controls.Add(formReservation);
            formReservation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formReservation.Dock = DockStyle.Fill;
            formReservation.Show();
        }

        private void btnTileSales_Click(object sender, EventArgs e)
        {
            PanelDesktop.Controls.Clear();
            frmSales formSales = new frmSales();
            formSales.TopLevel = false;
            PanelDesktop.Controls.Add(formSales);
            formSales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formSales.Dock = DockStyle.Fill;
            formSales.Show();
        }
    }
}

