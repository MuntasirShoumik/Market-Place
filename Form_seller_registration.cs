using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Place
{
    public partial class Form_seller_registration : Form
    {
        Form_login_seller form_Login_Seller;

        SqlConnection con = new SqlConnection("Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
        public Form_seller_registration()
        {
            InitializeComponent();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {

            if ( int.TryParse(id_textBox.Text, out int value))
            {
                con.Open();
                string query = "insert into SELLER values ('" + int.Parse(id_textBox.Text) + "','" + firstName_textBox.Text + "','" + lastName_textBox.Text + "','" + skill_comboBox.Text + "','" + phoneNumber_textBox.Text + "','" + location_comboBox.Text + "','" + email_textBox.Text + "','" + int.Parse(experience_textBox.Text) + "','" + dateTimePicker.Text + "','" + password_textBox.Text + "')";
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

        private void Form_seller_registration_Load(object sender, EventArgs e)
        {
            
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form_Login_Seller = new Form_login_seller();
            this.Hide();
            form_Login_Seller.Show();
        }

        private void id_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(id_textBox.Text))
            {
                e.Cancel = true;
                id_textBox.Focus();
                errorProvider1.SetError(id_textBox, "Please Enter an Id !");
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
                errorProvider2.SetError(firstName_textBox, "Please Enter your first name !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider2.SetError(firstName_textBox, null);
            }
        }

        private void skill_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(skill_comboBox.Text))
            {
                e.Cancel = true;
                skill_comboBox.Focus();
                errorProvider3.SetError(skill_comboBox, "Please Enter your Skill !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider3.SetError(skill_comboBox, null);
            }
        }

        private void phoneNumber_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumber_textBox.Text))
            {
                e.Cancel = true;
                phoneNumber_textBox.Focus();
                errorProvider4.SetError(phoneNumber_textBox, "Please Enter your Phone number!");
            }
            else
            {
                //e.Cancel = true;
                errorProvider4.SetError(phoneNumber_textBox, null);
            }
        }

        private void location_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(location_comboBox.Text))
            {
                e.Cancel = true;
                location_comboBox.Focus();
                errorProvider5.SetError(location_comboBox, "Please Enter your Location !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider5.SetError(location_comboBox, null);
            }
        }

        private void experience_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(experience_textBox.Text))
            {
                e.Cancel = true;
                experience_textBox.Focus();
                errorProvider6.SetError(experience_textBox, "Please Enter your Experience !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider6.SetError(experience_textBox, null);
            }
        }

        private void password_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(password_textBox.Text))
            {
                e.Cancel = true;
                password_textBox.Focus();
                errorProvider7.SetError(password_textBox, "Please Enter a Password !");
            }
            else
            {
                //e.Cancel = true;
                errorProvider7.SetError(password_textBox, null);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
