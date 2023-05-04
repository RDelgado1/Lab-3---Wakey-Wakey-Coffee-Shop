using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        int itemsToBeAdded = 0;

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

            //var burgerConfirm = MessageBox.Show(foodCart.foodName + " was added to your cart!", "Success!", MessageBoxButtons.OK);
    }

        private void itemCountSelect(string itemName)
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
            
            for(int a = 0; a < 10; a++)
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
            itemCountSelecLayout.Controls.Add(itemQuestion,0 , 0);
            itemCountSelecLayout.Controls.Add(itemCountSelection, 0, 1);
            itemCountSelecLayout.Controls.Add(addButton, 0, 2);

            itemCount.Controls.Add(itemCountSelecLayout);

            itemCount.Show();

            addButton.Click += (sender, args) =>
            {
                itemsToBeAdded = (int)itemCountSelection.SelectedItem;
                Console.WriteLine(itemsToBeAdded);

                for(int a = 0; a < itemsToBeAdded; a++)
                {
                    if(itemName == burgerLabel.Text)
                    {
                        foodGet(1);
                        itemCount.Close();
                    }
                    else if(itemName == pizzaLabel.Text)
                    {
                        foodGet(2);
                        itemCount.Close();
                    }
                    else if(itemName == saladLabel.Text)
                    {
                        foodGet(3);
                        itemCount.Close();
                    }
                }

                var confirmResult = MessageBox.Show(itemsToBeAdded + " " + burgerLabel.Text + "(s) were added to your cart", "Added to cart", MessageBoxButtons.OK);
            };
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
            itemCountSelect(burgerLabel.Text);
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            /*var confirmResult = MessageBox.Show("Do you want to add " + pizzaLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foodGet(2);
            }*/

            itemCountSelect(pizzaLabel.Text);
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            /*var confirmResult = MessageBox.Show("Do you want to add " + saladLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foodGet(3);
            }*/

            itemCountSelect(saladLabel.Text);
        }

    }
}
