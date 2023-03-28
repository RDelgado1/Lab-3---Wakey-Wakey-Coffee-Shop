using MySql.Data.MySqlClient;
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
    public partial class OrderLookUp : Form
    {
        static string server = "127.0.0.1";
        static string user = "root";
        static string password = "";
        static string database = "wakeywakeycoffeeshop";

        string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        private void orderSearch()
        {
            string orderNumText = orderNumberTextbox.Text;
            string orderEmailText = orderEmailTextBox.Text;

            try
            {

                if(string.IsNullOrEmpty(orderNumberTextbox.Text) && string.IsNullOrEmpty(orderEmailTextBox.Text))
                {
                    Console.WriteLine("empty");
                    var confirmResult = MessageBox.Show("Please Enter either an order number or an email", "Error", MessageBoxButtons.OK);
                }
                else if(!string.IsNullOrEmpty(orderNumberTextbox.Text))
                {
                    string sql = "SELECT * from placedorders where placedOrder_number = '" + orderNumText + "'";
                    conn = new MySqlConnection(connection_string);
                    cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    //reader = cmd.ExecuteReader();

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    orderSearchDataGrid.DataSource = dt;

                    orderNumberTextbox.Text = string.Empty;
                }
                else
                {
                    string sql = "SELECT * from guest where email = '" + orderEmailText + "'";
                    conn = new MySqlConnection(connection_string);
                    cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    //reader = cmd.ExecuteReader();

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    orderSearchDataGrid.DataSource = dt;

                    orderEmailTextBox.Text = string.Empty;
                }
                //string sql = "SELECT * from guest where email='" + orderEmailText + "' OR placedOrder_num='" + orderNumText + "'";
                //conn = new MySqlConnection(connection_string);
                //cmd = new MySqlCommand(sql, conn);

                //conn.Open();

                ////reader = cmd.ExecuteReader();

                //MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                //DataTable dt = new DataTable();
                //adp.Fill(dt);
                //orderSearchDataGrid.DataSource = dt;
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

        }

        public OrderLookUp()
        {
            InitializeComponent();
        }

        private void orderLookUpBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void orderSearchButton_Click(object sender, EventArgs e)
        {
            orderSearch();
            this.Refresh();
        }
    }
}
