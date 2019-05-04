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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 w = new Form7();
            w.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.cloId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Form7 clo = new Form7();
                clo.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int cloId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [AssessmentComponent] WHERE  RubricId  = '" + cloId + "'", connect);
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Rubric WHERE  CloId  = '" + cloId + "'", connect);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    connect.Close();
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Clo WHERE Id  = '" + cloId + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
                }
            }
        }
    } }
