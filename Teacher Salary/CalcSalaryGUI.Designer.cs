
namespace Teacher_Salary
{
    partial class CalcSalaryGUI
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
            this.startSalaryBox = new System.Windows.Forms.TextBox();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.yearsWorkedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryOutput = new System.Windows.Forms.Label();
            this.salaryButton = new System.Windows.Forms.Button();
            this.NewCalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startSalaryBox
            // 
            this.startSalaryBox.Location = new System.Drawing.Point(232, 49);
            this.startSalaryBox.Name = "startSalaryBox";
            this.startSalaryBox.Size = new System.Drawing.Size(100, 20);
            this.startSalaryBox.TabIndex = 0;
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(232, 101);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(100, 20);
            this.rateBox.TabIndex = 1;
            // 
            // yearsWorkedBox
            // 
            this.yearsWorkedBox.Location = new System.Drawing.Point(232, 155);
            this.yearsWorkedBox.Name = "yearsWorkedBox";
            this.yearsWorkedBox.Size = new System.Drawing.Size(100, 20);
            this.yearsWorkedBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raise Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years Employed";
            // 
            // SalaryOutput
            // 
            this.SalaryOutput.AutoSize = true;
            this.SalaryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryOutput.Location = new System.Drawing.Point(67, 9);
            this.SalaryOutput.Name = "SalaryOutput";
            this.SalaryOutput.Size = new System.Drawing.Size(51, 17);
            this.SalaryOutput.TabIndex = 6;
            this.SalaryOutput.Text = "Output";
            this.SalaryOutput.Visible = false;
            // 
            // salaryButton
            // 
            this.salaryButton.Location = new System.Drawing.Point(257, 384);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(75, 23);
            this.salaryButton.TabIndex = 7;
            this.salaryButton.Text = "Calculate Salary";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // NewCalculateButton
            // 
            this.NewCalculateButton.Location = new System.Drawing.Point(257, 415);
            this.NewCalculateButton.Name = "NewCalculateButton";
            this.NewCalculateButton.Size = new System.Drawing.Size(131, 23);
            this.NewCalculateButton.TabIndex = 8;
            this.NewCalculateButton.Text = "Calculate New Salary";
            this.NewCalculateButton.UseVisualStyleBackColor = true;
            this.NewCalculateButton.Visible = false;
            this.NewCalculateButton.Click += new System.EventHandler(this.NewCalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.NewCalculateButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.SalaryOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearsWorkedBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.startSalaryBox);
            this.Name = "Form1";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startSalaryBox;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox yearsWorkedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SalaryOutput;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button NewCalculateButton;
    }
}

