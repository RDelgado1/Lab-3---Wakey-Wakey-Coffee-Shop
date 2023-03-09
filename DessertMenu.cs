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
    public partial class DessertMenu : Form
    {
        public DessertMenu()
        {
            InitializeComponent();
        }

        private void dessertBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void sliceOfCakeButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + sliceOfCakeLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Console.WriteLine(sliceOfCakeLabel.Text + " was added to cart");
            }
            else
            {

            }
        }

        private void souffleButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to add " + souffleLabel.Text + " to your cart?", "Add to cart", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Console.WriteLine(souffleLabel.Text + " was added to cart");
            }
            else
            {

            }
        }
    }
}
