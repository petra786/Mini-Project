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
    public partial class VIew_Attendence : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public VIew_Attendence()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.classAttendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dash.stdAttendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                this.Hide();
                Attendence addAttendence = new Attendence();
                addAttendence.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int Attendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                int StudentAttendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM StudentAttendance WHERE AttendanceId='"+Attendence+"' AND StudentId  = '" + StudentAttendence + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.studentAttendanceTableAdapter.Fill(this.projectBDataSet1.StudentAttendance);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence a=new Attendence();
            a.Show();
        }

        private void VIew_Attendence_Load(object sender, EventArgs e)
        {
            this.studentAttendanceTableAdapter.Fill(projectBDataSet1.StudentAttendance);
        }
    }
}
