namespace WindowsFormsCalculator
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.inptSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.inptFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.inptResult = new System.Windows.Forms.TextBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(+) Zbroji";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(546, 164);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(144, 55);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "(-) Oduzmi";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(546, 235);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(144, 50);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "(*) Pomnozi";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(546, 310);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(144, 53);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "(%) Podijeli";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // inptSecondNumber
            // 
            this.inptSecondNumber.Location = new System.Drawing.Point(214, 199);
            this.inptSecondNumber.Name = "inptSecondNumber";
            this.inptSecondNumber.Size = new System.Drawing.Size(120, 26);
            this.inptSecondNumber.TabIndex = 4;
            this.inptSecondNumber.ValueChanged += new System.EventHandler(this.inptSecondNumber_ValueChanged);
            // 
            // inptFirstNumber
            // 
            this.inptFirstNumber.Location = new System.Drawing.Point(214, 114);
            this.inptFirstNumber.Name = "inptFirstNumber";
            this.inptFirstNumber.Size = new System.Drawing.Size(120, 26);
            this.inptFirstNumber.TabIndex = 5;
            this.inptFirstNumber.ValueChanged += new System.EventHandler(this.inptFirstNumber_ValueChanged);
            // 
            // inptResult
            // 
            this.inptResult.Location = new System.Drawing.Point(214, 292);
            this.inptResult.Name = "inptResult";
            this.inptResult.Size = new System.Drawing.Size(120, 26);
            this.inptResult.TabIndex = 6;
            this.inptResult.TextChanged += new System.EventHandler(this.inptResult_TextChanged);
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(78, 120);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(64, 20);
            this.lblFirstNumber.TabIndex = 7;
            this.lblFirstNumber.Text = "Prvi broj";
            this.lblFirstNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(78, 199);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(77, 20);
            this.lblSecondNumber.TabIndex = 8;
            this.lblSecondNumber.Text = "Drugi broj";
            this.lblSecondNumber.Click += new System.EventHandler(this.lblSecondNumber_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(78, 292);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Rezultat";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 426);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.inptResult);
            this.Controls.Add(this.inptFirstNumber);
            this.Controls.Add(this.inptSecondNumber);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.NumericUpDown inptSecondNumber;
        private System.Windows.Forms.NumericUpDown inptFirstNumber;
        private System.Windows.Forms.TextBox inptResult;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
    }
}

