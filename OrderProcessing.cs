using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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

        string custFirstName;
        string custLastName;
        string custEmail;

        private void newOrder()
        {
            flag.payBool = true;

            int orderNum = rnd.Next(0, 1000000);
            

            try
            {
                string placedOrderSQL = "INSERT INTO placedorders (placedOrder_number, placedOrder_date, placedOrder_amount, prod_count)" +
                " VALUES (@placedOrder_number, @placedOrder_date, @placedOrder_amount, @prod_count)";

                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(placedOrderSQL, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@placedOrder_number", orderNum);
                cmd.Parameters.AddWithValue("@placedOrder_Date", date);
                cmd.Parameters.AddWithValue("@placedOrder_amount", tot.grandTotal);
                cmd.Parameters.AddWithValue("@prod_count", count.totalMenu);

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

            newGuest(orderNum);
        }

        private void newGuest(int order)
        {
            int IDNum = rnd.Next(0, 500);
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

        public OrderProcessing()
        {
            InitializeComponent();
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

            if (!string.IsNullOrEmpty(custFirstName) && !string.IsNullOrEmpty(custLastName) && !string.IsNullOrEmpty(custEmail))
            {
                Console.WriteLine(firstNameTextBox.Text + " " + " " + lastNameTextBox.Text);

                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;

                newOrder();

                if (flag.payBool == true)
                {
                    var confirmResult = MessageBox.Show("Order was successfully made", "New Order", MessageBoxButtons.OK);


                    if (confirmResult == DialogResult.OK)
                    {

                        ShoppingCart.foodMenuCart.Clear();
                        ShoppingCart.drinkMenuCart.Clear();
                        ShoppingCart.dessertMenuCart.Clear();

                        Console.WriteLine(ShoppingCart.foodMenuCart.Count);

                        this.Close();
                    }
                }
            }
            else if(string.IsNullOrEmpty(firstNameTextBox.Text) && string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                var confirmResult = MessageBox.Show("Please Fill Out the Required Information", "New Order", MessageBoxButtons.OK);
            }
        }
    }
}
