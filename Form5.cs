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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 b = new Form9();
            b.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.rubId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Form9 rubric = new Form9();
                rubric.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int clId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Rubric WHERE Id  = '" + clId + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
                }
            }
        }
    }
}
