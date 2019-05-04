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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class View__Result : Form
    {
        const string cnn = "Data Source=TOSHIBA;Initial Catalog=ProjectB;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnn);
        public View__Result()
        {
            InitializeComponent();
        }

        private void View__Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet1.StudentResult);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Result a = new Student_Result();
            a.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream("Result.pdf", FileMode.Create));
            doc.Open();
            con.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int stdId = Convert.ToInt32(row.Cells[0].Value);
                int assId = Convert.ToInt32(row.Cells[1].Value);
                int ruId = Convert.ToInt32(row.Cells[2].Value);
                string query = "Select Student.FirstName as StudentName,Student.RegistrationNumber as RegistrationNumber, RubricLevel.RubricId as RubricId," +
                    " RubricLevel.MeasurementLevel as MeasurementLevel, RubricLevel.Details as Details," +
                    " AssessmentComponent.Name as Name, AssessmentComponent.TotalMarks as TotalMarks From Student INNER JOIN StudentResult ON " +
                    "Student.Id=StudentResult.StudentId INNER JOIN RubricLevel On " +
                    "RubricLevel.Id=StudentResult.RubricMeasurementId Inner JOIN " +
                    "AssessmentComponent On StudentResult.AssessmentComponentId =AssessmentComponent.Id" +
                    " Where StudentResult.StudentId ='"+stdId+ "'and StudentResult.RubricMeasurementId ='" + ruId+"'" +
                    "and StudentResult.AssessmentComponentId ='" + assId+"'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                String reg = "", detail = "", comp="",stdname="";
                int rb_Id = 0, ml = 0, total = 0;
                while (reader.Read())
                {
                    stdname = reader["StudentName"].ToString();
                    comp = reader["Name"].ToString();
                    reg = reader["RegistrationNumber"].ToString();
                    detail = reader["Details"].ToString();
                    rb_Id = Convert.ToInt32(reader["RubricId"]);
                    ml = Convert.ToInt32(reader["MeasurementLevel"]);
                    total = Convert.ToInt32(reader["TotalMarks"]);
                }
                reader.Close();
                //adding data to pdf file
                int ab = -1;
                var maxMeasurelevelQuery = "Select MAX(MeasurementLevel) as ml From RubricLevel Where RubricId='" + Convert.ToInt32(rb_Id) + "'";
                SqlCommand q = new SqlCommand(maxMeasurelevelQuery, con);
                SqlDataReader dataReader = q.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if(!(dataReader["ml"] is DBNull))
                            ab = Convert.ToInt32(dataReader["ml"]);
                    }
                }
                 
                
                dataReader.Close();
                Paragraph para = new Paragraph("Name: " + stdname.ToString() + "\n Registration Number: " + reg + "\n\n");
                PdfPTable table = new PdfPTable(5);
                string[] list = { "Component", "Rubric", "Component Marks", "Student Rubric Level", "Obtained Marks" };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(list[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                float obtain = (Convert.ToInt32(ml) / ab) * total;
                string[] data = { comp, detail, total.ToString(), ml.ToString(), obtain.ToString() };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(data[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                doc.Add(para);
                doc.Add(table);
            }
            doc.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int stdResult = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(cnn);
                    connect.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM StudentResult WHERE StudentId  = '" + stdResult + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    this.studentResultTableAdapter.Fill(this.projectBDataSet1.StudentResult);
                }
            }
        }
    }
}
