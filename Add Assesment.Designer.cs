namespace WindowsFormsApp1
{
    partial class Add_Assesment
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
            this.txtWeightage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTmarks = new System.Windows.Forms.TextBox();
            this.txtAssesment = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWeightage
            // 
            this.txtWeightage.Location = new System.Drawing.Point(355, 199);
            this.txtWeightage.Name = "txtWeightage";
            this.txtWeightage.Size = new System.Drawing.Size(121, 20);
            this.txtWeightage.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Weightage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Assesment Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add Assesment";
            // 
            // txtTmarks
            // 
            this.txtTmarks.Location = new System.Drawing.Point(355, 164);
            this.txtTmarks.Name = "txtTmarks";
            this.txtTmarks.Size = new System.Drawing.Size(121, 20);
            this.txtTmarks.TabIndex = 18;
            // 
            // txtAssesment
            // 
            this.txtAssesment.Location = new System.Drawing.Point(355, 136);
            this.txtAssesment.Name = "txtAssesment";
            this.txtAssesment.Size = new System.Drawing.Size(121, 20);
            this.txtAssesment.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(358, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Add Assesment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "View Assesment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 32;
            this.button2.Text = "Main Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_Assesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtAssesment);
            this.Controls.Add(this.txtTmarks);
            this.Controls.Add(this.txtWeightage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Add_Assesment";
            this.Text = "Add_Assesment";
            this.Load += new System.EventHandler(this.Add_Assesment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtWeightage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTmarks;
        private System.Windows.Forms.TextBox txtAssesment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}