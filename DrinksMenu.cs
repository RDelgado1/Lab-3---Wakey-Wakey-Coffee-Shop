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

        int itemsToBeAdded = 0;

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
                string sql = "SELECT id, name, price FROM menu where id = " + id;
                conn = new MySqlConnection(connection_string);
                cmd = new MySqlCommand(sql, conn);

                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //foodItem.id = reader.GetInt32("id");
                    drinkCart.id = reader.GetInt32("id");
                    drinkCart.drinkName = reader.GetString("name");
                    drinkCart.drinkPrice = reader.GetDecimal("price");
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
            ShoppingCart.drinkMenuCart.Add(drinkCart);

            //var burgerConfirm = MessageBox.Show(drinkCart.drinkName + " was added to your cart!", "Success!", MessageBoxButtons.OK);
        }

        private void drinktemCountSelect(string itemName)
        {
            Form itemCount = new Form()
            {
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(300, 125),
                Text = itemName
            };

            Label itemQuestion = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Text = "How many " + itemName + "s do you want to add to your cart?"
            };

            ComboBox itemCountSelection = new ComboBox()
            {
                Text = "-- Select --",
                Dock = DockStyle.Top,
            };

            for (int a = 0; a < 10; a++)
                itemCountSelection.Items.Add(a + 1);

            Button addButton = new Button()
            {
                Text = "Add",
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };

            TableLayoutPanel itemCountSelecLayout = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill
            };


            itemCountSelecLayout.RowCount = 2;
            itemCountSelecLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 52));
            itemCountSelecLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 52));
            itemCountSelecLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 52));
            itemCountSelecLayout.Controls.Add(itemQuestion, 0, 0);
            itemCountSelecLayout.Controls.Add(itemCountSelection, 0, 1);
            itemCountSelecLayout.Controls.Add(addButton, 0, 2);

            itemCount.Controls.Add(itemCountSelecLayout);

            itemCount.Show();

            addButton.Click += (sender, args) =>
            {
                itemsToBeAdded = (int)itemCountSelection.SelectedItem;
                Console.WriteLine(itemsToBeAdded);

                for (int a = 0; a < itemsToBeAdded; a++)
                {
                    if (itemName == sodaLabel.Text)
                    {
                        drinkGet(4);
                        itemCount.Close();
                    }
                    else if (itemName == waterLabel.Text)
                    {
                        drinkGet(5);
                        itemCount.Close();
                    }
                    else if (itemName == beerLabel.Text)
                    {
                        drinkGet(6);
                        itemCount.Close();
                    }
                }

                var confirmResult = MessageBox.Show(itemsToBeAdded + " " + itemName + "(s) were added to your cart", "Added to cart", MessageBoxButtons.OK);
            };
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

            drinktemCountSelect(sodaLabel.Text);
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            drinktemCountSelect(waterLabel.Text);
        }

        private void beerButton_Click(object sender, EventArgs e)
        {
            drinktemCountSelect(beerLabel.Text);
        }
    }
}
