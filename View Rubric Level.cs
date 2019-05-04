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
    public partial class View_Rubric_Level : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        public View_Rubric_Level()
        {
            InitializeComponent();
        }

        private void View_Rubric_Level_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet1.RubricLevel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Rubric_Level a = new Add_Rubric_Level();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                dash.rubLvlId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Add_Rubric_Level addRubricLevel = new Add_Rubric_Level();
                addRubricLevel.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int rublvlId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM RubricLevel WHERE Id  = '" + rublvlId + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.rubricLevelTableAdapter.Fill(this.projectBDataSet1.RubricLevel);
                }
            }
        }
    }
}
