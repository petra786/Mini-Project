namespace WindowsFormsApp1
{
    partial class View_Rubric_Level
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.rubricLevelTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.RubricLevelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.measurementLevelDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.rubricLevelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 351);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rubric Level";
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // View_Rubric_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "View_Rubric_Level";
            this.Text = "View_Rubric_Level";
            this.Load += new System.EventHandler(this.View_Rubric_Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSet1TableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}