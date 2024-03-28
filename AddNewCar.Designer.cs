namespace ABC_car_trade
{
    partial class AddNewCar
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
            this.fieldModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldCalenderYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fieldMilage = new System.Windows.Forms.TextBox();
            this.fieldDescriptionLabel = new System.Windows.Forms.Label();
            this.fieldDescription = new System.Windows.Forms.TextBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnCancelSaveCar = new System.Windows.Forms.Button();
            this.lblErrorSave = new System.Windows.Forms.Label();
            this.fieldVehicleMake = new System.Windows.Forms.ComboBox();
            this.fieldTransmissions = new System.Windows.Forms.ComboBox();
            this.fieldFuels = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Make";
            // 
            // fieldModel
            // 
            this.fieldModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldModel.ForeColor = System.Drawing.Color.White;
            this.fieldModel.Location = new System.Drawing.Point(363, 110);
            this.fieldModel.Name = "fieldModel";
            this.fieldModel.Size = new System.Drawing.Size(283, 26);
            this.fieldModel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model";
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(36, 23);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(208, 32);
            this.CarsMainLabel.TabIndex = 8;
            this.CarsMainLabel.Text = "Add a New Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(359, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // fieldPrice
            // 
            this.fieldPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPrice.ForeColor = System.Drawing.Color.White;
            this.fieldPrice.Location = new System.Drawing.Point(363, 196);
            this.fieldPrice.Name = "fieldPrice";
            this.fieldPrice.Size = new System.Drawing.Size(283, 26);
            this.fieldPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year";
            // 
            // fieldCalenderYear
            // 
            this.fieldCalenderYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldCalenderYear.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fieldCalenderYear.CustomFormat = "yyyy";
            this.fieldCalenderYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldCalenderYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fieldCalenderYear.Location = new System.Drawing.Point(42, 196);
            this.fieldCalenderYear.MaxDate = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            this.fieldCalenderYear.Name = "fieldCalenderYear";
            this.fieldCalenderYear.Size = new System.Drawing.Size(288, 26);
            this.fieldCalenderYear.TabIndex = 12;
            this.fieldCalenderYear.Value = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Color";
            // 
            // fieldColor
            // 
            this.fieldColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldColor.ForeColor = System.Drawing.Color.White;
            this.fieldColor.Location = new System.Drawing.Point(46, 280);
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Size = new System.Drawing.Size(283, 26);
            this.fieldColor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Milage";
            // 
            // fieldMilage
            // 
            this.fieldMilage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldMilage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldMilage.ForeColor = System.Drawing.Color.White;
            this.fieldMilage.Location = new System.Drawing.Point(363, 280);
            this.fieldMilage.Name = "fieldMilage";
            this.fieldMilage.Size = new System.Drawing.Size(283, 26);
            this.fieldMilage.TabIndex = 15;
            // 
            // fieldDescriptionLabel
            // 
            this.fieldDescriptionLabel.AutoSize = true;
            this.fieldDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.fieldDescriptionLabel.Location = new System.Drawing.Point(42, 395);
            this.fieldDescriptionLabel.Name = "fieldDescriptionLabel";
            this.fieldDescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.fieldDescriptionLabel.TabIndex = 22;
            this.fieldDescriptionLabel.Text = "Description";
            // 
            // fieldDescription
            // 
            this.fieldDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.fieldDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDescription.ForeColor = System.Drawing.Color.White;
            this.fieldDescription.Location = new System.Drawing.Point(46, 428);
            this.fieldDescription.Multiline = true;
            this.fieldDescription.Name = "fieldDescription";
            this.fieldDescription.Size = new System.Drawing.Size(600, 75);
            this.fieldDescription.TabIndex = 21;
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnSaveCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.ForeColor = System.Drawing.Color.White;
            this.btnSaveCar.Location = new System.Drawing.Point(478, 566);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(168, 46);
            this.btnSaveCar.TabIndex = 23;
            this.btnSaveCar.Text = "Save Car";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnCancelSaveCar
            // 
            this.btnCancelSaveCar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelSaveCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSaveCar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSaveCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelSaveCar.Location = new System.Drawing.Point(286, 566);
            this.btnCancelSaveCar.Name = "btnCancelSaveCar";
            this.btnCancelSaveCar.Size = new System.Drawing.Size(168, 46);
            this.btnCancelSaveCar.TabIndex = 24;
            this.btnCancelSaveCar.Text = "Cancel";
            this.btnCancelSaveCar.UseVisualStyleBackColor = false;
            this.btnCancelSaveCar.Click += new System.EventHandler(this.btnCancelSaveCar_Click);
            // 
            // lblErrorSave
            // 
            this.lblErrorSave.AutoSize = true;
            this.lblErrorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSave.ForeColor = System.Drawing.Color.White;
            this.lblErrorSave.Location = new System.Drawing.Point(46, 518);
            this.lblErrorSave.Name = "lblErrorSave";
            this.lblErrorSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblErrorSave.Size = new System.Drawing.Size(0, 23);
            this.lblErrorSave.TabIndex = 25;
            this.lblErrorSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrorSave.UseCompatibleTextRendering = true;
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
            this.fieldVehicleMake.Location = new System.Drawing.Point(42, 110);
            this.fieldVehicleMake.Name = "fieldVehicleMake";
            this.fieldVehicleMake.Size = new System.Drawing.Size(288, 28);
            this.fieldVehicleMake.TabIndex = 26;
            this.fieldVehicleMake.Text = "Vehicle Make";
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
            this.fieldTransmissions.Location = new System.Drawing.Point(46, 340);
            this.fieldTransmissions.Name = "fieldTransmissions";
            this.fieldTransmissions.Size = new System.Drawing.Size(284, 28);
            this.fieldTransmissions.TabIndex = 27;
            this.fieldTransmissions.Text = "Transmission Type";
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
            this.fieldFuels.Location = new System.Drawing.Point(363, 340);
            this.fieldFuels.Name = "fieldFuels";
            this.fieldFuels.Size = new System.Drawing.Size(283, 28);
            this.fieldFuels.TabIndex = 28;
            this.fieldFuels.Text = "Vehicle Fuel Type";
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.CancelButton = this.btnCancelSaveCar;
            this.ClientSize = new System.Drawing.Size(689, 657);
            this.ControlBox = false;
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
            this.Controls.Add(this.fieldCalenderYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldPrice);
            this.Controls.Add(this.CarsMainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldModel);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCar";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Car";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fieldCalenderYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fieldMilage;
        private System.Windows.Forms.Label fieldDescriptionLabel;
        private System.Windows.Forms.TextBox fieldDescription;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnCancelSaveCar;
        private System.Windows.Forms.Label lblErrorSave;
        private System.Windows.Forms.ComboBox fieldVehicleMake;
        private System.Windows.Forms.ComboBox fieldTransmissions;
        private System.Windows.Forms.ComboBox fieldFuels;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}