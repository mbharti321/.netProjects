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

namespace university
{
    public partial class formUniversity : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mbhar\Desktop\MCA\dotNetProjects\university\university\university\Database3.mdf;Integrated Security=True");
        public formUniversity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database3DataSet.student);

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            String insetrtQuery = "INSERT INTO student(username, password) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "');";
            SqlCommand cd = new SqlCommand(insetrtQuery, conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Registration Successful!!", "Student Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("Update student set password ='" + txtPassword.Text + "' where username='" + txtUsername.Text + "'", conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Update Successful!", "Student Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("Delete from student where username='" + txtUsername.Text + "'", conn);
            conn.Open();
            cd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Deletion Successful!", "Student Dialoge", MessageBoxButtons.OK);
            //refresh the grid
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from student", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
