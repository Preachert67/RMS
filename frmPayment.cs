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
    public partial class frmPayment : Form
    {

        public frmPayment()
        {
            InitializeComponent();
        }

        private static readonly Random Rng = new Random();

        public int NextNumber()
        {
            return Rng.Next(10000) + 1;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblInvoiceNo.Text = NextNumber().ToString();
            lblDate.Text = DateTime.Now.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
