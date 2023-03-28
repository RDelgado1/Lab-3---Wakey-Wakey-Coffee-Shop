using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    public partial class FoodMenu : Form
    {
        static string server = "127.0.0.1";
        static string user = "root";
        static string password = "";
        static string database = "wakeywakeycoffeeshop";

        string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        public class foodItem
        {
            public int id;
            public string foodName;
            public decimal foodPrice;
            public int foodCount;
        }

        private void foodGet(int id)
        {
            foodItem foodCart = new foodItem();

            try
            {
                string sql = "SELECT id, name, price FROM menu where id = " + id;
                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(sql, conn);

                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //foodItem.id = reader.GetInt32("id");
                    foodCart.id = reader.GetInt32("id");
                    foodCart.foodName = reader.GetString("name");
                    foodCart.foodPrice = reader.GetDecimal("price");
                    foodCart.foodCount = 1;
                }
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

            //Console.WriteLine(burgerLabel.Text + " was added to cart");
            ShoppingCart.foodMenuCart.Add(foodCart);

            var burgerConfirm = MessageBox.Show(foodCart.foodName + " was added to your cart!", "Success!", MessageBoxButtons.OK);
    }

        public FoodMenu()
        {
            InitializeComponent();
        }

        private void foodBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void burgerButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + burgerLabel.Text + " to your cart?","Add to cart", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                foodGet(1);
            }
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + pizzaLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foodGet(2);
            }
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + saladLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foodGet(3);
            }
        }
    }
}
