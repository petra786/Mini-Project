namespace WindowsFormsApp1
{
    partial class Evaluate_Student
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.AssessmentComponentTableAdapter();
            this.studentResultTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.StudentResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentResultBindingSource;
            this.comboBox2.DisplayMember = "AssessmentComponentId";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(366, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "AssessmentComponentId";
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Student Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 54;
            this.button2.Text = "Main Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "View Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 52;
            this.button4.Text = "Generate Result";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Assesment Component";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Rubric Measurement Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 39);
            this.label2.TabIndex = 46;
            this.label2.Text = "Evaluate Student";
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet1;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // Evaluate_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Evaluate_Student";
            this.Text = "Evaluate_Student";
            this.Load += new System.EventHandler(this.Evaluate_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet1TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet1TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
    }
}