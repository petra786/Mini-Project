using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Evaluate_Student : Form
    {
        public Evaluate_Student()
        {
            InitializeComponent();
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
            View__Result u = new View__Result();
            u.Show();
        }

        private void Evaluate_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet1.StudentResult);
            // TODO: This line of code loads data into the 'projectBDataSet1.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet1.AssessmentComponent);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
