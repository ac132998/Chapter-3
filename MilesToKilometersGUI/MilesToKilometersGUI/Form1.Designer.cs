namespace MilesToKilometersGUI
{
    partial class MilesToKilo
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
            this.btn_convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblToKilos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(106, 127);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 41);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert to Kilometers";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(144, 71);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(55, 20);
            this.txtMiles.TabIndex = 2;
            // 
            // lblToKilos
            // 
            this.lblToKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToKilos.Location = new System.Drawing.Point(99, 194);
            this.lblToKilos.Name = "lblToKilos";
            this.lblToKilos.Size = new System.Drawing.Size(100, 68);
            this.lblToKilos.TabIndex = 3;
            // 
            // MilesToKilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 311);
            this.Controls.Add(this.lblToKilos);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_convert);
            this.Name = "MilesToKilo";
            this.Text = "Miles To Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblToKilos;
    }
}

