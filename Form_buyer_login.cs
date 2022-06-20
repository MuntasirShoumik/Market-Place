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
    public partial class Form_buyer_login : Form
    {
        Form1 form1;
        Form_buyer_registration form_Buyer_Registration;
        Form_buyer_home_page form_Buyer_Home_Page;
        public Form_buyer_login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            form_Buyer_Registration = new Form_buyer_registration();
            this.Hide();
            form_Buyer_Registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(id_textBox.Text,out int value))
            {

                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");


                string query = "Select * from BUYER where id='" + id_textBox.Text.Trim() + "' and password = '" + password_textBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    form_Buyer_Home_Page = new Form_buyer_home_page(int.Parse(id_textBox.Text));
                    this.Hide();
                    form_Buyer_Home_Page.Show();
                }

                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Id !");
            }
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(id_textBox.Text))
            {
                e.Cancel = true;
                id_textBox.Focus();
                errorProvider1.SetError(id_textBox, "Please Enter your User Id !");
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
                errorProvider2.SetError(password_textBox, "Please Enter your User Password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider2.SetError(password_textBox, null);
            }
        }

        private void Form_buyer_login_Load(object sender, EventArgs e)
        {

        }
    }
}
