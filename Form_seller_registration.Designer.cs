
namespace Market_Place
{
    partial class Form_seller_registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_seller_registration));
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.experience_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.location_comboBox = new System.Windows.Forms.ComboBox();
            this.skill_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.btn_registration = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(561, 185);
            this.firstName_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(139, 27);
            this.firstName_textBox.TabIndex = 0;
            this.firstName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstName_textBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(743, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(835, 185);
            this.lastName_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(114, 27);
            this.lastName_textBox.TabIndex = 2;
            this.lastName_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "skill";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(456, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "phone";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(562, 291);
            this.phoneNumber_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(138, 27);
            this.phoneNumber_textBox.TabIndex = 6;
            this.phoneNumber_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumber_textBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(456, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(562, 388);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(138, 27);
            this.email_textBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(456, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Experience";
            // 
            // experience_textBox
            // 
            this.experience_textBox.Location = new System.Drawing.Point(561, 441);
            this.experience_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.experience_textBox.Name = "experience_textBox";
            this.experience_textBox.Size = new System.Drawing.Size(138, 27);
            this.experience_textBox.TabIndex = 12;
            this.experience_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.experience_textBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(457, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(579, 553);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker.TabIndex = 16;
            // 
            // location_comboBox
            // 
            this.location_comboBox.FormattingEnabled = true;
            this.location_comboBox.Items.AddRange(new object[] {
            "Mirpur",
            "Uttara",
            "Basundhara R/A",
            "Nikunja 1",
            "Nikunja 2",
            "Gulshan 1",
            "Gulshan 2",
            "Banani",
            "Banasree"});
            this.location_comboBox.Location = new System.Drawing.Point(561, 340);
            this.location_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_comboBox.Name = "location_comboBox";
            this.location_comboBox.Size = new System.Drawing.Size(138, 28);
            this.location_comboBox.TabIndex = 18;
            this.location_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.location_comboBox_Validating);
            // 
            // skill_comboBox
            // 
            this.skill_comboBox.FormattingEnabled = true;
            this.skill_comboBox.Items.AddRange(new object[] {
            "Machanic",
            "Electrician",
            "Carpenter",
            "key maker",
            "Plumber"});
            this.skill_comboBox.Location = new System.Drawing.Point(562, 243);
            this.skill_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skill_comboBox.Name = "skill_comboBox";
            this.skill_comboBox.Size = new System.Drawing.Size(138, 28);
            this.skill_comboBox.TabIndex = 19;
            this.skill_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.skill_comboBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(456, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(562, 497);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(138, 27);
            this.password_textBox.TabIndex = 20;
            this.password_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.password_textBox_Validating);
            // 
            // btn_registration
            // 
            this.btn_registration.BackColor = System.Drawing.Color.White;
            this.btn_registration.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_registration.Location = new System.Drawing.Point(551, 628);
            this.btn_registration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(240, 52);
            this.btn_registration.TabIndex = 22;
            this.btn_registration.Text = "Register";
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(457, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(562, 128);
            this.id_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(138, 27);
            this.id_textBox.TabIndex = 23;
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            this.id_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_textBox_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 716);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(527, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 50);
            this.label11.TabIndex = 26;
            this.label11.Text = "REGISTRATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Form_seller_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.skill_comboBox);
            this.Controls.Add(this.location_comboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.experience_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName_textBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_seller_registration";
            this.Text = "Form_seller_registration";
            this.Load += new System.EventHandler(this.Form_seller_registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox experience_textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox location_comboBox;
        private System.Windows.Forms.ComboBox skill_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}