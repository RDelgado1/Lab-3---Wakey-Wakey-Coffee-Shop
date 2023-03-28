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
    public partial class ShoppingCart : Form
    {
        public static List<FoodMenu.foodItem> foodMenuCart = new List<FoodMenu.foodItem>();
        public static List<DrinksMenu.drinkItem> drinkMenuCart = new List<DrinksMenu.drinkItem>();
        public static List<DessertMenu.dessertItem> dessertMenuCart = new List<DessertMenu.dessertItem>();

        private void cartGet()
        {
            if (foodMenuCart.Count > 0)
            {
                foodCartLabel.Text = "Your Food";

                foreach (FoodMenu.foodItem food in foodMenuCart)
                {
                    foodCheckList.Items.Add(food.foodName + "\t\t\t\t$" + food.foodPrice);
                }
            }
            else
            {
                foodCartLabel.Text = "No Food Added";
                foodCheckList.Hide();
            }

            if(drinkMenuCart.Count > 0)
            {
                drinkCartLabel.Text = "Your Drinks";

                foreach(DrinksMenu.drinkItem drink in drinkMenuCart)
                {
                    drinkCheckList.Items.Add(drink.drinkName + "\t\t\t\t$" + drink.drinkPrice);
                }
            }
            else
            {
                drinkCartLabel.Text = "No Drinks Added";
                drinkCheckList.Hide();
            }

            if(dessertMenuCart.Count > 0)
            {
                dessertCartLabel.Text = "Your Desserts";

                foreach(DessertMenu.dessertItem dessert in dessertMenuCart)
                {
                    dessertCheckList.Items.Add(dessert.dessertName + "\t\t\t\t$" + dessert.dessertPrice);
                }
            }
            else
            {
                dessertCartLabel.Text = "No Desserts Added";
                dessertCheckList.Hide();
            }
        }

        private void cartDelete()
        {
            var foodCheckedItem = foodCheckList.CheckedIndices;
            var drinkCheckedItem = drinkCheckList.CheckedIndices;
            var dessertCheckedItem = dessertCheckList.CheckedIndices;

            for (int i = foodCheckedItem.Count; i > 0;)
            {
                foodCheckList.Items.RemoveAt(foodCheckedItem[--i]);
                foodMenuCart.RemoveAt(i);

                if (foodMenuCart.Count == 0)
                {
                    foodCartLabel.Text = "No Food Added";
                }
            }

            for(int i = drinkCheckedItem.Count; i > 0;)
            {
                drinkCheckList.Items.Remove(drinkCheckedItem[--i]);
                drinkMenuCart.RemoveAt(i);

                if(drinkMenuCart.Count == 0)
                {
                    drinkCartLabel.Text = "No Drinks Added";
                }
            }

            for (int i = dessertCheckedItem.Count; i > 0;)
            {
                dessertCheckList.Items.Remove(dessertCheckedItem[--i]);
                dessertMenuCart.RemoveAt(i);

                if (dessertMenuCart.Count == 0)
                {
                    dessertCartLabel.Text = "No Desserts Added";
                }
            }

            if (foodCheckList.Items.Count == 0 && drinkCheckList.Items.Count == 0 && dessertCheckList.Items.Count == 0)
            {
                deleteButton.Hide();
                checkOutButton.Hide();
            }
        }

        private void cartCheckOut()
        {

            this.Hide();
            CheckOut checkOut = new CheckOut(); ;
            checkOut.ShowDialog();
            this.Show();
        }

        public ShoppingCart()
        {
            InitializeComponent();

            cartGet();

            if (foodMenuCart.Count > 0 || drinkMenuCart.Count > 0 || dessertMenuCart.Count > 0)
            {
                deleteButton.Show();
                checkOutButton.Show();
            }
            else
            {
                deleteButton.Hide();
                checkOutButton.Hide();
            }
        }

        private void cartBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            cartDelete();
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you ready to check out?", "Check Out", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                cartCheckOut();
                this.Hide();
            }
        }
    }
}
