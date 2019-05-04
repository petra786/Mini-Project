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
    public partial class Form3 : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet1.Student);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.stdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Form2 registerStudent = new Form2();
                registerStudent.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int stId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM StudentResult WHERE StudentId  = '" + stId + "'", connect);
                    SqlCommand command1 = new SqlCommand("DELETE FROM StudentAttendance WHERE StudentId  = '" + stId + "'", connect);
                    SqlCommand command2 = new SqlCommand("DELETE FROM Student WHERE Id  = '" + stId + "'", connect);
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    this.studentTableAdapter.Fill(this.projectBDataSet1.Student);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 v = new Form2();
            v.Show();
        }
    }
}
