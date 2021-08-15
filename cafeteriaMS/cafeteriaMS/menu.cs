using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteriaMS
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void linkLblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
        }

        private void linkLblOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formOrder order = new formOrder();
            order.Show();
            this.Hide();
        }

        private void linkLblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHome home = new formHome();
            home.Show();
            this.Hide();
        }
    }
}
