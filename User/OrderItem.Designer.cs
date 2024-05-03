namespace ABC_car_trade.User
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            this.itemStatus = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // itemStatus
            // 
            this.itemStatus.AutoSize = true;
            this.itemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStatus.ForeColor = System.Drawing.Color.White;
            this.itemStatus.Location = new System.Drawing.Point(166, 103);
            this.itemStatus.Name = "itemStatus";
            this.itemStatus.Size = new System.Drawing.Size(51, 20);
            this.itemStatus.TabIndex = 10;
            this.itemStatus.Text = "label2";
            // 
            // itemPrice
            // 
            this.itemPrice.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.White;
            this.itemPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.itemPrice.Location = new System.Drawing.Point(725, 19);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(307, 25);
            this.itemPrice.TabIndex = 9;
            this.itemPrice.Text = "label1";
            this.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSize = true;
            this.itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDesc.ForeColor = System.Drawing.Color.White;
            this.itemDesc.Location = new System.Drawing.Point(166, 55);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(51, 20);
            this.itemDesc.TabIndex = 8;
            this.itemDesc.Text = "label2";
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.White;
            this.itemName.Location = new System.Drawing.Point(164, 13);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(537, 31);
            this.itemName.TabIndex = 7;
            this.itemName.Text = "label1";
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbCarImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCarImage.InitialImage")));
            this.pbCarImage.Location = new System.Drawing.Point(3, 3);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(140, 144);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 6;
            this.pbCarImage.TabStop = false;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.itemStatus);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemDesc);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.pbCarImage);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1058, 150);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemStatus;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label itemDesc;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.PictureBox pbCarImage;
    }
}
