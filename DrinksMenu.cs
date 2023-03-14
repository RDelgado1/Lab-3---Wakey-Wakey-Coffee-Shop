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
    public partial class DrinksMenu : Form
    {
        static string server = "127.0.0.1";
        static string user = "root";
        static string password = "";
        static string database = "wakeywakeycoffeeshop";

        string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        public class drinkItem
        {
            public int id;
            public string drinkName;
            public decimal drinkPrice;
            public int drinkStock;
        }

        private void drinkGet(int id)
        {
            drinkItem drinkCart = new drinkItem();

            try
            {
                string sql = "SELECT id, drinkName, drinkPrice FROM drinkmenu where id = " + id;
                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(sql, conn);

                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //foodItem.id = reader.GetInt32("id");
                    drinkCart.id = reader.GetInt32("id");
                    drinkCart.drinkName = reader.GetString("drinkName");
                    drinkCart.drinkPrice = reader.GetDecimal("drinkPrice");
                    drinkCart.drinkStock = 1;
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
            shoppingCart.drinkMenuCart.Add(drinkCart);

            var burgerConfirm = MessageBox.Show(drinkCart.drinkName + " was added to your cart!", "Success!", MessageBoxButtons.OK);
        }

        public DrinksMenu()
        {
            InitializeComponent();
        }

        private void drinksBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void sodaButton_Click(object sender, EventArgs e)
        {
            
            var confirmResult = MessageBox.Show("Do you want to add " + sodaLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                drinkGet(1);
            }
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + waterLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                drinkGet(2);
            }
        }

        private void beerButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + beerLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                drinkGet(3);
            }
        }
    }
}
