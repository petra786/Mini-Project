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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 h = new Form2();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 p = new Form7();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 q = new Form9();
            q.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Attendence a = new Class_Attendence();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Assesment b = new Add_Assesment();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Assesment_Compomnent c = new Add_Assesment_Compomnent();
            c.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Attendence c = new Attendence();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 a = new Form9();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Result a = new Student_Result();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rubric_Level a = new Add_Rubric_Level();
            a.Show();
        }
    }
}
