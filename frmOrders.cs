using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace projectRMS
{
    public partial class frmOrders : Form
    {


        private void UploadData()
        {
            string selectQuery = "SELECT * FROM orderdetails";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;
        }


        private bool isCollapse;
        public frmOrders()
        {
            InitializeComponent();

        }
        MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=");
        MySqlCommand command;


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                pizzaPanelDropdown.Height += 10;
                if (pizzaPanelDropdown.Size == pizzaPanelDropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapse = false;
                }
            }

            else
            {
                pizzaPanelDropdown.Height -= 10;
                if (pizzaPanelDropdown.Size == pizzaPanelDropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapse = true;
                }

            }

        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }




        //Random number gen for item ID=======================================================

        private static readonly Random Rng = new Random();

        public int NextNumber()
        {
            return Rng.Next(1000) + 1; 
        }

        //===================================Add to cart======================================
     

        private void BtnAddtocart_Click(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = ((Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString());
               // int serviceCharge;
                int subTotal = Convert.ToInt32(txtTotal.Text);
              

                dgCart.Rows.Add(txtOrderId.Text, txtName.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text);//adding to datagrid
                int Total = 0;
                for (int i = 0; i < dgCart.Rows.Count; ++i)
                {
                 Total += Convert.ToInt32(dgCart.Rows[i].Cells[4].Value);
                }
                if (Total >= 2000)
                {
                    MessageBox.Show("Service charge is added", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Total = (Total * 10 / 100) + Total;
                }
                lblTotal.Text = Total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("One more textfields are empty", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgCart_CellValidated(object sender, DataGridViewCellEventArgs e)//Calclation inside datagridview
        {
            object a = dgCart.CurrentRow.Cells["Column3"].Value;
            object b = dgCart.CurrentRow.Cells["Column4"].Value;
            double aNumber = 0;
            double bNumber = 0;
            if (a != null)
                aNumber = Double.Parse(a.ToString());
            if (b != null)
                bNumber = Double.Parse(b.ToString());
            dgCart.CurrentRow.Cells["Column5"].Value = aNumber * bNumber;

            int Total = 0;
            for (int i = 0; i < dgCart.Rows.Count; ++i)
            {
                Total += Convert.ToInt32(dgCart.Rows[i].Cells[4].Value);
            }
            if (Total >= 2000)
            {
              //  MessageBox.Show("Service charge is added", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Total = (Total * 10 / 100) + Total;
            }
            lblTotal.Text = Total.ToString();
        }



        //DeleteOrder===========================================================================================

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
      
                foreach (DataGridViewRow item in this.dgCart.SelectedRows)
                {
                    dgCart.Rows.RemoveAt(item.Index);
                     MessageBox.Show("Item removed", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            txtOrderId.Clear();
            txtQuantity.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }



        //Add to list box===========================================================================================
        private void btnCategory1_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains("Maggi"))
            {

            }
            else
            {
                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "SELECT MenuItem_Name, ItemPrice FROM rmsdatabase.menu ; ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                        string menuName = myReader.GetString("MenuItem_Name");
                        listBox.Items.Add(menuName);
                    }


                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        //Precoded Menus ===========================================================

        private void btnCategory2_Click(object sender, EventArgs e)
        {
           //Can add more menu
        }

        private void btnCategory3_Click(object sender, EventArgs e)
        {
            //Can add more menu

        }

        private void btnCategory4_Click(object sender, EventArgs e)
        {
            //Can add more menu
        }

        //========================================Selecting Items from the List box to display Name and ID===============================
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string curItem = listBox.SelectedItem.ToString();
            txtName.Text = curItem;

            
            {
                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu where MenuItem_Name = '" + listBox.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                        string MenuName = myReader.GetString("MenuItem_Name").ToString();
                        txtName.Text = MenuName;
                        string mPrice = myReader.GetString("ItemPrice").ToString();
                        txtPrice.Text = mPrice;
                    }


                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        //Clear Fields==================================================
        private void btnAddmore_Click_1(object sender, EventArgs e)
        {

            txtQuantity.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            UploadData();
           
        }

        //===========================================================================
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
           
            txtQuantity.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }



        //Order ID implementation=========================================================

        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                txtOrderId.Text = NextNumber().ToString();

            }

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmDashboard back = new frmDashboard();
            back.ShowDialog(); // Shows Form2
     
  
        }
        


        //PLace order===========================================================================================================

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("datasource =localhost;port=3306;Initial Catalog=rmsdatabase;username=root;password=");
            for (int i = 0; i < dgCart.Rows.Count - 1; i++)
            {
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO rmsdatabase.orderdetails(Order_ID,Item_Name,Quantity,Price,Total_price) VALUES ('" + dgCart.Rows[i].Cells[0].Value + "','"
                                                                                                                            + dgCart.Rows[i].Cells[1].Value + "','"
                                                                                                                            + dgCart.Rows[i].Cells[2].Value + "','"
                                                                                                                            + dgCart.Rows[i].Cells[3].Value + "','"
                                                                                                                            + dgCart.Rows[i].Cells[4].Value + "')", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            UploadData();

            MessageBox.Show("Order Successfull!", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //========================================KOT=============================================
            
                frmKOT fr = new frmKOT();
                int numOfRows = dgCart.RowCount;

            if (numOfRows < 2)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                fr.ShowDialog();
            }

            else if (numOfRows < 3)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);            
                fr.ShowDialog();
            }


            else if (numOfRows < 4)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                fr.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                fr.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
            
                fr.ShowDialog();
            }

            else if (numOfRows < 5)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                fr.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                fr.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                fr.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                fr.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);              
                fr.ShowDialog();
            }

            else if (numOfRows < 5)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                fr.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                fr.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                fr.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                fr.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);
                fr.txtName5.Text = Convert.ToString(dgCart[1, 4].Value);
                fr.txtQ5.Text = Convert.ToString(dgCart[2, 4].Value);
                fr.ShowDialog();
            }

            else if (numOfRows < 6)
            {
                fr.txtOid.Text = Convert.ToString(dgCart[0, 0].Value);
                fr.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                fr.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                fr.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                fr.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                fr.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                fr.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                fr.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                fr.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);
                fr.txtName5.Text = Convert.ToString(dgCart[1, 4].Value);
                fr.txtQ5.Text = Convert.ToString(dgCart[2, 4].Value);
                fr.ShowDialog();
            }
            //===========================================Payment Slip==========================================================

        
            frmPayment frm = new frmPayment();
            int Total = 0;
            for (int i = 0; i < dgCart.Rows.Count; ++i)
            {
                Total += Convert.ToInt32(dgCart.Rows[i].Cells[4].Value);
            }
            if (Total >= 2000)
            {
                Total = (Total * 10 / 100) + Total;
            }
            lblTotal.Text = Total.ToString();
            frm.lblTotalPayment.Text = Total.ToString();

            if (numOfRows < 2)
            {
               
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.ShowDialog();
            }

            else if (numOfRows < 3)
            {
               
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.ShowDialog();
            }


            else if (numOfRows < 4)
            {
            
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                frm.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);

                frm.ShowDialog();
            }

            else if (numOfRows < 5)
            {
        
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                frm.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                frm.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                frm.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);
                frm.ShowDialog();
            }

            else if (numOfRows < 5)
            {
              
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                frm.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                frm.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                frm.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);
                frm.txtName5.Text = Convert.ToString(dgCart[1, 4].Value);
                frm.txtQ5.Text = Convert.ToString(dgCart[2, 4].Value);
                frm.ShowDialog();
            }

            else if (numOfRows < 6)
            {
               
                frm.txtName1.Text = Convert.ToString(dgCart[1, 0].Value);
                frm.txtQ1.Text = Convert.ToString(dgCart[2, 0].Value);
                frm.txtName2.Text = Convert.ToString(dgCart[1, 1].Value);
                frm.txtQ2.Text = Convert.ToString(dgCart[2, 1].Value);
                frm.txtName3.Text = Convert.ToString(dgCart[1, 2].Value);
                frm.txtQ3.Text = Convert.ToString(dgCart[2, 2].Value);
                frm.txtName4.Text = Convert.ToString(dgCart[1, 3].Value);
                frm.txtQ4.Text = Convert.ToString(dgCart[2, 3].Value);
                frm.txtName5.Text = Convert.ToString(dgCart[1, 4].Value);
                frm.txtQ5.Text = Convert.ToString(dgCart[2, 4].Value);
                frm.ShowDialog();
            }


          
         

            


            //Emptying datagrid 
            dgCart.Rows.Clear();

            //Emptying the textboxes
            txtOrderId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";
            lblTotal.Text = "";
        }

    

     
    }
}
        

