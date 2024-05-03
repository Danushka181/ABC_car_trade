namespace ABC_car_trade.User
{
    partial class UserCarParts
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutCarParts = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchCarParts = new System.Windows.Forms.TextBox();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(814, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search";
            // 
            // flowLayoutCarParts
            // 
            this.flowLayoutCarParts.AutoScroll = true;
            this.flowLayoutCarParts.Location = new System.Drawing.Point(32, 83);
            this.flowLayoutCarParts.Name = "flowLayoutCarParts";
            this.flowLayoutCarParts.Size = new System.Drawing.Size(1076, 480);
            this.flowLayoutCarParts.TabIndex = 17;
            // 
            // SearchCarParts
            // 
            this.SearchCarParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.SearchCarParts.ForeColor = System.Drawing.Color.White;
            this.SearchCarParts.Location = new System.Drawing.Point(894, 27);
            this.SearchCarParts.Name = "SearchCarParts";
            this.SearchCarParts.Size = new System.Drawing.Size(214, 20);
            this.SearchCarParts.TabIndex = 16;
            this.SearchCarParts.TextChanged += new System.EventHandler(this.SearchCarParts_TextChanged);
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(26, 27);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(172, 32);
            this.CarsMainLabel.TabIndex = 15;
            this.CarsMainLabel.Text = "CAR PARTS";
            // 
            // UserCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutCarParts);
            this.Controls.Add(this.SearchCarParts);
            this.Controls.Add(this.CarsMainLabel);
            this.Name = "UserCarParts";
            this.Text = "UserCarParts";
            this.Load += new System.EventHandler(this.UserCarParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCarParts;
        private System.Windows.Forms.TextBox SearchCarParts;
        private System.Windows.Forms.Label CarsMainLabel;
    }
}