using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace labTest1_hotelManagement
{
    public partial class formFoodMenu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mbhar\Desktop\MCA\dotNetProjects\labTest1_hotelManagement\labTest1_hotelManagement\ManoCafe.mdf;Integrated Security=True");
        public formFoodMenu()
        {
            InitializeComponent();
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String insetrtQuery = "INSERT INTO food1947235(id, fooName, foodPrice, foodType, foodFescription) " +
                "VALUES('" + txtId.Text + "','" + txtFoodName.Text + "' ,'" + txtPrice.Text + "' " +
                ",'" + comboFoodtype.Text + "' ,'" + richTextDescription.Text + "');";
            SqlCommand cd = new SqlCommand(insetrtQuery, conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Food added Successfully!", "ManoCafe Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            String updateQuery = "Update food1947235 set fooName ='" + txtFoodName.Text + ", foodPrice ='" + txtPrice.Text + "', foodType ='" + comboFoodtype.Text +"', foodFescription ='" + richTextDescription.Text + "' where id='" + txtId.Text + "'";
            SqlCommand cd = new SqlCommand(updateQuery, conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Update Successfully!", "ManoCafe Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("Delete from food1947235 where id='" + txtId.Text + "'", conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Deletion Successful!", "ManoCafe Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from food1947235", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void foodMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manoCafeDataSet1.Food1947235' table. You can move, or remove it, as needed.
            this.food1947235TableAdapter1.Fill(this.manoCafeDataSet1.Food1947235);
            // TODO: This line of code loads data into the 'manoCafeDataSet.Food1947235' table. You can move, or remove it, as needed.
            this.food1947235TableAdapter.Fill(this.manoCafeDataSet.Food1947235);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
