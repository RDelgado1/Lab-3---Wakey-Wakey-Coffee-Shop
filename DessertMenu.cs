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
    public partial class DessertMenu : Form
    {
        static string server = "127.0.0.1";
        static string user = "root";
        static string password = "";
        static string database = "wakeywakeycoffeeshop";

        string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        public class dessertItem
        {
            public int id;
            public string dessertName;
            public decimal dessertPrice;
            public int dessertStock;
        }

        private void dessertGet(int id)
        {
            dessertItem dessertCart = new dessertItem();

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
                    dessertCart.id = reader.GetInt32("id");
                    dessertCart.dessertName = reader.GetString("name");
                    dessertCart.dessertPrice = reader.GetDecimal("price");
                    dessertCart.dessertStock = 1;
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
            ShoppingCart.dessertMenuCart.Add(dessertCart);

            var burgerConfirm = MessageBox.Show(dessertCart.dessertName + " was added to your cart!", "Success!", MessageBoxButtons.OK);
        }

        public DessertMenu()
        {
            InitializeComponent();
        }

        private void dessertBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void sliceOfCakeButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + sliceOfCakeLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dessertGet(7);
            }
        }

        private void souffleButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + souffleLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dessertGet(8);
            }
        }
    }
}
