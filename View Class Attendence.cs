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
    public partial class View_Class_Attendence : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public View_Class_Attendence()
        {
            InitializeComponent();
        }

        private void View_Class_Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet1.ClassAttendance);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Attendence a = new Class_Attendence();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.classAttendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Class_Attendence addAttendence = new Class_Attendence();
                addAttendence.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int ClassAttendence = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [StudentAttendance] WHERE AttendanceId  = '" + ClassAttendence + "'", connect);
                    SqlCommand command1 = new SqlCommand("DELETE FROM ClassAttendance WHERE Id  = '" + ClassAttendence + "'", connect);
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    connect.Close();
                    this.classAttendanceTableAdapter.Fill(this.projectBDataSet1.ClassAttendance);
                }
            }
        }
    }
}
