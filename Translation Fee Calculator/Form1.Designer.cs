namespace Translation_Fee_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.disBox = new System.Windows.Forms.TextBox();
            this.disFromBox = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.calBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.everyBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profitLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.profitLblMyr = new System.Windows.Forms.Label();
            this.rmLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Translation Fee Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate per Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Page Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Amount";
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(239, 59);
            this.rateBox.Margin = new System.Windows.Forms.Padding(4);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(52, 22);
            this.rateBox.TabIndex = 6;
            this.rateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_click);
            // 
            // pageBox
            // 
            this.pageBox.Location = new System.Drawing.Point(239, 94);
            this.pageBox.Margin = new System.Windows.Forms.Padding(4);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(52, 22);
            this.pageBox.TabIndex = 7;
            this.pageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_click);
            // 
            // disBox
            // 
            this.disBox.Location = new System.Drawing.Point(239, 128);
            this.disBox.Margin = new System.Windows.Forms.Padding(4);
            this.disBox.Name = "disBox";
            this.disBox.Size = new System.Drawing.Size(52, 22);
            this.disBox.TabIndex = 8;
            this.disBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_click);
            // 
            // disFromBox
            // 
            this.disFromBox.Location = new System.Drawing.Point(239, 162);
            this.disFromBox.Margin = new System.Windows.Forms.Padding(4);
            this.disFromBox.Name = "disFromBox";
            this.disFromBox.Size = new System.Drawing.Size(52, 22);
            this.disFromBox.TabIndex = 9;
            this.disFromBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(244, 247);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalLbl.Size = new System.Drawing.Size(24, 27);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "0";
            // 
            // calBtn
            // 
            this.calBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calBtn.Location = new System.Drawing.Point(57, 410);
            this.calBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(219, 60);
            this.calBtn.TabIndex = 11;
            this.calBtn.Text = "Calculate";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "$";
            // 
            // everyBox
            // 
            this.everyBox.Location = new System.Drawing.Point(239, 197);
            this.everyBox.Margin = new System.Windows.Forms.Padding(4);
            this.everyBox.Name = "everyBox";
            this.everyBox.Size = new System.Drawing.Size(52, 22);
            this.everyBox.TabIndex = 13;
            this.everyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Discount Every";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Profit (USD)";
            // 
            // profitLbl
            // 
            this.profitLbl.AutoSize = true;
            this.profitLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLbl.Location = new System.Drawing.Point(244, 280);
            this.profitLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profitLbl.Name = "profitLbl";
            this.profitLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profitLbl.Size = new System.Drawing.Size(24, 27);
            this.profitLbl.TabIndex = 17;
            this.profitLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 346);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Duration";
            // 
            // durationLbl
            // 
            this.durationLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(160, 346);
            this.durationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.durationLbl.Size = new System.Drawing.Size(85, 26);
            this.durationLbl.TabIndex = 20;
            this.durationLbl.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(244, 346);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(61, 27);
            this.label13.TabIndex = 21;
            this.label13.Text = "Days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 313);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Profit (MYR)";
            // 
            // profitLblMyr
            // 
            this.profitLblMyr.AutoSize = true;
            this.profitLblMyr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLblMyr.Location = new System.Drawing.Point(244, 313);
            this.profitLblMyr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profitLblMyr.Name = "profitLblMyr";
            this.profitLblMyr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profitLblMyr.Size = new System.Drawing.Size(24, 27);
            this.profitLblMyr.TabIndex = 23;
            this.profitLblMyr.Text = "0";
            // 
            // rmLbl
            // 
            this.rmLbl.AutoSize = true;
            this.rmLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLbl.Location = new System.Drawing.Point(196, 313);
            this.rmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rmLbl.Name = "rmLbl";
            this.rmLbl.Size = new System.Drawing.Size(49, 27);
            this.rmLbl.TabIndex = 24;
            this.rmLbl.Text = "RM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 506);
            this.Controls.Add(this.rmLbl);
            this.Controls.Add(this.profitLblMyr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.profitLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.everyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.disFromBox);
            this.Controls.Add(this.disBox);
            this.Controls.Add(this.pageBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.TextBox disBox;
        private System.Windows.Forms.TextBox disFromBox;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox everyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label profitLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label profitLblMyr;
        private System.Windows.Forms.Label rmLbl;
    }
}

