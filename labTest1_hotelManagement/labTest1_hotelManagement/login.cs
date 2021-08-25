using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTest1_hotelManagement
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, password;
            userName = txtUsername.Text;
            password = txtPassword.Text;
            if (userName == "manish" && password == "password")
            {
                MessageBox.Show("Login Successful!", "Login Dialoge", MessageBoxButtons.OK);
                formHome home = new formHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credential!!\nTry again!!!!!!!!!!", "Login Dialoge", MessageBoxButtons.OK);
            }
        }
    }
}
