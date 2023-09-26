namespace CimpoundInterest
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.principleBox1 = new System.Windows.Forms.TextBox();
            this.timeBox1 = new System.Windows.Forms.TextBox();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.ratebox1 = new System.Windows.Forms.NumericUpDown();
            this.Answer1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Principle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 190);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7);
            this.label2.Size = new System.Drawing.Size(179, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time (Years)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(65, 129);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(134, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rate (%)";
            // 
            // principleBox1
            // 
            this.principleBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.principleBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principleBox1.Location = new System.Drawing.Point(340, 75);
            this.principleBox1.Name = "principleBox1";
            this.principleBox1.Size = new System.Drawing.Size(217, 40);
            this.principleBox1.TabIndex = 3;
            this.principleBox1.Text = "10000";
            this.principleBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timeBox1
            // 
            this.timeBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox1.Location = new System.Drawing.Point(340, 196);
            this.timeBox1.Name = "timeBox1";
            this.timeBox1.Size = new System.Drawing.Size(217, 40);
            this.timeBox1.TabIndex = 5;
            this.timeBox1.Text = "1";
            // 
            // Calculate1
            // 
            this.Calculate1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate1.Location = new System.Drawing.Point(71, 279);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(137, 46);
            this.Calculate1.TabIndex = 6;
            this.Calculate1.Text = "Calculate";
            this.Calculate1.UseVisualStyleBackColor = true;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // ratebox1
            // 
            this.ratebox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratebox1.Location = new System.Drawing.Point(340, 137);
            this.ratebox1.Name = "ratebox1";
            this.ratebox1.Size = new System.Drawing.Size(217, 40);
            this.ratebox1.TabIndex = 7;
            this.ratebox1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.Location = new System.Drawing.Point(347, 279);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(0, 33);
            this.Answer1.TabIndex = 8;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(71, 344);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(137, 46);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 497);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.ratebox1);
            this.Controls.Add(this.Calculate1);
            this.Controls.Add(this.timeBox1);
            this.Controls.Add(this.principleBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Simple Interest";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox principleBox1;
        private System.Windows.Forms.TextBox timeBox1;
        private System.Windows.Forms.Button Calculate1;
        private System.Windows.Forms.NumericUpDown ratebox1;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Button resetBtn;
    }
}