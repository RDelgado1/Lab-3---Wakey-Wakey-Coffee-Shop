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


        public shoppingCart()
        {
            InitializeComponent();
        }

        private void cartBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
