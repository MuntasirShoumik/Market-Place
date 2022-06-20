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
    public partial class Form_buyer_registration : Form
    {
        Form_buyer_login form_Buyer_Login;
        public Form_buyer_registration()
        {
            InitializeComponent();
        }

        private void Form_buyer_registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            if ( int.TryParse(id_textBox.Text, out int value))
            {
                SqlConnection con = new SqlConnection("Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                string query = "insert into BUYER values ('" + int.Parse(id_textBox.Text) + "','" + firstName_textBox.Text + "','" + lastName_textBox.Text + "','" + location_comboBox.Text + "','" + email_textBox.Text + "','" + DateTime.Parse(dateTimePicker_buyer.Text) + "','" + password_textBox.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                con.Close();
                MessageBox.Show("Registration succesfull ! ");
            }
            else
            {
                MessageBox.Show("Please Enter a valid Id ! ");
            }

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form_Buyer_Login = new Form_buyer_login();
            this.Hide();
            form_Buyer_Login.Show();
        }

        private void id_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(id_textBox.Text))
            {
                e.Cancel = true;
                id_textBox.Focus();
                errorProvider1.SetError(id_textBox, "Please Enter id !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(id_textBox, null);
            }
        }

        private void firstName_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstName_textBox.Text))
            {
                e.Cancel = true;
                firstName_textBox.Focus();
                errorProvider2.SetError(firstName_textBox, "Please Enter First name !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider2.SetError(firstName_textBox, null);
            }
        }

        private void location_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(location_comboBox.Text))
            {
                e.Cancel = true;
                location_comboBox.Focus();
                errorProvider3.SetError(location_comboBox, "Please Enter your location !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider3.SetError(location_comboBox, null);
            }
        }

        private void email_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(location_comboBox.Text))
            {
                e.Cancel = true;
                email_textBox.Focus();
                errorProvider4.SetError(email_textBox, "Please Enter location !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider4.SetError(email_textBox, null);
            }
        }

        private void password_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(password_textBox.Text))
            {
                e.Cancel = true;
                password_textBox.Focus();
                errorProvider5.SetError(password_textBox, "Please Enter password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider5.SetError(password_textBox, null);
            }
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
