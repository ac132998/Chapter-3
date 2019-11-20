namespace CarRentalInteractiveGUI
{
    partial class CarRentalCalculator
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
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btn_carRentalTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRental = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(190, 98);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 0;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(190, 151);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 1;
            // 
            // btn_carRentalTotal
            // 
            this.btn_carRentalTotal.Location = new System.Drawing.Point(137, 219);
            this.btn_carRentalTotal.Name = "btn_carRentalTotal";
            this.btn_carRentalTotal.Size = new System.Drawing.Size(75, 23);
            this.btn_carRentalTotal.TabIndex = 2;
            this.btn_carRentalTotal.Text = "Click Me!";
            this.btn_carRentalTotal.UseVisualStyleBackColor = true;
            this.btn_carRentalTotal.Click += new System.EventHandler(this.btn_carRentalTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter amount of days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter amount of miles";
            // 
            // lblTotalRental
            // 
            this.lblTotalRental.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRental.Location = new System.Drawing.Point(125, 276);
            this.lblTotalRental.Name = "lblTotalRental";
            this.lblTotalRental.Size = new System.Drawing.Size(100, 74);
            this.lblTotalRental.TabIndex = 5;
            // 
            // CarRentalCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 452);
            this.Controls.Add(this.lblTotalRental);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_carRentalTotal);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtDays);
            this.Name = "CarRentalCalculator";
            this.Text = "Car Rental Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btn_carRentalTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRental;
    }
}

