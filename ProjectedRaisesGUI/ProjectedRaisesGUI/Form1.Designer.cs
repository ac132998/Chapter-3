namespace ProjectedRaisesGUI
{
    partial class ProjectedRaises
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
            this.btn_estimateRaise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjRaise = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_estimateRaise
            // 
            this.btn_estimateRaise.Location = new System.Drawing.Point(119, 148);
            this.btn_estimateRaise.Name = "btn_estimateRaise";
            this.btn_estimateRaise.Size = new System.Drawing.Size(75, 23);
            this.btn_estimateRaise.TabIndex = 0;
            this.btn_estimateRaise.Text = "Click Me!";
            this.btn_estimateRaise.UseVisualStyleBackColor = true;
            this.btn_estimateRaise.Click += new System.EventHandler(this.btn_estimateRaise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Salary";
            // 
            // lblProjRaise
            // 
            this.lblProjRaise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjRaise.Location = new System.Drawing.Point(103, 210);
            this.lblProjRaise.Name = "lblProjRaise";
            this.lblProjRaise.Size = new System.Drawing.Size(100, 69);
            this.lblProjRaise.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(177, 86);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 3;
            // 
            // ProjectedRaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblProjRaise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_estimateRaise);
            this.Name = "ProjectedRaises";
            this.Text = "Projected Raises GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_estimateRaise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjRaise;
        private System.Windows.Forms.TextBox txtSalary;
    }
}

