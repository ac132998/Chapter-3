namespace EggsInteractiveGUI
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
            this.txtEggs1 = new System.Windows.Forms.TextBox();
            this.txtEggs4 = new System.Windows.Forms.TextBox();
            this.txtEggs5 = new System.Windows.Forms.TextBox();
            this.txtEggs2 = new System.Windows.Forms.TextBox();
            this.txtEggs3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbleggstotal = new System.Windows.Forms.Label();
            this.btn_calculateEggs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEggs1
            // 
            this.txtEggs1.Location = new System.Drawing.Point(55, 108);
            this.txtEggs1.Name = "txtEggs1";
            this.txtEggs1.Size = new System.Drawing.Size(100, 20);
            this.txtEggs1.TabIndex = 0;
            // 
            // txtEggs4
            // 
            this.txtEggs4.Location = new System.Drawing.Point(244, 108);
            this.txtEggs4.Name = "txtEggs4";
            this.txtEggs4.Size = new System.Drawing.Size(100, 20);
            this.txtEggs4.TabIndex = 1;
            // 
            // txtEggs5
            // 
            this.txtEggs5.Location = new System.Drawing.Point(244, 144);
            this.txtEggs5.Name = "txtEggs5";
            this.txtEggs5.Size = new System.Drawing.Size(100, 20);
            this.txtEggs5.TabIndex = 2;
            // 
            // txtEggs2
            // 
            this.txtEggs2.Location = new System.Drawing.Point(55, 144);
            this.txtEggs2.Name = "txtEggs2";
            this.txtEggs2.Size = new System.Drawing.Size(100, 20);
            this.txtEggs2.TabIndex = 3;
            // 
            // txtEggs3
            // 
            this.txtEggs3.Location = new System.Drawing.Point(55, 188);
            this.txtEggs3.Name = "txtEggs3";
            this.txtEggs3.Size = new System.Drawing.Size(100, 20);
            this.txtEggs3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter eggs produced by each chicken";
            // 
            // lbleggstotal
            // 
            this.lbleggstotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbleggstotal.Location = new System.Drawing.Point(110, 303);
            this.lbleggstotal.Name = "lbleggstotal";
            this.lbleggstotal.Size = new System.Drawing.Size(158, 71);
            this.lbleggstotal.TabIndex = 6;
            // 
            // btn_calculateEggs
            // 
            this.btn_calculateEggs.Location = new System.Drawing.Point(132, 248);
            this.btn_calculateEggs.Name = "btn_calculateEggs";
            this.btn_calculateEggs.Size = new System.Drawing.Size(122, 23);
            this.btn_calculateEggs.TabIndex = 7;
            this.btn_calculateEggs.Text = "Click to calculate";
            this.btn_calculateEggs.UseVisualStyleBackColor = true;
            this.btn_calculateEggs.Click += new System.EventHandler(this.btn_calculateEggs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 442);
            this.Controls.Add(this.btn_calculateEggs);
            this.Controls.Add(this.lbleggstotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEggs3);
            this.Controls.Add(this.txtEggs2);
            this.Controls.Add(this.txtEggs5);
            this.Controls.Add(this.txtEggs4);
            this.Controls.Add(this.txtEggs1);
            this.Name = "Form1";
            this.Text = "Eggs Interactive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEggs1;
        private System.Windows.Forms.TextBox txtEggs4;
        private System.Windows.Forms.TextBox txtEggs5;
        private System.Windows.Forms.TextBox txtEggs2;
        private System.Windows.Forms.TextBox txtEggs3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbleggstotal;
        private System.Windows.Forms.Button btn_calculateEggs;
    }
}

