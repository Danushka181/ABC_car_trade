using ABC_car_trade.Properties;

namespace ABC_car_trade
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnLogoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ABCLogoImage = new System.Windows.Forms.PictureBox();
            this.btnCarsMenuItem = new System.Windows.Forms.Button();
            this.btnCarPartsMenuItem = new System.Windows.Forms.Button();
            this.btnCustomersMenuItem = new System.Windows.Forms.Button();
            this.btnOrdersMenuItem = new System.Windows.Forms.Button();
            this.btnReportsMenuItem = new System.Windows.Forms.Button();
            this.MainChildPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ABCLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogoutBtn
            // 
            this.btnLogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoutBtn.BackgroundImage")));
            this.btnLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutBtn.FlatAppearance.BorderSize = 0;
            this.btnLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutBtn.Location = new System.Drawing.Point(1089, 12);
            this.btnLogoutBtn.Name = "btnLogoutBtn";
            this.btnLogoutBtn.Size = new System.Drawing.Size(90, 31);
            this.btnLogoutBtn.TabIndex = 35;
            this.btnLogoutBtn.UseVisualStyleBackColor = true;
            this.btnLogoutBtn.Click += new System.EventHandler(this.btnLogoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(704, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "You can manage all car parts, cars, orders, customers, and reports using this por" +
    "tal.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ABCLogoImage
            // 
            this.ABCLogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ABCLogoImage.BackgroundImage")));
            this.ABCLogoImage.Location = new System.Drawing.Point(27, 22);
            this.ABCLogoImage.Name = "ABCLogoImage";
            this.ABCLogoImage.Size = new System.Drawing.Size(251, 69);
            this.ABCLogoImage.TabIndex = 9;
            this.ABCLogoImage.TabStop = false;
            // 
            // btnCarsMenuItem
            // 
            this.btnCarsMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCarsMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarsMenuItem.BackgroundImage")));
            this.btnCarsMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarsMenuItem.FlatAppearance.BorderSize = 0;
            this.btnCarsMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarsMenuItem.Location = new System.Drawing.Point(305, 43);
            this.btnCarsMenuItem.Name = "btnCarsMenuItem";
            this.btnCarsMenuItem.Size = new System.Drawing.Size(96, 33);
            this.btnCarsMenuItem.TabIndex = 42;
            this.btnCarsMenuItem.Text = "                       ";
            this.btnCarsMenuItem.UseVisualStyleBackColor = false;
            this.btnCarsMenuItem.Click += new System.EventHandler(this.btnCarsMenuItem_Click);
            // 
            // btnCarPartsMenuItem
            // 
            this.btnCarPartsMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCarPartsMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarPartsMenuItem.BackgroundImage")));
            this.btnCarPartsMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarPartsMenuItem.FlatAppearance.BorderSize = 0;
            this.btnCarPartsMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartsMenuItem.Location = new System.Drawing.Point(426, 43);
            this.btnCarPartsMenuItem.Name = "btnCarPartsMenuItem";
            this.btnCarPartsMenuItem.Size = new System.Drawing.Size(132, 33);
            this.btnCarPartsMenuItem.TabIndex = 43;
            this.btnCarPartsMenuItem.Text = "                       ";
            this.btnCarPartsMenuItem.UseVisualStyleBackColor = false;
            this.btnCarPartsMenuItem.Click += new System.EventHandler(this.btnCarPartsMenuItem_Click);
            // 
            // btnCustomersMenuItem
            // 
            this.btnCustomersMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomersMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomersMenuItem.BackgroundImage")));
            this.btnCustomersMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomersMenuItem.FlatAppearance.BorderSize = 0;
            this.btnCustomersMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomersMenuItem.Location = new System.Drawing.Point(583, 43);
            this.btnCustomersMenuItem.Name = "btnCustomersMenuItem";
            this.btnCustomersMenuItem.Size = new System.Drawing.Size(148, 33);
            this.btnCustomersMenuItem.TabIndex = 44;
            this.btnCustomersMenuItem.Text = "                       ";
            this.btnCustomersMenuItem.UseVisualStyleBackColor = false;
            this.btnCustomersMenuItem.Click += new System.EventHandler(this.btnCustomersMenuItem_Click);
            // 
            // btnOrdersMenuItem
            // 
            this.btnOrdersMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdersMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdersMenuItem.BackgroundImage")));
            this.btnOrdersMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdersMenuItem.FlatAppearance.BorderSize = 0;
            this.btnOrdersMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersMenuItem.Location = new System.Drawing.Point(750, 43);
            this.btnOrdersMenuItem.Name = "btnOrdersMenuItem";
            this.btnOrdersMenuItem.Size = new System.Drawing.Size(112, 33);
            this.btnOrdersMenuItem.TabIndex = 45;
            this.btnOrdersMenuItem.Text = "                       ";
            this.btnOrdersMenuItem.UseVisualStyleBackColor = false;
            this.btnOrdersMenuItem.Click += new System.EventHandler(this.btnOrdersMenuItem_Click);
            // 
            // btnReportsMenuItem
            // 
            this.btnReportsMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.btnReportsMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportsMenuItem.BackgroundImage")));
            this.btnReportsMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportsMenuItem.FlatAppearance.BorderSize = 0;
            this.btnReportsMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsMenuItem.Location = new System.Drawing.Point(886, 43);
            this.btnReportsMenuItem.Name = "btnReportsMenuItem";
            this.btnReportsMenuItem.Size = new System.Drawing.Size(118, 33);
            this.btnReportsMenuItem.TabIndex = 46;
            this.btnReportsMenuItem.Text = "                       ";
            this.btnReportsMenuItem.UseVisualStyleBackColor = false;
            this.btnReportsMenuItem.Click += new System.EventHandler(this.btnReportsMenuItem_Click);
            // 
            // MainChildPanel
            // 
            this.MainChildPanel.Location = new System.Drawing.Point(31, 150);
            this.MainChildPanel.Name = "MainChildPanel";
            this.MainChildPanel.Size = new System.Drawing.Size(1150, 630);
            this.MainChildPanel.TabIndex = 47;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1207, 808);
            this.Controls.Add(this.MainChildPanel);
            this.Controls.Add(this.btnReportsMenuItem);
            this.Controls.Add(this.btnOrdersMenuItem);
            this.Controls.Add(this.btnCustomersMenuItem);
            this.Controls.Add(this.btnCarPartsMenuItem);
            this.Controls.Add(this.btnCarsMenuItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogoutBtn);
            this.Controls.Add(this.ABCLogoImage);
            this.MaximumSize = new System.Drawing.Size(1223, 847);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1223, 847);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Admin Dashboard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ABCLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ABCLogoImage;
        private System.Windows.Forms.Button btnCarsMenuItem;
        private System.Windows.Forms.Button btnCarPartsMenuItem;
        private System.Windows.Forms.Button btnCustomersMenuItem;
        private System.Windows.Forms.Button btnOrdersMenuItem;
        private System.Windows.Forms.Button btnReportsMenuItem;
        private System.Windows.Forms.Panel MainChildPanel;
    }
}