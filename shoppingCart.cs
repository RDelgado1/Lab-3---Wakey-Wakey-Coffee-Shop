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
        public static List<String> cart = new List<string>();

        public static class foodItem
        {
            public static int id;
            public static string foodName;
            public static decimal foodPrice;
            public static int foodCount;
        }

        public FoodMenu foodMenuCart = new FoodMenu();
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
