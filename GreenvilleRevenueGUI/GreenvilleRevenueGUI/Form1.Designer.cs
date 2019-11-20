namespace GreenvilleRevenueGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_contestants = new System.Windows.Forms.Button();
            this.txtlastyearsnum = new System.Windows.Forms.TextBox();
            this.txtthisyearnum = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of last year\'s contestants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter number of this year\'s contestants";
            // 
            // btn_contestants
            // 
            this.btn_contestants.Location = new System.Drawing.Point(193, 193);
            this.btn_contestants.Name = "btn_contestants";
            this.btn_contestants.Size = new System.Drawing.Size(75, 42);
            this.btn_contestants.TabIndex = 2;
            this.btn_contestants.Text = "Click to calculate";
            this.btn_contestants.UseVisualStyleBackColor = true;
            this.btn_contestants.Click += new System.EventHandler(this.btn_contestants_Click);
            // 
            // txtlastyearsnum
            // 
            this.txtlastyearsnum.Location = new System.Drawing.Point(301, 92);
            this.txtlastyearsnum.Name = "txtlastyearsnum";
            this.txtlastyearsnum.Size = new System.Drawing.Size(100, 20);
            this.txtlastyearsnum.TabIndex = 3;
            // 
            // txtthisyearnum
            // 
            this.txtthisyearnum.Location = new System.Drawing.Point(301, 132);
            this.txtthisyearnum.Name = "txtthisyearnum";
            this.txtthisyearnum.Size = new System.Drawing.Size(100, 20);
            this.txtthisyearnum.TabIndex = 4;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRevenue.Location = new System.Drawing.Point(130, 277);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(193, 73);
            this.lblTotalRevenue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 425);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.txtthisyearnum);
            this.Controls.Add(this.txtlastyearsnum);
            this.Controls.Add(this.btn_contestants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greenville Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_contestants;
        private System.Windows.Forms.TextBox txtlastyearsnum;
        private System.Windows.Forms.TextBox txtthisyearnum;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}

