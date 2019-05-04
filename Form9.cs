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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dash.rubId != -1)
            {
                int clo_id = 0;
                SqlConnection connection = new SqlConnection(cnn);
                connection.Open();

                String q = "Select Id from Clo where Name='" + comboBox1.Text + "'";
                SqlCommand sl = new SqlCommand(q, connection);
                SqlDataReader da = sl.ExecuteReader();
                while (da.Read())
                {
                    clo_id = Convert.ToInt32(da["Id"]);
                }
                connection.Close();
                connection.Open();
                string Query = "Update Rubric Set CloId=@Name,Details=@Detail where Id='"+dash.rubId+"'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Name", clo_id);
                command.Parameters.AddWithValue("@Detail", richTextBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added!");
            }
            else
            {
                int clo_id = 0;
                SqlConnection connection = new SqlConnection(cnn);
                connection.Open();

                String q = "Select Id from Clo where Name='" + comboBox1.Text + "'";
                SqlCommand sl = new SqlCommand(q, connection);
                SqlDataReader da = sl.ExecuteReader();
                while (da.Read())
                {
                    clo_id = Convert.ToInt32(da["Id"]);
                }
                connection.Close();
                connection.Open();
                string Query = "Insert into Rubric(CloId,Details) Values(@Name,@Detail)";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Name", clo_id);
                command.Parameters.AddWithValue("@Detail", richTextBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added!");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 z = new Form5();
            z.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            if (dash.rubId != -1)
            {
                button1.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from Rubric WHERE Id=" + dash.rubId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {

                    richTextBox1.Text = read["Details"].ToString();
                    
                    

                }
                connect.Close();
            }

        }
    }
}
