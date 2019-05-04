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
    public partial class Student_Result : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Student_Result()
        {
            InitializeComponent();
        }

        private void Student_Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Assessment' table. You can move, or remove it, as needed.
         //   this.assessmentTableAdapter.Fill(this.projectBDataSet1.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet1.Student);
            // TODO: This line of code loads data into the 'projectBDataSet1.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet1.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet1.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet1.RubricLevel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View__Result a = new View__Result();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(cnn);
            connect.Open();
            string q = "INSERT INTO StudentResult (StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) VALUES ('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + comboBox3.SelectedValue + "','" + dateTimePicker1.Value.Date + "')";
            SqlCommand cmd = new SqlCommand(q, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("result Added");
        }
    }
}
