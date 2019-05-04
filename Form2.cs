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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void lblStudentManagement_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 u = new Form1();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE Student SET FirstName = '" + txtFirst.Text.ToString() + "',LastName = '" + txtLast.Text.ToString() + "',Contact = '" + txtContact.Text.ToString() + "',Email = '" + txtEmail.Text.ToString() + "',RegistrationNumber = '" + txtRegister.Text.ToString() + "' WHERE Id = " + dash.stdId;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Student edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO Student (FirstName,LastName,Email,Contact,RegistrationNumber,Status) VALUES ('" + txtFirst.Text.ToString() + "','" + txtLast.Text.ToString() + "','" + txtContact.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtRegister.Text.ToString() + "',5)";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Student registered");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 y = new Form3();
            y.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (dash.stdId != -1)
            {
                button1.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from Student WHERE Id=" + dash.stdId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtFirst.Text = read["FirstName"].ToString();
                    txtLast.Text = read["LastName"].ToString();
                    txtEmail.Text = read["Email"].ToString();
                    txtContact.Text = read["Contact"].ToString();
                    txtRegister.Text = read["RegistrationNumber"].ToString();
                }
                connect.Close();
            }

        }
    }
}