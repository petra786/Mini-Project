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
    public partial class Add_Assesment_Compomnent : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Add_Assesment_Compomnent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            View_Assesment_Components u = new View_Assesment_Components();
            u.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE AssessmentComponent SET Name = '" + textBox2.Text.ToString() + "',RubricId = '" + Convert.ToInt32(comboBox1.SelectedValue) + "',TotalMarks = '" + Convert.ToInt32(textBox1.Text) + "',DateCreated='"+ DateTime.Now+ "',Dateupdated='" + DateTime.Now + "',AssessmentId='"+ comboBox2.SelectedValue+ "' WHERE Id = " + dash.assesCompId;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Assesment Component edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO AssessmentComponent (Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES ('" + textBox2.Text.ToString() + "','" + Convert.ToInt32(comboBox1.SelectedValue) + "','" + Convert.ToInt32(textBox1.Text)+ "' , '"+ DateTime.Now + "' , '" + DateTime.Now + "' , '" + comboBox2.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Assessment Component Added");
            }
        }

        private void Add_Assesment_Compomnent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
            this.assessmentTableAdapter.Fill(this.projectBDataSet1.Assessment);
            if (dash.assesCompId != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from AssessmentComponent WHERE Id=" + dash.assesCompId;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    textBox2.Text = read["Name"].ToString();
                    comboBox1.SelectedValue = read["RubricId"].ToString();
                    textBox1.Text = read["TotalMarks"].ToString();
                    comboBox2.SelectedValue = read["AssessmentId"].ToString();
                }
                connect.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
