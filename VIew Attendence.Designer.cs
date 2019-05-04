namespace WindowsFormsApp1
{
    partial class VIew_Attendence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentAttendanceTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.StudentAttendanceTableAdapter();
            this.studentAttendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn,
            this.Column2,
            this.Column1});
            this.dataGridView1.DataSource = this.studentAttendanceBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 351);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 39);
            this.label2.TabIndex = 44;
            this.label2.Text = "View Attendence";
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // studentAttendanceBindingSource1
            // 
            this.studentAttendanceBindingSource1.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource1.DataSource = this.projectBDataSet1;
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // VIew_Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Name = "VIew_Attendence";
            this.Text = "VIew_Attendence";
            this.Load += new System.EventHandler(this.VIew_Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private ProjectBDataSet1TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource1;
    }
}