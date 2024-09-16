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




        //Random number gen for item ID===========================================================================================

        public void AutogenID()
        {
            string n = "123456789";
            int len = n.Length;
            string otp = string.Empty;
            int otpdigit = 4;
            string finaldigit;
            int getindex;

            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = n.ToCharArray()[getindex].ToString();

                }
                while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;

            }

            txtOrderId.Text = (otp);
            //====================================================================================================
        }

        private void BtnAddtocart_Click(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = ((Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString());
                int serviceCharge;
                int subTotal = Convert.ToInt32(txtTotal.Text);
                if (subTotal >= 2000)
                {
                    MessageBox.Show("10% service charge is added");
                    serviceCharge = subTotal * 10 / 100;
                    subTotal = subTotal + serviceCharge;
                }


                dgCart.Rows.Add(txtOrderId.Text, txtName.Text, txtQuantity.Text, txtPrice.Text, subTotal);//adding to datagrid

                int Total = 0;
                for (int i = 0; i < dgCart.Rows.Count; ++i)
                {
                    Total += Convert.ToInt32(dgCart.Rows[i].Cells[4].Value);
                }
                lblTotal.Text = Total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("One more textfields are empty", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgCart_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            object a = dgCart.CurrentRow.Cells["Column3"].Value;
            object b = dgCart.CurrentRow.Cells["Column4"].Value;
            double aNumber = 0;
            double bNumber = 0;
            if (a != null)
                aNumber = Double.Parse(a.ToString());
            if (b != null)
                bNumber = Double.Parse(b.ToString());
            dgCart.CurrentRow.Cells["Column5"].Value = (aNumber * bNumber) + ((aNumber * bNumber) * 10 / 100);

        }


        //UpdateOrder===========================================================================================
        private void btnUpdateOrder_Click_1(object sender, EventArgs e)

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
                    int serviceCharge;
                    int total = Convert.ToInt32(txtTotal.Text);
                    if (total >= 2000)
                    {
                        MessageBox.Show("10% service charge is added");
                        serviceCharge = total * 10 / 100;
                        total = total + serviceCharge;

                    }

                    string insertQuery = "update rmsdatabase.orderdetails set  Order_ID ='" + this.txtOrderId.Text + "',Item_Name ='" + this.txtName.Text + "',Quantity = '" + this.txtQuantity.Text + "',Price ='" + this.txtPrice.Text + "',Total_price ='" + total + "'where Order_ID ='" + this.txtOrderId.Text + "'  ;";
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
                catch (Exception ex)
                {
                    MessageBox.Show("Enter valid inputs ", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //DeleteOrder===========================================================================================

        private void btnDelete_Click_1(object sender, EventArgs e)
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



        //Add to list box===========================================================================================
        private void btnCategory1_Click(object sender, EventArgs e)
        {

            if (listBox.Items.Contains("Chicken Lasagne in concassè"))
            {

            }
            else
            {
                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu ; ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                        string Category01 = myReader.GetString("Mains");
                        listBox.Items.Add(Category01);
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
            if (listBox.Items.Contains("Hot Butter Cuttlefish Pizza"))
            {

            }
            else
            {
                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu ; ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {


                        string Category02 = myReader.GetString("Pizza");
                        listBox.Items.Add(Category02);


                    }


                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnCategory3_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains("KIT KAT Chocshake"))
            {

            }
            else
            {

                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu ; ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {


                        string Category03 = myReader.GetString("Milkshakes");
                        listBox.Items.Add(Category03);


                    }


                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void btnCategory4_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains("Margarita"))
            {

            }
            else
            {

                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu ; ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {


                        string Category04 = myReader.GetString("Cocktails");
                        listBox.Items.Add(Category04);


                    }


                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string curItem = listBox.SelectedItem.ToString();
            txtName.Text = curItem;

            void fill_listbox()
            {
                string constring = "datasource = localhost;port = 3306;username=root;password=";
                string Query = "select * from rmsdatabase.menu where Mains= '" + listBox.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                        string sMain = myReader.GetString("Pizza").ToString();
                        txtName.Text = sMain;
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
            txtOrderId.Clear();
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
                AutogenID();

            }

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmDashboard back = new frmDashboard();
            back.ShowDialog(); // Shows Form2
        }
        frmKOT fr = new frmKOT();


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

            MessageBox.Show("Order Successfull!", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int row = dataGridViewOrders.CurrentRow.Index;
            //fr.txtOrderID.Text = Convert.ToString(dgCart[0, 0].Value);
            //fr.txtOrderID.Text = Convert.ToString(dgCart[0, 1].Value);
            //fr.txtOrderID.Text = Convert.ToString(dgCart[0, 2].Value);
            //fr.txtItemName.Text = Convert.ToString(dgCart[1, 1].Value);
            //fr.txtQuantity.Text = Convert.ToString(dgCart[2, row].Value);
            //fr.ShowDialog();

            dgCart.Rows.Clear();

            //Emptying the textboxes
            txtOrderId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";

        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            int row = dataGridViewOrders.CurrentRow.Index;
            fr.txtOrderID.Text = Convert.ToString(dataGridViewOrders[0, 1].Value);
            fr.txtItemName.Text = Convert.ToString(dataGridViewOrders[0, 2].Value);
            fr.txtQuantity.Text = Convert.ToString(dataGridViewOrders[0, 3].Value);
            fr.ShowDialog();
        }



        private void dgCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


     
    }
}
        

