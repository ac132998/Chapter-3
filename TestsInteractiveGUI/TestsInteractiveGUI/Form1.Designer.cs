namespace TestsInteractiveGUI
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
            this.btn_claculateaverage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest4 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest5 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.lblTestAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_claculateaverage
            // 
            this.btn_claculateaverage.Location = new System.Drawing.Point(145, 245);
            this.btn_claculateaverage.Name = "btn_claculateaverage";
            this.btn_claculateaverage.Size = new System.Drawing.Size(110, 23);
            this.btn_claculateaverage.TabIndex = 0;
            this.btn_claculateaverage.Text = "Click for Average";
            this.btn_claculateaverage.UseVisualStyleBackColor = true;
            this.btn_claculateaverage.Click += new System.EventHandler(this.btn_claculateaverage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter 5 test scores ";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(54, 101);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 20);
            this.txtTest1.TabIndex = 2;
            // 
            // txtTest4
            // 
            this.txtTest4.Location = new System.Drawing.Point(261, 101);
            this.txtTest4.Name = "txtTest4";
            this.txtTest4.Size = new System.Drawing.Size(100, 20);
            this.txtTest4.TabIndex = 3;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(54, 139);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 4;
            // 
            // txtTest5
            // 
            this.txtTest5.Location = new System.Drawing.Point(261, 139);
            this.txtTest5.Name = "txtTest5";
            this.txtTest5.Size = new System.Drawing.Size(100, 20);
            this.txtTest5.TabIndex = 5;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(54, 181);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 20);
            this.txtTest3.TabIndex = 6;
            // 
            // lblTestAverage
            // 
            this.lblTestAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTestAverage.Location = new System.Drawing.Point(93, 310);
            this.lblTestAverage.Name = "lblTestAverage";
            this.lblTestAverage.Size = new System.Drawing.Size(219, 23);
            this.lblTestAverage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 451);
            this.Controls.Add(this.lblTestAverage);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest5);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest4);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_claculateaverage);
            this.Name = "Form1";
            this.Text = "Tests Interactive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_claculateaverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest4;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest5;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Label lblTestAverage;
    }
}

