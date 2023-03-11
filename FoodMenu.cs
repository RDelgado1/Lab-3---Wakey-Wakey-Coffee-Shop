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
    public partial class FoodMenu : Form
    {
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

            if(confirmResult == DialogResult.Yes)
            {
                Console.WriteLine(burgerLabel.Text + " was added to cart");
                shoppingCart.cart.Add("one");
            }
            else
            {

            }
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + pizzaLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Console.WriteLine(pizzaLabel.Text + " was added to cart");
                shoppingCart.cart.Add("two");
            }
            else
            {

            }
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + saladLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Console.WriteLine(saladLabel.Text + " was added to cart");
            }
            else
            {

            }
        }
    }
}
