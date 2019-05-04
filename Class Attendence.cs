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
    public partial class Class_Attendence : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Class_Attendence()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE ClassAttendance SET AttendanceDate = '" + dateTimePicker1.Value.Date+ "' WHERE Id = " + dash.classAttendence;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Attendance edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO ClassAttendance (AttendanceDate) VALUES ('" + dateTimePicker1.Value.Date + "')";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Attendance Added");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Class_Attendence a = new View_Class_Attendence();
            a.Show();
        }

        private void Class_Attendence_Load(object sender, EventArgs e)
        {
            if (dash.classAttendence != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from ClassAttendance WHERE Id=" + dash.classAttendence;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    dateTimePicker1.Value = Convert.ToDateTime(read["AttendanceDate"]);
                }
                connect.Close();
            }
        }
    }
}
