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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 t = new Form9();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dash.cloId!=-1)
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE Clo SET Name = '" + textBox1.Text.ToString() + "',DateUpdated='" + DateTime.Now + "' WHERE Id = " + dash.cloId;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Clo edited");
            }
            else
            {
                SqlConnection con = new SqlConnection(cnn);
                con.Open();
                string query = "INSERT INTO CLO (Name,DateCreated,DateUpdated) VALUES ('" + textBox1.Text.ToString() + "','" + DateTime.Now + "','" + DateTime.Now + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CLO added");
            }
          
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (dash.cloId != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from Clo WHERE Id=" + dash.cloId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    textBox1.Text = read["Name"].ToString();

                }
                connect.Close();
            }
        }
    }
}