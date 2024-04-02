namespace ABC_car_trade
{
    partial class UserCars
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
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.flowLayoutCars = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchCars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(25, 31);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(91, 32);
            this.CarsMainLabel.TabIndex = 4;
            this.CarsMainLabel.Text = "CARS";
            // 
            // flowLayoutCars
            // 
            this.flowLayoutCars.AutoScroll = true;
            this.flowLayoutCars.Location = new System.Drawing.Point(31, 87);
            this.flowLayoutCars.Name = "flowLayoutCars";
            this.flowLayoutCars.Size = new System.Drawing.Size(1076, 480);
            this.flowLayoutCars.TabIndex = 8;
            // 
            // SearchCars
            // 
            this.SearchCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.SearchCars.ForeColor = System.Drawing.Color.White;
            this.SearchCars.Location = new System.Drawing.Point(893, 31);
            this.SearchCars.Name = "SearchCars";
            this.SearchCars.Size = new System.Drawing.Size(214, 20);
            this.SearchCars.TabIndex = 6;
            this.SearchCars.TextChanged += new System.EventHandler(this.SearchCars_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(813, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // UserCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutCars);
            this.Controls.Add(this.SearchCars);
            this.Controls.Add(this.CarsMainLabel);
            this.Name = "UserCars";
            this.Text = "UserCars";
            this.Load += new System.EventHandler(this.UserCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCars;
        private System.Windows.Forms.TextBox SearchCars;
        private System.Windows.Forms.Label label2;
    }
}