namespace ABC_car_trade.User
{
    partial class UserOrderStatus
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
            this.flowLayoutOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutOrders
            // 
            this.flowLayoutOrders.AutoScroll = true;
            this.flowLayoutOrders.Location = new System.Drawing.Point(32, 83);
            this.flowLayoutOrders.Name = "flowLayoutOrders";
            this.flowLayoutOrders.Size = new System.Drawing.Size(1076, 480);
            this.flowLayoutOrders.TabIndex = 10;
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(26, 27);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(178, 32);
            this.CarsMainLabel.TabIndex = 9;
            this.CarsMainLabel.Text = "MY ORDERS";
            // 
            // UserOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.flowLayoutOrders);
            this.Controls.Add(this.CarsMainLabel);
            this.Name = "UserOrderStatus";
            this.Text = "UserOrderStatus";
            this.Load += new System.EventHandler(this.UserOrderStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrders;
        private System.Windows.Forms.Label CarsMainLabel;
    }
}