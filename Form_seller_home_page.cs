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
    public partial class Form_seller_home_page : Form
    {
        Form_login_seller form_Login_Seller;
        int id = 0;
        public Form_seller_home_page(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Form_seller_home_page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
            con.Open();

            if(id != 0){
                SqlCommand cmd = new SqlCommand("SELECT * FROM SELLER WHERE Id = " + id +"",con);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    label12.Text = "id:  " + data.GetValue(0).ToString();
                    label10.Text = "Wellcome "+ data.GetValue(1).ToString();
                    firstName_textBox.Text = data.GetValue(1).ToString();
                    lastname_textBox.Text = data.GetValue(2).ToString();
                    skill_comboBox.Text = data.GetValue(3).ToString();
                    phoneNumber_textBox.Text = data.GetValue(4).ToString();
                    location_comboBox.Text = data.GetValue(5).ToString();
                    email_textBox.Text = data.GetValue(6).ToString();
                    experience_textBox.Text = data.GetValue(7).ToString();
                    dateTimePicker.Text = data.GetValue(8).ToString();
                    password_textBox.Text = data.GetValue(9).ToString();

                }
                con.Close();
            }
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void email_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
            con.Open();
            string query = "UPDATE SELLER SET first_name = '" + firstName_textBox.Text + "',last_name = '" + lastname_textBox.Text + "', skill = '" + skill_comboBox.Text + "', phone_number = '" + phoneNumber_textBox.Text + "', location = '" + location_comboBox.Text + "', email = '" + email_textBox.Text + "', experience = '" + int.Parse(experience_textBox.Text) + "',dob ='" + dateTimePicker.Text + "',password = '" + password_textBox.Text + "' WHERE id = '"+ id +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            con.Close();
            MessageBox.Show("Updated succesfull!! ");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_Login_Seller = new Form_login_seller();
            this.Hide();
            form_Login_Seller.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
