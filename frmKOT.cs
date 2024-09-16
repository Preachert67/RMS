using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectRMS
{
    public partial class frmKOT : Form
    {
        
        public frmKOT()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();

        }


        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            txtOid.Text = "";
            txtName1.Text = "";
            txtName2.Text = "";
            txtName3.Text = "";
            txtName4.Text = "";
            txtName5.Text = "";
            txtName6.Text = "";
            txtQ1.Text = "";
            txtQ2.Text = "";
            txtQ3.Text = "";
            txtQ4.Text = "";
            txtQ5.Text = "";
            txtQ6.Text = "";
            lblOrderStatus.Text = "Order Processing";

            this.Close();
       
        }
       
private void frmKOT_Load(object sender, EventArgs e)
        {
            txtOid.TextAlign = HorizontalAlignment.Center;
            txtName1.TextAlign = HorizontalAlignment.Center;
            txtName2.TextAlign = HorizontalAlignment.Center;
            txtName3.TextAlign = HorizontalAlignment.Center;
            txtName4.TextAlign = HorizontalAlignment.Center;
            txtName5.TextAlign = HorizontalAlignment.Center;
            txtName6.TextAlign = HorizontalAlignment.Center;
            txtQ1.TextAlign = HorizontalAlignment.Center;
            txtQ2.TextAlign = HorizontalAlignment.Center;
            txtQ3.TextAlign = HorizontalAlignment.Center;
            txtQ4.TextAlign = HorizontalAlignment.Center;
            txtQ5.TextAlign = HorizontalAlignment.Center;
            txtQ6.TextAlign = HorizontalAlignment.Center;
        }
    }
}
