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
    public partial class CheckOut : Form
    {
        decimal foodTotal;
        decimal drinkTotal;
        decimal dessertTotal;

        decimal grandTotal;

        private void checkout()
        {
            if (shoppingCart.foodMenuCart.Count > 0)
            {
                checkOutFoodLabel.Text = "Your Food";

                foreach (FoodMenu.foodItem food in shoppingCart.foodMenuCart)
                {
                    foodListView.Items.Add(food.foodName + " \t\t$" + food.foodPrice);
                }
            }
            else
            {
                checkOutFoodLabel.Text = "No Food Added";
                foodListView.Hide();
            }

            if (shoppingCart.drinkMenuCart.Count > 0)
            {
                checkOutDrinkLabel.Text = "Your Drinks";

                foreach (DrinksMenu.drinkItem drink in shoppingCart.drinkMenuCart)
                {
                    drinkListView.Items.Add(drink.drinkName + " \t\t$" + drink.drinkPrice);
                }
            }
            else
            {
                checkOutDrinkLabel.Text = "No Drinks Added";
                drinkListView.Hide();
            }

            if (shoppingCart.dessertMenuCart.Count > 0)
            {
                checkoutDessertLabel.Text = "Your Desserts";

                foreach (DessertMenu.dessertItem dessert in shoppingCart.dessertMenuCart)
                {
                    dessertListView.Items.Add(dessert.dessertName + " \t\t$" + dessert.dessertPrice);
                }
            }
            else
            {
                checkoutDessertLabel.Text = "No Desserts Added";
                dessertListView.Hide();
            }
        }

        private void totalGet()
        {
            foreach (FoodMenu.foodItem food in shoppingCart.foodMenuCart)
            {
                foodTotal += food.foodPrice;
            }

            foreach (DrinksMenu.drinkItem drink in shoppingCart.drinkMenuCart)
            {
                drinkTotal += drink.drinkPrice;
            }

            foreach (DessertMenu.dessertItem dessert in shoppingCart.dessertMenuCart)
            {
                dessertTotal += dessert.dessertPrice;
            }

            grandTotal = foodTotal + drinkTotal + dessertTotal;
        }

        public CheckOut()
        {
            InitializeComponent();

            checkout();

            totalGet();

            Console.WriteLine(grandTotal);

            totalValue.Text = grandTotal.ToString();
        }

        private void cancelCheckout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
