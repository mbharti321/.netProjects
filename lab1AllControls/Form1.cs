using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1AllControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, password, result;
            //a = Convert.ToInt32(num1.Text);
            //b = Convert.ToInt32(num2.Text);
            userName = txtUsername.Text;
            password = txtPassword.Text;
            if(userName == "manish" && password == "password")
            {
               MessageBox.Show("Login Successful!","Login Dialoge", MessageBoxButtons.OK);
                formHome home = new formHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credential!!\nTry again!!!!!!!!!!", "Login Dialoge", MessageBoxButtons.OK);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            formRegister register = new formRegister();
            register.Show();
            this.Hide();
        }
    }
}
