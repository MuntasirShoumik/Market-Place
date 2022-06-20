using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Market_Place
{
    public partial class Form1 : Form
    {
        Form_login_seller form_Login_Seller;
        Form_buyer_login form_Buyer_Login;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          





        }

        private void btn_worker_Click(object sender, EventArgs e)
        {
            form_Login_Seller = new Form_login_seller();
            this.Hide();
            form_Login_Seller.Show();
        }

        private void btn_buyer_Click(object sender, EventArgs e)
        {
            form_Buyer_Login = new Form_buyer_login();
            this.Hide();
            form_Buyer_Login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_admin_login form_Admin_Login = new Form_admin_login();
            this.Hide();
            form_Admin_Login.Show();
        }
    }
}
