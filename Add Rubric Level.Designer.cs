namespace WindowsFormsApp1
{
    partial class Add_Rubric_Level
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.projectBDataSet1 = new WindowsFormsApp1.ProjectBDataSet1();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSet1TableAdapters.RubricTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rubricBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Rubric Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 64;
            this.button2.Text = "Main Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 63;
            this.button1.Text = "View Rubric Level";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 62;
            this.button4.Text = "Add Rubric Level";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Rubric Level Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 213);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Measurement Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 39);
            this.label2.TabIndex = 58;
            this.label2.Text = "Add Rubric Level";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(351, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(121, 59);
            this.richTextBox1.TabIndex = 67;
            this.richTextBox1.Text = "";
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet1;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Rubric_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Add_Rubric_Level";
            this.Text = "Add_Rubric_Level";
            this.Load += new System.EventHandler(this.Add_Rubric_Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet1TableAdapters.RubricTableAdapter rubricTableAdapter;
    }
}