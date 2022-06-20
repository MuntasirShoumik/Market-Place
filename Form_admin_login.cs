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
    public partial class Form_admin_login : Form
    {
        public Form_admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FACELESS;Initial Catalog=market_place;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False");


            string query = "Select * from ADMIN where name = '"+ id_textBox.Text.Trim() + "' and password = '" + password_textBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form_admin_home form_Admin_Home= new Form_admin_home();
                this.Hide();
                form_Admin_Home.Show();
            }

            else
            {
                MessageBox.Show("Wrong password or user name !");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void id_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(id_textBox.Text))
            {
                e.Cancel = true;
                id_textBox.Focus();
                errorProvider1.SetError(id_textBox, "Please Enter your User Name !");
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

        private void Form_admin_login_Load(object sender, EventArgs e)
        {

        }
    }

}
