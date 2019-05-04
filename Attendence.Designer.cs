namespace WindowsFormsApp1
{
    partial class Attendence
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.studentAttendanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendanceTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.StudentAttendanceTableAdapter();
            this.classAttendanceTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.ClassAttendanceTableAdapter();
            this.studentTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.StudentTableAdapter();
            this.studentAttendanceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookupTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.LookupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 47;
            this.button2.Text = "Main Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 39);
            this.label2.TabIndex = 46;
            this.label2.Text = "Add Attendance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 55;
            this.button1.Text = "View Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(358, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 54;
            this.button4.Text = "Take Attendance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Attendence Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Student Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Attendance Id";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classAttendanceBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "Id";
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentBindingSource;
            this.comboBox2.DisplayMember = "Id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(358, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "Id";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet1;
            // 
            // studentAttendanceBindingSource1
            // 
            this.studentAttendanceBindingSource1.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource1.DataSource = this.projectBDataSet1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.lookupBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(358, 194);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 58;
            this.comboBox3.ValueMember = "LookupId";
            // 
            // studentAttendanceBindingSource2
            // 
            this.studentAttendanceBindingSource2.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource2.DataSource = this.projectBDataSet1;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentAttendanceBindingSource3
            // 
            this.studentAttendanceBindingSource3.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource3.DataSource = this.projectBDataSet1;
            // 
            // classAttendanceBindingSource1
            // 
            this.classAttendanceBindingSource1.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource1.DataSource = this.projectBDataSet1;
            // 
            // classAttendanceBindingSource2
            // 
            this.classAttendanceBindingSource2.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource2.DataSource = this.projectBDataSet1;
            // 
            // lookupBindingSource
            // 
            this.lookupBindingSource.DataMember = "Lookup";
            this.lookupBindingSource.DataSource = this.projectBDataSet1;
            // 
            // lookupTableAdapter
            // 
            this.lookupTableAdapter.ClearBeforeFill = true;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Name = "Attendence";
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet1TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource1;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource2;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet1TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource3;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource1;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource2;
        private System.Windows.Forms.BindingSource lookupBindingSource;
        private ProjectBDataSet1TableAdapters.LookupTableAdapter lookupTableAdapter;
    }
}