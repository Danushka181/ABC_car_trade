namespace ABC_car_trade
{
    partial class EditCarForm
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
            this.addImage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldEngineCapacity = new System.Windows.Forms.TextBox();
            this.manufatureYear = new System.Windows.Forms.ComboBox();
            this.fieldFuels = new System.Windows.Forms.ComboBox();
            this.fieldTransmissions = new System.Windows.Forms.ComboBox();
            this.fieldVehicleMake = new System.Windows.Forms.ComboBox();
            this.lblErrorSave = new System.Windows.Forms.Label();
            this.btnCancelSaveCar = new System.Windows.Forms.Button();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.fieldDescriptionLabel = new System.Windows.Forms.Label();
            this.fieldDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fieldMilage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldPrice = new System.Windows.Forms.TextBox();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.addImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImage.ForeColor = System.Drawing.Color.White;
            this.addImage.Location = new System.Drawing.Point(236, 575);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(97, 37);
            this.addImage.TabIndex = 59;
            this.addImage.Text = "Add Image";
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Vehicle Image";
            // 
            // carImage
            // 
            this.carImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carImage.ImageLocation = "";
            this.carImage.Location = new System.Drawing.Point(49, 457);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(284, 155);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carImage.TabIndex = 57;
            this.carImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(459, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Engine Capacity (CC)";
            // 
            // fieldEngineCapacity
            // 
            this.fieldEngineCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldEngineCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldEngineCapacity.ForeColor = System.Drawing.Color.White;
            this.fieldEngineCapacity.Location = new System.Drawing.Point(463, 303);
            this.fieldEngineCapacity.Name = "fieldEngineCapacity";
            this.fieldEngineCapacity.Size = new System.Drawing.Size(186, 26);
            this.fieldEngineCapacity.TabIndex = 55;
            // 
            // manufatureYear
            // 
            this.manufatureYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.manufatureYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufatureYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufatureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufatureYear.ForeColor = System.Drawing.Color.White;
            this.manufatureYear.FormattingEnabled = true;
            this.manufatureYear.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.manufatureYear.Location = new System.Drawing.Point(49, 219);
            this.manufatureYear.Name = "manufatureYear";
            this.manufatureYear.Size = new System.Drawing.Size(284, 28);
            this.manufatureYear.TabIndex = 54;
            this.manufatureYear.Text = "Manufacture Year";
            // 
            // fieldFuels
            // 
            this.fieldFuels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldFuels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fieldFuels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldFuels.ForeColor = System.Drawing.Color.White;
            this.fieldFuels.FormattingEnabled = true;
            this.fieldFuels.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Gas",
            "Electronic",
            "Solar"});
            this.fieldFuels.Location = new System.Drawing.Point(366, 363);
            this.fieldFuels.Name = "fieldFuels";
            this.fieldFuels.Size = new System.Drawing.Size(283, 28);
            this.fieldFuels.TabIndex = 53;
            this.fieldFuels.Text = "Vehicle Fuel Type";
            // 
            // fieldTransmissions
            // 
            this.fieldTransmissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldTransmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fieldTransmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldTransmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldTransmissions.ForeColor = System.Drawing.Color.White;
            this.fieldTransmissions.FormattingEnabled = true;
            this.fieldTransmissions.Items.AddRange(new object[] {
            "Auto",
            "Manuel",
            "Tip Tonic",
            "Paddle Shift",
            "Self Drive"});
            this.fieldTransmissions.Location = new System.Drawing.Point(49, 363);
            this.fieldTransmissions.Name = "fieldTransmissions";
            this.fieldTransmissions.Size = new System.Drawing.Size(284, 28);
            this.fieldTransmissions.TabIndex = 52;
            this.fieldTransmissions.Text = "Transmission Type";
            // 
            // fieldVehicleMake
            // 
            this.fieldVehicleMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldVehicleMake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fieldVehicleMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldVehicleMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldVehicleMake.ForeColor = System.Drawing.Color.White;
            this.fieldVehicleMake.FormattingEnabled = true;
            this.fieldVehicleMake.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Yamaha",
            "Benz",
            "Audi",
            "Jaguar",
            "Roll Roice",
            "Fiat",
            "Hummer",
            "Jeep",
            "Tata",
            "Mahindra",
            "Tesla"});
            this.fieldVehicleMake.Location = new System.Drawing.Point(45, 133);
            this.fieldVehicleMake.Name = "fieldVehicleMake";
            this.fieldVehicleMake.Size = new System.Drawing.Size(288, 28);
            this.fieldVehicleMake.TabIndex = 51;
            this.fieldVehicleMake.Text = "Vehicle Make";
            // 
            // lblErrorSave
            // 
            this.lblErrorSave.AutoSize = true;
            this.lblErrorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSave.ForeColor = System.Drawing.Color.White;
            this.lblErrorSave.Location = new System.Drawing.Point(49, 627);
            this.lblErrorSave.Name = "lblErrorSave";
            this.lblErrorSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblErrorSave.Size = new System.Drawing.Size(0, 23);
            this.lblErrorSave.TabIndex = 50;
            this.lblErrorSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorSave.UseCompatibleTextRendering = true;
            // 
            // btnCancelSaveCar
            // 
            this.btnCancelSaveCar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelSaveCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSaveCar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSaveCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelSaveCar.Location = new System.Drawing.Point(289, 675);
            this.btnCancelSaveCar.Name = "btnCancelSaveCar";
            this.btnCancelSaveCar.Size = new System.Drawing.Size(168, 46);
            this.btnCancelSaveCar.TabIndex = 49;
            this.btnCancelSaveCar.Text = "Cancel";
            this.btnCancelSaveCar.UseVisualStyleBackColor = false;
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnSaveCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.ForeColor = System.Drawing.Color.White;
            this.btnSaveCar.Location = new System.Drawing.Point(481, 675);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(168, 46);
            this.btnSaveCar.TabIndex = 48;
            this.btnSaveCar.Text = "Save Car";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // fieldDescriptionLabel
            // 
            this.fieldDescriptionLabel.AutoSize = true;
            this.fieldDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.fieldDescriptionLabel.Location = new System.Drawing.Point(368, 420);
            this.fieldDescriptionLabel.Name = "fieldDescriptionLabel";
            this.fieldDescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.fieldDescriptionLabel.TabIndex = 47;
            this.fieldDescriptionLabel.Text = "Description";
            // 
            // fieldDescription
            // 
            this.fieldDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDescription.ForeColor = System.Drawing.Color.White;
            this.fieldDescription.Location = new System.Drawing.Point(366, 457);
            this.fieldDescription.Multiline = true;
            this.fieldDescription.Name = "fieldDescription";
            this.fieldDescription.Size = new System.Drawing.Size(283, 155);
            this.fieldDescription.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(192, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Milage";
            // 
            // fieldMilage
            // 
            this.fieldMilage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldMilage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldMilage.ForeColor = System.Drawing.Color.White;
            this.fieldMilage.Location = new System.Drawing.Point(196, 303);
            this.fieldMilage.Name = "fieldMilage";
            this.fieldMilage.Size = new System.Drawing.Size(239, 26);
            this.fieldMilage.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Color";
            // 
            // fieldColor
            // 
            this.fieldColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldColor.ForeColor = System.Drawing.Color.White;
            this.fieldColor.Location = new System.Drawing.Point(49, 303);
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Size = new System.Drawing.Size(124, 26);
            this.fieldColor.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(362, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price";
            // 
            // fieldPrice
            // 
            this.fieldPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPrice.ForeColor = System.Drawing.Color.White;
            this.fieldPrice.Location = new System.Drawing.Point(366, 219);
            this.fieldPrice.Name = "fieldPrice";
            this.fieldPrice.Size = new System.Drawing.Size(283, 26);
            this.fieldPrice.TabIndex = 39;
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(39, 46);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(218, 32);
            this.CarsMainLabel.TabIndex = 38;
            this.CarsMainLabel.Text = "Edit Car Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Model";
            // 
            // fieldModel
            // 
            this.fieldModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldModel.ForeColor = System.Drawing.Color.White;
            this.fieldModel.Location = new System.Drawing.Point(366, 133);
            this.fieldModel.Name = "fieldModel";
            this.fieldModel.Size = new System.Drawing.Size(283, 26);
            this.fieldModel.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Make";
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(689, 766);
            this.ControlBox = false;
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fieldEngineCapacity);
            this.Controls.Add(this.manufatureYear);
            this.Controls.Add(this.fieldFuels);
            this.Controls.Add(this.fieldTransmissions);
            this.Controls.Add(this.fieldVehicleMake);
            this.Controls.Add(this.lblErrorSave);
            this.Controls.Add(this.btnCancelSaveCar);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.fieldDescriptionLabel);
            this.Controls.Add(this.fieldDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fieldMilage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fieldColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldPrice);
            this.Controls.Add(this.CarsMainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldModel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditCarForm";
            this.Text = "Edit Car Details";
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fieldEngineCapacity;
        private System.Windows.Forms.ComboBox manufatureYear;
        private System.Windows.Forms.ComboBox fieldFuels;
        private System.Windows.Forms.ComboBox fieldTransmissions;
        private System.Windows.Forms.ComboBox fieldVehicleMake;
        private System.Windows.Forms.Label lblErrorSave;
        private System.Windows.Forms.Button btnCancelSaveCar;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Label fieldDescriptionLabel;
        private System.Windows.Forms.TextBox fieldDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fieldMilage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldPrice;
        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldModel;
        private System.Windows.Forms.Label label2;
    }
}