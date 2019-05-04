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
    public partial class Attendence : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Lookup' table. You can move, or remove it, as needed.
            this.lookupTableAdapter.Fill(this.projectBDataSet1.Lookup);
            // TODO: This line of code loads data into the 'projectBDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet1.Student);
            // TODO: This line of code loads data into the 'projectBDataSet1.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet1.ClassAttendance);
            // TODO: This line of code loads data into the 'projectBDataSet1.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet1.StudentAttendance);
            // TODO: This line of code loads data into the 'projectBDataSet1.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet1.StudentAttendance);
            if (dash.stdAttendence != -1)
            {
                button4.Text = "Edit";
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string query = "Select * from StudentAttendance WHERE AttendanceId='"+dash.classAttendence+"' AND StudentId=" + dash.stdAttendence;
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.SelectedValue= read["AttendanceId"].ToString();
                    comboBox1.SelectedValue = read["StudentId"].ToString();
                    comboBox1.SelectedValue = read["AttendanceStatus"].ToString();
                }
                connect.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Edit")
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "UPDATE StudentAttendance SET AttendanceId = '" + comboBox1.SelectedValue + "',StudentId = '" + comboBox2.SelectedValue + "',AttendanceStatus = '" + comboBox3.SelectedValue + "' WHERE AttendanceId='"+dash.classAttendence+"' AND StudentId = " + dash.stdAttendence;
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Attendance edited");
            }
            else
            {
                SqlConnection connect = new SqlConnection(cnn);
                connect.Open();
                string q = "INSERT INTO StudentAttendance (AttendanceId,StudentId,AttendanceStatus) VALUES ('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + comboBox3.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(q, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Attendance Added");
            }
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
            VIew_Attendence a = new VIew_Attendence();
            a.Show();
        }
    }
}
