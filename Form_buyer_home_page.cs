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
    public partial class Form_buyer_home_page : Form
    {
        Form_buyer_login form_Buyer_Login;
        int id = 0;
        
        public Form_buyer_home_page(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Form_buyer_home_page_Load(object sender, EventArgs e)
        {
            BindData();
            comboBox1.Text = "Any Location";
            comboBox2.Text = "Any Skill";
            SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
            con.Open();

            if (id != 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM BUYER WHERE Id = " + id + "", con);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    label12.Text = "id:  " + data.GetValue(0).ToString();
                    label10.Text = "Wellcome " + data.GetValue(1).ToString();
                    firstName_textBox.Text = data.GetValue(1).ToString();
                    lastName_textBox.Text = data.GetValue(2).ToString();
                    location_comboBox.Text = data.GetValue(3).ToString();
                    password_textBox.Text = data.GetValue(6).ToString();
                    email_textBox.Text = data.GetValue(4).ToString();
                    
                    dateTimePicker.Text = data.GetValue(5).ToString();
                   

                }
                con.Close();
            }
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
            con.Open();
            SqlCommand command = new SqlCommand("select first_name,last_name,skill,phone_number,location,email,experience from SELLER", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text != "Any Skill" && comboBox1.Text != "Any Location")
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER where skill='" + comboBox2.Text.ToString().Trim() + "' and location = '" + comboBox1.Text.ToString().Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }else if(comboBox2.Text != "Any Skill" && comboBox1.Text == "Any Location")
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER where skill='" + comboBox2.Text.ToString().Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }else if(comboBox2.Text == "Any Skill" && comboBox1.Text != "Any Location")
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER where location='" + comboBox1.Text.ToString().Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }else if(comboBox2.Text == "Any Skill" && comboBox1.Text == "Any Location")
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER where first_name ='" + textBox1.Text.ToString().Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
            con.Open();
            string query = "UPDATE BUYER SET first_name = '" + firstName_textBox.Text + "',last_name = '" + lastName_textBox.Text  + "', location = '" + location_comboBox.Text + "', email = '" + email_textBox.Text  + "',dob ='" + dateTimePicker.Text + "',password = '" + password_textBox.Text + "' WHERE id = '" + id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            con.Close();
            MessageBox.Show("Updated succesful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_Buyer_Login = new Form_buyer_login();
            this.Hide();
            form_Buyer_Login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            


            
            
                radioButton1.Checked = false;



                SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");
                con.Open();
                SqlCommand command = new SqlCommand("Select first_name,last_name,skill,phone_number,location,email,experience from SELLER where  location ='" + location_comboBox.Text.ToString().Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            

            
        }
    }
}
