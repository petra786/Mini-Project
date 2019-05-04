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
    public partial class View_Assesments : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public View_Assesments()
        {
            InitializeComponent();
        }

        private void View_Assesments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet1.Assessment);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Assesment a = new Add_Assesment();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.assesmentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Add_Assesment addAssesment = new Add_Assesment();
                addAssesment.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                List<int> selectedAssementCompId = new List<int>();
                List<int> studentResultId = new List<int>();
                int assesmentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand selectAssementComp = new SqlCommand("select * FROM AssessmentComponent WHERE AssessmentId = '" + assesmentId + "'", connect);
                    SqlDataReader reader = selectAssementComp.ExecuteReader();
                    while (reader.Read())
                    {
                        selectedAssementCompId.Add((int)reader[0]);
                    }
                    reader.Close();
                    foreach(var assementcompid in selectedAssementCompId)
                    {
                        SqlCommand selectStudentResultComp = new SqlCommand("select * FROM StudentResult WHERE AssessmentComponentId = '" + assementcompid + "'", connect);
                        SqlDataReader studentresultreader = selectStudentResultComp.ExecuteReader();
                        while (studentresultreader.Read())
                        {
                            studentResultId.Add((int)studentresultreader[0]);
                        }
                        studentresultreader.Close();
                    }
                    foreach (var sudentresid in studentResultId)
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM StudentResult WHERE StudentId = '" + sudentresid + "'", connect);
                        command.ExecuteNonQuery();
                    }
                    foreach (var assementcompid in selectedAssementCompId)
                    {
                        SqlCommand command1 = new SqlCommand("DELETE FROM AssessmentComponent WHERE AssessmentId = '" + assesmentId + "'", connect);
                        command1.ExecuteNonQuery();
                    }
                    //SqlCommand command = new SqlCommand("DELETE FROM StudentResult WHERE AssessmentComponentId = '" + assesmentId + "'", connect);
                    //SqlCommand command1 = new SqlCommand("DELETE FROM AssessmentComponent WHERE AssessmentId = '" + assesmentId + "'", connect);
                    SqlCommand command2 = new SqlCommand("DELETE FROM Assessment WHERE Id = '" + assesmentId + "'", connect);
                    //command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connect.Close();
                    this.assessmentTableAdapter.Fill(this.projectBDataSet1.Assessment);
                }
            }
        }
    }
}
