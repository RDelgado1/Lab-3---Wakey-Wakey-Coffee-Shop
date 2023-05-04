using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    public partial class OrderProcessing : Form
    {
        static string server = "127.0.0.1";
        static string user = "root";
        static string password = "";
        static string database = "wakeywakeycoffeeshop";

        string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        CheckOut flag = new CheckOut();
        CheckOut tot = new CheckOut();
        ShoppingCart count = new ShoppingCart();

        Random rnd = new Random();

        DateTime date = DateTime.Today;

        string custFirstName, custLastName, custEmail;

        string custAdd, custCity, custState, custZip;

        int IDNum, orderNum;
        int orderNumDisplay;
        string deliveryOrPickup;

        private string[] zipcodeArray =
        {
            "10301", "10302", "10303", "10304", "10305",
            "10306", "10307", "10308", "10309", "10310",
            "10311", "10312", "10313", "10314"
        };
      
        private void newOrder(int orNum)
        {
            orderNumDisplay = orNum;
            flag.payBool = true;

            try
            {
                string placedOrderSQL = "INSERT INTO placedorders (placedOrder_number, placedOrder_date, placedOrder_amount, prod_count)" +
                " VALUES (@placedOrder_number, @placedOrder_date, @placedOrder_amount, @prod_count)";


                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(placedOrderSQL, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@placedOrder_number", orNum);
                cmd.Parameters.AddWithValue("@placedOrder_Date", date);
                cmd.Parameters.AddWithValue("@placedOrder_amount", tot.grandTotal);
                cmd.Parameters.AddWithValue("@prod_count", count.totalMenu);

                cmd.ExecuteNonQuery();

                //flag.payBool = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            try
            {
                IDNum = rnd.Next(0,1000000);

                string placedOrderSQL = "SELECT COUNT(*) FROM guest where id = " + IDNum;


                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(placedOrderSQL, conn);

                conn.Open();

                int idCheck = Convert.ToInt32(cmd.ExecuteScalar());

                //Console.WriteLine(count);

                if (idCheck > 0)
                {
                    IDNum = rnd.Next(0, 1000000);
                    //Console.WriteLine(IDNum);
                }

                newGuest(orderNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        private void newGuest(int order)
        {
            try
            {
                string guestSQL = "INSERT INTO guest (id, first_name, last_name, email, placedOrder_num)" +
                    " VALUES (@id, @first_name, @last_name, @email, @placedOrder_num)";

                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(guestSQL, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@id", IDNum);
                cmd.Parameters.AddWithValue("@first_name", custFirstName);
                cmd.Parameters.AddWithValue("@last_name", custLastName);
                cmd.Parameters.AddWithValue("@email", custEmail);
                cmd.Parameters.AddWithValue("@placedOrder_num", order);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        private void orderCreation()
        {
            int count;

            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;

            addressTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            stateTextBox.Text = string.Empty;
            zipCodeTextBox.Text = string.Empty;

            //Console.WriteLine("zip in the area");

            try
            {
                string searchOrderNum = "SELECT COUNT(*) FROM placedorders where placedOrder_number = " + orderNum;

                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(searchOrderNum, conn);

                conn.Open();

                count = Convert.ToInt32(cmd.ExecuteScalar());

                Console.WriteLine(count);

                if (count > 0)
                {
                    orderNum = rnd.Next(0, 1000000);
                    Console.WriteLine(orderNum);
                }

                newOrder(orderNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        public OrderProcessing()
        {
            InitializeComponent();

            if(pickupRadioButton.Checked == true) { Console.Write("eeoriuejrkgb "); }
        }

        private void oderProcessingCancelButton_Click(object sender, EventArgs e)
        {
            flag.payBool = false;
            this.Close();
        }

        private void orderSubmitButton_Click(object sender, EventArgs e)
        {
            custFirstName = firstNameTextBox.Text;
            custLastName = lastNameTextBox.Text;
            custEmail = emailTextBox.Text;

            custAdd = addressTextBox.Text;
            custCity = cityTextBox.Text;
            custState = stateTextBox.Text;
            custZip = zipCodeTextBox.Text;

            orderNum = rnd.Next(0, 1000000);

            

            if (!string.IsNullOrEmpty(custFirstName) && !string.IsNullOrEmpty(custLastName) && !string.IsNullOrEmpty(custEmail) &&
                !string.IsNullOrEmpty(custAdd) && !string.IsNullOrEmpty(custCity) &&
                !string.IsNullOrEmpty(custState) && !string.IsNullOrEmpty(custZip))
            {
                //Console.WriteLine(firstNameTextBox.Text + " " + " " + lastNameTextBox.Text);

                if(zipcodeArray.Contains(custZip) && deliveryRadioButton.Checked == true)
                {
                    orderCreation();

                    if (flag.payBool == true)
                    {
                        var confirmResult = MessageBox.Show("Order #" + orderNumDisplay + " was successfully placed", "New Order", MessageBoxButtons.OK);


                        if (confirmResult == DialogResult.OK)
                        {

                            ShoppingCart.foodMenuCart.Clear();
                            ShoppingCart.drinkMenuCart.Clear();
                            ShoppingCart.dessertMenuCart.Clear();

                            //Console.WriteLine(ShoppingCart.foodMenuCart.Count);

                            this.Close();
                        }
                    }
                }
                else if(pickupRadioButton.Checked == true)
                {
                    orderCreation();

                    if (flag.payBool == true)
                    {
                        var confirmResult = MessageBox.Show("Order #" + orderNumDisplay + " was successfully sent to the restaurant", "New Order", MessageBoxButtons.OK);

                        if (confirmResult == DialogResult.OK)
                        {

                            ShoppingCart.foodMenuCart.Clear();
                            ShoppingCart.drinkMenuCart.Clear();
                            ShoppingCart.dessertMenuCart.Clear();

                            //Console.WriteLine(ShoppingCart.foodMenuCart.Count);

                            this.Close();
                        }
                    }
                }
            }
            else 
            {
                var confirmResult = MessageBox.Show("Please Fill Out the Required Information", "New Order", MessageBoxButtons.OK);
            }
        }
    }
}
