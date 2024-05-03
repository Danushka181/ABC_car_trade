namespace ABC_car_trade.User
{
    partial class OrderCars
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
            this.quantityBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shippingAddress = new System.Windows.Forms.RichTextBox();
            this.btnOrderItem = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quantityBox
            // 
            this.quantityBox.FormattingEnabled = true;
            this.quantityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantityBox.Location = new System.Drawing.Point(37, 66);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(178, 21);
            this.quantityBox.TabIndex = 0;
            this.quantityBox.SelectedIndexChanged += new System.EventHandler(this.quantityBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping Address";
            // 
            // shippingAddress
            // 
            this.shippingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingAddress.Location = new System.Drawing.Point(37, 161);
            this.shippingAddress.Name = "shippingAddress";
            this.shippingAddress.Size = new System.Drawing.Size(329, 96);
            this.shippingAddress.TabIndex = 3;
            this.shippingAddress.Text = "";
            // 
            // btnOrderItem
            // 
            this.btnOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItem.ForeColor = System.Drawing.Color.White;
            this.btnOrderItem.Location = new System.Drawing.Point(34, 434);
            this.btnOrderItem.Name = "btnOrderItem";
            this.btnOrderItem.Size = new System.Drawing.Size(181, 65);
            this.btnOrderItem.TabIndex = 4;
            this.btnOrderItem.Text = "Confirm Order";
            this.btnOrderItem.UseVisualStyleBackColor = false;
            this.btnOrderItem.Click += new System.EventHandler(this.btnOrderItem_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(130, 295);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(92, 31);
            this.totalPrice.TabIndex = 5;
            this.totalPrice.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // orderMessage
            // 
            this.orderMessage.AutoSize = true;
            this.orderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMessage.Location = new System.Drawing.Point(37, 385);
            this.orderMessage.Name = "orderMessage";
            this.orderMessage.Size = new System.Drawing.Size(0, 25);
            this.orderMessage.TabIndex = 7;
            // 
            // OrderCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 525);
            this.Controls.Add(this.orderMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.btnOrderItem);
            this.Controls.Add(this.shippingAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Car";
            this.Load += new System.EventHandler(this.OrderCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox quantityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox shippingAddress;
        private System.Windows.Forms.Button btnOrderItem;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderMessage;
    }
}