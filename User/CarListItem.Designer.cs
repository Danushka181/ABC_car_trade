namespace ABC_car_trade.User
{
    partial class CarListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarListItem));
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblCarDesc = new System.Windows.Forms.Label();
            this.btnOrderItem = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMilage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbCarImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCarImage.InitialImage")));
            this.pbCarImage.Location = new System.Drawing.Point(3, 3);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(140, 144);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 0;
            this.pbCarImage.TabStop = false;
            // 
            // lblCarName
            // 
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.White;
            this.lblCarName.Location = new System.Drawing.Point(164, 13);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(537, 31);
            this.lblCarName.TabIndex = 1;
            this.lblCarName.Text = "label1";
            // 
            // lblCarDesc
            // 
            this.lblCarDesc.AutoSize = true;
            this.lblCarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDesc.ForeColor = System.Drawing.Color.White;
            this.lblCarDesc.Location = new System.Drawing.Point(166, 55);
            this.lblCarDesc.Name = "lblCarDesc";
            this.lblCarDesc.Size = new System.Drawing.Size(51, 20);
            this.lblCarDesc.TabIndex = 2;
            this.lblCarDesc.Text = "label2";
            // 
            // btnOrderItem
            // 
            this.btnOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItem.ForeColor = System.Drawing.Color.White;
            this.btnOrderItem.Location = new System.Drawing.Point(899, 87);
            this.btnOrderItem.Name = "btnOrderItem";
            this.btnOrderItem.Size = new System.Drawing.Size(133, 52);
            this.btnOrderItem.TabIndex = 3;
            this.btnOrderItem.Text = "Order";
            this.btnOrderItem.UseVisualStyleBackColor = false;
            this.btnOrderItem.Click += new System.EventHandler(this.btnOrderItem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(725, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(307, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "label1";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMilage
            // 
            this.lblMilage.AutoSize = true;
            this.lblMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilage.ForeColor = System.Drawing.Color.White;
            this.lblMilage.Location = new System.Drawing.Point(166, 103);
            this.lblMilage.Name = "lblMilage";
            this.lblMilage.Size = new System.Drawing.Size(51, 20);
            this.lblMilage.TabIndex = 5;
            this.lblMilage.Text = "label2";
            // 
            // CarListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.lblMilage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnOrderItem);
            this.Controls.Add(this.lblCarDesc);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.pbCarImage);
            this.Name = "CarListItem";
            this.Size = new System.Drawing.Size(1075, 150);
            this.Load += new System.EventHandler(this.CarListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCarDesc;
        private System.Windows.Forms.Button btnOrderItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMilage;
    }
}
