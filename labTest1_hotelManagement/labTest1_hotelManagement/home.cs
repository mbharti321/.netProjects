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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            formFoodMenu foodMenuObj = new formFoodMenu();
            foodMenuObj.Show();
            this.Hide();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formHome homeObj = new formHome();
            homeObj.Show();
            this.Hide();
        }
    }
}
