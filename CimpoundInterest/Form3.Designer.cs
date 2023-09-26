namespace CimpoundInterest
{
    partial class Form3
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
            this.resetBtn2 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Label();
            this.ratebox2 = new System.Windows.Forms.NumericUpDown();
            this.Calculate2 = new System.Windows.Forms.Button();
            this.timeBox2 = new System.Windows.Forms.TextBox();
            this.principleBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueOfN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ratebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueOfN)).BeginInit();
            this.SuspendLayout();
            // 
            // resetBtn2
            // 
            this.resetBtn2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn2.Location = new System.Drawing.Point(100, 376);
            this.resetBtn2.Name = "resetBtn2";
            this.resetBtn2.Size = new System.Drawing.Size(137, 46);
            this.resetBtn2.TabIndex = 18;
            this.resetBtn2.Text = "Reset";
            this.resetBtn2.UseVisualStyleBackColor = true;
            this.resetBtn2.Click += new System.EventHandler(this.resetBtn2_Click);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.Location = new System.Drawing.Point(376, 311);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(0, 33);
            this.Answer2.TabIndex = 17;
            // 
            // ratebox2
            // 
            this.ratebox2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratebox2.Location = new System.Drawing.Point(369, 129);
            this.ratebox2.Name = "ratebox2";
            this.ratebox2.Size = new System.Drawing.Size(217, 40);
            this.ratebox2.TabIndex = 16;
            this.ratebox2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratebox2.ValueChanged += new System.EventHandler(this.ratebox1_ValueChanged);
            // 
            // Calculate2
            // 
            this.Calculate2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate2.Location = new System.Drawing.Point(100, 311);
            this.Calculate2.Name = "Calculate2";
            this.Calculate2.Size = new System.Drawing.Size(137, 46);
            this.Calculate2.TabIndex = 15;
            this.Calculate2.Text = "Calculate";
            this.Calculate2.UseVisualStyleBackColor = true;
            this.Calculate2.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // timeBox2
            // 
            this.timeBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox2.Location = new System.Drawing.Point(369, 188);
            this.timeBox2.Name = "timeBox2";
            this.timeBox2.Size = new System.Drawing.Size(217, 40);
            this.timeBox2.TabIndex = 14;
            this.timeBox2.Text = "1";
            // 
            // principleBox2
            // 
            this.principleBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.principleBox2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principleBox2.Location = new System.Drawing.Point(369, 67);
            this.principleBox2.Name = "principleBox2";
            this.principleBox2.Size = new System.Drawing.Size(217, 40);
            this.principleBox2.TabIndex = 13;
            this.principleBox2.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 121);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(134, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rate (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7);
            this.label2.Size = new System.Drawing.Size(179, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time (Years)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 61);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Principle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 243);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7);
            this.label3.Size = new System.Drawing.Size(160, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Value Of N";
            // 
            // valueOfN
            // 
            this.valueOfN.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueOfN.Location = new System.Drawing.Point(369, 249);
            this.valueOfN.Name = "valueOfN";
            this.valueOfN.Size = new System.Drawing.Size(217, 40);
            this.valueOfN.TabIndex = 20;
            this.valueOfN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 445);
            this.Controls.Add(this.valueOfN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetBtn2);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.ratebox2);
            this.Controls.Add(this.Calculate2);
            this.Controls.Add(this.timeBox2);
            this.Controls.Add(this.principleBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueOfN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetBtn2;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.NumericUpDown ratebox2;
        private System.Windows.Forms.Button Calculate2;
        private System.Windows.Forms.TextBox timeBox2;
        private System.Windows.Forms.TextBox principleBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown valueOfN;
    }
}