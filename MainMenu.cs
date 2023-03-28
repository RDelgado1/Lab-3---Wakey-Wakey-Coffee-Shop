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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();

        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Food Button Test");
            this.Hide();
            FoodMenu food = new FoodMenu();
            food.ShowDialog();
            this.Show();
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Drink Button Test");
            this.Hide();
            DrinksMenu drinks = new DrinksMenu();
            drinks.ShowDialog();
            this.Show();
        }

        private void dessertButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Dessert Button Test");
            this.Hide();
            DessertMenu dessert = new DessertMenu();
            dessert.ShowDialog();
            this.Show();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCart cart = new ShoppingCart();
            cart.ShowDialog();
            this.Show();
        }

        private void orderLookUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderLookUp lookUp = new OrderLookUp();
            lookUp.ShowDialog();
            this.Show();
        }
    }
}
