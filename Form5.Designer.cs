namespace WindowsFormsApp1
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.projectBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.RubricTableAdapter();
            this.iD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rubric";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD,
            this.cloIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 351);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projectBDataSet1BindingSource
            // 
            this.projectBDataSet1BindingSource.DataSource = this.projectBDataSet1;
            this.projectBDataSet1BindingSource.Position = 0;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // iD
            // 
            this.iD.DataPropertyName = "Id";
            this.iD.HeaderText = "Id";
            this.iD.Name = "iD";
            this.iD.Visible = false;
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource projectBDataSet1BindingSource;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet1TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}