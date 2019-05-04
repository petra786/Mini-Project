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
    public partial class Add_Assesment : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Add_Assesment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE Assessment SET Title = '" + txtAssesment.Text.ToString() + "',TotalMarks = '" + txtTmarks.Text.ToString() + "',TotalWeightage = '" + txtWeightage.Text.ToString() + "' WHERE Id = " + dash.assesmentId;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Assesment edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO Assessment (Title,DateCreated,TotalMarks,TotalWeightage) VALUES ('" + txtAssesment.Text.ToString() + "','"+DateTime.Now+"','" + Convert.ToInt32(txtTmarks.Text) + "','" + Convert.ToInt32(txtWeightage.Text) + "')";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Assesment Added");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 u = new Form1();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Assesments u = new View_Assesments();
            u.Show();
        }

        private void Add_Assesment_Load(object sender, EventArgs e)
        {
            if (dash.assesmentId != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from Assessment WHERE Id=" + dash.assesmentId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtAssesment.Text = read["Title"].ToString();
                    txtTmarks.Text = read["TotalMarks"].ToString();
                    txtWeightage.Text = read["TotalWeightage"].ToString();
                }
                connect.Close();
            }
        }
    }
}
