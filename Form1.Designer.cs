namespace APPR___random___22SD___JaydenKlomp
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
            this.lblRandomValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.txbMinValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRandomValue
            // 
            this.lblRandomValue.AutoSize = true;
            this.lblRandomValue.Location = new System.Drawing.Point(134, 98);
            this.lblRandomValue.Name = "lblRandomValue";
            this.lblRandomValue.Size = new System.Drawing.Size(19, 16);
            this.lblRandomValue.TabIndex = 9;
            this.lblRandomValue.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Random value:";
            // 
            // txbMaxValue
            // 
            this.txbMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaxValue.Location = new System.Drawing.Point(96, 23);
            this.txbMaxValue.Name = "txbMaxValue";
            this.txbMaxValue.Size = new System.Drawing.Size(68, 27);
            this.txbMaxValue.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max value:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRandomize.Location = new System.Drawing.Point(170, 12);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(150, 50);
            this.btnRandomize.TabIndex = 5;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // txbMinValue
            // 
            this.txbMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinValue.Location = new System.Drawing.Point(96, 56);
            this.txbMinValue.Name = "txbMinValue";
            this.txbMinValue.Size = new System.Drawing.Size(68, 27);
            this.txbMinValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 123);
            this.Controls.Add(this.txbMinValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRandomValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMaxValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandomValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.TextBox txbMinValue;
        private System.Windows.Forms.Label label3;
    }
}

