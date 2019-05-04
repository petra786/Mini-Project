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
    public partial class View_Assesment_Components : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public View_Assesment_Components()
        {
            InitializeComponent();
        }

        private void View_Assesment_Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet1.AssessmentComponent);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Assesment_Compomnent u = new Add_Assesment_Compomnent();
            u.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.assesCompId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Add_Assesment_Compomnent addAssesmentComponent = new Add_Assesment_Compomnent();
                addAssesmentComponent.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int assesCompID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM AssessmentComponent WHERE Id  = '" + assesCompID + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.assessmentComponentTableAdapter.Fill(this.projectBDataSet1.AssessmentComponent);
                }
            }
        }
    }
}
