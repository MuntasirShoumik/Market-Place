using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_Place
{
    public partial class Form_login_seller : Form
    {
        Form1 form1;
        Form_seller_home_page form_Seller_Home_Page;
        Form_seller_registration form_Seller_Registration;
        public Form_login_seller()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            form_Seller_Registration = new Form_seller_registration();
            this.Hide();
            form_Seller_Registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(int.TryParse(id_textBox.Text, out int value))
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");


                string query = "Select * from SELLER where id='" + id_textBox.Text.Trim() + "' and password = '" + password_textBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    form_Seller_Home_Page = new Form_seller_home_page(int.Parse(id_textBox.Text));
                    this.Hide();
                    form_Seller_Home_Page.Show();
                }

                else
                {
                    MessageBox.Show("Wrong password or Id");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Id !");

            }
            
        }

        private void Form_login_seller_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void id_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(id_textBox.Text))
            {
                e.Cancel = true;
                id_textBox.Focus();
                errorProvider1.SetError(id_textBox, "Please Enter your Id !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(id_textBox, null);
            }
        }

        private void password_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(password_textBox.Text))
            {
                e.Cancel = true;
                password_textBox.Focus();
                errorProvider2.SetError(password_textBox, "Please Enter your Password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider2.SetError(password_textBox, null);
            }
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
