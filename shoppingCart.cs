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
    public partial class shoppingCart : Form
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
                    foodCheckList.Items.Add(food.foodName + " $" + food.foodPrice);
                }
            }
            else
            {
                foodCartLabel.Text = "No food Added";
                foodCheckList.Hide();
            }

            if(drinkMenuCart.Count > 0)
            {
                drinkCartLabel.Text = "Your Drinks";

                foreach(DrinksMenu.drinkItem drink in drinkMenuCart)
                {
                    drinkCheckList.Items.Add(drink.drinkName + " $" + drink.drinkPrice);
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
                    dessertCheckList.Items.Add(dessert.dessertName + " $" + dessert.dessertPrice);
                }
            }
            else
            {
                dessertCartLabel.Text = "No Desserts Added";
                dessertCheckList.Hide();
            }
        }


        public shoppingCart()
        {
            InitializeComponent();

            cartGet();

            if(foodMenuCart.Count > 0 || drinkMenuCart.Count > 0 || dessertMenuCart.Count > 0)
            {
                deleteButton.Show();
            }else
            {
                deleteButton.Hide();
            }
        }

        private void cartBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for(int a = foodCheckList.Items.Count - 1; a >= 0; a--)
            {
                if (foodCheckList.GetItemChecked(a))
                {
                    foodCheckList.Items.RemoveAt(foodCheckList.CheckedIndices[a]);
                    foodMenuCart.RemoveAt(a);
                }
            }

            for (int a = drinkCheckList.Items.Count - 1; a >= 0; a--)
            {
                if (drinkCheckList.GetItemChecked(a))
                {
                    drinkCheckList.Items.RemoveAt(drinkCheckList.CheckedIndices[a]);
                    drinkMenuCart.RemoveAt(a);
                }
            }

            for (int a = dessertCheckList.Items.Count - 1; a >= 0; a--)
            {
                if (dessertCheckList.GetItemChecked(a))
                {
                    dessertCheckList.Items.RemoveAt(dessertCheckList.CheckedIndices[a]);
                    dessertMenuCart.RemoveAt(a);
                }
            }
        }
    }
}
