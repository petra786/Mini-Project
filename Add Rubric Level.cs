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
    public partial class Add_Rubric_Level : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Add_Rubric_Level()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
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
            this.Hide();
            View_Rubric_Level u = new View_Rubric_Level();
            u.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE RubricLevel SET RubricId = '" + comboBox1.SelectedValue + "',Details = '" + richTextBox1.Text.ToString() + "',MeasurementLevel = '" + Convert.ToInt32(textBox1.Text) + "' WHERE Id = " + dash.rubLvlId;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Rubric Level edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO RubricLevel (RubricId,Details,MeasurementLevel) VALUES ('" + comboBox1.SelectedValue + "','" + richTextBox1.Text.ToString() + "','" + Convert.ToInt32(textBox1.Text) + "')";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Rubric Level Added");
            }
        }

        private void Add_Rubric_Level_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
            if (dash.rubLvlId != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from RubricLevel WHERE Id=" + dash.rubLvlId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Text = read["RubricId"].ToString();
                    richTextBox1.Text = read["Details"].ToString();
                    textBox1.Text = read["MeasurementLevel"].ToString();
                }
                connect.Close();
            }
        }
    }
}
